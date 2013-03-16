// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.data.store
{
    /// <summary>
	/// <para>The JSONP data store is a specialization of <see cref="qx.data.store.Json"/>. It
	/// differs in the type of transport used (<see cref="qx.io.request.Jsonp"/>). In
	/// order to fullfill requirements of the JSONP service, the method
	/// <see cref="SetCallbackParam"/> can be used.</para>
	/// <para>Please note that the upgrade notices described in <see cref="qx.data.store.Json"/>
	/// also apply to this class.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.data.store.Jsonp", OmitOptionalParameters = true, Export = false)]
    public partial class Jsonp : qx.data.store.Json
    {
		#region Properties

		/// <summary>
		/// <para>The name of the callback function. See
		/// <see cref="qx.bom.request.Jsonp.SetCallbackName"/> for more details.</para>
		/// <para>Note: Ignored when legacy transport is used.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "callbackName", NativeField = true)]
		public string CallbackName { get; set; }

		/// <summary>
		/// <para>The name of the callback parameter of the service. See
		/// <see cref="qx.bom.request.Jsonp.SetCallbackParam"/> for more details.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "callbackParam", NativeField = true)]
		public string CallbackParam { get; set; }

		#endregion Properties

		#region Methods

		public Jsonp() { throw new NotImplementedException(); }

		/// <param name="url">URL of the JSONP service.</param>
		/// <param name="delegatex">The delegate containing one of the methods specified in qx.data.store.IStoreDelegate.</param>
		/// <param name="callbackParam">The name of the callback param. See qx.bom.request.Jsonp#setCallbackParam for more details.</param>
		public Jsonp(string url, object delegatex = null, string callbackParam = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property callbackName.</para>
		/// </summary>
		[JsMethod(Name = "getCallbackName")]
		public string GetCallbackName() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property callbackParam.</para>
		/// </summary>
		[JsMethod(Name = "getCallbackParam")]
		public string GetCallbackParam() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property callbackName
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property callbackName.</param>
		[JsMethod(Name = "initCallbackName")]
		public void InitCallbackName(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property callbackParam
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property callbackParam.</param>
		[JsMethod(Name = "initCallbackParam")]
		public void InitCallbackParam(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property callbackName.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetCallbackName")]
		public void ResetCallbackName() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property callbackParam.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetCallbackParam")]
		public void ResetCallbackParam() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property callbackName.</para>
		/// </summary>
		/// <param name="value">New value for property callbackName.</param>
		[JsMethod(Name = "setCallbackName")]
		public void SetCallbackName(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property callbackParam.</para>
		/// </summary>
		/// <param name="value">New value for property callbackParam.</param>
		[JsMethod(Name = "setCallbackParam")]
		public void SetCallbackParam(string value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}