using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.UsingResources
{
    [JsType(JsMode.Prototype)]
    class UsingResources
    {
        void Foo()
        {
            using (Moo())
            {
            }
            using (Moo())
                Console.WriteLine();
            using (IDisposable x = Moo(), y = Bar())
            {
            }
        }

        private IDisposable Moo()
        {
            throw new NotImplementedException();
        }

        private IDisposable Bar()
        {
            throw new NotImplementedException();
        }
    }
}
