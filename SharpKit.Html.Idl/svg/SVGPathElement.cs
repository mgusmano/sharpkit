
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:28 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/svg/SVGPathElement.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "SVGPathElement")]
public partial class SvgPathElement : SvgElement, SvgTests, SvgLangSpace, SvgExternalResourcesRequired, SvgStylable, SvgTransformable
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('path')")]
	public   SvgPathElement() {}
	public  SvgAnimatedNumber pathLength {get; set; }
	public  double getTotalLength() { return default(double); }
	public  SvgPoint getPointAtLength(double distance) { return default(SvgPoint); }
	public  int getPathSegAtLength(double distance) { return default(int); }
	public  SvgPathSegClosePath createSVGPathSegClosePath() { return default(SvgPathSegClosePath); }
	public  SvgPathSegMovetoAbs createSVGPathSegMovetoAbs(double x, double y) { return default(SvgPathSegMovetoAbs); }
	public  SvgPathSegMovetoRel createSVGPathSegMovetoRel(double x, double y) { return default(SvgPathSegMovetoRel); }
	public  SvgPathSegLinetoAbs createSVGPathSegLinetoAbs(double x, double y) { return default(SvgPathSegLinetoAbs); }
	public  SvgPathSegLinetoRel createSVGPathSegLinetoRel(double x, double y) { return default(SvgPathSegLinetoRel); }
	public  SvgPathSegCurvetoCubicAbs createSVGPathSegCurvetoCubicAbs(double x, double y, double x1, double y1, double x2, double y2) { return default(SvgPathSegCurvetoCubicAbs); }
	public  SvgPathSegCurvetoCubicRel createSVGPathSegCurvetoCubicRel(double x, double y, double x1, double y1, double x2, double y2) { return default(SvgPathSegCurvetoCubicRel); }
	public  SvgPathSegCurvetoQuadraticAbs createSVGPathSegCurvetoQuadraticAbs(double x, double y, double x1, double y1) { return default(SvgPathSegCurvetoQuadraticAbs); }
	public  SvgPathSegCurvetoQuadraticRel createSVGPathSegCurvetoQuadraticRel(double x, double y, double x1, double y1) { return default(SvgPathSegCurvetoQuadraticRel); }
	public  SvgPathSegArcAbs createSVGPathSegArcAbs(double x, double y, double r1, double r2, double angle, bool largeArcFlag, bool sweepFlag) { return default(SvgPathSegArcAbs); }
	public  SvgPathSegArcRel createSVGPathSegArcRel(double x, double y, double r1, double r2, double angle, bool largeArcFlag, bool sweepFlag) { return default(SvgPathSegArcRel); }
	public  SvgPathSegLinetoHorizontalAbs createSVGPathSegLinetoHorizontalAbs(double x) { return default(SvgPathSegLinetoHorizontalAbs); }
	public  SvgPathSegLinetoHorizontalRel createSVGPathSegLinetoHorizontalRel(double x) { return default(SvgPathSegLinetoHorizontalRel); }
	public  SvgPathSegLinetoVerticalAbs createSVGPathSegLinetoVerticalAbs(double y) { return default(SvgPathSegLinetoVerticalAbs); }
	public  SvgPathSegLinetoVerticalRel createSVGPathSegLinetoVerticalRel(double y) { return default(SvgPathSegLinetoVerticalRel); }
	public  SvgPathSegCurvetoCubicSmoothAbs createSVGPathSegCurvetoCubicSmoothAbs(double x, double y, double x2, double y2) { return default(SvgPathSegCurvetoCubicSmoothAbs); }
	public  SvgPathSegCurvetoCubicSmoothRel createSVGPathSegCurvetoCubicSmoothRel(double x, double y, double x2, double y2) { return default(SvgPathSegCurvetoCubicSmoothRel); }
	public  SvgPathSegCurvetoQuadraticSmoothAbs createSVGPathSegCurvetoQuadraticSmoothAbs(double x, double y) { return default(SvgPathSegCurvetoQuadraticSmoothAbs); }
	public  SvgPathSegCurvetoQuadraticSmoothRel createSVGPathSegCurvetoQuadraticSmoothRel(double x, double y) { return default(SvgPathSegCurvetoQuadraticSmoothRel); }
	public  SvgPathSegList pathSegList {get; set; }
	public  SvgPathSegList normalizedPathSegList {get; set; }
	public  SvgPathSegList animatedPathSegList {get; set; }
	public  SvgPathSegList animatedNormalizedPathSegList {get; set; }
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