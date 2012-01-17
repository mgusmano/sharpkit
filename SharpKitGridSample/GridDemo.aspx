<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridDemo.aspx.cs" Inherits="SharpKitGridSample.GridDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Grid Demo - SharpKitSamples</title>
    <link href="Grid.css" rel="stylesheet" type="text/css" />
    <script src="res/jquery-1.6.4.min.js" type="text/javascript"></script>
    <script src="Grid.js" type="text/javascript"></script>
    <script src="GridDemo.js"></script>
    <script>$(Load);</script>
</head>
<body>
<h1>Grid Demo</h1>
    <table id="MyGrid" class="Grid">
        <thead>
            <tr>
                <th onclick="SortBy(this, 'Name');">Name</th>
                <th onclick="SortBy(this, 'Age');">Age</th>
                <th onclick="SortBy(this, 'PhoneNumber');">Phone Number</th>
                <th onclick="SortBy(this, 'Description');">Description</th>
            </tr>
        </thead>
        <tbody style="display: none">
            <tr id="MyGridRowTemplate">
                <td class="CellName"></td>
                <td class="CellAge"></td>
                <td class="CellPhoneNumber"></td>
                <td class="CellDescription"></td>
           </tr>
        </tbody>
    </table>
</body>
</html>
