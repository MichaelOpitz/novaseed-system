<%@ Page Title="Licencia" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Licencia.aspx.cs" Inherits="Project.Novaseed.Licencia" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row" style="text-align:center">
            <h2>
                <asp:Label ID="lblLicencia" runat="server" Font-Bold="true" Text="Licencia" Font-Names="versalitas"/></h2>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-4">
                <asp:DropDownList type="button" ID="ddlLicenciaAño" runat="server" class="btn btn-primary dropdown-toggle" Width="70%" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                <span class="help-block">¡Seleccione año para ver las licencias!</span>
            </div>
            <div class="col-sm-8">
                <asp:Button type="button" runat="server" class="btn btn-success btn-block" ID="btnLicencia" Style='border-color: #000000' Text="Buscar Licencias" OnClick="btnLicencia_Click" ></asp:Button>
            </div>
        </div>
        <br />
        <div class="row">
            <asp:GridView ID="gdvLicencia" runat="server"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
                PageSize="8"
                OnDataBound="LicenciaGridView_DataBound"
                OnPageIndexChanging="LicenciaGridView_PageIndexChanging">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay Licencias en el año seleccionado!  
                </EmptyDataTemplate>

                <PagerTemplate>
                    <table runat="server" id="testTable1" style="width: 100%" class="k-grid td">
                        <tr>
                            <td class="col-md-8 pull-left">
                                <asp:Label ID="MessageLabel"
                                    Text="Página: "
                                    runat="server"
                                    Font-Bold="true" />
                                <asp:LinkButton ID="FirstLB" runat="server" CommandName="Page" CommandArgument="First" ToolTip="First" CssClass="btn-pager btn-default" OnClick="FirstLB_Click"> Inicio </asp:LinkButton>
                                <asp:LinkButton ID="PrevLB" runat="server" CommandName="Page" CommandArgument="Prev" ToolTip="Previous" CssClass="btn-pager btn-default" OnClick="PrevLB_Click"> Anterior </asp:LinkButton>
                                <asp:DropDownList runat="server" ID="PageDropDownList" AutoPostBack="true" EnableViewState="true" OnSelectedIndexChanged="PageDropDownList_SelectedIndexChanged" CssClass="selectpicker form-control-drp"></asp:DropDownList>

                                <asp:LinkButton ID="NextLB" runat="server" CommandName="Page" CommandArgument="Next" ToolTip="Next" CssClass="btn-pager btn-default" OnClick="NextLB_Click"> Siguiente </asp:LinkButton>
                                <asp:LinkButton ID="LastLB" runat="server" CommandName="Page" CommandArgument="Last" ToolTip="Last" CssClass="btn-pager btn-default" OnClick="LastLB_Click"> Final</asp:LinkButton>
                            </td>

                            <td class="col-md-4 pull-right">
                                <asp:Label ID="PageSizeLabel" runat="server" Text="Tamaño de página: " Font-Bold="true"></asp:Label>
                                <asp:DropDownList ID="ddlPageSize" runat="server" OnSelectedIndexChanged="ddlPageSize_SelectedIndexChanged" AutoPostBack="true" CssClass="selectpicker form-control-drp">
                                    <%-- <asp:ListItem Value="0" Text="0" />--%>
                                    <asp:ListItem Value="8" Text="8" />
                                    <asp:ListItem Value="10" Text="10" />
                                    <asp:ListItem Value="12" Text="12" />
                                </asp:DropDownList>
                            </td>
                            <td class="col-md-2">
                                <asp:Label ID="CurrentPageLabel" runat="server" />
                            </td>
                        </tr>
                    </table>
                </PagerTemplate>

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

