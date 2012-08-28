using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html4;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class PerspectiveCamera : Camera
    {
        public PerspectiveCamera(JsNumber fov, JsNumber aspect, JsNumber near, JsNumber far) { }

        public void setLens(JsNumber focalLength, JsNumber frameHeight) { }
        public void setViewOffset(JsNumber fullWidth, JsNumber fullHeight, JsNumber x, JsNumber y, JsNumber width, JsNumber height) { }
        public void updateProjectionMatrix() { }
    }
}