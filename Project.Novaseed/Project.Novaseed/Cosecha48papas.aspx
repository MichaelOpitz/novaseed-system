<%@ Page Title="48 Papas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Cosecha48papas.aspx.cs" Inherits="Project.Novaseed.Cosecha48papas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row">
            <h2>
                <asp:Label ID="lbl48papasAño" runat="server" Font-Bold="true" Text="48 Papas" /></h2>
        </div>
        <br />
        <div class="row">
            <h5><asp:Label id="lbl48papasError" runat="server" Font-Bold="true" Text="" ForeColor="Red"/></h5>
        </div>
        <div class="row">
            <asp:Button type="button" runat="server" ID="btnAgregarUPOV" class="btn btn-danger btn-block" Style="border-color: #000000" Text="Generar Informe UPOV" OnClientClick="return confirm('¿Desea generar el informe upov?');" OnClick="btnAgregarUPOV_Click"></asp:Button>
        </div>
        <div class="row">
            <asp:GridView ID="gdv48papas" runat="server"
                DataKeyNames="id_cosecha"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
                OnRowDataBound="OnRowDataBound"
                OnRowDeleting="Cosecha48papasGridView_RowDeleting" OnSelectedIndexChanged="gdv48papas_SelectedIndexChanged">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay datos en el año seleccionado!  
                </EmptyDataTemplate>

                <SelectedRowStyle Font-Bold="True" />
                <Columns>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="50px" HeaderText="Generar UPOV">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkAgregarUPOV" runat="server" AutoPostBack="true" />
                        </ItemTemplate>
                        <HeaderStyle Width="100px"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>

                    <%--botones de acción sobre los registros...--%>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="100px">
                        <ItemTemplate>
                            <%--Botones de eliminar y editar cliente...--%>
                            <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Eliminar variedad de 48 papas?\nSi lo hace eliminará todos los registros de etapas avanzadas');" />
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
                
                <div class="row">
                    <div class="col-sm-3" style="margin-top:20px">                        
                        <asp:TextBox type="text" runat="server" class="form-control" ID="txt48papasCodigoSeleccionado" Placeholder="Código" Style="border: 3px double #000000" ReadOnly="true" Font-Bold="true"></asp:TextBox>
                        <span class="help-block" style="font: 700">Código Seleccionado</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="re48papasCantidadPapas" runat="server" ValidationExpression="^(4[0-8]{1,1})|(3[0-9]{1,1})|(2[0-9]{1,1})|(1[0-9]{1,1})|([0-9]{1})$" ErrorMessage="Debe ser un número entre 0 y 48" ControlToValidate="txt48papasCantidadPapas" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" ID="txt48papasCantidadPapas" Placeholder="Cantidad Papas" Style="border: 3px solid #1E90FF"></asp:TextBox>
                        <span class="help-block">Cantidad de Papas</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="re48papasPosicion" runat="server" ValidationExpression="^[0-9]{1,2}([.,][0-9]{1,2})*" ErrorMessage="Debe ser un número valido" ControlToValidate="txt48papasPosicion" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" ID="txt48papasPosicion" Placeholder="Posición" Style="border: 3px solid #1E90FF"></asp:TextBox>
                        <span class="help-block">Posición</span>
                    </div>
                    <div class="col-sm-2" style="margin-top:20px">
                        <asp:CheckBox ID="chk48papasFlor" runat="server" AutoPostBack="true" Text="Flor" />
                    </div>
                    <div class="col-sm-2">
                        <asp:CheckBox ID="chk48papasBayas" runat="server" AutoPostBack="true" Text="Bayas" />
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl48papasFertilidad" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Fertilidad</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl48papasEmergencia40" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Emergencia a 40 Días</span>
                    </div>

                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl48papasMetribuzina" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Metribuzina</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl48papasEmergencia" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
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
                        <asp:DropDownList type="button" ID="ddl48papasMadurez" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Madurez</span>
                    </div>
                    <div class="col-sm-5">
                        <asp:DropDownList type="button" ID="ddl48papasDesarrollo" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Desarrollo Follaje</span>
                    </div>
                    <div class="col-sm-4">
                        <asp:DropDownList type="button" ID="ddl48papasTipoHoja" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Tipo Hoja</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl48papasBrotacion" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Brotación</span>
                    </div>
                    <div class="col-sm-5">
                        <asp:DropDownList type="button" ID="ddl48papasTamaño" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Tamaño</span>
                    </div>
                    <div class="col-sm-4">
                        <asp:DropDownList type="button" ID="ddl48papasDistribucion" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Distribución Calibre</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl48papasForma" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Forma</span>
                    </div>
                    <div class="col-sm-5">
                        <asp:DropDownList type="button" ID="ddl48papasRegularidad" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Regularidad</span>
                    </div>
                    <div class="col-sm-4">
                        <asp:DropDownList type="button" ID="ddl48papasProfundidad" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
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
                    <asp:DropDownList type="button" ID="ddl48papasCalidadPiel" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Calidad Piel</span>
                </div>
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl48papasTuberculosVerdes" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Tubérculos Verdes</span>
                </div>
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl48papasTizonFollaje" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Tizon Tardío Follaje</span>
                </div>

                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl48papasTizonTuberculo" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Tizon Tardío Tubérculo</span>
                </div>
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl48papasNumero" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Numero de Tubérculos</span>
                </div>
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl48papasCiudadPlantacion" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
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
                    <asp:ListBox class="list-group checked-list-box" ID="lst48papasColorCarne" Style="width: 70%" runat="server" SelectionMode="Multiple"></asp:ListBox>
                    <span class="help-block">Color Carne</span>
                </div>
                <div class="col-sm-6">
                    <asp:ListBox class="list-group checked-list-box" ID="lst48papasColorPiel" Style="width: 70%" runat="server" SelectionMode="Multiple"></asp:ListBox>
                    <span class="help-block">Color Piel</span>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="panel panel-danger">
            <div class="panel-heading" style="text-align: center">Totales</div>
            <div class="panel-body">
                
                <div class="row">
                    <div class="col-sm-2 col-sm-offset-2">
                        <asp:RegularExpressionValidator ID="re48papasTotalKg" runat="server" ValidationExpression="^[0-9]{1,5}([.,][0-9]{1,2})*" ErrorMessage="Debe ser de 0 a 5 digitos" ControlToValidate="txt48papasTotalKg" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Total Kilogramos" ID="txt48papasTotalKg"></asp:TextBox>
                        <span class="help-block">Total Kilogramos</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re48papasTuberculosPlanta" runat="server" ValidationExpression="^[0-9]{1,3}([.,][0-9]{1,2})*" ErrorMessage="Debe ser entre 0 y 999" ControlToValidate="txt48papasTuberculosPlanta" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tubérculos/planta" ID="txt48papasTuberculosPlanta"></asp:TextBox>
                        <span class="help-block">Tubérculos/Planta</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re48papasConsumo" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasConsumo" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Consumo" ID="txt48papasConsumo"></asp:TextBox>
                        <span class="help-block">Consumo</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re48papasSemillon" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasSemillon" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Semillón" ID="txt48papasSemillon"></asp:TextBox>
                        <span class="help-block">Semillón</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-2 col-sm-offset-2">
                        <asp:RegularExpressionValidator ID="re48papasSemilla" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasSemilla" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Semilla" ID="txt48papasSemilla"></asp:TextBox>
                        <span class="help-block">Semilla</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re48papasSemillita" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasSemillita" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Semillita" ID="txt48papasSemillita"></asp:TextBox>
                        <span class="help-block">Semillita</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re48papasBajoCalibre" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasBajoCalibre" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Bajo Calibre" ID="txt48papasBajoCalibre"></asp:TextBox>
                        <span class="help-block">Bajo Calibre</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re48papasNumeroTallos" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasNumeroTallos" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Número Tallos" ID="txt48papasNumeroTallos"></asp:TextBox>
                        <span class="help-block">Número Tallos</span>
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
                        <asp:DropDownList type="button" ID="ddl48papasEnfermedad" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Enfermedad</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl48papasResistencia" runat="server" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Resistencia</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:Button type="button" runat="server" Text="Agregar Enfermedad" ID="btn48papasAgregarEnfermedad" class="btn btn-primary btn-md" BorderColor="#000000" OnClick="btn48papasAgregarEnfermedad_Click"></asp:Button>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-9 col-sm-offset-3">
                        <asp:GridView ID="gdv48papasEnfermedades" runat="server" Width="70%"
                            AutoGenerateColumns="False"
                            CssClass="table table-bordered bs-table"
                            AllowPaging="True"
                            AllowSorting="True"
                            OnRowDeleting="Cosecha48papasEnfermedadesGridView_RowDeleting">

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
                
                <div class="row">
                    <div class="col-sm-2 col-sm-offset-2" style="margin-top:20px">                        
                        <asp:DropDownList type="button" ID="ddl48papasSensibilidadQuimica" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Sensibilidad Química</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re48papasDañoCosecha" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasDañoCosecha" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Daño Cosecha" ID="txt48papasDañoCosecha"></asp:TextBox>
                        <span class="help-block">Daño Cosecha</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re48papasDormancia" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasDormancia" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Dormancia" ID="txt48papasDormancia"></asp:TextBox>
                        <span class="help-block">Dormancia</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re48papasTizonHoja" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasTizonHoja" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tizon Hoja" ID="txt48papasTizonHoja"></asp:TextBox>
                        <span class="help-block">Tizón Hoja</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-2 col-sm-offset-2" style="margin-top:20px">                        
                        <asp:DropDownList type="button" ID="ddl48papasFacilidadMuerte" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Facilidad Muerte</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re48papasToleranciaSequia" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasToleranciaSequia" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tolerancia Sequía" ID="txt48papasToleranciaSequia"></asp:TextBox>
                        <span class="help-block">Tolerancia Sequía</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re48papasToleranciaCalor" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasToleranciaCalor" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tolerancia Calor" ID="txt48papasToleranciaCalor"></asp:TextBox>
                        <span class="help-block">Tolerancia Calor</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re48papasToleranciaSal" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasToleranciaSal" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tolerancia Sal" ID="txt48papasToleranciaSal"></asp:TextBox>
                        <span class="help-block">Tolerancia Sal</span>
                    </div>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="panel panel-info">
            <div class="panel-heading" style="text-align: center">Urgencias</div>
            <div class="panel-body">
                
                <div class="col-sm-2 col-sm-offset-1">
                    <asp:RegularExpressionValidator ID="re48papasPutrefaccionSuave" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasPutrefaccionSuave" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Putrefacción Suave" ID="txt48papasPutrefaccionSuave"></asp:TextBox>
                    <span class="help-block">Putrefacción Suave</span>
                </div>
                <div class="col-sm-2">
                    <asp:RegularExpressionValidator ID="re48papasPutrefaccionRosa" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasPutrefaccionRosa" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Putrefacción Rosa" ID="txt48papasPutrefaccionRosa"></asp:TextBox>
                    <span class="help-block">Putrefacción Rosa</span>
                </div>
                <div class="col-sm-2">
                    <asp:RegularExpressionValidator ID="re48papasSilverScurf" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasSilverScurf" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Silver Scurf" ID="txt48papasSilverScurf"></asp:TextBox>
                    <span class="help-block">Silver Scurf</span>
                </div>
                <div class="col-sm-2">
                    <asp:RegularExpressionValidator ID="re48papasBlackleg" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasBlackleg" ForeColor="Red" ValidationGroup="modificar48papas"></asp:RegularExpressionValidator>
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Blackleg" ID="txt48papasBlackleg"></asp:TextBox>
                    <span class="help-block">Blackleg</span>
                </div>
                <div class="col-sm-2">
                    <asp:RegularExpressionValidator ID="re48papasHematomas" runat="server" ValidationExpression="" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt48papasHematomas" ForeColor="White" ></asp:RegularExpressionValidator>
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Hematomas" ID="txt48papasHematomas" ReadOnly="true"></asp:TextBox>
                    <span class="help-block">Hematomas</span>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">Rendimiento</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-9 col-sm-offset-3">
                        <asp:GridView ID="gdv48papasRendimiento" runat="server" Width="70%"
                            AutoGenerateColumns="False"
                            CssClass="table table-bordered bs-table"
                            AllowPaging="True"
                            AllowSorting="True">

                            <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                            <EditRowStyle BackColor="#ffffcc" />
                            <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                            <EmptyDataTemplate>
                                ¡No hay rendimiento en la variedad seleccionada!  
                            </EmptyDataTemplate>

                            <SelectedRowStyle Font-Bold="True" />
                            <Columns>
                                <asp:BoundField DataField="codigo_individuo" HeaderText="Código" ReadOnly="true" />
                                <asp:BoundField DataField="nombre_ciudad" HeaderText="Ciudad" ReadOnly="true" />
                                <asp:BoundField DataField="porcentaje_relacion_standard" HeaderText="Rendimiento (%)" ReadOnly="true" />
                                <asp:BoundField DataField="toneladas_hectarea" HeaderText="Toneladas/Hectárea (Ton)" ReadOnly="true" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="row" style="text-align: center">
            <asp:Button type="button" runat="server" Text="Guardar" ID="btn48papasGuardar" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" ValidationGroup="modificar48papas" CausesValidation="true" OnClientClick="return confirm('¿Desea guardar los cambios?');" OnClick="btn48papasGuardar_Click"></asp:Button>
            <asp:Button type="button" runat="server" Text="Cancelar" ID="btn48papasCancelar" class="btn btn-danger btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea cancelar los cambios?');" OnClick="btn48papasCancelar_Click"></asp:Button>
        </div>        
    </div>
</asp:Content>

