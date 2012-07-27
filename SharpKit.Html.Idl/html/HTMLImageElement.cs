
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:27 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/html/HTMLImageElement.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "HTMLImageElement")]
public partial class HtmlImageElement : HtmlElement
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('image')")]
	public   HtmlImageElement() {}
	public  JsString name {get; set; }
	public  JsString align {get; set; }
	public  JsString alt {get; set; }
	public  JsString border {get; set; }
	public  JsString crossOrigin {get; set; }
	public  int height {get; set; }
	public  int hspace {get; set; }
	public  bool isMap {get; set; }
	public  JsString longDesc {get; set; }
	public  JsString src {get; set; }
	public  JsString useMap {get; set; }
	public  int vspace {get; set; }
	public  int width {get; set; }
	public  bool complete {get; set; }
	public  JsString lowsrc {get; set; }
	public  int naturalHeight {get; set; }
	public  int naturalWidth {get; set; }
	public  int x {get; set; }
	public  int y {get; set; }
}

}