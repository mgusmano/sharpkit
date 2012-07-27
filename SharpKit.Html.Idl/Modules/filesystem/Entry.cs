
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:27 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/Modules/filesystem/Entry.idl

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

namespace SharpKit.Html.storage
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class Entry
{
	public  bool isFile {get; set; }
	public  bool isDirectory {get; set; }
	public  JsString name {get; set; }
	public  JsString fullPath {get; set; }
	public  DOMFileSystem filesystem {get; set; }
	public  void getMetadata(MetadataCallback successCallback) {}
	public  void getMetadata(MetadataCallback successCallback, ErrorCallback errorCallback) {}
	public  void moveTo(DirectoryEntry parent) {}
	public  void moveTo(DirectoryEntry parent, string name) {}
	public  void moveTo(DirectoryEntry parent, string name, EntryCallback successCallback) {}
	public  void moveTo(DirectoryEntry parent, string name, EntryCallback successCallback, ErrorCallback errorCallback) {}
	public  void copyTo(DirectoryEntry parent) {}
	public  void copyTo(DirectoryEntry parent, string name) {}
	public  void copyTo(DirectoryEntry parent, string name, EntryCallback successCallback) {}
	public  void copyTo(DirectoryEntry parent, string name, EntryCallback successCallback, ErrorCallback errorCallback) {}
	public  JsString toURL() { return default(JsString); }
	public  void remove(VoidCallback successCallback) {}
	public  void remove(VoidCallback successCallback, ErrorCallback errorCallback) {}
	public  void getParent() {}
	public  void getParent(EntryCallback successCallback) {}
	public  void getParent(EntryCallback successCallback, ErrorCallback errorCallback) {}
}

}