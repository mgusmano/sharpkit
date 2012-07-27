
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:26 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/html/canvas/DataView.idl

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