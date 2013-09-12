using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests
{
    [JsType(JsMode.Prototype)]
    static class ExtensionMethods
    {
        public static void ExtensionMethod(this Test x)
        {
        }
        static void foo()
        {
            var xx = new Test();
            Action action = xx.ExtensionMethod;
            Action action2 = xx.InstanceMethod;

            List<Test> list = new List<Test>();
            list.ForEach(ExtensionMethod);
            xx.ExtensionMethod();
            ExtensionMethod(xx);

        }
    }

    class Test
    {
        public void InstanceMethod()
        {
        }
    }

}
