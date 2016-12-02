<%@ Page Title="Menú Producción" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="MenuProduccion.aspx.cs" Inherits="Project.Novaseed.MenuProduccion" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row" style="font-size: x-large; height: 40px; text-align: center">
            <strong>Menú Producción</strong>
        </div>
        <div class="row" style="text-align: center; margin-top: 20px">
            <asp:DropDownList type="button" ID="ddlProduccionAño" runat="server" class="btn btn-primary dropdown-toggle" Width="30%" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
            </asp:DropDownList>
            <span class="help-block">¡Seleccione un año para ver la producción!</span>
        </div>
        <br />
        <div class="row" style="height: auto; text-align: center">
            <asp:Button type="button" runat="server" class="btn btn-default" ID="btnMenuProduccionIngresar" BackColor="LightGray" Style='width: 160px; height: 140px; border-color: #000000' Text="Modificar Producción" OnClick="btnMenuProduccionIngresar_Click"></asp:Button>
            <asp:Button type="button" runat="server" class="btn btn-default" ID="btnMenuProduccionFiltrar" BackColor="LightGray" Style='width: 160px; height: 140px; border-color: #000000' Text="Filtrar Producción" OnClick="btnMenuProduccionFiltrar_Click"></asp:Button>
        </div>
        <br />
        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">Estadísticas de las que pueden o tienen producción</div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-sm-3">
                        <asp:Button type="button" runat="server" class="btn btn-info btn-block" ID="btnEstadisticaPorcentaje" Style='color: black; border-color: #000000' Text="Ranking Variedad" OnClick="btnEstadisticaPorcentaje_Click"></asp:Button>
                    </div>
                    <div class="col-sm-3">
                        <asp:Button type="button" runat="server" class="btn btn-info btn-block" ID="btnEstadisticaCiudad" Style='color: black; border-color: #000000' Text="Ciudad" OnClick="btnEstadisticaCiudad_Click"></asp:Button>
                    </div>
                    <div class="col-sm-3">
                        <asp:Button type="button" runat="server" class="btn btn-info btn-block" ID="btnEstadisticaDestino" Style='color: black; border-color: #000000' Text="Destino" OnClick="btnEstadisticaDestino_Click"></asp:Button>
                    </div>
                    <div class="col-sm-3">
                        <asp:Button type="button" runat="server" class="btn btn-info btn-block" ID="btnEstadisticaFertilidad" Style='color: black; border-color: #000000' Text="Fertilidad" OnClick="btnEstadisticaFertilidad_Click"></asp:Button>
                    </div>
                </div>
            </div>
        </div>

        <div class="row" style="text-align:center">
            <asp:Chart ID="chartProduccion" runat="server" Height="513px" Width="933px"
                Palette="SeaGreen">
                <Series>
                    <asp:Series Name="Series1" Font="Microsoft Sans Serif, 12pt" Label="#VAL"
                        Legend="Series" LegendText="Series" XValueMember="codigo"
                        YValueMembers="porcentaje" YValuesPerPoint="6">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
                <Legends>
                    <asp:Legend Font="Microsoft Sans Serif, 12pt" IsTextAutoFit="False"
                        Name="Series">
                    </asp:Legend>
                </Legends>
            </asp:Chart>
        </div>


    </div>
</asp:Content>
