//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.dd
{
    #region DropTarget
    /// <inheritdocs />
    /// <summary>
    /// <p>A simple class that provides the basic implementation needed to make any element a drop target that can have
    /// draggable items dropped onto it.  The drop has no effect until an implementation of notifyDrop is provided.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class DropTarget : DDTarget
    {
        /// <summary>
        /// A named drag drop group to which this object belongs.  If a group is specified, then this object will only
        /// interact with other drag drop objects in the same group.
        /// </summary>
        public JsString ddGroup;
        /// <summary>
        /// The CSS class returned to the drag source when drop is allowed.
        /// Defaults to: <c>&quot;x-dd-drop-ok&quot;</c>
        /// </summary>
        public JsString dropAllowed;
        /// <summary>
        /// The CSS class returned to the drag source when drop is not allowed.
        /// Defaults to: <c>&quot;x-dd-drop-nodrop&quot;</c>
        /// </summary>
        public JsString dropNotAllowed;
        /// <summary>
        /// The CSS class applied to the drop target element while the drag source is over it.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString overClass;
        /// <summary>
        /// Creates new DropTarget.
        /// </summary>
        /// <param name="el"><p>The container element or ID of it.</p>
        /// </param>
        /// <param name="config">
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public DropTarget(object el, object config){}
        /// <summary>
        /// The function a Ext.dd.DragSource calls once to notify this drop target that the dragged item has
        /// been dropped on it.  This method has no default implementation and returns false, so you must provide an
        /// implementation that does something to process the drop event and returns true so that the drag source's
        /// repair action does not run.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="source"><p>The drag source that was dragged over this drop target</p>
        /// </param>
        /// <param name="e"><p>The event</p>
        /// </param>
        /// <param name="data"><p>An object containing arbitrary data supplied by the drag source</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>False if the drop was invalid.</p>
        /// </div>
        /// </returns>
        public virtual bool notifyDrop(DragSource source, object e, object data){return false;}
        /// <summary>
        /// The function a Ext.dd.DragSource calls once to notify this drop target that the source is now over the
        /// target.  This default implementation adds the CSS class specified by overClass (if any) to the drop element
        /// and returns the dropAllowed config value.  This method should be overridden if drop validation is required.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="source"><p>The drag source that was dragged over this drop target</p>
        /// </param>
        /// <param name="e"><p>The event</p>
        /// </param>
        /// <param name="data"><p>An object containing arbitrary data supplied by the drag source</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>status The CSS class that communicates the drop status back to the source so that the
        /// underlying <see cref="Ext.dd.StatusProxy">Ext.dd.StatusProxy</see> can be updated</p>
        /// </div>
        /// </returns>
        public virtual JsString notifyEnter(DragSource source, object e, object data){return null;}
        /// <summary>
        /// The function a Ext.dd.DragSource calls once to notify this drop target that the source has been dragged
        /// out of the target without dropping.  This default implementation simply removes the CSS class specified by
        /// overClass (if any) from the drop element.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="source"><p>The drag source that was dragged over this drop target</p>
        /// </param>
        /// <param name="e"><p>The event</p>
        /// </param>
        /// <param name="data"><p>An object containing arbitrary data supplied by the drag source</p>
        /// </param>
        public virtual void notifyOut(DragSource source, object e, object data){}
        /// <summary>
        /// The function a Ext.dd.DragSource calls continuously while it is being dragged over the target.
        /// This method will be called on every mouse movement while the drag source is over the drop target.
        /// This default implementation simply returns the dropAllowed config value.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="source"><p>The drag source that was dragged over this drop target</p>
        /// </param>
        /// <param name="e"><p>The event</p>
        /// </param>
        /// <param name="data"><p>An object containing arbitrary data supplied by the drag source</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>status The CSS class that communicates the drop status back to the source so that the
        /// underlying <see cref="Ext.dd.StatusProxy">Ext.dd.StatusProxy</see> can be updated</p>
        /// </div>
        /// </returns>
        public virtual JsString notifyOver(DragSource source, object e, object data){return null;}
        public DropTarget(DropTargetConfig config){}
        public DropTarget(){}
        public DropTarget(params object[] args){}
    }
    #endregion
    #region DropTargetConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DropTargetConfig : DDTargetConfig
    {
        /// <summary>
        /// A named drag drop group to which this object belongs.  If a group is specified, then this object will only
        /// interact with other drag drop objects in the same group.
        /// </summary>
        public JsString ddGroup;
        /// <summary>
        /// The CSS class returned to the drag source when drop is allowed.
        /// Defaults to: <c>&quot;x-dd-drop-ok&quot;</c>
        /// </summary>
        public JsString dropAllowed;
        /// <summary>
        /// The CSS class returned to the drag source when drop is not allowed.
        /// Defaults to: <c>&quot;x-dd-drop-nodrop&quot;</c>
        /// </summary>
        public JsString dropNotAllowed;
        /// <summary>
        /// The CSS class applied to the drop target element while the drag source is over it.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString overClass;
        public DropTargetConfig(params object[] args){}
    }
    #endregion
    #region DropTargetEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DropTargetEvents : DDTargetEvents
    {
        public DropTargetEvents(params object[] args){}
    }
    #endregion
}