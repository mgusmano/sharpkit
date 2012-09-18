
/*******************************************************************************************************

  Copyright (C) 2012 Sebastian Loncar, Web: http://loncar.de

  MIT License:

  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
  associated documentation files (the "Software"), to deal in the Software without restriction, 
  including without limitation the rights to use, copy, modify, merge, publish, distribute,
  sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all copies or substantial
  portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
  NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES
  OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*******************************************************************************************************/

namespace WebIDLParser
{

    public class Program
    {

        //Path to the existing project SharpKit.Html project
        public static string csOutDirectory = @"D:\dotnet\sharpkit\sdk\sharpkit\SharpKit.Html.Idl\";

        //Path to the WebKit(--> WebCore) sources. ( http://trac.webkit.org/browser/trunk/Source/WebCore/ )
        public static string idlInDirectory = @"D:\dotnet\webkit\Source\WebCore\";

        //An temporary directory, where the preprocessed IDL files will be stored.
        public static string idlOutTempDirectory = @"D:\IdlCs\idl\";

        //Needs to be true. Set only to false, when you already have the preprocessed IDL files in the idlOutTempDirectory.
        public static bool runPreprocessor = false;

        //Path to a c/c++ compiler, used for preprocessing the files.
        public static string preprocessorExe = @"C:\Program Files (x86)\Microsoft Visual Studio 10.0\VC\bin\amd64\cl.exe";

        public static void Main(string[] args)
        {
            Generator.start();
        }

    }

}

