<%@ Page Title="Producción" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ProduccionFiltrarVariedad.aspx.cs" Inherits="Project.Novaseed.ProduccionFiltrarVariedad" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row">
            <h2>
                <asp:Label ID="lblProduccionAño" runat="server" Font-Bold="true" Text="Filtrar por Variedad en Producción" /></h2>
        </div>
        <br />
        <div class="row">
            <asp:GridView ID="gdvProduccion" runat="server"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True" 
                OnRowDataBound="OnRowDataBound">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay producción en el año seleccionado!  
                </EmptyDataTemplate>

                <Columns>
                    <asp:BoundField DataField="nombre_productor" HeaderText="Productor" ReadOnly="true" />
                    <asp:BoundField DataField="nombre_ciudad" HeaderText="Ciudad" ReadOnly="true" />
                    <asp:BoundField DataField="codigo_variedad" HeaderText="Código Variedad" ReadOnly="true" />
                    <asp:BoundField DataField="nombre_categoria_produccion" HeaderText="Categoría Producción" ReadOnly="true" />
                    <asp:BoundField DataField="prod_cantidad_total" HeaderText="Cantidad Total" ReadOnly="true" />
                    <asp:BoundField DataField="cantidad_productor" HeaderText="Cantidad Productor" ReadOnly="true" />
                    <asp:BoundField DataField="superficie_produccion" HeaderText="Superficie" ReadOnly="true" />
                    <asp:BoundField DataField="cosecha_produccion" HeaderText="Cosecha" ReadOnly="true" />
                    <asp:BoundField DataField="licencia_produccion" HeaderText="Licencia" ReadOnly="true" /> 
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
