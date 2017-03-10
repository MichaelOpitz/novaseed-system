<%@ Page Title="Vasos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Vasos.aspx.cs" Inherits="Project.Novaseed.Vasos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="progress progress-striped active">
            <div class="progress-bar" role="progressbar"
                aria-valuenow="30" aria-valuemin="0" aria-valuemax="100" style="width: 30%">
                Etapa 2, Vasos                
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <h2>
                    <asp:Label ID="lblVasosAño" runat="server" Font-Bold="true" Text="Vasos" Font-Names="versalitas" /></h2>
            </div>
            <div class="col-sm-3 col-sm-offset-1">
                <asp:TextBox type="text" runat="server" class="form-control" ID="txtCantidadTotalVasos" Width="80%" ReadOnly="true" Style="background-color: #ffd800; border-color: #000000" Font-Bold="true"></asp:TextBox>
                <span class="help-block">Cantidad Total de Vasos por Año</span>
            </div>
            <div class="col-sm-4" style="text-align: right">
                <h6>
                    <asp:Label ID="lblVasosLeyendaVerde" runat="server" Text="Verde significa que está en etapas avanzadas" ForeColor="Green" Font-Italic="true" /></h6>
                <h6>
                    <asp:Label ID="lblVasosLeyendaRojo" runat="server" Text="Rojo significa que esta es su última etapa" ForeColor="Red" Font-Italic="true" /></h6>
            </div>
        </div>
        <br />
        <div class="row">
            <h5>
                <asp:Label ID="lblVasosError" runat="server" Font-Bold="true" Text="" ForeColor="Red" /></h5>
        </div>
        <div class="row">
            <asp:GridView ID="gdvVasos" runat="server" Width="100%"
                DataKeyNames="id_vasos"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
                PageSize="8"
                OnDataBound="VasosGridView_DataBound"
                OnPageIndexChanging="VasosGridView_PageIndexChanging"
                OnRowDataBound="OnRowDataBound"
                OnRowUpdating="VasosGridView_RowUpdating"
                OnRowCancelingEdit="VasosGridView_RowCancelingEdit"
                OnRowEditing="VasosGridView_RowEditing"
                OnRowDeleting="VasosGridView_RowDeleting">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay vasos en el año seleccionado!  
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
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="5%" HeaderText="Agregar">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkClonesAgregar" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <%--botones de acción sobre los registros...--%>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="20%" HeaderText="Acción">
                        <ItemTemplate>
                            <%--Botones de eliminar y editar cliente...--%>
                            <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Eliminar vaso?\nSi lo hace eliminará todos los registros de etapas avanzadas');" />
                            <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" CommandName="Edit" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <%--Botones de grabar y cancelar la edición de registro...--%>
                            <asp:Button ID="btnUpdate" runat="server" Text="Grabar" CssClass="btn btn-success" CommandName="Update" OnClientClick="return confirm('¿Desea modificar el vaso?');" />
                            <asp:Button ID="btnCancel" runat="server" Text="Cancelar" CssClass="btn btn-default" CommandName="Cancel" />
                        </EditItemTemplate>
                        <HeaderStyle Width="20%"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>

                    <asp:BoundField DataField="id_vasos" HeaderText="ID" ReadOnly="true" HeaderStyle-Width="5%" />
                    <asp:BoundField DataField="codigo_variedad" HeaderText="Madre" ReadOnly="true" HeaderStyle-Width="10%" />
                    <asp:BoundField DataField="nombre_madre" HeaderText="Nombre Madre" ReadOnly="true" HeaderStyle-Width="10%" />
                    <asp:BoundField DataField="pad_codigo_variedad" HeaderText="Padre" ReadOnly="true" HeaderStyle-Width="10%" />
                    <asp:BoundField DataField="nombre_padre" HeaderText="Nombre Padre" ReadOnly="true" HeaderStyle-Width="10%" />
                    <asp:BoundField DataField="ubicacion_vasos" HeaderText="Ubicación" HeaderStyle-Width="5%" ControlStyle-Width="100%" />
                    <asp:BoundField DataField="cantidad_vasos" HeaderText="Cantidad Total" HeaderStyle-Width="5%" ControlStyle-Width="100%" />
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="5%" HeaderText="Fertilidad">
                        <ItemTemplate>
                            <asp:DropDownList type="button" ID="ddlVasosFertilidad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="10%" HeaderText="Colores">
                        <ItemTemplate>
                            <asp:HyperLink ID="hlkVasosVerColores" runat="server" Text="Cantidad Colores" data-toggle="modal" data-target="#colores"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <div class="row" style="text-align: right">
            <asp:Button type="button" runat="server" ID="btnAgregarClones" class="btn btn-success btn-md" Width="15%" Style="border-color: #000000" Text="Agregar a Clones" OnClick="btnAgregarClones_Click" OnClientClick="return confirm('Agregará a Clones\n¿Está seguro?');"></asp:Button>
            <asp:Button type="button" runat="server" ID="btnCancelarClones" class="btn btn-danger btn-md" Width="15%" Style="border-color: #000000" Text="Volver al Menú" OnClick="btnCancelarClones_Click" OnClientClick="return confirm('¿Desea volver al menú?');"></asp:Button>
        </div>

        <!-- Modal -->
        <div id="colores" class="modal fade" role="dialog">
            <div class="modal-dialog">

                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Ver/Modificar Colores</h4>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-sm-6">
                                <asp:TextBox type="text" runat="server" class="form-control" ID="txtVasosAzul" Width="80%" Placeholder="Cantidad Azul"></asp:TextBox>
                                <span class="help-block">Cantidad de azules</span>
                            </div>
                            <div class="col-sm-6">
                                <asp:TextBox type="text" runat="server" class="form-control" ID="txtVasosRoja" Width="80%" Placeholder="Cantidad Roja"></asp:TextBox>
                                <span class="help-block">Cantidad de rojas</span>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-6">
                                <asp:TextBox type="text" runat="server" class="form-control" ID="txtVasosAmarilla" Width="80%" Placeholder="Cantidad Amarilla"></asp:TextBox>
                                <span class="help-block">Cantidad de amarillas</span>
                            </div>
                            <div class="col-sm-6">
                                <asp:TextBox type="text" runat="server" class="form-control" ID="txtVasosBicolor" Width="80%" Placeholder="Cantidad Bicolor"></asp:TextBox>
                                <span class="help-block">Cantidad de bicolores</span>
                            </div>
                        </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                </div>
            </div>

        </div>
    </div>

    </div>
</asp:Content>
