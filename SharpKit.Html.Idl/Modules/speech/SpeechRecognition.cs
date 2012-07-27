
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:27 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/Modules/speech/SpeechRecognition.idl

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
public partial class SpeechRecognition
{
	public   SpeechRecognition() {}
	public  SpeechGrammarList grammars {get; set; }
	public  JsString lang {get; set; }
	public  bool continuous {get; set; }
	public  int maxAlternatives {get; set; }
	public  void start() {}
	public  void stop() {}
	public  void abort() {}
	public  EventListener onaudiostart {get; set; }
	public  EventListener onsoundstart {get; set; }
	public  EventListener onspeechstart {get; set; }
	public  EventListener onspeechend {get; set; }
	public  EventListener onsoundend {get; set; }
	public  EventListener onaudioend {get; set; }
	public  EventListener onresult {get; set; }
	public  EventListener onnomatch {get; set; }
	public  EventListener onresultdeleted {get; set; }
	public  EventListener<ErrorEvent> onerror {get; set; }
	public  EventListener onstart {get; set; }
	public  EventListener onend {get; set; }
	public  void addEventListener(string type, EventListener listener) {}
	public  void addEventListener(string type, EventListener listener, bool useCapture) {}
	public  void removeEventListener(string type, EventListener listener) {}
	public  void removeEventListener(string type, EventListener listener, bool useCapture) {}
	public  bool dispatchEvent(DOMEvent evt) { return default(bool); }
}

}