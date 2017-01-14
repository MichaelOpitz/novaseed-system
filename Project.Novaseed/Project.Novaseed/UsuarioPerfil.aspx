<%@ Page Title="Usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="UsuarioPerfil.aspx.cs" Inherits="Project.Novaseed.UsuarioPerfil" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row" style="text-align: center">
            <h3>
                <asp:Label ID="lblUsuarioModificar" runat="server" Font-Bold="true" Text="Actualizar Perfil" /></h3>
        </div>
        <br />
        <div class="row" style="text-align: center">
            <h5>
                <asp:Label ID="lblUsuarioError" runat="server" Font-Bold="true" Text="" ForeColor="Red" /></h5>
        </div>

        <div class="row">
            <div class="col-sm-3 col-sm-offset-3">
                <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Rol" ID="txtUsuarioRol" ReadOnly="true"></asp:TextBox>
                <span class="help-block">Rol</span>
            </div>
            <div class="col-sm-1" style="text-align: center">
                <h5>
                    <asp:Label ID="lblUsuarioGuion" runat="server" Font-Bold="true" Text="-" /></h5>
            </div>
            <div class="col-sm-3" style="text-align: left">
                <asp:TextBox type="text" runat="server" class="form-control" Width="30%" Placeholder="DV" ID="txtUsuarioDV" ReadOnly="true"></asp:TextBox>
                <span class="help-block">Dígito Verificador</span>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-3 col-sm-offset-3">
                <asp:RegularExpressionValidator ID="reUsuarioNombre" runat="server" ValidationExpression="^[a-zA-ZÁÉÍÓÚáéíóú]{1,1}[a-zA-ZÁÉÍÓÚáéíóú\s\-]{0,48}" ErrorMessage="Debe ser sólo letras y guión" ControlToValidate="txtUsuarioNombre" ForeColor="Red" ValidationGroup="modificarPerfil"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Nombre" ID="txtUsuarioNombre"></asp:TextBox>
                <span class="help-block">Nombre</span>
            </div>
            <div class="col-sm-3">
                <asp:RegularExpressionValidator ID="reUsuarioApellido" runat="server" ValidationExpression="^[a-zA-ZÁÉÍÓÚáéíóú]{1,1}[a-zA-ZÁÉÍÓÚáéíóú\s\-]{0,48}" ErrorMessage="Debe ser sólo letras y guión" ControlToValidate="txtUsuarioApellido" ForeColor="Red" ValidationGroup="modificarPerfil"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Apellido" ID="txtUsuarioApellido"></asp:TextBox>
                <span class="help-block">Apellido</span>
            </div>
        </div>
        <br />
        <asp:UpdatePanel runat="server" ID="UpdatePanel"
            UpdateMode="Conditional">            
            <ContentTemplate>
                <div class="row">
                    <div class="col-sm-6 col-sm-offset-3">
                        <asp:DropDownList type="button" ID="ddlUsuarioMes" runat="server" Width="49%" AppendDataBoundItems="true" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" OnSelectedIndexChanged="ddlUsuarioMes_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem Selected="True" Value="1">Enero</asp:ListItem>
                            <asp:ListItem Value="2">Febrero</asp:ListItem>
                            <asp:ListItem Value="3">Marzo</asp:ListItem>
                            <asp:ListItem Value="4">Abril</asp:ListItem>
                            <asp:ListItem Value="5">Mayo</asp:ListItem>
                            <asp:ListItem Value="6">Junio</asp:ListItem>
                            <asp:ListItem Value="7">Julio</asp:ListItem>
                            <asp:ListItem Value="8">Agosto</asp:ListItem>
                            <asp:ListItem Value="9">Septiembre</asp:ListItem>
                            <asp:ListItem Value="10">Octubre</asp:ListItem>
                            <asp:ListItem Value="11">Noviembre</asp:ListItem>
                            <asp:ListItem Value="12">Diciembre</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList type="button" ID="ddlUsuarioAño" runat="server" Width="49%" AppendDataBoundItems="true" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" OnSelectedIndexChanged="ddlUsuarioAño_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                        <asp:Calendar ID="clrUsuarioFechaNacimiento" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="100%">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                            <TodayDayStyle BackColor="#CCCCCC" />
                        </asp:Calendar>
                        <span class="help-block">Fecha Nacimiento</span>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <div class="row" style="text-align: center">
            <div class="col-sm-6 col-sm-offset-3">
                <asp:ListBox class="list-group checked-list-box" ID="lstUsuarioNacionalidad" Style="width: 70%" runat="server" SelectionMode="Multiple"></asp:ListBox>
                <span class="help-block">Nacionalidad</span>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-3 col-sm-offset-3">
                <asp:RegularExpressionValidator ID="reUsuarioEmail" runat="server" ValidationExpression="^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,3})$" ErrorMessage="Correo inválido" ControlToValidate="txtUsuarioCorreo" ForeColor="Red" ValidationGroup="modificarPerfil"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Correo Electronico" ID="txtUsuarioCorreo"></asp:TextBox>
                <span class="help-block">Correo Electrónico</span>
            </div>
            <div class="col-sm-3">
                <asp:RegularExpressionValidator ID="reUsuarioTelefono" runat="server" ValidationExpression="^[9][0-9]{8,8}$" ErrorMessage="Teléfono inválido" ControlToValidate="txtUsuarioTelefono" ForeColor="Red" ValidationGroup="modificarPerfil"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Telefono" ID="txtUsuarioTelefono"></asp:TextBox>
                <span class="help-block">Teléfono Ejemplo: 912345678</span>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-3 col-sm-offset-3">
                <asp:RegularExpressionValidator ID="reUsuarioDireccion" runat="server" ValidationExpression=".{0,299}" ErrorMessage="Dirección incorrecta" ControlToValidate="txtUsuarioDireccion" ForeColor="Red" ValidationGroup="modificarPerfil"></asp:RegularExpressionValidator>
                <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Direccion" ID="txtUsuarioDireccion"></asp:TextBox>
                <span class="help-block">Dirección</span>
            </div>
            <div class="col-sm-2" style="margin-top: 20px">
                <asp:CheckBox ID="chkUsuarioAdministrador" runat="server" Text="Administrador" />
            </div>
        </div>

        <div class="row">
            <div class="col-sm-3 col-sm-offset-3">
                <asp:DropDownList type="button" ID="ddlUsuarioSexo" runat="server" Width="90%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                <span class="help-block">Sexo</span>
            </div>
            <div class="col-sm-3">
                <asp:DropDownList type="button" ID="ddlUsuarioCargo" runat="server" Width="90%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                <span class="help-block">Cargo</span>
            </div>
        </div>

        <br />
        <br />
        <div class="row" style="text-align: center">
            <asp:Button type="button" runat="server" Text="Guardar" ID="btnUsuarioGuardar" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" ValidationGroup="modificarPerfil" CausesValidation="true" OnClientClick="return confirm('¿Desea guardar los cambios?');" OnClick="btnUsuarioGuardar_Click"></asp:Button>
            <asp:Button type="button" runat="server" Text="Cambiar Contraseña" ID="btnUsuarioCambiarContraseña" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" data-toggle="modal" data-target="#contraseña"></asp:Button>
            <asp:Button type="button" runat="server" Text="Cancelar" ID="btnUsuarioCancelar" class="btn btn-danger btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea cancelar los cambios?');" OnClick="btnUsuarioCancelar_Click"></asp:Button>
        </div>

        <!-- Modal -->
        <div id="contraseña" class="modal fade" role="dialog">
            <div class="modal-dialog">

                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Cambiar Contraseña</h4>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-sm-8 col-sm-offset-3">
                                <asp:RegularExpressionValidator ID="reUsuarioPasswordActual" runat="server" ValidationExpression=".{3,49}" ErrorMessage="Contraseña debe tener entre 3 y 49 caracteres" ControlToValidate="txtUsuarioPasswordActual" ForeColor="Red" ValidationGroup="cambiarContraseña"></asp:RegularExpressionValidator>
                                <asp:TextBox type="password" runat="server" class="form-control" Placeholder="Contraseña" ID="txtUsuarioPasswordActual"></asp:TextBox>
                                <span class="help-block">Contraseña Actual</span>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-8 col-sm-offset-3">
                                <asp:RegularExpressionValidator ID="reUsuarioPasswordNueva" runat="server" ValidationExpression=".{3,49}" ErrorMessage="Contraseña debe tener entre 3 y 49 caracteres" ControlToValidate="txtUsuarioPasswordNueva" ForeColor="Red" ValidationGroup="cambiarContraseña"></asp:RegularExpressionValidator>
                                <asp:TextBox type="password" runat="server" class="form-control" Placeholder="Contraseña" ID="txtUsuarioPasswordNueva"></asp:TextBox>
                                <span class="help-block">Nueva Contraseña</span>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-8 col-sm-offset-3">
                                <asp:RegularExpressionValidator ID="reUsuarioPasswordRepetirNueva" runat="server" ValidationExpression=".{3,49}" ErrorMessage="Contraseña debe tener entre 3 y 49 caracteres" ControlToValidate="txtUsuarioPasswordRepetirNueva" ForeColor="Red" ValidationGroup="cambiarContraseña"></asp:RegularExpressionValidator>
                                <asp:TextBox type="password" runat="server" class="form-control" Placeholder="Repita Contraseña" ID="txtUsuarioPasswordRepetirNueva"></asp:TextBox>
                                <span class="help-block">Repita Contraseña</span>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:Button type="button" runat="server" Text="Cambiar Contraseña" ID="btnUsuarioConfirmarContraseña" class="btn btn-danger btn-md" Width="40%" BorderColor="#000000" OnClientClick="return confirm('¿Desea cambiar su contraseña?');" OnClick="btnUsuarioConfirmarContraseña_Click"></asp:Button>
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>

            </div>
        </div>

    </div>
</asp:Content>
