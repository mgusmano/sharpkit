using System;

namespace SharpKit.Html.indexeddb
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBObjectStore")]
    public partial class IDBObjectStore<K,V>
    {
        public  JsString name { get; set; }

        public  IDBAny keyPath { get; set; }

        public  DOMStringList indexNames { get; set; }

        public  IDBTransaction transaction { get; set; }

        public  bool autoIncrement { get; set; }

        public  IDBRequest put(V value)
        {
            return default(IDBRequest);
        }

        public  IDBRequest put(V value, K key)
        {
            return default(IDBRequest);
        }

        public  IDBRequest add(object value)
        {
            return default(IDBRequest);
        }

        public  IDBRequest add(object value, K key)
        {
            return default(IDBRequest);
        }

        public  IDBRequest delete(IDBKeyRange<K> keyRange)
        {
            return default(IDBRequest);
        }

        public  IDBRequest delete(K key)
        {
            return default(IDBRequest);
        }

        public  IDBRequest clear()
        {
            return default(IDBRequest);
        }

        public  IDBRequest get(IDBKeyRange<K> key)
        {
            return default(IDBRequest);
        }

        public  IDBRequest get(K key)
        {
            return default(IDBRequest);
        }

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

        public  IDBIndex createIndex(string name, JsString keyPath)
        {
            return default(IDBIndex);
        }

        public  IDBIndex createIndex(string name, JsString keyPath, object options)
        {
            return default(IDBIndex);
        }

        public  IDBIndex createIndex(string name, string keyPath)
        {
            return default(IDBIndex);
        }

        public  IDBIndex createIndex(string name, string keyPath, object options)
        {
            return default(IDBIndex);
        }

        public  IDBIndex<I,V> createIndex<I>(string name, JsString keyPath)
        {
            return default(IDBIndex<I,V>);
        }

        public  IDBIndex<I,V> createIndex<I>(string name, JsString keyPath, object options)
        {
            return default(IDBIndex<I,V>);
        }

        public  IDBIndex<I,V> createIndex<I>(string name, string keyPath)
        {
            return default(IDBIndex<I,V>);
        }

        public  IDBIndex<I,V> createIndex<I>(string name, string keyPath, object options)
        {
            return default(IDBIndex<I,V>);
        }

        public  IDBIndex<I,V> index<I>(string name)
        {
            return default(IDBIndex<I,V>);
        }

        public  void deleteIndex(string name)
        {
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