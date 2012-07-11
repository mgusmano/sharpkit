//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.panel
namespace Ext.panel
{
    #region Header
    /// <summary>
    /// Simple header class which is used for on Ext.panel.Panel and Ext.window.Window
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Header : Ext.container.Container, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Add a tool to the header ...
        /// </summary>
        public object addTool(object tool){return null;}
        /// <summary>
        /// Sets the CSS class that provides the icon image for this panel. ...
        /// </summary>
        public object setIconCls(JsString cls){return null;}
        /// <summary>
        /// Sets the title of the header. ...
        /// </summary>
        public object setTitle(JsString title){return null;}
        public Header(HeaderConfig config){}
        public Header(){}
    }
    #endregion
    #region HeaderConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class HeaderConfig : Ext.container.ContainerConfig
    {
    }
    #endregion
    #region HeaderEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class HeaderEvents : Ext.container.ContainerEvents
    {
    }
    #endregion
}
#endregion