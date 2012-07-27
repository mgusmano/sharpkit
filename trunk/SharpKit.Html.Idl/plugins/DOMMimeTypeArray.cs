
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:28 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/plugins/DOMMimeTypeArray.idl

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

[JsType(JsMode.Prototype, NativeEnumerator = false, NativeArrayEnumerator = true, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class MimeTypeArray : IJsArrayEnumerable<MimeType>
{
	public  int length {get; set; }
	[JsProperty(NativeIndexer = true)]
	public  MimeType this[int index] {get { return default(MimeType); } set {}}
	[JsProperty(NativeIndexer = true)]
	public  MimeType this[string name] {get { return default(MimeType); } set {}}

	MimeType IJsArrayEnumerable<MimeType>.this[JsNumber index] {
		get { throw new NotImplementedException(); }
	}

	JsNumber IJsArrayEnumerable<MimeType>.length {
		get { throw new NotImplementedException(); }
	}

	System.Collections.Generic.IEnumerator<MimeType> System.Collections.Generic.IEnumerable<MimeType>.GetEnumerator() {
		throw new NotImplementedException();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
		throw new NotImplementedException();
	}
}

}