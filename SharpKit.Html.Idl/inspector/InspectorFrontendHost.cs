
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:27 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/inspector/InspectorFrontendHost.idl

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
public partial class InspectorFrontendHost
{
	public  void loaded() {}
	public  void closeWindow() {}
	public  void bringToFront() {}
	public  void setZoomFactor(double zoom) {}
	public  void inspectedURLChanged(string newURL) {}
	public  void requestAttachWindow() {}
	public  void requestDetachWindow() {}
	public  void requestSetDockSide(string side) {}
	public  void setAttachedWindowHeight(int height) {}
	public  void moveWindowBy(double x, double y) {}
	public  void setInjectedScriptForOrigin(string origin, string script) {}
	public  JsString localizedStringsURL() { return default(JsString); }
	public  JsString hiddenPanels() { return default(JsString); }
	public  void copyText(string text) {}
	public  void openInNewTab(string url) {}
	public  bool canSave() { return default(bool); }
	public  void save(string url, string content, bool forceSaveAs) {}
	public  void append(string url, string content) {}
	public  JsString platform() { return default(JsString); }
	public  JsString port() { return default(JsString); }
	public  void showContextMenu(MouseEvent @event, object items) {}
	public  void sendMessageToBackend(string message) {}
	public  void recordActionTaken(int actionCode) {}
	public  void recordPanelShown(int panelCode) {}
	public  void recordSettingChanged(int settingChanged) {}
	public  JsString loadResourceSynchronously(string url) { return default(JsString); }
}

}