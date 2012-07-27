
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:28 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/page/DOMSelection.idl

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