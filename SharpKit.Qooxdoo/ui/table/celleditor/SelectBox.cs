// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.table.celleditor
{
    /// <summary>
	/// <para>A cell editor factory creating select boxes.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.table.celleditor.SelectBox", OmitOptionalParameters = true, Export = false)]
    public partial class SelectBox : qx.core.Object, qx.ui.table.ICellEditorFactory
    {
		#region Properties

		/// <summary>
		/// <para>array of data to construct ListItem widgets with</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "listData", NativeField = true)]
		public JsArray ListData { get; set; }

		/// <summary>
		/// <para>function that validates the result
		/// the function will be called with the new value and the old value and is
		/// supposed to return the value that is set as the table value.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "validationFunction", NativeField = true)]
		public Action<object> ValidationFunction { get; set; }

		#endregion Properties

		#region Methods

		public SelectBox() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates a cell editor.</para>
		/// <para>The cellInfo map contains the following properties:
		/// <list type="bullet">
		/// <item>value (var): the cell&#8217;s value.</item>
		/// <item>row (int): the model index of the row the cell belongs to.</item>
		/// <item>col (int): the model index of the column the cell belongs to.</item>
		/// <item>xPos (int): the x position of the cell in the table pane.</item>
		/// <item>table (qx.ui.table.Table) reference to the table, the cell belongs to. </item>
		/// </list</para>
		/// </summary>
		/// <param name="cellInfo">A map containing the information about the cell to create.</param>
		/// <returns>the widget that should be used as cell editor.</returns>
		[JsMethod(Name = "createCellEditor")]
		public qx.ui.core.Widget CreateCellEditor(object cellInfo) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the current value of a cell editor.</para>
		/// </summary>
		/// <param name="cellEditor">The cell editor formally created by #createCellEditor.</param>
		/// <returns>the current value from the editor.</returns>
		[JsMethod(Name = "getCellEditorValue")]
		public object GetCellEditorValue(qx.ui.core.Widget cellEditor) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property listData.</para>
		/// </summary>
		[JsMethod(Name = "getListData")]
		public JsArray GetListData() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property validationFunction.</para>
		/// </summary>
		[JsMethod(Name = "getValidationFunction")]
		public Action<object> GetValidationFunction() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property listData
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property listData.</param>
		[JsMethod(Name = "initListData")]
		public void InitListData(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property validationFunction
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property validationFunction.</param>
		[JsMethod(Name = "initValidationFunction")]
		public void InitValidationFunction(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property listData.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetListData")]
		public void ResetListData() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property validationFunction.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetValidationFunction")]
		public void ResetValidationFunction() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property listData.</para>
		/// </summary>
		/// <param name="value">New value for property listData.</param>
		[JsMethod(Name = "setListData")]
		public void SetListData(JsArray value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property validationFunction.</para>
		/// </summary>
		/// <param name="value">New value for property validationFunction.</param>
		[JsMethod(Name = "setValidationFunction")]
		public void SetValidationFunction(Action<object> value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}