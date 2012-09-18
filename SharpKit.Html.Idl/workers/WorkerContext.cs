
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser" at Tue, 18 Sep 2012 07:57:02 GMT

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/workers/WorkerContext.idl

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

namespace SharpKit.Html.threads
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
public partial class WorkerContext
{
	public  WorkerContext self {get; set; }
	public  WorkerLocation location {get; set; }
	public  void close() {}
	public  EventListener<ErrorEvent> onerror {get; set; }
	public  void importScripts() {}
	public  WorkerNavigator navigator {get; set; }
	public  int setTimeout(object handler, int timeout) { return default(int); }
	public  void clearTimeout(int handle) {}
	public  int setInterval(object handler, int timeout) { return default(int); }
	public  void clearInterval(int handle) {}
	public  void addEventListener(string type, EventListener listener) {}
	public  void addEventListener(string type, EventListener listener, bool useCapture) {}
	public  void removeEventListener(string type, EventListener listener) {}
	public  void removeEventListener(string type, EventListener listener, bool useCapture) {}
	public  bool dispatchEvent(DOMEvent evt) { return default(bool); }
	public  MessageEvent MessageEvent {get; set; }
	public  WorkerLocation WorkerLocation {get; set; }
	public  EventSource EventSource {get; set; }
	public  XMLHttpRequest XMLHttpRequest {get; set; }
	public  ArrayBuffer ArrayBuffer {get; set; }
	public  Int8Array Int8Array {get; set; }
	public  Uint8Array Uint8Array {get; set; }
	public  Uint8Array Uint8ClampedArray {get; set; }
	public  Int16Array Int16Array {get; set; }
	public  Uint16Array Uint16Array {get; set; }
	public  Int32Array Int32Array {get; set; }
	public  Uint32Array Uint32Array {get; set; }
	public  Float32Array Float32Array {get; set; }
	public  Float64Array Float64Array {get; set; }
	public  DataView DataView {get; set; }
}

}