//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE
{
    /// <summary>
    /// TinyMCE theme class.
    /// </summary>
    [JsType(JsMode.Prototype, Name="tinymce.Theme", Export=false)]
    public  partial class Theme
    {
        /// <summary>
        /// Meta info method, this method gets executed when TinyMCE wants to present information about the theme for example in the about/help dialog.
        /// </summary>
        public object getInfo(){return null;}
        /// <summary>
        /// Initializes the theme.
        /// </summary>
        /// <param name="editor">Editor instance that created the theme instance.</param>
        /// <param name="url">Absolute URL where the theme is located.</param>
        public object init(SharpKit.TinyMCE.Editor editor, string url){return null;}
        /// <summary>
        /// This method is responsible for rendering/generating the overall user interface with toolbars, buttons, iframe containers etc.
        /// </summary>
        /// <param name="obj">Object parameter containing the targetNode DOM node that will be replaced visually with an editor instance.</param>
        public object renderUI(object obj){return null;}
    }
}
