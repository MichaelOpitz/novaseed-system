﻿<%@ Page Title="Producción" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ProduccionSeleccionIngresar.aspx.cs" Inherits="Project.Novaseed.ProduccionSeleccionIngresar" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row">
            <div class="col-sm-8">
                <h2>
                    <asp:Label ID="lblProduccionAño" runat="server" Font-Bold="true" Text="Producción" Font-Names="versalitas"/></h2>
            </div>
            <div class="col-sm-4" style="text-align: right">
                <h6>
                    <asp:Label ID="lbl12papasLeyendaVerde" runat="server" Text="Verde significa que está en etapas avanzadas" ForeColor="Green" Font-Italic="true" /></h6>
                <h6>
                    <asp:Label ID="lbl12papasLeyendaRojo" runat="server" Text="Rojo significa que esta es su última etapa" ForeColor="Red" Font-Italic="true" /></h6>
            </div>
        </div>
        <br />
        <div class="row">
            <asp:GridView ID="gdvProduccion" runat="server"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
                PageSize="8"
                OnDataBound="ProduccionGridView_DataBound"
                OnPageIndexChanging="ProduccionGridView_PageIndexChanging"
                OnRowDataBound="OnRowDataBound"
                OnRowDeleting="ProduccionGridView_RowDeleting"
                OnSelectedIndexChanged="gdvProduccion_SelectedIndexChanged">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay producción en el año seleccionado!  
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
                    <asp:BoundField DataField="nombre_variedad" HeaderText="Nombre Variedad" ReadOnly="true" />
                    <asp:BoundField DataField="codigo_variedad" HeaderText="Código Variedad" ReadOnly="true" />
                    <asp:CommandField SelectText="Producción" ButtonType="Link" ShowSelectButton="True" HeaderText="Producción"/>
                    <%--botones de acción sobre los registros...--%>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="Acción">
                        <ItemTemplate>
                            <%--Botones de eliminar y editar cliente...--%>
                            <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Desea eliminar la producción seleccionada?');" />
                        </ItemTemplate>                        
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
