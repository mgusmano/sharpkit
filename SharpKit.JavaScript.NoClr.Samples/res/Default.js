/*Generated by SharpKit 5 v4.28.3000*/
function DefaultClient_Load()
{
};
function btnTest_click(e)
{
    var xxxx="hello\nworld";
    MyExtensions.CallContact({});
    var s="asdsa";
    var xx=s.charAt(6);
    var y=s.length;
    var arr2=["a","b"];
    y = arr2.length;
    var list=new Array();
    ListHelper.IndexOf(list,"Asdas");
    list.splice(3,0,"Asdasd");
    list.push("asdas");
    list.push("ggg");
    list.splice(0,1);
    var x=list[0];
    list[0] = "aaa";
    alert(x);
    for(var $i2=0,$l2=list.length,item=list[$i2];$i2 < $l2;$i2++,item = list[$i2])
    {
        alert(item);
    }
    var dic=[];
    dic["asd"] = 7;
    dic["aasdsd"] = 8;
    dic["aasdd"] = 9;
    delete dic["asd"];
    for(var key in dic)
    {
        var value=dic[key];
        alert(value);
    }
};
