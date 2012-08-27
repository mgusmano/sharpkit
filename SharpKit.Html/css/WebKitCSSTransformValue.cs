
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser" at Sun, 29 Jul 2012 15:47:54 GMT

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/css/WebKitCSSTransformValue.idl

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