//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:25
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.util
namespace Ext.util
{
    #region ComponentDragger
    /// <summary>
    /// A subclass of Ext.dd.DragTracker which handles dragging any Component. This is configured with a Component to be made draggable, and a config object for the
    /// Ext.dd.DragTracker class. A  delegate may be provided which may be either the element to use as the mousedown target
    /// or a Ext.DomQuery selector to activate multiple mousedown targets.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class ComponentDragger : Ext.dd.DragTracker, Observable
    {
        /// <summary>
        /// Creates new ComponentDragger. ...
        /// </summary>
        public object constructor(object comp, object config=null){return null;}
    }
    #endregion
    #region ComponentDraggerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ComponentDraggerConfig : Ext.dd.DragTrackerConfig
    {
        public bool constrain{get;set;}
        public bool constrainDelegate{get;set;}
        /// <summary>
        /// Optional. ...
        /// </summary>
        public new object @delegate{get;set;}
    }
    #endregion
    #region ComponentDraggerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ComponentDraggerEvents : Ext.dd.DragTrackerEvents
    {
    }
    #endregion
}
#endregion
