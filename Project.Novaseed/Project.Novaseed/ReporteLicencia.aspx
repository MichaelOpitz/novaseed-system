<%@ Page Title="Informe Licencia" Language="C#" AutoEventWireup="true" CodeBehind="ReporteLicencia.aspx.cs" Inherits="Project.Novaseed.ReporteLicencia" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="~/logo.ico" rel="shortcut icon" type="image/x-icon" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:Button ID="btnReporteLicencia" runat="server" Text="Cargar" Width="46%" OnClick="btnReporteLicencia_Click" />
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="46%" Height="100%">
            </rsweb:ReportViewer>

        </div>
    </form>
</body>
</html>
