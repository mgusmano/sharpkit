/*@Generated by SharpKit v4.23.5000*/
function Descendents(e)
{
    var divTest=document.getElementById("divTest");
    var $it1=SharpKit.Html.Extensions.Descendents(divTest).GetEnumerator();
    while($it1.MoveNext())
    {
        var node=$it1.get_Current();
        WriteLine(node.nodeName);
    }
}
function Children(e)
{
    var divTest=document.getElementById("divTest");
    var $it2=SharpKit.Html.Extensions.Children(divTest).GetEnumerator();
    while($it2.MoveNext())
    {
        var node=$it2.get_Current();
        WriteLine(node.nodeName);
    }
}
function WriteLine(s)
{
    var div=document.createElement("div");
    div.appendChild(document.createTextNode(s));
    document.body.appendChild(div);
}
