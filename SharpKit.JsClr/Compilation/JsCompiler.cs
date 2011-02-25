using System;

using SharpKit.JavaScript.Private;

namespace SharpKit.JavaScript.Compilation
{
    [JsType(JsMode.Global, Export=false)]
    class BrowserContext : JsContext
    {
        public static BrowserWindow window { get; set; }
    }
    [JsType(JsMode.Prototype, Export = false)]
    class BrowserWindow
    {
        public void setTimeout(JsAction callback, JsNumber ms)
        {
        }

        internal BrowserWindow open(string url, string p, string p_2)
        {
            throw new NotImplementedException();
        }
    }

	[JsType(GlobalObject = true, NativeOverloads = true, Filename = "~/Internal/Core.js")]
    class JsCompiler : BrowserContext
	{
		static bool Compile_FirstTime;
		[JsMethod(NativeOverloads=true, Code = @"if(target[name]===undefined)
		target[name] = source;")]
		internal static void CopyMemberIfNotDefined(object source, string name, object target)
		{
		}

		[JsMethod(NativeOverloads = true, Code = @"for(var p in source)
		target[p] = source[p];
	if(source.toString!=Object.prototype.toString && target.toString==Object.prototype.toString)
		target.toString = source.toString;")]
		internal static void _CopyObject(object source, object target)
		{

		}
		[JsMethod(NativeOverloads = true, Code = @"	for(var p in source)
	{
		if(typeof(target[p])!='undefined')
		{
			//TODO: Alon - unmark this. throw new Error(p+' is already defined on target object');
		}
		else
			target[p] = source[p];
	}
	if(source.toString!=Object.prototype.toString)
	{//TODO: commented out by dan-el
		//if(target.toString!=Object.prototype.toString)
			//throw new Error('toString is already defined on target object');
	}")]
		internal static void _SafeCopyObject(JsObject source, JsObject target)
		{
		}

		[JsMethod(NativeOverloads = true, Code = "this.name = name;")]
		static void Namespace(string name)
		{
			throw new NotImplementedException();
			//this.name = name;
		}

		static JsObject tmpTypes = new JsObject();
		internal static JsObject Types = new JsObject();
		static JsObject Namespaces = new JsObject();

		private static JsType Class(string fullname, string baseTypeName, JsObject definition, JsObject staticDefinition, JsArray interfaceNames, string assemblyName, JsArray customAttributes)
		{
			var type = new JsType();
			type.derivedTypes = new JsArray();
			type.interfaces = new JsArray();
			type.assemblyName = assemblyName;
			type.customAttributes = customAttributes ?? new JsArray();
			type.fullname = fullname;
			var index = fullname.As<JsString>().lastIndexOf(".");
			if (index == -1)
			{
				type.name = fullname;
			}
			else
			{
				type.name = fullname.As<JsString>().substring(index + 1);
				type.ns = fullname.As<JsString>().substring(0, index);
			}
			type.baseTypeName = baseTypeName;
			type.definition = definition ?? new JsObject();
			type.staticDefinition = staticDefinition ?? new JsObject();
			type.interfaceNames = interfaceNames ?? new JsArray();
			if (staticDefinition != null)
			{
				_SafeCopyObject(staticDefinition, type.definition);
			}
			tmpTypes[fullname] = type;
			return type;
		}

		private static void Interface(string fullname, string baseTypeName, JsObject definition, JsObject staticDefinition, JsArray interfaceNames)
		{
			var type = Class(fullname, baseTypeName, definition, staticDefinition, interfaceNames, null, null);
			type.isInterface = true;
		}
		[JsMethod(NativeOverloads = true, Code = @"var type = Class(fullname, 'System.MulticastDelegate', definition, null, null, null, null);
	type.isDelegate = true;
	if(type.definition.ctor==null) //no constructor
	{
		type.definition.ctor = function(obj, func){this.construct(obj, func);};
	}")]
		private static void Delegate(string fullname, JsObject definition)
		{
			throw new NotImplementedException();
		}

		private static void Struct(string fullname, JsObject definition, JsObject staticDef)
		{
			var type = Class(fullname, "System.ValueType", definition, staticDef, null, null, null);
			type.isValueType = true;
		}

		private static JsAttribute Attribute(JsType targetType, string targetMemberName, string typeName, string ctorName, JsArray positionalArguments, JsObject namedArguments)
		{
			//property, method, constructor, type, etc...
			var x = new JsObject(new
			{
				targetType = targetType,
				targetMemberName = targetMemberName,
				typeName = typeName,
				ctorName = ctorName,
				positionalArguments = positionalArguments,
				namedArguments = namedArguments
			});
			return x.As<JsAttribute>();
		}



		//TODO:
		//private static void Class2(modifiers, fullname, baseTypeNamesAndInterfaces, definition)
		//{

		//}

		//private static void Property(modifiers, propertyTypeName, name, getter, setter)
		//{
		//	
		//}
		//private static void Indexer(modifiers, propertyTypeName, name, indexTypeNames, getter, setter)
		//{
		//}
		//private static void Method(modifiers, returnTypeName, name, parameterTypeNames, definition)
		//{
		//}


		//Class("MyModel.Shooki", "System.Object",
		//[
		//	Property("public virtual", "MyModel.Contact", "Friend",
		//		private static void()
		//		{
		//		},
		//		private static void(value)
		//		{
		//		})
		//]);

		[JsMethod(NativeOverloads = true, Code = @"var type = Class(fullname, baseTypeName || 'System.Object', { ToString: function() { return this._Name; } }, definition);
type.isEnum = true;")]
		private static void Enum(string fullname, string baseTypeName, JsObject definition)
		{
			throw new NotImplementedException();
		}

		[JsMethod(NativeOverloads = true, Code = @"return this.staticDefintion[name];")]
		private static void _EnumTryParse(string name)
		{
			throw new NotImplementedException();
		}


		static JsArray AfterCompilationFunctions = new JsArray();
		static JsArray AfterCompilationCallers = new JsArray();
		private static void AfterCompilation(JsFunction func, object caller)
		{
			if (IsCompiled)
				func.call(caller);
			else
			{
				AfterCompilationFunctions.push(func);
				AfterCompilationCallers.push(caller ?? null);
			}
		}
		private static void AfterNextCompilation(JsFunction func, object caller)
		{
			AfterCompilationFunctions.push(func);
			AfterCompilationCallers.push(caller ?? null);
		}

		static JsArray BeforeCompilationFunctions = new JsArray();
		static JsArray BeforeCompilationCallers = new JsArray();
		private static void BeforeCompilation(JsFunction func, object caller)
		{
			BeforeCompilationFunctions.push(func);
			BeforeCompilationCallers.push(caller ?? null);
		}


		private static JsNamespace ResolveNamespace(string nsText)
		{
			var ns = Namespaces[nsText].As<JsNamespace>();
			if (ns == null)
			{
				var index = nsText.As<JsString>().lastIndexOf(".");
				if (index == -1)
				{
					ns = new JsNamespace(nsText);
                    window.As<JsObject>()[nsText] = ns;
				}
				else
				{
					var baseNs = ResolveNamespace(nsText.As<JsString>().substring(0, index));
					var remainder = nsText.As<JsString>().substr(index + 1);
					ns = new JsNamespace(nsText);
					baseNs[remainder] = ns;
				}
			}
			Namespaces[nsText] = ns;
			return ns;
		}

		static bool IsCompiled = false;
		[JsMethod(NativeOverloads = true, Code = @"	if (Compile_FirstTime && typeof(CodeRun_ShowCompilationProgress) == 'function')
	{
		Compile_FirstTime = false;
		Compile_Progressive(CodeRun_ShowCompilationProgress);
	}
	else
	{
		Compile_Direct();
	}")]
		public static void Compile()
		{
		}



		//var Compile_StartTime;
		private static void Compile_Progressive(JsFunction progressFunc)
		{
			//Compile_StartTime = new Date().getTime();
			Compile_Phase1();
			Compile_Phase2_Progressive_Start(progressFunc);
		}

		private static void Compile_Direct()
		{
			Compile_Phase1();
			Compile_Phase2();
			Compile_Phase3();
		}
		private static void Compile_Phase1()
		{
			for (var i = 0; i < BeforeCompilationFunctions.length; i++)
			{
				BeforeCompilationFunctions[i].As<JsFunction>().call(BeforeCompilationCallers[i]);
			}
			BeforeCompilationFunctions = new JsArray();
			BeforeCompilationCallers = new JsArray();
			foreach (var p in tmpTypes)
			{
				var tmpType = tmpTypes[p].As<JsType>();
				var type = Types[p].As<JsType>();
				if (type == null)
					Types[p] = tmpType;
				else
				{
					tmpType.isPartial = true;
					tmpType.realType = type;
				}
			}
		}

		static JsArray TmpTypeList;
		static int CurrentTmpTypeIndex;
		static JsFunction ProgressCallback;
		static int HandleItemCount;

		private static void Compile_Phase2_Progressive_Start(JsFunction progressFunc)
		{
			TmpTypeList = new JsArray();
			ProgressCallback = progressFunc;
			foreach (var p in tmpTypes)
			{
				TmpTypeList.push(tmpTypes[p]);
			}
			var count = TmpTypeList.length;
			HandleItemCount = JsMath.ceil((count / 25).As<JsNumber>()).As<int>();
			CurrentTmpTypeIndex = -1;
			Compile_Phase2_Progressive_Item();
		}

		private static void Compile_Phase2_Progressive_Item()
		{
			for (var i = 0; i < HandleItemCount; i++)
			{
				CurrentTmpTypeIndex++;
				var tmpType = TmpTypeList[CurrentTmpTypeIndex].As<JsType>();
				if (tmpType == null)
				{
					Compile_Phase2_Progressive_End();
					return;
				}
				else
				{
					Compile_Phase2_TmpType(tmpType);
				}
			}
			ProgressCallback.call(null, CurrentTmpTypeIndex + 1, TmpTypeList.length);
            window.setTimeout(Compile_Phase2_Progressive_Item, 0);
		}
		private static void Compile_Phase2_Progressive_End()
		{
			Compile_Phase3();
			//	progressFunc(3, 3);
			//	window.setTimeout(private static void(){	Compile_Phase3();	}, 0);
		}

		private static void Compile_Phase2_TmpType(JsType tmpType)
		{
			var p = tmpType.fullname;
			JsType type = null;
			tmpType = tmpTypes[p].As<JsType>();
			type = CompileType(tmpType);
			if (type != null)//.ctor  && type.ns!=null && type.ns!=""
                CopyMemberIfNotDefined(type, type.get_FullName(), window); //window[type.get_FullName()] = type;//.ctor;
			if (type.ns != null)
			{
				var ns = ResolveNamespace(type.ns);
				if (type != null)//.ctor
					ns[type.name] = type; //.ctor;
			}
		}

		private static void Compile_Phase2()
		{
			foreach (var p in tmpTypes)
			{
				Compile_Phase2_TmpType(tmpTypes[p].As<JsType>());
			}
			tmpTypes = new JsObject();
		}

		private static void Compile_Phase3()
		{
			var funcs = AfterCompilationFunctions;
			var callers = AfterCompilationCallers;
			AfterCompilationFunctions = new JsArray();
			AfterCompilationCallers = new JsArray();
			for (var i = 0; i < funcs.length; i++)
			{
				funcs[i].As<JsFunction>().call(callers[i]);
			}
			IsCompiled = true;
			//var compileTime = new Date().getTime() - Compile_StartTime;
			//	alert("compilation took "+compileTime+ "ms");
		}


		private static void ResolveBaseType(JsType type, JsType currentType)
		{
			var baseType = JsType.GetType(type.baseTypeName);
			if (baseType == null)
				baseType = JsType.GetTypeIgnoreNamespace(type.baseTypeName, true);
			if (!baseType.isCompiled)
				CompileType(baseType);
			currentType.baseType = baseType;
			baseType.derivedTypes.push(currentType);
		}

		private static void ResolveInterfaces(JsType type, JsType currentType)
		{
			if (type.interfaceNames == null)
				return;
			for (var i = 0; i < type.interfaceNames.length; i++)
			{
				var iName = type.interfaceNames[i].As<string>();
				var iface = JsType.GetType(iName);
				if (iface == null)
					iface = JsType.GetTypeIgnoreNamespace(iName, true);
				if (!iface.isCompiled)
					CompileType(iface);
				currentType.interfaces.push(iface);
			}
		}
		[JsMethod(NativeOverloads = true, Code = @"return function(){};")]
		static JsFunction CreateEmptyCtor()
		{
			throw new NotImplementedException();
		}
		[JsMethod(NativeOverloads = true, Code = @"return function(){this.construct();};")]
		static JsFunction CreateBaseCtor()
		{
			throw new NotImplementedException();
		}

		private static JsType CompileType(JsType type)
		{
			var currentType = Types[type.get_FullName()].As<JsType>() ?? type;
			if (currentType.ctors == null)
				currentType.ctors = new JsObject();
			if (!type.isCompiled)
			{
				var baseTypeResolved = false;
				if (currentType.baseType == null && currentType.baseTypeName != null)
				{
					ResolveBaseType(type, currentType);
					if (currentType.baseType != null)
						baseTypeResolved = true;
				}
				ResolveInterfaces(type, currentType);
				foreach (var p in type.definition)
				{
					if (p.As<JsString>().search("ctor") == 0) //isCtor
					{
						currentType.As<JsObject>()[p] = type.definition[p];
                        JsContext.delete(type.definition[p]);
                        if (JsContext.@typeof(currentType.commonPrototype) == "undefined")
							currentType.commonPrototype = currentType.As<JsObject>()[p].As<JsFunction>().prototype.As<JsCompilerPrototype>();
						else
							currentType.As<JsObject>()[p].As<JsFunction>().prototype = currentType.commonPrototype;
						currentType.ctors[p] = currentType.As<JsObject>()[p];
					}
				}
				//		if(currentType.ctor==null)
				//		{
				//			currentType.ctor = window[type.get_FullName()];
				//		}
				if (currentType.ctor == null)
				{
					if (currentType.ns == null || currentType.ns == "")
					{
                        var jsCtor = window.As<JsObject>()[currentType.name].As<JsFunction>();
						currentType.ctor = jsCtor;
					}
					//			currentType.ctor = type.definition[type.name];
					//			if(type.definition[type.name]!=null)
					//				delete type.definition[type.name];
					//			else
					if (currentType.ctor == null && currentType.ctors != null)
					{
						var createCtor = true;
						foreach (var p in currentType.ctors)
						{
							createCtor = false;
							break;
						}
						if (createCtor)
						{
							if (currentType.baseType != null)
								currentType.ctor = CreateBaseCtor();
							else
								currentType.ctor = CreateEmptyCtor();
						}
					}
					if (currentType.ctor != null)
					{
						currentType.ctors["ctor"] = currentType.ctor;
                        if (JsContext.@typeof(currentType.commonPrototype) == "undefined")
							currentType.commonPrototype = currentType.ctor.prototype.As<JsCompilerPrototype>();
						else
							currentType.ctor.prototype = currentType.commonPrototype;
					}
				}
				foreach (var p in currentType.ctors)
				{
					var ctor = currentType.ctors[p].As<JsCompilerFunction>();
					if (ctor._type == null)
						ctor._type = currentType;
				}
				//		if(currentType.ctor._type==null)
				//			currentType.ctor._type = currentType;
				if (baseTypeResolved)
				{
					_CopyObject(currentType.baseType.commonPrototype, currentType.commonPrototype);
				}
				foreach (var p in type.definition)
				{
					var member = type.definition[p];
					currentType.commonPrototype[p] = member;
                    if (JsContext.@typeof(member) == "function")
					{
						member.As<JsCompilerFunction>()._name = p;
						member.As<JsCompilerFunction>()._type = currentType;
					}
				}
				if (type.definition.As<JsCompilerPrototype>().toString != JsCompilerObject.prototype.toString)
				{
					currentType.commonPrototype.toString = type.definition.As<JsCompilerPrototype>().toString;
					currentType.commonPrototype.toString.name = "toString";
					currentType.commonPrototype.toString._type = currentType;
				}
				foreach (var p in type.staticDefinition)
				{
					var member = type.staticDefinition[p];
                    //TODO: if (JsContext.@typeof(currentType.As<JsObject>()[p]) != "undefined")
                    //TODO:    throw new JsError("Reserved static member name " + p).As<Exception>();
					currentType.As<JsObject>()[p] = member;
                    if (JsContext.@typeof(member) == "function")
					{
						member.As<JsCompilerFunction>()._name = p;
						member.As<JsCompilerFunction>()._type = currentType;
					}
				}
				type.isCompiled = true;
			}
			CompileEnum(currentType);
			if (currentType != type && type.customAttributes != null)
			{
				if (currentType.customAttributes != null)
				{
					for (var i = 0; i < type.customAttributes.length; i++)
					{
						currentType.customAttributes.push(type.customAttributes[i]);
					}
				}
				else
				{
					currentType.customAttributes = type.customAttributes;
				}
			}

			return currentType;
		}
		[JsMethod(NativeOverloads=true, Code = @"	if (currentType.isEnum)
	{
		currentType.tryParse = _EnumTryParse;
		for(var p in currentType.staticDefinition)
		{
			if (typeof(currentType.staticDefinition[p]) == 'string')
			{
				var x = new currentType.ctor();
				x._Name = p;
				currentType.staticDefinition[p] = x;
				currentType[p] = x;
			}
		}
	}
")]
		private static void CompileEnum(JsType currentType)
		{
		}

		[JsMethod(NativeOverloads=true, Code = "return Object.prototype.toString;")]
		private static JsFunction GetNativeToStringFunction()
		{
			throw new NotImplementedException();
		}

		static Exception __LastException;
		[JsMethod(NativeOverloads = true, Code = @"__LastException = exception || __LastException;
			var error = new Error(exception.ToString());
			error['_Exception'] = exception;
			throw error;")]
		private static void Throw(Exception exception)
		{
			
		}


		private static JsImplType Typeof(object jsTypeOrName)
		{
            if (jsTypeOrName == null)
                throw new JsError("Unknown type.").As<Exception>();
            if (JsContext.@typeof(jsTypeOrName) == "string")
				return JsImplType.GetType(jsTypeOrName.As<string>(), true);
			return JsImplType._TypeOf(jsTypeOrName.As<JsType>());
		}

		private static JsType JsTypeof(string typeName)
		{
			return JsType.GetType(typeName, false);
		}
		[JsMethod(NativeOverloads = true, Code = @"	//throw new Error('not implemented');
 //TODO:
	var type = JsType.GetType(typeName, true);
	if (args == null || args.length == 0) 
	{
		var obj = new type.ctor();
		return obj;
	}
	else 
	{
		var obj = new type.ctor.apply(null, args);
		return obj;
	}")]
		private static object New(string typeName, JsArray args)
		{
			throw new NotImplementedException();
		}

		[JsMethod(NativeOverloads = true, Code = @"	//Profiler.Data.push([2, new Date().getTime(), false, 1]);
	var ctor = type.ctor;
	var obj = new ctor();
	if(typeof(json)=='array')
	{
		//Profiler.Data.push([2, new Date().getTime(), true, 1]);
		throw new Error('not implemented');
	}
	else
	{
		for(var p in json)
		{
			var setter = obj['set_'+p];
			if(typeof(setter)=='function')
				setter.call(obj, json[p]);
			else
				obj[p] = json[p];
		}
	}
	//Profiler.Data.push([2, new Date().getTime(), true, 1]);
	return obj;")]
		private static void NewWithInitializer(JsType type, JsObject json)
		{
		}

		private static object NewAtServer(JsType type, params object[] args)
		{
            throw new NotImplementedException();
            //return RemotingServices.DefaultProxy.CreateInstance(type.assemblyName, type.get_FullName(), JsCompilerArguments.from(JsContext.arguments, 1).As<object[]>());
		}

		private static object As(object obj, string typeOrName)
		{
			if (obj == null)
				return obj;
			var type = JsType.GetType(typeOrName, true);
			if (Is(obj, type))
				return obj;
			return null;
		}
		[JsMethod(NativeOverloads = true, Code = @"	if (obj instanceof Error)
	{
		if (obj._Exception != null)
		{
			if(Is(obj._Exception, type))
				return obj._Exception;
			else
				return null;
		}
		else if (type.get_FullName() == 'System.Exception')
		{
			obj._Exception = new Exception(obj.message);
			return obj._Exception;
		}
	}
	return null;")]
		private static object TryImplicitConvert(object obj, JsType type)
		{
			throw new NotImplementedException();
		}

		private static object Cast(object obj, string typeOrName)
		{
			if (obj == null)
				return obj;
			var type = JsType.GetType(typeOrName, true);
			if (Is(obj, type))
				return obj;
			var converted = TryImplicitConvert(obj, type);
			if (converted != null)
				return converted;
            var objTypeName = JsContext.@typeof(obj);
            if (JsContext.@typeof(obj.As<JsCompilerObject>().getTypeName) == "function")
			{
				objTypeName = obj.As<JsCompilerObject2>().getTypeName();
			}
			var msg = new JsArray("InvalidCastException: Cannot cast ", objTypeName, " to ", type.get_FullName(), "Exception generated by JsRuntime").join("");
            throw new JsError(msg).As<Exception>();;
		}


		[JsMethod(GlobalCode = true, Code = @"AfterCompilation(function()
{
	JsType.GetTypeIgnoreNamespace_Cache = {};
});

if(typeof(Node)=='undefined')
{
	Node = function(){};
}
")]
		static void Global2()
		{
		}



		[JsMethod(NativeOverloads = true, Code = @"	var objType;	
	if(
			obj.constructor==null ||  //IE
			obj instanceof Node || //FireFox
			obj.constructor==HTMLImageElement || obj.constructor==HTMLInputElement ||								//IE & Firefox
			obj.constructor.name=='HTMLImageElement' || obj.constructor.name=='HTMLInputElement' 		//IE & Safari
		 )
	{
		var jsType = typeof(obj);
		var objTypeName = SharpKit.Html4.HtmlDom.GetTypeNameFromHtmlNode(obj);
		if(objTypeName==null)
			throw new Error();
		objType = JsType.GetType(objTypeName, true);
	}
	else
	{
		objType = obj.constructor._type;
	}
	return objType;
")]
		static JsType GetObjectType(object obj)
		{
			throw new NotImplementedException();
		}

		static bool _TestTypeInterfacesIs(JsType testType, JsType iface, JsObject testedInterfaces)
		{
			if (testedInterfaces[iface.name].As<bool>())
				return false;
			for (var i = 0; i < testType.interfaces.length; i++)
			{
				var testIface = testType.interfaces[i].As<JsType>();
				if (testIface == iface)
					return true;
				testedInterfaces[testIface.name] = true;
				if (_TestTypeInterfacesIs(testIface, iface, testedInterfaces))
					return true;
			}
			return false;
		}

		//checkes if the [objType] is of a certain [type]
		static bool TypeIs(JsType objType, JsType type)
		{
			if (type.isInterface)
			{
				var testedInterfaces = new JsObject();
				while (objType != null)
				{
					if (objType == type)
						return true;
					if (_TestTypeInterfacesIs(objType, type, testedInterfaces))
						return true;
					objType = objType.baseType;
				}
			}
			else
			{
				while (objType != null)
				{
					if (objType == type)
						return true;
					objType = objType.baseType;
				}
			}
			return false;
		}

		static bool Is(object obj, object typeOrName)
		{
			//Profiler.Data.push([1, new Date().getTime(), false, 1]);
			if (obj == null)
			{
				//Profiler.Data.push([1, new Date().getTime(), true, 1]);
				return false;
			}
			var type = JsType.GetType(typeOrName.As<string>(), true);
			//var type = typeCtor._type;
			if (type == null)
                throw new JsError("type expected").As<Exception>();
			var objType = GetObjectType(obj);
			var isIt = TypeIs(objType, type);
			//Profiler.Data.push([1, new Date().getTime(), true, 1]);
			return isIt;
		}

		public static object Default(object T)
		{
			//TODO:
			return null;
		}

		[JsMethod(NativeOverloads = true, Code = @"	if(obj===undefined)
		return 'undefined';
	if(obj===null)
		return 'null';
	if(obj.valueOf)
		obj = obj.valueOf();
	var type = typeof (obj);
	if (type == 'string')
		return obj;
	if (type == 'object' || type=='function')
	{
		if (obj._hashKey == null)
		{
			obj._hashKey = _hashKeyPrefix + String(_hashKeyIndex);
			_hashKeyIndex++;
		}
		return obj._hashKey;
	}
	return obj.toString();
//	if (type == 'number')
//		return obj.toString();
//	if (type == 'boolean')
//		return obj.toString();
//	throw new Error('GetHashKey not supported for object ' + obj);
")]
		public static string GetHashKey(object obj)
		{
			throw new NotImplementedException();
		}

		static int _hashKeyIndex = 0;
		static string _hashKeyPrefix = JsString.fromCharCode(1);


		//function ImportAssembliesFromWindow(win)
		//{
		//  for(var p in win.Types)
		//  {
		//    var type = win.Types[p];
		//    if(type!=null)
		//    {
		//      Types[p] = type;
		//      CopyMemberIfNotDefined(type, type.get_FullName(), window);//window[type.get_FullName()] = type;//.ctor;
		//      if(type.ns!=null)
		//      {
		//        var ns = ResolveNamespace(type.ns);
		//        if(type!=null)//.ctor
		//          ns[type.name] = type;//.ctor;
		//      }
		//    }
		//  }
		//}

		[JsMethod(GlobalCode = true, Code = @"
var __DebugClient = false;
if (typeof (appConfig) != 'undefined')
	__DebugClient = appConfig.DebugClient;

if (false)
{
	window.onerror = function(x, y, z)
	{
		var mb = [x, y, z];
		var exception = __LastException;
		if (exception != null)
		{
			mb.push(exception.ToString());
			__LastException = null;
		}
		if (__DebugClient)
		{
			mb.push('Do you wish to debug?');
			if (confirm(mb.join('\n')))
			{
				debugger;
			}
		}
		else
		{
			if (typeof (pageTracker) != 'undefined')
			{
				try
				{
					pageTracker._trackEvent('Error', 'Client', mb.join('\n'));
				} 
				catch(eee)
				{
				}
			};

			var s = 'We are sorry for the inconvenience but something went wrong.\n';
			alert(s + mb.join('\n'));
		}
		return true;
	}
}

if (typeof(MethodInstrumentationTable)=='undefined') MethodInstrumentationTable={};
MethodInstrumentationTable['1'] = { Name: 'kernel', Methods:
{
	'1': ';Is',
	'2': ';NewWithInitializer'

}};

")]
		static void Global3()
		{
		}


		//function __LoadScripts(urls, callback)
		//{
		//  var loaded = "loaded";
		//  var complete = "complete";
		//  var head = document.documentElement.children[0];
		//  var loadedScripts = 0;
		//  var urlsCount = urls.length;
		//  for (var i = 0; i < urlsCount; i++)
		//  {
		//    var url = urls[i];
		//    var script = document.createElement('script');
		//    script.src = url;
		//    script.attachEvent("onreadystatechange", function(e)
		//    {
		//      var readyState = e.srcElement.readyState;
		//      if (readyState == loaded || readyState == complete)
		//      {
		//        loadedScripts++;
		//        if (loadedScripts >= urlsCount)
		//          callback();
		//      }
		//    });
		//    head.appendChild(script);
		//  }
		//}



	}
}
