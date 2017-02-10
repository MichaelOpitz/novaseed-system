<%@ Page Title="Registro Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="UsuarioRegistro.aspx.cs" Inherits="Project.Novaseed.UsuarioRegistro" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />

        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#home">Registro de Usuarios</a></li>
            <li><a data-toggle="tab" href="#menu1">Gráficos de Usuario</a></li>
        </ul>

        <div class="tab-content">
            <div id="home" class="tab-pane fade in active">

                <div class="row">
                    <asp:GridView ID="gdvUsuario" runat="server"
                        AutoGenerateColumns="False"
                        CssClass="table table-bordered bs-table"
                        AllowPaging="True"
                        AllowSorting="True"
                        OnRowDataBound="OnRowDataBound">

                        <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#ffffcc" />
                        <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                        <EmptyDataTemplate>
                            ¡No existen usuarios!  
                        </EmptyDataTemplate>

                        <SelectedRowStyle Font-Bold="True" />
                        <Columns>
                            <asp:BoundField DataField="rol" HeaderText="Rol" ReadOnly="true" />
                            <asp:BoundField DataField="nombre" HeaderText="Nombre" ReadOnly="true" />
                            <asp:BoundField DataField="apellido" HeaderText="Apellido" ReadOnly="true" />
                            <asp:BoundField DataField="nombre_cargo" HeaderText="Nombre Cargo" ReadOnly="true" />
                            <asp:BoundField DataField="usuario_persona" HeaderText="Usuario" ReadOnly="true" />
                            <asp:BoundField DataField="fecha_ultima_conexion" HeaderText="Ultima Conexión" ReadOnly="true" />
                        </Columns>
                    </asp:GridView>
                </div>

            </div>
            <div id="menu1" class="tab-pane fade">

                <div class="row" style="text-align: center">
                    <asp:Chart ID="chartRegistroUsuario" runat="server"
                        Height="400px" Width="500px">
                        <Titles>
                            <asp:Title ShadowOffset="3" Name="Title1" />
                        </Titles>
                        <Legends>
                            <asp:Legend Alignment="Center" Docking="Bottom"
                                IsTextAutoFit="False" Name="Default"
                                LegendStyle="Row" />
                        </Legends>
                        <Series>
                            <asp:Series Name="Default" />
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1"
                                BorderWidth="0" />
                        </ChartAreas>
                    </asp:Chart>
                </div>

            </div>
        </div>

    </div>
</asp:Content>

