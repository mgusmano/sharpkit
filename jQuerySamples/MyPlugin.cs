using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.jQuery;
using SharpKit.JavaScript;

namespace jQuerySamples
{
    [JsType(JsMode.Prototype, 
        Name = "jQuery", 
        PrototypeName="fn", 
        OmitInheritance = true, 
        OmitDefaultConstructor = true, 
        NativeArrayEnumerator = true, 
        NativeEnumerator = false)]
    class MyPlugin : jQuery
    {
        public jQuery myPlugin()
        {
            this.append("Hello world, this is my SharpKit jQuery plugin!<br/>");
            return this;
        }
    }

    [JsType(JsMode.Global, Export=false)]
    class jQueryPlugin
    {
        public static jQuery @this { get; set; }
    }

    [JsType(JsMode.Prototype, Export=false)]
    public static class MyPluginExtension
    {
        [JsMethod(ExtensionImplementedInInstance=true)]
        public static jQuery myPlugin(this jQuery j) { return null; }
    }
}