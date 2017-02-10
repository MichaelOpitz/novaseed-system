<%@ Page Title="Ciudad" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="CiudadEliminar.aspx.cs" Inherits="Project.Novaseed.CiudadEliminar" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row" style="text-align: center">
            <h3>
                <asp:Label ID="lblCiudadAgregar" runat="server" Font-Bold="true" Text="Eliminar Ciudad, Provincia y/o Región" /></h3>
        </div>
        <br />
        <div class="row" style="text-align: center">
            <h5>
                <asp:Label ID="lblCiudadError" runat="server" Font-Bold="true" Text="" ForeColor="Red" /></h5>
        </div>

        <ul class="nav nav-tabs">
            <li class="active"><a class="active" data-toggle="tab" href="#home">Ciudad</a></li>
            <li><a data-toggle="tab" href="#menu1">Provincia</a></li>
            <li><a data-toggle="tab" href="#menu2">Región</a></li>
        </ul>

        <div class="tab-content">
            <div id="home" class="tab-pane fade in active">

                <div class="row" style="margin-top: 20px">
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddlCiudadPais" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" AppendDataBoundItems="true" AutoPostBack="True" OnSelectedIndexChanged="ddlCiudadPais_SelectedIndexChanged"></asp:DropDownList>
                        <span class="help-block">País</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddlCiudadRegion" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" AppendDataBoundItems="true" AutoPostBack="True" OnSelectedIndexChanged="ddlCiudadRegion_SelectedIndexChanged"></asp:DropDownList>
                        <span class="help-block">Región</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddlCiudadProvincia" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" AppendDataBoundItems="true" AutoPostBack="True" OnSelectedIndexChanged="ddlCiudadProvincia_SelectedIndexChanged"></asp:DropDownList>
                        <span class="help-block">Provincia</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddlCiudad" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Ciudad</span>
                    </div>
                </div>

                <br />
                <div class="row" style="text-align: center">
                    <asp:Button type="button" runat="server" Text="Eliminar" ID="btnCiudadEliminar" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea eliminar la ciudad?');" OnClick="btnCiudadEliminar_Click"></asp:Button>
                    <asp:Button type="button" runat="server" Text="Cancelar" ID="btnCiudadCancelar" class="btn btn-danger btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea cancelar los cambios?');" OnClick="btnCiudadCancelar_Click"></asp:Button>
                </div>

            </div>
            <div id="menu1" class="tab-pane fade">

                <asp:UpdatePanel runat="server" ID="UpdatePanel"
                    UpdateMode="Conditional">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnProvinciaEliminar"
                            EventName="Click" />
                    </Triggers>
                    <ContentTemplate>
                        <div class="row" style="margin-top: 20px">
                            <div class="col-sm-3 col-sm-offset-2">
                                <asp:DropDownList type="button" ID="ddlProvinciaPais" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" OnSelectedIndexChanged="ddlProvinciaPais_SelectedIndexChanged" AppendDataBoundItems="true" AutoPostBack="True"></asp:DropDownList>
                                <span class="help-block">País</span>
                            </div>
                            <div class="col-sm-3">
                                <asp:DropDownList type="button" ID="ddlProvinciaRegion" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" OnSelectedIndexChanged="ddlProvinciaRegion_SelectedIndexChanged" AppendDataBoundItems="true" AutoPostBack="True"></asp:DropDownList>
                                <span class="help-block">Región</span>
                            </div>
                            <div class="col-sm-3">
                                <asp:DropDownList type="button" ID="ddlProvincia" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                                <span class="help-block">Provincia</span>
                            </div>
                        </div>

                        <br />
                        <div class="row" style="text-align: center">
                            <asp:Button type="button" runat="server" Text="Eliminar" ID="btnProvinciaEliminar" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea eliminar la provincia?');" OnClick="btnProvinciaEliminar_Click"></asp:Button>
                            <asp:Button type="button" runat="server" Text="Cancelar" ID="btnProvinciaCancelar" class="btn btn-danger btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea cancelar los cambios?');" OnClick="btnProvinciaCancelar_Click"></asp:Button>
                        </div>

                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div id="menu2" class="tab-pane fade">

                <asp:UpdatePanel runat="server" ID="UpdatePanel2"
                    UpdateMode="Conditional">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnRegionEliminar"
                            EventName="Click" />
                    </Triggers>
                    <ContentTemplate>
                        <div class="row" style="margin-top: 20px">
                            <div class="col-sm-3 col-sm-offset-3">
                                <asp:DropDownList type="button" ID="ddlRegionPais" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" OnSelectedIndexChanged="ddlRegionPais_SelectedIndexChanged" AppendDataBoundItems="true" AutoPostBack="True"></asp:DropDownList>
                                <span class="help-block">País</span>
                            </div>
                            <div class="col-sm-3">
                                <asp:DropDownList type="button" ID="ddlRegion" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                                <span class="help-block">Región</span>
                            </div>
                        </div>

                        <br />
                        <div class="row" style="text-align: center">
                            <asp:Button type="button" runat="server" Text="Eliminar" ID="btnRegionEliminar" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea eliminar la región?');" OnClick="btnRegionEliminar_Click"></asp:Button>
                            <asp:Button type="button" runat="server" Text="Cancelar" ID="btnRegionCancelar" class="btn btn-danger btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea cancelar los cambios?');" OnClick="btnRegionCancelar_Click"></asp:Button>
                        </div>

                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>

    </div>
</asp:Content>

