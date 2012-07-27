
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:29 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/xml/XMLHttpRequest.idl

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

namespace SharpKit.Html
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class XMLHttpRequest
{
	public   XMLHttpRequest() {}
	public  EventListener onabort {get; set; }
	public  EventListener<ErrorEvent> onerror {get; set; }
	public  EventListener onload {get; set; }
	public  EventListener onloadend {get; set; }
	public  EventListener onloadstart {get; set; }
	public  EventListener<ProgressEvent> onprogress {get; set; }
	public  EventListener onreadystatechange {get; set; }
	public  static int UNSENT = 0;
	public  static int OPENED = 1;
	public  static int HEADERS_RECEIVED = 2;
	public  static int LOADING = 3;
	public  static int DONE = 4;
	public  int readyState {get; set; }
	public  bool withCredentials {get; set; }
	public  void open(string method, string url) {}
	public  void open(string method, string url, bool async) {}
	public  void open(string method, string url, bool async, string user) {}
	public  void open(string method, string url, bool async, string user, string password) {}
	public  void setRequestHeader(string header, string value) {}
	public  void send() {}
	public  void send(ArrayBuffer data) {}
	public  void send(ArrayBufferView data) {}
	public  void send(Blob data) {}
	public  void send(Document data) {}
	public  void send(string data) {}
	public  void send(FormData data) {}
	public  void abort() {}
	public  XMLHttpRequestUpload upload {get; set; }
	public  JsString getAllResponseHeaders() { return default(JsString); }
	public  JsString getResponseHeader(string header) { return default(JsString); }
	public  JsString responseText {get; set; }
	public  Document responseXML {get; set; }
	public  JsString responseType {get; set; }
	public  object response {get; set; }
	public  int status {get; set; }
	public  JsString statusText {get; set; }
	public  void overrideMimeType(string @override) {}
	public  void addEventListener(string type, EventListener listener) {}
	public  void addEventListener(string type, EventListener listener, bool useCapture) {}
	public  void removeEventListener(string type, EventListener listener) {}
	public  void removeEventListener(string type, EventListener listener, bool useCapture) {}
	public  bool dispatchEvent(DOMEvent evt) { return default(bool); }
}

}