<%@ Page Title="" Language="C#" MasterPageFile="~/Log4JavascriptMaster.Master" AutoEventWireup="true" CodeBehind="InPageAppender.aspx.cs" Inherits="log4javascriptSample.InPageAppender" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="body">
    <h1>InPageAppender</h1>
    <p>Appender should appear in the gray rectangle below :</p>
    <div id="pageAppenderArea" style="width: 800px; height: 600px; background: #DEDEDE;" />
    <script type="text/javascript">
        InitSampleInPageAppender("pageAppenderArea");
    </script>
</asp:Content>
