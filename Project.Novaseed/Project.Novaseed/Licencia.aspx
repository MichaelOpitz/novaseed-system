<%@ Page Title="Licencia" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Licencia.aspx.cs" Inherits="Project.Novaseed.Licencia" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row" style="text-align:center">
            <h2>
                <asp:Label ID="lblLicencia" runat="server" Font-Bold="true" Text="Licencia" /></h2>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-4 col-sm-offset-1">
                <asp:DropDownList type="button" ID="ddlLicenciaAño" runat="server" class="btn btn-primary dropdown-toggle" Width="70%" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                <span class="help-block">¡Seleccione año para ver las licencias!</span>
            </div>
            <div class="col-sm-4">
                <asp:Button type="button" runat="server" class="btn btn-danger btn-block" ID="btnLicencia" Style='border-color: #000000' Text="Buscar Licencias" OnClick="btnLicencia_Click" ></asp:Button>
            </div>
        </div>
        <br />
        <div class="row">
            <asp:GridView ID="gdvLicencia" runat="server"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay Licencias en el año seleccionado!  
                </EmptyDataTemplate>

                <Columns>
                    <asp:BoundField DataField="nombre_productor" HeaderText="Productor" ReadOnly="true" />
                    <asp:BoundField DataField="nombre_ciudad" HeaderText="Ciudad" ReadOnly="true" />
                    <asp:BoundField DataField="codigo_variedad" HeaderText="Código Variedad" ReadOnly="true" />
                    <asp:BoundField DataField="nombre_variedad" HeaderText="Nombre Variedad" ReadOnly="true" />
                    <asp:BoundField DataField="nombre_categoria_produccion" HeaderText="Categoría Producción" ReadOnly="true" />
                    <asp:BoundField DataField="prod_cantidad_total" HeaderText="Cantidad Total" ReadOnly="true" />
                    <asp:BoundField DataField="cantidad_productor" HeaderText="Cantidad Productor" ReadOnly="true" />
                    <asp:BoundField DataField="superficie_produccion" HeaderText="Superficie" ReadOnly="true" />
                    <asp:BoundField DataField="cosecha_produccion" HeaderText="Cosecha" ReadOnly="true" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

