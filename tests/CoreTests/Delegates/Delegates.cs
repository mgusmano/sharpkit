using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Delegates
{
    [JsType(JsMode.Prototype, ForceDelegatesAsNativeFunctions=true)]
    class Delegates
    {
        void foo()
        {
            Action x = foo;
        }
    }


    public delegate string SomeDelegate();
    [JsType(JsMode.Prototype)]
    public class Class1
    {
        public Class1() { }

        public static SomeDelegate DelegateProp = delegate()
        {
            return "test";
        };
        public  SomeDelegate DelegateProp2 = delegate()
        {
            return "test";
        };
    }



    [JsType(JsMode.Clr)]
    public class Circle<T>
    {
        public Circle(Func<T, T, int> func)
        {
        }
    }

    [JsType(JsMode.Clr)]
    public class Boxes
    {
        Circle<int> circle = new Circle<int>((a, b) => a + b);

        public Boxes()
        {
        }
    }


}
