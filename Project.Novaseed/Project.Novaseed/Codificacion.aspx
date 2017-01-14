<%@ Page Title="Codificacion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Codificacion.aspx.cs" Inherits="Project.Novaseed.Codificacion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row">
            <div class="col-sm-4">
                <h2>
                    <asp:Label ID="lblCodificacionAño" runat="server" Font-Bold="true" Text="Codificacion" Font-Names="versalitas"/></h2>
            </div>
        </div>
        <br />
        <div class="row">
            <asp:GridView ID="gdvCodificacion" runat="server"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
                OnSelectedIndexChanged="gdvCodificacion_SelectedIndexChanged">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay clones para codificar en el año seleccionado!  
                </EmptyDataTemplate>

                <Columns>
                    <asp:BoundField DataField="codigo_variedad" HeaderText="Madre" ReadOnly="true" />
                    <asp:BoundField DataField="nombre_madre" HeaderText="Nombre Madre" ReadOnly="true" />
                    <asp:BoundField DataField="pad_codigo_variedad" HeaderText="Padre" ReadOnly="true" />
                    <asp:BoundField DataField="nombre_padre" HeaderText="Nombre Padre" ReadOnly="true" />
                    <asp:CommandField SelectText="Ver Codificación" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>

        <%--<div class="modal fade" id="ventanaRanking" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
                            <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                        <h4 class="modal-title" id="myModalLabel">Modal title</h4>
                                    </div>
                                    <div class="modal-body"> --%>

        <%--</div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                        <button type="button" class="btn btn-primary">Save changes</button>
                                    </div>
                                </div>
                            </div>
                        </div>--%>
    </div>
</asp:Content>
