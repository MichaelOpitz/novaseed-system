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
            <div class="col-sm-4">
                <div class="input-group" style="float: right;">
                    <asp:TextBox ID="txtBuscarClones" runat="server" CssClass="form-control" placeholder="Buscar clon" Width="150px" />
                    <asp:LinkButton ID="btnBuscarClones" runat="server" CssClass="btn btn-info">
                       <span class="glyphicon glyphicon-search"></span>
                    </asp:LinkButton>
                </div>
            </div>
        </div>
        <br />
        <div class="row">
            <asp:Button type="button" runat="server" ID="btnAgregarCodificacion" class="btn btn-danger btn-block" Style="border-color: #000000" Text="Codificar" OnClick="btnAgregarCodificacion_Click"></asp:Button>
        </div>
        <div class="row">
            <asp:GridView ID="gdvClones" runat="server"
                DataKeyNames="id_clones"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
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

                <Columns>
                    <%--botones de acción sobre los registros...--%>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="200px">
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

                        <HeaderStyle Width="200px"></HeaderStyle>

                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>
                    <asp:BoundField DataField="id_clones" HeaderText="ID" ReadOnly="true" />
                    <asp:BoundField DataField="codigo_variedad" HeaderText="Madre" ReadOnly="true" HeaderStyle-Width="110px"/>
                    <asp:BoundField DataField="nombre_madre" HeaderText="Nombre Madre" ReadOnly="true" />
                    <asp:BoundField DataField="pad_codigo_variedad" HeaderText="Padre" ReadOnly="true" HeaderStyle-Width="110px"/>
                    <asp:BoundField DataField="nombre_padre" HeaderText="Nombre Padre" ReadOnly="true" />
                    <asp:BoundField DataField="posicion_clon" HeaderText="Posicion" />
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="50px" HeaderText="Fertilidad">
                        <ItemTemplate>
                            <asp:DropDownList type="button" ID="ddlClonesFertilidad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        </ItemTemplate>

                        <HeaderStyle Width="70px"></HeaderStyle>

                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>

                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="50px" HeaderText="Imagen">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkClonImagen" runat="server" AutoPostBack="true" Enabled="false" />
                        </ItemTemplate>
                        <HeaderStyle Width="70px"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>

                    <asp:BoundField DataField="azul_clon" HeaderText="Azules" />
                    <asp:BoundField DataField="roja_clon" HeaderText="Rojas" />
                    <asp:BoundField DataField="amarilla_clon" HeaderText="Amarillas" />
                    <asp:BoundField DataField="bicolor_clon" HeaderText="Bicolor" />                    
                </Columns>
            </asp:GridView>

        </div>
    </div>
</asp:Content>
