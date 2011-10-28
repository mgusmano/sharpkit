using System;
using System.Collections.Generic;

using System.Text;

namespace SharpKit.JavaScript.Private
{
    [JsType(Name = "System.Collections.Generic.KeyValuePair$2", Filename = "~/res/System.Collections.js")]
    public class JsImplKeyValuePair<K, T>
    {
        JsImplKeyValuePair(K key, T value)
        {
            this._Key = key;
            this._Value = value;
        }
        K _Key;
        T _Value;
        public K Key
        {
            get
            {
                return this._Key;
            }
        }
        public T Value
        {
            get { return _Value; }
        }
    }
}
