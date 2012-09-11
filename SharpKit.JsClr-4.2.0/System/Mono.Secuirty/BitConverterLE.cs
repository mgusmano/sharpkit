//
// Mono.Security.BitConverterLE.cs
//  Like System.BitConverter but always little endian
//
// Author:
//   Bernie Solomon
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

using System;
using SharpKit.JsClr.System;

namespace Mono.Security
{
	public class BitConverterLE
	{
		private BitConverterLE ()
		{
		}
		private static byte[] GetUShortBytes (Pointer bytes)
		{
			if (BitConverter.IsLittleEndian)
				return new byte [] { bytes [0], bytes [1] };
			else
				return new byte [] { bytes [1], bytes [0] };
		}

        private static byte[] GetUIntBytes(Pointer bytes)
		{
			if (BitConverter.IsLittleEndian)
				return new byte [] { bytes [0], bytes [1], bytes [2], bytes [3] };
			else
				return new byte [] { bytes [3], bytes [2], bytes [1], bytes [0] };
		}

		private static byte[] GetULongBytes (Pointer bytes)
		{
			if (BitConverter.IsLittleEndian)
				return new byte [] { bytes [0], bytes [1], bytes [2], bytes [3],
						     bytes [4], bytes [5], bytes [6], bytes [7] };
			else
				return new byte [] { bytes [7], bytes [6], bytes [5], bytes [4],
						     bytes [3], bytes [2], bytes [1], bytes [0] };
		}

		internal static byte[] GetBytes (bool value)
		{
			return new byte [] { value ? (byte)1 : (byte)0 };
		}

		internal static byte[] GetBytes (char value)
		{
			return GetUShortBytes (value.GetPointer());
		}

		internal static byte[] GetBytes (short value)
		{
			return GetUShortBytes (value.GetPointer());
		}

		internal static byte[] GetBytes (int value)
		{
			return GetUIntBytes (value.GetPointer());
		}

		internal static byte[] GetBytes (long value)
		{
			return GetULongBytes (value.GetPointer());
		}

		internal static byte[] GetBytes (ushort value)
		{
            return GetUShortBytes(value.GetPointer());
		}

		internal static byte[] GetBytes (uint value)
		{
            return GetUIntBytes(value.GetPointer());
		}

		internal static byte[] GetBytes (ulong value)
		{
            return GetULongBytes(value.GetPointer());
		}

		internal static byte[] GetBytes (float value)
		{
            return GetUIntBytes(value.GetPointer());
		}

		internal static byte[] GetBytes (double value)
		{
            return GetULongBytes(value.GetPointer());
		}

		private static void UShortFromBytes (Pointer dst, byte[] src, int startIndex)
		{
			if (BitConverter.IsLittleEndian) {
				dst [0] = src [startIndex];
				dst [1] = src [startIndex + 1];
			} else {
				dst [0] = src [startIndex + 1];
				dst [1] = src [startIndex];
			}
		}


		internal static bool ToBoolean (byte[] value, int startIndex)
		{
			return value [startIndex] != 0;
		}

		internal static char ToChar (byte[] value, int startIndex)
		{
			char ret = '\0';

			UShortFromBytes (ret.GetPointer(), value, startIndex);

			return ret;
		}

		internal static short ToInt16 (byte[] value, int startIndex)
		{
			short ret = 0;

            UShortFromBytes(ret.GetPointer(), value, startIndex);

			return ret;
		}

		internal static int ToInt32 (byte[] value, int startIndex)
		{
			int ret = 0;

            UIntFromBytes(ret.GetPointer(), value, startIndex);

			return ret;
		}

		internal static long ToInt64 (byte[] value, int startIndex)
		{
			long ret = 0;

            ULongFromBytes(ret.GetPointer(), value, startIndex);

			return ret;
		}

		internal static ushort ToUInt16 (byte[] value, int startIndex)
        {
			ushort ret = 0;

            UShortFromBytes(ret.GetPointer(), value, startIndex);

			return ret;
		}

		internal static uint ToUInt32 (byte[] value, int startIndex)
		{
			uint ret = 0;

            UIntFromBytes(ret.GetPointer(), value, startIndex);

			return ret;
		}

		internal static ulong ToUInt64 (byte[] value, int startIndex)
		{
			ulong ret = 0;

			ULongFromBytes (ret.GetPointer(), value, startIndex);

			return ret;
		}
        internal static float ToSingle (byte[] value, int startIndex)
		{
			float ret = 0;

            UIntFromBytes(ret.GetPointer(), value, startIndex);

			return ret;
		}
        private static void ULongFromBytes(Pointer dst, byte[] src, int startIndex)
        {
            if (BitConverter.IsLittleEndian)
            {
                for (int i = 0; i < 8; ++i)
                    dst[i] = src[startIndex + i];
            }
            else
            {
                for (int i = 0; i < 8; ++i)
                    dst[i] = src[startIndex + (7 - i)];
            }
        }
        
        private static void UIntFromBytes(Pointer dst, byte[] src, int startIndex)
        {
            if (BitConverter.IsLittleEndian)
            {
                dst[0] = src[startIndex];
                dst[1] = src[startIndex + 1];
                dst[2] = src[startIndex + 2];
                dst[3] = src[startIndex + 3];
            }
            else
            {
                dst[0] = src[startIndex + 3];
                dst[1] = src[startIndex + 2];
                dst[2] = src[startIndex + 1];
                dst[3] = src[startIndex];
            }
        }
		internal static double ToDouble (byte[] value, int startIndex)
		{
			double ret = 0;

            ULongFromBytes(ret.GetPointer(), value, startIndex);

			return ret;
		}

    }

}
