
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser" at Sun, 29 Jul 2012 15:27:58 GMT

  Content was generated from IDL file:
	http://trac.webkit.org/browser/trunk/Source/WebCore/page/DOMSelection.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class Selection
{
	public  Node anchorNode {get; set; }
	public  int anchorOffset {get; set; }
	public  Node focusNode {get; set; }
	public  int focusOffset {get; set; }
	public  bool isCollapsed {get; set; }
	public  int rangeCount {get; set; }
	public  void collapse(Node node, int index) {}
	public  void collapseToEnd() {}
	public  void collapseToStart() {}
	public  void deleteFromDocument() {}
	public  bool containsNode(Node node, bool allowPartial) { return default(bool); }
	public  void selectAllChildren(Node node) {}
	public  void extend(Node node, int offset) {}
	public  Range getRangeAt(int index) { return default(Range); }
	public  void removeAllRanges() {}
	public  void addRange(Range range) {}
	public  JsString toString() { return default(JsString); }
	public  Node baseNode {get; set; }
	public  int baseOffset {get; set; }
	public  Node extentNode {get; set; }
	public  int extentOffset {get; set; }
	public  JsString type {get; set; }
	public  void modify(string alter, string direction, string granularity) {}
	public  void setBaseAndExtent(Node baseNode, int baseOffset, Node extentNode, int extentOffset) {}
	public  void setPosition(Node node, int offset) {}
	public  void empty() {}
}

}