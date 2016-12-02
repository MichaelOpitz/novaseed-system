<%@ Page Title="Código de los Individuos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="CodigoIndividuos.aspx.cs" Inherits="Project.Novaseed.CodigoIndividuos" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row" >
            <div class="col-sm-3 col-sm-offset-1">
                <asp:TextBox ID="txtCodificacionMadre" runat="server" class="form-control" ReadOnly="true"></asp:TextBox>
                <span class="help-block">Código Madre</span>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txtCodificacionPadre" runat="server" class="form-control" ReadOnly="true"></asp:TextBox>
                <span class="help-block">Código Padre</span>
            </div>
            <div class="col-sm-3">
                <asp:TextBox ID="txtCodificacionAño" runat="server" class="form-control" ReadOnly="true"></asp:TextBox>
                <span class="help-block">Año de la codificación</span>
            </div>
        </div>        
        <hr />   
        <div class="row">
            <h5><asp:Label id="lblCodificacionError" runat="server" Font-Bold="true" Text="" ForeColor="Red"/></h5>
        </div>     
        <div class="row">
            <asp:Button type="button" runat="server" ID="btnAgregar6papas" class="btn btn-primary btn-block" Style="border-color: #000000" Text="Agregar a 6 Papas" OnClick="btnAgregar6papas_Click" OnClientClick="return confirm('¿Desea crear la temporada 6 papas para esta codificación?');"></asp:Button>
        </div>
        <div class="row">
            <asp:GridView ID="gdvCodigoIndividuos" runat="server"
                DataKeyNames="id_codificacion"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
                OnRowDataBound="OnRowDataBound"
                OnRowUpdating="CodigoIndividuosGridView_RowUpdating"
                OnRowCancelingEdit="CodigoIndividuosGridView_RowCancelingEdit"
                OnRowEditing="CodigoIndividuosGridView_RowEditing"
                OnRowDeleting="CodigoIndividuosGridView_RowDeleting">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay codificación en los padres seleccionados! 
                </EmptyDataTemplate>

                <Columns>
                    <%--botones de acción sobre los registros...--%>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="200px">
                        <ItemTemplate>
                            <%--Botones de eliminar y editar cliente...--%>
                            <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Eliminar la codificación?\nSi lo hace eliminará todos los registros de etapas avanzadas');" />
                            <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" CommandName="Edit" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <%--Botones de grabar y cancelar la edición de registro...--%>
                            <asp:Button ID="btnUpdate" runat="server" Text="Grabar" CssClass="btn btn-success" CommandName="Update" OnClientClick="return confirm('¿Desea modificar la codificación?');" />
                            <asp:Button ID="btnCancel" runat="server" Text="Cancelar" CssClass="btn btn-default" CommandName="Cancel" />
                        </EditItemTemplate>
                        <HeaderStyle Width="200px"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>
                    <asp:BoundField DataField="id_codificacion" HeaderText="ID" ReadOnly="true" />
                    <asp:BoundField DataField="codigo_individuo" HeaderText="Individuo" />

                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="70px" HeaderText="Agregar a 6 Papas">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkAgregar6Papas" runat="server" AutoPostBack="true" />
                        </ItemTemplate>
                        <HeaderStyle Width="170px"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
