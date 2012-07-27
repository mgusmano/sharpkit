
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:29 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/svg/SVGSwitchElement.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "SVGSwitchElement")]
public partial class SvgSwitchElement : SvgElement, SvgTests, SvgLangSpace, SvgExternalResourcesRequired, SvgStylable, SvgTransformable
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('switch')")]
	public   SvgSwitchElement() {}
	public  SvgStringList requiredFeatures {get; set; }
	public  SvgStringList requiredExtensions {get; set; }
	public  SvgStringList systemLanguage {get; set; }
	public  bool hasExtension(string extension) { return default(bool); }
	public  JsString xmllang {get; set; }
	public  JsString xmlspace {get; set; }
	public  SvgAnimatedBoolean externalResourcesRequired {get; set; }
	public  SvgAnimatedString className {get; set; }
	public  CssStyleDeclaration style {get; set; }
	public  CssValue getPresentationAttribute(string name) { return default(CssValue); }
	public  SvgAnimatedTransformList transform {get; set; }
	public  SvgElement nearestViewportElement {get; set; }
	public  SvgElement farthestViewportElement {get; set; }
	public  SvgRect getBBox() { return default(SvgRect); }
	public  SvgMatrix getCTM() { return default(SvgMatrix); }
	public  SvgMatrix getScreenCTM() { return default(SvgMatrix); }
	public  SvgMatrix getTransformToElement(SvgElement element) { return default(SvgMatrix); }
}

}