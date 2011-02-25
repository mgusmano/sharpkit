using System;
using System.Collections.Generic;

using System.Text;

using SharpKit.JavaScript.Compilation;

namespace SharpKit.JavaScript.Private
{

	[JsType(Name = "System.Delegate", Filename = "~/Internal/Core.js")]
	internal abstract class JsImplDelegate
	{
		public static JsImplDelegate Combine(JsImplDelegate delegate1, JsImplDelegate delegate2)
		{
			if (delegate1 == null)
				return delegate2;
			if (delegate1.As<JsImplMulticastDelegate>()._IsSealed)
				delegate1 = delegate1.Clone();
			delegate1._Add(delegate2);
			return delegate1;
		}

		protected abstract JsImplDelegate Clone();

		//TODO: HACK
		static JsImplDelegate Combine(object obj)
		{
			throw new NotImplementedException();

		}
		public static JsImplDelegate Remove(JsImplDelegate delegate1, JsImplDelegate delegate2)
		{
			if (delegate1 == null)
				return null;
			if (delegate1.As<JsImplMulticastDelegate>().Equals(delegate2.As<JsImplMulticastDelegate>()))
				return null;
			if (delegate1.As<JsImplMulticastDelegate>()._IsSealed)
				delegate1 = delegate1.Clone();
			delegate1._Remove(delegate2);
			return delegate1;
		}

		internal abstract void _Add(JsImplDelegate del);

		internal abstract void _Remove(JsImplDelegate del);

		public virtual object DynamicInvoke(params object[] args)
		{
			throw new Exception("DynamicInvoke is available only on MulticastDelegates");
		}

	}



	[JsType(Name = "System.MulticastDelegate", Filename = "~/Internal/Core.js")]
	internal class JsImplMulticastDelegate : JsImplDelegate
	{
		[JsMethod(NativeOverloads=true)]
		protected internal JsImplMulticastDelegate(JsObject obj2, JsFunction func2)
		{
			if (func2 == null)
				throw new Exception("ArgumentNullException - func");
			obj = obj2;
			func = func2;
		}

		JsFunction func;
		JsObject obj;
		JsExtendedArray delegates;
		JsFunction _jsFunc;
		JsFunction _ToJsFunction()
		{
			if (delegates != null)
				throw new Exception("Not Implemented");
			if (_jsFunc == null)
			{
				_jsFunc = VM.GetDelegate(obj, func);
			}
			return _jsFunc;
		}

		public JsImplDelegate[] GetInvocationList()
		{
			var ar = delegates.Clone();
			ar.insert(0, new JsImplMulticastDelegate(obj, func));
			return ar.As<JsImplDelegate[]>();
		}

		[JsMethod(Code = @"
var x = new this.constructor(this.obj, this.func);
if(this.delegates!=null)
	x.delegates = this.delegates.concat(); //clone
return x;
")]
		protected override JsImplDelegate Clone()
		{
			throw new NotImplementedException();
		}
		public override int GetHashCode()
		{
			//TODO:?
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (obj is JsImplMulticastDelegate)
				return Equals(obj.As<JsImplMulticastDelegate>());
			return false;
		}

		public bool Equals(JsImplMulticastDelegate del)
		{
			if(del==null)
				return false;
			if(this==del)
				return true;
			if (obj == del.obj && func == del.func)
			{
				if ((delegates == null || delegates.length == 0))
					return del.delegates == null || del.delegates.length == 0;
				if (del.delegates == null || del.delegates.length == 0)
					return false;
				if (delegates.length != del.delegates.length)
					return false;
				for (var i = 0; i < delegates.length; i++)
				{
					if (!delegates[i].Equals(del.delegates[i]))
						return false;
				}
				return true;
			}
			return false;
		}
		internal override void _Add(JsImplDelegate del)
		{
			if (_jsFunc != null)
				throw new Exception("Cannot change delegate - jsfunc already created");
			if (delegates == null)
				delegates = new JsExtendedArray();
			delegates.push(del);
		}

		internal override void _Remove(JsImplDelegate del)
		{
			if (delegates != null)
			{
				for (var i = 0; i < delegates.length; i++)
				{
					var del2 = delegates[i];
					if (del.As<JsImplMulticastDelegate>().Equals(del2.As<JsImplMulticastDelegate>()))
					{
						delegates.RemoveAt(i);
						return;
					}
				}
			}
		}

		internal bool _IsSealed;
		[JsMethod(Code= @"
			var restoreIsSealed = false;
			if(!this._IsSealed)
			{
				this._IsSealed = true;
				restoreIsSealed = true;
			}
			var res = this.func.apply(this.obj, arguments);
			if (this.delegates != null)
			{
				var length = this.delegates.length;
				if(length>0)
				{
					for (var i = 0; i < length; i++)
					{
						var del = this.delegates[i];
						res = del.Invoke.apply(del, arguments);
					}
				}
			}
			if(restoreIsSealed)
				this._IsSealed = false;
			return res;", NativeOverloads=true)]
		internal object Invoke(params object[] varargs)
		{
			throw new NotImplementedException();
		}

		[JsMethod(Code = @"return this.Invoke.apply(this, arguments);")]
		public override object DynamicInvoke(params object[] args)
		{
			throw new NotImplementedException();
		}

	}

}
