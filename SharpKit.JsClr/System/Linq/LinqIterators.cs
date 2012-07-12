using System;
using System.Collections.Generic;

using System.Text;

using System.Collections;

namespace SharpKit.JavaScript.Private
{
    [JsType(Name = "System.Linq.OfTypeIterator", Filename = "~/res/System.Linq.js")]
    class JsImplOfTypeIterator<T> : IEnumerator<T>, IEnumerable<T>
    {
        public JsImplOfTypeIterator(IEnumerable source)
        {
            this.Source = source;
        }
        IEnumerable Source;
        IEnumerator SourceEnumerator;

        public void Reset()
        {
            if (SourceEnumerator != null)
                this.SourceEnumerator.Reset();
        }
        public T Current
        {
            get
            {
                return SourceEnumerator.Current.As<T>();
            }
        }
        public bool MoveNext()
        {
            if (SourceEnumerator == null)
                SourceEnumerator = Source.GetEnumerator();
            while (true)
            {
                if (!SourceEnumerator.MoveNext())
                    return false;
                var item = SourceEnumerator.Current;
                if (item is T)
                    return true;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            Source = null;
            SourceEnumerator = null;
        }

        #endregion

        #region IEnumerator Members

        object System.Collections.IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }

        void System.Collections.IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }

    sealed class JsImplTakeIterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IEnumerator, IDisposable
    {
        // Fields
        private int _State;
        private TSource _Current;
        public int _Count;
        public IEnumerable<TSource> _Source;
        public IEnumerator<TSource> _SourceEnumerator;
        public TSource _Item;
        public int count;
        public IEnumerable<TSource> source;

        // Methods
        public JsImplTakeIterator(int _state)
        {
            this._State = _state;
        }

        public bool MoveNext()
        {
            bool success;
            try
            {
                switch (this._State)
                {
                    case 0:
                        this._State = -1;
                        if (this.count <= 0)
                        {
                            goto Label_009A;
                        }
                        this._SourceEnumerator = this.source.GetEnumerator();
                        this._State = 1;
                        goto Label_0087;

                    case 2:
                        this._State = 1;
                        if (--this.count == 0)
                        {
                            goto Label_0094;
                        }
                        goto Label_0087;

                    default:
                        goto Label_009A;
                }
            Label_0045:
                this._Item = this._SourceEnumerator.Current;
                this._Current = this._Item;
                this._State = 2;
                return true;
            Label_0087:
                if (this._SourceEnumerator.MoveNext())
                {
                    goto Label_0045;
                }
            Label_0094:
                this._State = -1;
                if (this._SourceEnumerator != null)
                {
                    this._SourceEnumerator.Dispose();
                }
            Label_009A:
                success = false;
            }
            finally
            {
                this.Dispose();
            }
            return success;
        }

        public IEnumerator<TSource> GetEnumerator()
        {
            JsImplTakeIterator<TSource> iterator;
            if (this._State == -2)
            {
                this._State = 0;
                iterator = this;
            }
            else
            {
                iterator = new JsImplTakeIterator<TSource>(0);
            }
            iterator.source = this._Source;
            iterator.count = this._Count;
            return iterator;
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }

        public void Dispose()
        {
        }

        // Properties
        public TSource Current
        {
            get
            {
                return this._Current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return this._Current;
            }
        }

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }


}
