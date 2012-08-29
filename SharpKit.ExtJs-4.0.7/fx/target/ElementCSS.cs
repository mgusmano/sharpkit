//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.fx.target
namespace Ext.fx.target
{
    #region ElementCSS
    /// <summary>
    /// This class represents a animation target for an Ext.core.Element that supports CSS
    /// based animation. In general this class will not be created directly, the Ext.core.Element
    /// will be passed to the animation and the appropriate target will be created.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class ElementCSS : Ext.fx.target.Element
    {
        public ElementCSS(ElementCSSConfig config){}
        public ElementCSS(){}
    }
    #endregion
    #region ElementCSSConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ElementCSSConfig : Ext.fx.target.ElementConfig
    {
    }
    #endregion
    #region ElementCSSEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ElementCSSEvents : Ext.fx.target.ElementEvents
    {
    }
    #endregion
}
#endregion
