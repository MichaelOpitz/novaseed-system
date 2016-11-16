<%@ Page Title="Codificacion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Codificacion.aspx.cs" Inherits="Project.Novaseed.Codificacion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row">
            <div class="col-sm-4">
                <h2>
                    <asp:Label ID="lblCodificacionAño" runat="server" Font-Bold="true" Text="Codificacion" /></h2>
            </div>
        </div>
        <br />
        <div class="row">
            <asp:gridview ID="gdvCodificacion" runat="server"
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
        <%--<asp:Button type="button" runat="server" Cssclass="btn btn-info btn-lg" data-toggle="modal" data-target="#ventanaCodigos" Text="VERR"></asp:Button>
        <div class="modal fade" id="ventanaCodigos" tabindex="-1" role="dialog" >
            <div class="modal-dialog">
                <div class="modal-content">

                </div>
            </div>
        </div>--%>
    </div>    
</asp:Content>
