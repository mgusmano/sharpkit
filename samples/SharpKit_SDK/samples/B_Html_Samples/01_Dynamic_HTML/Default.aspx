<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>SharpKit Samples</title>
    <script src="Default.js" type="text/javascript"></script>
</head>
<body>
    <h1>
       Dynamic HTML
    </h1>
   <h2>
		Html API example
	</h2>
	<p>
		This sample demonstrates how to dynamically create Html elements and append them to the DOM from C#.
	</p>
	<div style="border: solid 1px #cccccc; padding: 10px;">
		<b>Add a task and hit ENTER </b>
		<ul id="ulTaskList">
			<li>Buy bread</li>
			<li>Do Yoga</li>
			<li id="liNewTask">
				<input 
				type="text" 
				onblur="tbNewTask_onblur(this, event);" 
				onkeypress="return tbNewTask_onkeypress(this, event);"
					id="tbNewTask" />
			</li>
		</ul>
	</div>
</body>
</html>
