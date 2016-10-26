<%@ Page Title="Menu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="Menu.aspx.cs" Inherits="Project.Novaseed.Menu" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="row" style="font-size: x-large; height:40px; text-align:center">
        <strong>Menú</strong>
    </div>

    <br />
    <div class="row" style="height:auto; text-align:center">
        <asp:button type="button" runat="server" class="btn btn-primary" id="btnMenuMejoramiento" style='width: 160px; height: 140px' Text="Mejoramiento" OnClick="btnMenuMejoramiento_Click" ></asp:button>
        <asp:button type="button" runat="server" class="btn btn-default" id="btnMenuGeneracion" style='width: 160px; height: 140px' Text="Año de Generacion" ></asp:button>
    </div>
    <div class="row" style="height:auto; text-align:center">
        <asp:button type="button" runat="server" class="btn btn-default" id="btnMenuProduccion" style='width: 160px; height: 140px' Text="Produccion" ></asp:button>
        <asp:button type="button" runat="server" class="btn btn-primary" id="btnMenuLicencia" style='width: 160px; height: 140px' Text="Licencias"></asp:button>
    </div>

</asp:Content>