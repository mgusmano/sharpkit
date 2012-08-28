using System;
using System.Collections.Generic;
using System.Linq;

using SharpKit.JavaScript;

#if HTML4
using SharpKit.Html4;
#else
using SharpKit.Html;
#endif

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class WebGLRenderTarget
    {
        public WebGLRenderTarget(JsNumber width, JsNumber height, WebGLRenderTargetOptions options) { }

        //todo add all properties
        public JsBoolean generateMipmaps { get; set; }


        //todo add all methods
    }
}