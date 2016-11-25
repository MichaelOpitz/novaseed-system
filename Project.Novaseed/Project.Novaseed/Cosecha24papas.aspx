<%@ Page Title="24 Papas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Cosecha24papas.aspx.cs" Inherits="Project.Novaseed.Cosecha24papas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row">
            <h2>
                <asp:Label ID="lbl24papasAño" runat="server" Font-Bold="true" Text="24 Papas" /></h2>
        </div>
        <br />
        <div class="row">
            <asp:Button type="button" runat="server" ID="btnAgregar48papas" class="btn btn-danger btn-block" Style="border-color: #000000" Text="Agregar a 48 Papas" OnClientClick="return confirm('¿Desea agregar a 48 Papas?');" OnClick="btnAgregar48papas_Click"></asp:Button>
        </div>
        <div class="row">
            <asp:GridView ID="gdv24papas" runat="server"
                DataKeyNames="id_cosecha"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
                OnRowDataBound="OnRowDataBound"
                OnRowDeleting="Cosecha24papasGridView_RowDeleting" OnSelectedIndexChanged="gdv24papas_SelectedIndexChanged">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay datos en el año seleccionado!  
                </EmptyDataTemplate>

                <SelectedRowStyle Font-Bold="True" />
                <Columns>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="50px" HeaderText="Agregar a 48 Papas">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkAgregar48Papas" runat="server" AutoPostBack="true" />
                        </ItemTemplate>
                        <HeaderStyle Width="100px"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>

                    <%--botones de acción sobre los registros...--%>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="100px">
                        <ItemTemplate>
                            <%--Botones de eliminar y editar cliente...--%>
                            <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Eliminar variedad de 24 papas?\nSi lo hace eliminará todos los registros de etapas avanzadas');" />
                        </ItemTemplate>
                        <HeaderStyle Width="100px"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>

                    <asp:BoundField DataField="id_cosecha" HeaderText="ID" ReadOnly="true" />
                    <asp:BoundField DataField="codigo_variedad" HeaderText="Madre" ReadOnly="true" HeaderStyle-Width="100px" />
                    <asp:BoundField DataField="nombre_madre" HeaderText="Nombre Madre" ReadOnly="true" />
                    <asp:BoundField DataField="pad_codigo_variedad" HeaderText="Padre" ReadOnly="true" HeaderStyle-Width="100px" />
                    <asp:BoundField DataField="nombre_padre" HeaderText="Nombre Padre" ReadOnly="true" />
                    <asp:BoundField DataField="posicion_cosecha" HeaderText="Posición" ReadOnly="true" />
                    <asp:BoundField DataField="codigo_individuo" HeaderText="Código Individuo" ReadOnly="true" HeaderStyle-Width="100px" />
                    <asp:BoundField DataField="nombre_destino" HeaderText="Destino" ReadOnly="true" />

                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />

                </Columns>
            </asp:GridView>
        </div>

        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">Código Individuo y Emergencias</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" ID="txt24papasCodigoSeleccionado" Placeholder="Código" Style="border: 3px double #000000" ReadOnly="true" Font-Bold="true"></asp:TextBox>
                        <span class="help-block" style="font: 700">Código Seleccionado</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" ID="txt24papasCantidadPapas" Placeholder="Cantidad Papas" Style="border: 3px solid #1E90FF"></asp:TextBox>
                        <span class="help-block">Cantidad de Papas</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" ID="txt24papasPosicion" Placeholder="Posición" Style="border: 3px solid #1E90FF"></asp:TextBox>
                        <span class="help-block">Posición</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:CheckBox ID="chk24papasFlor" runat="server" AutoPostBack="true" Text="Flor" />
                    </div>
                    <div class="col-sm-2">
                        <asp:CheckBox ID="chk24papasBayas" runat="server" AutoPostBack="true" Text="Bayas" />
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl24papasFertilidad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Fertilidad</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl24papasEmergencia40" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Emergencia a 40 Días</span>
                    </div>

                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl24papasMetribuzina" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Metribuzina</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl24papasEmergencia" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Emergencia</span>
                    </div>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="panel panel-success">
            <div class="panel-heading" style="text-align: center">Planta</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-3 ">
                        <asp:DropDownList type="button" ID="ddl24papasMadurez" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Madurez</span>
                    </div>
                    <div class="col-sm-5">
                        <asp:DropDownList type="button" ID="ddl24papasDesarrollo" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Desarrollo Follaje</span>
                    </div>
                    <div class="col-sm-4">
                        <asp:DropDownList type="button" ID="ddl24papasTipoHoja" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Tipo Hoja</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl24papasBrotacion" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Brotación</span>
                    </div>
                    <div class="col-sm-5">
                        <asp:DropDownList type="button" ID="ddl24papasTamaño" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Tamaño</span>
                    </div>
                    <div class="col-sm-4">
                        <asp:DropDownList type="button" ID="ddl24papasDistribucion" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Distribución Calibre</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl24papasForma" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Forma</span>
                    </div>
                    <div class="col-sm-5">
                        <asp:DropDownList type="button" ID="ddl24papasRegularidad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Regularidad</span>
                    </div>
                    <div class="col-sm-4">
                        <asp:DropDownList type="button" ID="ddl24papasProfundidad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Profundidad Ojo</span>
                    </div>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">Calidad y Tizones</div>
            <div class="panel-body">
                <br />
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl24papasCalidadPiel" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Calidad Piel</span>
                </div>
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl24papasTuberculosVerdes" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Tubérculos Verdes</span>
                </div>
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl24papasTizonFollaje" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Tizon Tardío Follaje</span>
                </div>

                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl24papasTizonTuberculo" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Tizon Tardío Tubérculo</span>
                </div>
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl24papasNumero" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Numero de Tubérculos</span>
                </div>
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl24papasCiudadPlantacion" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Ciudad de Plantación</span>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="panel panel-info" style="text-align: center">
            <div class="panel-heading" style="text-align: center">Colores de carne y piel</div>
            <div class="panel-body">
                <br />
                <div class="col-sm-6">
                    <asp:ListBox class="list-group checked-list-box" ID="lst24papasColorCarne" Style="width: 70%" runat="server" SelectionMode="Multiple"></asp:ListBox>
                    <span class="help-block">Color Carne</span>
                </div>
                <div class="col-sm-6">
                    <asp:ListBox class="list-group checked-list-box" ID="lst24papasColorPiel" Style="width: 70%" runat="server" SelectionMode="Multiple"></asp:ListBox>
                    <span class="help-block">Color Piel</span>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="panel panel-danger">
            <div class="panel-heading" style="text-align: center">Totales</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-2 col-sm-offset-1">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Total Kilogramos" ID="txt24papasTotalKg"></asp:TextBox>
                        <span class="help-block">Total Kilogramos</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tubérculos/planta" ID="txt24papasTuberculosPlanta"></asp:TextBox>
                        <span class="help-block">Tubérculos/Planta</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Consumo" ID="txt24papasConsumo"></asp:TextBox>
                        <span class="help-block">Consumo</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Semillón" ID="txt24papasSemillon"></asp:TextBox>
                        <span class="help-block">Semillón</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Toneladas/Hectárea" ID="txt24papasToneladasHectarea" ReadOnly="true"></asp:TextBox>
                        <span class="help-block">Toneladas/Hectárea</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-2 col-sm-offset-1">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Semilla" ID="txt24papasSemilla"></asp:TextBox>
                        <span class="help-block">Semilla</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Semillita" ID="txt24papasSemillita"></asp:TextBox>
                        <span class="help-block">Semillita</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Bajo Calibre" ID="txt24papasBajoCalibre"></asp:TextBox>
                        <span class="help-block">Bajo Calibre</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Número Tallos" ID="txt24papasNumeroTallos"></asp:TextBox>
                        <span class="help-block">Número Tallos</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="% Relación Standard" ID="txt24papasRelacionStandard" ReadOnly="true"></asp:TextBox>
                        <span class="help-block">% Relación Standard</span>
                    </div>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">Enfermedades</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-5 col-sm-offset-1">
                        <asp:DropDownList type="button" ID="ddl24papasEnfermedad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Enfermedad</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl24papasResistencia" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Resistencia</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:Button type="button" runat="server" Text="Agregar Enfermedad" ID="btn24papasAgregarEnfermedad" class="btn btn-primary btn-md" BorderColor="#000000" OnClick="btn24papasAgregarEnfermedad_Click"></asp:Button>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-9 col-sm-offset-3">
                        <asp:GridView ID="gdv24papasEnfermedades" runat="server" Width="70%"
                            AutoGenerateColumns="False"
                            CssClass="table table-bordered bs-table"
                            AllowPaging="True"
                            AllowSorting="True"
                            OnRowDeleting="Cosecha24papasEnfermedadesGridView_RowDeleting">

                            <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                            <EditRowStyle BackColor="#ffffcc" />
                            <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                            <EmptyDataTemplate>
                                ¡No hay enfermedades en la variedad seleccionada!  
                            </EmptyDataTemplate>

                            <SelectedRowStyle Font-Bold="True" />
                            <Columns>
                                <asp:BoundField DataField="nombre_enfermedad" HeaderText="Enfermedad" ReadOnly="true" />
                                <asp:BoundField DataField="resistencia_variedad" HeaderText="Resistencia Variedad" ReadOnly="true" />

                                <%--botones de acción sobre los registros...--%>
                                <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="100px">
                                    <ItemTemplate>
                                        <%--Botones de eliminar y editar cliente...--%>
                                        <asp:Button ID="btnDeleteEnfermedad" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Deseas eliminar la enfermedad?');" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="100px"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                </asp:TemplateField>

                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">Sensibilidad y Tolerancias</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-2 ">
                        <asp:DropDownList type="button" ID="ddl24papasSensibilidadQuimica" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Sensibilidad Química</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Daño Cosecha" ID="txt24papasDañoCosecha"></asp:TextBox>
                        <span class="help-block">Daño Cosecha</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Dormancia" ID="txt24papasDormancia"></asp:TextBox>
                        <span class="help-block">Dormancia</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tizon Hoja" ID="txt24papasTizonHoja"></asp:TextBox>
                        <span class="help-block">Tizón Hoja</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-2 ">
                        <asp:DropDownList type="button" ID="ddl24papasFacilidadMuerte" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Facilidad Muerte</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tolerancia Sequía" ID="txt24papasToleranciaSequia"></asp:TextBox>
                        <span class="help-block">Tolerancia Sequía</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tolerancia Calor" ID="txt24papasToleranciaCalor"></asp:TextBox>
                        <span class="help-block">Tolerancia Calor</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tolerancia Sal" ID="txt24papasToleranciaSal"></asp:TextBox>
                        <span class="help-block">Tolerancia Sal</span>
                    </div>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">Urgencias</div>
            <div class="panel-body">
                <br />
                <div class="col-sm-2 col-sm-offset-1">
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Putrefacción Suave" ID="txt24papasPutrefaccionSuave"></asp:TextBox>
                    <span class="help-block">Putrefacción Suave</span>
                </div>
                <div class="col-sm-2">
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Putrefacción Rosa" ID="txt24papasPutrefaccionRosa"></asp:TextBox>
                    <span class="help-block">Putrefacción Rosa</span>
                </div>
                <div class="col-sm-2">
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Silver Scurf" ID="txt24papasSilverScurf"></asp:TextBox>
                    <span class="help-block">Silver Scurf</span>
                </div>
                <div class="col-sm-2">
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Blackleg" ID="txt24papasBlackleg"></asp:TextBox>
                    <span class="help-block">Blackleg</span>
                </div>
                <div class="col-sm-2">
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Hematomas" ID="txt24papasHematomas" ReadOnly="true"></asp:TextBox>
                    <span class="help-block">Hematomas</span>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="row" style="text-align: center">
            <asp:Button type="button" runat="server" Text="Guardar" ID="btn24papasGuardar" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea guardar los cambios?');" OnClick="btn24papasGuardar_Click"></asp:Button>
            <asp:Button type="button" runat="server" Text="Cancelar" ID="btn24papasCancelar" class="btn btn-danger btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea cancelar los cambios?');" OnClick="btn24papasCancelar_Click"></asp:Button>
        </div>
    </div>
</asp:Content>

