<%@ Page Title="Cruzamiento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="CruzamientoAgregar.aspx.cs" Inherits="Project.Novaseed.CruzamientoAgregar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div class="row" style="text-align:center">
            <h1><span class="label label-default">Agregar Cruzamiento</span></h1>
        </div>
        <div class="row" style="margin-top: 40px">
            <div class="col-sm-4 col-sm-offset-2">
                <h5><span class="label label-default">Madre</span></h5>
                <asp:TextBox type="text" runat="server" class="form-control" ID="txtCruzamientoMadre" Style="border-color: #000000" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="col-sm-4">
                <h5><span class="label label-default">Padre</span></h5>
                <asp:TextBox type="text" runat="server" class="form-control" ID="txtCruzamientoPadre" Style="border-color: #000000" ReadOnly="true"></asp:TextBox>
            </div>
        </div>
    </div>
</asp:Content>
