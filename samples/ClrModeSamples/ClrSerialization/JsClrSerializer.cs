using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Web.Script.Serialization;

namespace ClrModeSamples.ClrSerialization
{
    public class JsClrSerializer
    {
        JavaScriptSerializer JavaScriptSerializer = new JavaScriptSerializer();
        public TextWriter Writer { get; set; }
        Dictionary<object, string> Refs = new Dictionary<object, string>();
        int RefIndex;



        public string Serialize(object obj)
        {
            if (obj == null)
                return "null";

            var type = obj.GetType();
            var typeCode = Type.GetTypeCode(type);
            if (typeCode == TypeCode.Object)
            {
                string objRef;
                if (Refs.TryGetValue(obj, out objRef))
                    return objRef;
                RefIndex++;
                objRef = "obj" + RefIndex;
                var typeGenericArgs = String.Join(",", type.GetGenericArguments().Select(t => Serialize(GetJsTypeName(t))).ToArray());
                Writer.WriteLine("var {0} = new {1}.ctor({2});", objRef, GetJsTypeName(type), typeGenericArgs);
                if (obj is IList)
                {
                    var list = obj as IList;
                    foreach (var item in list)
                    {
                        var itemRef = Serialize(item);
                        Writer.WriteLine("{0}.Add({1});", objRef, itemRef);
                    }
                }
                else
                {
                    var props = type.GetProperties();
                    foreach (var pe in props)
                    {
                        var value = pe.GetValue(obj, null);
                        if (value == null)
                            continue;
                        var valueRef = Serialize(value);
                        Writer.WriteLine("{0}.set_{1}({2});", objRef, pe.Name, valueRef);
                    }
                }
                return objRef;
            }
            else
            {
                return JavaScriptSerializer.Serialize(obj);
            }
        }

        string GetJsTypeName(Type type)
        {
            if (type.IsGenericType)
            {
                return type.FullName.Replace("`", "$").Substring(0, type.FullName.IndexOf("["));
            }
            else
            {
                return type.FullName;
            }
        }

    }
}