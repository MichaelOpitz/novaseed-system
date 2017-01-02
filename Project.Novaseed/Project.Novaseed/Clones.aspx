<%@ Page Title="Clones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Clones.aspx.cs" Inherits="Project.Novaseed.Clones" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row">
            <div class="col-sm-4">
                <h2>
                    <asp:Label ID="lblClonesAño" runat="server" Font-Bold="true" Text="Clones" /></h2>
            </div>
        </div>
        <br />
        <div class="row">
            <h5>
                <asp:Label ID="lblClonesError" runat="server" Font-Bold="true" Text="" ForeColor="Red" /></h5>
        </div>
        <div class="row">
            <asp:Button type="button" runat="server" ID="btnAgregarCodificacion" class="btn btn-danger btn-block" Style="border-color: #000000" Text="Codificar" OnClick="btnAgregarCodificacion_Click"></asp:Button>
        </div>
        <div class="row">
            <asp:GridView ID="gdvClones" runat="server" Width="100%"
                DataKeyNames="id_clones"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
                PageSize="8"
                OnDataBound="ClonesGridView_DataBound"
                OnPageIndexChanging="ClonesGridView_PageIndexChanging"
                OnRowDataBound="OnRowDataBound"
                OnRowUpdating="ClonesGridView_RowUpdating"
                OnRowCancelingEdit="ClonesGridView_RowCancelingEdit"
                OnRowEditing="ClonesGridView_RowEditing"
                OnRowDeleting="ClonesGridView_RowDeleting">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay clones en el año seleccionado!  
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
                    <%--botones de acción sobre los registros...--%>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="18%">
                        <ItemTemplate>
                            <%--Botones de eliminar y editar cliente...--%>
                            <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Eliminar clon?\nSi lo hace eliminará todos los registros de etapas avanzadas');" />
                            <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" CommandName="Edit" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <%--Botones de grabar y cancelar la edición de registro...--%>
                            <asp:Button ID="btnUpdate" runat="server" Text="Grabar" CssClass="btn btn-success" CommandName="Update" OnClientClick="return confirm('¿Desea modificar el clon?');" />
                            <asp:Button ID="btnCancel" runat="server" Text="Cancelar" CssClass="btn btn-default" CommandName="Cancel" />
                        </EditItemTemplate>

                        <HeaderStyle Width="18%"></HeaderStyle>

                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>
                    <asp:BoundField DataField="id_clones" HeaderText="ID" ReadOnly="true" HeaderStyle-Width="5%" />
                    <asp:BoundField DataField="codigo_variedad" HeaderText="Madre" ReadOnly="true" HeaderStyle-Width="10%" />
                    <asp:BoundField DataField="nombre_madre" HeaderText="Nombre Madre" ReadOnly="true" HeaderStyle-Width="12%" />
                    <asp:BoundField DataField="pad_codigo_variedad" HeaderText="Padre" ReadOnly="true" HeaderStyle-Width="10%" />
                    <asp:BoundField DataField="nombre_padre" HeaderText="Nombre Padre" ReadOnly="true" HeaderStyle-Width="12%" />
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="10%" HeaderText="Fertilidad">
                        <ItemTemplate>
                            <asp:DropDownList type="button" ID="ddlClonesFertilidad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        </ItemTemplate>                                                
                    </asp:TemplateField>
                    <asp:BoundField DataField="azul_clon" HeaderText="Azules" HeaderStyle-Width="5%" ControlStyle-Width="100%" />
                    <asp:BoundField DataField="roja_clon" HeaderText="Rojas" HeaderStyle-Width="5%" ControlStyle-Width="100%" />
                    <asp:BoundField DataField="amarilla_clon" HeaderText="Amarillas" HeaderStyle-Width="5%" ControlStyle-Width="100%" />
                    <asp:BoundField DataField="bicolor_clon" HeaderText="Bicolor" HeaderStyle-Width="5%" ControlStyle-Width="100%" />
                </Columns>
            </asp:GridView>

        </div>
    </div>
</asp:Content>
