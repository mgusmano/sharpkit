//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class SVGSVGElement : SVGElement
{

	// SVGSVGElement
	public SVGAnimatedLength x {get; private set; }
	public SVGAnimatedLength y {get; private set; }
	public SVGAnimatedLength width {get; private set; }
	public SVGAnimatedLength height {get; private set; }
	public JsString contentScriptType {get; set; }
	public JsString contentStyleType {get; set; }
	public SVGRect viewport {get; private set; }
	public float pixelUnitToMillimeterX {get; private set; }
	public float pixelUnitToMillimeterY {get; private set; }
	public float screenPixelToMillimeterX {get; private set; }
	public float screenPixelToMillimeterY {get; private set; }
	public bool useCurrentView {get; set; }
	public SVGViewSpec currentView {get; private set; }
	public float currentScale {get; set; }
	public SVGPoint currentTranslate {get; private set; }
	public int suspendRedraw(int max_wait_milliseconds) { return default(int); }
	public void unsuspendRedraw(int suspend_handle_id) {}
	public void unsuspendRedrawAll() {}
	public void forceRedraw() {}
	public void pauseAnimations() {}
	public void unpauseAnimations() {}
	public bool animationsPaused() { return default(bool); }
	public float currentTime {get; set; }
	public NodeList getIntersectionList(SVGRect rect, SVGElement referenceElement) { return default(NodeList); }
	public NodeList getEnclosureList(SVGRect rect, SVGElement referenceElement) { return default(NodeList); }
	public bool checkIntersection(SVGElement element, SVGRect rect) { return default(bool); }
	public bool checkEnclosure(SVGElement element, SVGRect rect) { return default(bool); }
	public void deselectAll() {}
	public SVGNumber createSVGNumber() { return default(SVGNumber); }
	public SVGLength createSVGLength() { return default(SVGLength); }
	public SVGAngle createSVGAngle() { return default(SVGAngle); }
	public SVGPoint createSVGPoint() { return default(SVGPoint); }
	public SVGMatrix createSVGMatrix() { return default(SVGMatrix); }
	public SVGRect createSVGRect() { return default(SVGRect); }
	public SVGTransform createSVGTransform() { return default(SVGTransform); }
	public SVGTransform createSVGTransformFromMatrix(SVGMatrix matrix) { return default(SVGTransform); }
	public Element getElementById(string elementId) { return default(Element); }
}

}