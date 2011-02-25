using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScript.Private;

using SharpKit.JavaScript;


namespace SharpKit.JavaScript.Compilation
{
	internal static class Extensions
	{
		[JsMethod(ExtensionImplementedInInstance=true)]
		public static JsArray from(this JsArguments args, int index)
		{
			throw new NotImplementedException();
		}
	}


	internal class JsCompilerFunction : JsFunction
	{
		public JsType _type;
		public string _name;
		//TODO:?[Obsolete("?")]
		public string name;
	}

	internal class JsCompilerObject2 : JsObject
	{
		public string getTypeName()
		{
			throw new NotImplementedException();
		}
	}


	internal class JsCompilerPrototype : JsObject
	{
		public new JsCompilerFunction toString;
	}
	[JsType(Name="Object", Export=false, NativeOverloads=true, NativeEnumerator=true, NativeConstructors=true)]
	internal class JsCompilerObject : JsObject
	{
		public static JsCompilerPrototype prototype;
		public new JsCompilerFunction toString;
		public JsCompilerFunction getTypeName;
	}

	[JsType(Name = "arguments", Export = false, NativeOverloads=true)]
	public class JsCompilerArguments : JsArguments
	{

		public static JsArguments from(JsArguments args, int index)
		{
			throw new NotImplementedException();
		}
	}

	/// <summary>
	/// A type used internally by the Js Type System
	/// </summary>
	[JsTypeAttribute(Name = "JsType", Native = true, NativeOverloads = true, NativeConstructors = true, Filename = "~/Internal/Core.js")]
	internal class JsType
	{
		internal JsType()
		{
			definition = null;
			staticDefinition = null;
			baseType = null;
			interfaces = null;
		}
		internal JsFunction tryParse;
		internal JsCompilerPrototype commonPrototype;
		internal bool isCompiled;
		internal JsObject ctors;
		public bool isEnum;
		public JsObject definition;
		public JsObject staticDefinition;
		public JsType baseType;
		internal JsArray customAttributes;
		internal JsArray interfaces;
		internal JsArray interfaceNames;
		internal JsImplType _ClrType;
		internal JsArray derivedTypes;
		internal string assemblyName;
		internal string fullname;
		public string name;
		internal string ns;
		internal string baseTypeName;
		//public string Name { get; set; }
		//public string FullName { get; set; }
		//public string AssemblyQualifiedName { get; set; }
		internal bool isInterface;
		internal bool isDelegate;
		internal bool isValueType;
		public static JsObject GetAllTypesByFullName()
		{
			return JsCompiler.Types;
		}

		internal bool isPartial;
		internal JsType realType;
		internal JsFunction ctor;




public static void MapType(string existingTypeName, string nonExistingTypeName)
{
	var type = JsType.GetType(existingTypeName, true);
	var nonExistingType = JsType.GetType(nonExistingTypeName);
	if(nonExistingType!=null)
		throw new JsError(nonExistingTypeName +" already exists").As<Exception>();
	JsCompiler.Types[nonExistingTypeName] = type;
    JsContext.eval(nonExistingTypeName + "=" + existingTypeName + ";");
}

public static JsType GetTypeIgnoreNamespace(string name, bool throwIfNotFound)
{
	JsType type;
	var cache = GetTypeIgnoreNamespaceCache;//arguments.callee.cache;
	if(cache!=null)
	{
		type = cache[name].As<JsType>();
        if (JsContext.@typeof(type) != "undefined")
		{
			if(throwIfNotFound && type==null)
				throw new JsError("type "+name+ " was not found with (with IgnoreNamespace).").As<Exception>();
			return type;
		}
	}
	if(name.As<JsString>().search(".")>-1)
	{
		var tokens = name.As<JsString>().split(".").As<JsArray>();
		name = tokens[tokens.length-1].As<string>();
	}
	type = JsCompiler.Types[name].As<JsType>();
	var nameAfterNs = "."+name;
	if(type==null)
	{
		foreach (var p in JsCompiler.Types)
		{
			if(p==name || p.As<JsString>().endsWith(nameAfterNs))
			{
				type = JsCompiler.Types[p].As<JsType>();
				break;
			}
		}
	}
	if(throwIfNotFound && type==null)
		throw new JsError("type "+name+ " was not found with (with IgnoreNamespace).").As<Exception>();
	if(cache!=null)
		cache[name] = type ?? null;
	return type;
}
static JsObject GetTypeIgnoreNamespaceCache = null;
internal static bool _HasTypeArguments(string typeName)
{
	return typeName.As<JsString>().indexOf("[") > -1;
}

//returns null if no args exist in name.
internal static JsArray _GetTypeWithArguments(string typeName, bool throwIfNotFound)
{
	var name = typeName;
	var gti = name.As<JsString>().indexOf("`");
	if (gti != -1 && name.As<JsString>().indexOf("[") > -1)
	{
		var args = _ParseTypeNameArgs(name);
		var type = JsType.GetType(args[0].As<string>(), throwIfNotFound);
		if (type == null)
			return null;
		var res = new object[0].As<JsArray>();
		res.push(type);
		var typeArgs = new object[0].As<JsArray>();
		for (var i = 0; i < args[1].As<JsArray>().length; i++)
		{
			var typeArg = JsType.GetType(args[1].As<JsArray>()[i].As<JsArray>()[0].As<string>(), throwIfNotFound);
			if (typeArg == null)
				return null;
			typeArgs.push(typeArg);
		}
		res.push(typeArgs);
		return res;
	}
	return null;
}
	[JsMethod(Code=@"	var code = name.replace(/, [a-zA-Z0-9, =.]+\]/g, ']'); //remove all the ', mscorlib, Version=1.0.0.0, publicKeyToken=xxxxxxxxx
	code = code.replace(/`([0-9])/g, '$$$1,'); //remove the `2 and replace to $2, (the comma is for array to compile)
	code = '[' + code + ']';
	var args = eval(code);
	return args;")]

private static JsArray _ParseTypeNameArgs(string name)
{
	throw new NotImplementedException();
	//var code = name.As<JsString>().replace(new JsRegExp("/, [a-zA-Z0-9, =.]+\\]", "g"), "]"); //remove all the ", mscorlib, Version=1.0.0.0, publicKeyToken=xxxxxxxxx
	//code = code.As<JsString>().replace(new JsRegExp("/`([0-9])", "g"), "$$$1,"); //remove the `2 and replace to $2, (the comma is for array to compile)
	//code = "[" + code + "]";
	//var args = JsScript.eval(code).As<JsArray>();
	//return args;

}
		[JsMethod(Export=false, NativeOverloads=true)]
public static JsType GetType(string typeOrName)
{
	throw new NotImplementedException();
}

		public static JsType GetType(string typeOrName, bool throwIfNotFound)
{
    if (JsContext.@typeof(typeOrName) != "string")
	{
        if (JsContext.@typeof(typeOrName) == "function")
			return typeOrName.As<JsCompilerFunction>()._type;
		return typeOrName.As<JsType>();
	}
	var name = typeOrName;
	var gti = name.As<JsString>().indexOf("`");
	if (gti != -1)
	{
		name = name.As<JsString>().substr(0, gti + 2).As<JsString>().replace("`", "$");
	}
	var type = JsCompiler.Types[name].As<JsType>();
	if (type == null)
	{
		if (throwIfNotFound)
			throw new JsError("JsType " + name + " was not found").As<Exception>();
		return null;
	}
	return type;
}

public static JsType FindType(string name, bool throwIfNotFound)
{
	var type = GetType(name, false);
	if(type==null)
		type = GetTypeIgnoreNamespace(name, throwIfNotFound);
	return type;
}

public string get_FullName()
{
	return this.fullname;
}
		string _AssemblyQualifiedName;
public string get_AssemblyQualifiedName()
{
	if (this._AssemblyQualifiedName == null)
	{
		var name = this.get_FullName();
		if (this.assemblyName != null)
			name += ", " + this.assemblyName;
		this._AssemblyQualifiedName = name;
	}
	return this._AssemblyQualifiedName;
}


public string get_Name()
{
	return this.name;
}


	}

	[JsType(Name = "Attribute", NativeConstructors = true, Export = false)]
	internal class JsAttribute
	{
		public string targetType;
		public string targetMemberName;
		public string typeName;
		public string ctorName;
		public JsExtendedArray positionalArguments;
		public JsObject namedArguments;
	}

	[JsType(Name = "Namespace", NativeConstructors = true, Export = false, NativeOverloads=true)]
	internal class JsNamespace : JsObject
	{
		public JsNamespace(string ns)
		{
		}
	}
}

