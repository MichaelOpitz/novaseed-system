<%@ Page Title="Menú Año de Generación" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="MenuGeneracion.aspx.cs" Inherits="Project.Novaseed.MenuGeneracion" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div class="row" style="text-align: center; margin-top: 40px">
            <asp:DropDownList type="button" ID="ddlGeneracionAño" runat="server" class="btn btn-primary dropdown-toggle" Width="30%" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <asp:ListItem Value="AñoSeleccion">Seleccionar año</asp:ListItem>
            </asp:DropDownList>
            <div class="alert alert-warning" id="alertAñoSeleccion">
                <strong>Atención!</strong> Seleccione un año valido.
            </div>
        </div>
        <div class="row" style="margin-top: 40px">
            <div class="col-sm-9 col-sm-offset-2">
                <asp:Button type="button" runat="server" Text="Cruzamiento" ID="btnGeneracionCruzamiento" Width="30%" Height="100px" class="btn btn-default btn-md" BorderColor="#000000" Font-Bold="true" OnClick="btnGeneracionCruzamiento_Click"></asp:Button>
                <asp:Button type="button" runat="server" Text="Vasos" ID="btnGeneracionVasos" Width="30%" Height="100px" class="btn btn-default btn-md" BorderColor="#000000" Font-Bold="true" OnClick="btnGeneracionVasos_Click"></asp:Button>
                <asp:Button type="button" runat="server" Text="Clones" ID="btnGeneracionClones" Width="30%" Height="100px" class="btn btn-default btn-md" BorderColor="#000000" Font-Bold="true" OnClick="btnGeneracionClones_Click"></asp:Button>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-9 col-sm-offset-2">
                <asp:Button type="button" runat="server" Text="Codificación" ID="btnGeneracionCodificacion" Width="30%" Height="100px" class="btn btn-default btn-md" BorderColor="#000000" Font-Bold="true" OnClick="btnGeneracionCodificacion_Click"></asp:Button>
                <asp:Button type="button" runat="server" Text="6 Papas" ID="btnGeneracion6papas" Width="30%" Height="100px" class="btn btn-default btn-md" BorderColor="#000000" Font-Bold="true" OnClick="btnGeneracion6papas_Click"></asp:Button>
                <asp:Button type="button" runat="server" Text="12 Papas" ID="btnGeneracion12papas" Width="30%" Height="100px" class="btn btn-default btn-md" BorderColor="#000000" Font-Bold="true" OnClick="btnGeneracion12papas_Click"></asp:Button>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-9 col-sm-offset-2">
                <asp:Button type="button" runat="server" Text="24 Papas" ID="btnGeneracion24papas" Width="30%" Height="100px" class="btn btn-default btn-md" BorderColor="#000000" Font-Bold="true" OnClick="btnGeneracion24papas_Click"></asp:Button>
                <asp:Button type="button" runat="server" Text="48 Papas" ID="btnGeneracion48papas" Width="30%" Height="100px" class="btn btn-default btn-md" BorderColor="#000000" Font-Bold="true" OnClick="btnGeneracion48papas_Click"></asp:Button>
                <asp:Button type="button" runat="server" Text="UPOV" ID="btnGeneracionUpov" Width="30%" Height="100px" class="btn btn-default btn-md" BorderColor="#000000" Font-Bold="true" OnClick="btnGeneracionUpov_Click"></asp:Button>
            </div>
        </div>
    </div>
</asp:Content>
