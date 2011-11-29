//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.svg
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class SVGAngle
{

	// SVGAngle
	public static short SVG_ANGLETYPE_UNKNOWN = 0;
	public static short SVG_ANGLETYPE_UNSPECIFIED = 1;
	public static short SVG_ANGLETYPE_DEG = 2;
	public static short SVG_ANGLETYPE_RAD = 3;
	public static short SVG_ANGLETYPE_GRAD = 4;
	public short unitType {get;private set;}
	public float value {get;set;}
	public float valueInSpecifiedUnits {get;set;}
	public string valueAsString {get;set;}
	public void newValueSpecifiedUnits(short unitType, float valueInSpecifiedUnits) {}
	public void convertToSpecifiedUnits(short unitType) {}
}

}