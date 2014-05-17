using System;

namespace SharpKit.Html.indexeddb
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBIndex")]
    public partial class IDBIndex<K,V>
    {
        public  JsString name { get; set; }

        public  IDBObjectStore objectStore { get; set; }

        public  IDBAny keyPath { get; set; }

        public  bool unique { get; set; }

        public  bool multiEntry { get; set; }

        public  IDBRequest<IDBCursorWithValue<K,V>> openCursor()
        {
            return default(IDBRequest<IDBCursorWithValue<K,V>>);
        }

        public  IDBRequest<IDBCursorWithValue<K,V>> openCursor(IDBKeyRange<K> range)
        {
            return default(IDBRequest<IDBCursorWithValue<K,V>>);
        }

        public  IDBRequest<IDBCursorWithValue<K,V>> openCursor(IDBKeyRange<K> range, string direction)
        {
            return default(IDBRequest<IDBCursorWithValue<K,V>>);
        }

        public  IDBRequest<IDBCursorWithValue<K,V>> openCursor(K key)
        {
            return default(IDBRequest<IDBCursorWithValue<K,V>>);
        }

        public  IDBRequest<IDBCursorWithValue<K,V>> openCursor(K key, string direction)
        {
            return default(IDBRequest<IDBCursorWithValue<K,V>>);
        }

        public  IDBRequest openKeyCursor()
        {
            return default(IDBRequest);
        }

        public  IDBRequest openKeyCursor(IDBKeyRange<K> range)
        {
            return default(IDBRequest);
        }

        public  IDBRequest openKeyCursor(IDBKeyRange<K> range, string direction)
        {
            return default(IDBRequest);
        }

        public  IDBRequest openKeyCursor(K key)
        {
            return default(IDBRequest);
        }

        public  IDBRequest openKeyCursor(K key, string direction)
        {
            return default(IDBRequest);
        }

        public  IDBRequest get(IDBKeyRange<K> key)
        {
            return default(IDBRequest);
        }

        public  IDBRequest<V> get(K key)
        {
            return default(IDBRequest<V>);
        }

        public  IDBRequest getKey(IDBKeyRange<K> key)
        {
            return default(IDBRequest);
        }

        public  IDBRequest getKey(K key)
        {
            return default(IDBRequest);
        }

        public  IDBRequest count()
        {
            return default(IDBRequest);
        }

        public  IDBRequest count(IDBKeyRange<K> range)
        {
            return default(IDBRequest);
        }

        public  IDBRequest count(K key)
        {
            return default(IDBRequest);
        }
    }

}