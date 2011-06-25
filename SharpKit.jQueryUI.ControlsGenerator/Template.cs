//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using SharpKit.JavaScript;
//using SharpKit.jQuery;
//using SharpKit.jQuery.UI;
//namespace WebDesigner.Client
//{
//    [JsType(JsMode.Prototype)]
//    public class jSlider : jQueryContext
//    {
//        public jSlider(JsString selector, SliderOptions options)
//        {
//            Selector = J(selector);
//            Selector.slider(options);
//        }

//        public JsNumber value
//        {
//            get { return Get("value").As<JsNumber>(); }
//            set { Set("value", value); }
//        }

//        object Get(JsString option)
//        {
//            return Selector.slider(option);
//        }
//        void Set(JsString option, object value)
//        {
//            Selector.slider(option, value);
//        }
//        jQuery Selector;
//    }
//}