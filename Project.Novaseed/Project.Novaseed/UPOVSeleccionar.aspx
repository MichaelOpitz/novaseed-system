<%@ Page Title="UPOV" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="UPOVSeleccionar.aspx.cs" Inherits="Project.Novaseed.UPOVSeleccionar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row">
            <div class="col-sm-4">
                <h2>
                    <asp:Label ID="lblUPOVAño" runat="server" Font-Bold="true" Text="UPOV" /></h2>
            </div>
        </div>
        <br />
        <div class="row">
            <asp:GridView ID="gdvUPOV" runat="server"                
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
                OnRowDataBound="OnRowDataBound" OnSelectedIndexChanged="gdvUPOV_SelectedIndexChanged">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay informes UPOV en el año seleccionado!  
                </EmptyDataTemplate>

                <Columns>
                    <asp:BoundField DataField="id_upov" HeaderText="ID" ReadOnly="true" />
                    <asp:BoundField DataField="codigo_individuo" HeaderText="Código" ReadOnly="true" />
                    <asp:BoundField DataField="nombre_upov" HeaderText="Nombre UPOV" ReadOnly="true" />
                    <asp:BoundField DataField="nombre_ciudad" HeaderText="Ciudad" ReadOnly="true" />
                    <asp:BoundField DataField="codigo_variedad" HeaderText="Madre" ReadOnly="true"/>
                    <asp:BoundField DataField="nombre_madre" HeaderText="Nombre Madre" ReadOnly="true" />
                    <asp:BoundField DataField="pad_codigo_variedad" HeaderText="Padre" ReadOnly="true" />
                    <asp:BoundField DataField="nombre_padre" HeaderText="Nombre Padre" ReadOnly="true" />
                    <asp:CommandField SelectText="UPOV" ShowSelectButton="True" />                                       
                </Columns>
            </asp:GridView>

        </div>
    </div>
</asp:Content>
