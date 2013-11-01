using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpKit.JavaScript.Private
{

    [JsType(JsMode.Clr, Name = "System.Collections.Generic.Comparer$1", Filename = "~/Internal/Core.js")]
    public abstract class JsImplComparer<T> : IComparer<T>
    {
        public abstract int Compare(T x, T y);

        //private static JsObject<JsImplComparer<T>> _default = new JsObject<JsImplComparer<T>>();
        //public static JsImplComparer<T> _default;
        public static JsImplComparer<T> Default
        {
            get
            {
                //TASK: specialized comparers?

                //var typeName = typeof(T).ToString();
                //var cmp = _default[typeName];
                //if (cmp == JsContext.undefined) { 
                //    //
                //}

                //if (_default == null)
                //{
                //    //_default=new 
                //}
                //return _default;

                return new JsImplGemericComparer();
                //if (_default == null) _default = new JsImplGemericComparer();
                //return _default;
            }
        }

        [JsType(JsMode.Clr, Filename = "~/Internal/Core.js")]
        private class JsImplGemericComparer : JsImplComparer<T>
        {
            public override int Compare(T x, T y)
            {
                return x.As<IComparable<T>>().CompareTo(y);
            }
        }

    }

}
