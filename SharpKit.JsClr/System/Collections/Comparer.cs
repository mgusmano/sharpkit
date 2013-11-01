using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SharpKit.JavaScript.Private
{

    [JsType(JsMode.Clr, Name = "System.Collections.Comparer", Filename = "~/Internal/Core.js")]
    public abstract class JsImplComparer : IComparer
    {
        public abstract int Compare(object x, object y);

        private static JsImplComparer _default;
        public static JsImplComparer Default
        {
            get
            {
                if (_default == null) _default = new JsImplGemericComparer();
                return _default;
            }
        }

        [JsType(JsMode.Clr, Filename = "~/Internal/Core.js")]
        private class JsImplGemericComparer : JsImplComparer
        {
            public override int Compare(object x, object y)
            {
                return x.As<IComparable>().CompareTo(y);
            }
        }

    }

}
