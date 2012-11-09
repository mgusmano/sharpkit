<%@ Page Title="" Language="C#" MasterPageFile="~/Log4JavascriptMaster.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="log4javascriptSample.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <ul>
        <li>
            <asp:HyperLink ID="lnkInPageAppender" runat="server" NavigateUrl="~/InPageAppender.aspx"
                Text="InPageAppender" /> : log4javascript's <i>InPageAppender</i></li>
                <li><asp:HyperLink ID="lnkSelectApender" runat="server" NavigateUrl="~/SelectAppender.aspx" Text="SelectAppender" /> : Custom appender that add messages to a <i>select</i>.</li>
    </ul>
</asp:Content>
