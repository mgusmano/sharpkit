
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:27 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/html/HTMLElement.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "HTMLElement")]
public partial class HtmlElement : Element
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('')")]
	public   HtmlElement() {}
	public  JsString id {get; set; }
	public  JsString title {get; set; }
	public  JsString lang {get; set; }
	public  bool translate {get; set; }
	public  JsString dir {get; set; }
	public  JsString className {get; set; }
	public  DOMTokenList classList {get; set; }
	public  int tabIndex {get; set; }
	public  bool draggable {get; set; }
	public  bool hidden {get; set; }
	public  JsString accessKey {get; set; }
	public  JsString innerHTML {get; set; }
	public  JsString innerText {get; set; }
	public  JsString outerHTML {get; set; }
	public  JsString outerText {get; set; }
	public  Element insertAdjacentElement(string where, Element element) { return default(Element); }
	public  void insertAdjacentHTML(string where, string html) {}
	public  void insertAdjacentText(string where, string text) {}
	public  HtmlCollection children {get; set; }
	public  JsString contentEditable {get; set; }
	public  bool isContentEditable {get; set; }
	public  bool spellcheck {get; set; }
	public  bool itemScope {get; set; }
	public  DOMSettableTokenList itemType {get; set; }
	public  JsString itemId {get; set; }
	public  DOMSettableTokenList itemRef {get; set; }
	public  DOMSettableTokenList itemProp {get; set; }
	public  object itemValue {get; set; }
	public  void click() {}
}

}