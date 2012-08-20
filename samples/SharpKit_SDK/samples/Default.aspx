<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SharpKit_SDK.samples.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <ul>
        <%
            foreach (var cat in GetGetegories())
            {
        %>
        <li><a>
        <%=cat.Name%></a>
            <ul>
                <%

                foreach (var sample in cat.Samples)
                {
                %>
                <li>
                <a href="<%=sample.Href %>">
        <%=sample.Name%></a>
                    </li>
                <%
                }%>
            </ul>
            <%
            }
            %>
        </li>
    </ul>
</body>
</html>
