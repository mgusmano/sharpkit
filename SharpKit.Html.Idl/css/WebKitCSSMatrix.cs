
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:26 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/css/WebKitCSSMatrix.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class WebKitCSSMatrix
{
	public   WebKitCSSMatrix(string cssValue) {}
	public  double a {get; set; }
	public  double b {get; set; }
	public  double c {get; set; }
	public  double d {get; set; }
	public  double e {get; set; }
	public  double f {get; set; }
	public  double m11 {get; set; }
	public  double m12 {get; set; }
	public  double m13 {get; set; }
	public  double m14 {get; set; }
	public  double m21 {get; set; }
	public  double m22 {get; set; }
	public  double m23 {get; set; }
	public  double m24 {get; set; }
	public  double m31 {get; set; }
	public  double m32 {get; set; }
	public  double m33 {get; set; }
	public  double m34 {get; set; }
	public  double m41 {get; set; }
	public  double m42 {get; set; }
	public  double m43 {get; set; }
	public  double m44 {get; set; }
	public  void setMatrixValue(string @string) {}
	public  WebKitCSSMatrix multiply(WebKitCSSMatrix secondMatrix) { return default(WebKitCSSMatrix); }
	public  WebKitCSSMatrix inverse() { return default(WebKitCSSMatrix); }
	public  WebKitCSSMatrix translate(double x, double y, double z) { return default(WebKitCSSMatrix); }
	public  WebKitCSSMatrix scale(double scaleX, double scaleY, double scaleZ) { return default(WebKitCSSMatrix); }
	public  WebKitCSSMatrix rotate(double rotX, double rotY, double rotZ) { return default(WebKitCSSMatrix); }
	public  WebKitCSSMatrix rotateAxisAngle(double x, double y, double z, double angle) { return default(WebKitCSSMatrix); }
	public  WebKitCSSMatrix skewX(double angle) { return default(WebKitCSSMatrix); }
	public  WebKitCSSMatrix skewY(double angle) { return default(WebKitCSSMatrix); }
	public  JsString toString() { return default(JsString); }
}

}