using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;
using System.Drawing;
using System.Globalization;

namespace Project.Novaseed
{
    public partial class Cosecha48papas : System.Web.UI.Page
    {
        private int cont48papasUPOV, valorAñoInt32;
        private string valorAñoString;
        private DataTable table;
        private List<string> listEnfermedad, listResistencia;

        protected void Page_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("nombre_enfermedad", typeof(string));
            table.Columns.Add("resistencia_variedad", typeof(string));

            cont48papasUPOV = 0;

            CatalogFertilidad cf = new CatalogFertilidad();
            List<Project.BusinessRules.Fertilidad> fertilidad = cf.getFertilidad();

            CatalogEmergencia40Dias ce40 = new CatalogEmergencia40Dias();
            List<Project.BusinessRules.Emergencia40Dias> emergencia40 = ce40.getEmergencia40Dias();
            CatalogMetribuzina cmet = new CatalogMetribuzina();
            List<Project.BusinessRules.Metribuzina> metribuzina = cmet.getMetribuzina();
            CatalogEmergencia ce = new CatalogEmergencia();
            List<Project.BusinessRules.Emergencia> emergencia = ce.getEmergencia();

            CatalogMadurez cm = new CatalogMadurez();
            List<Project.BusinessRules.Madurez> madurez = cm.getMadurez();
            CatalogDesarrolloFollaje cdf = new CatalogDesarrolloFollaje();
            List<Project.BusinessRules.DesarrolloFollaje> desarrollo = cdf.getDesarrolloFollaje();
            CatalogTipoHoja cth = new CatalogTipoHoja();
            List<Project.BusinessRules.TipoHoja> hoja = cth.getTipoHoja();
            CatalogBrotacion cb = new CatalogBrotacion();
            List<Project.BusinessRules.Brotacion> brotacion = cb.getBrotacion();
            CatalogTamaño ct = new CatalogTamaño();
            List<Project.BusinessRules.Tamaño> tamaño = ct.getTamaño();
            CatalogDistribucionCalibre cdc = new CatalogDistribucionCalibre();
            List<Project.BusinessRules.DistribucionCalibre> distribucion = cdc.getDistribucionCalibre();
            CatalogFormaTuberculos cft = new CatalogFormaTuberculos();
            List<Project.BusinessRules.FormaTuberculos> forma = cft.getFormaTuberculos();
            CatalogRegularidad cr = new CatalogRegularidad();
            List<Project.BusinessRules.Regularidad> regularidad = cr.getRegularidad();
            CatalogProfundidadOjo cpo = new CatalogProfundidadOjo();
            List<Project.BusinessRules.ProfundidadOjo> profundidad = cpo.getProfundidadOjo();
            CatalogCalidadPiel ccpiel = new CatalogCalidadPiel();
            List<Project.BusinessRules.CalidadPiel> calidad = ccpiel.getCalidadPiel();

            CatalogTuberculosVerdes ctv = new CatalogTuberculosVerdes();
            List<Project.BusinessRules.TuberculosVerdes> verdes = ctv.getTuberculosVerdes();
            CatalogTizonTardioFollaje cttf = new CatalogTizonTardioFollaje();
            List<Project.BusinessRules.TizonTardioFollaje> tizon_follaje = cttf.getTizonTardioFollaje();
            CatalogTizonTardioTuberculo cttt = new CatalogTizonTardioTuberculo();
            List<Project.BusinessRules.TizonTardioTuberculo> tizon_tuberculo = cttt.getTizonTardioTuberculo();
            CatalogNumeroTuberculos cnt = new CatalogNumeroTuberculos();
            List<Project.BusinessRules.NumeroTuberculos> numero = cnt.getNumeroTuberculos();
            CatalogCiudad ccity = new CatalogCiudad();
            List<Project.BusinessRules.Ciudad> city = ccity.GetCiudad();

            CatalogColorCarne ccc = new CatalogColorCarne();
            List<Project.BusinessRules.ColorCarne> carne = ccc.getColorCarne();
            CatalogColorPiel ccp = new CatalogColorPiel();
            List<Project.BusinessRules.ColorPiel> piel = ccp.getColorPiel();

            CatalogEnfermedades cenf = new CatalogEnfermedades();
            List<Project.BusinessRules.Enfermedades> enfermedad = cenf.GetEnfermedades();
            CatalogResistenciaVariedad crv = new CatalogResistenciaVariedad();
            List<Project.BusinessRules.ResistenciaVariedad> resistencia = crv.GetResistenciaVariedad();

            CatalogSensibilidadQuimica csq = new CatalogSensibilidadQuimica();
            List<Project.BusinessRules.SensibilidadQuimica> sensibilidad = csq.GetSensibilidadQuimica();
            CatalogFacilidadMuerte cfm = new CatalogFacilidadMuerte();
            List<Project.BusinessRules.FacilidadMuerte> facilidad = cfm.GetFacilidadMuerte();

            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["valor"] != null)
                valorAñoString = Request.QueryString["valor"];
            else
                valorAñoString = "0";
            valorAñoInt32 = Int32.Parse(valorAñoString);

            this.lbl48papasError.Visible = false;
            this.lbl48papasError.Text = "";
            if (!Page.IsPostBack)
            {
                this.ddl48papasFertilidad.DataValueField = "id_fertilidad";
                this.ddl48papasFertilidad.DataTextField = "nombre_fertilidad";
                this.ddl48papasFertilidad.DataSource = fertilidad;

                this.ddl48papasEmergencia40.DataValueField = "id_emergencia_40_dias";
                this.ddl48papasEmergencia40.DataTextField = "nombre_emergencia_40_dias";
                this.ddl48papasEmergencia40.DataSource = emergencia40;
                this.ddl48papasMetribuzina.DataValueField = "id_metribuzina";
                this.ddl48papasMetribuzina.DataTextField = "nombre_metribuzina";
                this.ddl48papasMetribuzina.DataSource = metribuzina;
                this.ddl48papasEmergencia.DataValueField = "id_emergencia";
                this.ddl48papasEmergencia.DataTextField = "nombre_emergencia";
                this.ddl48papasEmergencia.DataSource = emergencia;

                this.ddl48papasMadurez.DataValueField = "id_madurez";
                this.ddl48papasMadurez.DataTextField = "nombre_madurez";
                this.ddl48papasMadurez.DataSource = madurez;
                this.ddl48papasDesarrollo.DataValueField = "id_desarrollo_follaje";
                this.ddl48papasDesarrollo.DataTextField = "nombre_desarrollo_follaje";
                this.ddl48papasDesarrollo.DataSource = desarrollo;
                this.ddl48papasTipoHoja.DataValueField = "id_tipo_hoja";
                this.ddl48papasTipoHoja.DataTextField = "nombre_tipo_hoja";
                this.ddl48papasTipoHoja.DataSource = hoja;
                this.ddl48papasBrotacion.DataValueField = "id_brotacion";
                this.ddl48papasBrotacion.DataTextField = "nombre_brotacion";
                this.ddl48papasBrotacion.DataSource = brotacion;

                this.ddl48papasTamaño.DataValueField = "id_tamaño";
                this.ddl48papasTamaño.DataTextField = "nombre_tamaño";
                this.ddl48papasTamaño.DataSource = tamaño;
                this.ddl48papasDistribucion.DataValueField = "id_distribucion_calibre";
                this.ddl48papasDistribucion.DataTextField = "nombre_distribucion_calibre";
                this.ddl48papasDistribucion.DataSource = distribucion;
                this.ddl48papasForma.DataValueField = "id_forma";
                this.ddl48papasForma.DataTextField = "nombre_forma";
                this.ddl48papasForma.DataSource = forma;
                this.ddl48papasRegularidad.DataValueField = "id_regularidad";
                this.ddl48papasRegularidad.DataTextField = "nombre_regularidad";
                this.ddl48papasRegularidad.DataSource = regularidad;
                this.ddl48papasProfundidad.DataValueField = "id_profundidad";
                this.ddl48papasProfundidad.DataTextField = "profundidad_ojo";
                this.ddl48papasProfundidad.DataSource = profundidad;
                this.ddl48papasCalidadPiel.DataValueField = "id_calidad_piel";
                this.ddl48papasCalidadPiel.DataTextField = "nombre_calidad_piel";
                this.ddl48papasCalidadPiel.DataSource = calidad;
                this.ddl48papasTuberculosVerdes.DataValueField = "id_tuberculos_verdes";
                this.ddl48papasTuberculosVerdes.DataTextField = "nombre_tuberculos_verdes";
                this.ddl48papasTuberculosVerdes.DataSource = verdes;
                this.ddl48papasTizonFollaje.DataValueField = "id_tizon_tardio_follaje";
                this.ddl48papasTizonFollaje.DataTextField = "nombre_tizon_tardio_follaje";
                this.ddl48papasTizonFollaje.DataSource = tizon_follaje;
                this.ddl48papasTizonTuberculo.DataValueField = "id_tizon_tardio_tuberculo";
                this.ddl48papasTizonTuberculo.DataTextField = "nombre_tizon_tardio_tuberculo";
                this.ddl48papasTizonTuberculo.DataSource = tizon_tuberculo;
                this.ddl48papasNumero.DataValueField = "id_numero_tuberculos";
                this.ddl48papasNumero.DataTextField = "nombre_numero_tuberculos";
                this.ddl48papasNumero.DataSource = numero;
                this.ddl48papasCiudadPlantacion.DataValueField = "id_ciudad";
                this.ddl48papasCiudadPlantacion.DataTextField = "nombre_ciudad";
                this.ddl48papasCiudadPlantacion.DataSource = city;

                this.lst48papasColorCarne.DataValueField = "id_color_carne";
                this.lst48papasColorCarne.DataTextField = "nombre_color_carne";
                this.lst48papasColorCarne.DataSource = carne;
                this.lst48papasColorPiel.DataValueField = "id_color_piel";
                this.lst48papasColorPiel.DataTextField = "nombre_color_piel";
                this.lst48papasColorPiel.DataSource = piel;

                this.ddl48papasEnfermedad.DataValueField = "id_enfermedad";
                this.ddl48papasEnfermedad.DataTextField = "nombre_enfermedad";
                this.ddl48papasEnfermedad.DataSource = enfermedad;
                this.ddl48papasResistencia.DataValueField = "id_resistencia_variedad";
                this.ddl48papasResistencia.DataTextField = "nombre_resistencia_variedad";
                this.ddl48papasResistencia.DataSource = resistencia;

                this.ddl48papasSensibilidadQuimica.DataValueField = "id_sensibilidad_quimica";
                this.ddl48papasSensibilidadQuimica.DataTextField = "nombre_sensibilidad_quimica";
                this.ddl48papasSensibilidadQuimica.DataSource = sensibilidad;
                this.ddl48papasFacilidadMuerte.DataValueField = "id_facilidad_muerte";
                this.ddl48papasFacilidadMuerte.DataTextField = "nombre_facilidad_muerte";
                this.ddl48papasFacilidadMuerte.DataSource = facilidad;

                this.lbl48papasAño.Text += "(" + valorAñoInt32.ToString() + ")";
                CatalogCosecha cc48p = new CatalogCosecha();
                this.gdv48papas.DataSource = cc48p.GetTablaCosecha(valorAñoInt32, 4);
                this.DataBind();
            }
        }

        /*
         * Verifica si es un entero
         */
        public bool EsNumero(object Expression)
        {
            bool isNum;
            double retNum;
            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        /*
        * Llena la grilla de la temporada 48papas con el año seleccionado
        */
        private void PoblarGrilla()
        {
            CatalogCosecha cc48p = new CatalogCosecha();
            this.gdv48papas.DataSource = cc48p.GetTablaCosecha(valorAñoInt32, 4);
            this.gdv48papas.DataBind();
        }

        /*
         * LLENA CON LOS CONTROLES ESPECIFICOS EL GRIDVIEW 48PAPAS
         */
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                CatalogCosecha cc = new CatalogCosecha();
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    //devuelve 1 y lo pinta de verde si esta en upov, 0 y rojo en caso contrario
                    int index48papasUPOV = cc.GetCosechaEstaEnUPOV(valorAñoInt32, cont48papasUPOV);
                    //Ecuentra el CheckBox en la fila
                    CheckBox chkAgregarUPOV = (e.Row.FindControl("chkAgregarUPOV") as CheckBox);
                    if (index48papasUPOV == 1)
                    {
                        e.Row.BackColor = Color.LightGreen;
                        chkAgregarUPOV.Enabled = false;
                    }
                    else
                    {
                        e.Row.BackColor = Color.FromArgb(255, 204, 203);
                        chkAgregarUPOV.Enabled = true;
                    }
                    cont48papasUPOV = cont48papasUPOV + 1;
                }
            }
            catch (Exception ex)
            {
            }
        }

        protected void Cosecha48papasGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                CatalogCosecha cc = new CatalogCosecha();
                string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv48papas.Rows[e.RowIndex].Cells[2].Text);
                int valor = cc.DeleteCosecha48papas(Int32.Parse(id_cosecha));
                if (valor == 0)
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Error!\n¡No se pudo eliminar la variedad!')</script>");

                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }

        protected void btn48papasCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuGeneracion.aspx");
        }

        protected void btn48papasGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.lbl48papasError.Visible = true;
                int invalido = 0;
                int selected = this.gdv48papas.SelectedIndex;

                string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv48papas.Rows[selected].Cells[2].Text);
                int id_cosechaEntero = Int32.Parse(id_cosecha);
                string cantidad_papas = this.txt48papasCantidadPapas.Text;
                if ((EsNumero(cantidad_papas) == true && (Int32.Parse(cantidad_papas) < 0 || Int32.Parse(cantidad_papas) > 48)) || (EsNumero(cantidad_papas) == false))
                    invalido = 1;
                string posicion_cosecha = this.txt48papasPosicion.Text.Replace(",", ".");
                try
                {
                    double posicion_cosechaDouble = double.Parse(posicion_cosecha, System.Globalization.CultureInfo.InvariantCulture);
                    if (posicion_cosechaDouble < 0 || posicion_cosechaDouble > 99.99)
                        invalido = 1;
                }
                catch (Exception exTotal)
                {
                    invalido = 1;
                }

                bool flor_cosecha = false;
                if (this.chk48papasFlor.Checked == true)
                    flor_cosecha = true;
                else
                    flor_cosecha = false;
                bool bayas_cosecha = false;
                if (this.chk48papasBayas.Checked == true)
                    bayas_cosecha = true;
                else
                    bayas_cosecha = false;
                string id_fertilidad = this.ddl48papasFertilidad.SelectedValue;
                string id_emergencia40 = this.ddl48papasEmergencia40.SelectedValue;
                string id_metribuzina = this.ddl48papasMetribuzina.SelectedValue;
                string id_emergencia = this.ddl48papasEmergencia.SelectedValue;

                string id_madurez = this.ddl48papasMadurez.SelectedValue;
                string id_desarrollo = this.ddl48papasDesarrollo.SelectedValue;
                string id_tipo_hoja = this.ddl48papasTipoHoja.SelectedValue;
                string id_brotacion = this.ddl48papasBrotacion.SelectedValue;
                string id_tamaño = this.ddl48papasTamaño.SelectedValue;
                string id_distribucion = this.ddl48papasDistribucion.SelectedValue;
                string id_forma = this.ddl48papasForma.SelectedValue;
                string id_regularidad = this.ddl48papasRegularidad.SelectedValue;
                string id_profundidad = this.ddl48papasProfundidad.SelectedValue;

                string id_calidad = this.ddl48papasCalidadPiel.SelectedValue;
                string id_verdes = this.ddl48papasTuberculosVerdes.SelectedValue;
                string id_tizon_follaje = this.ddl48papasTizonFollaje.SelectedValue;
                string id_tizon_tuberculo = this.ddl48papasTizonTuberculo.SelectedValue;
                string id_numero = this.ddl48papasNumero.SelectedValue;
                string id_ciudad = this.ddl48papasCiudadPlantacion.SelectedValue;

                string total_kg = this.txt48papasTotalKg.Text.Replace(",", ".");
                try
                {
                    double total_kgDouble = double.Parse(total_kg, System.Globalization.CultureInfo.InvariantCulture);
                    if (total_kgDouble < 0 || total_kgDouble > 99999.99)
                        invalido = 1;
                }
                catch (Exception exTotal)
                {
                    invalido = 1;
                }

                string tuberculos_planta = this.txt48papasTuberculosPlanta.Text.Replace(",", ".");
                try
                {
                    double tuberculos_plantaDouble = double.Parse(tuberculos_planta, System.Globalization.CultureInfo.InvariantCulture);
                    if (tuberculos_plantaDouble < 0 || tuberculos_plantaDouble > 999.99)
                        invalido = 1;
                }
                catch (Exception exTotal)
                {
                    invalido = 1;
                }

                string consumo = this.txt48papasConsumo.Text;
                if ((EsNumero(consumo) == true && (Int32.Parse(consumo) < 0 || Int32.Parse(consumo) > 99)) || (EsNumero(consumo) == false))
                    invalido = 1;
                string semillon = this.txt48papasSemillon.Text;
                if ((EsNumero(semillon) == true && (Int32.Parse(semillon) < 0 || Int32.Parse(semillon) > 99)) || (EsNumero(semillon) == false))
                    invalido = 1;
                string semilla = this.txt48papasSemilla.Text;
                if ((EsNumero(semilla) == true && (Int32.Parse(semilla) < 0 || Int32.Parse(semilla) > 99)) || (EsNumero(semilla) == false))
                    invalido = 1;
                string semillita = this.txt48papasSemillita.Text;
                if ((EsNumero(semillita) == true && (Int32.Parse(semillita) < 0 || Int32.Parse(semillita) > 99)) || (EsNumero(semillita) == false))
                    invalido = 1;
                string bajo_calibre = this.txt48papasBajoCalibre.Text;
                if ((EsNumero(bajo_calibre) == true && (Int32.Parse(bajo_calibre) < 0 || Int32.Parse(bajo_calibre) > 99)) || (EsNumero(bajo_calibre) == false))
                    invalido = 1;
                string numero_tallos = this.txt48papasNumeroTallos.Text;
                if ((EsNumero(numero_tallos) == true && (Int32.Parse(numero_tallos) < 0 || Int32.Parse(numero_tallos) > 99)) || (EsNumero(numero_tallos) == false))
                    invalido = 1;

                string id_sensibildiad_quimica = this.ddl48papasSensibilidadQuimica.SelectedValue;
                string id_facilidad_muerte = this.ddl48papasFacilidadMuerte.SelectedValue;
                string dormancia = this.txt48papasDormancia.Text;
                if ((EsNumero(dormancia) == true && (Int32.Parse(dormancia) < 0 || Int32.Parse(dormancia) > 99)) || (EsNumero(dormancia) == false))
                    invalido = 1;
                string tolerancia_sequia = this.txt48papasToleranciaSequia.Text;
                if ((EsNumero(tolerancia_sequia) == true && (Int32.Parse(tolerancia_sequia) < 0 || Int32.Parse(tolerancia_sequia) > 99)) || (EsNumero(tolerancia_sequia) == false))
                    invalido = 1;
                string tolerancia_calor = this.txt48papasToleranciaCalor.Text;
                if ((EsNumero(tolerancia_calor) == true && (Int32.Parse(tolerancia_calor) < 0 || Int32.Parse(tolerancia_calor) > 99)) || (EsNumero(tolerancia_calor) == false))
                    invalido = 1;
                string tolerancia_sal = this.txt48papasToleranciaSal.Text;
                if ((EsNumero(tolerancia_sal) == true && (Int32.Parse(tolerancia_sal) < 0 || Int32.Parse(tolerancia_sal) > 99)) || (EsNumero(tolerancia_sal) == false))
                    invalido = 1;
                string daño_cosecha = this.txt48papasDañoCosecha.Text;
                if ((EsNumero(daño_cosecha) == true && (Int32.Parse(daño_cosecha) < 0 || Int32.Parse(daño_cosecha) > 99)) || (EsNumero(daño_cosecha) == false))
                    invalido = 1;
                string tizon_hoja = this.txt48papasTizonHoja.Text;
                if ((EsNumero(tizon_hoja) == true && (Int32.Parse(tizon_hoja) < 0 || Int32.Parse(tizon_hoja) > 99)) || (EsNumero(tizon_hoja) == false))
                    invalido = 1;
                string putrefaccion_suave = this.txt48papasPutrefaccionSuave.Text;
                if ((EsNumero(putrefaccion_suave) == true && (Int32.Parse(putrefaccion_suave) < 0 || Int32.Parse(putrefaccion_suave) > 99)) || (EsNumero(putrefaccion_suave) == false))
                    invalido = 1;
                string putrefaccion_rosa = this.txt48papasPutrefaccionRosa.Text;
                if ((EsNumero(putrefaccion_rosa) == true && (Int32.Parse(putrefaccion_rosa) < 0 || Int32.Parse(putrefaccion_rosa) > 99)) || (EsNumero(putrefaccion_rosa) == false))
                    invalido = 1;
                string silver_scurf = this.txt48papasSilverScurf.Text;
                if ((EsNumero(silver_scurf) == true && (Int32.Parse(silver_scurf) < 0 || Int32.Parse(silver_scurf) > 99)) || (EsNumero(silver_scurf) == false))
                    invalido = 1;
                string blackleg = this.txt48papasBlackleg.Text;
                if ((EsNumero(blackleg) == true && (Int32.Parse(blackleg) < 0 || Int32.Parse(blackleg) > 99)) || (EsNumero(blackleg) == false))
                    invalido = 1;

                if (invalido == 0)
                {
                    CatalogCosecha cc = new CatalogCosecha();
                    Cosecha cosecha = new Cosecha(id_cosechaEntero, Int32.Parse(cantidad_papas), Double.Parse(posicion_cosecha, CultureInfo.InvariantCulture),
                        flor_cosecha, bayas_cosecha, Int32.Parse(id_fertilidad), Int32.Parse(id_emergencia40), Int32.Parse(id_metribuzina),
                        Int32.Parse(id_emergencia), Int32.Parse(id_madurez), Int32.Parse(id_desarrollo), Int32.Parse(id_tipo_hoja),
                        Int32.Parse(id_brotacion), Int32.Parse(id_tamaño), Int32.Parse(id_distribucion), Int32.Parse(id_forma),
                        Int32.Parse(id_regularidad), Int32.Parse(id_profundidad), Int32.Parse(id_calidad), Int32.Parse(id_verdes),
                        Int32.Parse(id_tizon_follaje), Int32.Parse(id_tizon_tuberculo), Int32.Parse(id_numero), Int32.Parse(id_ciudad),
                        Double.Parse(total_kg, CultureInfo.InvariantCulture), Double.Parse(tuberculos_planta, CultureInfo.InvariantCulture),
                        Int32.Parse(consumo), Int32.Parse(semillon), Int32.Parse(semilla), Int32.Parse(semillita),
                        Int32.Parse(bajo_calibre), Int32.Parse(numero_tallos), Int32.Parse(id_sensibildiad_quimica),
                        Int32.Parse(id_facilidad_muerte), Int32.Parse(dormancia), Int32.Parse(tolerancia_sequia),
                        Int32.Parse(tolerancia_calor), Int32.Parse(tolerancia_sal), Int32.Parse(daño_cosecha),
                        Int32.Parse(tizon_hoja), Int32.Parse(putrefaccion_suave), Int32.Parse(putrefaccion_rosa),
                        Int32.Parse(silver_scurf), Int32.Parse(blackleg));

                    //Modifica Color Carne
                    List<int> selectedCarne = this.lst48papasColorCarne.GetSelectedIndices().ToList();
                    if ((selectedCarne.Count > 1 && !selectedCarne[0].Equals(0)) || (selectedCarne.Count == 1))
                    {
                        cc.DeleteCosechaColorCarne(id_cosechaEntero);
                        for (int i = 0; i < selectedCarne.Count; i++)
                        {
                            string id_color_carne = this.lst48papasColorCarne.Items[selectedCarne[i]].Value;
                            cc.UpdateCosechaColorCarne(Int32.Parse(id_color_carne), id_cosechaEntero);
                        }
                    }
                    else
                        this.lbl48papasError.Text += "No puede seleccionar sin información y colores de la carne a la vez.<br/>";

                    //Modifica Color Piel
                    List<int> selectedPiel = this.lst48papasColorPiel.GetSelectedIndices().ToList();
                    if ((selectedPiel.Count > 1 && !selectedPiel[0].Equals(0)) || (selectedPiel.Count == 1))
                    {
                        cc.DeleteCosechaColorPiel(id_cosechaEntero);
                        for (int i = 0; i < selectedPiel.Count; i++)
                        {
                            string id_color_piel = this.lst48papasColorPiel.Items[selectedPiel[i]].Value;
                            cc.UpdateCosechaColorPiel(Int32.Parse(id_color_piel), id_cosechaEntero);
                        }
                    }
                    else
                        this.lbl48papasError.Text += "No puede seleccionar sin información y colores de la piel a la vez.<br/>";

                    //Modifica Enfermedades
                    cc.DeleteCosechaEnfermedades(id_cosechaEntero);
                    foreach (GridViewRow row in gdv48papasEnfermedades.Rows)
                    {
                        string nombre_enfermedad = HttpUtility.HtmlDecode((string)this.gdv48papasEnfermedades.Rows[row.RowIndex].Cells[0].Text);
                        string resistencia_variedad = HttpUtility.HtmlDecode((string)this.gdv48papasEnfermedades.Rows[row.RowIndex].Cells[1].Text);
                        int valorEnfermedad = cc.AddCosechaEnfermedades(nombre_enfermedad, id_cosechaEntero, resistencia_variedad);
                        if (valorEnfermedad == 0)
                            this.lbl48papasError.Text += "Error al ingresar enfermedad.<br/>";
                    }

                    //Modifica Cosecha 24 papas
                    int valor = cc.UpdateCosecha48papas(cosecha);
                    if (valor == 0)
                    {
                        this.lbl48papasError.Text += "Debe seleccionar una ciudad para la variedad o la posición indicada ya existe.<br/>";
                        Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Debe seleccionar una ciudad o ya hay una variedad asignada en esa posición!')</script>");
                    }
                }
                else
                {
                    this.lbl48papasError.Text += "Error al modificar, Revise los parámetros indicados y modifiquelos.<br/>";
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Datos incorrectos!\nRevise los parámetros indicados y modifique su valor')</script>");
                }
            }
            catch (Exception ex)
            {
                this.lbl48papasError.Text += "ERROR CRÍTICO, NO SE HA PODIDO MODIFICAR LA VARIEDAD, ARREGLE LOS PARÁMETROS E INTENTELO NUEVAMENTE.<br/>";
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error al modificar!\nNo se ha podido actualizar la variedad')</script>");
            }
            PoblarGrilla();
        }

        protected void gdv48papas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = this.gdv48papas.SelectedIndex;
            CatalogCosecha cc = new CatalogCosecha();
            //id_cosecha
            string id_cosechaString = HttpUtility.HtmlDecode((string)this.gdv48papas.Rows[selected].Cells[2].Text);
            int id_cosecha = Int32.Parse(id_cosechaString);

            //Código Seleccionado
            string codigo = HttpUtility.HtmlDecode((string)this.gdv48papas.Rows[selected].Cells[8].Text);
            this.txt48papasCodigoSeleccionado.Text = codigo;

            //Flor
            bool flor = cc.GetCosechaValoresBooleanos(id_cosecha, 0);
            this.chk48papasFlor.Checked = flor;

            //Cantidad Papas
            int cantidad_papas = cc.GetCosechaValoresEnteros(id_cosecha, 1);
            this.txt48papasCantidadPapas.Text = cantidad_papas.ToString();

            //Bayas
            bool bayas = cc.GetCosechaValoresBooleanos(id_cosecha, 2);
            this.chk48papasBayas.Checked = bayas;

            //Posicion 6papas
            string posicion = HttpUtility.HtmlDecode((string)this.gdv48papas.Rows[selected].Cells[7].Text);
            this.txt48papasPosicion.Text = posicion;

            //Fertilidad
            int fertilidad = cc.GetCosechaValoresEnteros(id_cosecha, 3);
            this.ddl48papasFertilidad.SelectedValue = fertilidad.ToString();

            //Emergencia 40 días
            int emergencia_40 = cc.GetCosechaValoresEnteros(id_cosecha, 4);
            this.ddl48papasEmergencia40.SelectedValue = emergencia_40.ToString();

            //Metribuzina
            int metribuzina = cc.GetCosechaValoresEnteros(id_cosecha, 5);
            this.ddl48papasMetribuzina.SelectedValue = metribuzina.ToString();

            //Emergencia
            int emergencia = cc.GetCosechaValoresEnteros(id_cosecha, 6);
            this.ddl48papasEmergencia.SelectedValue = emergencia.ToString();

            //Madurez
            int madurez = cc.GetCosechaValoresEnteros(id_cosecha, 7);
            this.ddl48papasMadurez.SelectedValue = madurez.ToString();

            //Desarrollo Follaje
            int desarrollo_follaje = cc.GetCosechaValoresEnteros(id_cosecha, 8);
            this.ddl48papasDesarrollo.SelectedValue = desarrollo_follaje.ToString();

            //Tipo Hoja
            int tipo_hoja = cc.GetCosechaValoresEnteros(id_cosecha, 9);
            this.ddl48papasTipoHoja.SelectedValue = tipo_hoja.ToString();

            //Brotacion
            int brotacion = cc.GetCosechaValoresEnteros(id_cosecha, 10);
            this.ddl48papasBrotacion.SelectedValue = brotacion.ToString();

            //Tamaño
            int tamaño = cc.GetCosechaValoresEnteros(id_cosecha, 11);
            this.ddl48papasTamaño.SelectedValue = tamaño.ToString();

            //Distribucion calibre
            int distribucion = cc.GetCosechaValoresEnteros(id_cosecha, 12);
            this.ddl48papasDistribucion.SelectedValue = distribucion.ToString();

            //Forma
            int forma = cc.GetCosechaValoresEnteros(id_cosecha, 13);
            this.ddl48papasForma.SelectedValue = forma.ToString();

            //Regularidad
            int regularidad = cc.GetCosechaValoresEnteros(id_cosecha, 14);
            this.ddl48papasRegularidad.SelectedValue = regularidad.ToString();

            //Profundidad Ojo
            int profundidad = cc.GetCosechaValoresEnteros(id_cosecha, 15);
            this.ddl48papasProfundidad.SelectedValue = profundidad.ToString();

            //Calidad Piel
            int calidad = cc.GetCosechaValoresEnteros(id_cosecha, 16);
            this.ddl48papasCalidadPiel.SelectedValue = calidad.ToString();

            //Tuberculos Verdes
            int verdes = cc.GetCosechaValoresEnteros(id_cosecha, 17);
            this.ddl48papasTuberculosVerdes.SelectedValue = verdes.ToString();

            //Tizon Tardio Follaje
            int tizon_follaje = cc.GetCosechaValoresEnteros(id_cosecha, 18);
            this.ddl48papasTizonFollaje.SelectedValue = tizon_follaje.ToString();

            //Tizon Tardio Tuberculo
            int tizon_tuberculo = cc.GetCosechaValoresEnteros(id_cosecha, 19);
            this.ddl48papasTizonTuberculo.SelectedValue = tizon_tuberculo.ToString();

            //Numero Tuberculos
            int numero = cc.GetCosechaValoresEnteros(id_cosecha, 20);
            this.ddl48papasNumero.SelectedValue = numero.ToString();

            //Ciudad
            int ciudad = cc.GetCosechaValoresEnteros(id_cosecha, 21);
            this.ddl48papasCiudadPlantacion.SelectedValue = ciudad.ToString();

            //Color Carne
            this.lst48papasColorCarne.SelectedIndex = -1;
            List<Project.BusinessRules.Cosecha> colorCarne = cc.GetCosechaColorCarne(id_cosecha);
            foreach (ListItem item in this.lst48papasColorCarne.Items)
                for (int i = 0; i < colorCarne.Count; i++)
                    if (item.Value == colorCarne[i].Id_color.ToString())
                        item.Selected = true;

            //Color Piel
            this.lst48papasColorPiel.SelectedIndex = -1;
            List<Project.BusinessRules.Cosecha> colorPiel = cc.GetCosechaColorPiel(id_cosecha);
            foreach (ListItem item in this.lst48papasColorPiel.Items)
                for (int i = 0; i < colorPiel.Count; i++)
                    if (item.Value == colorPiel[i].Id_color.ToString())
                        item.Selected = true;

            //Total Kilogramos
            double total_kg = cc.GetCosechaValoresDouble(id_cosecha, 24);
            this.txt48papasTotalKg.Text = total_kg.ToString();

            //Tuberculos/planta
            double tuberculos_planta = cc.GetCosechaValoresDouble(id_cosecha, 25);
            this.txt48papasTuberculosPlanta.Text = tuberculos_planta.ToString();

            //Consumo
            int consumo = cc.GetCosechaValoresEnteros(id_cosecha, 28);
            this.txt48papasConsumo.Text = consumo.ToString();

            //Semillon
            int semillon = cc.GetCosechaValoresEnteros(id_cosecha, 29);
            this.txt48papasSemillon.Text = semillon.ToString();

            //Semilla
            int semilla = cc.GetCosechaValoresEnteros(id_cosecha, 30);
            this.txt48papasSemilla.Text = semilla.ToString();

            //Semillita
            int semillita = cc.GetCosechaValoresEnteros(id_cosecha, 31);
            this.txt48papasSemillita.Text = semillita.ToString();

            //Bajo Calibre
            int bajo_calibre = cc.GetCosechaValoresEnteros(id_cosecha, 32);
            this.txt48papasBajoCalibre.Text = bajo_calibre.ToString();

            //Numero Tallos
            int numero_tallos = cc.GetCosechaValoresEnteros(id_cosecha, 33);
            this.txt48papasNumeroTallos.Text = numero_tallos.ToString();

            //Sensibilidad Quimica
            int sensibilidad_quimica = cc.GetCosechaValoresEnteros(id_cosecha, 34);
            this.ddl48papasSensibilidadQuimica.SelectedValue = sensibilidad_quimica.ToString();

            //Facilidad Muerte
            int facilidad_muerte = cc.GetCosechaValoresEnteros(id_cosecha, 35);
            this.ddl48papasFacilidadMuerte.SelectedValue = facilidad_muerte.ToString();

            //Dormancia
            int dormancia = cc.GetCosechaValoresEnteros(id_cosecha, 36);
            this.txt48papasDormancia.Text = dormancia.ToString();

            //Tolerancia Sequia
            int tolerancia_sequia = cc.GetCosechaValoresEnteros(id_cosecha, 37);
            this.txt48papasToleranciaSequia.Text = tolerancia_sequia.ToString();

            //Tolerancia Calor
            int tolerancia_calor = cc.GetCosechaValoresEnteros(id_cosecha, 38);
            this.txt48papasToleranciaCalor.Text = tolerancia_calor.ToString();

            //Tolerancia Sal
            int tolerancia_sal = cc.GetCosechaValoresEnteros(id_cosecha, 39);
            this.txt48papasToleranciaSal.Text = tolerancia_sal.ToString();

            //Daño Cosecha
            int daño_cosecha = cc.GetCosechaValoresEnteros(id_cosecha, 40);
            this.txt48papasDañoCosecha.Text = daño_cosecha.ToString();

            //Hematomas
            double hematomas = cc.GetCosechaValoresDouble(id_cosecha, 41);
            this.txt48papasHematomas.Text = hematomas.ToString();

            //Tizon Hoja
            int tizon_hoja = cc.GetCosechaValoresEnteros(id_cosecha, 42);
            this.txt48papasTizonHoja.Text = tizon_hoja.ToString();

            //Putrefaccion Suave
            int putrefaccion_suave = cc.GetCosechaValoresEnteros(id_cosecha, 43);
            this.txt48papasPutrefaccionSuave.Text = putrefaccion_suave.ToString();

            //Putrefaccion Rosa
            int putrefaccion_rosa = cc.GetCosechaValoresEnteros(id_cosecha, 44);
            this.txt48papasPutrefaccionRosa.Text = putrefaccion_rosa.ToString();

            //Silver Scurf
            int silver_scurf = cc.GetCosechaValoresEnteros(id_cosecha, 45);
            this.txt48papasSilverScurf.Text = silver_scurf.ToString();

            //Blackleg
            int blackleg = cc.GetCosechaValoresEnteros(id_cosecha, 46);
            this.txt48papasBlackleg.Text = blackleg.ToString();

            //Gridview Rendimiento para el ranking de variedades
            List<Cosecha> tablaRendimiento = new List<Cosecha>();
            tablaRendimiento = cc.GetTablaRendimiento48papas(id_cosecha);
            this.gdv48papasRendimiento.DataSource = tablaRendimiento;
            this.gdv48papasRendimiento.DataBind();

            //Enfermedades y resistencia en el gridview
            this.gdv48papasEnfermedades.DataSource = cc.GetCosechaEnfermedades(id_cosecha);
            this.gdv48papasEnfermedades.DataBind();
        }

        protected void btn48papasAgregarEnfermedad_Click(object sender, EventArgs e)
        {
            try
            {
                string id_enfermedad = this.ddl48papasEnfermedad.SelectedValue;
                if (!id_enfermedad.Equals("1"))
                {
                    if (this.gdv48papasEnfermedades.Rows.Count == 0)
                    {
                        table.Rows.Add(this.ddl48papasEnfermedad.SelectedItem, this.ddl48papasResistencia.SelectedItem);
                        this.gdv48papasEnfermedades.DataSource = table;
                    }
                    else
                    {
                        listEnfermedad = new List<string>();
                        listResistencia = new List<string>();
                        foreach (GridViewRow row in gdv48papasEnfermedades.Rows)
                        {
                            string nombre_enfermedad = HttpUtility.HtmlDecode((string)this.gdv48papasEnfermedades.Rows[row.RowIndex].Cells[0].Text);
                            listEnfermedad.Add(nombre_enfermedad);
                            string resistencia_variedad = HttpUtility.HtmlDecode((string)this.gdv48papasEnfermedades.Rows[row.RowIndex].Cells[1].Text);
                            listResistencia.Add(resistencia_variedad);
                        }
                        listEnfermedad.Add(this.ddl48papasEnfermedad.SelectedItem.ToString());
                        listResistencia.Add(this.ddl48papasResistencia.SelectedItem.ToString());

                        for (int i = 0; i < listEnfermedad.Count && i < listResistencia.Count; i++)
                        {
                            table.Rows.Add(listEnfermedad[i], listResistencia[i]);
                        }
                        this.gdv48papasEnfermedades.DataSource = table;
                    }
                    this.gdv48papasEnfermedades.DataBind();
                }
                else
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Debe seleccionar una enfermedad!')</script>");
            }
            catch (Exception ex)
            {
            }
        }

        protected void Cosecha48papasEnfermedadesGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                listEnfermedad = new List<string>();
                listResistencia = new List<string>();
                foreach (GridViewRow row in gdv48papasEnfermedades.Rows)
                {
                    string nombre_enfermedad = HttpUtility.HtmlDecode((string)this.gdv48papasEnfermedades.Rows[row.RowIndex].Cells[0].Text);
                    listEnfermedad.Add(nombre_enfermedad);
                    string resistencia_variedad = HttpUtility.HtmlDecode((string)this.gdv48papasEnfermedades.Rows[row.RowIndex].Cells[1].Text);
                    listResistencia.Add(resistencia_variedad);
                }

                for (int i = 0; i < listEnfermedad.Count && i < listResistencia.Count; i++)
                {
                    if (i != e.RowIndex)
                        table.Rows.Add(listEnfermedad[i], listResistencia[i]);
                }
                this.gdv48papasEnfermedades.DataSource = table;
                this.gdv48papasEnfermedades.DataBind();
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error!\n'" + ex.ToString() + "'')</script>");
            }
        }

        protected void btnAgregarUPOV_Click(object sender, EventArgs e)
        {
            try
            {
                int agrego = 0;
                foreach (GridViewRow row in gdv48papas.Rows)
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox chkAgregarUPOV = (row.Cells[0].FindControl("chkAgregarUPOV") as CheckBox);
                        if (chkAgregarUPOV != null)
                            if (chkAgregarUPOV.Checked)
                            {
                                string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv48papas.Rows[row.RowIndex].Cells[2].Text);
                                CatalogUPOV cu = new CatalogUPOV();
                                int existe_upov = cu.AddUPOV(Int32.Parse(id_cosecha));
                                if (existe_upov == 1)
                                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('La varieadd con ID: " + id_cosecha + " seleccionada ya generó el informe UPOV o no tiene una ciudad asignada')</script>");
                                else
                                    agrego = 1;
                            }
                    }

                if (agrego == 1)
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Agregado Correctamente!')</script>");
                    Response.Redirect("MenuGeneracion.aspx");
                }
            }
            catch (Exception ex)
            {
            }
        }

        protected void Cosecha48papasGridView_DataBound(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdv48papas.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");
                if (Context.Session["PageSize"] != null)
                {
                    pageSizeList.SelectedValue = Context.Session["PageSize"].ToString();
                }
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");

                if (pageList != null)
                {
                    for (int i = 0; i < gdv48papas.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdv48papas.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }

                if (pageLabel != null)
                {
                    int currentPage = gdv48papas.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdv48papas.PageCount.ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }
        protected void ddlPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdv48papas.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");

                gdv48papas.PageSize = Convert.ToInt32(pageSizeList.SelectedValue);
                Context.Session["PageSize"] = pageSizeList.SelectedValue;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        protected void PageDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdv48papas.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdv48papas.PageIndex = pageList.SelectedIndex;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        //Siguiente página
        protected void NextLB_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdv48papas.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Aumenta la página en 1
                gdv48papas.PageIndex = pageList.SelectedIndex + 1;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        //Página anterior
        protected void PrevLB_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdv48papas.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Disminuye la página en 1
                gdv48papas.PageIndex = pageList.SelectedIndex - 1;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        //Página inicio
        protected void FirstLB_Click(object sender, EventArgs e)
        {
            try
            {
                gdv48papas.PageIndex = 0;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        //Página final
        protected void LastLB_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdv48papas.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdv48papas.PageIndex = pageList.Items.Count;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        protected void Cosecha48papasGridView_PageIndexChanging(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdv48papas.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");//error
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");
                if (pageList != null)
                {
                    for (int i = 0; i < gdv48papas.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdv48papas.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }
                if (pageLabel != null)
                {
                    int currentPage = gdv48papas.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdv48papas.PageCount.ToString();
                }
                this.gdv48papas.Controls[0].Controls[this.gdv48papas.Controls[0].Controls.Count - 1].Visible = true;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
    }
}