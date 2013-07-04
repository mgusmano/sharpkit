using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.OperatorOverloads
{
    [JsType(JsMode.Prototype)]
    class Test
    {
        void foo()
        {
            var x = new BigNumber();
            var y = new BigNumber();
            x += y;
            var z = x + y;
            var a = MyBigNumber + x;
            MyBigNumber += a;
            
        }
        [JsProperty(NativeField=false)]
        public BigNumber MyBigNumber { get; set; }
    }
    [JsType(JsMode.Prototype)]
    class BigNumber
    {
        public static BigNumber operator +(BigNumber x, BigNumber y)
        {
            return new BigNumber();
        }
    }
}
