using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Methods
{

    [JsType(JsMode.Clr)]
    class DelegateTest
    {

        public void main() {

            func1((JsAction)null);
            func1((JsAction<string>)null);

            func2((JsAction<string>)null);
            func2((JsAction<int>)null);

            func3((Action)null);
            func3((Action<string>)null);

            func4((Action<string>)null);
            func4((Action<int>)null);
        }

        public void func1(JsAction callback)
        {
        }

        public void func1(JsAction<string> callback)
        {
        }

        public void func2(JsAction<string> callback)
        {
        }

        public void func2(JsAction<int> callback)
        {
        }

        public void func3(Action callback)
        {
        }

        public void func3(Action<string> callback)
        {
        }

        public void func4(Action<string> callback)
        {
        }

        public void func4(Action<int> callback)
        {
        }

    }
}
