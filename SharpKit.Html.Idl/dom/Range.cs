
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:26 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/dom/Range.idl

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
public partial class Range
{
	public  Node startContainer {get; set; }
	public  int startOffset {get; set; }
	public  Node endContainer {get; set; }
	public  int endOffset {get; set; }
	public  bool collapsed {get; set; }
	public  Node commonAncestorContainer {get; set; }
	public  void setStart(Node refNode, int offset) {}
	public  void setEnd(Node refNode, int offset) {}
	public  void setStartBefore(Node refNode) {}
	public  void setStartAfter(Node refNode) {}
	public  void setEndBefore(Node refNode) {}
	public  void setEndAfter(Node refNode) {}
	public  void collapse(bool toStart) {}
	public  void selectNode(Node refNode) {}
	public  void selectNodeContents(Node refNode) {}
	public  static int START_TO_START = 0;
	public  static int START_TO_END = 1;
	public  static int END_TO_END = 2;
	public  static int END_TO_START = 3;
	public  short compareBoundaryPoints(object how, Range sourceRange) { return default(short); }
	public  void deleteContents() {}
	public  DocumentFragment extractContents() { return default(DocumentFragment); }
	public  DocumentFragment cloneContents() { return default(DocumentFragment); }
	public  void insertNode(Node newNode) {}
	public  void surroundContents(Node newParent) {}
	public  Range cloneRange() { return default(Range); }
	public  JsString toString() { return default(JsString); }
	public  void detach() {}
	public  ClientRectList getClientRects() { return default(ClientRectList); }
	public  ClientRect getBoundingClientRect() { return default(ClientRect); }
	public  DocumentFragment createContextualFragment(string html) { return default(DocumentFragment); }
	public  bool intersectsNode(Node refNode) { return default(bool); }
	public  short compareNode(Node refNode) { return default(short); }
	public  static int NODE_BEFORE = 0;
	public  static int NODE_AFTER = 1;
	public  static int NODE_BEFORE_AND_AFTER = 2;
	public  static int NODE_INSIDE = 3;
	public  short comparePoint(Node refNode, int offset) { return default(short); }
	public  bool isPointInRange(Node refNode, int offset) { return default(bool); }
	public  void expand(string unit) {}
}

}