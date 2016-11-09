<%@ Page Title="Cruzamiento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Cruzamiento.aspx.cs" Inherits="Project.Novaseed.Cruzamiento" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row">
            <div class="col-sm-8">
                <h2><asp:Label id="lblCruzamientoAño" runat="server" Font-Bold="true" Text="Cruzamientos"/></h2>
            </div>
            <div class="col-sm-4">
                <div class="input-group" style="float: right;">
                    <asp:TextBox ID="txtBuscarCruzamiento" runat="server" CssClass="form-control" placeholder="Buscar cruzamiento" Width="70%" />
                    <asp:LinkButton ID="btnBuscarCruzamiento" runat="server" CssClass="btn btn-info">
                       <span class="glyphicon glyphicon-search"></span>
                    </asp:LinkButton>
                </div>
            </div>
        </div>
        <br />
        <div class="row">
            <asp:Button type="button" runat="server" ID="btnAgregarVasos" class="btn btn-primary btn-block" Style="border-color: #000000" Text="Agregar a Vasos" OnClick="btnAgregarVasos_Click" OnClientClick="return confirm('Agregará a Vasos\n¿Está seguro?');"></asp:Button>
        </div>
        <div class="row">
            <asp:GridView ID="gdvCruzamiento" runat="server"
                DataKeyNames="id_cruzamiento"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
                OnRowDataBound="OnRowDataBound"
                OnRowUpdating="CruzamientoGridView_RowUpdating"
                OnRowCancelingEdit="CruzamientoGridView_RowCancelingEdit"
                OnRowEditing="CruzamientoGridView_RowEditing"
                OnRowDeleting="CruzamientoGridView_RowDeleting">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay cruzamientos en el año seleccionado!  
                </EmptyDataTemplate>

                <Columns>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="50px" HeaderText="Agregar">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkVasosAgregar" runat="server" AutoPostBack="true" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <%--botones de acción sobre los registros...--%>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="180px">
                        <ItemTemplate>
                            <%--Botones de eliminar y editar cliente...--%>
                            <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Eliminar cruzamiento?\nSi lo hace eliminará todos los registros de etapas avanzadas');" />
                            <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" CommandName="Edit" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <%--Botones de grabar y cancelar la edición de registro...--%>
                            <asp:Button ID="btnUpdate" runat="server" Text="Grabar" CssClass="btn btn-success" CommandName="Update" OnClientClick="return confirm('¿Desea modificar cruzamiento?');" />
                            <asp:Button ID="btnCancel" runat="server" Text="Cancelar" CssClass="btn btn-default" CommandName="Cancel" />
                        </EditItemTemplate>

                        <HeaderStyle Width="200px"></HeaderStyle>

                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>
                    <asp:BoundField DataField="id_cruzamiento" HeaderText="ID" ReadOnly="true" />
                    <asp:BoundField DataField="codigo_variedad" HeaderText="Madre" ReadOnly="true" HeaderStyle-Width="100px"/>
                    <asp:BoundField DataField="nombre_madre" HeaderText="Nombre Madre" ReadOnly="true" />
                    <asp:BoundField DataField="pad_codigo_variedad" HeaderText="Padre" ReadOnly="true" HeaderStyle-Width="100px"/>
                    <asp:BoundField DataField="nombre_padre" HeaderText="Nombre Padre" ReadOnly="true" />
                    <asp:BoundField DataField="ubicacion_madre" HeaderText="Ubicación Madre" />
                    <asp:BoundField DataField="ubicacion_padre" HeaderText="Ubicación Padre" />
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="70px" HeaderText="Fertilidad">
                        <ItemTemplate>
                            <asp:DropDownList type="button" ID="ddlCruzamientoFertilidad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="50px" HeaderText="Flor">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkCruzamientoFlor" runat="server" AutoPostBack="true" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="bayas" HeaderText="Bayas" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
