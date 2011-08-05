using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{

	[JsType(Name = "System.Collections.Generic.IEnumerator", Filename = "~/Internal/Core.js")]
	public interface JsImplIEnumerator<T>
	{
	}

	[JsType(Name = "System.Collections.Generic.IEnumerable", Filename = "~/Internal/Core.js")]
	internal interface JsImplIEnumerable<T> : JsImplIEnumerable
	{
	}

	[JsType(Name = "System.Collections.Generic.IList", Filename = "~/Internal/Core.js")]
	internal interface JsImplIList<T> : JsImplICollection<T>
	{
	}

	[JsType(Name = "System.Collections.Generic.ICollection", Filename = "~/Internal/Core.js")]
	internal interface JsImplICollection<T> : JsImplIEnumerable<T>
	{
	}

	[JsType(Name = "System.Collections.Generic.IDictionary", Filename = "~/Internal/Core.js")]
	internal interface JsImplIDictionary<K, T>
	{
	}

}
