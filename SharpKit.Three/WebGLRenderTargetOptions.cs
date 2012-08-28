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
    [JsType(JsMode.Json, Export = false)]
    public class WebGLRenderTargetOptions
    {
        //todo add all other properties
        public JsBoolean generateMipmaps { get; set; }
    }
}