// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.table.selection
{
    /// <summary>
	/// <para>A selection manager. This is a helper class that handles all selection
	/// related events and updates a SelectionModel.</para>
	/// <para>Widgets that support selection should use this manager. This way the only
	/// thing the widget has to do is mapping mouse or key events to indexes and
	/// call the corresponding handler method.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.table.selection.Manager", OmitOptionalParameters = true, Export = false)]
    public partial class Manager : qx.core.Object
    {
		#region Properties

		/// <summary>
		/// <para>The selection model where to set the selection changes.</para>
		/// </summary>
		[JsProperty(Name = "selectionModel", NativeField = true)]
		public qx.ui.table.selection.Model SelectionModel { get; set; }

		#endregion Properties

		#region Methods

		public Manager() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property selectionModel.</para>
		/// </summary>
		[JsMethod(Name = "getSelectionModel")]
		public qx.ui.table.selection.Model GetSelectionModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Handles the mouse click event.</para>
		/// </summary>
		/// <param name="index">the index the mouse is pointing at.</param>
		/// <param name="evt">the mouse event.</param>
		[JsMethod(Name = "handleClick")]
		public void HandleClick(double index, object evt) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Handles the mouse down event.</para>
		/// </summary>
		/// <param name="index">the index the mouse is pointing at.</param>
		/// <param name="evt">the mouse event.</param>
		[JsMethod(Name = "handleMouseDown")]
		public void HandleMouseDown(double index, object evt) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Handles the mouse up event.</para>
		/// </summary>
		/// <param name="index">the index the mouse is pointing at.</param>
		/// <param name="evt">the mouse event.</param>
		[JsMethod(Name = "handleMouseUp")]
		public void HandleMouseUp(double index, object evt) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Handles a key down event that moved the focus (E.g. up, down, home, end, ...).</para>
		/// </summary>
		/// <param name="index">the index that is currently focused.</param>
		/// <param name="evt">the key event.</param>
		[JsMethod(Name = "handleMoveKeyDown")]
		public void HandleMoveKeyDown(double index, object evt) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Handles the key down event that is used as replacement for mouse clicks
		/// (Normally space).</para>
		/// </summary>
		/// <param name="index">the index that is currently focused.</param>
		/// <param name="evt">the key event.</param>
		[JsMethod(Name = "handleSelectKeyDown")]
		public void HandleSelectKeyDown(double index, object evt) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property selectionModel
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property selectionModel.</param>
		[JsMethod(Name = "initSelectionModel")]
		public void InitSelectionModel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property selectionModel.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSelectionModel")]
		public void ResetSelectionModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property selectionModel.</para>
		/// </summary>
		/// <param name="value">New value for property selectionModel.</param>
		[JsMethod(Name = "setSelectionModel")]
		public void SetSelectionModel(qx.ui.table.selection.Model value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}