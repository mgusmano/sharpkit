using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.GenericsInheritance
{
    [JsType(JsMode.Clr)]
    class Class1<T>
    {
        public virtual void Hello(List<T> prm)
        {
        }
        public virtual void Hello(List<T> prm, List<T> prm2)
        {
        }
    }

    [JsType(JsMode.Clr)]
    class Class2 : Class1<string>
    {
        public override void Hello(List<string> prm)
        {
            base.Hello(prm);
        }

        public override void Hello(List<string> prm, List<string> prm2)
        {
            base.Hello(prm, prm2);
        }
    }
}
