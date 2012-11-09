<%@ Page Title="" Language="C#" MasterPageFile="~/Log4JavascriptMaster.Master" AutoEventWireup="true" CodeBehind="SelectAppender.aspx.cs" Inherits="log4javascriptSample.SelectAppender" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
  <h1>SelectAppender</h1>
    <p>Appender should appear in the gray rectangle below :</p>
    <select id="pageAppenderArea" style="width: 800px; height: 600px; background: #DEDEDE;" size="10" />
    <script type="text/javascript">
        InitSampleSelectAppender("pageAppenderArea");
    </script>
</asp:Content>
