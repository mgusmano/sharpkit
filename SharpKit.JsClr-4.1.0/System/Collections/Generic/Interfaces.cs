using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{

	[JsType(Name = "System.Collections.Generic.IEnumerator$1", Filename = "~/Internal/Core.js")]
	public interface JsImplIEnumerator<T>
	{
	}

	[JsType(Name = "System.Collections.Generic.IEnumerable$1", Filename = "~/Internal/Core.js")]
	internal interface JsImplIEnumerable<T> : JsImplIEnumerable
	{
	}

	[JsType(Name = "System.Collections.Generic.IList$1", Filename = "~/Internal/Core.js")]
	internal interface JsImplIList<T> : JsImplICollection<T>
	{
	}

	[JsType(Name = "System.Collections.Generic.ICollection$1", Filename = "~/Internal/Core.js")]
	internal interface JsImplICollection<T> : JsImplIEnumerable<T>
	{
	}

	[JsType(Name = "System.Collections.Generic.IDictionary$2", Filename = "~/Internal/Core.js")]
	internal interface JsImplIDictionary<K, T>
	{
	}

}
