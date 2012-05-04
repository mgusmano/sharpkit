using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using YUI_;
[assembly: JsType(JsMode.Prototype)]
[assembly:JsMethod(TargetType=typeof(YUI), TargetMethod=".ctor", OmitNewOperator=true)]

namespace YUI_
{
    partial class YUI
    {
        public YUI use(object modules, JsAction<YUI> callback) { return null; }

    }
}