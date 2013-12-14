using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.AnonymousObjects
{

    [JsType(JsMode.Prototype, NativeJsons = true)]
    public class NativeJsons
    {
        public void F()
        {
            var x = new { a = "b" };
            var a = x.a;
        }
    }
    [JsType(JsMode.Prototype)]//in clr mode, add this: NativeJsons=true
    class AnonymousObjects
    {
        void foo()
        {
            var json = new
            {
                XePatientReminder = new
                {
                    BypassAccountIDs = true
                }
            };
        }
    }
}
