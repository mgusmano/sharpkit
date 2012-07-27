
/****************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser' at Fri, 27 Jul 2012 03:44:27 GMT
  Author of the tool: Sebastian Loncar, http://loncar.de

  Content was generated from IDL file: http://trac.webkit.org/browser/trunk/Source/WebCore/Modules/indexeddb/IDBObjectStore.idl

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
public partial class IDBObjectStore
{
	public  JsString name {get; set; }
	public  IDBAny keyPath {get; set; }
	public  DOMStringList indexNames {get; set; }
	public  IDBTransaction transaction {get; set; }
	public  bool autoIncrement {get; set; }
	public  IDBRequest put(object value) { return default(IDBRequest); }
	public  IDBRequest put(object value, IDBKey key) { return default(IDBRequest); }
	public  IDBRequest add(object value) { return default(IDBRequest); }
	public  IDBRequest add(object value, IDBKey key) { return default(IDBRequest); }
	public  IDBRequest delete(IDBKeyRange keyRange) { return default(IDBRequest); }
	public  IDBRequest delete(IDBKey key) { return default(IDBRequest); }
	public  IDBRequest clear() { return default(IDBRequest); }
	public  IDBRequest get(IDBKeyRange key) { return default(IDBRequest); }
	public  IDBRequest get(IDBKey key) { return default(IDBRequest); }
	public  IDBRequest openCursor() { return default(IDBRequest); }
	public  IDBRequest openCursor(IDBKeyRange range) { return default(IDBRequest); }
	public  IDBRequest openCursor(IDBKeyRange range, string direction) { return default(IDBRequest); }
	public  IDBRequest openCursor(IDBKey key) { return default(IDBRequest); }
	public  IDBRequest openCursor(IDBKey key, string direction) { return default(IDBRequest); }
	public  IDBRequest openCursor(IDBKeyRange range, int direction) { return default(IDBRequest); }
	public  IDBRequest openCursor(IDBKey key, int direction) { return default(IDBRequest); }
	public  IDBIndex createIndex(string name, string[] keyPath) { return default(IDBIndex); }
	public  IDBIndex createIndex(string name, string[] keyPath, object options) { return default(IDBIndex); }
	public  IDBIndex index(string name) { return default(IDBIndex); }
	public  void deleteIndex(string name) {}
	public  IDBRequest count() { return default(IDBRequest); }
	public  IDBRequest count(IDBKeyRange range) { return default(IDBRequest); }
	public  IDBRequest count(IDBKey key) { return default(IDBRequest); }
}

}