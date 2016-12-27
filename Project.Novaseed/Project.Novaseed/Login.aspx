﻿<%@ Page Title="Novaseed" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project.Novaseed.Login" %>

<html lang="es">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Novaseed</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>
    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <link href="~/logo.ico" rel="shortcut icon" type="image/x-icon" />
</head>

<body>
    <form runat="server">
        <asp:ScriptManager runat="server">
            <Scripts>
                <%--To learn more about bundling scripts in ScriptManager see http://go.microsoft.com/fwlink/?LinkID=301884 --%>
                <%--Framework Scripts--%>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="jquery" />
                <asp:ScriptReference Name="bootstrap" />
                <asp:ScriptReference Name="respond" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                <asp:ScriptReference Name="WebFormsBundle" />
                <%--Site Scripts--%>
            </Scripts>
        </asp:ScriptManager>

        <div class="container-fluid">

            <div class="row">
                <div class="col-sm-3 col-sm-offset-4" style="text-align:center">
                    <asp:Image ID="imgLoginBanner" ImageUrl="~/images/logo.png" runat="server" />
                </div>
            </div>

            <br />            
            <div class="row">
                <div class="col-sm-5 col-sm-offset-4">
                    <asp:RegularExpressionValidator ID="reLoginIngresar" runat="server" ValidationExpression="^[a-z]{3,49}$" ErrorMessage="Usuario Incorrecto" ControlToValidate="txtLoginUsuario" ForeColor="Red" ValidationGroup="login"></asp:RegularExpressionValidator>                                        
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Ingrese Usuario" ID="txtLoginUsuario"></asp:TextBox>                    
                    <asp:RegularExpressionValidator ID="reLoginContraseña" runat="server" ValidationExpression=".{3,49}" ErrorMessage="Contraseña Inválida" ControlToValidate="txtLoginContraseña" ForeColor="Red" ValidationGroup="login"></asp:RegularExpressionValidator>
                    <asp:TextBox type="password" runat="server" class="form-control" Placeholder="Ingrese Contraseña" ID="txtLoginContraseña"></asp:TextBox>                    
                </div>
            </div>

            <br />                        
            <div class="row" style="margin-top: 20px">
                <div class="col-sm-3 col-sm-offset-4">
                    <asp:Button type="button" runat="server" Text="Ingresar" ID="btnLoginIngresar" class="btn btn-primary btn-md" Width="90%" BorderColor="#000000" ValidationGroup="login" CausesValidation="true" OnClick="btnLoginIngresar_Click"></asp:Button>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-5 col-sm-offset-4">
                    <asp:CheckBox ID="chkLoginRecordar" runat="server" Text="Recordar Contraseña" />
                </div>
            </div>
        </div>

        <div class="container body-content" style="margin-top: 30px">
            <footer>
                <p>&copy; Novaseed <%: DateTime.Now.Year %>. Todos los derechos reservados.</p>
                <p>Sistema desarrollado por Michael Opitz</p>
            </footer>
        </div>

    </form>
</body>
</html>

