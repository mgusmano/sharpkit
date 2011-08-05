using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{

	[JsType(Name = "System.Action", Filename = "~/Internal/Core.js")]
	internal delegate void JsImplAction();

	[JsType(Name = "System.Action", Filename = "~/Internal/Core.js")]
	internal delegate void JsImplAction<T>(T obj);

	[JsType(Name = "System.Action", Filename = "~/Internal/Core.js")]
	internal delegate void JsImplAction<T1, T2>(T1 arg1, T2 arg2);

	[JsType(Name = "System.Action", Filename = "~/Internal/Core.js")]
	internal delegate void JsImplAction<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3);

	[JsType(Name = "System.Func", Filename = "~/Internal/Core.js")]
	internal delegate TResult JsImplFunc<TResult>();

	[JsType(Name = "System.Func", Filename = "~/Internal/Core.js")]
	internal delegate TResult JsImplFunc<T, TResult>(T obj);

	[JsType(Name = "System.Func", Filename = "~/Internal/Core.js")]
	internal delegate TResult JsImplFunc<T1, T2, TResult>(T1 arg1, T2 arg2);

	[JsType(Name = "System.Func", Filename = "~/Internal/Core.js")]
	internal delegate TResult JsImplFunc<T1, T2, T3, TResult>(T1 arg1, T2 arg2, T3 arg3);

	[JsType(Name = "System.EventHandler", Filename = "~/Internal/Core.js")]
	internal delegate void JsImplEventHandler(object sender, JsImplEventArgs e);

	[JsType(Name = "System.EventHandler", Filename = "~/Internal/Core.js")]
	internal delegate void JsImplEventHandler<TEventArgs>(object sender, TEventArgs e) where TEventArgs : EventArgs;

	[JsType(Name = "System.Predicate", Filename = "~/Internal/Core.js")]
	internal delegate bool JsImplPredicate<T>(T item);

}