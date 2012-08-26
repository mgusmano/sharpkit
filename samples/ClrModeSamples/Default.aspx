<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClrModeSamples.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>ClrModeSamples</title>
    <script src="res/jquery-1.6.4.min.js"></script>
    <script src="res/jsclr-4.1.0.js" type="text/javascript"></script>
    <script src="DefaultClient.js" type="text/javascript"></script>
    <script>
        Compile();
        $(DefaultClient_Load);
    </script>
</head>
<body>
    <button onclick="btnTest_click(event);">Click me</button>
</body>
</html>
