﻿<%@ Page Title="Licencia" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteLicenciaSeleccion.aspx.cs" Inherits="Project.Novaseed.ReporteLicenciaSeleccion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-6">
                <h2>
                    <asp:Label ID="lblLicenciaReporte" runat="server" Font-Bold="true" Text="Licencias" Font-Names="versalitas" /></h2>
            </div>
            <div class="col-sm-6" style="text-align: right">
                <div class="input-group" style="margin-top: 30px">
                    <asp:TextBox runat="server" type="text" class="form-control" id="txtLicenciaReporteBuscar" placeholder="Ingrese nombre de variedad"></asp:TextBox>
                    <span class="input-group-btn">
                        <asp:Button runat="server" class="btn btn-default" type="button" id="btnLicenciaReporteBuscar" Text="Buscar" OnClick="btnLicenciaReporteBuscar_Click"></asp:Button>
                    </span>
                </div>
            </div>
        </div>
        <div class="row" style="margin-top: 20px">
            <asp:GridView ID="gdvLicencia" runat="server"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
                PageSize="8"
                OnDataBound="LicenciaGridView_DataBound"
                OnPageIndexChanging="LicenciaGridView_PageIndexChanging"
                OnSelectedIndexChanged="gdvLicencia_SelectedIndexChanged">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No existen datos!  
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

                <SelectedRowStyle Font-Bold="True" />
                <Columns>
                    <asp:BoundField DataField="id_produccion" HeaderText="ID" ReadOnly="true" />
                    <asp:BoundField DataField="nombre_variedad" HeaderText="Variedad" ReadOnly="true" />
                    <asp:BoundField DataField="nombre_productor" HeaderText="Productor" ReadOnly="true" />
                    <asp:BoundField DataField="ano_produccion" HeaderText="Año" ReadOnly="true" />

                    <asp:CommandField SelectText="Descargar PDF" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
