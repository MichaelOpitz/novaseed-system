<%@ Page Title="Ciudad" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="CiudadAgregar.aspx.cs" Inherits="Project.Novaseed.CiudadAgregar" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row" style="text-align: center">
            <h2>
                <asp:Label ID="lblCiudadAgregar" runat="server" Font-Bold="true" Text="Agregar Ciudad" /></h2>
        </div>
        <hr />
        <div class="row" style="text-align: center">
            <h5>
                <asp:Label ID="lblCiudadError" runat="server" Font-Bold="true" Text="" ForeColor="Red" /></h5>
        </div>
        <div class="row" style="margin-top: 20px">
            <div class="col-sm-3 col-sm-offset-2">
                <asp:DropDownList type="button" ID="ddlCiudadPais" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                <span class="help-block">País</span>
            </div>
            <div class="col-sm-3" >
                <asp:DropDownList type="button" ID="ddlCiudadProvincia" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                <span class="help-block">Provincia</span>
            </div>
        </div>
    </div>
</asp:Content>

