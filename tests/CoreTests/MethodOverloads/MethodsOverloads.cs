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

            Func1((JsAction)null);
            Func1((JsAction<string>)null);

            Func2((JsAction<string>)null);
            Func2((JsAction<int>)null);

            Func3((Action)null);
            Func3((Action<string>)null);

            Func4((Action<string>)null);
            Func4((Action<int>)null);
        }

        public void Func1(JsAction callback)
        {
        }

        public void Func1(JsAction<string> callback)
        {
        }

        public void Func2(JsAction<string> callback)
        {
        }

        public void Func2(JsAction<int> callback)
        {
        }

        public void Func3(Action callback)
        {
        }

        public void Func3(Action<string> callback)
        {
        }

        public void Func4(Action<string> callback)
        {
        }

        public void Func4(Action<int> callback)
        {
        }

    }
}
