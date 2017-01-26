﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepViewer.aspx.cs" Inherits="ReportViewerByHand.RepViewer.RepViewer" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <!--Add the ScriptManager-->
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div>

        <!--Add a ReportViewer from the Toolbox-->
        <rsweb:reportViewer id="rptViewer" runat="server" height="800px" width="100%" ShowZoomControl="true"></rsweb:reportViewer>    
    </div>
    </form>
</body>
</html>
