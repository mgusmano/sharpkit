
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser" at Thu, 20 Sep 2012 15:27:33 GMT

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/svg/SVGElementInstance.idl

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

namespace SharpKit.Html.svg
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "SVGElementInstance")]
public partial class SvgElementInstance
{
	public  SvgElement correspondingElement {get; set; }
	public  SvgUseElement correspondingUseElement {get; set; }
	public  SvgElementInstance parentNode {get; set; }
	public  SvgElementInstanceList childNodes {get; set; }
	public  SvgElementInstance firstChild {get; set; }
	public  SvgElementInstance lastChild {get; set; }
	public  SvgElementInstance previousSibling {get; set; }
	public  SvgElementInstance nextSibling {get; set; }
	public  EventListener onabort {get; set; }
	public  EventListener onblur {get; set; }
	public  EventListener onchange {get; set; }
	public  EventListener onclick {get; set; }
	public  EventListener oncontextmenu {get; set; }
	public  EventListener ondblclick {get; set; }
	public  EventListener<ErrorEvent> onerror {get; set; }
	public  EventListener onfocus {get; set; }
	public  EventListener oninput {get; set; }
	public  EventListener onkeydown {get; set; }
	public  EventListener onkeypress {get; set; }
	public  EventListener onkeyup {get; set; }
	public  EventListener onload {get; set; }
	public  EventListener onmousedown {get; set; }
	public  EventListener onmousemove {get; set; }
	public  EventListener onmouseout {get; set; }
	public  EventListener onmouseover {get; set; }
	public  EventListener onmouseup {get; set; }
	public  EventListener onmousewheel {get; set; }
	public  EventListener onbeforecut {get; set; }
	public  EventListener oncut {get; set; }
	public  EventListener onbeforecopy {get; set; }
	public  EventListener oncopy {get; set; }
	public  EventListener onbeforepaste {get; set; }
	public  EventListener onpaste {get; set; }
	public  EventListener ondragenter {get; set; }
	public  EventListener ondragover {get; set; }
	public  EventListener ondragleave {get; set; }
	public  EventListener ondrop {get; set; }
	public  EventListener ondragstart {get; set; }
	public  EventListener ondrag {get; set; }
	public  EventListener ondragend {get; set; }
	public  EventListener onreset {get; set; }
	public  EventListener onresize {get; set; }
	public  EventListener onscroll {get; set; }
	public  EventListener onsearch {get; set; }
	public  EventListener onselect {get; set; }
	public  EventListener onselectstart {get; set; }
	public  EventListener onsubmit {get; set; }
	public  EventListener onunload {get; set; }
	public  void addEventListener(string type, EventListener listener) {}
	public  void addEventListener(string type, EventListener listener, bool useCapture) {}
	public  void removeEventListener(string type, EventListener listener) {}
	public  void removeEventListener(string type, EventListener listener, bool useCapture) {}
	public  bool dispatchEvent(DOMEvent @event) { return default(bool); }
}

}