<%@ Page Title="Ingresar Producción" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ProduccionIngresar.aspx.cs" Inherits="Project.Novaseed.ProduccionIngresar" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row">
            <div class="col-sm-5 col-sm-offset-2">
                <h3>
                    <asp:Label ID="lblProduccionVariedad" runat="server" Font-Bold="true" Text="Variedad Seleccionada: " /></h3>
            </div>
            <div class="col-sm-5">
                <h3>
                    <asp:Label ID="lblProduccionAño" runat="server" Font-Bold="true" Text="Temporada: " /></h3>
            </div>
        </div>        

        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">Categoría y Productor</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-3 col-sm-offset-2">
                        <asp:DropDownList type="button" ID="ddlProduccionCiudad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Ciudad</span>
                    </div>                    
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddlProduccionCategoriaProduccion" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Categoría Producción</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddlProduccionProductor" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Productor</span>
                    </div>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">Totales</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-2 col-sm-offset-1">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Cantidad Total (Ton)" ID="txtProduccionCantidadTotal"></asp:TextBox>
                        <span class="help-block">Cantidad Total (Ton)</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Cantidad Productor (Ton)" ID="txtProduccionCantidadProductor"></asp:TextBox>
                        <span class="help-block">Cantidad Productor (Ton)</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Superficie (Ton/Ha)" ID="txtProduccionSuperficie"></asp:TextBox>
                        <span class="help-block">Superficie (Ton/Ha)</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Cosecha (Ton)" ID="txtProduccionCosecha"></asp:TextBox>
                        <span class="help-block">Cosecha (Ton)</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:CheckBox ID="chkProduccionLicencia" runat="server" AutoPostBack="true" Text="Licencia" />
                    </div>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="row" style="text-align: center">
            <asp:Button type="button" runat="server" Text="Guardar" ID="btnProduccionGuardar" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea guardar los cambios?');" OnClick="btnProduccionGuardar_Click" ></asp:Button>
            <asp:Button type="button" runat="server" Text="Cancelar" ID="btnProduccionCancelar" class="btn btn-danger btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea cancelar los cambios?');" OnClick="btnProduccionCancelar_Click" ></asp:Button>
        </div>

    </div>
</asp:Content>
