// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.locale
{
    /// <summary>
	/// <para>This class contains the translation of a message and all information
	/// to translate it again into a different language.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.locale.LocalizedString", OmitOptionalParameters = true, Export = false)]
    public partial class LocalizedString : qx.type.BaseString
    {
		#region Methods

		public LocalizedString() { throw new NotImplementedException(); }

		/// <param name="translation">The translated message</param>
		/// <param name="messageId">The messageId to translate</param>
		/// <param name="args">list of arguments passed used as values for format strings</param>
		public LocalizedString(string translation, string messageId, JsArray args) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a translation of the string using the current locale.</para>
		/// </summary>
		/// <returns>This string translated using the current locale.</returns>
		[JsMethod(Name = "translate")]
		public LocalizedString Translate() { throw new NotImplementedException(); }

		#endregion Methods
    }
}