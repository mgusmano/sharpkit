
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:26 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/dom/NodeFilter.idl

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
public partial class NodeFilter
{
	public  static short FILTER_ACCEPT = 1;
	public  static short FILTER_REJECT = 2;
	public  static short FILTER_SKIP = 3;
	public  static int SHOW_ALL = 0xFFFFFFF;
	public  static int SHOW_ELEMENT = 0x00000001;
	public  static int SHOW_ATTRIBUTE = 0x00000002;
	public  static int SHOW_TEXT = 0x00000004;
	public  static int SHOW_CDATA_SECTION = 0x00000008;
	public  static int SHOW_ENTITY_REFERENCE = 0x00000010;
	public  static int SHOW_ENTITY = 0x00000020;
	public  static int SHOW_PROCESSING_INSTRUCTION = 0x00000040;
	public  static int SHOW_COMMENT = 0x00000080;
	public  static int SHOW_DOCUMENT = 0x00000100;
	public  static int SHOW_DOCUMENT_TYPE = 0x00000200;
	public  static int SHOW_DOCUMENT_FRAGMENT = 0x00000400;
	public  static int SHOW_NOTATION = 0x00000800;
	public  short acceptNode(Node n) { return default(short); }
}

}