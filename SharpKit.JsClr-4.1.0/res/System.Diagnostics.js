
if(typeof($CreateDelegate)=='undefined'){var $fki=0;var $fkp=String.fromCharCode(1);$CreateDelegate=function(a,b){if(a==null)return b;var c=a.$delegateCache;if(c==null){c={};a.$delegateCache=c;}if(b.$fk==null){$fki++;b.$fk=$fkp+String($fki);}var d=c[b.$fk];if(d==null){d=function(){return arguments.callee.func.apply(arguments.callee.target,arguments);};d.func=b;d.target=a;d.isDelegate=true;c[b.$fk]=d;}return d;}}
if(typeof(JsTypes)=='undefined')JsTypes=[];JsTypes.push({isEnum:false,definition:{ctor:function()
{System.Object.ctor.call(this);}},staticDefinition:{Break:function()
{debugger;}},baseType:null,customAttributes:[],interfaceNames:[],assemblyName:"SharpKit.JsClr-4.1.0",fullname:"System.Diagnostics.Debugger",baseTypeName:"System.Object",isInterface:false,isDelegate:false,isValueType:false,isPartial:false})
if(typeof(JsTypes)=='undefined')JsTypes=[];JsTypes.push({isEnum:false,definition:{ctor:function()
{System.Object.ctor.call(this);}},staticDefinition:{TraceWarning$$String:function(msg)
{if(!System.Diagnostics.Trace.Enabled)
return;if(System.Diagnostics.Trace.Warnings==null)
System.Diagnostics.Trace.Warnings=new System.Collections.Generic.List$1.ctor(System.String);System.Diagnostics.Trace.Warnings.Add(msg);},TraceWarning$$String$$Object$Array:function(format,args)
{if(!System.Diagnostics.Trace.Enabled)
return;System.Diagnostics.Trace.TraceWarning$$String(System.String.Format(format,args));},Warnings:null,Enabled:false},baseType:null,customAttributes:[],interfaceNames:[],assemblyName:"SharpKit.JsClr-4.1.0",fullname:"System.Diagnostics.Trace",baseTypeName:"System.Object",isInterface:false,isDelegate:false,isValueType:false,isPartial:false})