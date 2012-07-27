
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:28 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/svg/SVGMatrix.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "SVGMatrix")]
public partial class SvgMatrix
{
	public  double a {get; set; }
	public  double b {get; set; }
	public  double c {get; set; }
	public  double d {get; set; }
	public  double e {get; set; }
	public  double f {get; set; }
	public  SvgMatrix multiply(SvgMatrix secondMatrix) { return default(SvgMatrix); }
	public  SvgMatrix inverse() { return default(SvgMatrix); }
	public  SvgMatrix translate(double x, double y) { return default(SvgMatrix); }
	public  SvgMatrix scale(double scaleFactor) { return default(SvgMatrix); }
	public  SvgMatrix scaleNonUniform(double scaleFactorX, double scaleFactorY) { return default(SvgMatrix); }
	public  SvgMatrix rotate(double angle) { return default(SvgMatrix); }
	public  SvgMatrix rotateFromVector(double x, double y) { return default(SvgMatrix); }
	public  SvgMatrix flipX() { return default(SvgMatrix); }
	public  SvgMatrix flipY() { return default(SvgMatrix); }
	public  SvgMatrix skewX(double angle) { return default(SvgMatrix); }
	public  SvgMatrix skewY(double angle) { return default(SvgMatrix); }
}

}