
/****************************************************************************************************

  Author of this tool: Sebastian Loncar, http://loncar.de

*****************************************************************************************************

  This library is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  This library is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.

*****************************************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace WebIDLParser
{
	public class TStringList : List<string>
	{
	}

	public static class LarneFunctions
	{

		//------------------------------------------------------------------------------------------------------------------
		public static string StringLoadFromFile(string File, bool IgnoreIfFileNotExists = false) {
			return StringLoadFromFile(File, DefaultEncoding, IgnoreIfFileNotExists);
		}

		//------------------------------------------------------------------------------------------------------------------
		public static string StringLoadFromFile(string File, System.Text.Encoding Enc, bool IgnoreIfFileNotExists = false) {
			if (File == "" || !(System.IO.File.Exists(File))) {
				if (File != "" && System.IO.File.Exists(File + ".bak")) {
					File = File + ".bak";
				}
				else {
					if (IgnoreIfFileNotExists) {
						return "";
					}
					else {
						throw new Exception("Datei " + File + " existiert nicht!");
					}
				}
			}
			System.IO.FileStream fs = System.IO.File.Open(File, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite);
			try {
				byte[] buf = new byte[fs.Length];
				fs.Read(buf, 0, (int)fs.Length);
				fs.Close();
				return BufferToString(ref buf, Enc);
			}
			finally {
				fs.Close();
			}
		}

		//------------------------------------------------------------------------------------------------------------------
		public static void StringSaveToFile(string File, string Text) {
			StringSaveToFile(File, Text, DefaultEncoding);
		}

		//------------------------------------------------------------------------------------------------------------------
		public static void StringSaveToFile(string File, string Text, System.Text.Encoding Enc) {
			if (System.IO.File.Exists(File)) {
				System.IO.File.Delete(File);
			}
			System.IO.FileStream fs = System.IO.File.Open(File, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
			try {
				byte[] buf = StringToBuffer(ref Text, Enc);
				fs.Write(buf, 0, buf.Length);
			}
			finally {
				fs.Flush();
				fs.Close();
			}
		}

		//------------------------------------------------------------------------------------------------------------------
		public static byte[] StringToBuffer(ref string Str) {
			if (Str == null || Str == "") {
				return new byte[0];
			}
			else {
				return DefaultEncoding.GetBytes(Str);
			}
		}

		//------------------------------------------------------------------------------------------------------------------
		public static byte[] StringToBuffer(ref string Str, System.Text.Encoding Encoding) {
			if (Str == null || Str == "") {
				return new byte[0];
			}
			else {
				return Encoding.GetBytes(Str);
			}
		}

		//------------------------------------------------------------------------------------------------------------------
		private static System.Text.Encoding _DefaultEncoding = System.Text.Encoding.UTF8;
		public static System.Text.Encoding DefaultEncoding {
			get {
				return _DefaultEncoding;
			}
			set {
				_DefaultEncoding = value;
			}
		}

		//------------------------------------------------------------------------------------------------------------------
		public static string BufferToString(ref byte[] Buffer) {
			return BufferToString(ref Buffer, DefaultEncoding);
		}

		//------------------------------------------------------------------------------------------------------------------
		public static string BufferToString(ref byte[] Buffer, System.Text.Encoding Encoding) {
			return Encoding.GetString(Buffer);
		}

	}
}