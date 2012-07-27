
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:28 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/Modules/webaudio/AudioPannerNode.idl

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

namespace SharpKit.Html.audio
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class AudioPannerNode : AudioNode
{
	public  static int EQUALPOWER = 0;
	public  static int HRTF = 1;
	public  static int SOUNDFIELD = 2;
	public  static int LINEAR_DISTANCE = 0;
	public  static int INVERSE_DISTANCE = 1;
	public  static int EXPONENTIAL_DISTANCE = 2;
	public  int panningModel {get; set; }
	public  void setPosition(double x, double y, double z) {}
	public  void setOrientation(double x, double y, double z) {}
	public  void setVelocity(double x, double y, double z) {}
	public  int distanceModel {get; set; }
	public  double refDistance {get; set; }
	public  double maxDistance {get; set; }
	public  double rolloffFactor {get; set; }
	public  double coneInnerAngle {get; set; }
	public  double coneOuterAngle {get; set; }
	public  double coneOuterGain {get; set; }
	public  AudioGain coneGain {get; set; }
	public  AudioGain distanceGain {get; set; }
}

}