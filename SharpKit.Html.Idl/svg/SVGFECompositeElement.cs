
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:28 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/svg/SVGFECompositeElement.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "SVGFECompositeElement")]
public partial class SvgFECompositeElement : SvgElement, SvgFilterPrimitiveStandardAttributes
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('fecomposite')")]
	public   SvgFECompositeElement() {}
	public  static int SVG_FECOMPOSITE_OPERATOR_UNKNOWN = 0;
	public  static int SVG_FECOMPOSITE_OPERATOR_OVER = 1;
	public  static int SVG_FECOMPOSITE_OPERATOR_IN = 2;
	public  static int SVG_FECOMPOSITE_OPERATOR_OUT = 3;
	public  static int SVG_FECOMPOSITE_OPERATOR_ATOP = 4;
	public  static int SVG_FECOMPOSITE_OPERATOR_XOR = 5;
	public  static int SVG_FECOMPOSITE_OPERATOR_ARITHMETIC = 6;
	public  SvgAnimatedString in1 {get; set; }
	public  SvgAnimatedString in2 {get; set; }
	public  SvgAnimatedEnumeration @operator {get; set; }
	public  SvgAnimatedNumber k1 {get; set; }
	public  SvgAnimatedNumber k2 {get; set; }
	public  SvgAnimatedNumber k3 {get; set; }
	public  SvgAnimatedNumber k4 {get; set; }
	public  SvgAnimatedLength x {get; set; }
	public  SvgAnimatedLength y {get; set; }
	public  SvgAnimatedLength width {get; set; }
	public  SvgAnimatedLength height {get; set; }
	public  SvgAnimatedString result {get; set; }
	public  SvgAnimatedString className {get; set; }
	public  CssStyleDeclaration style {get; set; }
	public  CssValue getPresentationAttribute(string name) { return default(CssValue); }
}

}