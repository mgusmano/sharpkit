// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.toolbar
{
    /// <summary>
	/// <para>The normal toolbar button. Like a normal <see cref="qx.ui.form.Button"/>
	/// but with a style matching the toolbar and without keyboard support.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.toolbar.Button", OmitOptionalParameters = true, Export = false)]
    public partial class Button : qx.ui.form.Button
    {
		#region Properties

		[JsProperty(Name = "appearance", NativeField = true)]
		public object Appearance { get; set; }

		[JsProperty(Name = "focusable", NativeField = true)]
		public object Focusable { get; set; }

		[JsProperty(Name = "show", NativeField = true)]
		public object Show { get; set; }

		#endregion Properties

		#region Methods

		public Button() { throw new NotImplementedException(); }

		public Button(object label, object icon, object command) { throw new NotImplementedException(); }

		#endregion Methods
    }
}