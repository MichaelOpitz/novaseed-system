<%@ Page Title="Ayuda" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ayuda.aspx.cs" Inherits="Project.Novaseed.Ayuda" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div class="row" style="margin-top: 30px; text-align: center">
            <h2 style="text-align: center;">Ayuda</h2>
        </div>
        <hr style="color: #000000" />
        <hr style="color: #000000" />
        <div class="row">
            <h3 style="text-align: center; font-weight:bold">Mejoramiento</h3>
            1.- Se debe generar un cruzamiento donde se elige un padre y una madre según las características seleccionadas previamente.            
            <div class="col-sm-5 col-sm-offset-1" style="margin-top:20px">
                <asp:Image ID="imgAyudaMejoramientoCaracteristicas" ImageUrl="~/images/Mejoramiento/caracteristicas.png" BorderColor="Black" runat="server" Width="90%" Height="150%" />
            </div>
            <div class="col-sm-5" style="margin-top:20px">
                <asp:Image ID="imgAyudaMejoramientoSeleccionPadres" ImageUrl="~/images/Mejoramiento/seleccionPadres.png" BorderColor="Black" runat="server" Width="90%" Height="150%" />
            </div>
        </div>
        <br />
        <hr style="color: #000000" />
        <div class="row">
            <h3 style="text-align: center; font-weight:bold">Generación</h3>
        </div>
        <div class="row">
            2.- Se generará un cruzamiento por defecto en el año actual para modificar los parámetros específicos.        
            <div class="col-sm-8 col-sm-offset-2" style="margin-top:20px">
                <asp:Image ID="imgAyudaGeneracionCruzamiento" ImageUrl="~/images/Generacion/cruzamiento.png" BorderColor="Black" runat="server" Width="90%" Height="150%" />
            </div>
        </div>
        <br />
        <div class="row">
            3.- Se generará un vaso por defecto en el año actual para modificar los parámetros específicos.            
            <div class="col-sm-8 col-sm-offset-2" style="margin-top:20px">
                <asp:Image ID="imgAyudaGeneracionVasos" ImageUrl="~/images/Generacion/vasos.png" BorderColor="Black" runat="server" Width="90%" Height="150%"/>
            </div>
        </div>
        <br />
        <div class="row">
            4.- Se generará un clon por defecto en el año actual para modificar los parámetros específicos.
            <div class="col-sm-8 col-sm-offset-2" style="margin-top:20px">
                <asp:Image ID="imgAyudaGeneracionClones" ImageUrl="~/images/Generacion/clones.png" BorderColor="Black" runat="server" Width="90%" Height="150%"/>
            </div>
        </div>
        <br />
        <div class="row">
            5.- Se podrá codificar todos los clones que aprobaron la etapa.
            <div class="col-sm-8 col-sm-offset-2" style="margin-top:20px">
                <asp:Image ID="imgAyudaGeneracionCodificacion" ImageUrl="~/images/Generacion/codificacion.png" BorderColor="Black" runat="server" Width="90%" Height="150%"/>
            </div>
        </div>
        <br />
        <div class="row">
            6.- Se generará una cosecha(6, 12, 24, 48papas) por defecto en el año actual para modificar los parámetros específicos.
            <div class="col-sm-5 col-sm-offset-1" style="margin-top:20px">
                <asp:Image ID="imgAyudaGeneracionCosecha1" ImageUrl="~/images/Generacion/cosecha1.png" BorderColor="Black" runat="server" Width="90%" Height="150%"/>
            </div>
            <div class="col-sm-5" style="margin-top:20px">
                <asp:Image ID="imgAyudaGeneracionCosecha2" ImageUrl="~/images/Generacion/cosecha2.png" BorderColor="Black" runat="server" Width="90%" Height="150%"/>
            </div>
        </div>
        <div class="row" style="text-align:center">
            <asp:Image ID="imgAyudaGeneracionCosecha3" ImageUrl="~/images/Generacion/cosecha3.png" BorderColor="Black" runat="server" Width="90%" Height="150%"/>
        </div>        
        <br />
        <div class="row">
            7.- Se generará un informe UPOV por defecto en el mismo año de la cosecha 48papas para modificar los parámetros específicos.
            <div class="col-sm-8 col-sm-offset-2" style="margin-top:20px">
                <asp:Image ID="imgAyudaGeneracionUPOV" ImageUrl="~/images/Generacion/upov.png" BorderColor="Black" runat="server" Width="90%" Height="150%"/>
            </div>
        </div>
        <br />
        <hr style="color: #000000" />
        <div class="row">
            <h3 style="text-align: center; font-weight:bold">Producción</h3>
        </div>        
        <div class="row">
            8.- En producción se puede modificar y filtrar las variedades que aprobaron el informe UPOV
            <br />
            <div class="col-sm-5 col-sm-offset-1" style="margin-top:20px">
                <asp:Image ID="imgAyudaProduccionModificar" ImageUrl="~/images/Produccion/modificarProduccion.png" BorderColor="Black" runat="server" Width="90%" Height="150%"/>
            </div>
            <div class="col-sm-5" style="margin-top:20px">
                <asp:Image ID="imgAyudaProduccionFiltrar" ImageUrl="~/images/Produccion/filtrarProduccion.png" BorderColor="Black" runat="server" Width="90%" Height="150%"/>
            </div>
        </div>
        <br />
        <hr style="color: #000000" />
        <div class="row">
            <h3 style="text-align: center; font-weight:bold">Licencia</h3>
        </div> 
        <div class="row">
            9.- En las licencias se muestra todos los productores que pagaron la licencia para poder llevar la producción de dicha variedad.
            <div class="col-sm-8 col-sm-offset-2" style="margin-top:20px">
                <asp:Image ID="imgAyudaLicencia" ImageUrl="~/images/Licencia/licencia.png" BorderColor="Black" runat="server" Width="90%" Height="150%"/>
            </div>
        </div>
    </div>
</asp:Content>
