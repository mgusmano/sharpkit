;;;;;
if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.Events) == "undefined")
    CoreTests.Events = {};
CoreTests.Events.CustomEvents = function (){
    this.MyEvent2 = null;
    this.MyEvent = null;
    this.MyEvent3 = null;
};
CoreTests.Events.CustomEvents.prototype.add_MyEvent2 = function (value){
    this.MyEvent2 = $CombineDelegates(this.MyEvent2, value);
};
CoreTests.Events.CustomEvents.prototype.remove_MyEvent2 = function (value){
    this.MyEvent2 = $RemoveDelegate(this.MyEvent2, value);
};
CoreTests.Events.CustomEvents.prototype.MyEvent.add = function (value){
};
CoreTests.Events.CustomEvents.prototype.MyEvent.remove = function (value){
};
CoreTests.Events.CustomEvents.prototype.add_MyEvent3 = function (value){
};
CoreTests.Events.CustomEvents.prototype.remove_MyEvent3 = function (value){
};
CoreTests.Events.CustomEventsTest = function (){
};
CoreTests.Events.CustomEventsTest.prototype.foo = function (){
    var x = new CoreTests.Events.CustomEvents();
    x.MyEvent.add($CreateDelegate(this, this.x_MyEvent));
    x.MyEvent.remove($CreateDelegate(this, this.x_MyEvent));
    x.add_MyEvent2($CreateDelegate(this, this.x_MyEvent));
    x.remove_MyEvent2($CreateDelegate(this, this.x_MyEvent));
};
CoreTests.Events.CustomEventsTest.prototype.x_MyEvent = function (){
    throw $CreateException(new System.NotImplementedException.ctor(), new Error());
};

