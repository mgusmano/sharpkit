//***************************************************
//* This file was generated by tool
//* 20/07/2011 17:29:50
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.util
namespace Ext.util
{
    #region TextMetrics
    /// <summary>
    /// Provides precise pixel measurements for blocks of text so that you can determine exactly how high and
    /// wide, in pixels, a given block of text will be. Note that when measuring text, it should be plain text and
    /// should not contain any HTML, otherwise it may not be measured correctly. The measurement works by copying the relevant CSS styles that can affect the font related display,
    /// then checking the size of an element that is auto-sized. Note that if the text is multi-lined, you must
    /// provide a fixed width when doing the measurement. If multiple measurements are being done on the same element, you create a new instance to initialize
    /// to avoid the overhead of copying the styles to the element repeatedly.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class TextMetrics : Ext.Base
    {
        /// <summary>
        /// Creates new TextMetrics. ...
        /// </summary>
        public object constructor(object bindTo, JsNumber fixedWidth=null){return null;}
        /// <summary>
        /// Destroy this instance ...
        /// </summary>
        public object destroy(){return null;}
        /// <summary>
        /// Measures the size of the specified text ...
        /// </summary>
        public object measure(object el, JsString text, JsNumber fixedWidth=null){return null;}
    }
    #endregion
    #region TextMetricsConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class TextMetricsConfig
    {
    }
    #endregion
    #region TextMetricsEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class TextMetricsEvents
    {
    }
    #endregion
}
#endregion
