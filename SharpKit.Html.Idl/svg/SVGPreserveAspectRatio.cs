
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:29 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/svg/SVGPreserveAspectRatio.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "SVGPreserveAspectRatio")]
public partial class SvgPreserveAspectRatio
{
	public  static int SVG_PRESERVEASPECTRATIO_UNKNOWN = 0;
	public  static int SVG_PRESERVEASPECTRATIO_NONE = 1;
	public  static int SVG_PRESERVEASPECTRATIO_XMINYMIN = 2;
	public  static int SVG_PRESERVEASPECTRATIO_XMIDYMIN = 3;
	public  static int SVG_PRESERVEASPECTRATIO_XMAXYMIN = 4;
	public  static int SVG_PRESERVEASPECTRATIO_XMINYMID = 5;
	public  static int SVG_PRESERVEASPECTRATIO_XMIDYMID = 6;
	public  static int SVG_PRESERVEASPECTRATIO_XMAXYMID = 7;
	public  static int SVG_PRESERVEASPECTRATIO_XMINYMAX = 8;
	public  static int SVG_PRESERVEASPECTRATIO_XMIDYMAX = 9;
	public  static int SVG_PRESERVEASPECTRATIO_XMAXYMAX = 10;
	public  static int SVG_MEETORSLICE_UNKNOWN = 0;
	public  static int SVG_MEETORSLICE_MEET = 1;
	public  static int SVG_MEETORSLICE_SLICE = 2;
	public  int align {get; set; }
	public  int meetOrSlice {get; set; }
}

}