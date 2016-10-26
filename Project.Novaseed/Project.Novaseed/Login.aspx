<%@ Page Title="Login" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project.Novaseed.Login" %>

<html lang="es">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - Mi aplicación ASP.NET</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>
    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
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
    </form>


    <div class="container-fluid" style="background-color:#c8c8c8">

        <div class="row" style="height:40px">
            <div class="col-sm-7 col-sm-offset-4">
                <label for="txtLoginUsuario">Usuario</label>
            </div>
        </div>

        <div class="row" style="height:60px">
            <div class="col-sm-7 col-sm-offset-4">
                <input type="text" class="form-control" id="txtLoginUsuario" placeholder="Usuario">
            </div>
        </div>

        <div class="row" style="height:40px">
            <div class="col-sm-7 col-sm-offset-4">
                <label for="txtLoginPassword">Password</label>
            </div>
        </div>

        <div class="row" style="height:60px">
            <div class="col-sm-7 col-sm-offset-4">
                <input type="password" class="form-control" id="txtLoginPassword" placeholder="Password">
            </div>
        </div>

        <div class="row" style="height:40px; width:100%">
            <div class="col-sm-8 col-sm-offset-4">
                <label><input type="checkbox" id="chkLoginRecordarPassword" value="">Recordar contraseña</label>                
            </div>
        </div>

        <div class="row" style="height:60px">
            <div class="col-sm-7 col-sm-offset-4">
                <button type="submit" class="btn btn-info" id="btnLoginIngresar">Ingresar</button>
                <button type="submit" class="btn btn-danger" id="btnLoginCancelar">Cancelar</button>
            </div>
        </div>

        <%--<div class="row">
            <div class="col-sm-5"></div>
            <div class="col-sm-7">
                <label for="txtLoginUsuario">Usuario</label>
                <input type="text" class="form-control" id="txtLoginUsuario" placeholder="Usuario">
                <label for="txtLoginPassword">Password</label>
                <input type="password" class="form-control" id="txtLoginPassword" placeholder="Password">
            </div>
        </div>--%>

        <%--<div class="row" style="text-align: center">
            <label class="checkbox-inline">
                <input type="checkbox" id="chkLoginRecordarPassword" value="option1">
                <h6>Recordar contraseña</h6>
            </label>
        </div>

        <div class="row" style="text-align: center">
            <button type="submit" class="btn btn-info" id="btnLoginIngresar">Ingresar</button>
            <button type="submit" class="btn btn-danger" id="btnLoginCancelar">Cancelar</button>
        </div>--%>
    </div>

    <div class="container body-content">
        <footer>
            <p>&copy; <%: DateTime.Now.Year %> - Novaseed 2016. Todos los derechos reservados.</p>
            <p>Sistema desarrollado por Michael Opitz</p>
        </footer>
    </div>

</body>
</html>

