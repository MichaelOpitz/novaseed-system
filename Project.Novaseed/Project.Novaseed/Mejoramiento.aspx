<%@ Page Title="Mejoramiento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Mejoramiento.aspx.cs" Inherits="Project.Novaseed.Mejoramiento" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <%-- PRIMERA FILA --%>
        <div class="row" style="text-align: left">
            <div class="col-sm-4">
                <h5><span class="label label-primary">Color Carne</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoColorCarne" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>
            <div class="col-sm-4">
                <h5><span class="label label-primary">Color Piel</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoColorPiel" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>
            <div class="col-sm-4">
                <h5><span class="label label-primary">Tamaño</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoTamaño" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>            
        </div>
        <%-- SEGUNDA FILA --%>
        <div class="row" style="text-align: left">
            <div class="col-sm-4">
                <h5><span class="label label-primary">Madurez</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoMadurez" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>
            <div class="col-sm-4">
                <h5><span class="label label-primary">Forma</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoForma" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>                
            </div>
            <div class="col-sm-4">
                <h5><span class="label label-primary">Calidad Piel</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoCalidadPiel" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>            
        </div>
        <%-- TERCERA FILA --%>
        <div class="row" style="text-align: left">
            <div class="col-sm-4">
                <h5><span class="label label-primary">Distribucion Calibre</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoDistribucion" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>                
            </div>
            <div class="col-sm-4">
                <h5><span class="label label-primary">Tipo Hoja</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoTipoHoja" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>
            <div class="col-sm-4">
                <h5><span class="label label-primary">Profundidad Ojos</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoProfundidad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>            
        </div>
        <%-- CUARTA FILA --%>
        <div class="row" style="text-align: left">
            <div class="col-sm-4">
                <h5><span class="label label-primary">Regularidad</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoRegularidad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>
            <div class="col-sm-4">
                <h5><span class="label label-primary">Desarrollo Follaje</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoDesarrollo" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>
            <div class="col-sm-4">
                <h5><span class="label label-primary">Brotación</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoBrotacion" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>                   
        </div>
        <%-- QUINTA FILA --%>
        <div class="row" style="text-align: left"> 
            <div class="col-sm-4">
                <h5><span class="label label-primary">Emergencia</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoEmergencia" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>
            <div class="col-sm-4">
                <h5><span class="label label-primary">Emergencia a 40 Días</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoEmergencia40" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>
            <div class="col-sm-4">
                <h5><span class="label label-primary">Metribuzina</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoMetribuzina" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>                     
        </div>
        <%-- SEXTA FILA --%>
        <div class="row" style="text-align:left">
            <div class="col-sm-4">
                <h5><span class="label label-primary">Tubérculos Verdes</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoTuberculosVerdes" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>
            <div class="col-sm-4">
                <h5><span class="label label-primary">Tizon Tardío Follaje</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoTizonFollaje" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>   
            <div class="col-sm-4">
                <h5><span class="label label-primary">Tizon Tardío Tubérculo</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoTizonTuberculo" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>                           
        </div>
        <%-- SEPTIMA FILA --%>
        <div class="row" style="text-align:left">
            <div class="col-sm-4">
                <h5><span class="label label-primary">Numero Tubérculos</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoNumero" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>
            <div class="col-sm-4">
                <h5><span class="label label-primary">Fertilidad</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoFertilidad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div>
            <div class="col-sm-4">
                <h5><span class="label label-primary">Destino</span></h5>
                <asp:DropDownList type="button" ID="ddlMejoramientoDestino" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
            </div> 
        </div>
        <%-- TEXTBOX MADRE Y PADRE --%>
        <div class="row" style="text-align:center; margin-top:40px">
            <div class="col-sm-3 col-sm-offset-1">
                <asp:TextBox type="text" runat="server" class="form-control" id="txtMadre" placeholder="Ingrese Nombre de la Madre" style="border-color:#000000"></asp:TextBox>
            </div>
            <div class="col-sm-4">
                <asp:button type="button" runat="server" Text="Limpiar Características" ID="btnMejoramientoRefresh" class="btn btn-warning btn-md" Width="90%" ForeColor="#000000" Font-Bold="True" BorderColor="#000000" OnClick="btnMejoramientoRefresh_Click" ></asp:button>
            </div>
            <div class="col-sm-3">
                <asp:TextBox type="text" runat="server" class="form-control" id="txtPadre" placeholder="Ingrese Nombre del Padre" style="border-color:#000000"></asp:TextBox>
            </div>
        </div>
        <%-- BOTONES MADRE Y PADRE --%>
        <div class="row" style="text-align: center; margin-top:30px">
            <asp:button type="button" runat="server" Text="Características Madre" ID="btnCaracteristicaMadre" class="btn btn-primary btn-md" Width="49%" BorderColor="#000000" OnClick="btnCaracteristicaMadre_Click"></asp:button>
            <asp:button type="button" runat="server" Text="Características Padre" ID="btnCaracteristicaPadre" class="btn btn-primary btn-md" Width="49%" BorderColor="#000000" OnClick="btnCaracteristicaPadre_Click"></asp:button>
        </div>
        <%-- TABLA MADRE --%>
        <div class="row" style="text-align: center; margin-top:40px">
            <asp:GridView ID="gdvCaracteristicaMadre" runat="server" AutoGenerateColumns="False" class="table table-striped" >                
                <SelectedRowStyle Font-Bold="True"/>
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
        <%-- TABLA PADRE --%>
        <div class="row" style="text-align: center; margin-top:40px">
            <asp:GridView ID="gdvCaracteristicaPadre" runat="server" AutoGenerateColumns="False" class="table table-striped" >                
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
        <div class="row" style="text-align: center; margin-top:30px">
            <asp:button type="button" runat="server" Text="Generar Cruzamiento" ID="btnMejoramientoCruzamiento" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" OnClick="btnMejoramientoCruzamiento_Click"></asp:button>
            <asp:button type="button" runat="server" Text="Cancelar" ID="btnMejoramientoCancelar" class="btn btn-danger btn-md" Width="20%" BorderColor="#000000" OnClick="btnMejoramientoCancelar_Click"></asp:button>
        </div>
    </div>
</asp:Content>

