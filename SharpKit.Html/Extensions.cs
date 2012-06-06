using SharpKit.JavaScript;
using System;

namespace SharpKit.Html
{
	partial class HtmlDocument : Document
	{
		public new HtmlElement documentElement { get; private set; }
		public new HtmlElement createElement(string tagName) { return default(HtmlElement); }
		public new HtmlElement getElementById(string elementId) { return default(HtmlElement); }
		public DOMEvent createEvent(string eventInterface) { return default(DOMEvent); }

	}

	[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
	public partial class HtmlCollection<T> where T : HtmlElement
	{

		// HTMLCollection
		public int length { get; private set; }
		[JsProperty(NativeIndexer = true)]
		public T this[int index] { get { return default(T); } }
		[JsProperty(NativeIndexer = true)]
		public T this[string name] { get { return default(T); } }
	}

	partial class HtmlElement
	{
		public new HtmlDocument ownerDocument { get; set; }
	}
	partial class EventSource : EventTarget
	{
	}
	public class BaseException : System.Exception
	{

		public BaseException(string message)
			: base(message) {
		}
	}

	[JsType(JsMode.Prototype, Name = "CloseEvent", PropertiesAsFields = true)]
	public class CloseEvent : DOMEvent
	{
		/// <summary>
		/// represents whether the connection closed cleanly or not.
		/// </summary>
		/// <value>
		///   <c>true</c> if closed cleanly; otherwise, <c>false</c>.
		/// </value>
		bool wasClean { get { return default(bool); } }
		/// <summary>
		/// represents the WebSocket connection close code provided by the server.
		/// </summary>
		UInt16 code { get { return default(UInt16); } }
		/// <summary>
		///  represents the WebSocket connection close reason provided by the server.
		/// </summary>
		string reason { get { return default(string); } }
	}

	public partial class HtmlImageElement
	{
		public HtmlImageElement() { }
		public HtmlImageElement(int width) { }
		public HtmlImageElement(int width, int height) { }

	}

	public partial class HtmlAudioElement
	{
		public HtmlAudioElement() { }
		public HtmlAudioElement(string src) { }
	}

	[JsDelegate(NativeDelegates = true)]
	public delegate void PositionCallback(Position position);
	[JsDelegate(NativeDelegates = true)]
	public delegate void PositionErrorCallback(PositionError error);
	[JsDelegate(NativeDelegates = true)]
	public delegate void DatabaseCallback(Database database);

	[JsDelegate(NativeDelegates = true)]
	public delegate void SQLStatementCallback(SQLTransaction transaction, SQLResultSet resultSet);


	[JsDelegate(NativeDelegates = true)]
	public delegate void SQLStatementErrorCallback(SQLTransaction transaction, SQLError error);


	[JsDelegate(NativeDelegates = true)]
	public delegate void SQLTransactionCallback(SQLTransaction transaction);

	[JsDelegate(NativeDelegates = true)]
	public delegate void SQLTransactionErrorCallback(SQLError error);

	[JsDelegate(NativeDelegates = true)]
	public delegate void SQLTransactionSyncCallback(SQLTransactionSync transaction);

	[JsDelegate(NativeDelegates = true)]
	public delegate void SQLVoidCallback();

	//[JsDelegate(NativeDelegates = true)]
	[JsDelegate(NativeDelegates = true)]
	public delegate void Function();



	partial class CSSStyleDeclaration
	{
		public JsString borderRadius { get; set; }
		public JsString borderTopLeftRadius { get; set; }
		public JsString borderTopRightRadius { get; set; }
		public JsString borderBottomRightRadius { get; set; }
		public JsString borderBottomLeftRadius { get; set; }
	}

}
