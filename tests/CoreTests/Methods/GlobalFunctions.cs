using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Methods
{
    [JsType(JsMode.Prototype)]
    class GlobalFunctions2
    {
        void foo()
        {
            var x = GlobalFunctions.Name;
        }
    }
    [JsType(JsMode.Prototype)]
    class GlobalFunctions
    {
        [JsMethod(Global=true)]
        static void MyFunc()
        {

        }
        public static string Name
        {
            [JsMethod(Global = true)]
            get
            {
                return "asdasd";
            }
        }
    }
}
