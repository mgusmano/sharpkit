
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace WebIDLParser
{

	public class Generator
	{

		public static TParsedFileList parsedFiles = new TParsedFileList();

		public static void start() {
			if (!Directory.Exists(Program.idlOutTempDirectory)) Directory.CreateDirectory(Program.idlOutTempDirectory);
			if (!Directory.Exists(Program.csOutDirectory)) Directory.CreateDirectory(Program.csOutDirectory);

			TScriptTokenizer.SharedInit();

			//ConvertFile(@"D:\dotnet\webkit\Source\WebCore\Modules\intents\Intent.idl", csOutDirectory + @"test.cs");
			convertDirectory(Program.idlInDirectory, Program.csOutDirectory);

			foreach (var pFile in parsedFiles) {
				foreach (var ns in pFile.nsList) {
					foreach (var t in ns.types) {

						foreach (var attr in t.attributes) {
							if (attr is TNameAttribute) {
								var nameAttr = attr as TNameAttribute;
								if (nameAttr.name == "InterfaceName") {
									t.rename(nameAttr.value);
									break;
								}
							}

						}

						if (t.name == "Event") {
							t.rename("DOMEvent");
							t.aliasName = "Event";
						}

						if (t.name.StartsWith("HTML")) {
							t.aliasName = t.name;
							t.rename(t.name.Replace("HTML", "Html"));
						}

						if (t.name.StartsWith("SVG")) {
							t.aliasName = t.name;
							t.rename(t.name.Replace("SVG", "Svg"));
						}

						if (t.name.StartsWith("CSS")) {
							t.aliasName = t.name;
							t.rename(t.name.Replace("CSS", "Css"));
						}

						foreach (var mem in t.members) {
							if (mem.name.StartsWith("on") && mem.resultType.name == "EventListener") {
								var eventName = mem.name.Substring(2, 1).ToUpper() + mem.name.Substring(3) + "Event";
								var eventType = findType(eventName);
								if (eventType != null) {
									mem.resultType.name = "EventListener";
									mem.resultType.genericType = new TType() { name = eventName };
								}
							}
						}
					}
				}
			}

			foreach (var pFile in parsedFiles) {
				//pFile.removeUnknownTypes();
				foreach (var ns in pFile.nsList) {
					foreach (var t in ns.types) {
						t.checkConvertToInterface();
						t.generateConstructors();
					}
				}
			}

			foreach (var pFile in parsedFiles) {
				foreach (var ns in pFile.nsList) {
					foreach (var t in ns.types) {
						t.checkGenerateEnumerator();
					}
				}
			}

			foreach (var pFile in parsedFiles) {
				pFile.saveFile();
			}

			Console.WriteLine("ready");
			Console.ReadKey();
		}

		public static TFileType findType(string name) {
			foreach (var pFile in Generator.parsedFiles) {
				foreach (var ns in pFile.nsList) {
					foreach (var t in ns.types) {
						if (t.name == name) {
							return t;
						}
					}
				}
			}
			return null;
		}

		public static HashSet<string> namespaceNames = new HashSet<string>();
		public static TTypeList allTypes = new TTypeList();

		public static TFileTypeList findByBaseType(string name) {
			var list = new TFileTypeList();
			foreach (var pFile in Generator.parsedFiles) {
				foreach (var ns in pFile.nsList) {
					foreach (var t in ns.types) {
						foreach (var baseType in t.baseType) {
							if (baseType.name == name) list.Add(t); break;
						}
					}
				}
			}
			return list;
		}

		public static void convertFile(string InFile, string OutFile) {
			TStringList st = new TStringList();
			st.Add("org\\w3c\\dom\\html\\Function.java");
			st.Add("org\\w3c\\dom\\websocket");

			foreach (string f in st) {
				if (InFile.Contains(f)) {
					return;
				}
			}

			Console.WriteLine(InFile);

			//if (InFile.Contains("Exception")) {
			//  return;
			//}
			//if (InFile.Contains("Callback")) {
			//  return;
			//}
			//if (InFile.Contains("_Constructor")) {
			//  return;
			//}

			if (!(System.IO.Directory.Exists(Path.GetDirectoryName(OutFile))))
				System.IO.Directory.CreateDirectory(Path.GetDirectoryName(OutFile));

			TParsedFile Parser = new TParsedFile();
			Parser.convertFile(InFile, OutFile);

			parsedFiles.Add(Parser);
		}

		public static void convertDirectory(string InDir, string OutDir) {
			var exclude = new TStringList();
			exclude.Add("WebCore\\bindings");
			exclude.Add("WebCore\\testing");

			foreach (var excl in exclude)
				if (InDir.EndsWith(excl)) return;

			if (!(InDir.EndsWith("\\"))) {
				InDir += "\\";
			}
			if (!(OutDir.EndsWith("\\"))) {
				OutDir += "\\";
			}

			System.IO.DirectoryInfo InDirInfo = new System.IO.DirectoryInfo(InDir);
			foreach (System.IO.DirectoryInfo InDirInfo2 in InDirInfo.GetDirectories()) {
				convertDirectory(InDirInfo2.FullName, OutDir + InDirInfo2.Name);
			}

			foreach (System.IO.FileInfo file in InDirInfo.GetFiles("*.idl")) {
				convertFile(file.FullName, OutDir + file.Name.Replace(".idl", ".cs"));
			}
		}

		public static string getName(string name) {
			if (TScriptTokenizer.TokenConstHash.Contains(name.ToUpper())) {
				if (name != "this") {
					return "@" + name;
				}
			}


			var keywords = new HashSet<string>(new string[] { 
				"operator",
				"ref",
				"checked",
				"object",
				"event",
				"string",
				"continue",
				"override",
				"lock",
				"default",
			});

			if (keywords.Contains(name)) return "@" + name;

			return name;
		}

		static void addFileToCsProj(string csProjFilename, string filenameToAdd) {
			var ns = XNamespace.Get("http://schemas.microsoft.com/developer/msbuild/2003");
			var proj = XDocument.Load(csProjFilename);
			var itemGroup = proj.Root.Elements(ns + "ItemGroup").Last();
			itemGroup.Add(new XElement(ns + "Compile", new XAttribute("Include", filenameToAdd)));
			//File.Copy(csProjFilename, csProjFilename + ".bak", true);//backup
			//proj.Save(csProjFilename);
		}

	}

	public class TParsedFileList : List<TParsedFile>
	{
	}

}
