
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:26 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/css/WebKitCSSTransformValue.idl

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
public partial class WebKitCSSTransformValue : CssValueList
{
	public  static int CSS_TRANSLATE = 1;
	public  static int CSS_TRANSLATEX = 2;
	public  static int CSS_TRANSLATEY = 3;
	public  static int CSS_ROTATE = 4;
	public  static int CSS_SCALE = 5;
	public  static int CSS_SCALEX = 6;
	public  static int CSS_SCALEY = 7;
	public  static int CSS_SKEW = 8;
	public  static int CSS_SKEWX = 9;
	public  static int CSS_SKEWY = 10;
	public  static int CSS_MATRIX = 11;
	public  static int CSS_TRANSLATEZ = 12;
	public  static int CSS_TRANSLATE3D = 13;
	public  static int CSS_ROTATEX = 14;
	public  static int CSS_ROTATEY = 15;
	public  static int CSS_ROTATEZ = 16;
	public  static int CSS_ROTATE3D = 17;
	public  static int CSS_SCALEZ = 18;
	public  static int CSS_SCALE3D = 19;
	public  static int CSS_PERSPECTIVE = 20;
	public  static int CSS_MATRIX3D = 21;
	public  int operationType {get; set; }
}

}