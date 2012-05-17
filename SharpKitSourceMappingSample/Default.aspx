<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SharpKitSourceMappingSample.Default" %>
<!DOCTYPE html>
<html>
<head>
    <title>SharpKitSourceMappingSample</title>
    <script src="res/jquery-1.7.2.js"></script>
    <script src="res/Default.js"></script>
    <script>$(DefaultClient_Load);</script>
    <style>
        HTML{font-family:Verdana;}
    </style>
</head>
<body>
<h1>SharpKit C# Debugging</h1>
<ul>
<li>Open in Google Chrome</li>
<li>Show the develeoper tool (F12)</li>
<li>Click the configuration wheel</li>
<li>Enable source maps</li>
<li>Choose DefaultClient.cs in the debugger</li>
<li>Set a breakpoint in btnTest_click() method</li>
<li>Click the 'Test' Button</li>
</ul>
    <button onclick="btnTest_click(event);">Test</button><br />
</body>
</html>
