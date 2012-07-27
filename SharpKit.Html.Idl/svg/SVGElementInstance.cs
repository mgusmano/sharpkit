
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:28 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/svg/SVGElementInstance.idl

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

namespace SharpKit.Html.svg
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "SVGElementInstance")]
public partial class SvgElementInstance
{
	public  SvgElement correspondingElement {get; set; }
	public  SvgUseElement correspondingUseElement {get; set; }
	public  SvgElementInstance parentNode {get; set; }
	public  SvgElementInstanceList childNodes {get; set; }
	public  SvgElementInstance firstChild {get; set; }
	public  SvgElementInstance lastChild {get; set; }
	public  SvgElementInstance previousSibling {get; set; }
	public  SvgElementInstance nextSibling {get; set; }
	public  EventListener onabort {get; set; }
	public  EventListener onblur {get; set; }
	public  EventListener onchange {get; set; }
	public  EventListener onclick {get; set; }
	public  EventListener oncontextmenu {get; set; }
	public  EventListener ondblclick {get; set; }
	public  EventListener<ErrorEvent> onerror {get; set; }
	public  EventListener onfocus {get; set; }
	public  EventListener oninput {get; set; }
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
	public  EventListener onbeforecut {get; set; }
	public  EventListener oncut {get; set; }
	public  EventListener onbeforecopy {get; set; }
	public  EventListener oncopy {get; set; }
	public  EventListener onbeforepaste {get; set; }
	public  EventListener onpaste {get; set; }
	public  EventListener ondragenter {get; set; }
	public  EventListener ondragover {get; set; }
	public  EventListener ondragleave {get; set; }
	public  EventListener ondrop {get; set; }
	public  EventListener ondragstart {get; set; }
	public  EventListener ondrag {get; set; }
	public  EventListener ondragend {get; set; }
	public  EventListener onreset {get; set; }
	public  EventListener onresize {get; set; }
	public  EventListener onscroll {get; set; }
	public  EventListener onsearch {get; set; }
	public  EventListener onselect {get; set; }
	public  EventListener onselectstart {get; set; }
	public  EventListener onsubmit {get; set; }
	public  EventListener onunload {get; set; }
	public  void addEventListener(string type, EventListener listener) {}
	public  void addEventListener(string type, EventListener listener, bool useCapture) {}
	public  void removeEventListener(string type, EventListener listener) {}
	public  void removeEventListener(string type, EventListener listener, bool useCapture) {}
	public  bool dispatchEvent(DOMEvent @event) { return default(bool); }
}

}