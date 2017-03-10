<%@ Page Title="Menu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Menu.aspx.cs" Inherits="Project.Novaseed.Menu" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row" style="height: auto">
            <div class="col-sm-3">


                <div class="container">
                    <div class="row profile" style="border-color:black; border-style:groove;">
                        <div class="nav navbar-nav sider-navbar">
                            <!-- SIDEBAR USERPIC -->
                            <div class="profile-userpic" style="width:50%; height:50%; margin-left:25%">
                                <asp:Image ID="imgMenuAvatar" runat="server" class="img-responsive img-circle" alt="Profile Picture"/>
                            </div>
                            <!-- END SIDEBAR USERPIC -->
                            <!-- SIDEBAR USER TITLE -->
                            <div class="profile-usertitle" style="text-align: center">
                                <div class="profile-usertitle-name">
                                    <asp:Label id="lblMenuNombre" runat="server" Font-Bold="true"/>
                                </div>
                                <div class="profile-usertitle-job">
                                    <asp:Label id="lblMenuCargo" runat="server" Font-Bold="true"/>
				
                                </div>
                            </div>
                            <br />
                            <!-- END SIDEBAR BUTTONS -->
                            <!-- SIDEBAR MENU -->
                            <div class="profile-usermenu">
                                <ul class="nav">
                                    <li class="active">
                                        <a runat="server" href="~/UsuarioPerfil.aspx" style="background-color: #E0FFFF">
                                            <i class="glyphicon glyphicon-user"></i>
                                            Perfil </a>
                                    </li>
                                    <li class="collapse" id="dropdown">
                                        <a data-toggle="collapse" href="#dropdown-lvl1" style="background-color: #E0FFFF">
                                            <i class="glyphicon glyphicon-cog"></i>
                                            Administración <i class="caret"></i></a>

                                        <!-- Dropdown level 1 -->
                                        <div id="dropdown-lvl1" class="panel-collapse collapse" style="background-color: #FFE4E1; width: 100%">
                                            <ul class="nav nav-list">
                                              
                                                <li><a runat="server" href="~/Usuario.aspx" id="btnMenuLateralUsuario" ><i class="glyphicon glyphicon-user"></i>Usuario</a></li>

                                                <li class="divider"></li>

                                                <!-- Dropdown level 2 -->
                                                <li class="panel-collapse collapse" id="dropdownCiudad2" style="background-color: #FFE4E1; width: 100%">
                                                    <a data-toggle="collapse" href="#dropdownCiudad-lvl2">
                                                        <span class="glyphicon glyphicon-flag"></span>Ciudad <span class="caret"></span>
                                                    </a>
                                                    <div id="dropdownCiudad-lvl2" class="panel-collapse collapse" style="background-color: #FAFAD2; width: 100%">
                                                        <ul class="nav nav-list">
                                                            <li><a runat="server" href="~/CiudadAgregar.aspx"><i class="glyphicon glyphicon-plus"></i>Agregar</a></li>
                                                            <li><a runat="server" href="~/CiudadActualizar.aspx"><i class="glyphicon glyphicon-pencil"></i>Modificar</a></li>
                                                            <li><a runat="server" href="~/CiudadEliminar.aspx"><i class="glyphicon glyphicon-minus"></i>Eliminar</a></li>
                                                        </ul>
                                                    </div>
                                                </li>

                                                <li><a runat="server" href="~/Enfermedades.aspx"><i class="glyphicon glyphicon-warning-sign"></i>Enfermedades</a></li>
                                            </ul>
                                        </div>
                                    </li>

                                    <li class="collapse" id="dropdownInforme">
                                        <a data-toggle="collapse" href="#dropdownInforme-lvl1" style="background-color: #E0FFFF">
                                            <i class="glyphicon glyphicon-ok"></i>
                                            Informes <i class="caret"></i></a>
                                        <!-- Dropdown level 1 -->
                                        <div id="dropdownInforme-lvl1" class="panel-collapse collapse" style="background-color: #FAFAD2; width: 100%">
                                            <ul class="nav nav-list">
                                                <li><a runat="server" href="~/ReporteVariedadSeleccion.aspx"><i class="glyphicon glyphicon-asterisk"></i>Informe de Variedades</a></li>
                                                <li><a runat="server" href="~/ReporteUPOVSeleccion.aspx"><i class="glyphicon glyphicon-asterisk"></i>Informe UPOV</a></li>
                                                <li><a runat="server" href="~/ReporteProduccionSeleccion.aspx"><i class="glyphicon glyphicon-asterisk"></i>Informe Producción</a></li>
                                                <li><a runat="server" href="~/ReporteLicenciaSeleccion.aspx"><i class="glyphicon glyphicon-asterisk"></i>Informe Licencia</a></li>                                                
                                            </ul>
                                        </div>
                                    </li>
                                    <li>
                                        <a runat="server" href="~/UsuarioRegistro.aspx" style="background-color: #E0FFFF">
                                            <i class="glyphicon glyphicon-flash"></i>
                                            Registro de Usuarios </a>
                                    </li>
                                    <li>
                                        <a runat="server" href="~/Ayuda.aspx" style="background-color: #E0FFFF">
                                            <i class="glyphicon glyphicon-flag"></i>
                                            Ayuda </a>
                                    </li>
                                    <li>
                                        <a runat="server" href="~/Contact.aspx" style="background-color: #E0FFFF">
                                            <i class="glyphicon glyphicon-envelope"></i>
                                            Contacto </a>
                                    </li>
                                </ul>
                            </div>
                            <!-- END MENU -->
                        </div>
                    </div>
                </div>


            </div>
            <div class="col-sm-9" style="text-align: center">
                <br />
                <%--<strong>Menú</strong>--%>
                <asp:Image ID="imgMenuBanner" ImageUrl="~/images/logo.png" runat="server" Width="20%" Height="20%"/>
                <br />
                <br />
                <br />
                <%--<asp:Button type="button" runat="server" class="btn btn-info" ID="btnMenuMejoramiento" Style='width: 160px; height: 140px; border-color: #000000' ForeColor="Black" Text="Mejoramiento" OnClick="btnMenuMejoramiento_Click"></asp:Button>
                <asp:Button type="button" runat="server" class="btn btn-info" ID="btnMenuGeneracion" Style='width: 160px; height: 140px; border-color: #000000' ForeColor="Black" Text="Año de Generación" OnClick="btnMenuGeneracion_Click"></asp:Button>
                <asp:Button type="button" runat="server" class="btn btn-info" ID="btnMenuProduccion" Style='width: 160px; height: 140px; border-color: #000000' ForeColor="Black" Text="Producción" OnClick="btnMenuProduccion_Click"></asp:Button>
                <asp:Button type="button" runat="server" class="btn btn-info" ID="btnMenuLicencia" Style='width: 160px; height: 140px; border-color: #000000' ForeColor="Black" Text="Licencias" OnClick="btnMenuLicencia_Click"></asp:Button>--%>
                <asp:ImageButton ID="btnMenuMejoramiento" runat="server" ImageUrl="~/images/mejoramiento.png" Style='width: 160px; height: 140px; border-color: #000000' ForeColor="Black" OnClick="btnMenuMejoramiento_Click"/>
                <asp:ImageButton ID="btnMenuGeneracion" runat="server" ImageUrl="~/images/generacion.png" Style='width: 160px; height: 140px; border-color: #000000' ForeColor="Black" OnClick="btnMenuGeneracion_Click"/>
                <asp:ImageButton ID="btnMenuProduccion" runat="server" ImageUrl="~/images/produccion.png" Style='width: 160px; height: 140px; border-color: #000000' ForeColor="Black" OnClick="btnMenuProduccion_Click"/>
                <asp:ImageButton ID="btnMenuLicencia" runat="server" ImageUrl="~/images/licencia.png" Style='width: 160px; height: 140px; border-color: #000000' ForeColor="Black" OnClick="btnMenuLicencia_Click"/>
            </div>
        </div>
    </div>
</asp:Content>
