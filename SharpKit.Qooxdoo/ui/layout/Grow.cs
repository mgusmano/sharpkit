// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.layout
{
    /// <summary>
	/// <para>The grow layout stretches all children to the full available size
	/// but still respects limits configured by min/max values.</para>
	/// <para>It will place all children over each other with the top and left coordinates
	/// set to 0. The <see cref="qx.ui.container.Stack"/> and the
	/// <see cref="qx.ui.core.scroll.ScrollPane"/> are using this layout.</para>
	/// <para>Features</para>
	/// <list type="bullet">
	/// <item>Auto-sizing</item>
	/// <item>Respects minimum and maximum child dimensions</item>
	/// </list
	/// <para>Item Properties</para>
	/// <para>None</para>
	/// <para>Example</para>
	/// <code>
	/// var layout = new qx.ui.layout.Grow();
	/// var w1 = new qx.ui.core.Widget();
	/// var w2 = new qx.ui.core.Widget();
	/// var w3 = new qx.ui.core.Widget();
	/// var container = new qx.ui.container.Composite(layout);
	/// container.add(w1);
	/// container.add(w2);
	/// container.add(w3);
	/// </code>
	/// <para>External Documentation</para>
	/// 
	/// Extended documentation and links to demos of this layout in the qooxdoo manual.
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.layout.Grow", OmitOptionalParameters = true, Export = false)]
    public partial class Grow : qx.ui.layout.Abstract
    {
		#region Methods

		public Grow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Applies the children layout.</para>
		/// </summary>
		/// <param name="availWidth">Final width available for the content (in pixel)</param>
		/// <param name="availHeight">Final height available for the content (in pixel)</param>
		[JsMethod(Name = "renderLayout")]
		public void RenderLayout(double availWidth, double availHeight) { throw new NotImplementedException(); }

		#endregion Methods
    }
}