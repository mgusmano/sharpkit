using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.LinqQueries
{
    [JsType(JsMode.Prototype)]
    class LinqQueries
    {
        void foo()
        {
            string[] list = new[] { "a", "b", "c" };
            var q =
                from sentence in list
                let words = sentence.Split(' ')
                from word in words
                let w = word.ToLower()
                where w.StartsWith("a")
                select word;
        }
    }
}
