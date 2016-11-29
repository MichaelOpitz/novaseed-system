<%@ Page Title="12 Papas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Cosecha12papas.aspx.cs" Inherits="Project.Novaseed.Cosecha12papas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row">
            <h2>
                <asp:Label ID="lbl12papasAño" runat="server" Font-Bold="true" Text="12 Papas" /></h2>
        </div>
        <br />
        <div class="row">
            <asp:Button type="button" runat="server" ID="btnAgregar24papas" class="btn btn-danger btn-block" Style="border-color: #000000" Text="Agregar a 24 Papas" OnClientClick="return confirm('¿Desea agregar a 24 Papas?');" OnClick="btnAgregar24papas_Click1"></asp:Button>
        </div>
        <div class="row">
            <asp:GridView ID="gdv12papas" runat="server"
                DataKeyNames="id_cosecha"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
                OnRowDataBound="OnRowDataBound"
                OnRowDeleting="Cosecha12papasGridView_RowDeleting" OnSelectedIndexChanged="gdv12papas_SelectedIndexChanged">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay datos en el año seleccionado!  
                </EmptyDataTemplate>

                <SelectedRowStyle Font-Bold="True" />
                <Columns>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="50px" HeaderText="Agregar a 24 Papas">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkAgregar24Papas" runat="server" AutoPostBack="true" />
                        </ItemTemplate>
                        <HeaderStyle Width="100px"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>

                    <%--botones de acción sobre los registros...--%>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="100px">
                        <ItemTemplate>
                            <%--Botones de eliminar y editar cliente...--%>
                            <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Eliminar variedad de 12 papas?\nSi lo hace eliminará todos los registros de etapas avanzadas');" />
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
                        <asp:TextBox type="text" runat="server" class="form-control" ID="txt12papasCodigoSeleccionado" Placeholder="Código" Style="border: 3px double #000000" ReadOnly="true" Font-Bold="true"></asp:TextBox>
                        <span class="help-block" style="font: 700">Código Seleccionado</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" ID="txt12papasCantidadPapas" Placeholder="Cantidad Papas" Style="border: 3px solid #1E90FF"></asp:TextBox>
                        <span class="help-block">Cantidad de Papas</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" ID="txt12papasPosicion" Placeholder="Posición" Style="border: 3px solid #1E90FF"></asp:TextBox>
                        <span class="help-block">Posición</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:CheckBox ID="chk12papasFlor" runat="server" AutoPostBack="true" Text="Flor" />
                    </div>
                    <div class="col-sm-2">
                        <asp:CheckBox ID="chk12papasBayas" runat="server" AutoPostBack="true" Text="Bayas" />
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl12papasFertilidad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Fertilidad</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl12papasEmergencia40" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Emergencia a 40 Días</span>
                    </div>

                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl12papasMetribuzina" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Metribuzina</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl12papasEmergencia" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
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
                        <asp:DropDownList type="button" ID="ddl12papasMadurez" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Madurez</span>
                    </div>
                    <div class="col-sm-5">
                        <asp:DropDownList type="button" ID="ddl12papasDesarrollo" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Desarrollo Follaje</span>
                    </div>
                    <div class="col-sm-4">
                        <asp:DropDownList type="button" ID="ddl12papasTipoHoja" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Tipo Hoja</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl12papasBrotacion" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Brotación</span>
                    </div>
                    <div class="col-sm-5">
                        <asp:DropDownList type="button" ID="ddl12papasTamaño" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Tamaño</span>
                    </div>
                    <div class="col-sm-4">
                        <asp:DropDownList type="button" ID="ddl12papasDistribucion" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Distribución Calibre</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl12papasForma" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Forma</span>
                    </div>
                    <div class="col-sm-5">
                        <asp:DropDownList type="button" ID="ddl12papasRegularidad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Regularidad</span>
                    </div>
                    <div class="col-sm-4">
                        <asp:DropDownList type="button" ID="ddl12papasProfundidad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
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
                    <asp:DropDownList type="button" ID="ddl12papasCalidadPiel" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Calidad Piel</span>
                </div>
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl12papasTuberculosVerdes" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Tubérculos Verdes</span>
                </div>
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl12papasTizonFollaje" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Tizon Tardío Follaje</span>
                </div>

                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl12papasTizonTuberculo" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Tizon Tardío Tubérculo</span>
                </div>
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl12papasNumero" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Numero de Tubérculos</span>
                </div>
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl12papasCiudadPlantacion" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
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
                    <asp:ListBox class="list-group checked-list-box" ID="lst12papasColorCarne" Style="width: 70%" runat="server" SelectionMode="Multiple"></asp:ListBox>
                    <span class="help-block">Color Carne</span>
                </div>
                <div class="col-sm-6">
                    <asp:ListBox class="list-group checked-list-box" ID="lst12papasColorPiel" Style="width: 70%" runat="server" SelectionMode="Multiple"></asp:ListBox>
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
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Total Kilogramos" ID="txt12papasTotalKg"></asp:TextBox>
                        <span class="help-block">Total Kilogramos</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tubérculos/planta" ID="txt12papasTuberculosPlanta"></asp:TextBox>
                        <span class="help-block">Tubérculos/Planta</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Consumo" ID="txt12papasConsumo"></asp:TextBox>
                        <span class="help-block">Consumo</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Semillón" ID="txt12papasSemillon"></asp:TextBox>
                        <span class="help-block">Semillón</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Toneladas/Hectárea" ID="txt12papasToneladasHectarea" ></asp:TextBox>
                        <span class="help-block">Toneladas/Hectárea</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-2 col-sm-offset-1">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Semilla" ID="txt12papasSemilla"></asp:TextBox>
                        <span class="help-block">Semilla</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Semillita" ID="txt12papasSemillita"></asp:TextBox>
                        <span class="help-block">Semillita</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Bajo Calibre" ID="txt12papasBajoCalibre"></asp:TextBox>
                        <span class="help-block">Bajo Calibre</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Número Tallos" ID="txt12papasNumeroTallos"></asp:TextBox>
                        <span class="help-block">Número Tallos</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="% Relación Standard" ID="txt12papasRelacionStandard" ></asp:TextBox>
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
                        <asp:DropDownList type="button" ID="ddl12papasEnfermedad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Enfermedad</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl12papasResistencia" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Resistencia</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:Button type="button" runat="server" Text="Agregar Enfermedad" ID="btn12papasAgregarEnfermedad" class="btn btn-primary btn-md" BorderColor="#000000" OnClick="btn12papasAgregarEnfermedad_Click"></asp:Button>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-9 col-sm-offset-3">
                        <asp:GridView ID="gdv12papasEnfermedades" runat="server" Width="70%"
                            AutoGenerateColumns="False"
                            CssClass="table table-bordered bs-table"
                            AllowPaging="True"
                            AllowSorting="True"
                            OnRowDeleting="Cosecha12papasEnfermedadesGridView_RowDeleting">

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
                                        <asp:Button ID="btnDeleteEnfermedad" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Deseas eliminar la enfermedad?\nNo olvide guardar los cambios');" />
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
                        <asp:DropDownList type="button" ID="ddl12papasSensibilidadQuimica" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Sensibilidad Química</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Daño Cosecha" ID="txt12papasDañoCosecha"></asp:TextBox>
                        <span class="help-block">Daño Cosecha</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Dormancia" ID="txt12papasDormancia"></asp:TextBox>
                        <span class="help-block">Dormancia</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tizon Hoja" ID="txt12papasTizonHoja"></asp:TextBox>
                        <span class="help-block">Tizón Hoja</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-2 ">
                        <asp:DropDownList type="button" ID="ddl12papasFacilidadMuerte" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Facilidad Muerte</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tolerancia Sequía" ID="txt12papasToleranciaSequia"></asp:TextBox>
                        <span class="help-block">Tolerancia Sequía</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tolerancia Calor" ID="txt12papasToleranciaCalor"></asp:TextBox>
                        <span class="help-block">Tolerancia Calor</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tolerancia Sal" ID="txt12papasToleranciaSal"></asp:TextBox>
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
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Putrefacción Suave" ID="txt12papasPutrefaccionSuave"></asp:TextBox>
                    <span class="help-block">Putrefacción Suave</span>
                </div>
                <div class="col-sm-2">
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Putrefacción Rosa" ID="txt12papasPutrefaccionRosa"></asp:TextBox>
                    <span class="help-block">Putrefacción Rosa</span>
                </div>
                <div class="col-sm-2">
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Silver Scurf" ID="txt12papasSilverScurf"></asp:TextBox>
                    <span class="help-block">Silver Scurf</span>
                </div>
                <div class="col-sm-2">
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Blackleg" ID="txt12papasBlackleg"></asp:TextBox>
                    <span class="help-block">Blackleg</span>
                </div>
                <div class="col-sm-2">
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Hematomas" ID="txt12papasHematomas" ReadOnly="true"></asp:TextBox>
                    <span class="help-block">Hematomas</span>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="row" style="text-align: center">
            <asp:Button type="button" runat="server" Text="Guardar" ID="btn12papasGuardar" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea guardar los cambios?');" OnClick="btn12papasGuardar_Click"></asp:Button>
            <asp:Button type="button" runat="server" Text="Cancelar" ID="btn12papasCancelar" class="btn btn-danger btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea cancelar los cambios?');" OnClick="btn12papasCancelar_Click"></asp:Button>
        </div>
    </div>
</asp:Content>
