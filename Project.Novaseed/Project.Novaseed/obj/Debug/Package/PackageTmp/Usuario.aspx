﻿<%@ Page Title="Usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Usuario.aspx.cs" Inherits="Project.Novaseed.Usuario" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row" style="text-align: center">
            <h3>
                <asp:Label ID="lblUsuarioAgregar" runat="server" Font-Bold="true" Text="Administración de Usuario" /></h3>
        </div>
        <br />
        <div class="row" style="text-align: center">
            <h5>
                <asp:Label ID="lblUsuarioError" runat="server" Font-Bold="true" Text="" ForeColor="Red" /></h5>
        </div>

        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#home">Agregar Usuario</a></li>
            <li><a data-toggle="tab" href="#menu1">Eliminar Usuario</a></li>
        </ul>

        <div class="tab-content">
            <div id="home" class="tab-pane fade in active">

                <div class="row">
                    <div class="col-sm-3 col-sm-offset-3">
                        <asp:RegularExpressionValidator ID="reUsuarioRol" runat="server" ValidationExpression="^[1-9]{1,1}[0-9]{6,7}" ErrorMessage="Rol incorrecto" ControlToValidate="txtUsuarioRol" ForeColor="Red" ValidationGroup="agregarUsuario"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Rol" ID="txtUsuarioRol"></asp:TextBox>
                        <span class="help-block">Rol, Ejemplo: 12345678</span>
                    </div>
                    <div class="col-sm-1" style="margin-top: 20px; text-align: center">
                        <h5>
                            <asp:Label ID="lblUsuarioGuion" runat="server" Font-Bold="true" Text="-" /></h5>
                    </div>
                    <div class="col-sm-3" style="text-align: left">
                        <asp:RegularExpressionValidator ID="reUsuarioDV" runat="server" ValidationExpression="^[0-9]{1,1}|[kK]{1,1}" ErrorMessage="DV incorrecto" ControlToValidate="txtUsuarioDV" ForeColor="Red" ValidationGroup="agregarUsuario"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Width="30%" Placeholder="DV" ID="txtUsuarioDV"></asp:TextBox>
                        <span class="help-block">Dígito Verificador</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-3 col-sm-offset-3">
                        <asp:RegularExpressionValidator ID="reUsuarioNombre" runat="server" ValidationExpression="^[a-zA-ZÁÉÍÓÚáéíóú]{1,1}[a-zA-ZÁÉÍÓÚáéíóú\s\-]{0,48}" ErrorMessage="Debe ser sólo letras y guión" ControlToValidate="txtUsuarioNombre" ForeColor="Red" ValidationGroup="agregarUsuario"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Nombre" ID="txtUsuarioNombre"></asp:TextBox>
                        <span class="help-block">Nombre</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="reUsuarioApellido" runat="server" ValidationExpression="^[a-zA-ZÁÉÍÓÚáéíóú]{1,1}[a-zA-ZÁÉÍÓÚáéíóú\s\-]{0,48}" ErrorMessage="Debe ser sólo letras y guión" ControlToValidate="txtUsuarioApellido" ForeColor="Red" ValidationGroup="agregarUsuario"></asp:RegularExpressionValidator>
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
                        <asp:RegularExpressionValidator ID="reUsuarioEmail" runat="server" ValidationExpression="^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,3})$" ErrorMessage="Correo inválido" ControlToValidate="txtUsuarioCorreo" ForeColor="Red" ValidationGroup="agregarUsuario"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Correo Electronico" ID="txtUsuarioCorreo"></asp:TextBox>
                        <span class="help-block">Correo Electrónico</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="reUsuarioTelefono" runat="server" ValidationExpression="^[9][0-9]{8,8}$" ErrorMessage="Teléfono inválido" ControlToValidate="txtUsuarioTelefono" ForeColor="Red" ValidationGroup="agregarUsuario"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Telefono" ID="txtUsuarioTelefono"></asp:TextBox>
                        <span class="help-block">Teléfono Ejemplo: 912345678</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-3 col-sm-offset-3">
                        <asp:RegularExpressionValidator ID="reUsuarioDireccion" runat="server" ValidationExpression=".{0,299}" ErrorMessage="Dirección incorrecta" ControlToValidate="txtUsuarioDireccion" ForeColor="Red" ValidationGroup="agregarUsuario"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Direccion" ID="txtUsuarioDireccion"></asp:TextBox>
                        <span class="help-block">Dirección</span>
                    </div>
                    <div class="col-sm-2" style="margin-top: 20px">
                        <asp:CheckBox ID="chkUsuarioAdministrador" runat="server" Text="Administrador" class="checkbox" />
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
                <div class="row">
                    <div class="col-sm-7 col-sm-offset-3">
                        <asp:FileUpload ID="FileUpload1" runat="server" class="btn btn-default btn-md" type="button" Width="100%" Height="100%"/>
                        <span class="help-block">Subir Imagen</span>
                    </div>
                </div>

                <br />
                <div class="row">
                    <div class="col-sm-3 col-sm-offset-2">
                        <asp:RegularExpressionValidator ID="reUsuarioUser" runat="server" ValidationExpression="^[a-z]{3,49}$" ErrorMessage="Usuario debe tener entre 3 y 49 caracteres" ControlToValidate="txtUsuarioUser" ForeColor="Red" ValidationGroup="agregarUsuario"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Usuario" ID="txtUsuarioUser"></asp:TextBox>
                        <span class="help-block">Usuario</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="reUsuarioPassword" runat="server" ValidationExpression=".{3,49}" ErrorMessage="Contraseña debe tener entre 3 y 49 caracteres" ControlToValidate="txtUsuarioPassword" ForeColor="Red" ValidationGroup="agregarUsuario"></asp:RegularExpressionValidator>
                        <asp:TextBox type="password" runat="server" class="form-control" Placeholder="Contraseña" ID="txtUsuarioPassword"></asp:TextBox>
                        <span class="help-block">Contraseña</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="reUsuarioPasswordRepetir" runat="server" ValidationExpression=".{3,49}" ErrorMessage="Contraseña debe tener entre 3 y 49 caracteres" ControlToValidate="txtUsuarioPasswordRepetir" ForeColor="Red" ValidationGroup="agregarUsuario"></asp:RegularExpressionValidator>
                        <asp:TextBox type="password" runat="server" class="form-control" Placeholder="Repita Contraseña" ID="txtUsuarioPasswordRepetir"></asp:TextBox>
                        <span class="help-block">Repita Contraseña</span>
                    </div>
                </div>

                <br />
                <br />
                <div class="row" style="text-align: center">
                    <asp:Button type="button" runat="server" Text="Guardar" ID="btnUsuarioGuardar" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" ValidationGroup="agregarUsuario" CausesValidation="true" OnClientClick="return confirm('¿Desea guardar los cambios?');" OnClick="btnUsuarioGuardar_Click"></asp:Button>
                    <asp:Button type="button" runat="server" Text="Cancelar" ID="btnUsuarioCancelar" class="btn btn-danger btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea cancelar los cambios?');" OnClick="btnUsuarioCancelar_Click"></asp:Button>
                </div>

            </div>
            <div id="menu1" class="tab-pane fade">

                <asp:UpdatePanel runat="server" ID="UpdatePanel2"
                    UpdateMode="Conditional">
                    <ContentTemplate>
                        <div class="row">
                            <asp:GridView ID="gdvUsuario" runat="server"
                                AutoGenerateColumns="False"
                                CssClass="table table-bordered bs-table"
                                AllowPaging="True"
                                AllowSorting="True"
                                OnRowDataBound="OnRowDataBound"
                                OnRowDeleting="UsuarioGridView_RowDeleting">

                                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#ffffcc" />
                                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                                <EmptyDataTemplate>
                                    ¡No hay usuarios en el sistema!
                                </EmptyDataTemplate>

                                <Columns>
                                    <%--botones de acción sobre los registros...--%>
                                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="180px">
                                        <ItemTemplate>
                                            <%--Botones de eliminar y editar cliente...--%>
                                            <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Desea eliminar el usuario seleccionado?');" />
                                        </ItemTemplate>
                                        <HeaderStyle Width="200px"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:TemplateField>

                                    <asp:BoundField DataField="rol" HeaderText="Rol" ReadOnly="true" />
                                    <asp:BoundField DataField="dv" HeaderText="DV" ReadOnly="true" HeaderStyle-Width="30px" />
                                    <asp:BoundField DataField="nombre" HeaderText="Nombre" ReadOnly="true" />
                                    <asp:BoundField DataField="apellido" HeaderText="Apellido" ReadOnly="true" />
                                    <asp:BoundField DataField="nombre_cargo" HeaderText="Nombre Cargo" ReadOnly="true" />
                                    <asp:BoundField DataField="usuario_persona" HeaderText="Usuario" ReadOnly="true" />
                                    <asp:BoundField DataField="email" HeaderText="Email" ReadOnly="true" />

                                </Columns>
                            </asp:GridView>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>

            </div>
        </div>

    </div>
</asp:Content>
