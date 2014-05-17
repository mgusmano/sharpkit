using System;

namespace SharpKit.Html.indexeddb.custom
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBDatabase")]
    public partial class IDBDatabase
    {
        public  JsString name { get; set; }

        public  IDBAny version { get; set; }

        public  DOMStringList objectStoreNames { get; set; }

        public  EventListener onabort { get; set; }

        public  EventListener<ErrorEvent> onerror { get; set; }

        public  EventListener onversionchange { get; set; }

        public  IDBObjectStore<K,V> createObjectStore<K,V>(string name)
        {
            return default(IDBObjectStore<K,V>);
        }

        public  IDBObjectStore<K,V> createObjectStore<K,V>(string name, IDBObjectStoreOptions options)
        {
            return default(IDBObjectStore<K,V>);
        }

        public  void deleteObjectStore(string name)
        {
        }

        public  IDBTransaction transaction(JsArray<string> storeNames, string mode)
        {
            return default(IDBTransaction);
        }

        public  IDBTransaction transaction(JsString storeNames, string mode)
        {
            return default(IDBTransaction);
        }

        public  IDBTransaction transaction(string storeName, string mode)
        {
            return default(IDBTransaction);
        }

        public  void close()
        {
        }

        public  void addEventListener(string type, EventListener listener)
        {
        }

        public  void addEventListener(string type, EventListener listener, bool useCapture)
        {
        }

        public  void removeEventListener(string type, EventListener listener)
        {
        }

        public  void removeEventListener(string type, EventListener listener, bool useCapture)
        {
        }

        public  bool dispatchEvent(DOMEvent evt)
        {
            return default(bool);
        }
    }

}