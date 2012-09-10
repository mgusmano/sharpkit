using System;
using System.Collections.Generic;

using System.Text;

using System.Collections;

namespace SharpKit.JavaScript.Private
{

	[JsType(Name = "System.Char", Filename = "~/Internal/Core.js")]
	internal sealed class JsImplChar
	{
		[JsMethod(Code = @"return /\s/.test(c);")]
		public static bool IsWhiteSpace(char c)
		{
			throw new NotImplementedException();
		}

		public static bool IsUpper(char c)
		{
			//return true;
			return c.As<JsString>().toUpperCase() == c.As<string>();
			//c.IsU str.charAt(index).As<char>()
		}
	}

    [JsType(Name = "System.Byte", Filename = "~/Internal/Core.js")]
    internal sealed class JsImplByte
    {

    }
    [JsType(Name = "System.Int16", Filename = "~/Internal/Core.js")]
    internal sealed class JsImplInt16
    {

    }
    [JsType(Name = "System.Int64", Filename = "~/Internal/Core.js")]
    internal sealed class JsImplInt64
    {

    }
    [JsType(Name = "System.IntSingle", Filename = "~/Internal/Core.js")]
    internal sealed class JsImplIntSingle
    {

    }
    [JsType(Name = "System.SByte", Filename = "~/Internal/Core.js")]
    internal sealed class JsImplSByte
    {

    }
    [JsType(Name = "System.UInt16", Filename = "~/Internal/Core.js")]
    internal sealed class JsImplUInt16
    {

    }
    [JsType(Name = "System.UInt32", Filename = "~/Internal/Core.js")]
    internal sealed class JsImpUlInt32
    {

    }
    [JsType(Name = "System.UInt64", Filename = "~/Internal/Core.js")]
    internal sealed class JsImplUInt64
    {

    }


    [JsType(Name = "System.CharEnumerator", Filename = "~/Internal/Core.js")]
	internal sealed class JsImplCharEnumerator : IEnumerator<char>, IEnumerator
	{
		// Fields
		private char currentElement;
		private int index;
		private JsString str;

		// Methods
		internal JsImplCharEnumerator(JsString str2)
		{
			str = str2;
			index = -1;
		}


		public bool MoveNext()
		{
			if (index < (str.length - 1))
			{
				index++;
				currentElement = str.charAt(index).As<char>();
				return true;
			}
			index = str.length;
			return false;
		}

		public void Reset()
		{
			currentElement = '\0';
			index = -1;
		}

		void IDisposable.Dispose()
		{
		}

		// Properties
		public char Current
		{
			get
			{
				if (index == -1)
				{
					throw new InvalidOperationException("Enum Not Started");
				}
				if (index >= str.length)
				{
					throw new InvalidOperationException("Enum Ended");
				}
				return currentElement;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				if (index == -1)
				{
					throw new InvalidOperationException("Enum Not Started");
				}
				if (index >= str.length)
				{
					throw new InvalidOperationException("Enum Ended");
				}
				return currentElement;
			}
		}
	}



}
