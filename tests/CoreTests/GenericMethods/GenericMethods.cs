using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.GenericMethods
{
    [JsType(JsMode.Prototype, IgnoreGenericMethodArguments=false)]
    class GenericMethods
    {
        void Foo()
        {
            var x = Create<GenericMethods>();
        }
        T Create<T>() where T : new()
        {
            return new T();
        }

    }
}
