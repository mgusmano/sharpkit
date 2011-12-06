using System;
using System.Collections.Generic;

using System.Text;

using System.Collections;

namespace SharpKit.JavaScript.Private
{
	[JsType(Name = "System.Linq.WhereIterator", Filename = "~/res/System.Linq.js")]
	class WhereIterator<T> : IEnumerator<T>, IEnumerable<T>
	{
		public WhereIterator(IEnumerable<T> source, Func<T, bool> predicate)
		{
			this.Source = source;
			this.Predicate = predicate;
		}
		Func<T, bool> Predicate;
		IEnumerable<T> Source;
		IEnumerator<T> SourceEnumerator;

		public void Reset()
		{
			if (SourceEnumerator != null)
				this.SourceEnumerator.Reset();
		}
		public T Current
		{
			get
			{
				return SourceEnumerator.Current;
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
				if (Predicate(item))
					return true;
			}
		}

		#region IDisposable Members

		public void Dispose()
		{
			Source = null;
			Predicate = null;
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


	[JsType(Name = "System.Linq.SelectIterator", Filename = "~/res/System.Linq.js")]
	class JsImplSelectIterator<TSource, TResult> : IEnumerator<TResult>, IEnumerable<TResult>
	{
		public JsImplSelectIterator(IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			Source = source;
			Selector = selector;
		}
		Func<TSource, TResult> Selector;
		IEnumerable<TSource> Source;
		IEnumerator<TSource> SourceEnumerator;

		public void Reset()
		{
			if (SourceEnumerator != null)
				this.SourceEnumerator.Reset();
		}
		public TResult Current
		{
			get
			{
				return Selector(SourceEnumerator.Current);
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
				return true;
			}
		}

		#region IDisposable Members

		public void Dispose()
		{
			Selector = null;
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

		public IEnumerator<TResult> GetEnumerator()
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



	//sealed class JsImplSkipIterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IEnumerator, IDisposable
	//{
	//  // Fields
	//  private int __1__state;
	//  private TSource __2__current;
	//  public int __3__count;
	//  public IEnumerable<TSource> __3__source;
	//  //private int __l__initialThreadId;
	//  public IEnumerator<TSource> _e_5__4e;
	//  public int count;
	//  public IEnumerable<TSource> source;

	//  public JsImplSkipIterator(int __1__state)
	//  {
	//    this.__1__state = __1__state;
	//    // this.__l__initialThreadId = Thread.CurrentThread.ManagedThreadId;
	//  }

	//  private void __m__Finally4f()
	//  {
	//    this.__1__state = -1;
	//    if (this._e_5__4e != null)
	//    {
	//      this._e_5__4e.Dispose();
	//    }
	//  }

	//  private bool MoveNext()
	//  {
	//      bool flag;
	//      try
	//      {
	//          switch (this.__1__state)
	//          {
	//              case 0:
	//                  this.__1__state = -1;
	//                  this._e_5__4e = this.source.GetEnumerator();
	//                  this.__1__state = 1;
	//                  goto Label_004D;

	//              case 2:
	//                  goto Label_008A;

	//              default:
	//                  goto Label_00A4;
	//          }
	//      Label_003F:
	//          this.count--;
	//      Label_004D:
	//          if ((this.count > 0) && this._e_5__4e.MoveNext())
	//          {
	//              goto Label_003F;
	//          }
	//          if (this.count <= 0)
	//          {
	//              while (this._e_5__4e.MoveNext())
	//              {
	//                  this.__2__current = this._e_5__4e.Current;
	//                  this.__1__state = 2;
	//                  return true;
	//              Label_008A:
	//                  this.__1__state = 1;
	//              }
	//          }
	//          this.__m__Finally4f();
	//      Label_00A4:
	//          flag = false;
	//      }
	//      finally
	//      {
	//          Dispose();
	//      }
	//      return flag;
	//  }

	//  public IEnumerator<TSource> GetEnumerator()
	//  {
	//     JsImplSkipIterator<TSource> d__d;
	//     if (this.__1__state == -2)//(Thread.CurrentThread.ManagedThreadId == this.__l__initialThreadId) && 
	//      {
	//          this.__1__state = 0;
	//          d__d = this;
	//      }
	//      else
	//      {
	//        d__d = new JsImplSkipIterator<TSource>(0);
	//      }
	//      d__d.source = this.__3__source;
	//      d__d.count = this.__3__count;
	//      return d__d;
	//  }

	//  IEnumerator IEnumerable.GetEnumerator()
	//  {
	//    return GetEnumerator();
	//  }

	//  void IEnumerator.Reset()
	//  {
	//    throw new NotSupportedException();
	//  }

	//  public void Dispose()
	//  {
	//    switch (this.__1__state)
	//    {
	//      case 1:
	//      case 2:
	//        break;

	//      default:
	//        return;
	//        try
	//        {
	//        }
	//        finally
	//        {
	//          this.__m__Finally4f();
	//        }
	//        break;
	//    }
	//  }

	//  // Properties
	//  TSource IEnumerator<TSource>.Current
	//  {
	//    get
	//    {
	//      return this.__2__current;
	//    }
	//  }

	//  object IEnumerator.Current
	//  {
	//    get
	//    {
	//      return this.__2__current;
	//    }
	//  }
	//}




}
