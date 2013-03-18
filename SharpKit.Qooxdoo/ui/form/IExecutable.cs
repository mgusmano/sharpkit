// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.form
{
    /// <summary>
	/// <para>Form interface for all form widgets which are executable in some way. This
	/// could be a button for example.</para>
	/// </summary>
	public interface IExecutable
    {
		#region Events

		/// <summary>
		/// <para>Fired when the widget is executed. Sets the &#8220;data&#8221; property of the
		/// event to the object that issued the command.</para>
		/// </summary>
		event Action<qx.eventx.type.Data> OnExecute;

		#endregion Events

		#region Methods

		/// <summary>
		/// <para>Fire the &#8220;execute&#8221; event on the command.</para>
		/// </summary>
		void Execute();

		/// <summary>
		/// <para>Return the current set command of this executable.</para>
		/// </summary>
		/// <returns>The current set command.</returns>
		qx.ui.core.Command GetCommand();

		/// <summary>
		/// <para>Set the command of this executable.</para>
		/// </summary>
		/// <param name="command">The command.</param>
		void SetCommand(qx.ui.core.Command command);

		#endregion Methods
    }
}