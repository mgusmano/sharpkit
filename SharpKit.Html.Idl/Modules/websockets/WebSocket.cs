
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser" at Thu, 20 Sep 2012 15:27:33 GMT

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/Modules/websockets/WebSocket.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as "partial". Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

********************************************************************************************************

  Copyright (C) 2012 Sebastian Loncar, Web: http://loncar.de
  Copyright (C) 2009 Apple Inc. All Rights Reserved.

  MIT License:

  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
  associated documentation files (the "Software"), to deal in the Software without restriction, 
  including without limitation the rights to use, copy, modify, merge, publish, distribute,
  sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all copies or substantial
  portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
  NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES
  OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*******************************************************************************************************/

using System;

namespace SharpKit.Html
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
public partial class WebSocket
{
	public  JsString URL {get; set; }
	public  JsString url {get; set; }
	public  static int CONNECTING = 0;
	public  static int OPEN = 1;
	public  static int CLOSING = 2;
	public  static int CLOSED = 3;
	public  int readyState {get; set; }
	public  int bufferedAmount {get; set; }
	public  EventListener onopen {get; set; }
	public  EventListener<MessageEvent> onmessage {get; set; }
	public  EventListener<ErrorEvent> onerror {get; set; }
	public  EventListener<CloseEvent> onclose {get; set; }
	public  JsString protocol {get; set; }
	public  JsString extensions {get; set; }
	public  JsString binaryType {get; set; }
	public  bool send(string data) { return default(bool); }
	public  void close() {}
	public  void close(int code) {}
	public  void close(int code, string reason) {}
	public  void addEventListener(string type, EventListener listener) {}
	public  void addEventListener(string type, EventListener listener, bool useCapture) {}
	public  void removeEventListener(string type, EventListener listener) {}
	public  void removeEventListener(string type, EventListener listener, bool useCapture) {}
	public  bool dispatchEvent(DOMEvent evt) { return default(bool); }
}

}