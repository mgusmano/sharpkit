
Class("System.Diagnostics.Debugger","System.Object",{ctor:function()
{System.Object.ctor.call(this);}},{Break:function()
{debugger;}},null,"SharpKit.JsClr",[]);Class("System.Diagnostics.Trace","System.Object",{ctor:function()
{this.Enabled=false;System.Object.ctor.call(this);}},{TraceWarning$$String:function(msg)
{if(!System.Diagnostics.Trace.Enabled)
return;if(System.Diagnostics.Trace.Warnings==null)
System.Diagnostics.Trace.Warnings=new System.Collections.Generic.List$1.ctor(System.String);System.Diagnostics.Trace.Warnings.Add(msg);},TraceWarning$$String$$Object$Array:function(format,args)
{if(!System.Diagnostics.Trace.Enabled)
return;System.Diagnostics.Trace.TraceWarning$$String(System.String.Format(format,args));}},null,"SharpKit.JsClr",[]);