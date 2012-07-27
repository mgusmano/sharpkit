
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:29 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/svg/SVGTransform.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "SVGTransform")]
public partial class SvgTransform
{
	public  static int SVG_TRANSFORM_UNKNOWN = 0;
	public  static int SVG_TRANSFORM_MATRIX = 1;
	public  static int SVG_TRANSFORM_TRANSLATE = 2;
	public  static int SVG_TRANSFORM_SCALE = 3;
	public  static int SVG_TRANSFORM_ROTATE = 4;
	public  static int SVG_TRANSFORM_SKEWX = 5;
	public  static int SVG_TRANSFORM_SKEWY = 6;
	public  int type {get; set; }
	public  SvgMatrix matrix {get; set; }
	public  double angle {get; set; }
	public  void setMatrix(SvgMatrix matrix) {}
	public  void setTranslate(double tx, double ty) {}
	public  void setScale(double sx, double sy) {}
	public  void setRotate(double angle, double cx, double cy) {}
	public  void setSkewX(double angle) {}
	public  void setSkewY(double angle) {}
}

}