using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;

[JsType(JsMode.Json)]
class MyResult
{
    public string OriginalValue { get; set; }
    public string NewValue { get; set; }
}
