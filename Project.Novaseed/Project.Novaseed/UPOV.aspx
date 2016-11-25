<%@ Page Title="Informe UPOV" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="UPOV.aspx.cs" Inherits="Project.Novaseed.UPOV" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <br />
        <h1 style="text-align: center; font-weight: bold">Informe UPOV</h1>
        <div class="row" style="text-align: center">
            <h4><span style="text-align: center; border-image: initial; border: 1px solid blue;">DIRECTRICES UPOV PARA EL EXAMEN DE LA DISTINCION, HOMOGENEIDAD Y ESTABILIDAD</span></h4>
        </div>
        <br />
        <hr style="color: #000000" />
        <div class="row">
            <div class="col-sm-3 col-sm-offset-1">
                <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Nombre Variedad" ID="txtUPOVNombreVariedad"></asp:TextBox>
                <span class="help-block">Nombre Variedad</span>
            </div>
            <div class="col-sm-3">
                <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Madre" ID="txtUPOVMadre" ReadOnly="true"></asp:TextBox>
                <span class="help-block">Madre</span>
            </div>
            <div class="col-sm-3">
                <asp:TextBox type="text" runat="server" class="form-control" Placeholder="Padre" ID="txtUPOVPadre" ReadOnly="true"></asp:TextBox>
                <span class="help-block">Padre</span>
            </div>
        </div>
        <hr style="color: #000000" />
        <br />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">BROTE</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Botón Floral Pigmentación</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVBotonFloralPigmentacion" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Forma</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVBroteForma" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Longitud Ramificaciones Laterales</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVBroteLongitudRamificacionesLaterales" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Pigmentacion Base</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVBrotePigmentacionBase" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Pigmentacion Extremo</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVBrotePigmentacionExtremo" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Porte Extremo</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVBrotePorteExtremo" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Proporcion Azul</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVBroteProporcionAzul" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Pubescencia Base</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVBrotePubescenciaBase" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Pubescencia Extremo</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVBrotePubescenciaExtremo" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Radiculas</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVBroteRadiculas" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Tamaño</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVBroteTamaño" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Tamaño Extremo</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVBroteTamañoExtremo" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>

        <br />
        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">COROLA FLOR</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Extension Pigmentación Cara Interna</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVCorolaFlorExtensionPigmentacionCaraInterna" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Intensidad Pigmentación Cara Interna</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVCorolaFlorIntensidadPigmentacionCaraInterna" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Proporcion Azul Pigmentación Cara Interna</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVCorolaFlorProporcionAzulPigmentacionCaraInterna" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Tamaño</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVCorolaFlorTamaño" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>

        <br />
        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">FOLIOLO</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-3 col-sm-offset-1">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Brillo Haz</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVFolioloBrilloHaz" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Ondulación Borde</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVFolioloOndulacionBorde" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Profundidad Nervios</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVFolioloProfundidadNervios" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3 col-sm-offset-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Pubescencia Haz Roseta Apical</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVFolioloPubescenciaHazRosetaApical" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Terminales Coalescencia</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVFoliolosTerminalesCoalescencia" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>

        <br />
        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">HOJA</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-3 col-sm-offset-1">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Apertura</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVHojaApertura" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Color Verde</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVHojaColorVerde" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Foliolos Secundarios</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVHojaFoliolosSecundarios" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3 col-sm-offset-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Pigmentación Nervio Central</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVHojaPigmentacionNervioCentral" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Tamaño Contorno</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVHojaTamañoContorno" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>

        <br />
        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">INFLORESCENCIA</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-3 col-sm-offset-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Pigmentación Pendunculo</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVInflorescenciaPigmentacionPendunculo" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Tamaño</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVInflorescenciaTamaño" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>

        <br />
        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">PLANTA</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-3 col-sm-offset-1">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Altura</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVPlantaAltura" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Época Madurez</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVPlantaEpocaMadurez" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Estructura Follaje</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVPlantaEstructuraFollaje" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3 col-sm-offset-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Frecuencia Flores</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVPlantaFrecuenciaFlores" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Porte</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVPlantaPorte" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>

        <br />
        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">SEGUNDO PAR FOLIOLOS</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-3 col-sm-offset-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Anchura Longitud</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVSegundoParFoliolosAnchuraLongitud" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Tamaño</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVSegundoParFoliolosTamaño" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>

        <br />
        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">TUBÉRCULO</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-3 col-sm-offset-1">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Tallo Pigmentación</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVTalloPigmentacion" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Color Base Ojo</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVTuberculoColorBaseOjo" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Pigmentación Piel Reaccion Luz</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVTuberculoPigmentacionPielReaccionLuz" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3 col-sm-offset-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Profundidad Ojo</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVProfundidadOjo" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Forma Tubérculos</div>
                            <div class="panel-body">
                                <asp:RadioButtonList ID="rdbUPOVFormaTuberculos" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:RadioButtonList>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>

        <br />
        <hr style="color: #000000" />
        <div class="panel panel-primary">
            <div class="panel-heading" style="text-align: center">COLORES</div>
            <div class="panel-body">
                <br />
                <div class="row">
                    <div class="col-sm-3 col-sm-offset-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Carne</div>
                            <div class="panel-body">
                                <asp:CheckBoxList ID="chkUPOVColorCarne" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:CheckBoxList>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="panel panel-default">
                            <div class="panel-heading" style="text-align: center">Piel</div>
                            <div class="panel-body">
                                <asp:CheckBoxList ID="chkUPOVColorPiel" runat="server" RepeatLayout="Flow" RepeatDirection="Vertical"></asp:CheckBoxList>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>

        <div class="row" style="text-align: center">
            <asp:Button type="button" runat="server" Text="Guardar" ID="btnUPOVGuardar" class="btn btn-primary btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea guardar los cambios?');" OnClick="btnUPOVGuardar_Click"></asp:Button>
            <asp:Button type="button" runat="server" Text="Cancelar" ID="btnUPOVCancelar" class="btn btn-danger btn-md" Width="20%" BorderColor="#000000" OnClientClick="return confirm('¿Desea cancelar los cambios?');" OnClick="UPOVCancelar_Click"></asp:Button>
        </div>

    </div>
</asp:Content>


