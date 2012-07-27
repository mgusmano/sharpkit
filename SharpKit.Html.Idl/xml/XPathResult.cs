
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:29 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/xml/XPathResult.idl

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
public partial class XPathResult
{
	public  static int ANY_TYPE = 0;
	public  static int NUMBER_TYPE = 1;
	public  static int STRING_TYPE = 2;
	public  static int BOOLEAN_TYPE = 3;
	public  static int UNORDERED_NODE_ITERATOR_TYPE = 4;
	public  static int ORDERED_NODE_ITERATOR_TYPE = 5;
	public  static int UNORDERED_NODE_SNAPSHOT_TYPE = 6;
	public  static int ORDERED_NODE_SNAPSHOT_TYPE = 7;
	public  static int ANY_UNORDERED_NODE_TYPE = 8;
	public  static int FIRST_ORDERED_NODE_TYPE = 9;
	public  int resultType {get; set; }
	public  double numberValue {get; set; }
	public  JsString stringValue {get; set; }
	public  bool booleanValue {get; set; }
	public  Node singleNodeValue {get; set; }
	public  bool invalidIteratorState {get; set; }
	public  int snapshotLength {get; set; }
	public  Node iterateNext() { return default(Node); }
	public  Node snapshotItem(int index) { return default(Node); }
}

}