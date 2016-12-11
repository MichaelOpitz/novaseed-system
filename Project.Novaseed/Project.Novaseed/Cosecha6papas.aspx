<%@ Page Title="6 Papas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Cosecha6papas.aspx.cs" Inherits="Project.Novaseed.Cosecha6papas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <div class="row">
            <h2>
                <asp:Label ID="lbl6papasAño" runat="server" Font-Bold="true" Text="6 Papas" /></h2>
        </div>
        <br />
        <div class="row">
            <h5><asp:Label id="lbl6papasError" runat="server" Font-Bold="true" Text="" ForeColor="Red"/></h5>
        </div>
        <div class="row">
            <asp:Button type="button" runat="server" ID="btnAgregar12papas" class="btn btn-danger btn-block" Style="border-color: #000000" Text="Agregar a 12 Papas" OnClientClick="return confirm('¿Desea agregar a 12 Papas?');" OnClick="btnAgregar12papas_Click"></asp:Button>
        </div>
        <div class="row">
            <asp:GridView ID="gdv6papas" runat="server"
                DataKeyNames="id_cosecha"
                AutoGenerateColumns="False"
                CssClass="table table-bordered bs-table"
                AllowPaging="True"
                AllowSorting="True"
                OnRowDataBound="OnRowDataBound"
                OnRowDeleting="Cosecha6papasGridView_RowDeleting" OnSelectedIndexChanged="gdv6papas_SelectedIndexChanged">

                <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#ffffcc" />
                <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />
                <EmptyDataTemplate>
                    ¡No hay datos en el año seleccionado!  
                </EmptyDataTemplate>

                <SelectedRowStyle Font-Bold="True" />
                <Columns>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="50px" HeaderText="Agregar a 12 Papas">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkAgregar12Papas" runat="server" />
                        </ItemTemplate>
                        <HeaderStyle Width="100px"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:TemplateField>

                    <%--botones de acción sobre los registros...--%>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="100px">
                        <ItemTemplate>
                            <%--Botones de eliminar y editar cliente...--%>
                            <asp:Button ID="btnDelete" runat="server" Text="Quitar" CssClass="btn btn-danger" CommandName="Delete" OnClientClick="return confirm('¿Eliminar variedad de 6 papas?\nSi lo hace eliminará todos los registros de etapas avanzadas');" />
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
                        <asp:TextBox type="text" runat="server" class="form-control" ID="txt6papasCodigoSeleccionado" Width="80%" Placeholder="Código" Style="border: 3px double #000000" ReadOnly="true" Font-Bold="true"></asp:TextBox>                        
                        <span class="help-block" style="font: 700">Código Seleccionado</span>
                    </div>
                    <div class="col-sm-3">                        
                        <asp:RegularExpressionValidator ID="re6papasCantidadPapas" runat="server" ValidationExpression="^[0-6]{0,1}" ErrorMessage="Debe ser un número entre 0 y 6" ControlToValidate="txt6papasCantidadPapas" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" ID="txt6papasCantidadPapas" Width="80%" Placeholder="Cantidad Papas" Style="border: 3px solid #1E90FF"></asp:TextBox>                        
                        <span class="help-block">Cantidad de Papas</span>                        
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="re6papasPosicion" runat="server" ValidationExpression="^[0-9]{1,2}([.,][0-9]{1,2})*" ErrorMessage="Debe ser un número valido" ControlToValidate="txt6papasPosicion" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" ID="txt6papasPosicion" Width="80%" Placeholder="Posición" Style="border: 3px solid #1E90FF"></asp:TextBox>                        
                        <span class="help-block">Posición</span>
                    </div>
                    <div class="col-sm-2" style="margin-top:20px">
                        <asp:CheckBox ID="chk6papasFlor" runat="server" Text="Flor" />
                    </div>
                    <div class="col-sm-2">
                        <asp:CheckBox ID="chk6papasBayas" runat="server" Text="Bayas" />
                    </div>
                </div>                

                <div class="row">
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl6papasFertilidad" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Fertilidad</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl6papasEmergencia40" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Emergencia a 40 Días</span>
                    </div>

                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl6papasMetribuzina" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Metribuzina</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl6papasEmergencia" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
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
                        <asp:DropDownList type="button" ID="ddl6papasMadurez" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Madurez</span>
                    </div>
                    <div class="col-sm-5">
                        <asp:DropDownList type="button" ID="ddl6papasDesarrollo" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Desarrollo Follaje</span>
                    </div>
                    <div class="col-sm-4">
                        <asp:DropDownList type="button" ID="ddl6papasTipoHoja" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Tipo Hoja</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl6papasBrotacion" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Brotación</span>
                    </div>
                    <div class="col-sm-5">
                        <asp:DropDownList type="button" ID="ddl6papasTamaño" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Tamaño</span>
                    </div>
                    <div class="col-sm-4">
                        <asp:DropDownList type="button" ID="ddl6papasDistribucion" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Distribución Calibre</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-3">
                        <asp:DropDownList type="button" ID="ddl6papasForma" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Forma</span>
                    </div>
                    <div class="col-sm-5">
                        <asp:DropDownList type="button" ID="ddl6papasRegularidad" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Regularidad</span>
                    </div>
                    <div class="col-sm-4">
                        <asp:DropDownList type="button" ID="ddl6papasProfundidad" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
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
                    <asp:DropDownList type="button" ID="ddl6papasCalidadPiel" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Calidad Piel</span>
                </div>
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl6papasTuberculosVerdes" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Tubérculos Verdes</span>
                </div>
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl6papasTizonFollaje" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Tizon Tardío Follaje</span>
                </div>

                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl6papasTizonTuberculo" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Tizon Tardío Tubérculo</span>
                </div>
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl6papasNumero" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                    <span class="help-block">Numero de Tubérculos</span>
                </div>
                <div class="col-sm-4">
                    <asp:DropDownList type="button" ID="ddl6papasCiudadPlantacion" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
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
                    <asp:ListBox class="list-group checked-list-box" ID="lst6papasColorCarne" Style="width: 70%" runat="server" SelectionMode="Multiple"></asp:ListBox>
                    <span class="help-block">Color Carne</span>
                </div>
                <div class="col-sm-6">
                    <asp:ListBox class="list-group checked-list-box" ID="lst6papasColorPiel" Style="width: 70%" runat="server" SelectionMode="Multiple"></asp:ListBox>
                    <span class="help-block">Color Piel</span>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="panel panel-danger">
            <div class="panel-heading" style="text-align: center">Totales</div>
            <div class="panel-body">
                
                <div class="row">
                    <div class="col-sm-2 col-sm-offset-1">
                        <asp:RegularExpressionValidator ID="re6papasTotalKg" runat="server" ValidationExpression="^[0-9]{1,5}([.,][0-9]{1,2})*" ErrorMessage="Debe ser de 0 a 5 digitos" ControlToValidate="txt6papasTotalKg" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Total Kilogramos" ID="txt6papasTotalKg"></asp:TextBox>
                        <span class="help-block">Total Kilogramos</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re6papasTuberculosPlanta" runat="server" ValidationExpression="^[0-9]{1,3}([.,][0-9]{1,2})*" ErrorMessage="Debe ser entre 0 y 999" ControlToValidate="txt6papasTuberculosPlanta" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tubérculos/planta" ID="txt6papasTuberculosPlanta"></asp:TextBox>
                        <span class="help-block">Tubérculos/Planta</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re6papasConsumo" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasConsumo" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Consumo" ID="txt6papasConsumo"></asp:TextBox>
                        <span class="help-block">Consumo</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re6papasSemillon" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasSemillon" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Semillón" ID="txt6papasSemillon"></asp:TextBox>
                        <span class="help-block">Semillón</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re6papasToneladasHectarea" runat="server" ValidationExpression="^[0-9]{1,4}([.,][0-9]{1,2})*" ErrorMessage="Debe ser entre 0 y 9999" ControlToValidate="txt6papasToneladasHectarea" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Toneladas/Hectárea" ID="txt6papasToneladasHectarea" ></asp:TextBox>
                        <span class="help-block">Toneladas/Hectárea</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-2 col-sm-offset-1">
                        <asp:RegularExpressionValidator ID="re6papasSemilla" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasSemilla" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Semilla" ID="txt6papasSemilla"></asp:TextBox>
                        <span class="help-block">Semilla</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re6papasSemillita" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasSemillita" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Semillita" ID="txt6papasSemillita"></asp:TextBox>
                        <span class="help-block">Semillita</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re6papasBajoCalibre" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasBajoCalibre" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Bajo Calibre" ID="txt6papasBajoCalibre"></asp:TextBox>
                        <span class="help-block">Bajo Calibre</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re6papasNumeroTallos" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasNumeroTallos" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Número Tallos" ID="txt6papasNumeroTallos"></asp:TextBox>
                        <span class="help-block">Número Tallos</span>
                    </div>
                    <div class="col-sm-2">
                        <asp:RegularExpressionValidator ID="re6papasRelacionStandard" runat="server" ValidationExpression="^[0-9]{0,3}[%]{0,1}" ErrorMessage="Debe ser entre 0 y 999" ControlToValidate="txt6papasRelacionStandard" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="% Relación Standard" ID="txt6papasRelacionStandard" ></asp:TextBox>
                        <span class="help-block">% Relación Standard</span>
                    </div>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">Sensibilidad y Tolerancias</div>
            <div class="panel-body">
                
                <div class="row">
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="re6papasSensibilidadQuimica" runat="server" ValidationExpression="." ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="ddl6papasSensibilidadQuimica" ForeColor="White" ></asp:RegularExpressionValidator>
                        <asp:DropDownList type="button" ID="ddl6papasSensibilidadQuimica" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Sensibilidad Química</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="re6papasDañoCosecha" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasDañoCosecha" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Daño Cosecha" ID="txt6papasDañoCosecha"></asp:TextBox>
                        <span class="help-block">Daño Cosecha</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="re6papasDormancia" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasDormancia" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Dormancia" ID="txt6papasDormancia"></asp:TextBox>
                        <span class="help-block">Dormancia</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="re6papasTizonHoja" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasTizonHoja" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tizon Hoja" ID="txt6papasTizonHoja"></asp:TextBox>
                        <span class="help-block">Tizón Hoja</span>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="re6papasFacilidadMuerte" runat="server" ValidationExpression="." ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="ddl6papasFacilidadMuerte" ForeColor="White" ></asp:RegularExpressionValidator>
                        <asp:DropDownList type="button" ID="ddl6papasFacilidadMuerte" runat="server" Width="80%" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"></asp:DropDownList>
                        <span class="help-block">Facilidad Muerte</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="re6papasToleranciaSequia" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasToleranciaSequia" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tolerancia Sequía" ID="txt6papasToleranciaSequia"></asp:TextBox>
                        <span class="help-block">Tolerancia Sequía</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="re6papasToleranciaCalor" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasToleranciaCalor" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tolerancia Calor" ID="txt6papasToleranciaCalor"></asp:TextBox>
                        <span class="help-block">Tolerancia Calor</span>
                    </div>
                    <div class="col-sm-3">
                        <asp:RegularExpressionValidator ID="re6papasToleranciaSal" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasToleranciaSal" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                        <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Tolerancia Sal" ID="txt6papasToleranciaSal"></asp:TextBox>
                        <span class="help-block">Tolerancia Sal</span>
                    </div>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">Urgencias</div>
            <div class="panel-body">
                
                <div class="col-sm-2 col-sm-offset-1">
                    <asp:RegularExpressionValidator ID="re6papasPutrefaccionSuave" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasPutrefaccionSuave" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Putrefacción Suave" ID="txt6papasPutrefaccionSuave"></asp:TextBox>
                    <span class="help-block">Putrefacción Suave</span>
                </div>
                <div class="col-sm-2">
                    <asp:RegularExpressionValidator ID="re6papasPutrefaccionRosa" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasPutrefaccionRosa" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Putrefacción Rosa" ID="txt6papasPutrefaccionRosa"></asp:TextBox>
                    <span class="help-block">Putrefacción Rosa</span>
                </div>
                <div class="col-sm-2">
                    <asp:RegularExpressionValidator ID="re6papasSilverScurf" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasSilverScurf" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Silver Scurf" ID="txt6papasSilverScurf"></asp:TextBox>
                    <span class="help-block">Silver Scurf</span>
                </div>
                <div class="col-sm-2">
                    <asp:RegularExpressionValidator ID="re6papasBlackleg" runat="server" ValidationExpression="^[0-9]{0,2}" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasBlackleg" ForeColor="Red" ValidationGroup="modificar6papas"></asp:RegularExpressionValidator>
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Blackleg" ID="txt6papasBlackleg"></asp:TextBox>
                    <span class="help-block">Blackleg</span>
                </div>
                <div class="col-sm-2">
                    <asp:RegularExpressionValidator ID="re6papasHematomas" runat="server" ValidationExpression="" ErrorMessage="Debe ser entre 0 y 99" ControlToValidate="txt6papasHematomas" ForeColor="White" ></asp:RegularExpressionValidator>
                    <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Hematomas" ID="txt6papasHematomas" ReadOnly="true"></asp:TextBox>
                    <span class="help-block">Hematomas</span>
                </div>
            </div>
        </div>

        <hr style="color: #000000" />
        <div class="row" style="text-align: center">
            <asp:Button type="button" runat="server" Text="Guardar" ID="btn6papasGuardar" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" ValidationGroup="modificar6papas" CausesValidation="true" OnClientClick="return confirm('¿Desea guardar los cambios?');" OnClick="btn6papasGuardar_Click"></asp:Button>
            <asp:Button type="button" runat="server" Text="Cancelar" ID="btn6papasCancelar" class="btn btn-danger btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea cancelar los cambios?');" OnClick="btn6papasCancelar_Click"></asp:Button>
        </div>
    </div>
</asp:Content>

