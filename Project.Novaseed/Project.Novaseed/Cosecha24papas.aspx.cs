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

        protected void Cosecha24papasGridView_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            CatalogCosecha cc = new CatalogCosecha();
            string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv24papas.Rows[e.RowIndex].Cells[2].Text);
            int valor = cc.DeleteCosecha24papas(Int32.Parse(id_cosecha));
            if (valor == 0)
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('Error!\n¡No se pudo eliminar la variedad!')</script>");

            PoblarGrilla();
        }        

        protected void btn24papasCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuGeneracion.aspx");
        }

        protected void btn24papasGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = this.gdv24papas.SelectedIndex;

                string id_cosecha = HttpUtility.HtmlDecode((string)this.gdv24papas.Rows[selected].Cells[2].Text);
                int id_cosechaEntero = Int32.Parse(id_cosecha);
                string cantidad_papas = this.txt24papasCantidadPapas.Text;
                string posicion_cosecha = this.txt24papasPosicion.Text.Replace(",", ".");
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
                string tuberculos_planta = this.txt24papasTuberculosPlanta.Text.Replace(",", ".");
                string toneladas_hectarea = this.txt24papasToneladasHectarea.Text.Replace(",", ".");
                string porcentaje_relacion = this.txt24papasRelacionStandard.Text.Replace("%", "");
                string consumo = this.txt24papasConsumo.Text;
                string semillon = this.txt24papasSemillon.Text;
                string semilla = this.txt24papasSemilla.Text;
                string semillita = this.txt24papasSemillita.Text;
                string bajo_calibre = this.txt24papasBajoCalibre.Text;
                string numero_tallos = this.txt24papasNumeroTallos.Text;

                string id_sensibildiad_quimica = this.ddl24papasSensibilidadQuimica.SelectedValue;
                string id_facilidad_muerte = this.ddl24papasFacilidadMuerte.SelectedValue;
                string dormancia = this.txt24papasDormancia.Text;
                string tolerancia_sequia = this.txt24papasToleranciaSequia.Text;
                string tolerancia_calor = this.txt24papasToleranciaCalor.Text;
                string tolerancia_sal = this.txt24papasToleranciaSal.Text;
                string daño_cosecha = this.txt24papasDañoCosecha.Text;
                string tizon_hoja = this.txt24papasTizonHoja.Text;
                string putrefaccion_suave = this.txt24papasPutrefaccionSuave.Text;
                string putrefaccion_rosa = this.txt24papasPutrefaccionRosa.Text;
                string silver_scurf = this.txt24papasSilverScurf.Text;
                string blackleg = this.txt24papasBlackleg.Text;

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

                cc.DeleteCosechaColorCarne(id_cosechaEntero);
                List<int> selectedCarne = this.lst24papasColorCarne.GetSelectedIndices().ToList();
                for (int i = 0; i < selectedCarne.Count; i++)
                {
                    string id_color_carne = this.lst24papasColorCarne.Items[selectedCarne[i]].Value;
                    cc.UpdateCosechaColorCarne(Int32.Parse(id_color_carne), id_cosechaEntero);
                }

                cc.DeleteCosechaColorPiel(id_cosechaEntero);
                List<int> selectedPiel = this.lst24papasColorPiel.GetSelectedIndices().ToList();
                for (int i = 0; i < selectedPiel.Count; i++)
                {
                    string id_color_piel = this.lst24papasColorPiel.Items[selectedPiel[i]].Value;
                    cc.UpdateCosechaColorPiel(Int32.Parse(id_color_piel), id_cosechaEntero);
                }

                cc.DeleteCosechaEnfermedades(id_cosechaEntero);
                foreach (GridViewRow row in gdv24papasEnfermedades.Rows)
                {
                    string nombre_enfermedad = HttpUtility.HtmlDecode((string)this.gdv24papasEnfermedades.Rows[row.RowIndex].Cells[0].Text);
                    string resistencia_variedad = HttpUtility.HtmlDecode((string)this.gdv24papasEnfermedades.Rows[row.RowIndex].Cells[1].Text);
                    int valorEnfermedad = cc.AddCosechaEnfermedades(nombre_enfermedad, id_cosechaEntero, resistencia_variedad);
                    if (valorEnfermedad == 0)
                        Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Error al ingresar enfermedad!')</script>");
                }

                int valor = cc.UpdateCosecha24papas(cosecha);
                if (valor == 0)
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Debe seleccionar una ciudad o ya hay una variedad asignada en esa posición!')</script>");
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('" + ex.ToString() + "')</script>");
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
                    listEnfermedad.Add(this.ddl24papasEnfermedad.SelectedItem.ToString());
                    listResistencia.Add(this.ddl24papasResistencia.SelectedItem.ToString());

                    for (int i = 0; i < listEnfermedad.Count && i < listResistencia.Count; i++)
                    {
                        table.Rows.Add(listEnfermedad[i], listResistencia[i]);
                    }
                    this.gdv24papasEnfermedades.DataSource = table;
                }
                this.gdv24papasEnfermedades.DataBind();
            }
            else
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡Debe seleccionar una enfermedad!')</script>");
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
    }
}