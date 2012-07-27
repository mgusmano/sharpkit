
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:26 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/css/CSSPrimitiveValue.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "CSSPrimitiveValue")]
public partial class CssPrimitiveValue : CssValue
{
	public  static int CSS_UNKNOWN = 0;
	public  static int CSS_NUMBER = 1;
	public  static int CSS_PERCENTAGE = 2;
	public  static int CSS_EMS = 3;
	public  static int CSS_EXS = 4;
	public  static int CSS_PX = 5;
	public  static int CSS_CM = 6;
	public  static int CSS_MM = 7;
	public  static int CSS_IN = 8;
	public  static int CSS_PT = 9;
	public  static int CSS_PC = 10;
	public  static int CSS_DEG = 11;
	public  static int CSS_RAD = 12;
	public  static int CSS_GRAD = 13;
	public  static int CSS_MS = 14;
	public  static int CSS_S = 15;
	public  static int CSS_HZ = 16;
	public  static int CSS_KHZ = 17;
	public  static int CSS_DIMENSION = 18;
	public  static int CSS_STRING = 19;
	public  static int CSS_URI = 20;
	public  static int CSS_IDENT = 21;
	public  static int CSS_ATTR = 22;
	public  static int CSS_COUNTER = 23;
	public  static int CSS_RECT = 24;
	public  static int CSS_RGBCOLOR = 25;
	public  static int CSS_VW = 26;
	public  static int CSS_VH = 27;
	public  static int CSS_VMIN = 28;
	public  int primitiveType {get; set; }
	public  void setFloatValue(int unitType, double floatValue) {}
	public  double getFloatValue(int unitType) { return default(double); }
	public  void setStringValue(int stringType, string stringValue) {}
	public  JsString getStringValue() { return default(JsString); }
	public  Counter getCounterValue() { return default(Counter); }
	public  Rect getRectValue() { return default(Rect); }
	public  RGBColor getRGBColorValue() { return default(RGBColor); }
}

}