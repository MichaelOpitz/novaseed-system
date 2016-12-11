<%@ Page Title="Menu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Menu.aspx.cs" Inherits="Project.Novaseed.Menu" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row" style="height: auto">
            <div class="col-sm-3">


                <div class="container">
                    <div class="row profile">
                        <div class="profile-sidebar">
                            <!-- SIDEBAR USERPIC -->
                            <div class="profile-userpic">
                                <img src="http://keenthemes.com/preview/metronic/theme/assets/admin/pages/media/profile/profile_user.jpg" class="img-responsive" alt="">
                            </div>
                            <!-- END SIDEBAR USERPIC -->
                            <!-- SIDEBAR USER TITLE -->
                            <div class="profile-usertitle" style="text-align: center">
                                <div class="profile-usertitle-name">
                                    Marcus Doe
				
                                </div>
                                <div class="profile-usertitle-job">
                                    Developer
				
                                </div>
                            </div>
                            <br />
                            <!-- END SIDEBAR USER TITLE -->
                            <!-- SIDEBAR BUTTONS -->
                            <div class="profile-userbuttons" style="text-align: center">
                                <button type="button" class="btn btn-success btn-sm">Follow</button>
                                <button type="button" class="btn btn-danger btn-sm">Message</button>
                            </div>
                            <br />
                            <!-- END SIDEBAR BUTTONS -->
                            <!-- SIDEBAR MENU -->
                            <div class="profile-usermenu">
                                <ul class="nav">
                                    <li class="active">
                                        <a runat="server" href="~/UsuarioModificar.aspx" style="background-color: #E0FFFF">
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

                                                <!-- Dropdown level 2 -->
                                                <li class="panel-collapse collapse" id="dropdownUsuario2" style="background-color: #FFE4E1; width: 100%">
                                                    <a data-toggle="collapse" href="#dropdownUsuario-lvl2">
                                                        <i class="glyphicon glyphicon-user"></i>Usuario <i class="caret"></i>
                                                    </a>
                                                    <div id="dropdownUsuario-lvl2" class="panel-collapse collapse" style="background-color: #FAFAD2; width: 100%">
                                                        <ul class="nav nav-list">
                                                            <li><a runat="server" href="~/UsuarioAgregar.aspx"><i class="glyphicon glyphicon-plus"></i>Agregar</a></li>
                                                            <li><a runat="server" href="~/UsuarioEliminar.aspx"><i class="glyphicon glyphicon-minus"></i>Eliminar</a></li>
                                                        </ul>
                                                    </div>
                                                </li>

                                                <li class="divider"></li>

                                                <!-- Dropdown level 2 -->
                                                <li class="panel-collapse collapse" id="dropdownCiudad2" style="background-color: #FFE4E1; width: 100%">
                                                    <a data-toggle="collapse" href="#dropdownCiudad-lvl2">
                                                        <span class="glyphicon glyphicon-flag"></span>Ciudad <span class="caret"></span>
                                                    </a>
                                                    <div id="dropdownCiudad-lvl2" class="panel-collapse collapse" style="background-color: #FAFAD2; width: 100%">
                                                        <ul class="nav nav-list">
                                                            <li><a runat="server" href="~/CiudadAgregar.aspx"><i class="glyphicon glyphicon-plus"></i>Agregar</a></li>
                                                            <li><a href="#"><i class="glyphicon glyphicon-pencil"></i>Modificar</a></li>
                                                            <li><a href="#"><i class="glyphicon glyphicon-minus"></i>Eliminar</a></li>
                                                        </ul>
                                                    </div>
                                                </li>

                                                <!-- Dropdown level 2 -->
                                                <li class="panel-collapse collapse" id="dropdownEnfermedades2" style="background-color: #FFE4E1; width: 100%">
                                                    <a data-toggle="collapse" href="#dropdownEnfermedades-lvl2">
                                                        <span class="glyphicon glyphicon-warning-sign"></span>Enfermedades <span class="caret"></span>
                                                    </a>
                                                    <div id="dropdownEnfermedades-lvl2" class="panel-collapse collapse" style="background-color: #FAFAD2; width: 100%">
                                                        <ul class="nav nav-list">
                                                            <li><a href="#"><i class="glyphicon glyphicon-plus"></i>Agregar</a></li>
                                                            <li><a href="#"><i class="glyphicon glyphicon-pencil"></i>Modificar</a></li>
                                                            <li><a href="#"><i class="glyphicon glyphicon-minus"></i>Eliminar</a></li>
                                                        </ul>
                                                    </div>
                                                </li>
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
                                                <li><a href="#"><i class="glyphicon glyphicon-asterisk"></i>Informe de Variedades</a></li>
                                                <li><a href="#"><i class="glyphicon glyphicon-asterisk"></i>Informe UPOV</a></li>
                                                <li><a href="#"><i class="glyphicon glyphicon-asterisk"></i>Informe Producción</a></li>
                                                <li><a href="#"><i class="glyphicon glyphicon-asterisk"></i>Informe Licencia</a></li>
                                                <li><a href="#"><i class="glyphicon glyphicon-asterisk"></i>Informe de Estadísticas</a></li>
                                            </ul>
                                        </div>
                                    </li>
                                    <li>
                                        <a runat="server" href="#" style="background-color: #E0FFFF">
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
                <asp:Image ID="imgMenuBanner" ImageUrl="~/images/logo.png" runat="server" />
                <br />
                <br />
                <br />
                <asp:Button type="button" runat="server" class="btn btn-primary" ID="btnMenuMejoramiento" Style='width: 160px; height: 140px; border-color: #000000' Text="Mejoramiento" OnClick="btnMenuMejoramiento_Click"></asp:Button>
                <asp:Button type="button" runat="server" class="btn btn-default" ID="btnMenuGeneracion" Style='width: 160px; height: 140px; border-color: #000000' Text="Año de Generación" OnClick="btnMenuGeneracion_Click"></asp:Button>
                <asp:Button type="button" runat="server" class="btn btn-default" ID="btnMenuProduccion" Style='width: 160px; height: 140px; border-color: #000000' Text="Producción" OnClick="btnMenuProduccion_Click"></asp:Button>
                <asp:Button type="button" runat="server" class="btn btn-primary" ID="btnMenuLicencia" Style='width: 160px; height: 140px; border-color: #000000' Text="Licencias" OnClick="btnMenuLicencia_Click"></asp:Button>
            </div>
        </div>
    </div>
</asp:Content>
