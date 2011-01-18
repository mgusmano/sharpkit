<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>SharpKit Samples</title>
    <script src="../../../scripts/jquery-1.4.4.min.js" type="text/javascript"></script>
    <script src="Default.js" type="text/javascript"></script>
</head>
<body>
    <h1>
        jQuery Selectors</h1>
    <p>
        This sample demonstrates how to use jQuery selectors from C#.</p>
    <div class="MyExpander">
        <a href="#" id="Header">Show / hide content 1</a>
        <div id="Content">
            <p>
            jQuery offers a powerful set of tools for matching a set of elements in a document.
            </p>
        </div>
    </div>
    <br />
    <div class="MyExpander">
        <a href="#" id="Header">Show / hide content 2</a>
        <div id="Content">
            <p>
             Use any combination of '#', '>', SPACE and '.CLASS_NAME'
            </p>
        </div>
    </div>
</body>
</html>
