//
// System.BitConverter.cs
//
// Author:
//   Matt Kimball (matt@kimball.net)
//
//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//
//Modified for JS: 9/10/12 
//Niels Linders (nielsLinders@gmail.com)
//StatusQuote Inc.
//

using System;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.JsClr.System;

namespace SQSystem
{
    [JsType(Name = "System.BitConverter", Filename = "~/Internal/Core.js", Mode = JsMode.Clr)]
	public static class BitConverter
	{
		static readonly bool SwappedWordsInDouble = DoubleWordsAreSwapped ();
		public static readonly bool IsLittleEndian = AmILittleEndian ();

		static bool AmILittleEndian ()
		{
			// binary representations of 1.0:
			// big endian: 3f f0 00 00 00 00 00 00
			// little endian: 00 00 00 00 00 00 f0 3f
			// arm fpa little endian: 00 00 f0 3f 00 00 00 00
			double d = 1.0;
		    return ((int)d.GetPointer()[0] == 0);
		}

		static bool DoubleWordsAreSwapped ()
		{
			// binary representations of 1.0:
			// big endian: 3f f0 00 00 00 00 00 00
			// little endian: 00 00 00 00 00 00 f0 3f
			// arm fpa little endian: 00 00 f0 3f 00 00 00 00
            double d = 1.0;
            return (int)d.GetPointer()[2] == 0xf0;
		}

		public static long DoubleToInt64Bits (double value)
		{
			return (long) value;
		}

		public static double Int64BitsToDouble (long value)
		{
			return value;
		}

		internal static double InternalInt64BitsToDouble (long value)
		{
			return SwappableToDouble (GetBytes (value), 0);
		}
		
		static byte[] GetBytes (Pointer ptr, int count)
		{
			byte [] ret = new byte [count];

			for (int i = 0; i < count; i++) {
				ret [i] = ptr [i];
			}

			return ret;
		}

		public static byte[] GetBytes (bool value)
		{
			return GetBytes (value.GetPointer(), 1);
		}

		public static byte[] GetBytes (char value)
		{
            return GetBytes(value.GetPointer(), 2);
		}

		public static byte[] GetBytes (short value)
		{
            return GetBytes(value.GetPointer(), 2);
		}

		public static byte[] GetBytes (int value)
		{
			return GetBytes (value.GetPointer(), 4);
		}

		public static byte[] GetBytes (long value)
		{
			return GetBytes (value.GetPointer(), 8);
		}

		public static byte[] GetBytes (ushort value)
		{
			return GetBytes (value.GetPointer(), 2);
		}

		
		public static byte[] GetBytes (uint value)
		{
			return GetBytes (value.GetPointer(), 4);
		}

		
		public static byte[] GetBytes (ulong value)
		{
			return GetBytes (value.GetPointer(), 8);
		}

		public static byte[] GetBytes (float value)
		{
            return GetBytes(value.GetPointer(), 4);
		}

		public static byte[] GetBytes (double value)
		{
			if (SwappedWordsInDouble) {
				byte[] data = new byte [8];
                Pointer p = value.GetPointer();
				data [0] = p [4];
                data[1] = p[5];
                data[2] = p[6];
                data[3] = p[7];
                data[4] = p[0];
                data[5] = p[1];
                data[6] = p[2];
                data[7] = p[3];
				return data;
			} else {
                return GetBytes(value.GetPointer(), 8);
			}
		}

		static void PutBytes (Pointer dst, byte[] src, int start_index, int count)
		{
			if (src == null)
				throw new ArgumentNullException ("value");

			if (start_index < 0 || (start_index > src.Length - 1))
				throw new ArgumentOutOfRangeException ("startIndex", "Index was"
					+ " out of range. Must be non-negative and less than the"
					+ " size of the collection.");

			// avoid integer overflow (with large pos/neg start_index values)
			if (src.Length - count < start_index)
				throw new ArgumentException ("Destination array is not long"
					+ " enough to copy all the items in the collection."
					+ " Check array index and length.");

			for (int i = 0; i < count; i++)
				dst[i] = src[i + start_index];
		}

		public static bool ToBoolean (byte[] value, int startIndex)
		{
			if (value == null) 
				throw new ArgumentNullException ("value");

			if (startIndex < 0 || (startIndex > value.Length - 1))
				throw new ArgumentOutOfRangeException ("startIndex", "Index was"
					+ " out of range. Must be non-negative and less than the"
					+ " size of the collection.");

			if (value [startIndex] != 0)
				return true;
			
			return false;
		}

		public static char ToChar (byte[] value, int startIndex)
		{
			char ret = '\0';

			PutBytes (ret.GetPointer(), value, startIndex, 2);

			return ret;
		}

		public static short ToInt16 (byte[] value, int startIndex)
		{
            short ret = 0;

			PutBytes (ret.GetPointer(), value, startIndex, 2);

			return ret;
		}

		public static int ToInt32 (byte[] value, int startIndex)
		{
		    int ret = 0;

			PutBytes (ret.GetPointer(), value, startIndex, 4);

			return ret;
		}

		public static long ToInt64 (byte[] value, int startIndex)
		{
			long ret = 0; 

			PutBytes (ret.GetPointer(), value, startIndex, 8);

			return ret;
		}

		public static ushort ToUInt16 (byte[] value, int startIndex)
		{
			ushort ret = 0;

			PutBytes (ret.GetPointer(), value, startIndex, 2);

			return ret;
		}

		
		public static uint ToUInt32 (byte[] value, int startIndex)
		{
			uint ret = 0;

			PutBytes (ret.GetPointer(), value, startIndex, 4);

			return ret;
		}

		
		public static ulong ToUInt64 (byte[] value, int startIndex)
		{
			ulong ret = 0;

			PutBytes (ret.GetPointer(), value, startIndex, 8);

			return ret;
		}

		public static float ToSingle (byte[] value, int startIndex)
		{
			float ret = 0;

			PutBytes (ret.GetPointer(), value, startIndex, 4);

			return ret;
		}

		public static double ToDouble (byte[] value, int startIndex)
		{
			double ret = 0;

			if (SwappedWordsInDouble) {
                var p = ret.GetPointer();
				if (value == null)
					throw new ArgumentNullException ("value");

				if (startIndex < 0 || (startIndex > value.Length - 1))
					throw new ArgumentOutOfRangeException ("startIndex", "Index was"
						+ " out of range. Must be non-negative and less than the"
						+ " size of the collection.");

				// avoid integer overflow (with large pos/neg start_index values)
				if (value.Length - 8 < startIndex)
					throw new ArgumentException ("Destination array is not long"
						+ " enough to copy all the items in the collection."
						+ " Check array index and length.");

				p [0] = value [startIndex + 4];
				p [1] = value [startIndex + 5];
				p [2] = value [startIndex + 6];
				p [3] = value [startIndex + 7];
				p [4] = value [startIndex + 0];
				p [5] = value [startIndex + 1];
				p [6] = value [startIndex + 2];
				p [7] = value [startIndex + 3];

				return ret;
			}

            PutBytes(ret.GetPointer(), value, startIndex, 8);

			return ret;
		}

		internal static double SwappableToDouble (byte[] value, int startIndex)
		{
			double ret = 0;

			if (SwappedWordsInDouble) {
                var p = ret.GetPointer();
				if (value == null)
					throw new ArgumentNullException ("value");

				if (startIndex < 0 || (startIndex > value.Length - 1))
					throw new ArgumentOutOfRangeException ("startIndex", "Index was"
						+ " out of range. Must be non-negative and less than the"
						+ " size of the collection.");

				// avoid integer overflow (with large pos/neg start_index values)
				if (value.Length - 8 < startIndex)
					throw new ArgumentException ("Destination array is not long"
						+ " enough to copy all the items in the collection."
						+ " Check array index and length.");

				p [0] = value [startIndex + 4];
				p [1] = value [startIndex + 5];
				p [2] = value [startIndex + 6];
				p [3] = value [startIndex + 7];
				p [4] = value [startIndex + 0];
				p [5] = value [startIndex + 1];
				p [6] = value [startIndex + 2];
				p [7] = value [startIndex + 3];

				return ret;
			} else if (!IsLittleEndian) {
                var p = ret.GetPointer();
				if (value == null)
					throw new ArgumentNullException ("value");

				if (startIndex < 0 || (startIndex > value.Length - 1))
					throw new ArgumentOutOfRangeException ("startIndex", "Index was"
						+ " out of range. Must be non-negative and less than the"
						+ " size of the collection.");

				// avoid integer overflow (with large pos/neg start_index values)
				if (value.Length - 8 < startIndex)
					throw new ArgumentException ("Destination array is not long"
						+ " enough to copy all the items in the collection."
						+ " Check array index and length.");

				p [0] = value [startIndex + 7];
				p [1] = value [startIndex + 6];
				p [2] = value [startIndex + 5];
				p [3] = value [startIndex + 4];
				p [4] = value [startIndex + 3];
				p [5] = value [startIndex + 2];
				p [6] = value [startIndex + 1];
				p [7] = value [startIndex + 0];

				return ret;
			}

            PutBytes(ret.GetPointer(), value, startIndex, 8);

			return ret;
		}
		
		public static string ToString (byte[] value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");

			return ToString (value, 0, value.Length);
		}

		public static string ToString (byte[] value, int startIndex)
		{
			if (value == null)
				throw new ArgumentNullException ("value");

			return ToString (value, startIndex, value.Length - startIndex);
		}

		public static string ToString (byte[] value, int startIndex, int length)
		{
			if (value == null)
				throw new ArgumentNullException ("byteArray");

			// The 4th and last clause (start_index >= value.Length)
			// was added as a small fix to a very obscure bug.
			// It makes a small difference when start_index is
			// outside the range and length==0. 
			if (startIndex < 0 || startIndex >= value.Length) {
				// special (but valid) case (e.g. new byte [0])
				if ((startIndex == 0) && (value.Length == 0))
					return String.Empty;
				throw new ArgumentOutOfRangeException ("startIndex", "Index was"
					+ " out of range. Must be non-negative and less than the"
					+ " size of the collection.");
			}

			if (length < 0)
				throw new ArgumentOutOfRangeException ("length",
					"Value must be positive.");

			// note: re-ordered to avoid possible integer overflow
			if (startIndex > value.Length - length)
				throw new ArgumentException ("startIndex + length > value.Length");

			if (length == 0)
				return string.Empty;

			StringBuilder builder = new StringBuilder(length * 3 - 1);
			int end = startIndex + length;

			for (int i = startIndex; i < end; i++) {
				if (i > startIndex)
					builder.Append('-');
				
				char high = (char)((value[i] >> 4) & 0x0f);
				char low = (char)(value[i] & 0x0f);

				if (high < 10) 
					high += '0';
				else {
					high -= (char) 10;
					high += 'A';
				}

				if (low < 10)
					low += '0';
				else {
					low -= (char) 10;
					low += 'A';
				}
				builder.Append(high);
				builder.Append(low);
			}

			return builder.ToString ();
		}
	}
}
