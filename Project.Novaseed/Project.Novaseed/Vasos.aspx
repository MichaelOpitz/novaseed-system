<%@ Page Title="Vasos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Vasos.aspx.cs" Inherits="Project.Novaseed.Vasos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row">
            <div class="col-sm-4">
                <h2><asp:Label id="lblVasosAño" runat="server" Font-Bold="true" Text="Vasos"/></h2>
            </div>
            <div class="col-sm-3 col-sm-offset-1">
                <asp:TextBox type="text" runat="server" class="form-control" ID="txtCantidadTotalVasos" Width="80%" ReadOnly="true" Style="background-color: #ffd800; border-color: #000000" Font-Bold="true"></asp:TextBox>
                <span class="help-block">Cantidad Total de Vasos por Año</span>
            </div>
            <div class="col-sm-4">
                <div class="input-group" style="float: right;">
                    <asp:TextBox ID="txtBuscarVasos" runat="server" CssClass="form-control" placeholder="Buscar vaso" Width="150px" />
                    <asp:LinkButton ID="btnBuscarVaso" runat="server" CssClass="btn btn-info">
                       <span class="glyphicon glyphicon-search"></span>
                    </asp:LinkButton>
                </div>
            </div>
        </div>
        <br />
        <div class="row">
            <asp:Button type="button" runat="server" id="btnAgregarClones" class="btn btn-primary btn-block" Style="border-color: #000000" Text="Agregar a Clones" OnClick="btnAgregarClones_Click" OnClientClick="return confirm('Agregará a Clones\n¿Está seguro?');"></asp:Button>
        </div>
        <div class="row">
            <asp:GridView ID="gdvVasos" runat="server"
                DataKeyNames="id_vasos"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
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

                <Columns>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="70px" HeaderText="Agregar">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkClonesAgregar" runat="server" AutoPostBack="true" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <%--botones de acción sobre los registros...--%>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="200px">
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

                        <HeaderStyle Width="200px"></HeaderStyle>

                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>
                    <asp:BoundField DataField="id_vasos" HeaderText="ID" ReadOnly="true" />
                    <asp:BoundField DataField="codigo_variedad" HeaderText="Madre" ReadOnly="true" HeaderStyle-Width="100px"/>
                    <asp:BoundField DataField="nombre_madre" HeaderText="Nombre Madre" ReadOnly="true" />
                    <asp:BoundField DataField="pad_codigo_variedad" HeaderText="Padre" ReadOnly="true" HeaderStyle-Width="100px"/>
                    <asp:BoundField DataField="nombre_padre" HeaderText="Nombre Padre" ReadOnly="true" />
                    <asp:BoundField DataField="ubicacion_vasos" HeaderText="Ubicación" />
                    <asp:BoundField DataField="cantidad_vasos" HeaderText="Cantidad Vasos" />
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="70px" HeaderText="Fertilidad">
                        <ItemTemplate>
                            <asp:DropDownList type="button" ID="ddlVasosFertilidad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="azul_vasos" HeaderText="Azules" />
                    <asp:BoundField DataField="roja_vasos" HeaderText="Rojas" />
                    <asp:BoundField DataField="amarilla_vasos" HeaderText="Amarillas" />
                    <asp:BoundField DataField="bicolor_vasos" HeaderText="Bicolor" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
