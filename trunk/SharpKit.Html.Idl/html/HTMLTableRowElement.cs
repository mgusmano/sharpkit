
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:27 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/html/HTMLTableRowElement.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "HTMLTableRowElement")]
public partial class HtmlTableRowElement : HtmlElement
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('tablerow')")]
	public   HtmlTableRowElement() {}
	public  int rowIndex {get; set; }
	public  int sectionRowIndex {get; set; }
	public  HtmlCollection cells {get; set; }
	public  JsString align {get; set; }
	public  JsString bgColor {get; set; }
	public  JsString ch {get; set; }
	public  JsString chOff {get; set; }
	public  JsString vAlign {get; set; }
	public  HtmlElement insertCell(int index) { return default(HtmlElement); }
	public  void deleteCell(int index) {}
}

}