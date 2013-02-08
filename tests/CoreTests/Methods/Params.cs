using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Methods
{
    [JsType(JsMode.Clr)]
    class Params
    {
        void alert(object obj)
        {
        }
        void foo()
        {
            if (CallMethodWithManyParams() != 0) 
                alert("params error"); //CRASHES
            if (CallMethodWithManyParams("aa") != 1) 
                alert("params error");
            if (CallMethodWithManyParams("a", "b") != 2) 
                alert("params error");
            if (CallMethodWithManyParams("a", "b", 1230) != 3) 
                alert("params error");
            if (CallMethodWithManyParams("a", "b", 1230, "sss") != 4) 
                alert("params error");

        }

        [JsMethod(NativeParams=false)]
        private static int CallMethodWithManyParams(params object[] arr)
        {
            return arr.Length;
        }
    }
}
