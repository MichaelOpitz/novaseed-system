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
    public partial class Cosecha24papas : System.Web.UI.Page
    {
        private int cont24papas48papas, valorAñoInt32;
        private string valorAñoString;
        private DataTable table;
        private List<string> listEnfermedad, listResistencia;

        protected void Page_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("nombre_enfermedad", typeof(string));
            table.Columns.Add("resistencia_variedad", typeof(string));

            cont24papas48papas = 0;

            CatalogFertilidad cf = new CatalogFertilidad();
            List<Project.BusinessRules.Fertilidad> fertilidad = cf.GetFertilidad();

            CatalogEmergencia40Dias ce40 = new CatalogEmergencia40Dias();
            List<Project.BusinessRules.Emergencia40Dias> emergencia40 = ce40.GetEmergencia40Dias();
            CatalogMetribuzina cmet = new CatalogMetribuzina();
            List<Project.BusinessRules.Metribuzina> metribuzina = cmet.GetMetribuzina();
            CatalogEmergencia ce = new CatalogEmergencia();
            List<Project.BusinessRules.Emergencia> emergencia = ce.GetEmergencia();

            CatalogMadurez cm = new CatalogMadurez();
            List<Project.BusinessRules.Madurez> madurez = cm.GetMadurez();
            CatalogDesarrolloFollaje cdf = new CatalogDesarrolloFollaje();
            List<Project.BusinessRules.DesarrolloFollaje> desarrollo = cdf.GetDesarrolloFollaje();
            CatalogTipoHoja cth = new CatalogTipoHoja();
            List<Project.BusinessRules.TipoHoja> hoja = cth.GetTipoHoja();
            CatalogBrotacion cb = new CatalogBrotacion();
            List<Project.BusinessRules.Brotacion> brotacion = cb.GetBrotacion();
            CatalogTamaño ct = new CatalogTamaño();
            List<Project.BusinessRules.Tamaño> tamaño = ct.GetTamaño();
            CatalogDistribucionCalibre cdc = new CatalogDistribucionCalibre();
            List<Project.BusinessRules.DistribucionCalibre> distribucion = cdc.GetDistribucionCalibre();
            CatalogFormaTuberculos cft = new CatalogFormaTuberculos();
            List<Project.BusinessRules.FormaTuberculos> forma = cft.GetFormaTuberculos();
            CatalogRegularidad cr = new CatalogRegularidad();
            List<Project.BusinessRules.Regularidad> regularidad = cr.GetRegularidad();
            CatalogProfundidadOjo cpo = new CatalogProfundidadOjo();
            List<Project.BusinessRules.ProfundidadOjo> profundidad = cpo.GetProfundidadOjo();
            CatalogCalidadPiel ccpiel = new CatalogCalidadPiel();
            List<Project.BusinessRules.CalidadPiel> calidad = ccpiel.GetCalidadPiel();

            CatalogTuberculosVerdes ctv = new CatalogTuberculosVerdes();
            List<Project.BusinessRules.TuberculosVerdes> verdes = ctv.GetTuberculosVerdes();
            CatalogTizonTardioFollaje cttf = new CatalogTizonTardioFollaje();
            List<Project.BusinessRules.TizonTardioFollaje> tizon_follaje = cttf.GetTizonTardioFollaje();
            CatalogTizonTardioTuberculo cttt = new CatalogTizonTardioTuberculo();
            List<Project.BusinessRules.TizonTardioTuberculo> tizon_tuberculo = cttt.GetTizonTardioTuberculo();
            CatalogNumeroTuberculos cnt = new CatalogNumeroTuberculos();
            List<Project.BusinessRules.NumeroTuberculos> numero = cnt.GetNumeroTuberculos();
            CatalogCiudad ccity = new CatalogCiudad();
            List<Project.BusinessRules.Ciudad> city = ccity.GetCiudad();

            CatalogColorCarne ccc = new CatalogColorCarne();
            List<Project.BusinessRules.ColorCarne> carne = ccc.GetColorCarne();
            CatalogColorPiel ccp = new CatalogColorPiel();
            List<Project.BusinessRules.ColorPiel> piel = ccp.GetColorPiel();

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

            this.lbl24papasError.Visible = false;
            this.lbl24papasError.Text = "";
            this.lbl24papasErrorEnfermedad.Visible = false;
            this.lbl24papasErrorEnfermedad.Text = "";
            if (!Page.IsPostBack)
            {
                this.ddl24papasFertilidad.DataValueField = "id_fertilidad";
                this.ddl24papasFertilidad.DataTextField = "nombre_fertilidad";
                this.ddl24papasFertilidad.DataSource = fertilidad;

                this.ddl24papasEmergencia40.DataValueField = "id_emergencia_40_dias";
                this.ddl24papasEmergencia40.DataTextField = "nombre_emergencia_40_dias";
                this.ddl24papasEmergencia40.DataSource = emergencia40;
                this.ddl24papasMetribuzina.DataValueField = "id_metribuzina";
                this.ddl24papasMetribuzina.DataTextField = "nombre_metribuzina";
                this.ddl24papasMetribuzina.DataSource = metribuzina;
                this.ddl24papasEmergencia.DataValueField = "id_emergencia";
                this.ddl24papasEmergencia.DataTextField = "nombre_emergencia";
                this.ddl24papasEmergencia.DataSource = emergencia;

                this.ddl24papasMadurez.DataValueField = "id_madurez";
                this.ddl24papasMadurez.DataTextField = "nombre_madurez";
                this.ddl24papasMadurez.DataSource = madurez;
                this.ddl24papasDesarrollo.DataValueField = "id_desarrollo_follaje";
                this.ddl24papasDesarrollo.DataTextField = "nombre_desarrollo_follaje";
                this.ddl24papasDesarrollo.DataSource = desarrollo;
                this.ddl24papasTipoHoja.DataValueField = "id_tipo_hoja";
                this.ddl24papasTipoHoja.DataTextField = "nombre_tipo_hoja";
                this.ddl24papasTipoHoja.DataSource = hoja;
                this.ddl24papasBrotacion.DataValueField = "id_brotacion";
                this.ddl24papasBrotacion.DataTextField = "nombre_brotacion";
                this.ddl24papasBrotacion.DataSource = brotacion;

                this.ddl24papasTamaño.DataValueField = "id_tamaño";
                this.ddl24papasTamaño.DataTextField = "nombre_tamaño";
                this.ddl24papasTamaño.DataSource = tamaño;
                this.ddl24papasDistribucion.DataValueField = "id_distribucion_calibre";
                this.ddl24papasDistribucion.DataTextField = "nombre_distribucion_calibre";
                this.ddl24papasDistribucion.DataSource = distribucion;
                this.ddl24papasForma.DataValueField = "id_forma";
                this.ddl24papasForma.DataTextField = "nombre_forma";
                this.ddl24papasForma.DataSource = forma;
                this.ddl24papasRegularidad.DataValueField = "id_regularidad";
                this.ddl24papasRegularidad.DataTextField = "nombre_regularidad";
                this.ddl24papasRegularidad.DataSource = regularidad;
                this.ddl24papasProfundidad.DataValueField = "id_profundidad";
                this.ddl24papasProfundidad.DataTextField = "profundidad_ojo";
                this.ddl24papasProfundidad.DataSource = profundidad;
                this.ddl24papasCalidadPiel.DataValueField = "id_calidad_piel";
                this.ddl24papasCalidadPiel.DataTextField = "nombre_calidad_piel";
                this.ddl24papasCalidadPiel.DataSource = calidad;
                this.ddl24papasTuberculosVerdes.DataValueField = "id_tuberculos_verdes";
                this.ddl24papasTuberculosVerdes.DataTextField = "nombre_tuberculos_verdes";
                this.ddl24papasTuberculosVerdes.DataSource = verdes;
                this.ddl24papasTizonFollaje.DataValueField = "id_tizon_tardio_follaje";
                this.ddl24papasTizonFollaje.DataTextField = "nombre_tizon_tardio_follaje";
                this.ddl24papasTizonFollaje.DataSource = tizon_follaje;
                this.ddl24papasTizonTuberculo.DataValueField = "id_tizon_tardio_tuberculo";
                this.ddl24papasTizonTuberculo.DataTextField = "nombre_tizon_tardio_tuberculo";
                this.ddl24papasTizonTuberculo.DataSource = tizon_tuberculo;
                this.ddl24papasNumero.DataValueField = "id_numero_tuberculos";
                this.ddl24papasNumero.DataTextField = "nombre_numero_tuberculos";
                this.ddl24papasNumero.DataSource = numero;
                this.ddl24papasCiudadPlantacion.DataValueField = "id_ciudad";
                this.ddl24papasCiudadPlantacion.DataTextField = "nombre_ciudad";
                this.ddl24papasCiudadPlantacion.DataSource = city;

                this.lst24papasColorCarne.DataValueField = "id_color_carne";
                this.lst24papasColorCarne.DataTextField = "nombre_color_carne";
                this.lst24papasColorCarne.DataSource = carne;
                this.lst24papasColorPiel.DataValueField = "id_color_piel";
                this.lst24papasColorPiel.DataTextField = "nombre_color_piel";
                this.lst24papasColorPiel.DataSource = piel;

                this.ddl24papasEnfermedad.DataValueField = "id_enfermedad";
                this.ddl24papasEnfermedad.DataTextField = "nombre_enfermedad";
                this.ddl24papasEnfermedad.DataSource = enfermedad;
                this.ddl24papasResistencia.DataValueField = "id_resistencia_variedad";
                this.ddl24papasResistencia.DataTextField = "nombre_resistencia_variedad";
                this.ddl24papasResistencia.DataSource = resistencia;

                this.ddl24papasSensibilidadQuimica.DataValueField = "id_sensibilidad_quimica";
                this.ddl24papasSensibilidadQuimica.DataTextField = "nombre_sensibilidad_quimica";
                this.ddl24papasSensibilidadQuimica.DataSource = sensibilidad;
                this.ddl24papasFacilidadMuerte.DataValueField = "id_facilidad_muerte";
                this.ddl24papasFacilidadMuerte.DataTextField = "nombre_facilidad_muerte";
                this.ddl24papasFacilidadMuerte.DataSource = facilidad;

                this.lbl24papasAño.Text += "(" + valorAñoInt32.ToString() + ")";
                CatalogCosecha cc24p = new CatalogCosecha();
                this.gdv24papas.DataSource = cc24p.GetTablaCosecha(valorAñoInt32, 3);
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
        * Llena la grilla de la temporada 24papas con el año seleccionado
        */
        private void PoblarGrilla()
        {
            CatalogCosecha cc24p = new CatalogCosecha();
            this.gdv24papas.DataSource = cc24p.GetTablaCosecha(valorAñoInt32, 3);
            this.gdv24papas.DataBind();
        }

        /*
         * LLENA CON LOS CONTROLES ESPECIFICOS EL GRIDVIEW 24PAPAS
         */
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                CatalogCosecha cc = new CatalogCosecha();
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    //el tercer parametro es 4 por el id_temporada que es 48 papas(4 para el color, 3 para el obtener en catalog)
                    int index12papas24papas = cc.GetCosechaTemporadasAvanzadas(valorAñoInt32, cont24papas48papas, 4);
                    //Ecuentra el CheckBox en la fila
                    CheckBox chkAgregar48Papas = (e.Row.FindControl("chkAgregar48Papas") as CheckBox);
                    if (index12papas24papas == 1)
                    {
                        e.Row.BackColor = Color.LightGreen;
                        chkAgregar48Papas.Enabled = false;
                    }
                    else
                    {
                        e.Row.BackColor = Color.FromArgb(255, 204, 203);
                        chkAgregar48Papas.Enabled = true;
                    }
                    cont24papas48papas = cont24papas48papas + 1;
                }
            }
            catch (Exception ex)
            {
            }
        }

        protected void Cosecha24papasGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                CatalogCosecha cc = new CatalogCosecha();
                string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv24papas.Rows[e.RowIndex].Cells[2].Text);
                int valor = cc.DeleteCosecha24papas(Int32.Parse(id_cosecha));
                if (valor == 0)
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error! No se pudo eliminar la variedad')</script>");

                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }    

        protected void btn24papasCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuGeneracion.aspx");
        }

        protected void btn24papasGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.lbl24papasError.Visible = true;
                int invalido = 0;
                int selected = this.gdv24papas.SelectedIndex;

                string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv24papas.Rows[selected].Cells[2].Text);
                int id_cosechaEntero = Int32.Parse(id_cosecha);
                string cantidad_papas = this.txt24papasCantidadPapas.Text;
                if ((EsNumero(cantidad_papas) == true && (Int32.Parse(cantidad_papas) < 0 || Int32.Parse(cantidad_papas) > 24)) || (EsNumero(cantidad_papas) == false))
                    invalido = 1;
                string posicion_cosecha = this.txt24papasPosicion.Text.Replace(",", ".");
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
                if (this.chk24papasFlor.Checked == true)
                    flor_cosecha = true;
                else
                    flor_cosecha = false;
                bool bayas_cosecha = false;
                if (this.chk24papasBayas.Checked == true)
                    bayas_cosecha = true;
                else
                    bayas_cosecha = false;
                string id_fertilidad = this.ddl24papasFertilidad.SelectedValue;
                string id_emergencia40 = this.ddl24papasEmergencia40.SelectedValue;
                string id_metribuzina = this.ddl24papasMetribuzina.SelectedValue;
                string id_emergencia = this.ddl24papasEmergencia.SelectedValue;

                string id_madurez = this.ddl24papasMadurez.SelectedValue;
                string id_desarrollo = this.ddl24papasDesarrollo.SelectedValue;
                string id_tipo_hoja = this.ddl24papasTipoHoja.SelectedValue;
                string id_brotacion = this.ddl24papasBrotacion.SelectedValue;
                string id_tamaño = this.ddl24papasTamaño.SelectedValue;
                string id_distribucion = this.ddl24papasDistribucion.SelectedValue;
                string id_forma = this.ddl24papasForma.SelectedValue;
                string id_regularidad = this.ddl24papasRegularidad.SelectedValue;
                string id_profundidad = this.ddl24papasProfundidad.SelectedValue;

                string id_calidad = this.ddl24papasCalidadPiel.SelectedValue;
                string id_verdes = this.ddl24papasTuberculosVerdes.SelectedValue;
                string id_tizon_follaje = this.ddl24papasTizonFollaje.SelectedValue;
                string id_tizon_tuberculo = this.ddl24papasTizonTuberculo.SelectedValue;
                string id_numero = this.ddl24papasNumero.SelectedValue;
                string id_ciudad = this.ddl24papasCiudadPlantacion.SelectedValue;

                string total_kg = this.txt24papasTotalKg.Text.Replace(",", ".");
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

                string tuberculos_planta = this.txt24papasTuberculosPlanta.Text.Replace(",", ".");
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

                string toneladas_hectarea = this.txt24papasToneladasHectarea.Text.Replace(",", ".");
                try
                {
                    double toneladas_hectareaDouble = double.Parse(toneladas_hectarea, System.Globalization.CultureInfo.InvariantCulture);
                    if (toneladas_hectareaDouble < 0 || toneladas_hectareaDouble > 9999.99)
                        invalido = 1;
                }
                catch (Exception exTotal)
                {
                    invalido = 1;
                }

                string porcentaje_relacion = this.txt24papasRelacionStandard.Text.Replace("%", "");
                if ((EsNumero(porcentaje_relacion) == true && (Int32.Parse(porcentaje_relacion) < 0 || Int32.Parse(porcentaje_relacion) > 999)) || (EsNumero(porcentaje_relacion) == false))
                    invalido = 1;
                string consumo = this.txt24papasConsumo.Text;
                if ((EsNumero(consumo) == true && (Int32.Parse(consumo) < 0 || Int32.Parse(consumo) > 99)) || (EsNumero(consumo) == false))
                    invalido = 1;
                string semillon = this.txt24papasSemillon.Text;
                if ((EsNumero(semillon) == true && (Int32.Parse(semillon) < 0 || Int32.Parse(semillon) > 99)) || (EsNumero(semillon) == false))
                    invalido = 1;
                string semilla = this.txt24papasSemilla.Text;
                if ((EsNumero(semilla) == true && (Int32.Parse(semilla) < 0 || Int32.Parse(semilla) > 99)) || (EsNumero(semilla) == false))
                    invalido = 1;
                string semillita = this.txt24papasSemillita.Text;
                if ((EsNumero(semillita) == true && (Int32.Parse(semillita) < 0 || Int32.Parse(semillita) > 99)) || (EsNumero(semillita) == false))
                    invalido = 1;
                string bajo_calibre = this.txt24papasBajoCalibre.Text;
                if ((EsNumero(bajo_calibre) == true && (Int32.Parse(bajo_calibre) < 0 || Int32.Parse(bajo_calibre) > 99)) || (EsNumero(bajo_calibre) == false))
                    invalido = 1;
                string numero_tallos = this.txt24papasNumeroTallos.Text;
                if ((EsNumero(numero_tallos) == true && (Int32.Parse(numero_tallos) < 0 || Int32.Parse(numero_tallos) > 99)) || (EsNumero(numero_tallos) == false))
                    invalido = 1;

                string id_sensibildiad_quimica = this.ddl24papasSensibilidadQuimica.SelectedValue;
                string id_facilidad_muerte = this.ddl24papasFacilidadMuerte.SelectedValue;
                string dormancia = this.txt24papasDormancia.Text;
                if ((EsNumero(dormancia) == true && (Int32.Parse(dormancia) < 0 || Int32.Parse(dormancia) > 99)) || (EsNumero(dormancia) == false))
                    invalido = 1;
                string tolerancia_sequia = this.txt24papasToleranciaSequia.Text;
                if ((EsNumero(tolerancia_sequia) == true && (Int32.Parse(tolerancia_sequia) < 0 || Int32.Parse(tolerancia_sequia) > 99)) || (EsNumero(tolerancia_sequia) == false))
                    invalido = 1;
                string tolerancia_calor = this.txt24papasToleranciaCalor.Text;
                if ((EsNumero(tolerancia_calor) == true && (Int32.Parse(tolerancia_calor) < 0 || Int32.Parse(tolerancia_calor) > 99)) || (EsNumero(tolerancia_calor) == false))
                    invalido = 1;
                string tolerancia_sal = this.txt24papasToleranciaSal.Text;
                if ((EsNumero(tolerancia_sal) == true && (Int32.Parse(tolerancia_sal) < 0 || Int32.Parse(tolerancia_sal) > 99)) || (EsNumero(tolerancia_sal) == false))
                    invalido = 1;
                string daño_cosecha = this.txt24papasDañoCosecha.Text;
                if ((EsNumero(daño_cosecha) == true && (Int32.Parse(daño_cosecha) < 0 || Int32.Parse(daño_cosecha) > 99)) || (EsNumero(daño_cosecha) == false))
                    invalido = 1;
                string tizon_hoja = this.txt24papasTizonHoja.Text;
                if ((EsNumero(tizon_hoja) == true && (Int32.Parse(tizon_hoja) < 0 || Int32.Parse(tizon_hoja) > 99)) || (EsNumero(tizon_hoja) == false))
                    invalido = 1;
                string putrefaccion_suave = this.txt24papasPutrefaccionSuave.Text;
                if ((EsNumero(putrefaccion_suave) == true && (Int32.Parse(putrefaccion_suave) < 0 || Int32.Parse(putrefaccion_suave) > 99)) || (EsNumero(putrefaccion_suave) == false))
                    invalido = 1;
                string putrefaccion_rosa = this.txt24papasPutrefaccionRosa.Text;
                if ((EsNumero(putrefaccion_rosa) == true && (Int32.Parse(putrefaccion_rosa) < 0 || Int32.Parse(putrefaccion_rosa) > 99)) || (EsNumero(putrefaccion_rosa) == false))
                    invalido = 1;
                string silver_scurf = this.txt24papasSilverScurf.Text;
                if ((EsNumero(silver_scurf) == true && (Int32.Parse(silver_scurf) < 0 || Int32.Parse(silver_scurf) > 99)) || (EsNumero(silver_scurf) == false))
                    invalido = 1;
                string blackleg = this.txt24papasBlackleg.Text;
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
                        Double.Parse(toneladas_hectarea, CultureInfo.InvariantCulture), Int32.Parse(porcentaje_relacion),
                        Int32.Parse(consumo), Int32.Parse(semillon), Int32.Parse(semilla), Int32.Parse(semillita),
                        Int32.Parse(bajo_calibre), Int32.Parse(numero_tallos), Int32.Parse(id_sensibildiad_quimica),
                        Int32.Parse(id_facilidad_muerte), Int32.Parse(dormancia), Int32.Parse(tolerancia_sequia),
                        Int32.Parse(tolerancia_calor), Int32.Parse(tolerancia_sal), Int32.Parse(daño_cosecha),
                        Int32.Parse(tizon_hoja), Int32.Parse(putrefaccion_suave), Int32.Parse(putrefaccion_rosa),
                        Int32.Parse(silver_scurf), Int32.Parse(blackleg));

                    //Modifica Color Carne
                    List<int> selectedCarne = this.lst24papasColorCarne.GetSelectedIndices().ToList();
                    if ((selectedCarne.Count > 1 && !selectedCarne[0].Equals(0)) || (selectedCarne.Count == 1))
                    {
                        cc.DeleteCosechaColorCarne(id_cosechaEntero);
                        for (int i = 0; i < selectedCarne.Count; i++)
                        {
                            string id_color_carne = this.lst24papasColorCarne.Items[selectedCarne[i]].Value;
                            cc.UpdateCosechaColorCarne(Int32.Parse(id_color_carne), id_cosechaEntero);
                        }
                    }
                    else
                        this.lbl24papasError.Text += "No puede seleccionar sin información y colores de la carne a la vez.<br/>";

                    //Modifica Color Piel
                    List<int> selectedPiel = this.lst24papasColorPiel.GetSelectedIndices().ToList();
                    if ((selectedPiel.Count > 1 && !selectedPiel[0].Equals(0)) || (selectedPiel.Count == 1))
                    {
                        cc.DeleteCosechaColorPiel(id_cosechaEntero);
                        for (int i = 0; i < selectedPiel.Count; i++)
                        {
                            string id_color_piel = this.lst24papasColorPiel.Items[selectedPiel[i]].Value;
                            cc.UpdateCosechaColorPiel(Int32.Parse(id_color_piel), id_cosechaEntero);
                        }
                    }
                    else
                        this.lbl24papasError.Text += "No puede seleccionar sin información y colores de la piel a la vez.<br/>";

                    //Modifica Enfermedades
                    cc.DeleteCosechaEnfermedades(id_cosechaEntero);
                    foreach (GridViewRow row in gdv24papasEnfermedades.Rows)
                    {
                        string nombre_enfermedad = HttpUtility.HtmlDecode((string)this.gdv24papasEnfermedades.Rows[row.RowIndex].Cells[0].Text);
                        string resistencia_variedad = HttpUtility.HtmlDecode((string)this.gdv24papasEnfermedades.Rows[row.RowIndex].Cells[1].Text);
                        int valorEnfermedad = cc.AddCosechaEnfermedades(nombre_enfermedad, id_cosechaEntero, resistencia_variedad);
                        if (valorEnfermedad == 0)
                            this.lbl24papasError.Text += "Error al ingresar enfermedad.<br/>";
                    }

                    //Modifica Cosecha 24 papas
                    int valor = cc.UpdateCosecha24papas(cosecha);
                    if (valor == 0)
                    {
                        this.lbl24papasError.Text += "Debe seleccionar una ciudad para la variedad o la posición indicada ya existe.<br/>";
                        Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Debe seleccionar una ciudad o ya hay una variedad asignada en esa posición!')</script>");
                    }
                }
                else
                {
                    this.lbl24papasError.Text += "Error al modificar, Revise los parámetros indicados y modifiquelos.<br/>";
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Datos incorrectos! Revise los parámetros indicados y modifique su valor')</script>");
                }
            }
            catch (Exception ex)
            {
                this.lbl24papasError.Text += "ERROR CRÍTICO, NO SE HA PODIDO MODIFICAR LA VARIEDAD, ARREGLE LOS PARÁMETROS E INTENTELO NUEVAMENTE.<br/>";
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error al modificar! No se ha podido actualizar la variedad')</script>");
            }
            PoblarGrilla();
        }

        protected void gdv24papas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = this.gdv24papas.SelectedIndex;
            CatalogCosecha cc = new CatalogCosecha();
            //id_cosecha
            string id_cosechaString = HttpUtility.HtmlDecode((string)this.gdv24papas.Rows[selected].Cells[2].Text);
            int id_cosecha = Int32.Parse(id_cosechaString);

            //Código Seleccionado
            string codigo = HttpUtility.HtmlDecode((string)this.gdv24papas.Rows[selected].Cells[8].Text);
            this.txt24papasCodigoSeleccionado.Text = codigo;

            //Flor
            bool flor = cc.GetCosechaValoresBooleanos(id_cosecha, 0);
            this.chk24papasFlor.Checked = flor;

            //Cantidad Papas
            int cantidad_papas = cc.GetCosechaValoresEnteros(id_cosecha, 1);
            this.txt24papasCantidadPapas.Text = cantidad_papas.ToString();

            //Bayas
            bool bayas = cc.GetCosechaValoresBooleanos(id_cosecha, 2);
            this.chk24papasBayas.Checked = bayas;

            //Posicion 6papas
            string posicion = HttpUtility.HtmlDecode((string)this.gdv24papas.Rows[selected].Cells[7].Text);
            this.txt24papasPosicion.Text = posicion;

            //Fertilidad
            int fertilidad = cc.GetCosechaValoresEnteros(id_cosecha, 3);
            this.ddl24papasFertilidad.SelectedValue = fertilidad.ToString();

            //Emergencia 40 días
            int emergencia_40 = cc.GetCosechaValoresEnteros(id_cosecha, 4);
            this.ddl24papasEmergencia40.SelectedValue = emergencia_40.ToString();

            //Metribuzina
            int metribuzina = cc.GetCosechaValoresEnteros(id_cosecha, 5);
            this.ddl24papasMetribuzina.SelectedValue = metribuzina.ToString();

            //Emergencia
            int emergencia = cc.GetCosechaValoresEnteros(id_cosecha, 6);
            this.ddl24papasEmergencia.SelectedValue = emergencia.ToString();

            //Madurez
            int madurez = cc.GetCosechaValoresEnteros(id_cosecha, 7);
            this.ddl24papasMadurez.SelectedValue = madurez.ToString();

            //Desarrollo Follaje
            int desarrollo_follaje = cc.GetCosechaValoresEnteros(id_cosecha, 8);
            this.ddl24papasDesarrollo.SelectedValue = desarrollo_follaje.ToString();

            //Tipo Hoja
            int tipo_hoja = cc.GetCosechaValoresEnteros(id_cosecha, 9);
            this.ddl24papasTipoHoja.SelectedValue = tipo_hoja.ToString();

            //Brotacion
            int brotacion = cc.GetCosechaValoresEnteros(id_cosecha, 10);
            this.ddl24papasBrotacion.SelectedValue = brotacion.ToString();

            //Tamaño
            int tamaño = cc.GetCosechaValoresEnteros(id_cosecha, 11);
            this.ddl24papasTamaño.SelectedValue = tamaño.ToString();

            //Distribucion calibre
            int distribucion = cc.GetCosechaValoresEnteros(id_cosecha, 12);
            this.ddl24papasDistribucion.SelectedValue = distribucion.ToString();

            //Forma
            int forma = cc.GetCosechaValoresEnteros(id_cosecha, 13);
            this.ddl24papasForma.SelectedValue = forma.ToString();

            //Regularidad
            int regularidad = cc.GetCosechaValoresEnteros(id_cosecha, 14);
            this.ddl24papasRegularidad.SelectedValue = regularidad.ToString();

            //Profundidad Ojo
            int profundidad = cc.GetCosechaValoresEnteros(id_cosecha, 15);
            this.ddl24papasProfundidad.SelectedValue = profundidad.ToString();

            //Calidad Piel
            int calidad = cc.GetCosechaValoresEnteros(id_cosecha, 16);
            this.ddl24papasCalidadPiel.SelectedValue = calidad.ToString();

            //Tuberculos Verdes
            int verdes = cc.GetCosechaValoresEnteros(id_cosecha, 17);
            this.ddl24papasTuberculosVerdes.SelectedValue = verdes.ToString();

            //Tizon Tardio Follaje
            int tizon_follaje = cc.GetCosechaValoresEnteros(id_cosecha, 18);
            this.ddl24papasTizonFollaje.SelectedValue = tizon_follaje.ToString();

            //Tizon Tardio Tuberculo
            int tizon_tuberculo = cc.GetCosechaValoresEnteros(id_cosecha, 19);
            this.ddl24papasTizonTuberculo.SelectedValue = tizon_tuberculo.ToString();

            //Numero Tuberculos
            int numero = cc.GetCosechaValoresEnteros(id_cosecha, 20);
            this.ddl24papasNumero.SelectedValue = numero.ToString();

            //Ciudad
            int ciudad = cc.GetCosechaValoresEnteros(id_cosecha, 21);
            this.ddl24papasCiudadPlantacion.SelectedValue = ciudad.ToString();

            //Color Carne
            this.lst24papasColorCarne.SelectedIndex = -1;
            List<Project.BusinessRules.Cosecha> colorCarne = cc.GetCosechaColorCarne(id_cosecha);
            foreach (ListItem item in this.lst24papasColorCarne.Items)
                for (int i = 0; i < colorCarne.Count; i++)
                    if (item.Value == colorCarne[i].Id_color.ToString())
                        item.Selected = true;

            //Color Piel
            this.lst24papasColorPiel.SelectedIndex = -1;
            List<Project.BusinessRules.Cosecha> colorPiel = cc.GetCosechaColorPiel(id_cosecha);
            foreach (ListItem item in this.lst24papasColorPiel.Items)
                for (int i = 0; i < colorPiel.Count; i++)
                    if (item.Value == colorPiel[i].Id_color.ToString())
                        item.Selected = true;

            //Total Kilogramos
            double total_kg = cc.GetCosechaValoresDouble(id_cosecha, 24);
            this.txt24papasTotalKg.Text = total_kg.ToString();

            //Tuberculos/planta
            double tuberculos_planta = cc.GetCosechaValoresDouble(id_cosecha, 25);
            this.txt24papasTuberculosPlanta.Text = tuberculos_planta.ToString();

            //Toneladas/hectarea
            double toneladas_hectarea = cc.GetCosechaValoresDouble(id_cosecha, 26);
            this.txt24papasToneladasHectarea.Text = toneladas_hectarea.ToString();

            // % Relacion Standard
            int porcentaje_relacion = cc.GetCosechaValoresEnteros(id_cosecha, 27);
            this.txt24papasRelacionStandard.Text = porcentaje_relacion.ToString() + "%";

            //Consumo
            int consumo = cc.GetCosechaValoresEnteros(id_cosecha, 28);
            this.txt24papasConsumo.Text = consumo.ToString();

            //Semillon
            int semillon = cc.GetCosechaValoresEnteros(id_cosecha, 29);
            this.txt24papasSemillon.Text = semillon.ToString();

            //Semilla
            int semilla = cc.GetCosechaValoresEnteros(id_cosecha, 30);
            this.txt24papasSemilla.Text = semilla.ToString();

            //Semillita
            int semillita = cc.GetCosechaValoresEnteros(id_cosecha, 31);
            this.txt24papasSemillita.Text = semillita.ToString();

            //Bajo Calibre
            int bajo_calibre = cc.GetCosechaValoresEnteros(id_cosecha, 32);
            this.txt24papasBajoCalibre.Text = bajo_calibre.ToString();

            //Numero Tallos
            int numero_tallos = cc.GetCosechaValoresEnteros(id_cosecha, 33);
            this.txt24papasNumeroTallos.Text = numero_tallos.ToString();

            //Sensibilidad Quimica
            int sensibilidad_quimica = cc.GetCosechaValoresEnteros(id_cosecha, 34);
            this.ddl24papasSensibilidadQuimica.SelectedValue = sensibilidad_quimica.ToString();

            //Facilidad Muerte
            int facilidad_muerte = cc.GetCosechaValoresEnteros(id_cosecha, 35);
            this.ddl24papasFacilidadMuerte.SelectedValue = facilidad_muerte.ToString();

            //Dormancia
            int dormancia = cc.GetCosechaValoresEnteros(id_cosecha, 36);
            this.txt24papasDormancia.Text = dormancia.ToString();

            //Tolerancia Sequia
            int tolerancia_sequia = cc.GetCosechaValoresEnteros(id_cosecha, 37);
            this.txt24papasToleranciaSequia.Text = tolerancia_sequia.ToString();

            //Tolerancia Calor
            int tolerancia_calor = cc.GetCosechaValoresEnteros(id_cosecha, 38);
            this.txt24papasToleranciaCalor.Text = tolerancia_calor.ToString();

            //Tolerancia Sal
            int tolerancia_sal = cc.GetCosechaValoresEnteros(id_cosecha, 39);
            this.txt24papasToleranciaSal.Text = tolerancia_sal.ToString();

            //Daño Cosecha
            int daño_cosecha = cc.GetCosechaValoresEnteros(id_cosecha, 40);
            this.txt24papasDañoCosecha.Text = daño_cosecha.ToString();

            //Hematomas
            double hematomas = cc.GetCosechaValoresDouble(id_cosecha, 41);
            this.txt24papasHematomas.Text = hematomas.ToString();

            //Tizon Hoja
            int tizon_hoja = cc.GetCosechaValoresEnteros(id_cosecha, 42);
            this.txt24papasTizonHoja.Text = tizon_hoja.ToString();

            //Putrefaccion Suave
            int putrefaccion_suave = cc.GetCosechaValoresEnteros(id_cosecha, 43);
            this.txt24papasPutrefaccionSuave.Text = putrefaccion_suave.ToString();

            //Putrefaccion Rosa
            int putrefaccion_rosa = cc.GetCosechaValoresEnteros(id_cosecha, 44);
            this.txt24papasPutrefaccionRosa.Text = putrefaccion_rosa.ToString();

            //Silver Scurf
            int silver_scurf = cc.GetCosechaValoresEnteros(id_cosecha, 45);
            this.txt24papasSilverScurf.Text = silver_scurf.ToString();

            //Blackleg
            int blackleg = cc.GetCosechaValoresEnteros(id_cosecha, 46);
            this.txt24papasBlackleg.Text = blackleg.ToString();

            //Enfermedades y resistencia en el gridview
            this.gdv24papasEnfermedades.DataSource = cc.GetCosechaEnfermedades(id_cosecha);
            this.gdv24papasEnfermedades.DataBind();
        }

        protected void btn24papasAgregarEnfermedad_Click(object sender, EventArgs e)
        {
            try
            {
                this.lbl24papasErrorEnfermedad.Visible = true;
                string id_enfermedad = this.ddl24papasEnfermedad.SelectedValue;
                if (!id_enfermedad.Equals("1"))
                {
                    if (this.gdv24papasEnfermedades.Rows.Count == 0)
                    {
                        table.Rows.Add(this.ddl24papasEnfermedad.SelectedItem, this.ddl24papasResistencia.SelectedItem);
                        this.gdv24papasEnfermedades.DataSource = table;
                    }
                    else
                    {
                        listEnfermedad = new List<string>();
                        listResistencia = new List<string>();
                        foreach (GridViewRow row in gdv24papasEnfermedades.Rows)
                        {
                            string nombre_enfermedad = HttpUtility.HtmlDecode((string)this.gdv24papasEnfermedades.Rows[row.RowIndex].Cells[0].Text);
                            listEnfermedad.Add(nombre_enfermedad);
                            string resistencia_variedad = HttpUtility.HtmlDecode((string)this.gdv24papasEnfermedades.Rows[row.RowIndex].Cells[1].Text);
                            listResistencia.Add(resistencia_variedad);
                        }
                        string existeEnfermedad = listEnfermedad.Find(x => x == this.ddl24papasEnfermedad.SelectedItem.ToString());
                        if (existeEnfermedad == null)
                        {
                            listEnfermedad.Add(this.ddl24papasEnfermedad.SelectedItem.ToString());
                            listResistencia.Add(this.ddl24papasResistencia.SelectedItem.ToString());
                        }
                        else
                            this.lbl24papasErrorEnfermedad.Text += "La enfermedad seleccionada ya existe.<br/>";

                        for (int i = 0; i < listEnfermedad.Count && i < listResistencia.Count; i++)
                        {
                            table.Rows.Add(listEnfermedad[i], listResistencia[i]);
                        }
                        this.gdv24papasEnfermedades.DataSource = table;
                    }
                    this.gdv24papasEnfermedades.DataBind();
                }
                else
                    this.lbl24papasErrorEnfermedad.Text += "Debe seleccionar una enfermedad.<br/>";
            }
            catch (Exception ex)
            {
            }
        }

        protected void Cosecha24papasEnfermedadesGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                listEnfermedad = new List<string>();
                listResistencia = new List<string>();
                foreach (GridViewRow row in gdv24papasEnfermedades.Rows)
                {
                    string nombre_enfermedad = HttpUtility.HtmlDecode((string)this.gdv24papasEnfermedades.Rows[row.RowIndex].Cells[0].Text);
                    listEnfermedad.Add(nombre_enfermedad);
                    string resistencia_variedad = HttpUtility.HtmlDecode((string)this.gdv24papasEnfermedades.Rows[row.RowIndex].Cells[1].Text);
                    listResistencia.Add(resistencia_variedad);
                }

                for (int i = 0; i < listEnfermedad.Count && i < listResistencia.Count; i++)
                {
                    if (i != e.RowIndex)
                        table.Rows.Add(listEnfermedad[i], listResistencia[i]);
                }
                this.gdv24papasEnfermedades.DataSource = table;
                this.gdv24papasEnfermedades.DataBind();
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error!\n'" + ex.ToString() + "'')</script>");
            }
        }

        protected void btnAgregar48papas_Click(object sender, EventArgs e)
        {
            try
            {
                int agrego = 0;
                foreach (GridViewRow row in gdv24papas.Rows)
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox chkAgregar48Papas = (row.Cells[0].FindControl("chkAgregar48Papas") as CheckBox);
                        if (chkAgregar48Papas != null)
                            if (chkAgregar48Papas.Checked)
                            {
                                string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv24papas.Rows[row.RowIndex].Cells[2].Text);
                                CatalogCosecha cc = new CatalogCosecha();
                                int existe_48papas = cc.AddCosecha48papas(Int32.Parse(id_cosecha));
                                if (existe_48papas == 1)
                                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('La varieadd con ID: " + id_cosecha + " seleccionada ya está en temporadas avanzadas o no tiene una ciudad asignada')</script>");
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

        protected void Cosecha24papasGridView_DataBound(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdv24papas.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");
                if (Context.Session["PageSize"] != null)
                {
                    pageSizeList.SelectedValue = Context.Session["PageSize"].ToString();
                }
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");

                if (pageList != null)
                {
                    for (int i = 0; i < gdv24papas.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdv24papas.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }

                if (pageLabel != null)
                {
                    int currentPage = gdv24papas.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdv24papas.PageCount.ToString();
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
                GridViewRow pagerRow = gdv24papas.BottomPagerRow;
                DropDownList pageSizeList = (DropDownList)pagerRow.Cells[0].FindControl("ddlPageSize");

                gdv24papas.PageSize = Convert.ToInt32(pageSizeList.SelectedValue);
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
                GridViewRow pagerRow = gdv24papas.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdv24papas.PageIndex = pageList.SelectedIndex;
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
                GridViewRow pagerRow = gdv24papas.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Aumenta la página en 1
                gdv24papas.PageIndex = pageList.SelectedIndex + 1;
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
                GridViewRow pagerRow = gdv24papas.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                //Disminuye la página en 1
                gdv24papas.PageIndex = pageList.SelectedIndex - 1;
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
                gdv24papas.PageIndex = 0;
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
                GridViewRow pagerRow = gdv24papas.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
                gdv24papas.PageIndex = pageList.Items.Count;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
        protected void Cosecha24papasGridView_PageIndexChanging(object sender, EventArgs e)
        {
            try
            {
                GridViewRow pagerRow = gdv24papas.BottomPagerRow;
                DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");//error
                Label pageLabel = (Label)pagerRow.Cells[0].FindControl("CurrentPageLabel");
                if (pageList != null)
                {
                    for (int i = 0; i < gdv24papas.PageCount; i++)
                    {
                        int pageNumber = i + 1;
                        ListItem item = new ListItem(pageNumber.ToString());
                        if (i == gdv24papas.PageIndex)
                        {
                            item.Selected = true;
                        }
                        pageList.Items.Add(item);
                    }
                }
                if (pageLabel != null)
                {
                    int currentPage = gdv24papas.PageIndex + 1;
                    pageLabel.Text = "Ver " + currentPage.ToString() + " de " + gdv24papas.PageCount.ToString();
                }
                this.gdv24papas.Controls[0].Controls[this.gdv24papas.Controls[0].Controls.Count - 1].Visible = true;
                PoblarGrilla();
            }
            catch (Exception ex)
            {
            }
        }
    }
}