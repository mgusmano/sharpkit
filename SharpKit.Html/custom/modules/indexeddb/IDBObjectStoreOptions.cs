using System;
using SharpKit.JavaScript;

namespace SharpKit.Html.indexeddb.custom
{
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBObjectStoreOptions")]
    public class IDBObjectStoreOptions
    {
        [JsProperty(Name = "keyPath")]
        public string keyPath { get; set; }
    }
}

