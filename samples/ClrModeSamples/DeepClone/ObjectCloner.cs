using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using System.Collections;

namespace ClrModeSamples.DeepClone
{
    [JsType(JsMode.Clr)]
    public class ObjectCloner
    {
        public object Clone(object obj)
        {
            return Clone(obj, new CloneContext());
        }
        [JsMethod(IgnoreGenericArguments=true)]
        public static T CloneObject<T>(T obj)
        {
            return new ObjectCloner().Clone(obj.As<object>()).As<T>();
        }
        object Clone(object obj, CloneContext context)
        {
            var type = JsContext.JsTypeOf(obj);
            if (type == JsTypes.@object)
            {
                object obj2;
                if (context.Mappings.ContainsKey(obj))
                    obj2 = context.Mappings[obj];
                else
                    obj2 = CloneObject(obj, context);
                return obj2;
            }
            else
            {
                return obj;
            }

        }

        private object CloneObject(object obj, CloneContext context)
        {
            if (obj.instanceof<JsArray>())
            {
                var arr2 = new JsArray();
                context.Mappings[obj] = arr2;

                foreach (var item in arr2)
                    arr2.push(Clone(item, context));
                return arr2;
            }
            else if (obj is IList)
            {
                var list = obj.As<IList>();
                var list2 = Activator.CreateInstance(obj.GetType()).As<IList>();
                context.Mappings[obj] = list2;
                foreach (var item in list)
                    list2.Add(Clone(item, context));
                return list2;
            }
            else if (obj.instanceof<JsDate>())
            {
                return new JsDate(obj.As<JsDate>().valueOf());
            }
            else
            {
                var obj2 = Activator.CreateInstance(obj.GetType());
                context.Mappings[obj] = obj2;
                var json = obj.As<JsObject>();
                var json2 = obj2.As<JsObject>();
                foreach (var p in json)
                {
                    json2[p] = Clone(json[p], context);
                }
                return obj2;
            }
        }
    }


    [JsType(JsMode.Clr)]
    class CloneContext
    {
        public CloneContext()
        {
            Mappings = new Dictionary<object, object>();
        }
        public Dictionary<object, object> Mappings { get; set; }
    }
}