
if(typeof($CreateDelegate)=='undefined'){var $fki=0;var $fkp=String.fromCharCode(1);$CreateDelegate=function(a,b){if(a==null)return b;var c=a.$delegateCache;if(c==null){c={};a.$delegateCache=c;}if(b.$fk==null){$fki++;b.$fk=$fkp+String($fki);}var d=c[b.$fk];if(d==null){d=function(){return arguments.callee.func.apply(arguments.callee.target,arguments);};d.func=b;d.target=a;d.isDelegate=true;c[b.$fk]=d;}return d;}}
if(typeof(JsTypes)=='undefined')JsTypes=[];JsTypes.push({isEnum:false,definition:{ctor:function()
{System.Object.ctor.call(this);}},staticDefinition:{First$$IEnumerable$1:function(TSource,source)
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
{var local=$it2.get_Current();if(predicate(local))
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
{var local=$it3.get_Current();if(predicate(local))
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
{var local2=$it4.get_Current();if(predicate(local2))
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
{var local2=$it5.get_Current();if(predicate(local2))
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
return false;},Any$$IEnumerable$1:function(TSource,source)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
var enumerator=source.GetEnumerator();try
{if(enumerator.MoveNext())
{return true;}}
finally
{enumerator.Dispose();}
return false;},Any$$IEnumerable$1$$Func$2:function(TSource,source,predicate)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
if(predicate==null)
{throw System.Linq.Error.ArgumentNull("predicate");}
var $it7=source.GetEnumerator();while($it7.MoveNext())
{var local=$it7.get_Current();if(predicate(local))
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
var arr=new Array();var $it8=source.GetEnumerator();while($it8.MoveNext())
{var obj=$it8.get_Current();arr.push(obj);}
return arr;},ToList:function(TSource,source)
{if(source==null)
{throw System.Linq.Error.ArgumentNull("source");}
return new System.Collections.Generic.List$1.ctor$$IEnumerable$1(TSource,source);}},baseType:null,customAttributes:[],interfaceNames:[],assemblyName:"SharpKit.JsClr-4.1.0",fullname:"System.Linq.Enumerable",baseTypeName:"System.Object",isInterface:false,isDelegate:false,isValueType:false,isPartial:false})
if(typeof(JsTypes)=='undefined')JsTypes=[];JsTypes.push({isEnum:false,definition:{ctor:function()
{System.Object.ctor.call(this);}},staticDefinition:{ArgumentNull:function(p)
{return new System.Exception.ctor$$String("ArgumentNull "+p);},NoElements:function()
{return new System.Exception.ctor$$String("NoElements");},NoMatch:function()
{return new System.Exception.ctor$$String("NoMatch");}},baseType:null,customAttributes:[],interfaceNames:[],assemblyName:"SharpKit.JsClr-4.1.0",fullname:"System.Linq.Error",baseTypeName:"System.Object",isInterface:false,isDelegate:false,isValueType:false,isPartial:false})
if(typeof(JsTypes)=='undefined')JsTypes=[];JsTypes.push({isEnum:false,definition:{ctor:function(T,source,predicate)
{this.T=T;this.Predicate=null;this.Source=null;this.SourceEnumerator=null;System.Object.ctor.call(this);this.Source=source;this.Predicate=predicate;},Current$$:"T",get_Current:function()
{return this.SourceEnumerator.get_Current();},Reset:function()
{if(this.SourceEnumerator!=null)
this.SourceEnumerator.Reset();},MoveNext:function()
{if(this.SourceEnumerator==null)
this.SourceEnumerator=this.Source.GetEnumerator();while(true)
{if(!this.SourceEnumerator.MoveNext())
return false;var item=this.SourceEnumerator.get_Current();if(this.Predicate(item))
return true;}},Dispose:function()
{this.Source=null;this.Predicate=null;this.SourceEnumerator=null;},GetEnumerator:function()
{return this;}},staticDefinition:{},baseType:null,customAttributes:[],interfaceNames:["System.Collections.Generic.IEnumerator$1","System.Collections.Generic.IEnumerable$1"],assemblyName:"SharpKit.JsClr-4.1.0",fullname:"System.Linq.WhereIterator$1",baseTypeName:"System.Object",isInterface:false,isDelegate:false,isValueType:false,isPartial:false})
if(typeof(JsTypes)=='undefined')JsTypes=[];JsTypes.push({isEnum:false,definition:{ctor:function(T,source)
{this.T=T;this.Source=null;this.SourceEnumerator=null;System.Object.ctor.call(this);this.Source=source;},Current$$:"T",get_Current:function()
{return this.SourceEnumerator.get_Current();},Reset:function()
{if(this.SourceEnumerator!=null)
this.SourceEnumerator.Reset();},MoveNext:function()
{if(this.SourceEnumerator==null)
this.SourceEnumerator=this.Source.GetEnumerator();while(true)
{if(!this.SourceEnumerator.MoveNext())
return false;var item=this.SourceEnumerator.get_Current();if(Is(item,this.T))
return true;}},Dispose:function()
{this.Source=null;this.SourceEnumerator=null;},GetEnumerator:function()
{return this;}},staticDefinition:{},baseType:null,customAttributes:[],interfaceNames:["System.Collections.Generic.IEnumerator$1","System.Collections.Generic.IEnumerable$1"],assemblyName:"SharpKit.JsClr-4.1.0",fullname:"System.Linq.OfTypeIterator$1",baseTypeName:"System.Object",isInterface:false,isDelegate:false,isValueType:false,isPartial:false})
if(typeof(JsTypes)=='undefined')JsTypes=[];JsTypes.push({isEnum:false,definition:{ctor:function(TSource,TResult,source,selector)
{this.TSource=TSource;this.TResult=TResult;this.Selector=null;this.Source=null;this.SourceEnumerator=null;System.Object.ctor.call(this);this.Source=source;this.Selector=selector;},Current$$:"TResult",get_Current:function()
{return this.Selector(this.SourceEnumerator.get_Current());},Reset:function()
{if(this.SourceEnumerator!=null)
this.SourceEnumerator.Reset();},MoveNext:function()
{if(this.SourceEnumerator==null)
this.SourceEnumerator=this.Source.GetEnumerator();while(true)
{if(!this.SourceEnumerator.MoveNext())
return false;return true;}},Dispose:function()
{this.Selector=null;this.Source=null;this.SourceEnumerator=null;},GetEnumerator:function()
{return this;}},staticDefinition:{},baseType:null,customAttributes:[],interfaceNames:["System.Collections.Generic.IEnumerator$1","System.Collections.Generic.IEnumerable$1"],assemblyName:"SharpKit.JsClr-4.1.0",fullname:"System.Linq.SelectIterator$2",baseTypeName:"System.Object",isInterface:false,isDelegate:false,isValueType:false,isPartial:false})