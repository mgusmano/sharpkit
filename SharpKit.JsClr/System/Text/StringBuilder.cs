using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{
	[JsType(Name = "System.Text.StringBuilder", Filename="~/res/System.Text.js")]
	class JsImplStringBuilder
	{
		JsExtendedArray array;
		int length;

		public JsImplStringBuilder()
		{
			this.array = new string[0].As<JsExtendedArray>();
			this.length = 0;

		}

		public JsImplStringBuilder(string s)
		{
			this.array = new string[] { s }.As<JsExtendedArray>();
			this.length = s == null ? 0 : s.Length;
		}


		public void Append(char s)
		{
			this.array.push(s);
			this.length += 1;
		}

		public void Append(string s)
		{
			this.array.push(s);
			this.length += s.Length;
		}

		public void AppendFormat(string s, object arg0)
		{
			string ss = String.Format(s, arg0);
			this.array.push(ss);
			this.length += ss.Length;
		}

		public void AppendFormat(string s, object arg0, object arg1)
		{
			string ss = String.Format(s, arg0, arg1);
			this.array.push(ss);
			this.length += ss.Length;
		}

		public void AppendFormat(string s, object arg0, object arg1, object arg2)
		{
			string ss = String.Format(s, arg0, arg1, arg2);
			this.array.push(ss);
			this.length += ss.Length;
		}

		public void Append(object obj)
		{
			if (obj != null)
			{
				var s = obj.ToString();
				this.array.push(s);
				this.length += s.Length;
			}
		}

		public override string ToString()
		{
			return this.array.join("");
		}

		public int Length
		{
			get
			{
				return this.length;
			}
			set
			{
				if (value != 0)
					throw new Exception("Not Implemented");
				this.array.Clear();
				this.length = value;
			}
		}
		[JsMethod(NativeOverloads = true)]
		public JsImplStringBuilder Remove(int start, int count)
		{
			var s = this.array.join("");
			s = s.As<string>().Remove(start, count);
			this.array = new object[] { s }.As<JsExtendedArray>();
			this.length = s.length;
			return this;
		}
	}


    [JsType(Name = "System.StringComparison", Filename = "~/Internal/Core.js")]
	public enum JsImplStringComparison
	{
		CurrentCulture,
		CurrentCultureIgnoreCase,
		InvariantCulture,
		InvariantCultureIgnoreCase,
		Ordinal,
		OrdinalIgnoreCase
	}




 

}
