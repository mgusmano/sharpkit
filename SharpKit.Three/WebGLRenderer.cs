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
    public class WebGLRenderer
    {
        public WebGLRenderer() { }
        public WebGLRenderer(WebGLRendererOptions parameters) { }

        //todo add all public params
        public HtmlElement domElement { get; set; }

        //todo add all methods
        public void setSize(JsNumber width, JsNumber height) { }

        public void render(Scene scene, Camera camera) { }
        public void render(Scene scene, Camera camera, WebGLRenderTarget renderTarget, JsBoolean forceClear) { }
    }
}