
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:26 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/dom/Event.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "Event")]
public partial class DOMEvent
{
	public  static int NONE = 0;
	public  static int CAPTURING_PHASE = 1;
	public  static int AT_TARGET = 2;
	public  static int BUBBLING_PHASE = 3;
	public  static int MOUSEDOWN = 1;
	public  static int MOUSEUP = 2;
	public  static int MOUSEOVER = 4;
	public  static int MOUSEOUT = 8;
	public  static int MOUSEMOVE = 16;
	public  static int MOUSEDRAG = 32;
	public  static int CLICK = 64;
	public  static int DBLCLICK = 128;
	public  static int KEYDOWN = 256;
	public  static int KEYUP = 512;
	public  static int KEYPRESS = 1024;
	public  static int DRAGDROP = 2048;
	public  static int FOCUS = 4096;
	public  static int BLUR = 8192;
	public  static int SELECT = 16384;
	public  static int CHANGE = 32768;
	public  JsString type {get; set; }
	public  EventTarget target {get; set; }
	public  EventTarget currentTarget {get; set; }
	public  int eventPhase {get; set; }
	public  bool bubbles {get; set; }
	public  bool cancelable {get; set; }
	public  object timeStamp {get; set; }
	public  void stopPropagation() {}
	public  void preventDefault() {}
	public  void initEvent(string eventTypeArg, bool canBubbleArg, bool cancelableArg) {}
	public  bool defaultPrevented {get; set; }
	public  void stopImmediatePropagation() {}
	public  EventTarget srcElement {get; set; }
	public  bool returnValue {get; set; }
	public  bool cancelBubble {get; set; }
	public  Clipboard clipboardData {get; set; }
}

}