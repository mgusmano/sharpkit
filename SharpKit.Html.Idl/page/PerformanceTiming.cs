
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:28 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/page/PerformanceTiming.idl

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
public partial class PerformanceTiming
{
	public  int navigationStart {get; set; }
	public  int unloadEventStart {get; set; }
	public  int unloadEventEnd {get; set; }
	public  int redirectStart {get; set; }
	public  int redirectEnd {get; set; }
	public  int fetchStart {get; set; }
	public  int domainLookupStart {get; set; }
	public  int domainLookupEnd {get; set; }
	public  int connectStart {get; set; }
	public  int connectEnd {get; set; }
	public  int secureConnectionStart {get; set; }
	public  int requestStart {get; set; }
	public  int responseStart {get; set; }
	public  int responseEnd {get; set; }
	public  int domLoading {get; set; }
	public  int domInteractive {get; set; }
	public  int domContentLoadedEventStart {get; set; }
	public  int domContentLoadedEventEnd {get; set; }
	public  int domComplete {get; set; }
	public  int loadEventStart {get; set; }
	public  int loadEventEnd {get; set; }
}

}