<%@ Page Title="Usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="UsuarioModificar.aspx.cs" Inherits="Project.Novaseed.UsuarioModificar" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row" style="text-align: center">
            <h2>
                <asp:Label ID="lblUsuarioModificar" runat="server" Font-Bold="true" Text="Actualizar Perfil" /></h2>
        </div>
        <hr />
        <div class="row" style="text-align: center">
            <h5>
                <asp:Label ID="lblUsuarioError" runat="server" Font-Bold="true" Text="" ForeColor="Red" /></h5>
        </div>
    </div>
</asp:Content>
