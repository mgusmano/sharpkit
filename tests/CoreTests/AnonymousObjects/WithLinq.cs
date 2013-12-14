using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.AnonymousObjects
{
    [JsType(JsMode.Clr)]
    public class TestClasses
    {
        public TestClasses()
        {
            var result = new[] { "Hello" }
                .Select(x => new { Greeting = x })
                .Select(x => x.Greeting);
        }
    }
}
