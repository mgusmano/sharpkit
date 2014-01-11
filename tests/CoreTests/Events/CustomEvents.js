if (typeof($CreateException)=='undefined') 
{
    var $CreateException = function(ex, error) 
    {
        if(error==null)
            error = new Error();
        if(ex==null)
            ex = new System.Exception.ctor();       
        error.message = ex.message;
        for (var p in ex)
           error[p] = ex[p];
        return error;
    }
}
function $CombineDelegates(del1,del2)
{
    if(del1 == null)
        return del2;
    if(del2 == null)
        return del1;
    var del=$CreateMulticastDelegateFunction();
    del.delegates = [];
    if(del1.isMulticastDelegate)
    {
        for(var i=0;i < del1.delegates.length;i++)
            del.delegates.push(del1.delegates[i]);
    }
    else
    {
        del.delegates.push(del1);
    }
    if(del2.isMulticastDelegate)
    {
        for(var i=0;i < del2.delegates.length;i++)
            del.delegates.push(del2.delegates[i]);
    }
    else
    {
        del.delegates.push(del2);
    }
    return del;
};
function $CreateMulticastDelegateFunction()
{
    var del2 = null;
    
    var del=function()
    {
        var x=undefined;
        for(var i=0;i < del2.delegates.length;i++)
        {
            var del3=del2.delegates[i];
            x = del3.apply(null,arguments);
        }
        return x;
    };
    del.isMulticastDelegate = true;
    del2 = del;   
    
    return del;
};
function $RemoveDelegate(delOriginal,delToRemove)
{
    if(delToRemove == null || delOriginal == null)
        return delOriginal;
    if(delOriginal.isMulticastDelegate)
    {
        if(delToRemove.isMulticastDelegate)
            throw new Error("Multicast to multicast delegate removal is not implemented yet");
        var del=$CreateMulticastDelegateFunction();
        for(var i=0;i < delOriginal.delegates.length;i++)
        {
            var del2=delOriginal.delegates[i];
            if(del2 != delToRemove)
            {
                if(del.delegates == null)
                    del.delegates = [];
                del.delegates.push(del2);
            }
        }
        if(del.delegates == null)
            return null;
        if(del.delegates.length == 1)
            return del.delegates[0];
        return del;
    }
    else
    {
        if(delToRemove.isMulticastDelegate)
            throw new Error("single to multicast delegate removal is not supported");
        if(delOriginal == delToRemove)
            return null;
        return delOriginal;
    }
};
if (typeof($CreateDelegate)=='undefined'){
    if(typeof($iKey)=='undefined') var $iKey = 0;
    if(typeof($pKey)=='undefined') var $pKey = String.fromCharCode(1);
    var $CreateDelegate = function(target, func){
        if (target == null || func == null) 
            return func;
        if(func.target==target && func.func==func)
            return func;
        if (target.$delegateCache == null)
            target.$delegateCache = {};
        if (func.$key == null)
            func.$key = $pKey + String(++$iKey);
        var delegate;
        if(target.$delegateCache!=null)
            delegate = target.$delegateCache[func.$key];
        if (delegate == null){
            delegate = function(){
                return func.apply(target, arguments);
            };
            delegate.func = func;
            delegate.target = target;
            delegate.isDelegate = true;
            if(target.$delegateCache!=null)
                target.$delegateCache[func.$key] = delegate;
        }
        return delegate;
    }
}
if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.Events) == "undefined")
    CoreTests.Events = {};
CoreTests.Events.CustomEvents = function ()
{
    this.MyEvent2 = null;
    this.MyEvent = null;
    this.MyEvent3 = null;
};
CoreTests.Events.CustomEvents.prototype.add_MyEvent2 = function (value)
{
    this.MyEvent2 = $CombineDelegates(this.MyEvent2, value);
};
CoreTests.Events.CustomEvents.prototype.remove_MyEvent2 = function (value)
{
    this.MyEvent2 = $RemoveDelegate(this.MyEvent2, value);
};
CoreTests.Events.CustomEvents.prototype.MyEvent.add = function (value)
{
};
CoreTests.Events.CustomEvents.prototype.MyEvent.remove = function (value)
{
};
CoreTests.Events.CustomEvents.prototype.add_MyEvent3 = function (value)
{
};
CoreTests.Events.CustomEvents.prototype.remove_MyEvent3 = function (value)
{
};
CoreTests.Events.CustomEventsTest = function ()
{
};
CoreTests.Events.CustomEventsTest.prototype.foo = function ()
{
    var x = new CoreTests.Events.CustomEvents();
    x.MyEvent.add($CreateDelegate(this, this.x_MyEvent));
    x.MyEvent.remove($CreateDelegate(this, this.x_MyEvent));
    x.add_MyEvent2($CreateDelegate(this, this.x_MyEvent));
    x.remove_MyEvent2($CreateDelegate(this, this.x_MyEvent));
};
CoreTests.Events.CustomEventsTest.prototype.x_MyEvent = function ()
{
    throw $CreateException(new System.NotImplementedException.ctor(), new Error());
};
