/*Generated by SharpKit 5 v4.28.3000*/
if(typeof(JsTypes) == "undefined")
    var JsTypes=[];
var ClrModeSamples$MyApp=
{
    fullname:"ClrModeSamples.MyApp",
    baseTypeName:"System.Object",
    staticDefinition:
    {
        Main:function()
        {
            var list=new System.Collections.Generic.List$1.ctor(ClrModeSamples.Contact);
            list.Add((function()
            {
                var $v1=new ClrModeSamples.Contact.ctor();
                $v1.set_Name("Asdas");
                return $v1;
            }).call(this));
            var $it1=list.GetEnumerator();
            while($it1.MoveNext())
            {
                var item=$it1.get_Current();
                alert(item.get_Name());
            }
            System.Linq.Enumerable.First$1$$IEnumerable$1(ClrModeSamples.Contact,list).CallMe();
            System.Linq.Enumerable.First$1$$IEnumerable$1(ClrModeSamples.Contact,list).CallMe$$String("Hello");
        }
    },
    assemblyName:"ClrModeSamples",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(ClrModeSamples$MyApp);
var ClrModeSamples$Contact=
{
    fullname:"ClrModeSamples.Contact",
    baseTypeName:"System.Object",
    assemblyName:"ClrModeSamples",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        },
        Name$$:"System.String",
        get_Name:function(){return this._Name;},
        set_Name:function(value){this._Name = value;},
        CallMe:function()
        {
            alert("CallMe1");
        },
        CallMe$$String:function(s)
        {
            alert("CallMe2 " + s);
        }
    }
};
JsTypes.push(ClrModeSamples$Contact);
function DefaultClient_Load()
{
    ClrModeSamples.MyApp.Main();
};
