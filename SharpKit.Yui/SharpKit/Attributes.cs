using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using Y_;
[assembly: JsType(JsMode.Prototype)]
[assembly:JsMethod(TargetType=typeof(YUI), TargetMethod=".ctor", OmitNewOperator=true)]

namespace Y_
{
    [JsType(JsMode.Global, Export=false)]
    public partial class YUIContext
    {
        [JsProperty(Name="Y", NativeField=true)]
        public static YUI Current { get; set; }
    }
    partial class YUI : YUIContext
    {
        public YUI use(object modules, JsAction<YUI> callback) { return null; }

        public void use(string[] p, JsAction<YUI> jsAction)
        {
            throw new NotImplementedException();
        }
    }
}