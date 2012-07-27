
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:26 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/dom/Element.idl

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
public partial class Element : Node
{
	public  JsString tagName {get; set; }
	public  JsString getAttribute(string name) { return default(JsString); }
	public  void setAttribute(string name, string value) {}
	public  void removeAttribute(string name) {}
	public  Attr getAttributeNode(string name) { return default(Attr); }
	public  Attr setAttributeNode(Attr newAttr) { return default(Attr); }
	public  Attr removeAttributeNode(Attr oldAttr) { return default(Attr); }
	public  NodeList getElementsByTagName(string name) { return default(NodeList); }
	public  JsString getAttributeNS(string namespaceURI, string localName) { return default(JsString); }
	public  void setAttributeNS(string namespaceURI, string qualifiedName, string value) {}
	public  void removeAttributeNS(string namespaceURI, string localName) {}
	public  NodeList getElementsByTagNameNS(string namespaceURI, string localName) { return default(NodeList); }
	public  Attr getAttributeNodeNS(string namespaceURI, string localName) { return default(Attr); }
	public  Attr setAttributeNodeNS(Attr newAttr) { return default(Attr); }
	public  bool hasAttribute(string name) { return default(bool); }
	public  bool hasAttributeNS(string namespaceURI, string localName) { return default(bool); }
	public  CssStyleDeclaration style {get; set; }
	public  int offsetLeft {get; set; }
	public  int offsetTop {get; set; }
	public  int offsetWidth {get; set; }
	public  int offsetHeight {get; set; }
	public  Element offsetParent {get; set; }
	public  int clientLeft {get; set; }
	public  int clientTop {get; set; }
	public  int clientWidth {get; set; }
	public  int clientHeight {get; set; }
	public  int scrollLeft {get; set; }
	public  int scrollTop {get; set; }
	public  int scrollWidth {get; set; }
	public  int scrollHeight {get; set; }
	public  void focus() {}
	public  void blur() {}
	public  void scrollIntoView() {}
	public  void scrollIntoView(bool alignWithTop) {}
	public  void scrollIntoViewIfNeeded() {}
	public  void scrollIntoViewIfNeeded(bool centerIfNeeded) {}
	public  void scrollByLines(int lines) {}
	public  void scrollByPages(int pages) {}
	public  NodeList getElementsByClassName(string name) { return default(NodeList); }
	public  DOMStringMap dataset {get; set; }
	public  Element querySelector(string selectors) { return default(Element); }
	public  NodeList querySelectorAll(string selectors) { return default(NodeList); }
	public  Element firstElementChild {get; set; }
	public  Element lastElementChild {get; set; }
	public  Element previousElementSibling {get; set; }
	public  Element nextElementSibling {get; set; }
	public  int childElementCount {get; set; }
	public  ClientRectList getClientRects() { return default(ClientRectList); }
	public  ClientRect getBoundingClientRect() { return default(ClientRect); }
	public  EventListener onabort {get; set; }
	public  EventListener onblur {get; set; }
	public  EventListener onchange {get; set; }
	public  EventListener onclick {get; set; }
	public  EventListener oncontextmenu {get; set; }
	public  EventListener ondblclick {get; set; }
	public  EventListener ondrag {get; set; }
	public  EventListener ondragend {get; set; }
	public  EventListener ondragenter {get; set; }
	public  EventListener ondragleave {get; set; }
	public  EventListener ondragover {get; set; }
	public  EventListener ondragstart {get; set; }
	public  EventListener ondrop {get; set; }
	public  EventListener<ErrorEvent> onerror {get; set; }
	public  EventListener onfocus {get; set; }
	public  EventListener oninput {get; set; }
	public  EventListener oninvalid {get; set; }
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
	public  EventListener onscroll {get; set; }
	public  EventListener onselect {get; set; }
	public  EventListener onsubmit {get; set; }
	public  EventListener onbeforecut {get; set; }
	public  EventListener oncut {get; set; }
	public  EventListener onbeforecopy {get; set; }
	public  EventListener oncopy {get; set; }
	public  EventListener onbeforepaste {get; set; }
	public  EventListener onpaste {get; set; }
	public  EventListener onreset {get; set; }
	public  EventListener onsearch {get; set; }
	public  EventListener onselectstart {get; set; }
	public  EventListener ontouchstart {get; set; }
	public  EventListener ontouchmove {get; set; }
	public  EventListener ontouchend {get; set; }
	public  EventListener ontouchcancel {get; set; }
	public  EventListener onwebkitfullscreenchange {get; set; }
	public  EventListener onwebkitfullscreenerror {get; set; }
}

}