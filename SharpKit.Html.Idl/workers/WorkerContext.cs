
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:29 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/workers/WorkerContext.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as 'partial'. Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

*****************************************************************************************************

  This library is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  This library is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.

*****************************************************************************************************/

using System;

namespace SharpKit.Html.threads
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
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