﻿<%@ Page Title="Mejoramiento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Mejoramiento.aspx.cs" Inherits="Project.Novaseed.Mejoramiento" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">Características</div>
            <div class="panel-body">
                <%-- PRIMERA FILA --%>
                <div class="row" style="text-align: left">
                    <div class="col-sm-4">
                        <h5><%--<span class="label label-primary">Tamaño</span>--%></h5>
                        <asp:DropDownList type="button" ID="ddlMejoramientoTamaño" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Tamaño</span>
                    </div>
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Madurez</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoMadurez" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Madurez</span>
                    </div>
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Forma</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoForma" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Forma</span>
                    </div>
                </div>
                <%-- SEGUNDA FILA --%>
                <div class="row" style="text-align: left">
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Distribucion Calibre</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoDistribucion" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Distribucion Calibre</span>
                    </div>
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Profundidad Ojos</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoProfundidad" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Profundidad Ojos</span>
                    </div>
                    <div class="col-sm-4">
                        <h5><%--<span class="label label-primary">Regularidad</span>--%></h5>
                        <asp:DropDownList type="button" ID="ddlMejoramientoRegularidad" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Regularidad</span>
                    </div>
                </div>
                <%-- TERCERA FILA --%>
                <div class="row" style="text-align: left">
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Brotación</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoBrotacion" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Brotación</span>
                    </div>
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Emergencia</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoEmergencia" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Emergencia</span>
                    </div>
                    <div class="col-sm-4">
                        <h5><%--<span class="label label-primary">Emergencia a 40 Días</span>--%></h5>
                        <asp:DropDownList type="button" ID="ddlMejoramientoEmergencia40" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Emergencia 40 Días</span>
                    </div>
                </div>
                <%-- CUARTA FILA --%>
                <div class="row" style="text-align: left">
                    <div class="col-sm-4">
                        <h5><%--<span class="label label-primary">Metribuzina</span>--%></h5>
                        <asp:DropDownList type="button" ID="ddlMejoramientoMetribuzina" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Metribuzina</span>
                    </div>
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Tubérculos Verdes</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoTuberculosVerdes" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Tubérculos Verdes</span>
                    </div>
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Tizon Tardío Follaje</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoTizonFollaje" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Tizón Tardío Follaje</span>
                    </div>
                </div>
                <%-- QUINTA FILA --%>
                <div class="row" style="text-align: left">
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Tizon Tardío Tubérculo</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoTizonTuberculo" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Tizón Tardío Tubérculo</span>
                    </div>
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Numero Tubérculos</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoNumero" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Número Tubérculos</span>
                    </div>
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Fertilidad</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoFertilidad" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Fertilidad</span>
                    </div>
                </div>
                <%-- SEXTA FILA --%>
                <div class="row" style="text-align: left">
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Destino</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoDestino" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Destino</span>
                    </div>
                    <div class="col-sm-4">
                        <asp:TextBox type="text" runat="server" class="form-control" ID="txtMadre" Width="80%" placeholder="Ingrese Nombre de la Madre" Style="border-color: #000000"></asp:TextBox>
                        <span class="help-block">Buscar por Nombre Madre</span>
                    </div>
                    <div class="col-sm-4">
                        <asp:TextBox type="text" runat="server" class="form-control" ID="txtPadre" Width="80%" placeholder="Ingrese Nombre del Padre" Style="border-color: #000000"></asp:TextBox>
                        <span class="help-block">Buscar por Nombre Padre</span>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <asp:Button type="button" runat="server" ID="btnMejoramientoRefresh" class="btn btn-danger btn-block" Style="border-color: #000000" Text="Limpiar Características" OnClientClick="return confirm('¿Desea limpiar las características?');" OnClick="btnMejoramientoRefresh_Click"></asp:Button>
        </div>

        <asp:UpdatePanel runat="server" ID="UpdatePanel"
            UpdateMode="Conditional">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnCaracteristicaPadre"
                    EventName="Click" />
            </Triggers>
            <ContentTemplate>
                <%-- BOTONES MADRE Y PADRE --%>
                <div class="row" style="text-align: center; margin-top: 30px">
                    <asp:Button type="button" runat="server" Text="Características Madre" ID="btnCaracteristicaMadre" class="btn btn-primary btn-md" Width="49%" BorderColor="#000000" OnClick="btnCaracteristicaMadre_Click"></asp:Button>
                    <asp:Button type="button" runat="server" Text="Características Padre" ID="btnCaracteristicaPadre" class="btn btn-primary btn-md" Width="49%" BorderColor="#000000" OnClick="btnCaracteristicaPadre_Click"></asp:Button>
                </div>
                <%-- TABLA MADRE --%>
                <div class="row" style="margin-top: 40px">
                    <span class="label label-primary" style="text-align: left">Tabla Madre</span>
                </div>
                <div class="row" style="text-align: center">
                    <asp:GridView ID="gdvCaracteristicaMadre" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-bordered bs-table"
                        AllowPaging="True"
                        AllowSorting="True"
                        PageSize="6"
                        OnDataBound="MadreGridView_DataBound"
                        OnPageIndexChanging="MadreGridView_PageIndexChanging">

                        <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#ffffcc" />
                        <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                        <EmptyDataTemplate>
                            ¡No hay datos en las características seleccionadas!  
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
                                            <asp:ListItem Value="6" Text="6" />
                                            <asp:ListItem Value="8" Text="8" />
                                            <asp:ListItem Value="10" Text="10" />
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
                            <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="Seleccionar">
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkMejoramientoSeleccionarMadre" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="codigo_variedad" HeaderText="Código" />
                            <asp:BoundField DataField="nombre_variedad" HeaderText="Nombre" />
                            <asp:BoundField DataField="nombre_madurez" HeaderText="Madurez" />
                            <asp:BoundField DataField="nombre_forma" HeaderText="Forma" />
                            <asp:BoundField DataField="nombre_profundidad" HeaderText="Profundidad" />
                            <asp:BoundField DataField="nombre_regularidad" HeaderText="Regularidad" />
                            <asp:BoundField DataField="nombre_destino" HeaderText="Destino" />
                        </Columns>
                    </asp:GridView>
                </div>
                <hr style="color: #000000" />
                <%-- TABLA PADRE --%>
                <div class="row" style="margin-top: 40px">
                    <span class="label label-primary" style="text-align: left">Tabla Padre</span>
                </div>
                <div class="row" style="text-align: center">
                    <asp:GridView ID="gdvCaracteristicaPadre" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-bordered bs-table"
                        AllowPaging="True"
                        AllowSorting="True"
                        PageSize="6"
                        OnDataBound="PadreGridView_DataBound"
                        OnPageIndexChanging="PadreGridView_PageIndexChanging">

                        <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#ffffcc" />
                        <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                        <EmptyDataTemplate>
                            ¡No hay datos en las características seleccionadas!  
                        </EmptyDataTemplate>

                        <PagerTemplate>
                            <table runat="server" id="testTable2" style="width: 100%" class="k-grid td">
                                <tr>
                                    <td class="col-md-8 pull-left">
                                        <asp:Label ID="MessageLabel2"
                                            Text="Página: "
                                            runat="server"
                                            Font-Bold="true" />
                                        <asp:LinkButton ID="FirstLB2" runat="server" CommandName="Page" CommandArgument="First" ToolTip="First" CssClass="btn-pager btn-default" OnClick="FirstLB2_Click"> Inicio </asp:LinkButton>
                                        <asp:LinkButton ID="PrevLB2" runat="server" CommandName="Page" CommandArgument="Prev" ToolTip="Previous" CssClass="btn-pager btn-default" OnClick="PrevLB2_Click"> Anterior </asp:LinkButton>
                                        <asp:DropDownList runat="server" ID="PageDropDownList2" AutoPostBack="true" EnableViewState="true" OnSelectedIndexChanged="PageDropDownList2_SelectedIndexChanged" CssClass="selectpicker form-control-drp"></asp:DropDownList>

                                        <asp:LinkButton ID="NextLB2" runat="server" CommandName="Page" CommandArgument="Next" ToolTip="Next" CssClass="btn-pager btn-default" OnClick="NextLB2_Click"> Siguiente </asp:LinkButton>
                                        <asp:LinkButton ID="LastLB2" runat="server" CommandName="Page" CommandArgument="Last" ToolTip="Last" CssClass="btn-pager btn-default" OnClick="LastLB2_Click"> Final</asp:LinkButton>
                                    </td>

                                    <td class="col-md-4 pull-right">
                                        <asp:Label ID="PageSizeLabel2" runat="server" Text="Tamaño de página: " Font-Bold="true"></asp:Label>
                                        <asp:DropDownList ID="ddlPageSize2" runat="server" OnSelectedIndexChanged="ddlPageSize2_SelectedIndexChanged" AutoPostBack="true" CssClass="selectpicker form-control-drp">
                                            <%-- <asp:ListItem Value="0" Text="0" />--%>
                                            <asp:ListItem Value="6" Text="6" />
                                            <asp:ListItem Value="8" Text="8" />
                                            <asp:ListItem Value="10" Text="10" />
                                        </asp:DropDownList>
                                    </td>
                                    <td class="col-md-2">
                                        <asp:Label ID="CurrentPageLabel2" runat="server" />
                                    </td>
                                </tr>
                            </table>
                        </PagerTemplate>

                        <SelectedRowStyle Font-Bold="True" />
                        <Columns>
                            <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="Seleccionar">
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkMejoramientoSeleccionarPadre" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="codigo_variedad" HeaderText="Código" />
                            <asp:BoundField DataField="nombre_variedad" HeaderText="Nombre" />
                            <asp:BoundField DataField="nombre_madurez" HeaderText="Madurez" />
                            <asp:BoundField DataField="nombre_forma" HeaderText="Forma" />
                            <asp:BoundField DataField="nombre_profundidad" HeaderText="Profundidad" />
                            <asp:BoundField DataField="nombre_regularidad" HeaderText="Regularidad" />
                            <asp:BoundField DataField="nombre_destino" HeaderText="Destino" />
                        </Columns>
                    </asp:GridView>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        <%-- BOTONES CRUZAMIENTO Y CANCELAR --%>
        <div class="row" style="text-align: center; margin-top: 30px">
            <asp:Button type="button" runat="server" Text="Generar Cruzamiento" ID="btnMejoramientoCruzamiento" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" OnClick="btnMejoramientoCruzamiento_Click" OnClientClick="return confirm('¿Desea crear el cruzamiento?');"></asp:Button>
            <asp:Button type="button" runat="server" Text="Cancelar" ID="btnMejoramientoCancelar" class="btn btn-danger btn-md" Width="20%" BorderColor="#000000" OnClick="btnMejoramientoCancelar_Click" OnClientClick="return confirm('¿Desea cancelar el cruzamiento?');"></asp:Button>
        </div>
    </div>
</asp:Content>

