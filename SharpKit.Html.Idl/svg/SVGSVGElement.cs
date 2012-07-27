
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:29 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/svg/SVGSVGElement.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "SVGSVGElement")]
public partial class SvgSvgElement : SvgElement, SvgTests, SvgLangSpace, SvgExternalResourcesRequired, SvgStylable, SvgLocatable, SvgFitToViewBox, SvgZoomAndPan
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('svg')")]
	public   SvgSvgElement() {}
	public  SvgAnimatedLength x {get; set; }
	public  SvgAnimatedLength y {get; set; }
	public  SvgAnimatedLength width {get; set; }
	public  SvgAnimatedLength height {get; set; }
	public  JsString contentScriptType {get; set; }
	public  JsString contentStyleType {get; set; }
	public  SvgRect viewport {get; set; }
	public  double pixelUnitToMillimeterX {get; set; }
	public  double pixelUnitToMillimeterY {get; set; }
	public  double screenPixelToMillimeterX {get; set; }
	public  double screenPixelToMillimeterY {get; set; }
	public  bool useCurrentView {get; set; }
	public  SvgViewSpec currentView {get; set; }
	public  double currentScale {get; set; }
	public  SvgPoint currentTranslate {get; set; }
	public  int suspendRedraw(int maxWaitMilliseconds) { return default(int); }
	public  void unsuspendRedraw(int suspendHandleId) {}
	public  void unsuspendRedrawAll() {}
	public  void forceRedraw() {}
	public  void pauseAnimations() {}
	public  void unpauseAnimations() {}
	public  bool animationsPaused() { return default(bool); }
	public  double getCurrentTime() { return default(double); }
	public  void setCurrentTime(double seconds) {}
	public  NodeList getIntersectionList(SvgRect rect, SvgElement referenceElement) { return default(NodeList); }
	public  NodeList getEnclosureList(SvgRect rect, SvgElement referenceElement) { return default(NodeList); }
	public  bool checkIntersection(SvgElement element, SvgRect rect) { return default(bool); }
	public  bool checkEnclosure(SvgElement element, SvgRect rect) { return default(bool); }
	public  void deselectAll() {}
	public  SvgNumber createSVGNumber() { return default(SvgNumber); }
	public  SvgLength createSVGLength() { return default(SvgLength); }
	public  SvgAngle createSVGAngle() { return default(SvgAngle); }
	public  SvgPoint createSVGPoint() { return default(SvgPoint); }
	public  SvgMatrix createSVGMatrix() { return default(SvgMatrix); }
	public  SvgRect createSVGRect() { return default(SvgRect); }
	public  SvgTransform createSVGTransform() { return default(SvgTransform); }
	public  SvgTransform createSVGTransformFromMatrix(SvgMatrix matrix) { return default(SvgTransform); }
	public  Element getElementById(string elementId) { return default(Element); }
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
	public  SvgElement nearestViewportElement {get; set; }
	public  SvgElement farthestViewportElement {get; set; }
	public  SvgRect getBBox() { return default(SvgRect); }
	public  SvgMatrix getCTM() { return default(SvgMatrix); }
	public  SvgMatrix getScreenCTM() { return default(SvgMatrix); }
	public  SvgMatrix getTransformToElement(SvgElement element) { return default(SvgMatrix); }
	public  SvgAnimatedRect viewBox {get; set; }
	public  SvgAnimatedPreserveAspectRatio preserveAspectRatio {get; set; }
	public  int SVG_ZOOMANDPAN_UNKNOWN {get; private set; }
	public  int SVG_ZOOMANDPAN_DISABLE {get; private set; }
	public  int SVG_ZOOMANDPAN_MAGNIFY {get; private set; }
	public  int zoomAndPan {get; set; }
}

}