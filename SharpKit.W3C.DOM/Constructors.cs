using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using org.w3c.dom.html;

namespace org.w3c.dom.websocket
{
    [JsType(JsMode.Prototype, Name = "WebSocket")]
    public class WebSocket
    {
        public WebSocket(string url) { }
        public WebSocket(string url, JsString protocol) { }
        public JsString uRL { get; private set; }
        public const short CONNECTING = 0;
        public const short OPEN = 1;
        public const short CLOSED = 2;
        public short readyState { get; private set; }
        public int bufferedAmount { get; private set; }
        public JsAction onopen { get; set; }
        public JsAction<MessageEvent> onmessage { get; set; }
        public JsAction<CloseEvent> onclose { get; set; }
        public JsAction<MessageEvent> onerror { get; set; }
        public bool send(string data) { return false; }
        public void close() { }
    }

    [JsType(JsMode.Prototype, Name = "CloseEvent", PropertiesAsFields=true)]
    public interface CloseEvent : org.w3c.dom.events.Event
    {
        /// <summary>
        /// represents whether the connection closed cleanly or not.
        /// </summary>
        /// <value>
        ///   <c>true</c> if closed cleanly; otherwise, <c>false</c>.
        /// </value>
        bool wasClean { get; }
        /// <summary>
        /// represents the WebSocket connection close code provided by the server.
        /// </summary>
        UInt16 code { get; }
        /// <summary>
        ///  represents the WebSocket connection close reason provided by the server.
        /// </summary>
        JsString reason { get; }
    }
}