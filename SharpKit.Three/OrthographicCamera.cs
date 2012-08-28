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
    [JsType(JsMode.Prototype, Export=false)] 
    public class OrthographicCamera : Camera
    {
        public OrthographicCamera(JsNumber left, JsNumber right, JsNumber top, JsNumber bottom, JsNumber near, JsNumber far){}
        public JsNumber left {get; set;}
        public JsNumber right {get; set;}
        public JsNumber top {get; set;}
        public JsNumber bottom {get; set;}
        public JsNumber near {get; set;}
        public JsNumber far {get; set;}
        public void updateProjectionMatrix() {} 
    }
}