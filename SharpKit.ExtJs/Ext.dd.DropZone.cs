//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.dd
namespace Ext.dd
{
    #region DropZone
    /// <inheritdocs />
    /// <summary>
    /// <p>This class provides a container DD instance that allows dropping on multiple child target nodes.</p>
    /// <p>By default, this class requires that child nodes accepting drop are registered with <see cref="Ext.dd.Registry">Ext.dd.Registry</see>.
    /// However a simpler way to allow a DropZone to manage any number of target elements is to configure the
    /// DropZone with an implementation of <see cref="Ext.dd.DropZone.getTargetFromEvent">getTargetFromEvent</see> which interrogates the passed
    /// mouse event to see if it has taken place within an element, or class of elements. This is easily done
    /// by using the event's <see cref="Ext.EventObject.getTarget">getTarget</see> method to identify a node based on a
    /// <see cref="Ext.dom.Query">Ext.DomQuery</see> selector.</p>
    /// <p>Once the DropZone has detected through calling getTargetFromEvent, that the mouse is over
    /// a drop target, that target is passed as the first parameter to <see cref="Ext.dd.DropZone.onNodeEnter">onNodeEnter</see>, <see cref="Ext.dd.DropZone.onNodeOver">onNodeOver</see>,
    /// <see cref="Ext.dd.DropZone.onNodeOut">onNodeOut</see>, <see cref="Ext.dd.DropZone.onNodeDrop">onNodeDrop</see>. You may configure the instance of DropZone with implementations
    /// of these methods to provide application-specific behaviour for these events to update both
    /// application state, and UI state.</p>
    /// <p>For example to make a GridPanel a cooperating target with the example illustrated in
    /// <see cref="Ext.dd.DragZone">DragZone</see>, the following technique might be used:</p>
    /// <pre><code>myGridPanel.on('render', function() {
    /// myGridPanel.dropZone = new <see cref="Ext.dd.DropZone">Ext.dd.DropZone</see>(myGridPanel.getView().scroller, {
    /// // If the mouse is over a grid row, return that node. This is
    /// // provided as the "target" parameter in all "onNodeXXXX" node event handling functions
    /// getTargetFromEvent: function(e) {
    /// return e.getTarget(myGridPanel.getView().rowSelector);
    /// },
    /// // On entry into a target node, highlight that node.
    /// onNodeEnter : function(target, dd, e, data){
    /// <see cref="Ext.ExtContext.fly">Ext.fly</see>(target).addCls('my-row-highlight-class');
    /// },
    /// // On exit from a target node, unhighlight that node.
    /// onNodeOut : function(target, dd, e, data){
    /// <see cref="Ext.ExtContext.fly">Ext.fly</see>(target).removeCls('my-row-highlight-class');
    /// },
    /// // While over a target node, return the default drop allowed class which
    /// // places a "tick" icon into the drag proxy.
    /// onNodeOver : function(target, dd, e, data){
    /// return Ext.dd.DropZone.prototype.dropAllowed;
    /// },
    /// // On node drop we can interrogate the target to find the underlying
    /// // application object that is the real target of the dragged data.
    /// // In this case, it is a Record in the GridPanel's Store.
    /// // We can use the data set up by the DragZone's getDragData method to read
    /// // any data we decided to attach in the DragZone's getDragData method.
    /// onNodeDrop : function(target, dd, e, data){
    /// var rowIndex = myGridPanel.getView().findRowIndex(target);
    /// var r = myGridPanel.getStore().getAt(rowIndex);
    /// <see cref="Ext.MessageBox.alert">Ext.Msg.alert</see>('Drop gesture', 'Dropped Record id ' + data.draggedRecord.id +
    /// ' on Record id ' + r.id);
    /// return true;
    /// }
    /// });
    /// }
    /// </code></pre>
    /// <p>See the <see cref="Ext.dd.DragZone">DragZone</see> documentation for details about building a DragZone which
    /// cooperates with this DropZone.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class DropZone : DropTarget
    {
        /// <summary>
        /// Returns a custom data object associated with the DOM node that is the target of the event.  By default
        /// this looks up the event target in the Ext.dd.Registry, although you can override this method to
        /// provide your own custom lookup.
        /// </summary>
        /// <param name="e"><p>The event</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>data The custom data</p>
        /// </div>
        /// </returns>
        public object getTargetFromEvent(object e){return null;}
        /// <summary>
        /// Called when the DropZone determines that a Ext.dd.DragSource has been dropped on it,
        /// but not on any of its registered drop nodes.  The default implementation returns false, so it should be
        /// overridden to provide the appropriate processing of the drop event if you need the drop zone itself to
        /// be able to accept drops.  It should return true when valid so that the drag source's repair action does not run.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="source"><p>The drag source that was dragged over this drop zone</p>
        /// </param>
        /// <param name="e"><p>The event</p>
        /// </param>
        /// <param name="data"><p>An object containing arbitrary data supplied by the drag source</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if the drop was valid, else false</p>
        /// </div>
        /// </returns>
        public virtual bool onContainerDrop(DragSource source, object e, object data){return false;}
        /// <summary>
        /// Called while the DropZone determines that a Ext.dd.DragSource is being dragged over it,
        /// but not over any of its registered drop nodes.  The default implementation returns this.dropNotAllowed, so
        /// it should be overridden to provide the proper feedback if necessary.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="source"><p>The drag source that was dragged over this drop zone</p>
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
        public virtual JsString onContainerOver(DragSource source, object e, object data){return null;}
        /// <summary>
        /// Called when the DropZone determines that a Ext.dd.DragSource has been dropped onto
        /// the drop node.  The default implementation returns false, so it should be overridden to provide the
        /// appropriate processing of the drop event and return true so that the drag source's repair action does not run.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="nodeData"><p>The custom data associated with the drop node (this is the same value returned from
        /// <see cref="Ext.dd.DropZone.getTargetFromEvent">getTargetFromEvent</see> for this node)</p>
        /// </param>
        /// <param name="source"><p>The drag source that was dragged over this drop zone</p>
        /// </param>
        /// <param name="e"><p>The event</p>
        /// </param>
        /// <param name="data"><p>An object containing arbitrary data supplied by the drag source</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if the drop was valid, else false</p>
        /// </div>
        /// </returns>
        public virtual bool onNodeDrop(object nodeData, DragSource source, object e, object data){return false;}
        /// <summary>
        /// Called when the DropZone determines that a Ext.dd.DragSource has entered a drop node
        /// that has either been registered or detected by a configured implementation of getTargetFromEvent.
        /// This method has no default implementation and should be overridden to provide
        /// node-specific processing if necessary.
        /// </summary>
        /// <param name="nodeData"><p>The custom data associated with the drop node (this is the same value returned from
        /// <see cref="Ext.dd.DropZone.getTargetFromEvent">getTargetFromEvent</see> for this node)</p>
        /// </param>
        /// <param name="source"><p>The drag source that was dragged over this drop zone</p>
        /// </param>
        /// <param name="e"><p>The event</p>
        /// </param>
        /// <param name="data"><p>An object containing arbitrary data supplied by the drag source</p>
        /// </param>
        public void onNodeEnter(object nodeData, DragSource source, object e, object data){}
        /// <summary>
        /// Called when the DropZone determines that a Ext.dd.DragSource has been dragged out of
        /// the drop node without dropping.  This method has no default implementation and should be overridden to provide
        /// node-specific processing if necessary.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="nodeData"><p>The custom data associated with the drop node (this is the same value returned from
        /// <see cref="Ext.dd.DropZone.getTargetFromEvent">getTargetFromEvent</see> for this node)</p>
        /// </param>
        /// <param name="source"><p>The drag source that was dragged over this drop zone</p>
        /// </param>
        /// <param name="e"><p>The event</p>
        /// </param>
        /// <param name="data"><p>An object containing arbitrary data supplied by the drag source</p>
        /// </param>
        public virtual void onNodeOut(object nodeData, DragSource source, object e, object data){}
        /// <summary>
        /// Called while the DropZone determines that a Ext.dd.DragSource is over a drop node
        /// that has either been registered or detected by a configured implementation of getTargetFromEvent.
        /// The default implementation returns this.dropAllowed, so it should be
        /// overridden to provide the proper feedback.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="nodeData"><p>The custom data associated with the drop node (this is the same value returned from
        /// <see cref="Ext.dd.DropZone.getTargetFromEvent">getTargetFromEvent</see> for this node)</p>
        /// </param>
        /// <param name="source"><p>The drag source that was dragged over this drop zone</p>
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
        public virtual JsString onNodeOver(object nodeData, DragSource source, object e, object data){return null;}
        public DropZone(Ext.dd.DropZoneConfig config){}
        public DropZone(){}
        public DropZone(params object[] args){}
    }
    #endregion
    #region DropZoneConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DropZoneConfig : DropTargetConfig
    {
        public DropZoneConfig(params object[] args){}
    }
    #endregion
    #region DropZoneEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DropZoneEvents : DropTargetEvents
    {
        public DropZoneEvents(params object[] args){}
    }
    #endregion
}
#endregion
