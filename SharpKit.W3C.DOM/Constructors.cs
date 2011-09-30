using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using org.w3c.dom.html;

namespace org.w3c.dom.websocket
{
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
        public Function onopen { get; set; }
        public JsAction<MessageEvent> onmessage { get; set; }
        public Function onclose { get; set; }
        public bool send(string data) { return false; }
        public void close() { }
    }
}
