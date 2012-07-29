
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser" at Sun, 29 Jul 2012 15:27:57 GMT

  Content was generated from IDL file:
	http://trac.webkit.org/browser/trunk/Source/WebCore/html/HTMLBodyElement.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as "partial". Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

********************************************************************************************************

	Copyright (C) 2012 Sebastian Loncar
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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "HTMLBodyElement")]
public partial class HtmlBodyElement : HtmlElement
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('body')")]
	public   HtmlBodyElement() {}
	public  JsString aLink {get; set; }
	public  JsString background {get; set; }
	public  JsString bgColor {get; set; }
	public  JsString link {get; set; }
	public  JsString text {get; set; }
	public  JsString vLink {get; set; }
	public  EventListener onbeforeunload {get; set; }
	public  EventListener onhashchange {get; set; }
	public  EventListener<MessageEvent> onmessage {get; set; }
	public  EventListener onoffline {get; set; }
	public  EventListener ononline {get; set; }
	public  EventListener onpopstate {get; set; }
	public  EventListener onresize {get; set; }
	public  EventListener<StorageEvent> onstorage {get; set; }
	public  EventListener onunload {get; set; }
	public  EventListener onorientationchange {get; set; }
	public  EventListener onblur {get; set; }
	public  EventListener<ErrorEvent> onerror {get; set; }
	public  EventListener onfocus {get; set; }
	public  EventListener onload {get; set; }
}

}