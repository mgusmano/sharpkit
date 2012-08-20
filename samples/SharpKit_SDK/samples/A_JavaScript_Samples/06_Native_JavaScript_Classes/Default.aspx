<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>SharpKit Samples</title>
    <script src="Default.js" type="text/javascript"></script>
</head>
<body>
    <h1>
        Native JavaScript Classes
    </h1>
    <p>
        The SharpKit.JavaScript namespace contains native JavaScript classes such as Number
        and Math.</p>
    <p>
        Matcing CLR types are prefixed with Js, for instance: JsNumber, JsMath.
    </p>
    <input id="textbox1" type="text" value="34" />
    <input id="textbox2" type="text" value="57" />
    <button onclick="btn_onclick();">
        Click to calculate the bigger number</button>
</body>
</html>
