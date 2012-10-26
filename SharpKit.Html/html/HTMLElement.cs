
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/html/HTMLElement.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "HTMLElement")]
public partial class HtmlElement : Element
{
	public  JsString id {get; set; }
	public  JsString title {get; set; }
	public  JsString lang {get; set; }
	public  bool translate {get; set; }
	public  JsString dir {get; set; }
	public  JsString className {get; set; }
	public  DOMTokenList classList {get; set; }
	public  int tabIndex {get; set; }
	public  bool draggable {get; set; }
	public  bool hidden {get; set; }
	public  JsString accessKey {get; set; }
	public  JsString innerHTML {get; set; }
	public  JsString innerText {get; set; }
	public  JsString outerHTML {get; set; }
	public  JsString outerText {get; set; }
	public  Element insertAdjacentElement(string where, Element element) { return default(Element); }
	public  void insertAdjacentHTML(string where, string html) {}
	public  void insertAdjacentText(string where, string text) {}
	public  HtmlCollection children {get; set; }
	public  JsString contentEditable {get; set; }
	public  bool isContentEditable {get; set; }
	public  bool spellcheck {get; set; }
	public  bool itemScope {get; set; }
	public  DOMSettableTokenList itemType {get; set; }
	public  JsString itemId {get; set; }
	public  DOMSettableTokenList itemRef {get; set; }
	public  DOMSettableTokenList itemProp {get; set; }
	public  object itemValue {get; set; }
	public  void click() {}
}

}