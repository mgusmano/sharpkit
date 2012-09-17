using System;
using System.Collections.Generic;
using System.Linq;
using SharpKit.JavaScript;

namespace SharpKitWebApp5
{
    [JsType]
    public class Class5
    {
        void foo()
        {
            foreach (var match in new JsRegExp(@"expression...").exec("sdf")) 
            {
            }
        }
    }
}