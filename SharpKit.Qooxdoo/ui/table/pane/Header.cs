// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.table.pane
{
    /// <summary>
	/// <para>Shows the header of a table.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.table.pane.Header", OmitOptionalParameters = true, Export = false)]
    public partial class Header : qx.ui.core.Widget
    {
		#region Methods

		public Header() { throw new NotImplementedException(); }

		/// <param name="paneScroller">the TablePaneScroller the header belongs to.</param>
		public Header(qx.ui.table.pane.Scroller paneScroller) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the blocker of the header.</para>
		/// </summary>
		/// <returns>the blocker.</returns>
		[JsMethod(Name = "getBlocker")]
		public qx.ui.core.Blocker GetBlocker() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the header widget for the given column</para>
		/// </summary>
		/// <param name="col">The column number</param>
		/// <returns>The header cell widget</returns>
		[JsMethod(Name = "getHeaderWidgetAtColumn")]
		public qx.ui.table.headerrenderer.HeaderCell GetHeaderWidgetAtColumn(double col) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the TablePaneScroller this header belongs to.</para>
		/// </summary>
		/// <returns>the TablePaneScroller.</returns>
		[JsMethod(Name = "getPaneScroller")]
		public qx.ui.table.pane.Scroller GetPaneScroller() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the table this header belongs to.</para>
		/// </summary>
		/// <returns>the table.</returns>
		[JsMethod(Name = "getTable")]
		public qx.ui.table.Table GetTable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Hides the feedback shown while a column is moved by the user.</para>
		/// </summary>
		[JsMethod(Name = "hideColumnMoveFeedback")]
		public void HideColumnMoveFeedback() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether the column move feedback is currently shown.</para>
		/// </summary>
		/// <returns>true whether the column move feedback is currently shown, false otherwise.</returns>
		[JsMethod(Name = "isShowingColumnMoveFeedback")]
		public bool IsShowingColumnMoveFeedback() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Event handler. Called the column order has changed.</para>
		/// </summary>
		[JsMethod(Name = "onColOrderChanged")]
		public void OnColOrderChanged() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Event handler. Called when the pane model has changed.</para>
		/// </summary>
		[JsMethod(Name = "onPaneModelChanged")]
		public void OnPaneModelChanged() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Event handler. Called when the table model meta data has changed.</para>
		/// </summary>
		[JsMethod(Name = "onTableModelMetaDataChanged")]
		public void OnTableModelMetaDataChanged() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the column width. This overrides the width from the column model.</para>
		/// </summary>
		/// <param name="col">The column to change the width for.</param>
		/// <param name="width">The new width.</param>
		/// <param name="isMouseAction">true if the column width is being changed as a result of a mouse drag in the header; false or undefined otherwise.</param>
		[JsMethod(Name = "setColumnWidth")]
		public void SetColumnWidth(double col, double width, bool isMouseAction) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the column the mouse is currently over.</para>
		/// </summary>
		/// <param name="col">the model index of the column the mouse is currently over or null if the mouse is over no column.</param>
		[JsMethod(Name = "setMouseOverColumn")]
		public void SetMouseOverColumn(double col) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Shows the feedback shown while a column is moved by the user.</para>
		/// </summary>
		/// <param name="col">the model index of the column to show the move feedback for.</param>
		/// <param name="x">the x position the left side of the feeback should have (in pixels, relative to the left side of the header).</param>
		[JsMethod(Name = "showColumnMoveFeedback")]
		public void ShowColumnMoveFeedback(double col, double x) { throw new NotImplementedException(); }

		#endregion Methods
    }
}