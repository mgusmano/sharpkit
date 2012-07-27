
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:26 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/dom/Node.idl

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
public partial class Node
{
	public  static int ELEMENT_NODE = 1;
	public  static int ATTRIBUTE_NODE = 2;
	public  static int TEXT_NODE = 3;
	public  static int CDATA_SECTION_NODE = 4;
	public  static int ENTITY_REFERENCE_NODE = 5;
	public  static int ENTITY_NODE = 6;
	public  static int PROCESSING_INSTRUCTION_NODE = 7;
	public  static int COMMENT_NODE = 8;
	public  static int DOCUMENT_NODE = 9;
	public  static int DOCUMENT_TYPE_NODE = 10;
	public  static int DOCUMENT_FRAGMENT_NODE = 11;
	public  static int NOTATION_NODE = 12;
	public  JsString nodeName {get; set; }
	public  JsString nodeValue {get; set; }
	public  int nodeType {get; set; }
	public  Node parentNode {get; set; }
	public  NodeList childNodes {get; set; }
	public  Node firstChild {get; set; }
	public  Node lastChild {get; set; }
	public  Node previousSibling {get; set; }
	public  Node nextSibling {get; set; }
	public  NamedNodeMap attributes {get; set; }
	public  Document ownerDocument {get; set; }
	public  Node insertBefore(Node newChild, Node refChild) { return default(Node); }
	public  Node replaceChild(Node newChild, Node oldChild) { return default(Node); }
	public  Node removeChild(Node oldChild) { return default(Node); }
	public  Node appendChild(Node newChild) { return default(Node); }
	public  bool hasChildNodes() { return default(bool); }
	public  Node cloneNode(bool deep) { return default(Node); }
	public  void normalize() {}
	public  bool isSupported(string feature, string version) { return default(bool); }
	public  JsString namespaceURI {get; set; }
	public  JsString prefix {get; set; }
	public  JsString localName {get; set; }
	public  bool hasAttributes() { return default(bool); }
	public  JsString baseURI {get; set; }
	public  JsString textContent {get; set; }
	public  bool isSameNode(Node other) { return default(bool); }
	public  bool isEqualNode(Node other) { return default(bool); }
	public  JsString lookupPrefix(string namespaceURI) { return default(JsString); }
	public  bool isDefaultNamespace(string namespaceURI) { return default(bool); }
	public  JsString lookupNamespaceURI(string prefix) { return default(JsString); }
	public  static int DOCUMENT_POSITION_DISCONNECTED = 0x01;
	public  static int DOCUMENT_POSITION_PRECEDING = 0x02;
	public  static int DOCUMENT_POSITION_FOLLOWING = 0x04;
	public  static int DOCUMENT_POSITION_CONTAINS = 0x08;
	public  static int DOCUMENT_POSITION_CONTAINED_BY = 0x10;
	public  static int DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC = 0x20;
	public  int compareDocumentPosition(Node other) { return default(int); }
	public  bool contains(Node other) { return default(bool); }
	public  Element parentElement {get; set; }
	public  void addEventListener(string type, EventListener listener) {}
	public  void addEventListener(string type, EventListener listener, bool useCapture) {}
	public  void removeEventListener(string type, EventListener listener) {}
	public  void removeEventListener(string type, EventListener listener, bool useCapture) {}
	public  bool dispatchEvent(DOMEvent @event) { return default(bool); }
}

}