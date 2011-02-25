using System;
using System.Collections.Generic;

using System.Text;
using System.Collections;

namespace SharpKit.JavaScript.Private
{
	[JsType(Name = "System.Collections.Generic.Stack", Filename = "~/res/System.Collections.js")]
	public class JsImplStack<T> : IEnumerable<T>, ICollection
	{
		JsExtendedArray _list;
		public JsImplStack()
		{
			this._list = new JsExtendedArray();
		}
		public void Clear()
		{
			this._list.Clear();
		}
		public int Count
		{
			get
			{
				return this._list.length;
			}
		}
		public IEnumerator<T> GetEnumerator()
		{
			return this._list.GetEnumerator().As<IEnumerator<T>>();
		}
		public T[] ToArray()
		{
			return this._list.Clone().As<T[]>();
		}
		public void Push(T item)
		{
			this._list.push(item);
		}
		public object Pop()
		{
			if (this._list.length == 0)
				throw new JsError("Cannot pop from stack - stack is empty").As<Exception>();
			return this._list.pop();
		}
		public bool Contains(T item)
		{
			return this._list.contains(item);
		}


		#region IEnumerable Members

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region ICollection Members

		void ICollection.CopyTo(Array array, int index)
		{
			throw new NotImplementedException();
		}

		bool ICollection.IsSynchronized
		{
			get { throw new NotImplementedException(); }
		}

		object ICollection.SyncRoot
		{
			get { throw new NotImplementedException(); }
		}

		#endregion
	}
}
