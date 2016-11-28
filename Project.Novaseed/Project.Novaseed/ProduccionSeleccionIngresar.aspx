<%@ Page Title="Producción" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ProduccionSeleccionIngresar.aspx.cs" Inherits="Project.Novaseed.ProduccionSeleccionIngresar" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row">
            <h2>
                <asp:Label ID="lblProduccionAño" runat="server" Font-Bold="true" Text="Producción" /></h2>
        </div>
        <br />
        <div class="row">
            <asp:GridView ID="gdvProduccion" runat="server"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
                OnRowDataBound="OnRowDataBound"
                OnSelectedIndexChanged="gdvProduccion_SelectedIndexChanged">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay producción en el año seleccionado!  
                </EmptyDataTemplate>

                <Columns>
                    <asp:BoundField DataField="nombre_variedad" HeaderText="Nombre Variedad" ReadOnly="true" />
                    <asp:BoundField DataField="codigo_variedad" HeaderText="Código Variedad" ReadOnly="true" />
                    <asp:CommandField SelectText="Producción" ButtonType="Link" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
