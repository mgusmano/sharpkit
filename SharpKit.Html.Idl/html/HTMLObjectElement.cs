
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:27 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/html/HTMLObjectElement.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "HTMLObjectElement")]
public partial class HtmlObjectElement : HtmlElement
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('object')")]
	public   HtmlObjectElement() {}
	public  HtmlFormElement form {get; set; }
	public  JsString code {get; set; }
	public  JsString align {get; set; }
	public  JsString archive {get; set; }
	public  JsString border {get; set; }
	public  JsString codeBase {get; set; }
	public  JsString codeType {get; set; }
	public  JsString data {get; set; }
	public  bool declare {get; set; }
	public  JsString height {get; set; }
	public  int hspace {get; set; }
	public  JsString name {get; set; }
	public  JsString standby {get; set; }
	public  JsString type {get; set; }
	public  JsString useMap {get; set; }
	public  int vspace {get; set; }
	public  JsString width {get; set; }
	public  bool willValidate {get; set; }
	public  ValidityState validity {get; set; }
	public  JsString validationMessage {get; set; }
	public  bool checkValidity() { return default(bool); }
	public  void setCustomValidity(string error) {}
	public  Document contentDocument {get; set; }
}

}