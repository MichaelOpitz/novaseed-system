<%@ Page Title="Ciudad" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="CiudadActualizar.aspx.cs" Inherits="Project.Novaseed.CiudadActualizar" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row" style="text-align: center">
            <h3>
                <asp:Label ID="lblCiudadActualizar" runat="server" Font-Bold="true" Text="Modificar Ciudad, Provincia y/o Región" /></h3>
        </div>
        <br />
        <div class="row" style="text-align: center">
            <h5>
                <asp:Label ID="lblCiudadError" runat="server" Font-Bold="true" Text="" ForeColor="Red" /></h5>
        </div>


        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#home">Ciudad</a></li>
            <li><a data-toggle="tab" href="#menu1">Provincia</a></li>
            <li><a data-toggle="tab" href="#menu2">Región</a></li>
        </ul>

        <div class="tab-content">
            <div id="home" class="tab-pane fade in active">

                <div class="row" style="margin-top: 20px">
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="reCiudadPais" runat="server" ValidationExpression="." ErrorMessage="Debe ser entre 2 y 99" ControlToValidate="ddlCiudadPais" ForeColor="White"></asp:RegularExpressionValidator>
                        <asp:DropDownList type="button" ID="ddlCiudadPais" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" OnSelectedIndexChanged="ddlCiudadPais_SelectedIndexChanged" AppendDataBoundItems="true" AutoPostBack="True"></asp:DropDownList>
                        <span class="help-block">País</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="reCiudadRegion" runat="server" ValidationExpression="." ErrorMessage="Debe ser entre 2 y 99" ControlToValidate="ddlCiudadRegion" ForeColor="White"></asp:RegularExpressionValidator>
                        <asp:DropDownList type="button" ID="ddlCiudadRegion" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" AppendDataBoundItems="true" AutoPostBack="True" OnSelectedIndexChanged="ddlCiudadRegion_SelectedIndexChanged"></asp:DropDownList>
                        <span class="help-block">Región</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="reCiudadProvincia" runat="server" ValidationExpression="." ErrorMessage="Debe ser entre 2 y 99" ControlToValidate="ddlCiudadProvincia" ForeColor="White"></asp:RegularExpressionValidator>
                        <asp:DropDownList type="button" ID="ddlCiudadProvincia" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" AppendDataBoundItems="true" AutoPostBack="True" OnSelectedIndexChanged="ddlCiudadProvincia_SelectedIndexChanged"></asp:DropDownList>
                        <span class="help-block">Provincia</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="reCiudadDDL" runat="server" ValidationExpression="." ErrorMessage="Debe ser entre 2 y 99" ControlToValidate="ddlCiudad" ForeColor="White"></asp:RegularExpressionValidator>
                        <asp:DropDownList type="button" ID="ddlCiudad" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Ciudad</span>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3 col-sm-offset-1">
                        <asp:RegularExpressionValidator ID="reCiudadTXT" runat="server" ValidationExpression=".{2,99}" ErrorMessage="Debe ser entre 2 y 99" ControlToValidate="txtCiudad" ForeColor="Red" ValidationGroup="ingresarCiudad"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Ingrese Ciudad" ID="txtCiudad"></asp:TextBox>
                        <span class="help-block">Ciudad</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression=".{2,99}" ErrorMessage="Debe ser entre 2 y 99" ControlToValidate="txtCiudad" ForeColor="Red" ValidationGroup="ingresarCiudad"></asp:RegularExpressionValidator>
                        <asp:Button type="button" runat="server" Text="Guardar" ID="btnCiudadGuardar" class="btn btn-primary btn-md" Width="90%" BorderColor="#000000" ValidationGroup="ingresarCiudad" CausesValidation="true" OnClientClick="return confirm('¿Desea guardar los cambios?');" OnClick="btnCiudadGuardar_Click"></asp:Button>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ValidationExpression=".{2,99}" ErrorMessage="Debe ser entre 2 y 99" ControlToValidate="txtCiudad" ForeColor="Red" ValidationGroup="ingresarCiudad"></asp:RegularExpressionValidator>
                        <asp:Button type="button" runat="server" Text="Cancelar" ID="btnCiudadCancelar" class="btn btn-danger btn-md" Width="90%" BorderColor="#000000" OnClientClick="return confirm('¿Desea cancelar los cambios?');" OnClick="btnCiudadCancelar_Click"></asp:Button>
                    </div>
                </div>

            </div>
            <div id="menu1" class="tab-pane fade">

                <asp:UpdatePanel runat="server" ID="UpdatePanel"
                    UpdateMode="Conditional">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnProvinciaGuardar"
                            EventName="Click" />
                    </Triggers>
                    <ContentTemplate>
                        <div class="row" style="margin-top: 20px">
                            <div class="col-sm-3">
                                <asp:RegularExpressionValidator ID="reProvinciaPais" runat="server" ValidationExpression="." ErrorMessage="Debe ser entre 2 y 99" ControlToValidate="ddlProvinciaPais" ForeColor="White"></asp:RegularExpressionValidator>
                                <asp:DropDownList type="button" ID="ddlProvinciaPais" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" OnSelectedIndexChanged="ddlProvinciaPais_SelectedIndexChanged" AppendDataBoundItems="true" AutoPostBack="True"></asp:DropDownList>
                                <span class="help-block">País</span>
                            </div>
                            <div class="col-sm-3">
                                <asp:RegularExpressionValidator ID="reProvinciaRegion" runat="server" ValidationExpression="." ErrorMessage="Debe ser entre 2 y 99" ControlToValidate="ddlProvinciaRegion" ForeColor="White"></asp:RegularExpressionValidator>
                                <asp:DropDownList type="button" ID="ddlProvinciaRegion" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" AppendDataBoundItems="true" AutoPostBack="True" OnSelectedIndexChanged="ddlProvinciaRegion_SelectedIndexChanged"></asp:DropDownList>
                                <span class="help-block">Región</span>
                            </div>
                            <div class="col-sm-3">
                                <asp:RegularExpressionValidator ID="reProvinciaDDL" runat="server" ValidationExpression="." ErrorMessage="Debe ser entre 2 y 99" ControlToValidate="ddlProvincia" ForeColor="White"></asp:RegularExpressionValidator>
                                <asp:DropDownList type="button" ID="ddlProvincia" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                                <span class="help-block">Provincia</span>
                            </div>
                            <div class="col-sm-3">
                                <asp:RegularExpressionValidator ID="reProvinciaTXT" runat="server" ValidationExpression=".{2,99}" ErrorMessage="Debe ser entre 2 y 99" ControlToValidate="txtProvincia" ForeColor="Red" ValidationGroup="ingresarProvincia"></asp:RegularExpressionValidator>
                                <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Ingrese Provincia" ID="txtProvincia"></asp:TextBox>
                                <span class="help-block">Provincia</span>
                            </div>
                        </div>

                        <br />
                        <div class="row" style="text-align: center">
                            <asp:Button type="button" runat="server" Text="Guardar" ID="btnProvinciaGuardar" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" ValidationGroup="ingresarProvincia" CausesValidation="true" OnClientClick="return confirm('¿Desea guardar los cambios?');" OnClick="btnProvinciaGuardar_Click"></asp:Button>
                            <asp:Button type="button" runat="server" Text="Cancelar" ID="btnProvinciaCancelar" class="btn btn-danger btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea cancelar los cambios?');" OnClick="btnProvinciaCancelar_Click"></asp:Button>
                        </div>

                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div id="menu2" class="tab-pane fade">

                <asp:UpdatePanel runat="server" ID="UpdatePanel2"
                    UpdateMode="Conditional">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnRegionGuardar"
                            EventName="Click" />
                    </Triggers>
                    <ContentTemplate>
                        <div class="row" style="margin-top: 20px">
                            <div class="col-sm-3 col-sm-offset-2">
                                <asp:RegularExpressionValidator ID="reRegionPais" runat="server" ValidationExpression="." ErrorMessage="Debe ser entre 2 y 99" ControlToValidate="ddlRegionPais" ForeColor="White"></asp:RegularExpressionValidator>
                                <asp:DropDownList type="button" ID="ddlRegionPais" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" OnSelectedIndexChanged="ddlRegionPais_SelectedIndexChanged" AppendDataBoundItems="true" AutoPostBack="True"></asp:DropDownList>
                                <span class="help-block">País</span>
                            </div>
                            <div class="col-sm-3">
                                <asp:RegularExpressionValidator ID="reRegionDDL" runat="server" ValidationExpression="." ErrorMessage="Debe ser entre 2 y 99" ControlToValidate="ddlRegion" ForeColor="White"></asp:RegularExpressionValidator>
                                <asp:DropDownList type="button" ID="ddlRegion" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                                <span class="help-block">Región</span>
                            </div>
                            <div class="col-sm-3">
                                <asp:RegularExpressionValidator ID="reRegionTXT" runat="server" ValidationExpression=".{2,99}" ErrorMessage="Debe ser entre 2 y 99" ControlToValidate="txtRegion" ForeColor="Red" ValidationGroup="ingresarRegion"></asp:RegularExpressionValidator>
                                <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Ingrese Región" ID="txtRegion"></asp:TextBox>
                                <span class="help-block">Región</span>
                            </div>
                        </div>

                        <br />
                        <div class="row" style="text-align: center">
                            <asp:Button type="button" runat="server" Text="Guardar" ID="btnRegionGuardar" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" ValidationGroup="ingresarRegion" CausesValidation="true" OnClientClick="return confirm('¿Desea guardar los cambios?');" OnClick="btnRegionGuardar_Click"></asp:Button>
                            <asp:Button type="button" runat="server" Text="Cancelar" ID="btnRegionCancelar" class="btn btn-danger btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea cancelar los cambios?');" OnClick="btnRegionCancelar_Click"></asp:Button>
                        </div>

                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>

    </div>
</asp:Content>

