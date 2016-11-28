<%@ Page Title="Producción" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ProduccionFiltrar.aspx.cs" Inherits="Project.Novaseed.ProduccionFiltrar" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row" style="font-size: x-large; height: 40px; text-align: center">
            <strong>Filtrar Producción</strong>
        </div>
        <br />
        <div class="row">
            <asp:Button type="button" runat="server" ID="btnMenuProduccionFiltrarPorVariedad" class="btn btn-primary btn-block" Style="border-color: #000000" Text="Por Variedad" OnClick="btnMenuProduccionFiltrarPorVariedad_Click"></asp:Button>
        </div>
        <div class="panel panel-info">
            <div class="panel-heading" style="text-align: center">Filtrar por Productor, Ciudad y/o Categoría</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-2">
                        <asp:DropDownList type="button" ID="ddlProduccionProductor" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Productor</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddlProduccionCiudad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Ciudad</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddlProduccionCategoriaProduccion" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Categoría Producción</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:Button type="button" runat="server" class="btn btn-danger btn-block" ID="btnProduccionFiltrarPorProductorCiudadCategoria" Style='border-color: #000000' Text="Buscar" OnClick="btnProduccionFiltrarPorProductorCiudadCategoria_Click"></asp:Button>
                    </div>
                </div>
            </div>
        </div>


    </div>
</asp:Content>

