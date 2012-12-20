using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs
{
    public static partial class console
    {
        public static void log(params object[] obj) { }
        public static void log(JsString data) { }
    }
}
