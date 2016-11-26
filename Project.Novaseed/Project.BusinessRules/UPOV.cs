using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOV
    {
        private int id_upov;
        private string codigo_individuo, nombre_upov, nombre_ciudad, codigo_variedad, nombre_madre, pad_codigo_variedad,
            nombre_padre, nombre_variedad_upov;

        private int id_inflorescencia_tamano, id_brote_tamano_extremo, id_brote_forma, id_brote_proporcion_azul, id_foliolo_brillo_haz,
            id_boton_floral_pigmentacion, id_brote_pigmentacion_base, id_hoja_tamano_contorno, id_foliolo_pubescencia_haz_roseta_apical,
            id_foliolo_ondulacion_borde, id_brote_radiculas, id_segundo_par_foliolos_anchura_longitud, id_brote_porte_extremo, 
            id_profundidad, id_planta_porte, id_segundo_par_foliolos_tamano, id_planta_altura, id_brote_pigmentacion_extremo,
            id_hoja_foliolos_secundarios, id_foliolos_terminales_coalescencia, id_hoja_pigmentacion_nervio_central,
            id_tuberculo_color_base_ojo, id_brote_longitud_ramificaciones_laterales, id_foliolo_profundidad_nervios, id_forma,
            id_tallo_pigmentacion, id_brote_pubescencia_base, id_corola_flor_intensidad_pigmentacion_cara_interna,
            id_tuberculo_pigmentacion_piel_reaccion_luz, id_corola_flor_proporcion_azul_pigmentacion_cara_interna, 
            id_corola_flor_tamano, id_hoja_apertura, id_planta_estructura_follaje, id_hoja_color_verde, id_planta_frecuencia_flores,
            id_planta_epoca_madurez, id_inflorescencia_pigmentacion_pendunculo, id_brote_pubescencia_extremo,
            id_corola_flor_extension_pigmentacion_cara_interna, id_brote_tamano, id_cosecha, ano_upov, id_color_carne, id_color_piel;

        public int Id_color_piel
        {
            get { return id_color_piel; }
            set { id_color_piel = value; }
        }

        public int Id_color_carne
        {
            get { return id_color_carne; }
            set { id_color_carne = value; }
        }

        public int Ano_upov
        {
            get { return ano_upov; }
            set { ano_upov = value; }
        }

        public int Id_cosecha
        {
            get { return id_cosecha; }
            set { id_cosecha = value; }
        }

        public int Id_brote_tamano
        {
            get { return id_brote_tamano; }
            set { id_brote_tamano = value; }
        }

        public int Id_corola_flor_extension_pigmentacion_cara_interna
        {
            get { return id_corola_flor_extension_pigmentacion_cara_interna; }
            set { id_corola_flor_extension_pigmentacion_cara_interna = value; }
        }

        public int Id_brote_pubescencia_extremo
        {
            get { return id_brote_pubescencia_extremo; }
            set { id_brote_pubescencia_extremo = value; }
        }

        public int Id_inflorescencia_pigmentacion_pendunculo
        {
            get { return id_inflorescencia_pigmentacion_pendunculo; }
            set { id_inflorescencia_pigmentacion_pendunculo = value; }
        }

        public int Id_planta_epoca_madurez
        {
            get { return id_planta_epoca_madurez; }
            set { id_planta_epoca_madurez = value; }
        }

        public int Id_planta_frecuencia_flores
        {
            get { return id_planta_frecuencia_flores; }
            set { id_planta_frecuencia_flores = value; }
        }

        public int Id_hoja_color_verde
        {
            get { return id_hoja_color_verde; }
            set { id_hoja_color_verde = value; }
        }

        public int Id_planta_estructura_follaje
        {
            get { return id_planta_estructura_follaje; }
            set { id_planta_estructura_follaje = value; }
        }

        public int Id_hoja_apertura
        {
            get { return id_hoja_apertura; }
            set { id_hoja_apertura = value; }
        }

        public int Id_corola_flor_tamano
        {
            get { return id_corola_flor_tamano; }
            set { id_corola_flor_tamano = value; }
        }

        public int Id_corola_flor_proporcion_azul_pigmentacion_cara_interna
        {
            get { return id_corola_flor_proporcion_azul_pigmentacion_cara_interna; }
            set { id_corola_flor_proporcion_azul_pigmentacion_cara_interna = value; }
        }

        public int Id_tuberculo_pigmentacion_piel_reaccion_luz
        {
            get { return id_tuberculo_pigmentacion_piel_reaccion_luz; }
            set { id_tuberculo_pigmentacion_piel_reaccion_luz = value; }
        }

        public int Id_corola_flor_intensidad_pigmentacion_cara_interna
        {
            get { return id_corola_flor_intensidad_pigmentacion_cara_interna; }
            set { id_corola_flor_intensidad_pigmentacion_cara_interna = value; }
        }

        public int Id_brote_pubescencia_base
        {
            get { return id_brote_pubescencia_base; }
            set { id_brote_pubescencia_base = value; }
        }

        public int Id_tallo_pigmentacion
        {
            get { return id_tallo_pigmentacion; }
            set { id_tallo_pigmentacion = value; }
        }

        public int Id_forma
        {
            get { return id_forma; }
            set { id_forma = value; }
        }

        public int Id_foliolo_profundidad_nervios
        {
            get { return id_foliolo_profundidad_nervios; }
            set { id_foliolo_profundidad_nervios = value; }
        }

        public int Id_brote_longitud_ramificaciones_laterales
        {
            get { return id_brote_longitud_ramificaciones_laterales; }
            set { id_brote_longitud_ramificaciones_laterales = value; }
        }

        public int Id_tuberculo_color_base_ojo
        {
            get { return id_tuberculo_color_base_ojo; }
            set { id_tuberculo_color_base_ojo = value; }
        }

        public int Id_hoja_pigmentacion_nervio_central
        {
            get { return id_hoja_pigmentacion_nervio_central; }
            set { id_hoja_pigmentacion_nervio_central = value; }
        }

        public int Id_foliolos_terminales_coalescencia
        {
            get { return id_foliolos_terminales_coalescencia; }
            set { id_foliolos_terminales_coalescencia = value; }
        }

        public int Id_hoja_foliolos_secundarios
        {
            get { return id_hoja_foliolos_secundarios; }
            set { id_hoja_foliolos_secundarios = value; }
        }

        public int Id_brote_pigmentacion_extremo
        {
            get { return id_brote_pigmentacion_extremo; }
            set { id_brote_pigmentacion_extremo = value; }
        }

        public int Id_planta_altura
        {
            get { return id_planta_altura; }
            set { id_planta_altura = value; }
        }

        public int Id_segundo_par_foliolos_tamano
        {
            get { return id_segundo_par_foliolos_tamano; }
            set { id_segundo_par_foliolos_tamano = value; }
        }

        public int Id_planta_porte
        {
            get { return id_planta_porte; }
            set { id_planta_porte = value; }
        }

        public int Id_profundidad
        {
            get { return id_profundidad; }
            set { id_profundidad = value; }
        }

        public int Id_brote_porte_extremo
        {
            get { return id_brote_porte_extremo; }
            set { id_brote_porte_extremo = value; }
        }

        public int Id_segundo_par_foliolos_anchura_longitud
        {
            get { return id_segundo_par_foliolos_anchura_longitud; }
            set { id_segundo_par_foliolos_anchura_longitud = value; }
        }

        public int Id_brote_radiculas
        {
            get { return id_brote_radiculas; }
            set { id_brote_radiculas = value; }
        }

        public int Id_foliolo_ondulacion_borde
        {
            get { return id_foliolo_ondulacion_borde; }
            set { id_foliolo_ondulacion_borde = value; }
        }

        public int Id_foliolo_pubescencia_haz_roseta_apical
        {
            get { return id_foliolo_pubescencia_haz_roseta_apical; }
            set { id_foliolo_pubescencia_haz_roseta_apical = value; }
        }

        public int Id_hoja_tamano_contorno
        {
            get { return id_hoja_tamano_contorno; }
            set { id_hoja_tamano_contorno = value; }
        }

        public int Id_brote_pigmentacion_base
        {
            get { return id_brote_pigmentacion_base; }
            set { id_brote_pigmentacion_base = value; }
        }

        public int Id_boton_floral_pigmentacion
        {
            get { return id_boton_floral_pigmentacion; }
            set { id_boton_floral_pigmentacion = value; }
        }

        public int Id_foliolo_brillo_haz
        {
            get { return id_foliolo_brillo_haz; }
            set { id_foliolo_brillo_haz = value; }
        }

        public int Id_brote_proporcion_azul
        {
            get { return id_brote_proporcion_azul; }
            set { id_brote_proporcion_azul = value; }
        }

        public int Id_brote_forma
        {
            get { return id_brote_forma; }
            set { id_brote_forma = value; }
        }

        public int Id_brote_tamano_extremo
        {
            get { return id_brote_tamano_extremo; }
            set { id_brote_tamano_extremo = value; }
        }

        public int Id_inflorescencia_tamano
        {
            get { return id_inflorescencia_tamano; }
            set { id_inflorescencia_tamano = value; }
        }        

        public string Nombre_variedad_upov
        {
            get { return nombre_variedad_upov; }
            set { nombre_variedad_upov = value; }
        }

        public string Nombre_upov
        {
            get { return nombre_upov; }
            set { nombre_upov = value; }
        }

        public int Id_upov
        {
            get { return id_upov; }
            set { id_upov = value; }
        }        

        public string Nombre_padre
        {
            get { return nombre_padre; }
            set { nombre_padre = value; }
        }

        public string Pad_codigo_variedad
        {
            get { return pad_codigo_variedad; }
            set { pad_codigo_variedad = value; }
        }

        public string Nombre_madre
        {
            get { return nombre_madre; }
            set { nombre_madre = value; }
        }

        public string Codigo_variedad
        {
            get { return codigo_variedad; }
            set { codigo_variedad = value; }
        }

        public string Codigo_individuo
        {
            get { return codigo_individuo; }
            set { codigo_individuo = value; }
        }

        public string Nombre_ciudad
        {
            get { return nombre_ciudad; }
            set { nombre_ciudad = value; }
        }

        /*
         * Constructor que muestra la tabla para generar el informe upov
         */
        public UPOV(int id_upov, string codigo_individuo, string nombre_upov, string nombre_ciudad, string codigo_variedad, 
            string nombre_madre, string pad_codigo_variedad, string nombre_padre)
        {
            this.id_upov = id_upov;
            this.codigo_individuo = codigo_individuo;
            this.nombre_upov = nombre_upov;
            this.nombre_ciudad = nombre_ciudad;
            this.codigo_variedad = codigo_variedad;
            this.nombre_madre = nombre_madre;
            this.pad_codigo_variedad = pad_codigo_variedad;
            this.nombre_padre = nombre_padre;
        }

        /*
         * Constructor para obtener el informe upov
         */
        public UPOV(int id_upov, int id_inflorescencia_tamano, int id_brote_tamano_extremo, int id_brote_forma, int id_brote_proporcion_azul, 
            int id_foliolo_brillo_haz, int id_boton_floral_pigmentacion, int id_brote_pigmentacion_base, int id_hoja_tamano_contorno,
            int id_foliolo_pubescencia_haz_roseta_apical, int id_foliolo_ondulacion_borde, int id_brote_radiculas, 
            int id_segundo_par_foliolos_anchura_longitud, int id_brote_porte_extremo, int id_profundidad, int id_planta_porte, 
            int id_segundo_par_foliolos_tamano, int id_planta_altura, int id_brote_pigmentacion_extremo, 
            int id_hoja_foliolos_secundarios, int id_foliolos_terminales_coalescencia, int id_hoja_pigmentacion_nervio_central,
            int id_tuberculo_color_base_ojo, int id_brote_longitud_ramificaciones_laterales, int id_foliolo_profundidad_nervios, 
            int id_forma, int id_tallo_pigmentacion, int id_brote_pubescencia_base, int id_corola_flor_intensidad_pigmentacion_cara_interna,
            int id_tuberculo_pigmentacion_piel_reaccion_luz, int id_corola_flor_proporcion_azul_pigmentacion_cara_interna, 
            int id_corola_flor_tamano, int id_hoja_apertura, int id_planta_estructura_follaje, int id_hoja_color_verde, 
            int id_planta_frecuencia_flores, int id_planta_epoca_madurez, int id_inflorescencia_pigmentacion_pendunculo, 
            int id_brote_pubescencia_extremo, int id_corola_flor_extension_pigmentacion_cara_interna, int id_brote_tamano,
            string nombre_variedad_upov, string nombre_madre, string nombre_padre)
        {
            this.id_upov = id_upov;
            this.id_inflorescencia_tamano = id_inflorescencia_tamano;
            this.id_brote_tamano_extremo = id_brote_tamano_extremo;
            this.id_brote_forma = id_brote_forma;
            this.id_brote_proporcion_azul = id_brote_proporcion_azul;
            this.id_foliolo_brillo_haz = id_foliolo_brillo_haz;
            this.id_boton_floral_pigmentacion = id_boton_floral_pigmentacion;
            this.id_brote_pigmentacion_base = id_brote_pigmentacion_base;
            this.id_hoja_tamano_contorno = id_hoja_tamano_contorno;
            this.id_foliolo_pubescencia_haz_roseta_apical = id_foliolo_pubescencia_haz_roseta_apical;
            this.id_foliolo_ondulacion_borde = id_foliolo_ondulacion_borde;
            this.id_brote_radiculas = id_brote_radiculas;
            this.id_segundo_par_foliolos_anchura_longitud = id_segundo_par_foliolos_anchura_longitud;
            this.id_brote_porte_extremo = id_brote_porte_extremo;
            this.id_profundidad = id_profundidad;
            this.id_planta_porte = id_planta_porte;
            this.id_segundo_par_foliolos_tamano = id_segundo_par_foliolos_tamano;
            this.id_planta_altura = id_planta_altura;
            this.id_brote_pigmentacion_extremo = id_brote_pigmentacion_extremo;
            this.id_hoja_foliolos_secundarios = id_hoja_foliolos_secundarios;
            this.id_foliolos_terminales_coalescencia = id_foliolos_terminales_coalescencia;
            this.id_hoja_pigmentacion_nervio_central = id_hoja_pigmentacion_nervio_central;
            this.id_tuberculo_color_base_ojo = id_tuberculo_color_base_ojo;
            this.id_brote_longitud_ramificaciones_laterales = id_brote_longitud_ramificaciones_laterales;
            this.id_foliolo_profundidad_nervios = id_foliolo_profundidad_nervios;
            this.id_forma = id_forma;
            this.id_tallo_pigmentacion = id_tallo_pigmentacion;
            this.id_brote_pubescencia_base = id_brote_pubescencia_base;
            this.id_corola_flor_intensidad_pigmentacion_cara_interna = id_corola_flor_intensidad_pigmentacion_cara_interna;
            this.id_tuberculo_pigmentacion_piel_reaccion_luz = id_tuberculo_pigmentacion_piel_reaccion_luz;
            this.id_corola_flor_proporcion_azul_pigmentacion_cara_interna = id_corola_flor_proporcion_azul_pigmentacion_cara_interna;
            this.id_corola_flor_tamano = id_corola_flor_tamano;
            this.id_hoja_apertura = id_hoja_apertura;
            this.id_planta_estructura_follaje = id_planta_estructura_follaje;
            this.id_hoja_color_verde = id_hoja_color_verde;
            this.id_planta_frecuencia_flores = id_planta_frecuencia_flores;
            this.id_planta_epoca_madurez = id_planta_epoca_madurez;
            this.id_inflorescencia_pigmentacion_pendunculo = id_inflorescencia_pigmentacion_pendunculo;
            this.id_brote_pubescencia_extremo = id_brote_pubescencia_extremo;
            this.id_corola_flor_extension_pigmentacion_cara_interna = id_corola_flor_extension_pigmentacion_cara_interna;
            this.id_brote_tamano = id_brote_tamano;
            this.nombre_variedad_upov = nombre_variedad_upov;
            this.nombre_madre = nombre_madre;
            this.nombre_padre = nombre_padre;
        }

        /*
         * Constructor para actualizar el informe upov
         */
        public UPOV(int id_upov, int id_inflorescencia_tamano, int id_brote_tamano_extremo, int id_brote_forma,
            int id_brote_proporcion_azul, int id_foliolo_brillo_haz, int id_boton_floral_pigmentacion, int id_brote_pigmentacion_base,
            int id_hoja_tamano_contorno, int id_foliolo_pubescencia_haz_roseta_apical, int id_foliolo_ondulacion_borde,
            int id_brote_radiculas, int id_segundo_par_foliolos_anchura_longitud, int id_brote_porte_extremo, int id_profundidad,
            int id_planta_porte, int id_segundo_par_foliolos_tamano, int id_planta_altura, int id_brote_pigmentacion_extremo,
            int id_hoja_foliolos_secundarios, int id_foliolos_terminales_coalescencia, int id_hoja_pigmentacion_nervio_central,
            int id_tuberculo_color_base_ojo, int id_brote_longitud_ramificaciones_laterales, int id_foliolo_profundidad_nervios,
            int id_forma, int id_tallo_pigmentacion, int id_brote_pubescencia_base, int id_corola_flor_intensidad_pigmentacion_cara_interna,
            int id_tuberculo_pigmentacion_piel_reaccion_luz, int id_corola_flor_proporcion_azul_pigmentacion_cara_interna,
            int id_corola_flor_tamano, int id_hoja_apertura, int id_planta_estructura_follaje, int id_hoja_color_verde,
            int id_planta_frecuencia_flores, int id_planta_epoca_madurez, int id_inflorescencia_pigmentacion_pendunculo,
            int id_brote_pubescencia_extremo, int id_corola_flor_extension_pigmentacion_cara_interna, int id_brote_tamano,
            string nombre_variedad_upov)
        {
            this.id_upov = id_upov;
            this.id_inflorescencia_tamano = id_inflorescencia_tamano;
            this.id_brote_tamano_extremo = id_brote_tamano_extremo;
            this.id_brote_forma = id_brote_forma;
            this.id_brote_proporcion_azul = id_brote_proporcion_azul;
            this.id_foliolo_brillo_haz = id_foliolo_brillo_haz;
            this.id_boton_floral_pigmentacion = id_boton_floral_pigmentacion;
            this.id_brote_pigmentacion_base = id_brote_pigmentacion_base;
            this.id_hoja_tamano_contorno = id_hoja_tamano_contorno;
            this.id_foliolo_pubescencia_haz_roseta_apical = id_foliolo_pubescencia_haz_roseta_apical;
            this.id_foliolo_ondulacion_borde = id_foliolo_ondulacion_borde;
            this.id_brote_radiculas = id_brote_radiculas;
            this.id_segundo_par_foliolos_anchura_longitud = id_segundo_par_foliolos_anchura_longitud;
            this.id_brote_porte_extremo = id_brote_porte_extremo;
            this.id_profundidad = id_profundidad;
            this.id_planta_porte = id_planta_porte;
            this.id_segundo_par_foliolos_tamano = id_segundo_par_foliolos_tamano;
            this.id_planta_altura = id_planta_altura;
            this.id_brote_pigmentacion_extremo = id_brote_pigmentacion_extremo;
            this.id_hoja_foliolos_secundarios = id_hoja_foliolos_secundarios;
            this.id_foliolos_terminales_coalescencia = id_foliolos_terminales_coalescencia;
            this.id_hoja_pigmentacion_nervio_central = id_hoja_pigmentacion_nervio_central;
            this.id_tuberculo_color_base_ojo = id_tuberculo_color_base_ojo;
            this.id_brote_longitud_ramificaciones_laterales = id_brote_longitud_ramificaciones_laterales;
            this.id_foliolo_profundidad_nervios = id_foliolo_profundidad_nervios;
            this.id_forma = id_forma;
            this.id_tallo_pigmentacion = id_tallo_pigmentacion;
            this.id_brote_pubescencia_base = id_brote_pubescencia_base;
            this.id_corola_flor_intensidad_pigmentacion_cara_interna = id_corola_flor_intensidad_pigmentacion_cara_interna;
            this.id_tuberculo_pigmentacion_piel_reaccion_luz = id_tuberculo_pigmentacion_piel_reaccion_luz;
            this.id_corola_flor_proporcion_azul_pigmentacion_cara_interna = id_corola_flor_proporcion_azul_pigmentacion_cara_interna;
            this.id_corola_flor_tamano = id_corola_flor_tamano;
            this.id_hoja_apertura = id_hoja_apertura;
            this.id_planta_estructura_follaje = id_planta_estructura_follaje;
            this.id_hoja_color_verde = id_hoja_color_verde;
            this.id_planta_frecuencia_flores = id_planta_frecuencia_flores;
            this.id_planta_epoca_madurez = id_planta_epoca_madurez;
            this.id_inflorescencia_pigmentacion_pendunculo = id_inflorescencia_pigmentacion_pendunculo;
            this.id_brote_pubescencia_extremo = id_brote_pubescencia_extremo;
            this.id_corola_flor_extension_pigmentacion_cara_interna = id_corola_flor_extension_pigmentacion_cara_interna;
            this.id_brote_tamano = id_brote_tamano;
            this.nombre_variedad_upov = nombre_variedad_upov;
        }

        /*
         * Constructor para la funcion que obtiene el menor año del total de informes upov
         */ 
        public UPOV(int año_upov)
        {
            this.ano_upov = año_upov;
        }
    }
}