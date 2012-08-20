using SharpKit.JavaScript;
using SharpKit.Html4;

[JsType(JsMode.Global, "Default.js")]
class DynamicHtmlSample : HtmlContext
{
    public static bool tbNewTask_onkeypress(HtmlInput textbox, HtmlDomEventArgs e)
    {
        //If enter is hit, blur the input
        if (e.keyCode == 13)
        {
            textbox.blur();
            return false;
        }
        return true;
    }

    public static bool tbNewTask_onblur(HtmlInput textbox)
    {
        //when input is blured, insert a new item if it is not empty
        if (textbox.value == null || textbox.value == "")
            return false;
        
        var li = document.createElement("li");
        li.appendChild(document.createTextNode(textbox.value));

        var liNewTask = document.getElementById("liNewTask");
        liNewTask.insertAdjacentElement("beforeBegin", li);

        //reset the input to blank
        textbox.value = "";
        textbox.focus();
        return true;
    }
}


