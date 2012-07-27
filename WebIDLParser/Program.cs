
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

namespace WebIDLParser
{

	public class Program
	{

		//Path to the existing project SharpKit.Html project
		public static string csOutDirectory = @"D:\dotnet\sharpkit\sdk\sdk\SharpKit.Html.Idl\";

		//Path to the WebKit(--> WebCore) sources. ( http://trac.webkit.org/browser/trunk/Source/WebCore/ )
		public static string idlInDirectory = @"D:\dotnet\webkit\Source\WebCore\";

		//An temporary directory, where the preprocessed IDL files will be stored.
		public static string idlOutTempDirectory = @"D:\IdlCs\idl\";

		//Set only to false, when you already have the preprocessed IDL files in the idlOutTempDirectory.
		public static bool runPreprocessor = false;

		//Path to a c/c++ compiler, used for preprocessing the files.
		public static string preprocessorExe = @"C:\Program Files (x86)\Microsoft Visual Studio 10.0\VC\bin\amd64\cl.exe";

		public static void Main(string[] args) {
			Generator.start();
		}

	}

}

