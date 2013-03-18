// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.dialog
{
    /// <summary>
	/// <para>The picker widget gives the user the possibility to select a value out of an array
	/// of values. The picker widget is always shown in a <see cref="qx.ui.mobile.dialog.Dialog"/>.</para>
	/// <para>The picker widget is able to display multiple picker slots, for letting the user choose
	/// several values at one time, in one single dialog.</para>
	/// <para>The selectable value array is passed to this widget through a <see cref="qx.data.Array"/> which represents one picker slot.</para>
	/// <para>Example</para>
	/// <para>Here is an example of how to use the picker widget.</para>
	/// <code>
	/// var pickerSlot1 = new qx.data.Array(["qx.Desktop", "qx.Mobile", "qx.Website","qx.Server"]);
	/// var pickerSlot2 = new qx.data.Array(["1.8", "2.0", "2.0.1", "2.0.2", "2.1","2.2"]);
	/// var picker = new qx.ui.mobile.dialog.Picker();
	/// picker.setTitle("Picker");
	/// picker.addSlot(pickerSlot1);
	/// picker.addSlot(pickerSlot2);
	/// var showPickerButton = new qx.ui.mobile.form.Button("Show Picker");
	/// showPickerButton.addListener("tap", picker.show, picker);
	/// this.getContent().add(showPickerButton);
	/// // Listener when user has confirmed his selection.
	/// // Contains the selectedIndex and values of all slots in a array.
	/// picker.addListener("confirmSelection",function(evt){
	/// var pickerData = evt.getData();
	/// }, this);
	/// // Listener for change of picker slots.
	/// picker.addListener("changeSelection",function(evt){
	/// var slotData = evt.getData();
	/// }, this);
	/// </code>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.dialog.Picker", OmitOptionalParameters = true, Export = false)]
    public partial class Picker : qx.ui.mobile.dialog.Dialog
    {
		#region Events

		/// <summary>
		/// <para>Fired when the selection of a single slot has changed.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeSelection;

		/// <summary>
		/// <para>Fired when the picker is closed. This means user has confirmed its selection.
		/// Thie events contains all data which were chosen by user.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnConfirmSelection;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The default CSS class used for this widget. The default CSS class
		/// should contain the common appearance of the widget.
		/// It is set to the container element of the widget. Use <see cref="AddCssClass"/>
		/// to enhance the default appearance of the widget.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "defaultCssClass", NativeField = true)]
		public string DefaultCssClass { get; set; }

		#endregion Properties

		#region Methods

		public Picker() { throw new NotImplementedException(); }

		/// <param name="anchor">The anchor widget for this item. If no anchor is available, the menu will be displayed modal and centered on screen.</param>
		public Picker(qx.ui.mobile.core.Widget anchor = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds an picker slot to the end of the array.</para>
		/// </summary>
		/// <param name="slotData">the picker slot data to display.</param>
		[JsMethod(Name = "addSlot")]
		public void AddSlot(qx.data.Array slotData) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Confirms the selection, fires &#8220;confirmSelection&#8221; data event and hides the picker dialog.</para>
		/// </summary>
		[JsMethod(Name = "confirm")]
		public void Confirm() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Getter for the selectedIndex of a picker slot, identified by its index.</para>
		/// </summary>
		/// <param name="slotIndex">the index of the target picker slot.</param>
		/// <returns>the index of the target picker slot, or null if slotIndex is unknown.</returns>
		[JsMethod(Name = "getSelectedIndex")]
		public double GetSelectedIndex(double slotIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the picker slot count, added to this picker.</para>
		/// </summary>
		/// <returns>count of picker slots.</returns>
		[JsMethod(Name = "getSlotCount")]
		public double GetSlotCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes the pickerSlot at the given slotIndex.</para>
		/// </summary>
		/// <param name="slotIndex">the index of the target picker slot.</param>
		[JsMethod(Name = "removeSlot")]
		public void RemoveSlot(double slotIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Setter for the caption of the picker dialog&#8217;s cancel button.
		/// Default is &#8220;Cancel&#8221;.</para>
		/// </summary>
		/// <param name="caption">the caption of the cancel button.</param>
		[JsMethod(Name = "setCancelButtonCaption")]
		public void SetCancelButtonCaption(string caption) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Setter for the caption of the picker dialog&#8217;s confirm button.
		/// Default is &#8220;OK&#8221;.</para>
		/// </summary>
		/// <param name="caption">the caption of the confirm button.</param>
		[JsMethod(Name = "setConfirmButtonCaption")]
		public void SetConfirmButtonCaption(string caption) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Setter for the selectedIndex of a picker slot, identified by its index.</para>
		/// </summary>
		/// <param name="slotIndex">the index of the target picker slot.</param>
		/// <param name="value">the selectedIndex of the slot.</param>
		/// <param name="useTransition">flag which indicates whether a  transition should be used on update or not.</param>
		[JsMethod(Name = "setSelectedIndex")]
		public void SetSelectedIndex(double slotIndex, double value, bool useTransition = true) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Shows the blocker.</para>
		/// </summary>
		[JsMethod(Name = "show")]
		public void Show() { throw new NotImplementedException(); }

		#endregion Methods
    }
}