using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SharpKit.Html4;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Json, Export = false)]
    public class WebGLRendererOptions
    {

        //todo: add all other params
        public JsNumber maxLights { get; set; }
    }
}