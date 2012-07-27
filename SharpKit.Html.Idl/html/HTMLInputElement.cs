
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:27 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/html/HTMLInputElement.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "HTMLInputElement")]
public partial class HtmlInputElement : HtmlElement
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('input')")]
	public   HtmlInputElement() {}
	public  JsString accept {get; set; }
	public  JsString alt {get; set; }
	public  JsString autocomplete {get; set; }
	public  bool autofocus {get; set; }
	public  bool defaultChecked {get; set; }
	public  bool @checked {get; set; }
	public  JsString dirName {get; set; }
	public  bool disabled {get; set; }
	public  HtmlFormElement form {get; set; }
	public  FileList files {get; set; }
	public  JsString formAction {get; set; }
	public  JsString formEnctype {get; set; }
	public  JsString formMethod {get; set; }
	public  bool formNoValidate {get; set; }
	public  JsString formTarget {get; set; }
	public  int height {get; set; }
	public  bool indeterminate {get; set; }
	public  HtmlElement list {get; set; }
	public  JsString max {get; set; }
	public  int maxLength {get; set; }
	public  JsString min {get; set; }
	public  bool multiple {get; set; }
	public  JsString name {get; set; }
	public  JsString pattern {get; set; }
	public  JsString placeholder {get; set; }
	public  bool @readOnly {get; set; }
	public  bool required {get; set; }
	public  int size {get; set; }
	public  JsString src {get; set; }
	public  JsString step {get; set; }
	public  JsString type {get; set; }
	public  JsString defaultValue {get; set; }
	public  JsString value {get; set; }
	public  object valueAsDate {get; set; }
	public  double valueAsNumber {get; set; }
	public  void stepUp() {}
	public  void stepUp(int n) {}
	public  void stepDown() {}
	public  void stepDown(int n) {}
	public  int width {get; set; }
	public  bool willValidate {get; set; }
	public  ValidityState validity {get; set; }
	public  JsString validationMessage {get; set; }
	public  bool checkValidity() { return default(bool); }
	public  void setCustomValidity(string error) {}
	public  NodeList labels {get; set; }
	public  void select() {}
	public  int selectionStart {get; set; }
	public  int selectionEnd {get; set; }
	public  JsString selectionDirection {get; set; }
	public  void setSelectionRange(int start, int end) {}
	public  void setSelectionRange(int start, int end, string direction) {}
	public  JsString align {get; set; }
	public  JsString useMap {get; set; }
	public  bool incremental {get; set; }
	public  EventListener onwebkitspeechchange {get; set; }
	public  JsString capture {get; set; }
}

}