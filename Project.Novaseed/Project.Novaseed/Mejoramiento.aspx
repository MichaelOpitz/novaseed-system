<%@ Page Title="Mejoramiento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
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
                        <%--<h5><span class="label label-primary">Color Carne</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoColorCarne" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Color Carne</span>
                    </div>
                    <div class="col-sm-4">
                        <h5><%--<span class="label label-primary">Color Piel</span>--%></h5>
                        <asp:DropDownList type="button" ID="ddlMejoramientoColorPiel" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Color Piel</span>
                    </div>
                    <div class="col-sm-4">
                        <h5><%--<span class="label label-primary">Tamaño</span>--%></h5>
                        <asp:DropDownList type="button" ID="ddlMejoramientoTamaño" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Tamaño</span>
                    </div>
                </div>
                <%-- SEGUNDA FILA --%>
                <div class="row" style="text-align: left">
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
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Calidad Piel</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoCalidadPiel" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Calidad Piel</span>
                    </div>
                </div>
                <%-- TERCERA FILA --%>
                <div class="row" style="text-align: left">
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Distribucion Calibre</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoDistribucion" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Distribucion Calibre</span>
                    </div>
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Tipo Hoja</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoTipoHoja" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Tipo Hoja</span>
                    </div>
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Profundidad Ojos</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoProfundidad" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Profundidad Ojos</span>
                    </div>
                </div>
                <%-- CUARTA FILA --%>
                <div class="row" style="text-align: left">
                    <div class="col-sm-4">
                        <h5><%--<span class="label label-primary">Regularidad</span>--%></h5>
                        <asp:DropDownList type="button" ID="ddlMejoramientoRegularidad" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Regularidad</span>
                    </div>
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Desarrollo Follaje</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoDesarrollo" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Desarrollo Follaje</span>
                    </div>
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Brotación</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoBrotacion" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Brotación</span>
                    </div>
                </div>
                <%-- QUINTA FILA --%>
                <div class="row" style="text-align: left">
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
                    <div class="col-sm-4">
                        <h5><%--<span class="label label-primary">Metribuzina</span>--%></h5>
                        <asp:DropDownList type="button" ID="ddlMejoramientoMetribuzina" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Metribuzina</span>
                    </div>
                </div>
                <%-- SEXTA FILA --%>
                <div class="row" style="text-align: left">
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
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Tizon Tardío Tubérculo</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoTizonTuberculo" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Tizón Tardío Tubérculo</span>
                    </div>
                </div>
                <%-- SEPTIMA FILA --%>
                <div class="row" style="text-align: left">
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
                    <div class="col-sm-4">
                        <%--<h5><span class="label label-primary">Destino</span></h5>--%>
                        <asp:DropDownList type="button" ID="ddlMejoramientoDestino" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Seleccione Destino</span>
                    </div>
                </div>
            </div>
        </div>
        <div class="panel panel-info">
            <div class="panel-heading" style="text-align: center">Buscar por nombre de madre o padre</div>
            <div class="panel-body">
                <%-- TEXTBOX MADRE Y PADRE, BOTON LIMPIAR CARACTERISTICAS --%>
                <div class="row" >
                    <div class="col-sm-3 col-sm-offset-1">
                        <asp:TextBox type="text" runat="server" class="form-control" ID="txtMadre" placeholder="Ingrese Nombre de la Madre" Style="border-color: #000000"></asp:TextBox>
                    </div>
                    <div class="col-sm-3">
                        <asp:Button type="button" runat="server" Text="Limpiar Características" ID="btnMejoramientoRefresh" class="btn btn-warning btn-md" Width="90%" ForeColor="#000000" Font-Bold="True" BorderColor="#000000" OnClick="btnMejoramientoRefresh_Click" OnClientClick="return confirm('¿Desea limpiar las características?');"></asp:Button>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" ID="txtPadre" placeholder="Ingrese Nombre del Padre" Style="border-color: #000000"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
        <%-- BOTONES MADRE Y PADRE --%>
        <div class="row" style="text-align: center; margin-top: 30px">
            <asp:Button type="button" runat="server" Text="Características Madre" ID="btnCaracteristicaMadre" class="btn btn-primary btn-md" Width="49%" BorderColor="#000000" OnClick="btnCaracteristicaMadre_Click"></asp:Button>
            <asp:Button type="button" runat="server" Text="Características Padre" ID="btnCaracteristicaPadre" class="btn btn-primary btn-md" Width="49%" BorderColor="#000000" OnClick="btnCaracteristicaPadre_Click"></asp:Button>
        </div>
        <br />
        <%-- TABLA MADRE --%>
        <div class="row" style="text-align: center; margin-top: 40px">
            <asp:GridView ID="gdvCaracteristicaMadre" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered bs-table">
                
                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay datos en las características seleccionadas!  
                </EmptyDataTemplate>

                <SelectedRowStyle Font-Bold="True" />
                <Columns>
                    <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                    <asp:BoundField DataField="codigo_variedad" HeaderText="Código" />
                    <asp:BoundField DataField="nombre_variedad" HeaderText="Nombre" />
                    <asp:BoundField DataField="nombre_madurez" HeaderText="Madurez" />
                    <asp:BoundField DataField="nombre_forma" HeaderText="Forma" />
                    <asp:BoundField DataField="nombre_calidad_piel" HeaderText="Calidad" />
                    <asp:BoundField DataField="nombre_tipo_hoja" HeaderText="Tipo Hoja" />
                    <asp:BoundField DataField="nombre_profundidad" HeaderText="Profundidad" />
                    <asp:BoundField DataField="nombre_regularidad" HeaderText="Regularidad" />
                    <asp:BoundField DataField="nombre_desarrollo_follaje" HeaderText="Desarrollo Follaje" />
                    <asp:BoundField DataField="nombre_destino" HeaderText="Destino" />
                </Columns>
            </asp:GridView>
        </div>
        <br />
        <%-- TABLA PADRE --%>
        <div class="row" style="text-align: center; margin-top: 40px">
            <asp:GridView ID="gdvCaracteristicaPadre" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered bs-table">
                
                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay datos en las características seleccionadas!  
                </EmptyDataTemplate>
                
                <SelectedRowStyle Font-Bold="True" />
                <Columns>
                    <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                    <asp:BoundField DataField="codigo_variedad" HeaderText="Código" />
                    <asp:BoundField DataField="nombre_variedad" HeaderText="Nombre" />
                    <asp:BoundField DataField="nombre_madurez" HeaderText="Madurez" />
                    <asp:BoundField DataField="nombre_forma" HeaderText="Forma" />
                    <asp:BoundField DataField="nombre_calidad_piel" HeaderText="Calidad" />
                    <asp:BoundField DataField="nombre_tipo_hoja" HeaderText="Tipo Hoja" />
                    <asp:BoundField DataField="nombre_profundidad" HeaderText="Profundidad" />
                    <asp:BoundField DataField="nombre_regularidad" HeaderText="Regularidad" />
                    <asp:BoundField DataField="nombre_desarrollo_follaje" HeaderText="Desarrollo Follaje" />
                    <asp:BoundField DataField="nombre_destino" HeaderText="Destino" />
                </Columns>
            </asp:GridView>
        </div>
        <%-- BOTONES CRUZAMIENTO Y CANCELAR --%>
        <div class="row" style="text-align: center; margin-top: 30px">
            <asp:Button type="button" runat="server" Text="Generar Cruzamiento" ID="btnMejoramientoCruzamiento" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" OnClick="btnMejoramientoCruzamiento_Click" OnClientClick="return confirm('¿Desea crear el cruzamiento?');"></asp:Button>
            <asp:Button type="button" runat="server" Text="Cancelar" ID="btnMejoramientoCancelar" class="btn btn-danger btn-md" Width="20%" BorderColor="#000000" OnClick="btnMejoramientoCancelar_Click" OnClientClick="return confirm('¿Desea cancelar el cruzamiento?');"></asp:Button>
        </div>
    </div>
</asp:Content>

