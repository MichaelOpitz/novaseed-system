<%@ Page Title="Usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="UsuarioEliminar.aspx.cs" Inherits="Project.Novaseed.UsuarioEliminar" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row" style="text-align: center">
            <h2>
                <asp:Label ID="lblUsuarioEliminar" runat="server" Font-Bold="true" Text="Eliminar Usuario" /></h2>
        </div>
        <hr />
        <div class="row" style="text-align: center">
            <h5>
                <asp:Label ID="lblUsuarioError" runat="server" Font-Bold="true" Text="" ForeColor="Red" /></h5>
        </div>
        <div class="row">
            <asp:GridView ID="gdvUsuario" runat="server"                
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
                OnRowDeleting="UsuarioGridView_RowDeleting">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay usuarios en el sistema!
                </EmptyDataTemplate>

                <Columns>
                    <%--botones de acción sobre los registros...--%>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="180px">
                        <ItemTemplate>
                            <%--Botones de eliminar y editar cliente...--%>
                            <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Desea eliminar el usuario seleccionado?');" />                            
                        </ItemTemplate>
                        <HeaderStyle Width="200px"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>

                    <asp:BoundField DataField="rol" HeaderText="Rol" ReadOnly="true" />
                    <asp:BoundField DataField="dv" HeaderText="DV" ReadOnly="true" HeaderStyle-Width="30px"/>
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" ReadOnly="true" />
                    <asp:BoundField DataField="apellido" HeaderText="Apellido" ReadOnly="true" />
                    <asp:BoundField DataField="nombre_cargo" HeaderText="Nombre Cargo" ReadOnly="true" />
                    <asp:BoundField DataField="usuario_persona" HeaderText="Usuario" ReadOnly="true" />
                    
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
