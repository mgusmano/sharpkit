// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.progressive.model
{
    /// <summary>
	/// <para>Data Model for Progressive renderer.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.progressive.model.Abstract", OmitOptionalParameters = true, Export = false)]
    public abstract partial class Abstract : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>This event is fired when new data has been added to the data model.  It
		/// typically informs Progressive to begin its rendering process.</para>
		/// <para>The event data is an integer: the number of elements now available on
		/// the element queue.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnDataAvailable;

		#endregion Events

		#region Methods

		public Abstract() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the number of data elements currently available.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getElementCount")]
		public double GetElementCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the next available element from the data model.</para>
		/// </summary>
		/// <returns>The returned object must provide at least the following members:   renderer  The name of a renderer.  That name is used by qx.ui.progressive.Progressive to select the renderer to be used to render this element.  The name should match one provided to qx.ui.progressive.Progressive#addRenderer.    data   The data to be passed to the renderer.  The data may be of any type that the renderer knows how to render.  </returns>
		[JsMethod(Name = "getNextElement")]
		public object GetNextElement() { throw new NotImplementedException(); }

		#endregion Methods
    }
}