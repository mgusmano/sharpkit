// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.eventx.type
{
    /// <summary>
	/// <para>Common base class for all native events (DOM events, IO events, ...).</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.event.type.Native", OmitOptionalParameters = true, Export = false)]
    public partial class Native : qx.eventx.type.Event
    {
		#region Methods

		public Native() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Create a clone of the event object, which is not automatically disposed
		/// or pooled after an event dispatch.</para>
		/// </summary>
		/// <param name="embryo">Optional event class, which will be configured using the data of this event instance. The event must be an instance of this event class. If the value is null, a new pooled instance is created.</param>
		/// <returns>a clone of this class.</returns>
		[JsMethod(Name = "clone")]
		public qx.eventx.type.Event Clone(qx.eventx.type.Event embryo = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the native browser event object of this event.</para>
		/// </summary>
		/// <returns>The native browser event</returns>
		[JsMethod(Name = "getNativeEvent")]
		public Event GetNativeEvent() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Retrieves the event&#8217;s return value.</para>
		/// </summary>
		/// <returns>The return value</returns>
		[JsMethod(Name = "getReturnValue")]
		public string GetReturnValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Initialize the fields of the event. The event must be initialized before
		/// it can be dispatched.</para>
		/// </summary>
		/// <param name="nativeEvent">The DOM event to use</param>
		/// <param name="target">The event target</param>
		/// <param name="relatedTarget">The related event target</param>
		/// <param name="canBubble">Whether or not the event is a bubbling event. If the event is bubbling, the bubbling can be stopped using qx.event.type.Event#stopPropagation</param>
		/// <param name="cancelable">Whether or not an event can have its default action prevented. The default action can either be the browser&#8217;s default action of a native event (e.g. open the context menu on a right click) or the default action of a qooxdoo class (e.g. close the window widget). The default action can be prevented by calling #preventDefault</param>
		/// <returns>The initialized event instance</returns>
		[JsMethod(Name = "init")]
		public qx.eventx.type.Event Init(Event nativeEvent, object target, object relatedTarget = null, bool canBubble = false, bool cancelable = false) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Prevent browser default behavior, e.g. opening the context menu, ...</para>
		/// </summary>
		[JsMethod(Name = "preventDefault")]
		public void PreventDefault() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the event&#8217;s return value. If the return value is set in a
		/// beforeunload event, the user will be asked by the browser, whether
		/// he really wants to leave the page. The return string will be displayed in
		/// the message box.</para>
		/// </summary>
		/// <param name="returnValue">Return value</param>
		[JsMethod(Name = "setReturnValue")]
		public void SetReturnValue(string returnValue = null) { throw new NotImplementedException(); }

		#endregion Methods
    }
}