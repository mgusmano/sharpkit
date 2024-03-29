// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.dev
{
    /// <summary>
	/// <para>Methods to get information about the JavaScript call stack.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.dev.StackTrace", OmitOptionalParameters = true, Export = false)]
    public partial class StackTrace 
    {
		#region Methods

		public StackTrace() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a stack trace of the current position in the code.</para>
		/// <para>Browser compatibility:
		/// <list type="bullet">
		/// <item>In new versions of Gecko, WebKit and Opera, the output of
		/// <see cref="GetStackTraceFromError"/> and <see cref="GetStackTraceFromCaller"/> is
		/// combined to generate the richest trace, including line numbers.</item>
		/// <item>For Internet Explorer (and other engines that do not provide stack
		/// traces), <see cref="GetStackTraceFromCaller"/> is used</item>
		/// </list</para>
		/// </summary>
		/// <returns>Stack trace of the current position in the code. Each line in the array represents one call in the stack trace.</returns>
		[JsMethod(Name = "getStackTrace")]
		public static string GetStackTrace() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a stack trace from the arguments special variable using the
		/// caller property.</para>
		/// <para>This methods returns class/mixin and function names of each step
		/// in the call stack.</para>
		/// <para>Recursion is not supported.</para>
		/// </summary>
		/// <param name="args">arguments variable.</param>
		/// <returns>Stack trace of caller of the function the arguments variable belongs to. Each line in the array represents one call in the stack trace.</returns>
		[JsMethod(Name = "getStackTraceFromCaller")]
		public static string GetStackTraceFromCaller(JsArguments args) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Try to get a stack trace from an Error object. Mozilla sets the field
		/// stack for Error objects thrown using throw new Error().
		/// From this field it is possible to get a stack trace from the position
		/// the exception was thrown at.</para>
		/// <para>This will get the JavaScript file names and the line numbers of each call.
		/// The file names are converted into qooxdoo class names if possible (customizable
		/// via <see cref="#FILENAME_TO_CLASSNAME"/>).</para>
		/// <para>The stack trace can be custom formatted using <see cref="#FORMAT_STACKTRACE"/>.</para>
		/// <para>This works reliably in Gecko-based browsers. Later Opera versions and
		/// Chrome also provide a useful stack trace. For Safari, only the class or
		/// file name and line number where the error occurred are returned.
		/// IE 6/7/8/9 does not attach any stack information to error objects so an
		/// empty array is returned.</para>
		/// </summary>
		/// <param name="error">Error exception instance.</param>
		/// <returns>Stack trace of the exception. Each line in the array represents one call in the stack trace.</returns>
		[JsMethod(Name = "getStackTraceFromError")]
		public static string GetStackTraceFromError(JsError error) { throw new NotImplementedException(); }

		#endregion Methods
    }
}