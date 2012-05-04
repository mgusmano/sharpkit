//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_
{
    /// <summary>
    /// Widget extension, which can be used to add extended XY positioning support to
    /// the base Widget class, through the `Base.create` method.
    /// **Note:** This extension requires that the `WidgetPosition` extension be added
    /// to the Widget (before `WidgetPositionAlign`, if part of the same extension list
    /// passed to `Base.build`).
    /// </summary>
    public partial class WidgetPositionAlign
    {
        /// <summary>
        /// Handles `alignChange` events by updating the UI in response to `align`
        /// Attribute changes.
        /// </summary>
        protected void _afterAlignChange(EventFacade e){}
        /// <summary>
        /// Handles `alignOnChange` events by updating the alignment-syncing event
        /// handlers.
        /// </summary>
        protected void _afterAlignOnChange(EventFacade e){}
        /// <summary>
        /// Attaches the alignment-syncing event handlers.
        /// </summary>
        protected void _attachPosAlignUIHandles(){}
        /// <summary>
        /// Bind event listeners responsible for updating the UI state in response to
        /// the widget's position-align related state changes.
        /// This method is invoked after `bindUI` has been invoked for the `Widget`
        /// class using the AOP infrastructure.
        /// </summary>
        protected void _bindUIPosAlign(){}
        /// <summary>
        /// Detaches the alignment-syncing event handlers.
        /// </summary>
        protected void _detachPosAlignUIHandles(){}
        /// <summary>
        /// Default setter for `center` Attribute changes. Sets up the appropriate
        /// value, and passes it through the to the align attribute.
        /// </summary>
        protected object _setAlignCenter(object val){return null;}
        /// <summary>
        /// Synchronizes the current `align` Attribute value to the DOM.
        /// This method is invoked after `syncUI` has been invoked for the `Widget`
        /// class using the AOP infrastructure.
        /// </summary>
        protected void _syncUIPosAlign(){}
        /// <summary>
        /// Updates the UI to reflect the `align` value passed in.
        /// **Note:** See the `align` Attribute documentation, for the Object structure
        /// expected.
        /// </summary>
        protected void _uiSetAlign(YUI_.Array points){}
        /// <summary>
        /// Updates the UI to reflect the `align` value passed in.
        /// **Note:** See the `align` Attribute documentation, for the Object structure
        /// expected.
        /// </summary>
        protected void _uiSetAlign(object node, YUI_.Array points){}
        /// <summary>
        /// Attaches or detaches alignment-syncing event handlers based on the widget's
        /// `visible` Attribute state.
        /// </summary>
        protected void _uiSetVisiblePosAlign(object visible){}
        /// <summary>
        /// Centers the widget in the viewport, or if a `Node` is passed in, it will
        /// be centered to that `Node`.
        /// </summary>
        public void centered(){}
        /// <summary>
        /// Centers the widget in the viewport, or if a `Node` is passed in, it will
        /// be centered to that `Node`.
        /// </summary>
        public void centered(object node){}
        /// <summary>
        /// Holds the alignment-syncing event handles.
        /// </summary>
        protected YUI_.Array _posAlignUIHandles{get;set;}
        /// <summary>
        /// The alignment configuration for this widget.
        /// The `align` attribute is used to align a reference point on the widget, with
        /// the reference point on another `Node`, or the viewport. The object which
        /// `align` expects has the following properties:
        /// * __`node`__: The `Node` to which the widget is to be aligned. If set to
        /// `null`, or not provided, the widget is aligned to the viewport.
        /// * __`points`__: A two element Array, defining the two points on the widget
        /// and `Node`/viewport which are to be aligned. The first element is the
        /// point on the widget, and the second element is the point on the
        /// `Node`/viewport. Supported alignment points are defined as static
        /// properties on `WidgetPositionAlign`.
        /// </summary>
        public object align{get;set;}
        /// <summary>
        /// An Array of Objects corresponding to the `Node`s and events that will cause
        /// the alignment of this widget to be synced to the DOM.
        /// The `alignOn` Attribute is expected to be an Array of Objects with the
        /// following properties:
        /// * __`eventName`__: The String event name to listen for.
        /// * __`node`__: The optional `Node` that will fire the event, it can be a
        /// `Node` reference or a selector String. This will default to the widget's
        /// `boundingBox`.
        /// </summary>
        public YUI_.Array alignOn{get;set;}
    }
}
