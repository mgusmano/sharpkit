using System;

namespace SharpKit.Html.indexeddb.custom
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBTransaction")]
    public partial class IDBTransaction
    {
        public  JsString mode { get; set; }

        public  IDBDatabase db { get; set; }

        public  DOMError error { get; set; }

        public  IDBObjectStore<K,V> objectStore<K,V>(string name)
        {
            return default(IDBObjectStore<K,V>);
        }

        public  void abort()
        {
        }

        public  EventListener onabort { get; set; }

        public  EventListener oncomplete { get; set; }

        public  EventListener<ErrorEvent> onerror { get; set; }

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