using SharpKit.JavaScript;
using System;

namespace SharpKit.Html
{
    partial class HTMLDocument : Document
    {
    }
    partial class EventSource : EventTarget
    {
    }
    public class Exception : System.Exception
    {

        public Exception(string message)
            : base(message)
        {
        }
    }

    [JsType(JsMode.Prototype, Name = "CloseEvent", PropertiesAsFields = true)]
    public class CloseEvent : Event
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

    public partial class HTMLImageElement
    {
        public HTMLImageElement() { }
        public HTMLImageElement(int width) { }
        public HTMLImageElement(int width, int height) { }

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

}
