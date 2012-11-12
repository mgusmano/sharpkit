using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Methods
{

    [JsType(JsMode.Clr)]
    class MethodOverloads
    {

        public void Main()
        {
            JsAct(Test);
            JsAct(TestString);
            JsAct(TestInt);

            Act(Test);
            Act(TestString);
            Act(TestInt);

            //DoCreate<object>(Create<object>);

        }


        void Test()
        {
        }
        void TestString(string s)
        {
        }
        void TestInt(int x)
        {
        }

        public void JsAct(JsAction callback)
        {
        }

        public void JsAct(JsAction<string> callback)
        {
        }

        public void JsAct(JsAction<int> callback)
        {
        }


        public void Act(Action callback)
        {
        }

        public void Act(Action<string> callback)
        {
        }


        public void Act(Action<int> callback)
        {
        }

    }

    [JsType(JsMode.Clr)]
    public class GenericConstructorCall
    {
        public void main()
        {
            var foo = new GenericConstructor<int, string>(5);
            var bar = new GenericConstructor<int, string>("test");

            var kv = new KeyValuePair<int, string>(5, "");
        }
    }

    [JsType(JsMode.Clr)]
    public class GenericConstructor<A, B>
    {

        public GenericConstructor(A arg)
        {
        }

        public GenericConstructor(B arg)
        {
        }

    }

}
