using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace CoreTests.Constants
{

    [JsType(JsMode.Prototype)]
    class Constants
    {
        public static void MyMethod()
        {
            new MyPageClient { Type = MyPageClient.TypeName };
        }

    }
    [JsType(JsMode.Json)]
    public class MyPageClient
    {
        public string Type { get; set; }
        public const string TypeName = "ggg";
    }
}
