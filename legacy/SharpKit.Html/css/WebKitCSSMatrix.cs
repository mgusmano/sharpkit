
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser" at Sun, 29 Jul 2012 15:47:54 GMT

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/css/WebKitCSSMatrix.idl

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
public partial class WebKitCSSMatrix
{
	public   WebKitCSSMatrix(string cssValue) {}
	public  double a {get; set; }
	public  double b {get; set; }
	public  double c {get; set; }
	public  double d {get; set; }
	public  double e {get; set; }
	public  double f {get; set; }
	public  double m11 {get; set; }
	public  double m12 {get; set; }
	public  double m13 {get; set; }
	public  double m14 {get; set; }
	public  double m21 {get; set; }
	public  double m22 {get; set; }
	public  double m23 {get; set; }
	public  double m24 {get; set; }
	public  double m31 {get; set; }
	public  double m32 {get; set; }
	public  double m33 {get; set; }
	public  double m34 {get; set; }
	public  double m41 {get; set; }
	public  double m42 {get; set; }
	public  double m43 {get; set; }
	public  double m44 {get; set; }
	public  void setMatrixValue(string @string) {}
	public  WebKitCSSMatrix multiply(WebKitCSSMatrix secondMatrix) { return default(WebKitCSSMatrix); }
	public  WebKitCSSMatrix inverse() { return default(WebKitCSSMatrix); }
	public  WebKitCSSMatrix translate(double x, double y, double z) { return default(WebKitCSSMatrix); }
	public  WebKitCSSMatrix scale(double scaleX, double scaleY, double scaleZ) { return default(WebKitCSSMatrix); }
	public  WebKitCSSMatrix rotate(double rotX, double rotY, double rotZ) { return default(WebKitCSSMatrix); }
	public  WebKitCSSMatrix rotateAxisAngle(double x, double y, double z, double angle) { return default(WebKitCSSMatrix); }
	public  WebKitCSSMatrix skewX(double angle) { return default(WebKitCSSMatrix); }
	public  WebKitCSSMatrix skewY(double angle) { return default(WebKitCSSMatrix); }
	public  JsString toString() { return default(JsString); }
}

}