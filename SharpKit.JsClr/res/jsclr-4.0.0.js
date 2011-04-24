
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
var isIE=navigator.userAgent.toLowerCase().indexOf("msie")>-1;var isMoz=document.implementation&&document.implementation.createDocument;var isWebkit=navigator.userAgent.indexOf("WebKit")>-1;if(!isMoz)
{HTMLImageElement=null;HTMLInputElement=null;}
String.Format=function(format,varargs)
{return String.format.apply(String,arguments);}
String.prototype.startsWith=function(str)
{return this.indexOf(str)==0;}
String.prototype.endsWith=function(str)
{return this.substr(this.length-str.length,str.length)==str;}
Object.ctor=Object;Array.ctor=Array;Date.ctor=Date;Function.ctor=Function;Date.prototype.ToString=Date.prototype.toString;Number.prototype.ToString=Number.prototype.toString;Error.prototype.ToString=function()
{return this.name+" : "+this.message;}
if(typeof(ActiveXObject)!="undefined")
ActiveXObject.ctor$$String=ActiveXObject;Number.prototype.get_Value=function()
{return this;}
Number.prototype.ToString$$String=function(format)
{var s=this.toString();for(var i=0;i<format.length;i++)
{var ch=format.charAt(i);if(ch=="0")
{if(s.length<i+1)
s="0"+s;}
else
throw new Error("not implemented");}
return s;}
var ENABLE_PROFILER=typeof(appConfig)=="object"?appConfig.enableProfiler:false;var ENABLE_PROFILING=typeof(appConfig)=="object"?appConfig.enableProfiling:false;if(ENABLE_PROFILER)
{BeforeCompilation(Profiler.Initialize,Profiler);}
var envDebugFunction=(typeof(Debug)!="undefined"&&Debug!=null&&Debug.writeln)||(typeof(console)!="undefined"&&console!=null&&console.log)||function(t){};Debug={writeln:envDebugFunction}
Array.parse=function(value)
{return eval('('+value+')');}
Class("System.Object",null,{ctor:function()
{},toString:function()
{return this.ToString();},ToString:function()
{return"{"+this.constructor._type.get_FullName()+"}";},construct:function()
{arguments.callee.caller._type.baseType.ctor.apply(this,arguments);},GetType:function()
{return System.Type._TypeOf(this.constructor._type);},getType:function()
{return this.constructor._type;},getTypeName:function()
{return this.constructor._type.name;},base:function()
{return arguments.callee.caller._type.baseType.ctor.prototype[arguments.callee.caller._name].apply(this,arguments);},callBase:function(methodName)
{return arguments.callee.caller._type.baseType.ctor.prototype[methodName].apply(this,Arguments.from(arguments,1));}});Class("Object",null,{});Class("Array","Object",{GetEnumerator:function()
{return new ArrayEnumerator.ctor(this);},getItem:function(index)
{return this[index];},getCount:function()
{return this.length;},get_Count:function()
{return this.length;},selectSingle:function(propName)
{var result=[];for(var i=0;i<this.length;i++)
{var item=this[i];var value=item[propName];if(value===undefined)
value=null;result.push(value);}
return result;},Clone:function()
{return this.concat();},toArray:function()
{return this;},Add:function(item)
{this.push(item);},AddRange:function(items)
{var length=items.length;var thisLength=this.length;for(var i=0;i<length;i++)
{this[thisLength]=items[i];thisLength++;}},Clear:function()
{if(this.length>0)
{this.splice(0,this.length);}},clone:function()
{return this.slice(0);},contains:function(item)
{var index=this.indexOf(item);return(index>=0);},Contains$$Object:function(item)
{var index=this.indexOf(item);return(index>=0);},dequeue:function()
{return this.shift();},indexOf:function(item,startFrom)
{if(startFrom==null)
startFrom=0;var length=this.length;if(length!=0)
{for(var index=startFrom;index<length;index++)
{if(this[index]==item)
{return index;}}}
return-1;},insert:function(index,item)
{this.splice(index,0,item);},addAt:function(index,item)
{this.splice(index,0,item);},queue:function(item)
{this.push(item);},Remove$$Object:function(item)
{return this.Remove(item);},Remove:function(item)
{var index=this.indexOf(item);if(index>=0)
{this.splice(index,1);}
return index;},RemoveAt:function(index)
{this.splice(index,1);},copyTo:function(target,startIndex)
{for(var i=startIndex;i<this.length;i++)
{target.push(this[i]);}},filter:function(pred)
{var item,i=0;for(var i=0,j=this.length;i<j;i++)
{item=this[i];if(!pred(item))
{this.splice(i,1);i--;j--;}}
return this;},filterOut:function(pred)
{return this.filter(function(item){return!pred(item);});},apply:function(modifier)
{for(var i=0,j=this.length;i<j;i++)
{this[i]=modifier(this[i]);}
return this;},findFirst:function(pred)
{var item;for(var i=0,j=this.length;i<j;i++)
{item=this[i];if(pred(item))
return item;}
return null;},ToArray:function()
{return this;},peek:function()
{return this[this.length-1];},getLast:function()
{return this[this.length-1];},getIterator:function()
{return new ArrayIterator(this);},get_Length:function()
{return this.length;},get_Item:function(index)
{return this[index];},get_Item$$Int32:function(index)
{return this[index];}});Class("ArrayEnumerator","System.Object",{ctor:function(array)
{this._array=array;this._idx=-1;},Reset:function()
{this._idx=-1;},get_Current:function()
{return this._array[this._idx];},MoveNext:function()
{this._idx++;return this._array.length>this._idx;},Dispose:function()
{}});AfterCompilation(function()
{if(window["System.DateTime"]!=null)
{var minDate=new Date(0);minDate.setUTCFullYear(1,0,1);var minDateTime=new System.DateTime.ctor$$Date(minDate);System.DateTime.MinValue=minDateTime;System.DateTime.commonPrototype.MinValue=minDateTime;}});Class("System.Boolean","System.ValueType",{ctor:Boolean,ToString:function()
{return this==true?"true":"false";}},{tryParse:function(s)
{if(s==null)
return false;return s.toLowerCase().trim()=="true";}});Class("System.Int32","System.ValueType",{ctor:Number,ToString:function()
{return String(Number(this));}},{tryParse:function(s)
{return parseInt(s);},Parse$$String:function(s)
{return parseInt(s);}});Class("System.Decimal","System.ValueType",{ctor:function(x){return new Number(x);},ToString:function()
{return this.toString();}},{tryParse:function(s)
{return parseFloat(s);}});String.prototype._toString=String.prototype.toString;Class("System.String","System.Object",{ctor:String,GetEnumerator:function()
{return new System.CharEnumerator.ctor$$String(this);},GetType:function()
{return Typeof(System.String);},Insert$$Int32$$String:function(startIndex,str)
{var sub1=this.substring(0,startIndex);var sub2=this.substring(startIndex);return sub1+str+sub2;},Split$$Char$Array:function(varargs)
{if(arguments.length!=1)
{var re="[";for(var i=0;i<arguments.length;i++)
{re+=arguments[i];}
re+="]";var regExp=new RegExp(re);var arr=this.split(regExp);if(isMoz)
{var arr2=[];for(var i=0,j=arr.length;i<j;i++)
{if(arr[i].length>0)
arr2.push(arr[i]);}
arr=arr2;}
return arr;}
var firstArg=varargs;return this.split(firstArg);},ReplaceFirst:function(find,replace)
{return this.replace(find,replace);},Replace$$Char$$Char:function(oldValue,newValue)
{return this.Replace(oldValue,newValue);},Replace$$String$$String:function(oldValue,newValue)
{return this.Replace(oldValue,newValue);},Replace:function(oldValue,newValue)
{var last=this;var replaced=this.replace(oldValue,newValue);while(last!=replaced)
{last=replaced;replaced=replaced.replace(oldValue,newValue);}
return replaced;},Substring$$Int32:function(startIndex)
{return this.substr(startIndex);},Substring$$Int32$$Int32:function(startIndex,length)
{return this.substr(startIndex,length);},Substring:function(startIndex,length)
{return this.substr(startIndex,length);},ToLower$$:function()
{return this.toLowerCase();},ToLower:function()
{return this.toLowerCase();},ToUpper:function()
{return this.toUpperCase();},getItem:function(index)
{return this.charAt(index);},IndexOf$$String:function(s)
{return this.indexOf(s);},IndexOf$$Char:function(ch)
{return this.indexOf(ch);},Split$$Char$Array$$StringSplitOptions:function(charArray,stringSplitOptions)
{if(stringSplitOptions==System.StringSplitOptions.None)
throw new Error("Not Implemented");return this.Split$$Char$Array.apply(this,charArray);},IndexOfAny$$Char$Array:function(charArray)
{var s=charArray.join("");for(var i=0;i<this.length;i++)
{var ch=this.charAt(i);if(s.search(ch)>=0)
return i;}
return-1;},IndexOf:function(value,startIndex)
{return this.indexOf.apply(this,arguments);},LastIndexOf:function(value,startIndex)
{return this.lastIndexOf.apply(this,arguments);},LastIndexOf$$Char:function(ch)
{return this.lastIndexOf(ch);},LastIndexOf$$String:function(s)
{return this.lastIndexOf(s);},Remove$$Int32$$Int32:function(start,count)
{return this.substr(0,start)+this.substr(start+count);},StartsWith$$String:function(str)
{if(str==null)
throw new System.ArgumentNullException.ctor();return this.indexOf(str)==0;},EndsWith$$String:function(str)
{return this.lastIndexOf(str)==this.length-str.length;},Contains$$String:function(s)
{return this.indexOf(s)!=-1;},ToString:function()
{return this._toString();},toString:function()
{return this._toString();},getLength:function()
{return this.length;},get_Chars$$Int32:String.prototype.charAt,get_Chars:String.prototype.charAt,get_Length:function()
{return this.length;},trim:function()
{return this.replace(/^\s+|\s+$/g,"");},Trim:function()
{return this.replace(/^\s+|\s+$/g,"");},ltrim:function()
{return this.replace(/^\s+/,"");},rtrim:function()
{return this.replace(/\s+$/,"");},FormatObject$$String$$Object$Array:function(formatStr,object)
{var r=/{[A-Za-z]+}/g;var s=formatStr;var matches=s.match(r);for(var i=0,j=matches.length;i<j;i++)
{var m=matches[i];var n=m.substring(1,m.length-1);var v=dataObject["get"+n]();s=s.split(m).join(v);}
return s;}},{Empty:"",FormatCache:[],Format:function(format,varargs)
{var cache=System.String.FormatCache;var format=arguments[0];for(var i=1;i<arguments.length;i++)
{var re=cache[i-1];if(re==null)
{re=new RegExp('\\{'+(i-1)+'\\}','gm');cache.push(re);}
format=format.replace(re,arguments[i]);}
return format;},Format$$String$$Object$Array:function(format,varargs)
{return System.String.Format.apply(null,arguments);},Format$$String$$Object$$Object:function(s,obj1,obj2)
{return this.Format(s,obj1,obj2);},Format$$String$$Object:function(s,obj1)
{return this.Format(s,obj1);},Join$$String$$String$Array:function(separator,values)
{return values.join(separator);},Compare$$String$$String$$Boolean:function(s1,s2,ignoreCase)
{if(ignoreCase)
{s1=s1.toLowerCase();s2=s2.toLowerCase();}
if(s1>s2)
return 1;else if(s1<s2)
return-1;else
return 0;}});Arguments=function()
{}
Arguments.from=function(argsObject,start)
{return Array.prototype.slice.call(argsObject,start);}
Arguments.Range=function(argsObject,start,end)
{if(end==null)
end=argsObject.length-1;var list=new Array();for(var i=start;i<=end;i++)
{list.push(argsObject[i]);}
return list;}
Arguments.Contains=function(arguments,object)
{for(var i=0;i<arguments.length;i++)
{if(arguments[i]==object)
return true;}
return false;}
Class("Date",null,{removeTime:function()
{return new Date(this.getFullYear(),this.getMonth(),this.getDate());},getStartMonthDayOfWeek:function()
{return new Date(this.getFullYear(),this.getMonth(),1).getDay();},getShortDayOfWeek:function()
{return Date.shortDays[this.getDay()];},addMonths:function(months)
{return new Date(this.getFullYear(),this.getMonth()+months,this.getDate(),this.getHours(),this.getMinutes(),this.getSeconds(),this.getMilliseconds());},addDays:function(days)
{return new Date(this.getFullYear(),this.getMonth(),this.getDate()+days,this.getHours(),this.getMinutes(),this.getSeconds(),this.getMilliseconds());},isInMonth:function(date)
{return this.getFullYear()==date.getFullYear()&&this.getMonth()==date.getMonth();}},{shortDays:["Su","Mo","Tu","We","Th","Fr","Sa"],getNow:function()
{return new Date();},getToday:function()
{return new Date().removeTime();}});Class("VM",null,{},{GetDelegate:function(target,func)
{if(target==null)
return func;if(typeof(func)=="string")
func=target[func];var cache=target.__delegateCache;if(cache==null)
{cache={};target.__delegateCache=cache;}
var key=GetHashKey(func)+"$$"+GetHashKey(target);var delegate=cache[key];if(delegate==null)
{delegate=function()
{return arguments.callee.func.apply(arguments.callee.target,arguments);};delegate.func=func;delegate.target=target;delegate.isDelegate=true;cache[key]=delegate;}
return delegate;},tryParse:function(text,ctor)
{if(ctor==null)
return null;var type=ctor._type;return this._TryParse(text,type);},TryParse:function(text,type)
{if(typeof(type)=="string")
type=Typeof(type);if(type==null)
return null;return this._TryParse(text,type._JsType);},_TryParse:function(text,jsType)
{if(jsType==null)
return null;if(typeof(jsType)=="string")
{jsType=this.getType(jsType);if(jsType==null)
return null;}
if(jsType.tryParse==null)
return null;return jsType.tryParse(text);},PropertyIs:function(object,propertyName,typeName)
{var propertyCtor=VM.getPropertyType(object,propertyName);if(propertyCtor!=null)
{var propertyType=propertyCtor._type;var type=Type.GetType(typeName,true);return TypeIs(propertyType,type);}
return false;},getMemberTypeName:function(instance,memberName)
{var signature=instance[memberName+"$$"];if(signature==null)
return null;var memberTypeName=signature.split(" ").getLast();return memberTypeName;}});Class("SharpKit.DataModel.NotifyCollectionChangedEventArgs","System.Object",{ctor:function(action,changedItem)
{if(arguments.length==0)
return;this._Action=action;if(action=="Add")
{this._NewItems=[changedItem];}
else if(action=="Remove")
{this._OldItems=[changedItem];}
else
throw new Error("Not implemented");},get_OldItems:function()
{return this._OldItems;},get_NewItems:function()
{return this._NewItems;},get_Action:function()
{return this._Action;}});AfterCompilation(function()
{System.IO.Path.ctor();});Class("System.IO.Path","System.Object",{ctor:function()
{this.AltDirectorySeparatorChar='/';this.DirectorySeparatorChar='\\';this.InvalidFileNameChars=['"','<','>','|','\0','\x0001','\x0002','\x0003','\x0004','\x0005','\x0006','\a','\b','\t','\n','\v','\f','\r','\x000e','\x000f','\x0010','\x0011','\x0012','\x0013','\x0014','\x0015','\x0016','\x0017','\x0018','\x0019','\x001a','\x001b','\x001c','\x001d','\x001e','\x001f',':','*','?','\\','/'];this.InvalidPathChars=['"','<','>','|','\0','\x0001','\x0002','\x0003','\x0004','\x0005','\x0006','\a','\b','\t','\n','\v','\f','\r','\x000e','\x000f','\x0010','\x0011','\x0012','\x0013','\x0014','\x0015','\x0016','\x0017','\x0018','\x0019','\x001a','\x001b','\x001c','\x001d','\x001e','\x001f'];this.MaxPath=260;this.PathSeparator=';';this.RealInvalidPathChars=['"','<','>','|','\0','\x0001','\x0002','\x0003','\x0004','\x0005','\x0006','\a','\b','\t','\n','\v','\f','\r','\x000e','\x000f','\x0010','\x0011','\x0012','\x0013','\x0014','\x0015','\x0016','\x0017','\x0018','\x0019','\x001a','\x001b','\x001c','\x001d','\x001e','\x001f'];this.VolumeSeparatorChar=':';System.Object.ctor.call(this);}},{MAX_DIRECTORY_PATH:0xf8,MAX_PATH:260,ChangeExtension:function(path,extension)
{if(path==null)
{return null;}
System.IO.Path.CheckInvalidPathChars(path);var str=path;var length=path.get_Length();while(--length>=0)
{var ch=path.get_Chars(length);if(ch=='.')
{str=path.Substring$$Int32$$Int32(0,length);break;}
if(((ch==System.IO.Path.DirectorySeparatorChar)||(ch==System.IO.Path.AltDirectorySeparatorChar))||(ch==System.IO.Path.VolumeSeparatorChar))
{break;}}
if((extension==null)||(path.get_Length()==0))
{return str;}
if((extension.get_Length()==0)||(extension.get_Chars(0)!='.'))
{str=str+".";}
return(str+extension);},CharArrayStartsWithOrdinal:function(array,numChars,compareTo,ignoreCase)
{if(numChars<compareTo.get_Length())
{return false;}
if(ignoreCase)
{var str=new System.String.ctor$$Char$Array$$Int32$$Int32(array,0,compareTo.get_Length());return compareTo.Equals$$String$$StringComparison(str,System.StringComparison.OrdinalIgnoreCase);}
for(var i=0;i<compareTo.get_Length();i++)
{if(array[i]!=compareTo.get_Chars(i))
{return false;}}
return true;},CheckInvalidPathChars:function(path)
{for(var i=0;i<path.get_Length();i++)
{var num2=path.charCodeAt(i);if(((num2==0x22)||(num2==60))||(((num2==0x3e)||(num2==0x7c))||(num2<0x20)))
{throw new System.ArgumentException.ctor$$String(System.Environment.GetResourceString("Argument_InvalidPathChars"));}}},CheckSearchPattern:function(searchPattern)
{var num;while((num=searchPattern.IndexOf$$String$$StringComparison("..",System.StringComparison.Ordinal))!=-1)
{if((num+2)==searchPattern.get_Length())
{throw new System.ArgumentException.ctor$$String(System.Environment.GetResourceString("Arg_InvalidSearchPattern"));}
if((searchPattern.get_Chars(num+2)==System.IO.Path.DirectorySeparatorChar)||(searchPattern.get_Chars(num+2)==System.IO.Path.AltDirectorySeparatorChar))
{throw new System.ArgumentException.ctor$$String(System.Environment.GetResourceString("Arg_InvalidSearchPattern"));}
searchPattern=searchPattern.Substring$$Int32(num+2);}},Combine:function(path1,path2)
{if((path1==null)||(path2==null))
{throw new System.ArgumentNullException.ctor$$String((path1==null)?"path1":"path2");}
System.IO.Path.CheckInvalidPathChars(path1);System.IO.Path.CheckInvalidPathChars(path2);if(path2.get_Length()==0)
{return path1;}
if(path1.get_Length()==0)
{return path2;}
if(System.IO.Path.IsPathRooted(path2))
{return path2;}
var ch=path1.get_Chars(path1.get_Length()-1);if(((ch!=System.IO.Path.DirectorySeparatorChar)&&(ch!=System.IO.Path.AltDirectorySeparatorChar))&&(ch!=System.IO.Path.VolumeSeparatorChar))
{return(path1+System.IO.Path.DirectorySeparatorChar+path2);}
return(path1+path2);},FixupPath:function(path)
{return System.IO.Path.NormalizePath(path,false);},GetDirectoryName:function(path)
{if(path!=null)
{System.IO.Path.CheckInvalidPathChars(path);path=System.IO.Path.FixupPath(path);var rootLength=System.IO.Path.GetRootLength(path);if(path.get_Length()>rootLength)
{var length=path.get_Length();if(length==rootLength)
{return null;}
while(((length>rootLength)&&(path.get_Chars(--length)!=System.IO.Path.DirectorySeparatorChar))&&(path.get_Chars(length)!=System.IO.Path.AltDirectorySeparatorChar))
{}
return path.Substring$$Int32$$Int32(0,length);}}
return null;},GetExtension:function(path)
{if(path==null)
{return null;}
System.IO.Path.CheckInvalidPathChars(path);var length=path.get_Length();var startIndex=length;while(--startIndex>=0)
{var ch=path.get_Chars(startIndex);if(ch=='.')
{if(startIndex!=(length-1))
{return path.Substring$$Int32$$Int32(startIndex,length-startIndex);}
return string.Empty;}
if(((ch==System.IO.Path.DirectorySeparatorChar)||(ch==System.IO.Path.AltDirectorySeparatorChar))||(ch==System.IO.Path.VolumeSeparatorChar))
{break;}}
return System.String.Empty;},GetFileName:function(path)
{if(path!=null)
{System.IO.Path.CheckInvalidPathChars(path);var length=path.get_Length();var num2=length;while(--num2>=0)
{var ch=path.get_Chars(num2);if(((ch==System.IO.Path.DirectorySeparatorChar)||(ch==System.IO.Path.AltDirectorySeparatorChar))||(ch==System.IO.Path.VolumeSeparatorChar))
{return path.Substring$$Int32$$Int32(num2+1,(length-num2)-1);}}}
return path;},GetFileNameWithoutExtension:function(path)
{path=System.IO.Path.GetFileName(path);if(path==null)
{return null;}
var length=path.LastIndexOf$$Char('.');if(length==-1)
{return path;}
return path.Substring$$Int32$$Int32(0,length);},GetFullPath:function(path)
{var fullPathInternal=System.IO.Path.GetFullPathInternal(path);return fullPathInternal;},GetFullPathInternal:function(path)
{if(path==null)
{throw new System.ArgumentNullException.ctor$$String("path");}
return System.IO.Path.NormalizePath(path,true);},GetInvalidFileNameChars:function()
{return Cast(System.IO.Path.InvalidFileNameChars.Clone(),"System.Char[]");},GetInvalidPathChars:function()
{return Cast(System.IO.Path.RealInvalidPathChars.Clone(),"System.Char[]");},GetPathRoot:function(path)
{if(path==null)
{return null;}
path=System.IO.Path.FixupPath(path);return path.Substring$$Int32$$Int32(0,System.IO.Path.GetRootLength(path));},GetRandomFileName:function()
{throw new System.NotSupportedException.ctor();},GetRootLength:function(path)
{System.IO.Path.CheckInvalidPathChars(path);var num=0;var length=path.get_Length();if((length>=1)&&System.IO.Path.IsDirectorySeparator(path.get_Chars(0)))
{num=1;if((length>=2)&&System.IO.Path.IsDirectorySeparator(path.get_Chars(1)))
{num=2;var num3=2;while((num<length)&&(((path.get_Chars(num)!=System.IO.Path.DirectorySeparatorChar)&&(path.get_Chars(num)!=System.IO.Path.AltDirectorySeparatorChar))||(--num3>0)))
{num++;}}
return num;}
if((length>=2)&&(path.get_Chars(1)==System.IO.Path.VolumeSeparatorChar))
{num=2;if((length>=3)&&System.IO.Path.IsDirectorySeparator(path.get_Chars(2)))
{num++;}}
return num;},GetTempFileName:function()
{throw new System.NotSupportedException.ctor();},GetTempPath:function()
{throw new System.NotSupportedException.ctor();},HasExtension:function(path)
{if(path!=null)
{System.IO.Path.CheckInvalidPathChars(path);var length=path.get_Length();while(--length>=0)
{var ch=path.get_Chars(length);if(ch=='.')
{return(length!=(path.get_Length()-1));}
if(((ch==System.IO.Path.DirectorySeparatorChar)||(ch==System.IO.Path.AltDirectorySeparatorChar))||(ch==System.IO.Path.VolumeSeparatorChar))
{break;}}}
return false;},InternalCombine:function(path1,path2)
{if((path1==null)||(path2==null))
{throw new System.ArgumentNullException.ctor$$String((path1==null)?"path1":"path2");}
System.IO.Path.CheckInvalidPathChars(path1);System.IO.Path.CheckInvalidPathChars(path2);if(path2.get_Length()==0)
{throw new System.ArgumentException.ctor$$String$$String(System.Environment.GetResourceString("Argument_PathEmpty"),"path2");}
if(System.IO.Path.IsPathRooted(path2))
{throw new System.ArgumentException.ctor$$String$$String(System.Environment.GetResourceString("Arg_Path2IsRooted"),"path2");}
var length=path1.get_Length();if(length==0)
{return path2;}
var ch=path1.get_Chars(length-1);if(((ch!=System.IO.Path.DirectorySeparatorChar)&&(ch!=System.IO.Path.AltDirectorySeparatorChar))&&(ch!=System.IO.Path.VolumeSeparatorChar))
{return(path1+System.IO.Path.DirectorySeparatorChar+path2);}
return(path1+path2);},IsDirectorySeparator:function(c)
{if(c!=System.IO.Path.DirectorySeparatorChar)
{return(c==System.IO.Path.AltDirectorySeparatorChar);}
return true;},IsPathRooted:function(path)
{if(path!=null)
{System.IO.Path.CheckInvalidPathChars(path);var length=path.get_Length();if(((length>=1)&&((path.get_Chars(0)==System.IO.Path.DirectorySeparatorChar)||(path.get_Chars(0)==System.IO.Path.AltDirectorySeparatorChar)))||((length>=2)&&(path.get_Chars(1)==System.IO.Path.VolumeSeparatorChar)))
{return true;}}
return false;},NormalizePath:function(path,fullCheck)
{return System.IO.Path.NormalizePathSlow(path,fullCheck);},NormalizePathSlow:function(path,fullCheck)
{return path;}},null,"SharpKit.JsClr",[]);Class("System.Linq.Enumerable","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{First$$IEnumerable$1:function(TSource,source)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
var list=As(source,System.Collections.Generic.IList$1);if(list!=null)
{if(list.get_Count()>0)
{return list.get_Item(0);}}
else
{var enumerator=source.GetEnumerator();try
{if(enumerator.MoveNext())
{return enumerator.get_Current();}}
finally
{enumerator.Dispose();}}
throw System.Linq.Error.NoElements();},First$$IEnumerable$1$$Func$2:function(TSource,source,predicate)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
if(predicate==null)
{throw System.Linq.Error.ArgumentNull("predicate");}
var $it2=source.GetEnumerator();while($it2.MoveNext())
{var local=$it2.get_Current();if(predicate.Invoke(local))
{return local;}}
throw System.Linq.Error.NoMatch();},FirstOrDefault$$IEnumerable$1:function(TSource,source)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
var list=As(source,System.Collections.Generic.IList$1);if(list!=null)
{if(list.get_Count()>0)
{return list.get_Item(0);}}
else
{var enumerator=source.GetEnumerator();try
{if(enumerator.MoveNext())
{return enumerator.get_Current();}}
finally
{enumerator.Dispose();}}
return Default(TSource);},FirstOrDefault$$IEnumerable$1$$Func$2:function(TSource,source,predicate)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
if(predicate==null)
{throw System.Linq.Error.ArgumentNull("predicate");}
var $it3=source.GetEnumerator();while($it3.MoveNext())
{var local=$it3.get_Current();if(predicate.Invoke(local))
{return local;}}
return Default(TSource);},Last$$IEnumerable$1:function(TSource,source)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
var list=As(source,System.Collections.Generic.IList$1);if(list!=null)
{var count=list.get_Count();if(count>0)
{return list.get_Item(count-1);}}
else
{var enumerator=source.GetEnumerator();try
{if(enumerator.MoveNext())
{var current;do
{current=enumerator.get_Current();}
while(enumerator.MoveNext());return current;}}
finally
{enumerator.Dispose();}}
throw System.Linq.Error.NoElements();},Last$$IEnumerable$1$$Func$2:function(TSource,source,predicate)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
if(predicate==null)
{throw System.Linq.Error.ArgumentNull("predicate");}
var local=Default(TSource);var flag=false;var $it4=source.GetEnumerator();while($it4.MoveNext())
{var local2=$it4.get_Current();if(predicate.Invoke(local2))
{local=local2;flag=true;}}
if(!flag)
{throw System.Linq.Error.NoMatch();}
return local;},LastOrDefault$$IEnumerable$1:function(TSource,source)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
var list=As(source,System.Collections.Generic.IList$1);if(list!=null)
{var count=list.get_Count();if(count>0)
{return list.get_Item(count-1);}}
else
{var enumerator=source.GetEnumerator();try
{if(enumerator.MoveNext())
{var current;do
{current=enumerator.get_Current();}
while(enumerator.MoveNext());return current;}}
finally
{enumerator.Dispose();}}
return Default(TSource);},LastOrDefault$$IEnumerable$1$$Func$2:function(TSource,source,predicate)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
if(predicate==null)
{throw System.Linq.Error.ArgumentNull("predicate");}
var local=Default(TSource);var $it5=source.GetEnumerator();while($it5.MoveNext())
{var local2=$it5.get_Current();if(predicate.Invoke(local2))
{local=local2;}}
return local;},Where$$IEnumerable$1$$Func$2:function(TSource,source,predicate)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
if(predicate==null)
{throw System.Linq.Error.ArgumentNull("predicate");}
return new System.Linq.WhereIterator$1.ctor(TSource,source,predicate);},Where$$IEnumerable$1$$Func$3:function(TSource,source,predicate)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
if(predicate==null)
{throw System.Linq.Error.ArgumentNull("predicate");}
throw new System.NotImplementedException.ctor();},Contains$$IEnumerable$1$$TSource:function(TSource,source,value)
{var is2=As(source,System.Collections.Generic.ICollection$1);if(is2!=null)
{return is2.Contains(value);}
return System.Linq.Enumerable.Contains$$IEnumerable$1$$TSource$$IEqualityComparer$1(TSource,source,value,null);},Contains$$IEnumerable$1$$TSource$$IEqualityComparer$1:function(TSource,source,value,comparer)
{if(comparer==null)
{comparer=System.Collections.Generic.EqualityComparer$1.get_Default();}
if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
var $it6=source.GetEnumerator();while($it6.MoveNext())
{var local=$it6.get_Current();if(comparer.Equals$$T$$T(local,value))
{return true;}}
return false;},Count:function(TSource,source)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
var is2=As(source,System.Collections.Generic.ICollection$1);if(is2!=null)
{return is2.get_Count();}
var num=0;var enumerator=source.GetEnumerator();try
{while(enumerator.MoveNext())
{num++;}}
finally
{enumerator.Dispose();}
return num;},OfType:function(TResult,source)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
return new System.Linq.OfTypeIterator$1.ctor(TResult,source);},Select:function(TSource,TResult,source,selector)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
if(selector==null)
{throw System.Linq.Error.ArgumentNull("selector");}
return new System.Linq.SelectIterator$2.ctor(TSource,TResult,source,selector);},Take:function(TSource,source,count)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
return System.Linq.Enumerable.TakeIterator(TSource,source,count);},TakeIterator:function(TSource,source,count)
{var d__=new SharpKit.JavaScript.Private.JsImplTakeIterator$1.ctor(TSource,-2);d__._Source=source;d__._Count=count;return d__;},ToArray:function(TSource,source)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
var arr=new Array();var $it7=source.GetEnumerator();while($it7.MoveNext())
{var obj=$it7.get_Current();arr.push(obj);}
return arr;},ToList:function(TSource,source)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
return new System.Collections.Generic.List$1.ctor$$IEnumerable$1(TSource,source);}},null,"SharpKit.JsClr",[]);Class("System.Linq.Error","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{ArgumentNull:function(p)
{return new System.Exception.ctor$$String("ArgumentNull "+p);},NoElements:function()
{return new System.Exception.ctor$$String("NoElements");},NoMatch:function()
{return new System.Exception.ctor$$String("NoMatch");}},null,"SharpKit.JsClr",[]);Class("System.Linq.WhereIterator$1","System.Object",{ctor:function(T,source,predicate)
{this.T=T;System.Object.ctor.call(this);this.Source=source;this.Predicate=predicate;},Current$$:"T",get_Current:function()
{return this.SourceEnumerator.get_Current();},Reset:function()
{if(this.SourceEnumerator!=null)
this.SourceEnumerator.Reset();},MoveNext:function()
{if(this.SourceEnumerator==null)
this.SourceEnumerator=this.Source.GetEnumerator();while(true)
{if(!this.SourceEnumerator.MoveNext())
return false;var item=this.SourceEnumerator.get_Current();if(this.Predicate.Invoke(item))
return true;}},Dispose:function()
{this.Source=null;this.Predicate=null;this.SourceEnumerator=null;},GetEnumerator:function()
{return this;}},{},["System.Collections.Generic.IEnumerator$1","System.Collections.Generic.IEnumerable$1"],"SharpKit.JsClr",[]);Class("System.Linq.OfTypeIterator$1","System.Object",{ctor:function(T,source)
{this.T=T;System.Object.ctor.call(this);this.Source=source;},Current$$:"T",get_Current:function()
{return this.SourceEnumerator.get_Current();},Reset:function()
{if(this.SourceEnumerator!=null)
this.SourceEnumerator.Reset();},MoveNext:function()
{if(this.SourceEnumerator==null)
this.SourceEnumerator=this.Source.GetEnumerator();while(true)
{if(!this.SourceEnumerator.MoveNext())
return false;var item=this.SourceEnumerator.get_Current();if(Is(item,this.T))
return true;}},Dispose:function()
{this.Source=null;this.SourceEnumerator=null;},GetEnumerator:function()
{return this;}},{},["System.Collections.Generic.IEnumerator$1","System.Collections.Generic.IEnumerable$1"],"SharpKit.JsClr",[]);Class("System.Linq.SelectIterator$2","System.Object",{ctor:function(TSource,TResult,source,selector)
{this.TSource=TSource;this.TResult=TResult;System.Object.ctor.call(this);this.Source=source;this.Selector=selector;},Current$$:"TResult",get_Current:function()
{return this.Selector.Invoke(this.SourceEnumerator.get_Current());},Reset:function()
{if(this.SourceEnumerator!=null)
this.SourceEnumerator.Reset();},MoveNext:function()
{if(this.SourceEnumerator==null)
this.SourceEnumerator=this.Source.GetEnumerator();while(true)
{if(!this.SourceEnumerator.MoveNext())
return false;return true;}},Dispose:function()
{this.Selector=null;this.Source=null;this.SourceEnumerator=null;},GetEnumerator:function()
{return this;}},{},["System.Collections.Generic.IEnumerator$1","System.Collections.Generic.IEnumerable$1"],"SharpKit.JsClr",[]);Class("System.Collections.ArrayList","System.Collections.Generic.List$1",{ctor:function()
{System.Collections.Generic.List$1.ctor.call(this,"System.Object");}},{},null,"SharpKit.JsClr",[]);Class("System.Collections.Generic.Dictionary$2","System.Object",{ctor:function(TKey,TValue)
{this.TKey=TKey;this.TValue=TValue;this._version=0;System.Object.ctor.call(this);this._table=new Object();this._keys=new Object();this._version=0;},Keys$$:"System.Collections.Generic.ICollection`1",get_Keys:function()
{var keys=new Array();for(var p in this._keys)
{keys.push(this._keys[p]);}
return keys;},Values$$:"System.Collections.Generic.ICollection`1",get_Values:function()
{var values=new Array();for(var p in this._table)
{values.push(this._table[p]);}
return values;},Count$$:"System.Int32",get_Count:function()
{throw new System.NotImplementedException.ctor();},IsReadOnly$$:"System.Boolean",get_IsReadOnly:function()
{throw new System.NotImplementedException.ctor();},Item$$:"TValue",get_Item:function(key)
{var hashKey=this.GetHashKey(key);return this._table[hashKey];},set_Item:function(key,value)
{var hashKey=this.GetHashKey(key);this._table[hashKey]=value;this._keys[hashKey]=key;this._version++;},GetHashKey:function(key)
{return SharpKit.JavaScript.Utils.Js.GetHashKey(key);},Add$$TKey$$TValue:function(key,value)
{var hashKey=this.GetHashKey(key);this._table[hashKey]=value;this._keys[hashKey]=key;this._version++;},Add$$KeyValuePair$2:function(item)
{throw new System.NotImplementedException.ctor();},Remove$$TKey:function(key)
{var hashKey=this.GetHashKey(key);delete(this._table[hashKey]);delete(this._keys[hashKey]);this._version++;return true;},Remove$$KeyValuePair$2:function(item)
{throw new System.NotImplementedException.ctor();},ContainsKey:function(key)
{var hashKey=this.GetHashKey(key);return typeof(this._table[hashKey])!="undefined";},GetEnumerator:function()
{var array=new Array();for(var hashKey in this._table)
{array.push(new System.Collections.Generic.KeyValuePair$2.ctor(this.TKey,this.TValue,this._keys[hashKey],this._table[hashKey]));}
return array.GetEnumerator();},Clear:function()
{for(var hashKey in this._table)
{this._keys=new Object();this._table=new Object();this._version++;return;}},TryGetValue:function(key,value)
{throw new System.NotImplementedException.ctor();},Contains:function(item)
{throw new System.NotImplementedException.ctor();},CopyTo:function(array,arrayIndex)
{throw new System.NotImplementedException.ctor();}},{},["System.Collections.Generic.IDictionary$2"],"SharpKit.JsClr",[]);Class("System.Collections.Generic.Stack$1","System.Object",{ctor:function(T)
{this.T=T;System.Object.ctor.call(this);this._list=new Array();},Count$$:"System.Int32",get_Count:function()
{return this._list.length;},Clear:function()
{this._list.Clear();},GetEnumerator:function()
{return this._list.GetEnumerator();},ToArray:function()
{return this._list.Clone();},Push:function(item)
{this._list.push(item);},Pop:function()
{if(this._list.length==0)
throw new Error("Cannot pop from stack - stack is empty");return this._list.pop();},Contains:function(item)
{return this._list.contains(item);}},{},["System.Collections.Generic.IEnumerable$1","System.Collections.ICollection"],"SharpKit.JsClr",[]);Class("System.Collections.Generic.List$1","System.Object",{ctor:function(T)
{this.T=T;System.Object.ctor.call(this);this._list=new Array();},ctor$$IEnumerable$1:function(T,collection)
{this.T=T;System.Object.ctor.call(this);this._list=new Array();this.AddRange(collection);},Count$$:"System.Int32",get_Count:function()
{return this._list.length;},IsReadOnly$$:"System.Boolean",get_IsReadOnly:function()
{throw new System.NotImplementedException.ctor$$String("JsImplList$T");},Item$$:"T",get_Item:function(index)
{if(index>=this._list.length||index<0)
throw new System.ArgumentOutOfRangeException.ctor$$String("index");return this._list[index];},set_Item:function(index,value)
{if(index>=this._list.length||index<0)
throw new System.ArgumentOutOfRangeException.ctor$$String("index");this._list[index]=value;},RemoveRange:function(index,count)
{this._list.splice(index,count);},Clear:function()
{this._list.Clear();},GetEnumerator:function()
{return new System.Collections.IListEnumerator$1.ctor(this.T,this);},ToArray:function()
{return this._list.Clone();},AddRange:function(items)
{var $it1=items.GetEnumerator();while($it1.MoveNext())
{var item=$it1.get_Current();this.Add(item);}},Add:function(item)
{this._list.push(item);},Remove:function(item)
{var index=this._list.indexOf(item);if(index==-1)
return false;this._list.RemoveAt(index);return true;},Contains:function(item)
{return this._list.contains(item);},SetItems:function(items)
{this.Clear();if(items!=null)
this.AddRange(items);},IndexOf:function(item)
{return this._list.indexOf(item);},Insert:function(index,item)
{this._list.insert(index,item);},RemoveAt:function(index)
{this._list.RemoveAt(index);},TryRemove:function(item)
{throw new System.NotImplementedException.ctor$$String("TryRemove");},CopyTo:function(array,arrayIndex)
{throw new System.NotImplementedException.ctor$$String("JsImplList$T");},Sort:function(comparison)
{this._list.sort(SharpKit.JavaScript.Utils.Js.ToJsFunction(comparison));}},{},["System.Collections.Generic.IList$1","System.Collections.IList"],"SharpKit.JsClr",[]);Class("System.Collections.IListEnumerator$1","System.Object",{ctor:function(T,list)
{this.T=T;this.Index=0;this.ListCount=0;System.Object.ctor.call(this);this.List=list;this.Index=-1;this.ListCount=list.get_Count();},Current$$:"T",get_Current:function()
{return this.List.get_Item(this.Index);},Dispose:function()
{this.List=null;},MoveNext:function()
{this.Index++;return this.Index<this.ListCount;},Reset:function()
{this.Index=-1;}},{},["System.Collections.Generic.IEnumerator$1"],"SharpKit.JsClr",[]);Enum("System.Reflection.BindingFlags",null,{CreateInstance:"CreateInstance",DeclaredOnly:"DeclaredOnly",Default:"Default",ExactBinding:"ExactBinding",FlattenHierarchy:"FlattenHierarchy",GetField:"GetField",GetProperty:"GetProperty",IgnoreCase:"IgnoreCase",IgnoreReturn:"IgnoreReturn",Instance:"Instance",InvokeMethod:"InvokeMethod",NonPublic:"NonPublic",OptionalParamBinding:"OptionalParamBinding",Public:"Public",PutDispProperty:"PutDispProperty",PutRefDispProperty:"PutRefDispProperty",SetField:"SetField",SetProperty:"SetProperty",Static:"Static",SuppressChangeType:"SuppressChangeType"});Class("System.Reflection.MemberInfo","System.Object",{ctor:function()
{System.Object.ctor.call(this);},Name$$:"System.String",get_Name:function()
{return this._Name;},DeclaringType$$:"SharpKit.JavaScript.Private.JsImplType",get_DeclaringType:function()
{return this._DeclaringType;},VerifyCustomAttributes:function()
{this.get_DeclaringType().VerifyCustomAttributesOnTypeAndMembers();},GetBaseMember:function()
{return null;},AddCustomAttributes:function(list,attributeType,inherit)
{this.VerifyCustomAttributes();if(this._CustomAttributes!=null)
{for(var i=0;i<this._CustomAttributes.length;i++)
{var att=this._CustomAttributes[i];if(attributeType.IsInstanceOfType(att))
list.Add(att);}}
if(inherit)
{var bm=this.GetBaseMember();if(bm!=null)
bm.AddCustomAttributes(list,attributeType,inherit);}},GetCustomAttributes$$Type$$Boolean:function(attributeType,inherit)
{var list=new System.Collections.Generic.List$1.ctor(System.Object);this.AddCustomAttributes(list,attributeType,inherit);return list.ToArray();},GetCustomAttributes$$Boolean:function(inherit)
{if(inherit)
throw new System.NotImplementedException.ctor$$String("GetCustomAttributes with inherit=true is not implemented");this.VerifyCustomAttributes();return this._CustomAttributes;}},{},null,"SharpKit.JsClr",[]);Class("System.Reflection.MethodBase","System.Reflection.MemberInfo",{ctor:function()
{System.Reflection.MemberInfo.ctor.call(this);}},{},null,"SharpKit.JsClr",[]);Class("System.Reflection.MethodInfo","System.Reflection.MethodBase",{ctor:function()
{this._IsStatic=false;this.JsFunction=null;this.JsName=null;System.Reflection.MethodBase.ctor.call(this);},Invoke:function(obj,parameters)
{var func;if(this._IsStatic)
func=this.JsFunction;else
{if(obj==null)
throw new System.Exception.ctor$$String("Cannot invoke non static method without a target object");func=obj[this.JsName];}
var res;if(parameters==null)
res=func.apply(obj);else
res=func.apply(obj,parameters);return res;}},{},null,"SharpKit.JsClr",[]);Class("System.Reflection.PropertyInfo","System.Reflection.MemberInfo",{ctor:function()
{this._IsStatic=false;System.Reflection.MemberInfo.ctor.call(this);},Name$$:"System.String",get_Name:function()
{return this._Name;},PropertyType$$:"SharpKit.JavaScript.Private.JsImplType",get_PropertyType:function()
{return this._PropertyType;},GetBaseMember:function()
{return null;},GetValue:function(obj,indexes)
{if(this._Getter==null)
throw new System.Exception.ctor$$String("Property "+this._Name+" doesn't have a getter");var value=this._Getter.apply(obj,(indexes!=null?indexes:new Array()));return value;},SetValue:function(obj,value,indexes)
{if(this._Setter==null)
throw new System.Exception.ctor$$String("Property "+this._Name+" doesn't have a setter");if(indexes==null||indexes.get_Length()==0)
{this._Setter.call(obj,value);}
else
{var arr=new Array(indexes);arr.push(value);this._Setter.apply(obj,(indexes!=null?indexes:new Array()));}}},{},null,"SharpKit.JsClr",[]);Class("System.Type","System.Reflection.MemberInfo",{ctor:function(jsType)
{this.allPropertiesVerified=false;this.verifiedCustomAttributesOnTypeAndMembers=false;System.Reflection.MemberInfo.ctor.call(this);this._JsType=jsType;this._Name=this._JsType.name;if(System.Type.EmptyTypes==null)
System.Type.EmptyTypes=[];},IsEnum$$:"System.Boolean",get_IsEnum:function()
{return this._JsType.isEnum;},BaseType$$:"SharpKit.JavaScript.Private.JsImplType",get_BaseType:function()
{if(this._JsType.baseType==null)
return null;return System.Type._TypeOf(this._JsType.baseType);},Name$$:"System.String",get_Name:function()
{return this._JsType.get_Name();},FullName$$:"System.String",get_FullName:function()
{return this._JsType.get_FullName();},AssemblyQualifiedName$$:"System.String",get_AssemblyQualifiedName:function()
{return this._JsType.get_AssemblyQualifiedName();},GetBaseMember:function()
{return this.get_BaseType();},FillProperties:function(def)
{for(var funcName in def)
{var isGetter=funcName.startsWith("get_");var isSetter=funcName.startsWith("set_");if(isGetter||isSetter)
this.FillProperty(def,funcName,isSetter);}},FillProperty:function(def,funcName,isSetter)
{var member=def[funcName];var func=member;var propName=funcName.Substring$$Int32(4);var prop=this._PropertiesByName[propName];if(prop==null)
{prop=new System.Reflection.PropertyInfo.ctor();this._PropertiesByName[propName]=prop;this._Properties.push(prop);prop._Name=propName;prop._DeclaringType=this;prop._IsStatic=this._JsType.staticDefinition!=null&&this._JsType.staticDefinition[funcName]!=null;var propTypeName=VM.getMemberTypeName(def,propName);if(propTypeName!=null)
prop._PropertyType=System.Type.GetType$$String(propTypeName);else
{}}
if(isSetter)
prop._Setter=func;else
prop._Getter=func;},TryFillProperty:function(def,name)
{if(def==null)
return false;var getterName="get_"+name;var setterName="set_"+name;if(def.hasOwnProperty(getterName))
this.FillProperty(def,getterName,false);if(def.hasOwnProperty(setterName))
this.FillProperty(def,setterName,true);return this._PropertiesByName[name]!=null;},GetProperty:function(name)
{this.VerifyProperty(name);return this._PropertiesByName[name];},VerifyProperty:function(name)
{if(this._PropertiesByName==null)
{this._PropertiesByName=new Object();this._Properties=new Array();}
if(this._PropertiesByName.hasOwnProperty(name))
return;if(this.TryFillProperty(this._JsType.definition,name))
return;if(this.TryFillProperty(this._JsType.staticDefinition,name))
return;var baseType=this.get_BaseType();if(baseType!=null)
{var pe=baseType.GetProperty(name);this._PropertiesByName[name]=pe;this._Properties.push(pe);return;}
this._PropertiesByName[name]=null;},VerifyProperties:function()
{if(!this.allPropertiesVerified)
{this.allPropertiesVerified=true;if(this._PropertiesByName==null)
{this._PropertiesByName=new Object();this._Properties=new Array();}
this.FillProperties(this._JsType.definition);this.FillProperties(this._JsType.staticDefinition);var baseType=this.get_BaseType();if(baseType!=null)
{var $it8=baseType.GetProperties().GetEnumerator();while($it8.MoveNext())
{var pe=$it8.get_Current();if(!this._PropertiesByName.hasOwnProperty(pe._Name))
{this._PropertiesByName[pe._Name]=pe;this._Properties.push(pe);}}}}},GetProperties:function()
{this.VerifyProperties();return this._Properties;},FillMethods:function(def)
{var isStatic=def==this._JsType.staticDefinition;for(var funcName in def)
{if(funcName=="toString")
continue;var func=def[funcName];if(SharpKit.JavaScript.Utils.Js.Typeof(func)!="function")
continue;var methodName=SharpKit.JavaScript.JsNamingHelper.JsFunctionNameToClrMethodName(funcName);var methods=this._MethodsByName[methodName];if(methods==null)
{methods=new Array();this._MethodsByName[methodName]=methods;}
var method=new System.Reflection.MethodInfo.ctor();methods.push(method);this._Methods.push(method);method._Name=methodName;method.JsName=funcName;method.JsFunction=func;method._DeclaringType=this;method._IsStatic=this._JsType.staticDefinition!=null&&this._JsType.staticDefinition[funcName]==func;}},GetMethod:function(name)
{this.VerifyMethods();var methods=this._MethodsByName[name];if(methods==null)
return null;return methods[0];},VerifyMethods:function()
{if(this._MethodsByName==null)
{this._MethodsByName=new Object();this._Methods=new Array();this.FillMethods(this._JsType.definition);this.FillMethods(this._JsType.staticDefinition);var baseType=this.get_BaseType();if(baseType!=null)
{var $it9=baseType.GetMethods().GetEnumerator();while($it9.MoveNext())
{var pe=$it9.get_Current();if(this._MethodsByName[pe._Name]==null)
{this._MethodsByName[pe._Name]=pe;this._Methods.push(pe);}}}}},GetMethods:function()
{this.VerifyMethods();var arr=new Array();for(var i=0;i<this._Methods.length;i++)
{arr.push(this._Methods[i]);}
return arr;},GetMethods$$String:function(name)
{this.VerifyMethods();return this._MethodsByName[name];},GetMethods$$BindingFlags:function(bindingFlags)
{return this.GetMethods();},VerifyCustomAttributes:function()
{this.VerifyCustomAttributesOnTypeAndMembers();},VerifyCustomAttributesOnTypeAndMembers:function()
{if(this.verifiedCustomAttributesOnTypeAndMembers)
return;this.verifiedCustomAttributesOnTypeAndMembers=true;if(this._JsType.customAttributes==null)
return;for(var i=0;i<this._JsType.customAttributes.length;i++)
{var attDef=this._JsType.customAttributes[i];var attType=JsType.GetType(attDef.typeName);var jsCtor=attType[attDef.ctorName];var att=SharpKit.JavaScript.Utils.Js.ApplyNew(jsCtor,attDef.positionalArguments);if(attDef.namedArguments!=null)
{for(var propName in attDef.namedArguments)
{var value=attDef.namedArguments[propName];if(SharpKit.JavaScript.Utils.Js.Typeof(value)=="function")
value=value.call(null);att["set_"+propName].call(att,value);}}
var target=this.GetAttributeTarget(attDef.targetType,attDef.targetMemberName);if(target._CustomAttributes==null)
target._CustomAttributes=new Array();target._CustomAttributes.push(att);}},GetAttributeTarget:function(memberType,memberName)
{if(memberType=="type")
return this;else if(memberType=="method")
{var methodName=SharpKit.JavaScript.JsNamingHelper.JsFunctionNameToClrMethodName(memberName);var $it10=this.GetMethods$$String(methodName).GetEnumerator();while($it10.MoveNext())
{var method=$it10.get_Current();if(method.JsName==memberName)
return method;}
return null;}
else if(memberType=="property")
{return this.GetProperty(memberName);}
else
throw new System.NotImplementedException.ctor$$String("GetAttributeTarget not supported yet for memberType: "+memberType);},IsAssignableFrom:function(type)
{return TypeIs(type._JsType,this._JsType);},IsInstanceOfType:function(obj)
{return Is(obj,this._JsType);},ToString:function()
{return System.String.Format("{Name = "+this.get_Name()+" FullName = "+this.get_FullName()+"}");},MakeGenericType:function(typeArguments)
{var x=[];for(var i=0;i<arguments.length;i++)
x.push(arguments[i]||null);return this._MakeGenericType(x);},GetGenericTypeDefinition:function()
{return this._GenericTypeDefinition;},GetGenericArguments:function()
{if(this._TypeArguments==null)
return System.Type.EmptyTypes;return this._TypeArguments;},_MakeGenericType:function(typeArguments)
{if(this._MakeGenericTypeCache==null)
this._MakeGenericTypeCache=new Object();var key="";for(var i=0;i<typeArguments.length;i++)
{var typeArg=typeArguments[i];key+=typeArg._Name;}
var t=this._MakeGenericTypeCache[key];if(t==null)
{t=new System.Type.ctor(this._JsType);this._MakeGenericTypeCache[key]=t;t._Name=this._Name;t._GenericTypeDefinition=this;t._TypeArguments=typeArguments;t._Properties=this._Properties;t._PropertiesByName=this._PropertiesByName;t._Methods=this._Methods;t._MethodsByName=this._MethodsByName;t._DeclaringType=this._DeclaringType;t._CustomAttributes=this._CustomAttributes;}
return t;}},{_TypeOf:function(jsType)
{if(jsType==null)
throw new System.Exception.ctor$$String("Cannot resovle type");if(jsType._ClrType==null)
jsType._ClrType=new System.Type.ctor(jsType);return jsType._ClrType;},GetType$$String:function(name)
{return System.Type.GetType$$String$$Boolean(name,false);},GetType$$String$$Boolean:function(name,throwOnError)
{if(JsType._HasTypeArguments(name))
{var jsTypeAndArgs=JsType._GetTypeWithArguments(name,throwOnError);if(jsTypeAndArgs==null)
return null;var genericType=System.Type._TypeOf(jsTypeAndArgs[0]);var jsTypeArgs=jsTypeAndArgs[1];for(var i=0;i<jsTypeArgs.length;i++)
{jsTypeArgs[i]=System.Type._TypeOf(jsTypeArgs[i]);}
var type=genericType._MakeGenericType(jsTypeArgs);return type;}
var jsType=JsType.GetType(name);if(jsType==null)
{if(throwOnError)
throw new System.Exception.ctor$$String("Type "+name+" was not found");return null;}
return System.Type._TypeOf(jsType);},GetType$$String$$Boolean$$Boolean:function(name,throwOnError,ignoreCase)
{if(ignoreCase)
throw new System.NotImplementedException.ctor();return System.Type.GetType$$String$$Boolean(name,throwOnError);}},null,"SharpKit.JsClr",[]);Class("System.Diagnostics.Debugger","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{Break:function()
{debugger;}},null,"SharpKit.JsClr",[]);Class("System.Diagnostics.Trace","System.Object",{ctor:function()
{this.Enabled=false;System.Object.ctor.call(this);}},{TraceWarning$$String:function(msg)
{if(!System.Diagnostics.Trace.Enabled)
return;if(System.Diagnostics.Trace.Warnings==null)
System.Diagnostics.Trace.Warnings=new System.Collections.Generic.List$1.ctor(System.String);System.Diagnostics.Trace.Warnings.Add(msg);},TraceWarning$$String$$Object$Array:function(format,args)
{if(!System.Diagnostics.Trace.Enabled)
return;System.Diagnostics.Trace.TraceWarning$$String(System.String.Format(format,args));}},null,"SharpKit.JsClr",[]);Class("System.Text.StringBuilder","System.Object",{ctor:function()
{this.length=0;System.Object.ctor.call(this);this.array=[];this.length=0;},ctor$$String:function(s)
{this.length=0;System.Object.ctor.call(this);this.array=[s];this.length=s==null?0:s.get_Length();},Length$$:"System.Int32",get_Length:function()
{return this.length;},set_Length:function(value)
{if(value!=0)
throw new System.Exception.ctor$$String("Not Implemented");this.array.Clear();this.length=value;},Append$$Char:function(s)
{this.array.push(s);this.length+=1;},Append$$String:function(s)
{this.array.push(s);this.length+=s.get_Length();},Append$$Object:function(obj)
{if(obj!=null)
{var s=obj.ToString();this.array.push(s);this.length+=s.get_Length();}},AppendFormat$$String$$Object:function(s,arg0)
{var ss=System.String.Format(s,arg0);this.array.push(ss);this.length+=ss.get_Length();},AppendFormat$$String$$Object$$Object:function(s,arg0,arg1)
{var ss=System.String.Format(s,arg0,arg1);this.array.push(ss);this.length+=ss.get_Length();},AppendFormat$$String$$Object$$Object$$Object:function(s,arg0,arg1,arg2)
{var ss=System.String.Format(s,arg0,arg1,arg2);this.array.push(ss);this.length+=ss.get_Length();},ToString:function()
{return this.array.join("");},Remove:function(start,count)
{var s=this.array.join("");s=s.Remove$$Int32$$Int32(start,count);this.array=[s];this.length=s.length;return this;}},{},null,"SharpKit.JsClr",[]);Interface("System.Runtime.Serialization.IExtensibleDataObject","System.Object",null,"SharpKit.JsClr",[]);Class("SharpKit.PropertyInfoExtensions","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{IsStatic:function(pi)
{return pi._IsStatic;},IsPublic:function(pi)
{throw new Error('Not Implemented');}},null,"SharpKit.JsClr",[]);Class("SharpKit.Extensions2","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{GetValueOrDefaultIfNullOrEmpty:function(s,defaultValue)
{if(s==null||s.length==0)return defaultValue;return s;},IsNullOrEmpty$$String:function(s)
{return s==null||s.length==0;},IsNotNullOrEmpty$$String:function(s)
{return s!=null&&s.length>0;},HtmlEscape:function(s)
{return s.Replace$$String$$String("&","&amp;").Replace$$String$$String("<","&lt;").Replace$$String$$String(">","&gt;").Replace$$String$$String("\n","<br/>");},ReplaceFirst$$String$$String$$String:function(s,search,replace)
{return s.ReplaceFirst(search,replace);},ReplaceFirst$$String$$String$$String$$StringComparison:function(s,search,replace,comparisonType)
{var index=s.IndexOf$$String$$StringComparison(search,comparisonType);if(index!=-1)
{var finalStr=System.String.Concat$$String$$String$$String(s.Substring$$Int32$$Int32(0,index),replace,s.Substring$$Int32(search.get_Length()+index));return finalStr;}
return s;},FixCamelCasing:function(s)
{var sb=new System.Text.StringBuilder.ctor();var first=true;var $it11=s.GetEnumerator();while($it11.MoveNext())
{var c=$it11.get_Current();if(System.Char.IsUpper$$Char(c)&&!first)
{sb.Append$$Char(' ');}
sb.Append$$Char(c);first=false;}
return sb.ToString();},RemoveLast:function(s,count)
{return s.substr(s,s.length-count);},TrimEnd:function(s,trimText)
{if(s.EndsWith$$String(trimText))
return SharpKit.Extensions2.RemoveLast(s,trimText.get_Length());return s;},EqualsIgnoreCase:function(s1,s2)
{return System.String.Compare$$String$$String$$Boolean(s1,s2,true)==0;}},null,"SharpKit.JsClr",[]);Class("SharpKit.JavaScript.Utils.Js","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{escape:function(s)
{return escape(s);},ToJsFunction:function(del)
{return del._ToJsFunction();},JsEquals:function(obj,value)
{return obj==value;},JsExactEqualsToUndefined:function(obj)
{return obj===undefined;},JsExactEquals:function(obj,value)
{return obj===value;},Typeof:function(obj)
{return typeof(obj);},ApplyFunction:function(func,thisArg,prms)
{throw new System.NotImplementedException.ctor$$String("TODO: Implement");},CallFunction:function(func,thisArg,prms)
{throw new System.NotImplementedException.ctor$$String("TODO: Implement");},CallFunction2:function(obj,funcName,prms)
{return obj[funcName].apply(obj,Arguments.from(arguments,2));},CreateDelegate:function(obj,func)
{return new System.MulticastDelegate.ctor(obj,func);},CreateInstanceDelegate$$Object$$String:function(obj,funcName)
{var jsObj=obj;if(jsObj==null||funcName==null||jsObj[funcName]==null)
throw new System.Exception.ctor$$String("CreateInstanceDelegate error");return new System.MulticastDelegate.ctor(jsObj,jsObj[funcName]);},CreateInstanceDelegate$$Object$$String$$Boolean:function(obj,funcName,findOverloadedMethod)
{var jsObj=obj;if(jsObj==null||funcName==null)
throw new System.Exception.ctor$$String("CreateInstanceDelegate error");if(jsObj[funcName]==null&&findOverloadedMethod)
{var overloadedFuncName=SharpKit.JavaScript.Utils.Js.FindOverloadedMethodName(obj,funcName);if(overloadedFuncName==null)
throw new System.Exception.ctor$$String("CreateInstanceDelegate error");else
funcName=overloadedFuncName;}
if(jsObj[funcName]==null)
throw new System.Exception.ctor$$String("CreateInstanceDelegate error");return new System.MulticastDelegate.ctor(jsObj,jsObj[funcName]);},FindOverloadedMethodName:function(obj,funcName)
{funcName+='$$';for(var o in obj)
if(typeof(obj[o])=='function'&&o.indexOf(funcName)==0)
return o;return null;},Eval:function(code)
{eval(code)},Compile:function()
{throw new System.NotImplementedException.ctor();},GetHashKey:function(key)
{return GetHashKey(key);},DeleteMember:function(obj,name)
{delete obj[name];},parseFloat:function(s)
{return parseFloat(s);},parseInt:function(s)
{return parseInt(s);},ApplyNew:function(jsCtor,prms)
{if(prms==null||prms.length==0)return new jsCtor();return new jsCtor(prms[0],prms[1],prms[2],prms[3],prms[4],prms[5],prms[6],prms[7],prms[8]);},IsArray:function(obj)
{return obj instanceof Array;},isNaN:function(obj)
{return isNaN(obj);},decodeURIComponent:function(encodedURIString)
{return decodeURIComponent(encodedURIString)},encodeURIComponent:function(encodedURIString)
{return encodeURIComponent(encodedURIString)},encodeURI:function(URIString)
{return encodeURI(URIString)},decodeURI:function(URIString)
{return decodeURI(URIString)},unescape:function(s)
{return unescape(s)}},null,"SharpKit.JsClr",[]);Class("SharpKit.JavaScript.JsNamingHelper","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{JsFunctionNameToClrMethodName:function(jsFuncName)
{var methodName=jsFuncName;var di=jsFuncName.IndexOf$$Char('$');if(di>0)
methodName=jsFuncName.Substring$$Int32$$Int32(0,di);return methodName;},ClrTypeToJsTypeRef:function(type)
{var att=System.Linq.Enumerable.FirstOrDefault$$IEnumerable$1("SharpKit.JavaScript.JsTypeAttribute",System.Linq.Enumerable.OfType("SharpKit.JavaScript.JsTypeAttribute",type.GetCustomAttributes$$Type$$Boolean(Typeof(SharpKit.JavaScript.JsTypeAttribute),false)));if(att!=null&&SharpKit.Extensions2.IsNotNullOrEmpty$$String(att.get_Name()))
{return att.get_Name().Replace$$Char$$Char('`','$');}
return type.get_Namespace()+"."+type.get_Name().Replace$$Char$$Char('`','$');},ClrConstructorToJsFunctionName:function(mi)
{var sb=new System.Text.StringBuilder.ctor();var typeRef=SharpKit.JavaScript.JsNamingHelper.ClrTypeToJsTypeRef(mi.get_DeclaringType());sb.Append$$String(typeRef);sb.Append$$String(".ctor");SharpKit.JavaScript.JsNamingHelper.ConvertParametersToJsFunctionName(mi.GetParameters(),sb);return sb.ToString();},ConvertParametersToJsFunctionName:function(prms,sb)
{var $it12=prms.GetEnumerator();while($it12.MoveNext())
{var prm=$it12.get_Current();sb.Append$$String("$$");sb.Append$$String(prm.get_ParameterType().get_Name());}},ClrMethodBaseToJsFunctionName:function(mi)
{if(mi.get_MemberType()==System.Reflection.MemberTypes.Constructor)
{return SharpKit.JavaScript.JsNamingHelper.ClrMethodToJsFunctionName(Cast(mi,"System.Reflection.MethodInfo"));}
else if(mi.get_MemberType()==System.Reflection.MemberTypes.Method)
{return SharpKit.JavaScript.JsNamingHelper.ClrConstructorToJsFunctionName(Cast(mi,"System.Reflection.ConstructorInfo"));}
else
throw new System.NotImplementedException.ctor();},ClrMethodToJsFunctionName:function(mi)
{if(SharpKit.JavaScript.JsNamingHelper.IsPropertySetter(mi))
{return mi.get_Name();}
var name=mi.get_Name();var type=mi.get_DeclaringType();if(type.get_IsGenericType())
{type=type.GetGenericTypeDefinition();mi=type.GetMethod$$String(name);}
var sb=new System.Text.StringBuilder.ctor();if(mi.get_IsStatic())
{sb.Append$$String(SharpKit.JavaScript.JsNamingHelper.ClrTypeToJsTypeRef(type));var att=System.Linq.Enumerable.FirstOrDefault$$IEnumerable$1("SharpKit.JavaScript.JsTypeAttribute",System.Linq.Enumerable.OfType("SharpKit.JavaScript.JsTypeAttribute",type.GetCustomAttributes$$Type$$Boolean(Typeof(SharpKit.JavaScript.JsTypeAttribute),false)));if(att==null||att.get_Mode()==SharpKit.JavaScript.JsMode.Clr)
{sb.Append$$String(".staticDefinition.");}
else
{sb.Append$$String(".");}}
sb.Append$$String(name);SharpKit.JavaScript.JsNamingHelper.ConvertParametersToJsFunctionName(mi.GetParameters(),sb);return sb.ToString();},IsPropertySetter:function(mi)
{var name=mi.get_Name();return name.StartsWith$$String("set_")&&mi.GetParameters().get_Length()==1;}},null,"SharpKit.JsClr",[]);