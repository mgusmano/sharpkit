
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser" at Thu, 20 Sep 2012 15:27:32 GMT

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/html/canvas/DataView.idl

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
public partial class DataView : ArrayBufferView
{
	public  object getInt8() { return default(object); }
	public  object getUint8() { return default(object); }
	public  short getInt16(int byteOffset) { return default(short); }
	public  short getInt16(int byteOffset, bool littleEndian) { return default(short); }
	public  int getUint16(int byteOffset) { return default(int); }
	public  int getUint16(int byteOffset, bool littleEndian) { return default(int); }
	public  int getInt32(int byteOffset) { return default(int); }
	public  int getInt32(int byteOffset, bool littleEndian) { return default(int); }
	public  int getUint32(int byteOffset) { return default(int); }
	public  int getUint32(int byteOffset, bool littleEndian) { return default(int); }
	public  double getFloat32(int byteOffset) { return default(double); }
	public  double getFloat32(int byteOffset, bool littleEndian) { return default(double); }
	public  double getFloat64(int byteOffset) { return default(double); }
	public  double getFloat64(int byteOffset, bool littleEndian) { return default(double); }
	public  void setInt8() {}
	public  void setUint8() {}
	public  void setInt16(int byteOffset, short value) {}
	public  void setInt16(int byteOffset, short value, bool littleEndian) {}
	public  void setUint16(int byteOffset, int value) {}
	public  void setUint16(int byteOffset, int value, bool littleEndian) {}
	public  void setInt32(int byteOffset, int value) {}
	public  void setInt32(int byteOffset, int value, bool littleEndian) {}
	public  void setUint32(int byteOffset, int value) {}
	public  void setUint32(int byteOffset, int value, bool littleEndian) {}
	public  void setFloat32(int byteOffset, double value) {}
	public  void setFloat32(int byteOffset, double value, bool littleEndian) {}
	public  void setFloat64(int byteOffset, double value) {}
	public  void setFloat64(int byteOffset, double value, bool littleEndian) {}
}

}