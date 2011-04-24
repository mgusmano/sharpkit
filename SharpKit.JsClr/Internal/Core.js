
var Compile_FirstTime=false;function CopyMemberIfNotDefined(source,name,target)
{if(target[name]===undefined)
target[name]=source;}
function _CopyObject(source,target)
{for(var p in source)
target[p]=source[p];if(source.toString!=Object.prototype.toString&&target.toString==Object.prototype.toString)
target.toString=source.toString;}
function _SafeCopyObject(source,target)
{for(var p in source)
{if(typeof(target[p])!='undefined')
{}
else
target[p]=source[p];}
if(source.toString!=Object.prototype.toString)
{}}
function Namespace(name)
{this.name=name;}
var tmpTypes=new Object();var Types=new Object();var Namespaces=new Object();function Class(fullname,baseTypeName,definition,staticDefinition,interfaceNames,assemblyName,customAttributes)
{var type=new JsType();type.derivedTypes=new Array();type.interfaces=new Array();type.assemblyName=assemblyName;type.customAttributes=(customAttributes!=null?customAttributes:new Array());type.fullname=fullname;var index=fullname.lastIndexOf(".");if(index==-1)
{type.name=fullname;}
else
{type.name=fullname.substring(index+1);type.ns=fullname.substring(0,index);}
type.baseTypeName=baseTypeName;type.definition=(definition!=null?definition:new Object());type.staticDefinition=(staticDefinition!=null?staticDefinition:new Object());type.interfaceNames=(interfaceNames!=null?interfaceNames:new Array());if(staticDefinition!=null)
{_SafeCopyObject(staticDefinition,type.definition);}
tmpTypes[fullname]=type;return type;}
function Interface(fullname,baseTypeName,definition,staticDefinition,interfaceNames)
{var type=Class(fullname,baseTypeName,definition,staticDefinition,interfaceNames,null,null);type.isInterface=true;}
function Delegate(fullname,definition)
{var type=Class(fullname,'System.MulticastDelegate',definition,null,null,null,null);type.isDelegate=true;if(type.definition.ctor==null)
{type.definition.ctor=function(obj,func){this.construct(obj,func);};}}
function Struct(fullname,definition,staticDef)
{var type=Class(fullname,"System.ValueType",definition,staticDef,null,null,null);type.isValueType=true;}
function Attribute(targetType,targetMemberName,typeName,ctorName,positionalArguments,namedArguments)
{var x=new Object({get_targetType:function(){return targetType;},get_targetMemberName:function(){return targetMemberName;},get_typeName:function(){return typeName;},get_ctorName:function(){return ctorName;},get_positionalArguments:function(){return positionalArguments;},get_namedArguments:function(){return namedArguments;}});return x;}
function Enum(fullname,baseTypeName,definition)
{var type=Class(fullname,baseTypeName||'System.Object',{ToString:function(){return this._Name;}},definition);type.isEnum=true;}
function _EnumTryParse(name)
{return this.staticDefintion[name];}
var AfterCompilationFunctions=new Array();var AfterCompilationCallers=new Array();function AfterCompilation(func,caller)
{if(IsCompiled)
func.call(caller);else
{AfterCompilationFunctions.push(func);AfterCompilationCallers.push((caller!=null?caller:null));}}
function AfterNextCompilation(func,caller)
{AfterCompilationFunctions.push(func);AfterCompilationCallers.push((caller!=null?caller:null));}
var BeforeCompilationFunctions=new Array();var BeforeCompilationCallers=new Array();function BeforeCompilation(func,caller)
{BeforeCompilationFunctions.push(func);BeforeCompilationCallers.push((caller!=null?caller:null));}
function ResolveNamespace(nsText)
{var ns=Namespaces[nsText];if(ns==null)
{var index=nsText.lastIndexOf(".");if(index==-1)
{ns=new Namespace(nsText);window[nsText]=ns;}
else
{var baseNs=ResolveNamespace(nsText.substring(0,index));var remainder=nsText.substr(index+1);ns=new Namespace(nsText);baseNs[remainder]=ns;}}
Namespaces[nsText]=ns;return ns;}
var IsCompiled=false;function Compile()
{if(Compile_FirstTime&&typeof(CodeRun_ShowCompilationProgress)=='function')
{Compile_FirstTime=false;Compile_Progressive(CodeRun_ShowCompilationProgress);}
else
{Compile_Direct();}}
function Compile_Progressive(progressFunc)
{Compile_Phase1();Compile_Phase2_Progressive_Start(progressFunc);}
function Compile_Direct()
{Compile_Phase1();Compile_Phase2();Compile_Phase3();}
function Compile_Phase1()
{for(var i=0;i<BeforeCompilationFunctions.length;i++)
{BeforeCompilationFunctions[i].call(BeforeCompilationCallers[i]);}
BeforeCompilationFunctions=new Array();BeforeCompilationCallers=new Array();for(var p in tmpTypes)
{var tmpType=tmpTypes[p];var type=Types[p];if(type==null)
Types[p]=tmpType;else
{tmpType.isPartial=true;tmpType.realType=type;}}}
var TmpTypeList;var CurrentTmpTypeIndex=0;var ProgressCallback;var HandleItemCount=0;function Compile_Phase2_Progressive_Start(progressFunc)
{TmpTypeList=new Array();ProgressCallback=progressFunc;for(var p in tmpTypes)
{TmpTypeList.push(tmpTypes[p]);}
var count=TmpTypeList.length;HandleItemCount=Math.ceil((((count/25)|0)));CurrentTmpTypeIndex=-1;Compile_Phase2_Progressive_Item();}
function Compile_Phase2_Progressive_Item()
{for(var i=0;i<HandleItemCount;i++)
{CurrentTmpTypeIndex++;var tmpType=TmpTypeList[CurrentTmpTypeIndex];if(tmpType==null)
{Compile_Phase2_Progressive_End();return;}
else
{Compile_Phase2_TmpType(tmpType);}}
ProgressCallback.call(null,CurrentTmpTypeIndex+1,TmpTypeList.length);window.setTimeout(Compile_Phase2_Progressive_Item,0);}
function Compile_Phase2_Progressive_End()
{Compile_Phase3();}
function Compile_Phase2_TmpType(tmpType)
{var p=tmpType.fullname;var type=null;tmpType=tmpTypes[p];type=CompileType(tmpType);if(type!=null)
CopyMemberIfNotDefined(type,type.get_FullName(),window);if(type.ns!=null)
{var ns=ResolveNamespace(type.ns);if(type!=null)
ns[type.name]=type;}}
function Compile_Phase2()
{for(var p in tmpTypes)
{Compile_Phase2_TmpType(tmpTypes[p]);}
tmpTypes=new Object();}
function Compile_Phase3()
{var funcs=AfterCompilationFunctions;var callers=AfterCompilationCallers;AfterCompilationFunctions=new Array();AfterCompilationCallers=new Array();for(var i=0;i<funcs.length;i++)
{funcs[i].call(callers[i]);}
IsCompiled=true;}
function ResolveBaseType(type,currentType)
{var baseType=JsType.GetType(type.baseTypeName);if(baseType==null)
baseType=JsType.GetTypeIgnoreNamespace(type.baseTypeName,true);if(!baseType.isCompiled)
CompileType(baseType);currentType.baseType=baseType;baseType.derivedTypes.push(currentType);}
function ResolveInterfaces(type,currentType)
{if(type.interfaceNames==null)
return;for(var i=0;i<type.interfaceNames.length;i++)
{var iName=type.interfaceNames[i];var iface=JsType.GetType(iName);if(iface==null)
iface=JsType.GetTypeIgnoreNamespace(iName,true);if(!iface.isCompiled)
CompileType(iface);currentType.interfaces.push(iface);}}
function CreateEmptyCtor()
{return function(){};}
function CreateBaseCtor()
{return function(){this.construct();};}
function CompileType(type)
{var currentType=(Types[type.get_FullName()]!=null?Types[type.get_FullName()]:type);if(currentType.ctors==null)
currentType.ctors=new Object();if(!type.isCompiled)
{var baseTypeResolved=false;if(currentType.baseType==null&&currentType.baseTypeName!=null)
{ResolveBaseType(type,currentType);if(currentType.baseType!=null)
baseTypeResolved=true;}
ResolveInterfaces(type,currentType);for(var p in type.definition)
{if(p.search("ctor")==0)
{currentType[p]=type.definition[p];delete(type.definition[p]);if(typeof(currentType.commonPrototype)=="undefined")
currentType.commonPrototype=currentType[p].prototype;else
currentType[p].prototype=currentType.commonPrototype;currentType.ctors[p]=currentType[p];}}
if(currentType.ctor==null)
{if(currentType.ns==null||currentType.ns=="")
{var jsCtor=window[currentType.name];currentType.ctor=jsCtor;}
if(currentType.ctor==null&&currentType.ctors!=null)
{var createCtor=true;for(var p in currentType.ctors)
{createCtor=false;break;}
if(createCtor)
{if(currentType.baseType!=null)
currentType.ctor=CreateBaseCtor();else
currentType.ctor=CreateEmptyCtor();}}
if(currentType.ctor!=null)
{currentType.ctors["ctor"]=currentType.ctor;if(typeof(currentType.commonPrototype)=="undefined")
currentType.commonPrototype=currentType.ctor.prototype;else
currentType.ctor.prototype=currentType.commonPrototype;}}
for(var p in currentType.ctors)
{var ctor=currentType.ctors[p];if(ctor._type==null)
ctor._type=currentType;}
if(baseTypeResolved)
{_CopyObject(currentType.baseType.commonPrototype,currentType.commonPrototype);}
for(var p in type.definition)
{var member=type.definition[p];currentType.commonPrototype[p]=member;if(typeof(member)=="function")
{member._name=p;member._type=currentType;}}
if(type.definition.toString!=Object.prototype.toString)
{currentType.commonPrototype.toString=type.definition.toString;currentType.commonPrototype.toString.name="toString";currentType.commonPrototype.toString._type=currentType;}
for(var p in type.staticDefinition)
{var member=type.staticDefinition[p];currentType[p]=member;if(typeof(member)=="function")
{member._name=p;member._type=currentType;}}
type.isCompiled=true;}
CompileEnum(currentType);if(currentType!=type&&type.customAttributes!=null)
{if(currentType.customAttributes!=null)
{for(var i=0;i<type.customAttributes.length;i++)
{currentType.customAttributes.push(type.customAttributes[i]);}}
else
{currentType.customAttributes=type.customAttributes;}}
return currentType;}
function CompileEnum(currentType)
{if(currentType.isEnum)
{currentType.tryParse=_EnumTryParse;for(var p in currentType.staticDefinition)
{if(typeof(currentType.staticDefinition[p])=='string')
{var x=new currentType.ctor();x._Name=p;currentType.staticDefinition[p]=x;currentType[p]=x;}}}}
function GetNativeToStringFunction()
{return Object.prototype.toString;}
var __LastException;function Throw(exception)
{__LastException=exception||__LastException;var error=new Error(exception.ToString());error['_Exception']=exception;throw error;}
function Typeof(jsTypeOrName)
{if(jsTypeOrName==null)
throw new Error("Unknown type.");if(typeof(jsTypeOrName)=="string")
return System.Type.GetType$$String$$Boolean(jsTypeOrName,true);return System.Type._TypeOf(jsTypeOrName);}
function JsTypeof(typeName)
{return JsType.GetType(typeName,false);}
function New(typeName,args)
{var type=JsType.GetType(typeName,true);if(args==null||args.length==0)
{var obj=new type.ctor();return obj;}
else
{var obj=new type.ctor.apply(null,args);return obj;}}
function NewWithInitializer(type,json)
{var ctor=type.ctor;var obj=new ctor();if(typeof(json)=='array')
{throw new Error('not implemented');}
else
{for(var p in json)
{var setter=obj['set_'+p];if(typeof(setter)=='function')
setter.call(obj,json[p]);else
obj[p]=json[p];}}
return obj;}
function NewAtServer(type,args)
{throw new System.NotImplementedException.ctor();}
function As(obj,typeOrName)
{if(obj==null)
return obj;var type=JsType.GetType(typeOrName,true);if(Is(obj,type))
return obj;return null;}
function TryImplicitConvert(obj,type)
{if(obj instanceof Error)
{if(obj._Exception!=null)
{if(Is(obj._Exception,type))
return obj._Exception;else
return null;}
else if(type.get_FullName()=='System.Exception')
{obj._Exception=new Exception(obj.message);return obj._Exception;}}
return null;}
function Cast(obj,typeOrName)
{if(obj==null)
return obj;var type=JsType.GetType(typeOrName,true);if(Is(obj,type))
return obj;var converted=TryImplicitConvert(obj,type);if(converted!=null)
return converted;var objTypeName=typeof(obj);if(typeof(obj.getTypeName)=="function")
{objTypeName=obj.getTypeName();}
var msg=new Array("InvalidCastException: Cannot cast ",objTypeName," to ",type.get_FullName(),"Exception generated by JsRuntime").join("");throw new Error(msg);}
AfterCompilation(function()
{JsType.GetTypeIgnoreNamespace_Cache={};});if(typeof(Node)=='undefined')
{Node=function(){};}
function GetObjectType(obj)
{var objType;if(obj.constructor==null||obj instanceof Node||obj.constructor==HTMLImageElement||obj.constructor==HTMLInputElement||obj.constructor.name=='HTMLImageElement'||obj.constructor.name=='HTMLInputElement')
{var jsType=typeof(obj);var objTypeName=SharpKit.Html4.HtmlDom.GetTypeNameFromHtmlNode(obj);if(objTypeName==null)
throw new Error();objType=JsType.GetType(objTypeName,true);}
else
{objType=obj.constructor._type;}
return objType;}
function _TestTypeInterfacesIs(testType,iface,testedInterfaces)
{if(testedInterfaces[iface.name])
return false;for(var i=0;i<testType.interfaces.length;i++)
{var testIface=testType.interfaces[i];if(testIface==iface)
return true;testedInterfaces[testIface.name]=true;if(_TestTypeInterfacesIs(testIface,iface,testedInterfaces))
return true;}
return false;}
function TypeIs(objType,type)
{if(type.isInterface)
{var testedInterfaces=new Object();while(objType!=null)
{if(objType==type)
return true;if(_TestTypeInterfacesIs(objType,type,testedInterfaces))
return true;objType=objType.baseType;}}
else
{while(objType!=null)
{if(objType==type)
return true;objType=objType.baseType;}}
return false;}
function Is(obj,typeOrName)
{if(obj==null)
{return false;}
var type=JsType.GetType(typeOrName,true);if(type==null)
throw new Error("type expected");var objType=GetObjectType(obj);var isIt=TypeIs(objType,type);return isIt;}
function Default(T)
{return null;}
function GetHashKey(obj)
{if(obj===undefined)
return'undefined';if(obj===null)
return'null';if(obj.valueOf)
obj=obj.valueOf();var type=typeof(obj);if(type=='string')
return obj;if(type=='object'||type=='function')
{if(obj._hashKey==null)
{obj._hashKey=_hashKeyPrefix+String(_hashKeyIndex);_hashKeyIndex++;}
return obj._hashKey;}
return obj.toString();}
var _hashKeyIndex=0;var _hashKeyPrefix=String.fromCharCode(1);var __DebugClient=false;if(typeof(appConfig)!='undefined')
__DebugClient=appConfig.DebugClient;if(false)
{window.onerror=function(x,y,z)
{var mb=[x,y,z];var exception=__LastException;if(exception!=null)
{mb.push(exception.ToString());__LastException=null;}
if(__DebugClient)
{mb.push('Do you wish to debug?');if(confirm(mb.join('\n')))
{debugger;}}
else
{if(typeof(pageTracker)!='undefined')
{try
{pageTracker._trackEvent('Error','Client',mb.join('\n'));}
catch(eee)
{}};var s='We are sorry for the inconvenience but something went wrong.\n';alert(s+mb.join('\n'));}
return true;}}
if(typeof(MethodInstrumentationTable)=='undefined')MethodInstrumentationTable={};MethodInstrumentationTable['1']={Name:'kernel',Methods:{'1':';Is','2':';NewWithInitializer'}};JsType=function()
{this.definition=null;this.staticDefinition=null;this.baseType=null;this.interfaces=null;}
JsType.prototype.isCompiled=false;JsType.prototype.isEnum=false;JsType.prototype.isInterface=false;JsType.prototype.isDelegate=false;JsType.prototype.isValueType=false;JsType.GetAllTypesByFullName=function()
{return Types;}
JsType.prototype.isPartial=false;JsType.MapType=function(existingTypeName,nonExistingTypeName)
{var type=JsType.GetType(existingTypeName,true);var nonExistingType=JsType.GetType(nonExistingTypeName);if(nonExistingType!=null)
throw new Error(nonExistingTypeName+" already exists");Types[nonExistingTypeName]=type;eval(nonExistingTypeName+"="+existingTypeName+";");}
JsType.GetTypeIgnoreNamespace=function(name,throwIfNotFound)
{var type;var cache=JsType.GetTypeIgnoreNamespaceCache;if(cache!=null)
{type=cache[name];if(typeof(type)!="undefined")
{if(throwIfNotFound&&type==null)
throw new Error("type "+name+" was not found with (with IgnoreNamespace).");return type;}}
if(name.search(".")>-1)
{var tokens=name.split(".");name=tokens[tokens.length-1];}
type=Types[name];var nameAfterNs="."+name;if(type==null)
{for(var p in Types)
{if(p==name||p.endsWith(nameAfterNs))
{type=Types[p];break;}}}
if(throwIfNotFound&&type==null)
throw new Error("type "+name+" was not found with (with IgnoreNamespace).");if(cache!=null)
cache[name]=(type!=null?type:null);return type;}
JsType.GetTypeIgnoreNamespaceCache=null;JsType._HasTypeArguments=function(typeName)
{return typeName.indexOf("[")>-1;}
JsType._GetTypeWithArguments=function(typeName,throwIfNotFound)
{var name=typeName;var gti=name.indexOf("`");if(gti!=-1&&name.indexOf("[")>-1)
{var args=JsType._ParseTypeNameArgs(name);var type=JsType.GetType(args[0],throwIfNotFound);if(type==null)
return null;var res=[];res.push(type);var typeArgs=[];for(var i=0;i<args[1].length;i++)
{var typeArg=JsType.GetType(args[1][i][0],throwIfNotFound);if(typeArg==null)
return null;typeArgs.push(typeArg);}
res.push(typeArgs);return res;}
return null;}
JsType._ParseTypeNameArgs=function(name)
{var code=name.replace(/, [a-zA-Z0-9, =.]+\]/g,']');code=code.replace(/`([0-9])/g,'$$$1,');code='['+code+']';var args=eval(code);return args;}
JsType.GetType=function(typeOrName,throwIfNotFound)
{if(typeof(typeOrName)!="string")
{if(typeof(typeOrName)=="function")
return typeOrName._type;return typeOrName;}
var name=typeOrName;var gti=name.indexOf("`");if(gti!=-1)
{name=name.substr(0,gti+2).replace("`","$");}
var type=Types[name];if(type==null)
{if(throwIfNotFound)
throw new Error("JsType "+name+" was not found");return null;}
return type;}
JsType.FindType=function(name,throwIfNotFound)
{var type=JsType.GetType(name,false);if(type==null)
type=JsType.GetTypeIgnoreNamespace(name,throwIfNotFound);return type;}
JsType.prototype.get_FullName=function()
{return this.fullname;}
JsType.prototype.get_AssemblyQualifiedName=function()
{if(this._AssemblyQualifiedName==null)
{var name=this.get_FullName();if(this.assemblyName!=null)
name+=", "+this.assemblyName;this._AssemblyQualifiedName=name;}
return this._AssemblyQualifiedName;}
JsType.prototype.get_Name=function()
{return this.name;}
typeHelper=function()
{}
typeHelper.getTypeName=function(value)
{var typeName=typeof(value);if(typeName!='object')
return typeName;if(value instanceof Date)
return'date';throw new Error('unknown type');}
Class("System.Activator","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{CreateInstance:function(type)
{return new type._JsType.ctor();}},null,"SharpKit.JsClr",[]);Class("System.Attribute","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{},null,"SharpKit.JsClr",[]);Interface("System.Collections.Generic.IEnumerator$1","System.Object",null,"SharpKit.JsClr",[]);Interface("System.Collections.IEnumerator","System.Object",null,"SharpKit.JsClr",[]);Interface("System.Collections.Generic.IEnumerable$1","System.Object",["System.Collections.IEnumerable"],"SharpKit.JsClr",[]);Interface("System.Collections.IEnumerable","System.Object",null,"SharpKit.JsClr",[]);Interface("System.Collections.Generic.IList$1","System.Object",["System.Collections.Generic.ICollection$1"],"SharpKit.JsClr",[]);Interface("System.Collections.IList","System.Object",["System.Collections.ICollection"],"SharpKit.JsClr",[]);Interface("System.Collections.Generic.ICollection$1","System.Object",["System.Collections.Generic.IEnumerable$1"],"SharpKit.JsClr",[]);Interface("System.Collections.ICollection","System.Object",["System.Collections.IEnumerable"],"SharpKit.JsClr",[]);Interface("System.Collections.Generic.IDictionary$2","System.Object",null,"SharpKit.JsClr",[]);Interface("System.Collections.IDictionary","System.Object",["System.Collections.ICollection","System.Collections.IEnumerable"],"SharpKit.JsClr",[]);Delegate("System.Comparison$1",{ctor:function(T,obj,func)
{this.T=T;System.MulticastDelegate.ctor.call(this,obj,func);}});Delegate("System.ComponentModel.CancelEventHandler",{ctor:function(obj,func)
{System.MulticastDelegate.ctor.call(this,obj,func);}});Class("System.ComponentModel.CancelEventArgs","System.EventArgs",{ctor:function()
{this._Cancel=false;System.EventArgs.ctor.call(this);this._Cancel=false;},ctor$$Boolean:function(cancel)
{this._Cancel=false;System.EventArgs.ctor.call(this);this._Cancel=cancel;},Cancel$$:"System.Boolean",get_Cancel:function()
{return this._Cancel;},set_Cancel:function(value)
{this._Cancel=value;}},{},null,"SharpKit.JsClr",[]);Interface("System.ComponentModel.INotifyPropertyChanging","System.Object",null,"SharpKit.JsClr",[]);Interface("System.ComponentModel.INotifyPropertyChanged","System.Object",null,"SharpKit.JsClr",[]);Delegate("System.ComponentModel.PropertyChangedEventHandler",{ctor:function(obj,func)
{System.MulticastDelegate.ctor.call(this,obj,func);}});Class("System.ComponentModel.PropertyChangedEventArgs","System.EventArgs",{ctor:function(propertyName)
{System.EventArgs.ctor.call(this);this._PropertyName=propertyName;},PropertyName$$:"System.String",get_PropertyName:function()
{return this._PropertyName;}},{},null,"SharpKit.JsClr",[]);Class("System.DateTime","System.Object",{ctor:function()
{this.MinValue=null;System.Object.ctor.call(this);if(arguments.length==3)
System.DateTime.ctor$$Int32$$Int32$$Int32.apply(this,arguments);else if(arguments.length==6)
System.DateTime.ctor$$Int32$$Int32$$Int32$$Int32$$Int32$$Int32.apply(this,arguments);else
this.date=System.DateTime.MinValue.date;},ctor$$Int32$$Int32$$Int32:function(year,month,day)
{this.MinValue=null;System.Object.ctor.call(this);this.date=new Date();this.set_Year(year);this.set_Month(month);this.set_Day(day);},ctor$$Int32$$Int32$$Int32$$Int32$$Int32$$Int32:function(year,month,day,hour,minute,second)
{this.MinValue=null;System.Object.ctor.call(this);this.date=new Date();this.set_Year(year);this.set_Month(month);this.set_Day(day);this.set_Hour(hour);this.set_Minute(minute);this.set_Second(second);},ctor$$Date:function(jsDate)
{this.MinValue=null;System.Object.ctor.call(this);if(jsDate!=null)
this.date=jsDate;else
this.date=System.DateTime.MinValue.date;},Year$$:"System.Int32",get_Year:function()
{return this.date.getFullYear();},set_Year:function(value)
{this.date.setFullYear(value);},Month$$:"System.Int32",get_Month:function()
{return this.date.getMonth()+1;},set_Month:function(value)
{this.date.setMonth(value-1);},Day$$:"System.Int32",get_Day:function()
{return this.date.getDate();},set_Day:function(value)
{this.date.setDate(value);},Hour$$:"System.Int32",get_Hour:function()
{return this.date.getHours();},set_Hour:function(value)
{this.date.setHours(value);},Minute$$:"System.Int32",get_Minute:function()
{return this.date.getMinutes();},set_Minute:function(value)
{this.date.setMinutes(value);},Second$$:"System.Int32",get_Second:function()
{return this.date.getSeconds();},set_Second:function(value)
{this.date.setSeconds(value);},Millisecond$$:"System.Int32",get_Millisecond:function()
{return this.date.getMilliseconds();},set_Millisecond:function(value)
{this.date.setMilliseconds(value);},DayOfWeek$$:"System.Int32",get_DayOfWeek:function()
{return this.date.getDay();},Today$$:"SharpKit.JavaScript.Private.JsImplDateTime",get_Today:function()
{return new System.DateTime.ctor$$Date(SharpKit.JavaScript.Private.Extensions.removeTime(new Date()));},ToJsDate:function()
{return this.date;},CompareTo:function(value)
{return this.date.valueOf()-value.date.valueOf();},ToString:function()
{return this.date.toString();},ToString$$String:function(format)
{format=format.Replace$$String$$String("yyyy",this.get_Year().ToString$$String("0000"));format=format.Replace$$String$$String("yyyy",this.get_Year().ToString$$String("00"));format=format.Replace$$String$$String("y",this.get_Year().ToString());format=format.Replace$$String$$String("MM",this.get_Month().ToString$$String("00"));format=format.Replace$$String$$String("M",this.get_Month().ToString());format=format.Replace$$String$$String("dd",this.get_Day().ToString$$String("00"));format=format.Replace$$String$$String("d",this.get_Day().ToString());format=format.Replace$$String$$String("HH",this.get_Hour().ToString$$String("00"));format=format.Replace$$String$$String("H",this.get_Hour().ToString());format=format.Replace$$String$$String("mm",this.get_Minute().ToString$$String("00"));format=format.Replace$$String$$String("m",this.get_Minute().ToString());format=format.Replace$$String$$String("ss",this.get_Second().ToString$$String("00"));format=format.Replace$$String$$String("s",this.get_Second().ToString());return format;},AddDays:function(days)
{return new System.DateTime.ctor$$Date(SharpKit.JavaScript.Private.Extensions.addDays(this.date,days));},AddMonths:function(months)
{return new System.DateTime.ctor$$Date(SharpKit.JavaScript.Private.Extensions.addMonths(this.date,months));}},{Now$$:"SharpKit.JavaScript.Private.JsImplDateTime",get_Now:function()
{return new System.DateTime.ctor$$Date(new Date());},DaysInMonth:function(year,month)
{return 32-new Date(year,month-1,32).getDate();},Compare:function(t1,t2)
{return t1.date.valueOf()-t2.date.valueOf();}},null,"SharpKit.JsClr",[]);Class("SharpKit.JavaScript.Private.Extensions","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{addDays:function(date,days)
{var date2=new Date(date.valueOf());date2.setDate(date2.getDate()+days);return date2;},addMonths:function(date,months)
{var date2=new Date(date.valueOf());date2.setMonth(date2.getMonth()+months);return date2;},removeTime:function(date)
{var date2=new Date(date.getFullYear(),date.getMonth(),date.getDate());return date2;}},null,"SharpKit.JsClr",[]);Class("System.Delegate","System.Object",{ctor:function()
{System.Object.ctor.call(this);},DynamicInvoke:function(args)
{throw new System.Exception.ctor$$String("DynamicInvoke is available only on MulticastDelegates");}},{Combine$$Delegate$$Delegate:function(delegate1,delegate2)
{if(delegate1==null)
return delegate2;if(delegate1._IsSealed)
delegate1=delegate1.Clone();delegate1._Add(delegate2);return delegate1;},Combine$$Object:function(obj)
{throw new System.NotImplementedException.ctor();},Remove:function(delegate1,delegate2)
{if(delegate1==null)
return null;if(delegate1.Equals$$MulticastDelegate(delegate2))
return null;if(delegate1._IsSealed)
delegate1=delegate1.Clone();delegate1._Remove(delegate2);return delegate1;}},null,"SharpKit.JsClr",[]);Class("System.MulticastDelegate","System.Delegate",{ctor:function(obj2,func2)
{this._IsSealed=false;System.Delegate.ctor.call(this);if(func2==null)
throw new System.Exception.ctor$$String("ArgumentNullException - func");this.obj=obj2;this.func=func2;},_ToJsFunction:function()
{if(this.delegates!=null)
throw new System.Exception.ctor$$String("Not Implemented");if(this._jsFunc==null)
{this._jsFunc=VM.GetDelegate(this.obj,this.func);}
return this._jsFunc;},GetInvocationList:function()
{var ar=this.delegates.Clone();ar.insert(0,new System.MulticastDelegate.ctor(this.obj,this.func));return ar;},Clone:function()
{var x=new this.constructor(this.obj,this.func);if(this.delegates!=null)
x.delegates=this.delegates.concat();return x;},GetHashCode:function()
{return System.Object.commonPrototype.GetHashCode.call(this);},Equals$$Object:function(obj)
{if(Is(obj,System.MulticastDelegate))
return this.Equals$$MulticastDelegate(obj);return false;},Equals$$MulticastDelegate:function(del)
{if(del==null)
return false;if(this==del)
return true;if(this.obj==del.obj&&this.func==del.func)
{if((this.delegates==null||this.delegates.length==0))
return del.delegates==null||del.delegates.length==0;if(del.delegates==null||del.delegates.length==0)
return false;if(this.delegates.length!=del.delegates.length)
return false;for(var i=0;i<this.delegates.length;i++)
{if(!this.delegates[i].Equals$$Object(del.delegates[i]))
return false;}
return true;}
return false;},_Add:function(del)
{if(this._jsFunc!=null)
throw new System.Exception.ctor$$String("Cannot change delegate - jsfunc already created");if(this.delegates==null)
this.delegates=new Array();this.delegates.push(del);},_Remove:function(del)
{if(this.delegates!=null)
{for(var i=0;i<this.delegates.length;i++)
{var del2=this.delegates[i];if(del.Equals$$MulticastDelegate(del2))
{this.delegates.RemoveAt(i);return;}}}},Invoke:function(varargs)
{var restoreIsSealed=false;if(!this._IsSealed)
{this._IsSealed=true;restoreIsSealed=true;}
var res=this.func.apply(this.obj,arguments);if(this.delegates!=null)
{var length=this.delegates.length;if(length>0)
{for(var i=0;i<length;i++)
{var del=this.delegates[i];res=del.Invoke.apply(del,arguments);}}}
if(restoreIsSealed)
this._IsSealed=false;return res;},DynamicInvoke:function(args)
{return this.Invoke.apply(this,arguments);}},{},null,"SharpKit.JsClr",[]);Delegate("System.Action",{ctor:function(obj,func)
{System.MulticastDelegate.ctor.call(this,obj,func);}});Delegate("System.Action$1",{ctor:function(T,obj,func)
{this.T=T;System.MulticastDelegate.ctor.call(this,obj,func);}});Delegate("System.Action$2",{ctor:function(T1,T2,obj,func)
{this.T1=T1;this.T2=T2;System.MulticastDelegate.ctor.call(this,obj,func);}});Delegate("System.Action$3",{ctor:function(T1,T2,T3,obj,func)
{this.T1=T1;this.T2=T2;this.T3=T3;System.MulticastDelegate.ctor.call(this,obj,func);}});Delegate("System.Func$1",{ctor:function(TResult,obj,func)
{this.TResult=TResult;System.MulticastDelegate.ctor.call(this,obj,func);}});Delegate("System.Func$2",{ctor:function(T,TResult,obj,func)
{this.T=T;this.TResult=TResult;System.MulticastDelegate.ctor.call(this,obj,func);}});Delegate("System.Func$3",{ctor:function(T1,T2,TResult,obj,func)
{this.T1=T1;this.T2=T2;this.TResult=TResult;System.MulticastDelegate.ctor.call(this,obj,func);}});Delegate("System.Func$4",{ctor:function(T1,T2,T3,TResult,obj,func)
{this.T1=T1;this.T2=T2;this.T3=T3;this.TResult=TResult;System.MulticastDelegate.ctor.call(this,obj,func);}});Delegate("System.EventHandler",{ctor:function(obj,func)
{System.MulticastDelegate.ctor.call(this,obj,func);}});Delegate("System.EventHandler$1",{ctor:function(TEventArgs,obj,func)
{this.TEventArgs=TEventArgs;System.MulticastDelegate.ctor.call(this,obj,func);}});Delegate("System.Predicate$1",{ctor:function(T,obj,func)
{this.T=T;System.MulticastDelegate.ctor.call(this,obj,func);}});Class("System.Enum","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{GetNames:function(type)
{var jsType=type._JsType;var array=new Array();for(var p in jsType.staticDefinition)
{array.push(p);}
return array;},GetValues:function(type)
{var jsType=type._JsType;var array=new Array();for(var p in jsType.staticDefinition)
{array.push(jsType.staticDefinition[p]);}
return array;}},null,"SharpKit.JsClr",[]);Class("System.Environment","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{GetResourceString:function(p)
{return p;}},null,"SharpKit.JsClr",[]);Class("System.EventArgs","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{},null,"SharpKit.JsClr",[]);Class("System.Exception","System.Object",{ctor$$String$$Exception:function(message,innerException)
{System.Object.ctor.call(this);this._Message=message;this._InnerException=innerException;},ctor$$String:function(message)
{System.Object.ctor.call(this);this._Message=message;},ctor:function()
{System.Object.ctor.call(this);},InnerException$$:"System.Exception",get_InnerException:function()
{return this._InnerException;},Message$$:"System.String",get_Message:function()
{return this._Message;},ToString:function()
{var ie=this.get_InnerException();if(ie==null)
return this.get_Message();return this.get_Message()+", "+this.get_InnerException();},SetErrorCode:function(hr)
{}},{},null,"SharpKit.JsClr",[]);Class("System.NotImplementedException","System.Exception",{ctor:function()
{System.Exception.ctor$$String.call(this,"NotImplementedException");},ctor$$String:function(s)
{System.Exception.ctor$$String.call(this,"NotImplementedException: "+s);}},{},null,"SharpKit.JsClr",[]);Class("System.SystemException","System.Exception",{ctor:function()
{System.Exception.ctor$$String.call(this,System.Environment.GetResourceString("Arg_SystemException"));System.Exception.commonPrototype.SetErrorCode.call(this,-2146233087);},ctor$$String:function(message)
{System.Exception.ctor$$String.call(this,message);System.Exception.commonPrototype.SetErrorCode.call(this,-2146233087);},ctor$$String$$Exception:function(message,innerException)
{System.Exception.ctor$$String$$Exception.call(this,message,innerException);System.Exception.commonPrototype.SetErrorCode.call(this,-2146233087);}},{},null,"SharpKit.JsClr",[]);Class("System.ArgumentException","System.SystemException",{ctor:function()
{System.SystemException.ctor$$String.call(this,System.Environment.GetResourceString("Arg_ArgumentException"));System.Exception.commonPrototype.SetErrorCode.call(this,-2147024809);},ctor$$String:function(message)
{System.SystemException.ctor$$String.call(this,message);System.Exception.commonPrototype.SetErrorCode.call(this,-2147024809);},ctor$$String$$Exception:function(message,innerException)
{System.SystemException.ctor$$String$$Exception.call(this,message,innerException);},ctor$$String$$String:function(message,paramName)
{System.SystemException.ctor$$String.call(this,message);this.m_paramName=paramName;System.Exception.commonPrototype.SetErrorCode.call(this,-2147024809);},ctor$$String$$String$$Exception:function(message,paramName,innerException)
{System.SystemException.ctor$$String$$Exception.call(this,message,innerException);this.m_paramName=paramName;System.Exception.commonPrototype.SetErrorCode.call(this,-2147024809);},ParamName$$:"System.String",get_ParamName:function()
{return this.m_paramName;}},{},null,"SharpKit.JsClr",[]);Class("System.NullReferenceException","System.SystemException",{ctor:function()
{System.SystemException.ctor$$String.call(this,"Object reference not set to an instance of object");},ctor$$String:function(message)
{System.SystemException.ctor$$String.call(this,message);}},{},null,"SharpKit.JsClr",[]);Class("System.NotSupportedException","System.SystemException",{ctor:function()
{System.SystemException.ctor$$String.call(this,"Arg_NotSupportedException");},ctor$$String:function(message)
{System.SystemException.ctor$$String.call(this,message);},ctor$$String$$Exception:function(message,innerException)
{System.SystemException.ctor$$String$$Exception.call(this,message,innerException);}},{},null,"SharpKit.JsClr",[]);Class("System.ArgumentOutOfRangeException","System.ArgumentException",{ctor:function()
{System.ArgumentException.ctor$$String.call(this,"Arg_ArgumentOutOfRangeException");System.Exception.commonPrototype.SetErrorCode.call(this,-2146233086);},ctor$$String:function(paramName)
{System.ArgumentException.ctor$$String$$String.call(this,"Arg_ArgumentOutOfRangeException",paramName);System.Exception.commonPrototype.SetErrorCode.call(this,-2146233086);},ctor$$String$$Exception:function(message,innerException)
{System.ArgumentException.ctor$$String$$Exception.call(this,message,innerException);System.Exception.commonPrototype.SetErrorCode.call(this,-2146233086);},ctor$$String$$String:function(paramName,message)
{System.ArgumentException.ctor$$String$$String.call(this,message,paramName);System.Exception.commonPrototype.SetErrorCode.call(this,-2146233086);},ctor$$String$$Object$$String:function(paramName,actualValue,message)
{System.ArgumentException.ctor$$String$$String.call(this,message,paramName);this.m_actualValue=actualValue;System.Exception.commonPrototype.SetErrorCode.call(this,-2146233086);},ActualValue$$:"System.Object",get_ActualValue:function()
{return this.m_actualValue;},RangeMessage$$:"System.String",get_RangeMessage:function()
{if(System.ArgumentOutOfRangeException._rangeMessage==null)
{System.ArgumentOutOfRangeException._rangeMessage="Arg_ArgumentOutOfRangeException";}
return System.ArgumentOutOfRangeException._rangeMessage;}},{},null,"SharpKit.JsClr",[]);Interface("System.IDisposable","System.Object",null,"SharpKit.JsClr",[]);Class("System.Nullable$1","System.Object",{ctor:function(T,value)
{this.T=T;this.hasValue=false;System.Object.ctor.call(this);this.value=value;this.hasValue=true;},HasValue$$:"System.Boolean",get_HasValue:function()
{return this.hasValue;},Value$$:"T",get_Value:function()
{if(!this.get_HasValue())
{throw new System.InvalidOperationException.ctor$$String("InvalidOperation_NoValue");}
return this.value;},GetValueOrDefault:function()
{return this.value;},GetValueOrDefault$$T:function(defaultValue)
{if(!this.get_HasValue())
{return defaultValue;}
return this.value;},Equals$$Object:function(other)
{if(!this.get_HasValue())
{return(other==null);}
if(other==null)
{return false;}
return this.value.Equals$$Object(other);},GetHashCode:function()
{if(!this.get_HasValue())
{return 0;}
return this.value.GetHashCode();},ToString:function()
{if(!this.get_HasValue())
{return"";}
return this.value.ToString();}},{},null,"SharpKit.JsClr",[]);Enum("System.StringSplitOptions",null,{None:"None",RemoveEmptyEntries:"RemoveEmptyEntries"});Class("System.Char","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{IsWhiteSpace:function(c)
{return/\s/.test(c);},IsUpper:function(c)
{return c.toUpperCase()==c;}},null,"SharpKit.JsClr",[]);Class("System.CharEnumerator","System.Object",{ctor:function(str2)
{this.currentElement='\0';this.index=0;System.Object.ctor.call(this);this.str=str2;this.index=-1;},Current$$:"System.Char",get_Current:function()
{if(this.index==-1)
{throw new System.InvalidOperationException.ctor$$String("Enum Not Started");}
if(this.index>=this.str.length)
{throw new System.InvalidOperationException.ctor$$String("Enum Ended");}
return this.currentElement;},MoveNext:function()
{if(this.index<(this.str.length-1))
{this.index++;this.currentElement=this.str.charAt(this.index);return true;}
this.index=this.str.length;return false;},Reset:function()
{this.currentElement='\0';this.index=-1;}},{},["System.Collections.Generic.IEnumerator$1","System.Collections.IEnumerator"],"SharpKit.JsClr",[]);Enum("System.StringComparison",null,{CurrentCulture:"CurrentCulture",CurrentCultureIgnoreCase:"CurrentCultureIgnoreCase",InvariantCulture:"InvariantCulture",InvariantCultureIgnoreCase:"InvariantCultureIgnoreCase",Ordinal:"Ordinal",OrdinalIgnoreCase:"OrdinalIgnoreCase"});Class("System.Uri","System.Object",{ctor:function(uri)
{System.Object.ctor.call(this);this._OriginalString=uri;},OriginalString$$:"System.String",get_OriginalString:function()
{return this._OriginalString;},ToString:function()
{return this._OriginalString;}},{},null,"SharpKit.JsClr",[]);Class("System.ValueType","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{},null,"SharpKit.JsClr",[]);JsRuntime=function()
{}
JsRuntime.Start=function()
{Compile();}