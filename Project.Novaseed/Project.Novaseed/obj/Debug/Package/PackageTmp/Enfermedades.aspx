<%@ Page Title="Enfermedades" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Enfermedades.aspx.cs" Inherits="Project.Novaseed.Enfermedades" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row" style="text-align: center">
            <h3>
                <asp:Label ID="lblEnfermedadesAgregar" runat="server" Font-Bold="true" Text="Enfermedades" /></h3>
        </div>
        <br />
        <div class="row" style="text-align: center">
            <h5>
                <asp:Label ID="lblEnfermedadesError" runat="server" Font-Bold="true" Text="" ForeColor="Red" /></h5>
        </div>


        <ul class="nav nav-tabs">
            <li><a data-toggle="tab" href="#home">Agregar Enfermedad</a></li>
            <li class="active"><a data-toggle="tab" href="#menu1">Modificar y Eliminar Enfermedad</a></li>
        </ul>

        <div class="tab-content">
            <div id="home" class="tab-pane fade">

                <div class="row" style="margin-top: 20px">
                    <div class="col-sm-3 col-sm-offset-3">
                        <asp:RegularExpressionValidator ID="reEnfermedades" runat="server" ValidationExpression=".{2,99}" ErrorMessage="Debe ser entre 2 y 99" ControlToValidate="txtEnfermedades" ForeColor="Red" ValidationGroup="ingresarEnfermedades"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Ingrese Enfermedades" ID="txtEnfermedades"></asp:TextBox>
                        <span class="help-block">Enfermedades</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="reEnfermedades2" runat="server" ValidationExpression="." ErrorMessage="Debe ser entre 2 y 99" ControlToValidate="txtEnfermedades" ForeColor="White"></asp:RegularExpressionValidator>
                        <asp:Button type="button" runat="server" Text="Guardar" ID="btnEnfermedadesGuardar" Width="100%" class="btn btn-primary btn-md" BorderColor="#000000" ValidationGroup="ingresarEnfermedades" CausesValidation="true" OnClientClick="return confirm('¿Desea guardar los cambios?');" OnClick="btnEnfermedadesGuardar_Click"></asp:Button>
                    </div>
                </div>

            </div>
            <div id="menu1" class="tab-pane fade in active">

                <div class="row">
                    <asp:GridView ID="gdvEnfermedades" runat="server"
                        DataKeyNames="id_enfermedad"
                        AutoGenerateColumns="False"
                        CssClass="table table-bordered bs-table"
                        AllowPaging="True"
                        AllowSorting="True"
                        OnRowDataBound="OnRowDataBound"
                        PageSize="8"
                        OnDataBound="EnfermedadesGridView_DataBound"
                        OnPageIndexChanging="EnfermedadesGridView_PageIndexChanging"
                        OnRowUpdating="EnfermedadesGridView_RowUpdating"
                        OnRowCancelingEdit="EnfermedadesGridView_RowCancelingEdit"
                        OnRowEditing="EnfermedadesGridView_RowEditing"
                        OnRowDeleting="EnfermedadesGridView_RowDeleting">

                        <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#ffffcc" />
                        <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                        <EmptyDataTemplate>
                            ¡No existen enfermedades!  
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

                        <SelectedRowStyle Font-Bold="True" />
                        <Columns>

                            <%--botones de acción sobre los registros...--%>
                            <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="180px">
                                <ItemTemplate>
                                    <%--Botones de eliminar y editar cliente...--%>
                                    <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Eliminar la enfermedad?');" />
                                    <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" CommandName="Edit" />
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <%--Botones de grabar y cancelar la edición de registro...--%>
                                    <asp:Button ID="btnUpdate" runat="server" Text="Grabar" CssClass="btn btn-success" CommandName="Update" OnClientClick="return confirm('¿Desea modificar enfermedad?');" />
                                    <asp:Button ID="btnCancel" runat="server" Text="Cancelar" CssClass="btn btn-default" CommandName="Cancel" />
                                </EditItemTemplate>

                                <HeaderStyle Width="200px"></HeaderStyle>

                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                            </asp:TemplateField>

                            <asp:BoundField DataField="id_enfermedad" HeaderText="ID" ReadOnly="true" />
                            <asp:BoundField DataField="nombre_enfermedad" HeaderText="Enfermedad" ControlStyle-Width="100%" />

                        </Columns>
                    </asp:GridView>
                </div>

            </div>
        </div>

    </div>
</asp:Content>

