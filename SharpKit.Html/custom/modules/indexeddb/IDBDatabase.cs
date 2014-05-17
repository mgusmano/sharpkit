using System;

namespace SharpKit.Html.indexeddb
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBDatabase")]
    public partial class IDBDatabase
    {
        public  IDBObjectStore<K,V> createObjectStore<K,V>(string name)
        {
            return default(IDBObjectStore<K,V>);
        }

        public  IDBObjectStore<K,V> createObjectStore<K,V>(string name, ObjectStoreOptions options)
        {
            return default(IDBObjectStore<K,V>);
        }

        public  IDBTransaction transaction(JsArray<string> storeNames, string mode)
        {
            return default(IDBTransaction);
        }
    }
}