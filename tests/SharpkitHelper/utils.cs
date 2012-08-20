using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpkitHelper
{

	public class TStringList : List<string> { }

	public static class Extensions
	{

		public static bool isEmpty(this string self)
		{
			return self == null || self == "";
		}

	}

}
