﻿<%@ Page Title="Codificacion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Codificacion.aspx.cs" Inherits="Project.Novaseed.Codificacion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="progress progress-striped active">
            <div class="progress-bar" role="progressbar"
                aria-valuenow="50" aria-valuemin="0" aria-valuemax="100" style="width: 50%">Etapa 3.5, Codificación                
            </div>
        </div>
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
                PageSize="8"
                OnDataBound="CodificacionGridView_DataBound"
                OnPageIndexChanging="CodificacionGridView_PageIndexChanging"
                OnSelectedIndexChanged="gdvCodificacion_SelectedIndexChanged">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay clones para codificar en el año seleccionado!  
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
                    <asp:BoundField DataField="codigo_variedad" HeaderText="Madre" ReadOnly="true" />
                    <asp:BoundField DataField="nombre_madre" HeaderText="Nombre Madre" ReadOnly="true" />
                    <asp:BoundField DataField="pad_codigo_variedad" HeaderText="Padre" ReadOnly="true" />
                    <asp:BoundField DataField="nombre_padre" HeaderText="Nombre Padre" ReadOnly="true" />
                    <asp:CommandField SelectText="Ver Codificación" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
