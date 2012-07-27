
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:27 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/html/HTMLMediaElement.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "HTMLMediaElement")]
public partial class HtmlMediaElement : HtmlElement
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('media')")]
	public   HtmlMediaElement() {}
	public  MediaError error {get; set; }
	public  JsString src {get; set; }
	public  JsString currentSrc {get; set; }
	public  static int NETWORK_EMPTY = 0;
	public  static int NETWORK_IDLE = 1;
	public  static int NETWORK_LOADING = 2;
	public  static int NETWORK_NO_SOURCE = 3;
	public  int networkState {get; set; }
	public  JsString preload {get; set; }
	public  TimeRanges buffered {get; set; }
	public  void load() {}
	public  JsString canPlayType(string type) { return default(JsString); }
	public  static int HAVE_NOTHING = 0;
	public  static int HAVE_METADATA = 1;
	public  static int HAVE_CURRENT_DATA = 2;
	public  static int HAVE_FUTURE_DATA = 3;
	public  static int HAVE_ENOUGH_DATA = 4;
	public  int readyState {get; set; }
	public  bool seeking {get; set; }
	public  double currentTime {get; set; }
	public  double initialTime {get; set; }
	public  double startTime {get; set; }
	public  double duration {get; set; }
	public  bool paused {get; set; }
	public  double defaultPlaybackRate {get; set; }
	public  double playbackRate {get; set; }
	public  TimeRanges played {get; set; }
	public  TimeRanges seekable {get; set; }
	public  bool ended {get; set; }
	public  bool autoplay {get; set; }
	public  bool loop {get; set; }
	public  void play() {}
	public  void pause() {}
	public  bool controls {get; set; }
	public  double volume {get; set; }
	public  bool muted {get; set; }
	public  bool defaultMuted {get; set; }
	public  JsString mediaGroup {get; set; }
	public  MediaController controller {get; set; }
}

}