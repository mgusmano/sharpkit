
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser" at Thu, 20 Sep 2012 15:27:33 GMT

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/inspector/InspectorFrontendHost.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as "partial". Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

********************************************************************************************************

  Copyright (C) 2012 Sebastian Loncar, Web: http://loncar.de
  Copyright (C) 2009 Apple Inc. All Rights Reserved.

  MIT License:

  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
  associated documentation files (the "Software"), to deal in the Software without restriction, 
  including without limitation the rights to use, copy, modify, merge, publish, distribute,
  sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all copies or substantial
  portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
  NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES
  OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*******************************************************************************************************/

using System;

namespace SharpKit.Html
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
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