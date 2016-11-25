using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;

namespace Project.Novaseed
{
    public partial class UPOV : System.Web.UI.Page
    {
        private string id_upov;

        protected void Page_Load(object sender, EventArgs e)
        {
            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["id"] != null)
                id_upov = Request.QueryString["id"];
            else
                id_upov = "0";
            
            List<Project.BusinessRules.UPOV> lstUPOV = new List<Project.BusinessRules.UPOV>();
            CatalogUPOV cu = new CatalogUPOV();
            lstUPOV = cu.GetUPOV(Int32.Parse(id_upov));

            if (!Page.IsPostBack)
            {              
                //NombreVariedad
                this.txtUPOVNombreVariedad.Text = lstUPOV[0].Nombre_variedad_upov;
                //NombreMadre
                this.txtUPOVMadre.Text = lstUPOV[0].Nombre_madre;
                //NombrePadre
                this.txtUPOVPadre.Text = lstUPOV[0].Nombre_padre;

                //UPOVBotonFloralPigmentacion
                List<UPOVBotonFloralPigmentacion> lstUPOVBotonFloralPigmentacion = new List<UPOVBotonFloralPigmentacion>();
                lstUPOVBotonFloralPigmentacion = cu.GetUPOVBotonFloralPigmentacion();

                for (int i = 0; i < lstUPOVBotonFloralPigmentacion.Count; i++)
                {
                    string valor = lstUPOVBotonFloralPigmentacion[i].Id_boton_floral_pigmentacion.ToString();
                    this.rdbUPOVBotonFloralPigmentacion.Items.Add(new ListItem(lstUPOVBotonFloralPigmentacion[i].Nombre_boton_floral_pigmentacion, valor));
                }
                this.rdbUPOVBotonFloralPigmentacion.SelectedValue = lstUPOV[0].Id_boton_floral_pigmentacion.ToString();

                //UPOVBroteForma
                List<UPOVBroteForma> lstUPOVBroteForma = new List<UPOVBroteForma>();
                lstUPOVBroteForma = cu.GetUPOVBroteForma();

                for (int i = 0; i < lstUPOVBroteForma.Count; i++)
                {
                    string valor = lstUPOVBroteForma[i].Id_brote_forma.ToString();
                    this.rdbUPOVBroteForma.Items.Add(new ListItem(lstUPOVBroteForma[i].Nombre_brote_forma, valor));
                }
                this.rdbUPOVBroteForma.SelectedValue = lstUPOV[0].Id_brote_forma.ToString();

                //UPOVBroteLongitudRamificacionesLaterales
                List<UPOVBroteLongitudRamificacionesLaterales> lstUPOVBroteLongitudRamificacionesLaterales = new List<UPOVBroteLongitudRamificacionesLaterales>();
                lstUPOVBroteLongitudRamificacionesLaterales = cu.GetUPOVBroteLongitudRamificacionesLaterales();

                for (int i = 0; i < lstUPOVBroteLongitudRamificacionesLaterales.Count; i++)
                {
                    string valor = lstUPOVBroteLongitudRamificacionesLaterales[i].Id_brote_longitud_ramificaciones_laterales.ToString();
                    this.rdbUPOVBroteLongitudRamificacionesLaterales.Items.Add(new ListItem(lstUPOVBroteLongitudRamificacionesLaterales[i].Nombre_brote_longitud_ramificaciones_laterales, valor));
                }
                this.rdbUPOVBroteLongitudRamificacionesLaterales.SelectedValue = lstUPOV[0].Id_brote_longitud_ramificaciones_laterales.ToString();

                //UPOVBrotePigmentacionBase
                List<UPOVBrotePigmentacionBase> lstUPOVBrotePigmentacionBase = new List<UPOVBrotePigmentacionBase>();
                lstUPOVBrotePigmentacionBase = cu.GetUPOVBrotePigmentacionBase();

                for (int i = 0; i < lstUPOVBrotePigmentacionBase.Count; i++)
                {
                    string valor = lstUPOVBrotePigmentacionBase[i].Id_brote_pigmentacion_base.ToString();
                    this.rdbUPOVBrotePigmentacionBase.Items.Add(new ListItem(lstUPOVBrotePigmentacionBase[i].Nombre_brote_pigmentacion_base, valor));
                }
                this.rdbUPOVBrotePigmentacionBase.SelectedValue = lstUPOV[0].Id_brote_pigmentacion_base.ToString();

                //UPOVBrotePigmentacionExtremo
                List<UPOVBrotePigmentacionExtremo> lstUPOVBrotePigmentacionExtremo = new List<UPOVBrotePigmentacionExtremo>();
                lstUPOVBrotePigmentacionExtremo = cu.GetUPOVBrotePigmentacionExtremo();

                for (int i = 0; i < lstUPOVBrotePigmentacionExtremo.Count; i++)
                {
                    string valor = lstUPOVBrotePigmentacionExtremo[i].Id_brote_pigmentacion_extremo.ToString();
                    this.rdbUPOVBrotePigmentacionExtremo.Items.Add(new ListItem(lstUPOVBrotePigmentacionExtremo[i].Nombre_brote_pigmentacion_extremo, valor));
                }
                this.rdbUPOVBrotePigmentacionExtremo.SelectedValue = lstUPOV[0].Id_brote_pigmentacion_extremo.ToString();

                //UPOVBrotePorteExtremo
                List<UPOVBrotePorteExtremo> lstUPOVBrotePorteExtremo = new List<UPOVBrotePorteExtremo>();
                lstUPOVBrotePorteExtremo = cu.GetUPOVBrotePorteExtremo();

                for (int i = 0; i < lstUPOVBrotePorteExtremo.Count; i++)
                {
                    string valor = lstUPOVBrotePorteExtremo[i].Id_brote_porte_extremo.ToString();
                    this.rdbUPOVBrotePorteExtremo.Items.Add(new ListItem(lstUPOVBrotePorteExtremo[i].Nombre_brote_porte_extremo, valor));
                }
                this.rdbUPOVBrotePorteExtremo.SelectedValue = lstUPOV[0].Id_brote_porte_extremo.ToString();

                //UPOVBroteProporcionAzul
                List<UPOVBroteProporcionAzul> lstUPOVBroteProporcionAzul = new List<UPOVBroteProporcionAzul>();
                lstUPOVBroteProporcionAzul = cu.GetUPOVBroteProporcionAzul();

                for (int i = 0; i < lstUPOVBroteProporcionAzul.Count; i++)
                {
                    string valor = lstUPOVBroteProporcionAzul[i].Id_brote_proporcion_azul.ToString();
                    this.rdbUPOVBroteProporcionAzul.Items.Add(new ListItem(lstUPOVBroteProporcionAzul[i].Nombre_brote_proporcion_azul, valor));
                }
                this.rdbUPOVBroteProporcionAzul.SelectedValue = lstUPOV[0].Id_brote_proporcion_azul.ToString();

                //UPOVBrotePubescenciaBase
                List<UPOVBrotePubescenciaBase> lstUPOVBrotePubescenciaBase = new List<UPOVBrotePubescenciaBase>();
                lstUPOVBrotePubescenciaBase = cu.GetUPOVBrotePubescenciaBase();

                for (int i = 0; i < lstUPOVBrotePubescenciaBase.Count; i++)
                {
                    string valor = lstUPOVBrotePubescenciaBase[i].Id_brote_pubescencia_base.ToString();
                    this.rdbUPOVBrotePubescenciaBase.Items.Add(new ListItem(lstUPOVBrotePubescenciaBase[i].Nombre_brote_pubescencia_base, valor));
                }
                this.rdbUPOVBrotePubescenciaBase.SelectedValue = lstUPOV[0].Id_brote_pubescencia_base.ToString();

                //UPOVBrotePubescenciaExtremo
                List<UPOVBrotePubescenciaExtremo> lstUPOVBrotePubescenciaExtremo = new List<UPOVBrotePubescenciaExtremo>();
                lstUPOVBrotePubescenciaExtremo = cu.GetUPOVBrotePubescenciaExtremo();

                for (int i = 0; i < lstUPOVBrotePubescenciaExtremo.Count; i++)
                {
                    string valor = lstUPOVBrotePubescenciaExtremo[i].Id_brote_pubescencia_extremo.ToString();
                    this.rdbUPOVBrotePubescenciaExtremo.Items.Add(new ListItem(lstUPOVBrotePubescenciaExtremo[i].Nombre_brote_pubescencia_extremo, valor));
                }
                this.rdbUPOVBrotePubescenciaExtremo.SelectedValue = lstUPOV[0].Id_brote_pubescencia_extremo.ToString();

                //UPOVBroteRadiculas
                List<UPOVBroteRadiculas> lstUPOVBroteRadiculas = new List<UPOVBroteRadiculas>();
                lstUPOVBroteRadiculas = cu.GetUPOVBroteRadiculas();

                for (int i = 0; i < lstUPOVBroteRadiculas.Count; i++)
                {
                    string valor = lstUPOVBroteRadiculas[i].Id_brote_radiculas.ToString();
                    this.rdbUPOVBroteRadiculas.Items.Add(new ListItem(lstUPOVBroteRadiculas[i].Nombre_brote_radiculas, valor));
                }
                this.rdbUPOVBroteRadiculas.SelectedValue = lstUPOV[0].Id_brote_radiculas.ToString();

                //UPOVBroteTamaño
                List<UPOVBroteTamaño> lstUPOVBroteTamaño = new List<UPOVBroteTamaño>();
                lstUPOVBroteTamaño = cu.GetUPOVBroteTamaño();

                for (int i = 0; i < lstUPOVBroteTamaño.Count; i++)
                {
                    string valor = lstUPOVBroteTamaño[i].Id_brote_tamaño.ToString();
                    this.rdbUPOVBroteTamaño.Items.Add(new ListItem(lstUPOVBroteTamaño[i].Nombre_brote_tamaño, valor));
                }
                this.rdbUPOVBroteTamaño.SelectedValue = lstUPOV[0].Id_brote_tamano.ToString();

                //UPOVBroteTamañoExtremo
                List<UPOVBroteTamañoExtremo> lstUPOVBroteTamañoExtremo = new List<UPOVBroteTamañoExtremo>();
                lstUPOVBroteTamañoExtremo = cu.GetUPOVBroteTamañoExtremo();

                for (int i = 0; i < lstUPOVBroteTamañoExtremo.Count; i++)
                {
                    string valor = lstUPOVBroteTamañoExtremo[i].Id_brote_tamaño_extremo.ToString();
                    this.rdbUPOVBroteTamañoExtremo.Items.Add(new ListItem(lstUPOVBroteTamañoExtremo[i].Nombre_brote_tamaño_extremo, valor));
                }
                this.rdbUPOVBroteTamañoExtremo.SelectedValue = lstUPOV[0].Id_brote_tamano_extremo.ToString();

                //UPOVCorolaFlorExtensionPigmentacionCaraInterna
                List<UPOVCorolaFlorExtensionPigmentacionCaraInterna> lstUPOVCorolaFlorExtensionPigmentacionCaraInterna = new List<UPOVCorolaFlorExtensionPigmentacionCaraInterna>();
                lstUPOVCorolaFlorExtensionPigmentacionCaraInterna = cu.GetUPOVCorolaFlorExtensionPigmentacionCaraInterna();

                for (int i = 0; i < lstUPOVCorolaFlorExtensionPigmentacionCaraInterna.Count; i++)
                {
                    string valor = lstUPOVCorolaFlorExtensionPigmentacionCaraInterna[i].Id_corola_flor_extension_pigmentacion_cara_interna.ToString();
                    this.rdbUPOVCorolaFlorExtensionPigmentacionCaraInterna.Items.Add(new ListItem(lstUPOVCorolaFlorExtensionPigmentacionCaraInterna[i].Nombre_corola_flor_extension_pigmentacion_cara_interna, valor));
                }
                this.rdbUPOVCorolaFlorExtensionPigmentacionCaraInterna.SelectedValue = lstUPOV[0].Id_corola_flor_extension_pigmentacion_cara_interna.ToString();

                //UPOVCorolaFlorIntensidadPigmentacionCaraInterna
                List<UPOVCorolaFlorIntensidadPigmentacionCaraInterna> lstUPOVCorolaFlorIntensidadPigmentacionCaraInterna = new List<UPOVCorolaFlorIntensidadPigmentacionCaraInterna>();
                lstUPOVCorolaFlorIntensidadPigmentacionCaraInterna = cu.GetUPOVCorolaFlorIntensidadPigmentacionCaraInterna();

                for (int i = 0; i < lstUPOVCorolaFlorIntensidadPigmentacionCaraInterna.Count; i++)
                {
                    string valor = lstUPOVCorolaFlorIntensidadPigmentacionCaraInterna[i].Id_corola_flor_intensidad_pigmentacion_cara_interna.ToString();
                    this.rdbUPOVCorolaFlorIntensidadPigmentacionCaraInterna.Items.Add(new ListItem(lstUPOVCorolaFlorIntensidadPigmentacionCaraInterna[i].Nombre_corola_flor_intensidad_pigmentacion_cara_interna, valor));
                }
                this.rdbUPOVCorolaFlorIntensidadPigmentacionCaraInterna.SelectedValue = lstUPOV[0].Id_corola_flor_intensidad_pigmentacion_cara_interna.ToString();

                //UPOVCorolaFlorProporcionAzulPigmentacionCaraInterna
                List<UPOVCorolaFlorProporcionAzulPigmentacionCaraInterna> lstUPOVCorolaFlorProporcionAzulPigmentacionCaraInterna = new List<UPOVCorolaFlorProporcionAzulPigmentacionCaraInterna>();
                lstUPOVCorolaFlorProporcionAzulPigmentacionCaraInterna = cu.GetUPOVCorolaFlorProporcionAzulPigmentacionCaraInterna();

                for (int i = 0; i < lstUPOVCorolaFlorProporcionAzulPigmentacionCaraInterna.Count; i++)
                {
                    string valor = lstUPOVCorolaFlorProporcionAzulPigmentacionCaraInterna[i].Id_corola_flor_proporcion_azul_pigmentacion_cara_interna.ToString();
                    this.rdbUPOVCorolaFlorProporcionAzulPigmentacionCaraInterna.Items.Add(new ListItem(lstUPOVCorolaFlorProporcionAzulPigmentacionCaraInterna[i].Nombre_corola_flor_proporcion_azul_pigmentacion_cara_interna, valor));
                }
                this.rdbUPOVCorolaFlorProporcionAzulPigmentacionCaraInterna.SelectedValue = lstUPOV[0].Id_corola_flor_proporcion_azul_pigmentacion_cara_interna.ToString();

                //UPOVCorolaFlorTamaño
                List<UPOVCorolaFlorTamaño> lstUPOVCorolaFlorTamaño = new List<UPOVCorolaFlorTamaño>();
                lstUPOVCorolaFlorTamaño = cu.GetUPOVCorolaFlorTamaño();

                for (int i = 0; i < lstUPOVCorolaFlorTamaño.Count; i++)
                {
                    string valor = lstUPOVCorolaFlorTamaño[i].Id_corola_flor_tamaño.ToString();
                    this.rdbUPOVCorolaFlorTamaño.Items.Add(new ListItem(lstUPOVCorolaFlorTamaño[i].Nombre_corola_flor_tamaño, valor));
                }
                this.rdbUPOVCorolaFlorTamaño.SelectedValue = lstUPOV[0].Id_corola_flor_tamano.ToString();

                //UPOVFolioloBrilloHaz
                List<UPOVFolioloBrilloHaz> lstUPOVFolioloBrilloHaz = new List<UPOVFolioloBrilloHaz>();
                lstUPOVFolioloBrilloHaz = cu.GetUPOVFolioloBrilloHaz();

                for (int i = 0; i < lstUPOVFolioloBrilloHaz.Count; i++)
                {
                    string valor = lstUPOVFolioloBrilloHaz[i].Id_foliolo_brillo_haz.ToString();
                    this.rdbUPOVFolioloBrilloHaz.Items.Add(new ListItem(lstUPOVFolioloBrilloHaz[i].Nombre_foliolo_brillo_haz, valor));
                }
                this.rdbUPOVFolioloBrilloHaz.SelectedValue = lstUPOV[0].Id_foliolo_brillo_haz.ToString();

                //UPOVFolioloOndulacionBorde
                List<UPOVFolioloOndulacionBorde> lstUPOVFolioloOndulacionBorde = new List<UPOVFolioloOndulacionBorde>();
                lstUPOVFolioloOndulacionBorde = cu.GetUPOVFolioloOndulacionBorde();

                for (int i = 0; i < lstUPOVFolioloOndulacionBorde.Count; i++)
                {
                    string valor = lstUPOVFolioloOndulacionBorde[i].Id_foliolo_ondulacion_borde.ToString();
                    this.rdbUPOVFolioloOndulacionBorde.Items.Add(new ListItem(lstUPOVFolioloOndulacionBorde[i].Nombre_foliolo_ondulacion_borde, valor));
                }
                this.rdbUPOVFolioloOndulacionBorde.SelectedValue = lstUPOV[0].Id_foliolo_ondulacion_borde.ToString();

                //UPOVFolioloProfundidadNervios
                List<UPOVFolioloProfundidadNervios> lstUPOVFolioloProfundidadNervios = new List<UPOVFolioloProfundidadNervios>();
                lstUPOVFolioloProfundidadNervios = cu.GetUPOVFolioloProfundidadNervios();

                for (int i = 0; i < lstUPOVFolioloProfundidadNervios.Count; i++)
                {
                    string valor = lstUPOVFolioloProfundidadNervios[i].Id_foliolo_profundidad_nervios.ToString();
                    this.rdbUPOVFolioloProfundidadNervios.Items.Add(new ListItem(lstUPOVFolioloProfundidadNervios[i].Nombre_foliolo_profundidad_nervios, valor));
                }
                this.rdbUPOVFolioloProfundidadNervios.SelectedValue = lstUPOV[0].Id_foliolo_profundidad_nervios.ToString();

                //UPOVFolioloPubescenciaHazRosetaApical
                List<UPOVFolioloPubescenciaHazRosetaApical> lstUPOVFolioloPubescenciaHazRosetaApical = new List<UPOVFolioloPubescenciaHazRosetaApical>();
                lstUPOVFolioloPubescenciaHazRosetaApical = cu.GetUPOVFolioloPubescenciaHazRosetaApical();

                for (int i = 0; i < lstUPOVFolioloPubescenciaHazRosetaApical.Count; i++)
                {
                    string valor = lstUPOVFolioloPubescenciaHazRosetaApical[i].Id_foliolo_pubescencia_haz_roseta_apical.ToString();
                    this.rdbUPOVFolioloPubescenciaHazRosetaApical.Items.Add(new ListItem(lstUPOVFolioloPubescenciaHazRosetaApical[i].Nombre_foliolo_pubescencia_haz_roseta_apical, valor));
                }
                this.rdbUPOVFolioloPubescenciaHazRosetaApical.SelectedValue = lstUPOV[0].Id_foliolo_pubescencia_haz_roseta_apical.ToString();

                //UPOVFoliolosTerminalesCoalescencia
                List<UPOVFoliolosTerminalesCoalescencia> lstUPOVFoliolosTerminalesCoalescencia = new List<UPOVFoliolosTerminalesCoalescencia>();
                lstUPOVFoliolosTerminalesCoalescencia = cu.GetUPOVFoliolosTerminalesCoalescencia();

                for (int i = 0; i < lstUPOVFoliolosTerminalesCoalescencia.Count; i++)
                {
                    string valor = lstUPOVFoliolosTerminalesCoalescencia[i].Id_foliolos_terminales_coalescencia.ToString();
                    this.rdbUPOVFoliolosTerminalesCoalescencia.Items.Add(new ListItem(lstUPOVFoliolosTerminalesCoalescencia[i].Nombre_foliolos_terminales_coalescencia, valor));
                }
                this.rdbUPOVFoliolosTerminalesCoalescencia.SelectedValue = lstUPOV[0].Id_foliolos_terminales_coalescencia.ToString();

                //UPOVHojaApertura
                List<UPOVHojaApertura> lstUPOVHojaApertura = new List<UPOVHojaApertura>();
                lstUPOVHojaApertura = cu.GetUPOVHojaApertura();

                for (int i = 0; i < lstUPOVHojaApertura.Count; i++)
                {
                    string valor = lstUPOVHojaApertura[i].Id_hoja_apertura.ToString();
                    this.rdbUPOVHojaApertura.Items.Add(new ListItem(lstUPOVHojaApertura[i].Nombre_hoja_apertura, valor));
                }
                this.rdbUPOVHojaApertura.SelectedValue = lstUPOV[0].Id_hoja_apertura.ToString();

                //UPOVHojaColorVerde
                List<UPOVHojaColorVerde> lstUPOVHojaColorVerde = new List<UPOVHojaColorVerde>();
                lstUPOVHojaColorVerde = cu.GetUPOVHojaColorVerde();

                for (int i = 0; i < lstUPOVHojaColorVerde.Count; i++)
                {
                    string valor = lstUPOVHojaColorVerde[i].Id_hoja_color_verde.ToString();
                    this.rdbUPOVHojaColorVerde.Items.Add(new ListItem(lstUPOVHojaColorVerde[i].Nombre_hoja_color_verde, valor));
                }
                this.rdbUPOVHojaColorVerde.SelectedValue = lstUPOV[0].Id_hoja_color_verde.ToString();

                //UPOVHojaFoliolosSecundarios
                List<UPOVHojaFoliolosSecundarios> lstUPOVHojaFoliolosSecundarios = new List<UPOVHojaFoliolosSecundarios>();
                lstUPOVHojaFoliolosSecundarios = cu.GetUPOVHojaFoliolosSecundarios();

                for (int i = 0; i < lstUPOVHojaFoliolosSecundarios.Count; i++)
                {
                    string valor = lstUPOVHojaFoliolosSecundarios[i].Id_hoja_foliolos_secundarios.ToString();
                    this.rdbUPOVHojaFoliolosSecundarios.Items.Add(new ListItem(lstUPOVHojaFoliolosSecundarios[i].Nombre_hoja_foliolos_secundarios, valor));
                }
                this.rdbUPOVHojaFoliolosSecundarios.SelectedValue = lstUPOV[0].Id_hoja_foliolos_secundarios.ToString();

                //UPOVHojaPigmentacionNervioCentral
                List<UPOVHojaPigmentacionNervioCentral> lstUPOVHojaPigmentacionNervioCentral = new List<UPOVHojaPigmentacionNervioCentral>();
                lstUPOVHojaPigmentacionNervioCentral = cu.GetUPOVHojaPigmentacionNervioCentral();

                for (int i = 0; i < lstUPOVHojaPigmentacionNervioCentral.Count; i++)
                {
                    string valor = lstUPOVHojaPigmentacionNervioCentral[i].Id_hoja_pigmentacion_nervio_central.ToString();
                    this.rdbUPOVHojaPigmentacionNervioCentral.Items.Add(new ListItem(lstUPOVHojaPigmentacionNervioCentral[i].Nombre_hoja_pigmentacion_nervio_central, valor));
                }
                this.rdbUPOVHojaPigmentacionNervioCentral.SelectedValue = lstUPOV[0].Id_hoja_pigmentacion_nervio_central.ToString();

                //UPOVHojaTamañoContorno
                List<UPOVHojaTamañoContorno> lstUPOVHojaTamañoContorno = new List<UPOVHojaTamañoContorno>();
                lstUPOVHojaTamañoContorno = cu.GetUPOVHojaTamañoContorno();

                for (int i = 0; i < lstUPOVHojaTamañoContorno.Count; i++)
                {
                    string valor = lstUPOVHojaTamañoContorno[i].Id_hoja_tamaño_contorno.ToString();
                    this.rdbUPOVHojaTamañoContorno.Items.Add(new ListItem(lstUPOVHojaTamañoContorno[i].Nombre_hoja_tamaño_contorno, valor));
                }
                this.rdbUPOVHojaTamañoContorno.SelectedValue = lstUPOV[0].Id_hoja_tamano_contorno.ToString();

                //UPOVInflorescenciaPigmentacionPendunculo
                List<UPOVInflorescenciaPigmentacionPendunculo> lstUPOVInflorescenciaPigmentacionPendunculo = new List<UPOVInflorescenciaPigmentacionPendunculo>();
                lstUPOVInflorescenciaPigmentacionPendunculo = cu.GetUPOVInflorescenciaPigmentacionPendunculo();

                for (int i = 0; i < lstUPOVInflorescenciaPigmentacionPendunculo.Count; i++)
                {
                    string valor = lstUPOVInflorescenciaPigmentacionPendunculo[i].Id_inflorescencia_pigmentacion_pendunculo.ToString();
                    this.rdbUPOVInflorescenciaPigmentacionPendunculo.Items.Add(new ListItem(lstUPOVInflorescenciaPigmentacionPendunculo[i].Nombre_inflorescencia_pigmentacion_pendunculo, valor));
                }
                this.rdbUPOVInflorescenciaPigmentacionPendunculo.SelectedValue = lstUPOV[0].Id_inflorescencia_pigmentacion_pendunculo.ToString();

                //UPOVInflorescenciaTamaño
                List<UPOVInflorescenciaTamaño> lstUPOVInflorescenciaTamaño = new List<UPOVInflorescenciaTamaño>();
                lstUPOVInflorescenciaTamaño = cu.GetUPOVInflorescenciaTamaño();

                for (int i = 0; i < lstUPOVInflorescenciaTamaño.Count; i++)
                {
                    string valor = lstUPOVInflorescenciaTamaño[i].Id_inflorescencia_tamaño.ToString();
                    this.rdbUPOVInflorescenciaTamaño.Items.Add(new ListItem(lstUPOVInflorescenciaTamaño[i].Nombre_inflorescencia_tamaño, valor));
                }
                this.rdbUPOVInflorescenciaTamaño.SelectedValue = lstUPOV[0].Id_inflorescencia_tamano.ToString();

                //UPOVPlantaAltura
                List<UPOVPlantaAltura> lstUPOVPlantaAltura = new List<UPOVPlantaAltura>();
                lstUPOVPlantaAltura = cu.GetUPOVPlantaAltura();

                for (int i = 0; i < lstUPOVPlantaAltura.Count; i++)
                {
                    string valor = lstUPOVPlantaAltura[i].Id_planta_altura.ToString();
                    this.rdbUPOVPlantaAltura.Items.Add(new ListItem(lstUPOVPlantaAltura[i].Nombre_planta_altura, valor));
                }
                this.rdbUPOVPlantaAltura.SelectedValue = lstUPOV[0].Id_planta_altura.ToString();

                //UPOVPlantaEpocaMadurez
                List<UPOVPlantaEpocaMadurez> lstUPOVPlantaEpocaMadurez = new List<UPOVPlantaEpocaMadurez>();
                lstUPOVPlantaEpocaMadurez = cu.GetUPOVPlantaEpocaMadurez();

                for (int i = 0; i < lstUPOVPlantaEpocaMadurez.Count; i++)
                {
                    string valor = lstUPOVPlantaEpocaMadurez[i].Id_planta_epoca_madurez.ToString();
                    this.rdbUPOVPlantaEpocaMadurez.Items.Add(new ListItem(lstUPOVPlantaEpocaMadurez[i].Nombre_planta_epoca_madurez, valor));
                }
                this.rdbUPOVPlantaEpocaMadurez.SelectedValue = lstUPOV[0].Id_planta_epoca_madurez.ToString();

                //UPOVPlantaEstructuraFollaje
                List<UPOVPlantaEstructuraFollaje> lstUPOVPlantaEstructuraFollaje = new List<UPOVPlantaEstructuraFollaje>();
                lstUPOVPlantaEstructuraFollaje = cu.GetUPOVPlantaEstructuraFollaje();

                for (int i = 0; i < lstUPOVPlantaEstructuraFollaje.Count; i++)
                {
                    string valor = lstUPOVPlantaEstructuraFollaje[i].Id_planta_estructura_follaje.ToString();
                    this.rdbUPOVPlantaEstructuraFollaje.Items.Add(new ListItem(lstUPOVPlantaEstructuraFollaje[i].Nombre_planta_estructura_follaje, valor));
                }
                this.rdbUPOVPlantaEstructuraFollaje.SelectedValue = lstUPOV[0].Id_planta_estructura_follaje.ToString();

                //UPOVPlantaFrecuenciaFlores
                List<UPOVPlantaFrecuenciaFlores> lstUPOVPlantaFrecuenciaFlores = new List<UPOVPlantaFrecuenciaFlores>();
                lstUPOVPlantaFrecuenciaFlores = cu.GetUPOVPlantaFrecuenciaFlores();

                for (int i = 0; i < lstUPOVPlantaFrecuenciaFlores.Count; i++)
                {
                    string valor = lstUPOVPlantaFrecuenciaFlores[i].Id_planta_frecuencia_flores.ToString();
                    this.rdbUPOVPlantaFrecuenciaFlores.Items.Add(new ListItem(lstUPOVPlantaFrecuenciaFlores[i].Nombre_planta_frecuencia_flores, valor));
                }
                this.rdbUPOVPlantaFrecuenciaFlores.SelectedValue = lstUPOV[0].Id_planta_frecuencia_flores.ToString();

                //UPOVPlantaPorte
                List<UPOVPlantaPorte> lstUPOVPlantaPorte = new List<UPOVPlantaPorte>();
                lstUPOVPlantaPorte = cu.GetUPOVPlantaPorte();

                for (int i = 0; i < lstUPOVPlantaPorte.Count; i++)
                {
                    string valor = lstUPOVPlantaPorte[i].Id_planta_porte.ToString();
                    this.rdbUPOVPlantaPorte.Items.Add(new ListItem(lstUPOVPlantaPorte[i].Nombre_planta_porte, valor));
                }
                this.rdbUPOVPlantaPorte.SelectedValue = lstUPOV[0].Id_planta_porte.ToString();

                //UPOVSegundoParFoliolosAnchuraLongitud
                List<UPOVSegundoParFoliolosAnchuraLongitud> lstUPOVSegundoParFoliolosAnchuraLongitud = new List<UPOVSegundoParFoliolosAnchuraLongitud>();
                lstUPOVSegundoParFoliolosAnchuraLongitud = cu.GetUPOVSegundoParFoliolosAnchuraLongitud();

                for (int i = 0; i < lstUPOVSegundoParFoliolosAnchuraLongitud.Count; i++)
                {
                    string valor = lstUPOVSegundoParFoliolosAnchuraLongitud[i].Id_segundo_par_foliolos_anchura_longitud.ToString();
                    this.rdbUPOVSegundoParFoliolosAnchuraLongitud.Items.Add(new ListItem(lstUPOVSegundoParFoliolosAnchuraLongitud[i].Nombre_segundo_par_foliolos_anchura_longitud, valor));
                }
                this.rdbUPOVSegundoParFoliolosAnchuraLongitud.SelectedValue = lstUPOV[0].Id_segundo_par_foliolos_anchura_longitud.ToString();

                //UPOVSegundoParFoliolosTamaño
                List<UPOVSegundoParFoliolosTamaño> lstUPOVSegundoParFoliolosTamaño = new List<UPOVSegundoParFoliolosTamaño>();
                lstUPOVSegundoParFoliolosTamaño = cu.GetUPOVSegundoParFoliolosTamaño();

                for (int i = 0; i < lstUPOVSegundoParFoliolosTamaño.Count; i++)
                {
                    string valor = lstUPOVSegundoParFoliolosTamaño[i].Id_segundo_par_foliolos_tamaño.ToString();
                    this.rdbUPOVSegundoParFoliolosTamaño.Items.Add(new ListItem(lstUPOVSegundoParFoliolosTamaño[i].Nombre_segundo_par_foliolos_tamaño, valor));
                }
                this.rdbUPOVSegundoParFoliolosTamaño.SelectedValue = lstUPOV[0].Id_segundo_par_foliolos_tamano.ToString();

                //UPOVTalloPigmentacion
                List<UPOVTalloPigmentacion> lstUPOVTalloPigmentacion = new List<UPOVTalloPigmentacion>();
                lstUPOVTalloPigmentacion = cu.GetUPOVTalloPigmentacion();

                for (int i = 0; i < lstUPOVTalloPigmentacion.Count; i++)
                {
                    string valor = lstUPOVTalloPigmentacion[i].Id_tallo_pigmentacion.ToString();
                    this.rdbUPOVTalloPigmentacion.Items.Add(new ListItem(lstUPOVTalloPigmentacion[i].Nombre_tallo_pigmentacion, valor));
                }
                this.rdbUPOVTalloPigmentacion.SelectedValue = lstUPOV[0].Id_tallo_pigmentacion.ToString();

                //UPOVTuberculoColorBaseOjo
                List<UPOVTuberculoColorBaseOjo> lstUPOVTuberculoColorBaseOjo = new List<UPOVTuberculoColorBaseOjo>();
                lstUPOVTuberculoColorBaseOjo = cu.GetUPOVTuberculoColorBaseOjo();

                for (int i = 0; i < lstUPOVTuberculoColorBaseOjo.Count; i++)
                {
                    string valor = lstUPOVTuberculoColorBaseOjo[i].Id_tuberculo_color_base_ojo.ToString();
                    this.rdbUPOVTuberculoColorBaseOjo.Items.Add(new ListItem(lstUPOVTuberculoColorBaseOjo[i].Nombre_tuberculo_color_base_ojo, valor));
                }
                this.rdbUPOVTuberculoColorBaseOjo.SelectedValue = lstUPOV[0].Id_tuberculo_color_base_ojo.ToString();

                //UPOVTuberculoPigmentacionPielReaccionLuz
                List<UPOVTuberculoPigmentacionPielReaccionLuz> lstUPOVTuberculoPigmentacionPielReaccionLuz = new List<UPOVTuberculoPigmentacionPielReaccionLuz>();
                lstUPOVTuberculoPigmentacionPielReaccionLuz = cu.GetUPOVTuberculoPigmentacionPielReaccionLuz();

                for (int i = 0; i < lstUPOVTuberculoPigmentacionPielReaccionLuz.Count; i++)
                {
                    string valor = lstUPOVTuberculoPigmentacionPielReaccionLuz[i].Id_tuberculo_pigmentacion_piel_reaccion_luz.ToString();
                    this.rdbUPOVTuberculoPigmentacionPielReaccionLuz.Items.Add(new ListItem(lstUPOVTuberculoPigmentacionPielReaccionLuz[i].Nombre_tuberculo_pigmentacion_piel_reaccion_luz, valor));
                }
                this.rdbUPOVTuberculoPigmentacionPielReaccionLuz.SelectedValue = lstUPOV[0].Id_tuberculo_pigmentacion_piel_reaccion_luz.ToString();

                //Profundidad
                List<ProfundidadOjo> lstProfundidadOjo = new List<ProfundidadOjo>();
                CatalogProfundidadOjo cp = new CatalogProfundidadOjo();
                lstProfundidadOjo = cp.getProfundidadOjo();

                for (int i = 0; i < lstProfundidadOjo.Count; i++)
                {
                    string valor = lstProfundidadOjo[i].Id_profundidad.ToString();
                    this.rdbUPOVProfundidadOjo.Items.Add(new ListItem(lstProfundidadOjo[i].Profundidad_ojo, valor));
                }
                this.rdbUPOVProfundidadOjo.SelectedValue = lstUPOV[0].Id_profundidad.ToString();

                //Forma
                List<FormaTuberculos> lstFormaTuberculos = new List<FormaTuberculos>();
                CatalogFormaTuberculos cf = new CatalogFormaTuberculos();
                lstFormaTuberculos = cf.getFormaTuberculos();

                for (int i = 0; i < lstFormaTuberculos.Count; i++)
                {
                    string valor = lstFormaTuberculos[i].Id_forma.ToString();
                    this.rdbUPOVFormaTuberculos.Items.Add(new ListItem(lstFormaTuberculos[i].Nombre_forma, valor));
                }
                this.rdbUPOVFormaTuberculos.SelectedValue = lstUPOV[0].Id_forma.ToString();               
            }
        }

        protected void UPOVCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuGeneracion.aspx");
        }

        protected void btnUPOVGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CatalogUPOV cu = new CatalogUPOV();
                int id_inflorescencia_tamano = Int32.Parse(this.rdbUPOVInflorescenciaTamaño.SelectedValue);
                int id_brote_tamano_extremo = Int32.Parse(this.rdbUPOVBroteTamañoExtremo.SelectedValue);
                int id_brote_forma = Int32.Parse(this.rdbUPOVBroteForma.SelectedValue);
                int id_brote_proporcion_azul = Int32.Parse(this.rdbUPOVBroteProporcionAzul.SelectedValue);
                int id_foliolo_brillo_haz = Int32.Parse(this.rdbUPOVFolioloBrilloHaz.SelectedValue);
                int id_boton_floral_pigmentacion = Int32.Parse(this.rdbUPOVBotonFloralPigmentacion.SelectedValue);
                int id_brote_pigmentacion_base = Int32.Parse(this.rdbUPOVBrotePigmentacionBase.SelectedValue);
                int id_hoja_tamano_contorno = Int32.Parse(this.rdbUPOVHojaTamañoContorno.SelectedValue);
                int id_foliolo_pubescencia_haz_roseta_apical = Int32.Parse(this.rdbUPOVFolioloPubescenciaHazRosetaApical.SelectedValue);
                int id_foliolo_ondulacion_borde = Int32.Parse(this.rdbUPOVFolioloOndulacionBorde.SelectedValue);
                int id_brote_radiculas = Int32.Parse(this.rdbUPOVBroteRadiculas.SelectedValue);
                int id_segundo_par_foliolos_anchura_longitud = Int32.Parse(this.rdbUPOVSegundoParFoliolosAnchuraLongitud.SelectedValue);
                int id_brote_porte_extremo = Int32.Parse(this.rdbUPOVBrotePorteExtremo.SelectedValue);
                int id_profundidad = Int32.Parse(this.rdbUPOVProfundidadOjo.SelectedValue);
                int id_planta_porte = Int32.Parse(this.rdbUPOVPlantaPorte.SelectedValue);
                int id_segundo_par_foliolos_tamano = Int32.Parse(this.rdbUPOVSegundoParFoliolosTamaño.SelectedValue);
                int id_planta_altura = Int32.Parse(this.rdbUPOVPlantaAltura.SelectedValue);
                int id_brote_pigmentacion_extremo = Int32.Parse(this.rdbUPOVBrotePigmentacionExtremo.SelectedValue);
                int id_hoja_foliolos_secundarios = Int32.Parse(this.rdbUPOVHojaFoliolosSecundarios.SelectedValue);
                int id_foliolos_terminales_coalescencia = Int32.Parse(this.rdbUPOVFoliolosTerminalesCoalescencia.SelectedValue);
                int id_hoja_pigmentacion_nervio_central = Int32.Parse(this.rdbUPOVHojaPigmentacionNervioCentral.SelectedValue);
                int id_tuberculo_color_base_ojo = Int32.Parse(this.rdbUPOVTuberculoColorBaseOjo.SelectedValue);
                int id_brote_longitud_ramificaciones_laterales = Int32.Parse(this.rdbUPOVBroteLongitudRamificacionesLaterales.SelectedValue);
                int id_foliolo_profundidad_nervios = Int32.Parse(this.rdbUPOVFolioloProfundidadNervios.SelectedValue);
                int id_forma = Int32.Parse(this.rdbUPOVFormaTuberculos.SelectedValue);
                int id_tallo_pigmentacion = Int32.Parse(this.rdbUPOVTalloPigmentacion.SelectedValue);
                int id_brote_pubescencia_base = Int32.Parse(this.rdbUPOVBrotePubescenciaBase.SelectedValue);
                int id_corola_flor_intensidad_pigmentacion_cara_interna = Int32.Parse(this.rdbUPOVCorolaFlorIntensidadPigmentacionCaraInterna.SelectedValue);
                int id_tuberculo_pigmentacion_piel_reaccion_luz = Int32.Parse(this.rdbUPOVTuberculoPigmentacionPielReaccionLuz.SelectedValue);
                int id_corola_flor_proporcion_azul_pigmentacion_cara_interna = Int32.Parse(this.rdbUPOVCorolaFlorProporcionAzulPigmentacionCaraInterna.SelectedValue);
                int id_corola_flor_tamano = Int32.Parse(this.rdbUPOVCorolaFlorTamaño.SelectedValue);
                int id_hoja_apertura = Int32.Parse(this.rdbUPOVHojaApertura.SelectedValue);
                int id_planta_estructura_follaje = Int32.Parse(this.rdbUPOVPlantaEstructuraFollaje.SelectedValue);
                int id_hoja_color_verde = Int32.Parse(this.rdbUPOVHojaColorVerde.SelectedValue);
                int id_planta_frecuencia_flores = Int32.Parse(this.rdbUPOVPlantaFrecuenciaFlores.SelectedValue);
                int id_planta_epoca_madurez = Int32.Parse(this.rdbUPOVPlantaEpocaMadurez.SelectedValue);
                int id_inflorescencia_pigmentacion_pendunculo = Int32.Parse(this.rdbUPOVInflorescenciaPigmentacionPendunculo.SelectedValue);
                int id_brote_pubescencia_extremo = Int32.Parse(this.rdbUPOVBrotePubescenciaExtremo.SelectedValue);
                int id_corola_flor_extension_pigmentacion_cara_interna = Int32.Parse(this.rdbUPOVCorolaFlorExtensionPigmentacionCaraInterna.SelectedValue);
                int id_brote_tamano = Int32.Parse(this.rdbUPOVBroteTamaño.SelectedValue);
                string nombre_variedad_upov = this.txtUPOVNombreVariedad.Text;

                Project.BusinessRules.UPOV upov = new Project.BusinessRules.UPOV(Int32.Parse(id_upov), id_inflorescencia_tamano,
                    id_brote_tamano_extremo, id_brote_forma, id_brote_proporcion_azul, id_foliolo_brillo_haz, id_boton_floral_pigmentacion,
                    id_brote_pigmentacion_base, id_hoja_tamano_contorno, id_foliolo_pubescencia_haz_roseta_apical,
                    id_foliolo_ondulacion_borde, id_brote_radiculas, id_segundo_par_foliolos_anchura_longitud, id_brote_porte_extremo,
                    id_profundidad, id_planta_porte, id_segundo_par_foliolos_tamano, id_planta_altura, id_brote_pigmentacion_extremo,
                    id_hoja_foliolos_secundarios, id_foliolos_terminales_coalescencia, id_hoja_pigmentacion_nervio_central,
                    id_tuberculo_color_base_ojo, id_brote_longitud_ramificaciones_laterales, id_foliolo_profundidad_nervios, id_forma,
                    id_tallo_pigmentacion, id_brote_pubescencia_base, id_corola_flor_intensidad_pigmentacion_cara_interna,
                    id_tuberculo_pigmentacion_piel_reaccion_luz, id_corola_flor_proporcion_azul_pigmentacion_cara_interna,
                    id_corola_flor_tamano, id_hoja_apertura, id_planta_estructura_follaje, id_hoja_color_verde,
                    id_planta_frecuencia_flores, id_planta_epoca_madurez, id_inflorescencia_pigmentacion_pendunculo,
                    id_brote_pubescencia_extremo, id_corola_flor_extension_pigmentacion_cara_interna, id_brote_tamano,
                    nombre_variedad_upov);

                int valor = cu.UpdateUPOV(upov);
                if (valor == 0)
                    Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('¡No se pudo modificar el informe UPOV!')</script>");
                else                                   
                    Response.Redirect("MenuGeneracion.aspx");
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "Script", "<script>alert('" + ex.ToString() + "')</script>");
            }
        }
    }
}