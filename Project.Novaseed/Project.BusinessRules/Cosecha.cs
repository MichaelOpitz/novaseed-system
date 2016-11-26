using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;

namespace Project.BusinessRules
{
    public class Cosecha
    {
        //Atributos tabla cosecha
        private int id_cosecha, id_distribucion_calibre, id_regularidad, id_profundidad, id_metribuzina, id_madurez, 
            id_desarrollo_follaje, id_forma, id_emergencia_40_dias, id_brotacion, id_destino, id_codificacion, id_ciudad, 
            id_tipo_hoja, id_tuberculos_verdes, id_termporada, id_numero_tuberculos, id_fertilidad, id_tamaño, 
            id_tizon_tardio_tuberculo, id_tizon_tardio_follaje, id_emergencia, id_calidad_piel, año_cosecha, cantidad_papas, 
            porcentaje_relacion_standard, consumo, semillon, semilla, semillita, bajo_calibre, numero_tallos;
        private bool flor_cosecha, bayas_cosecha;
        private double posicion_cosecha, total_kg, tuberculos_planta, toneladas_hectarea;
        private string codigo_variedad, pad_codigo_variedad, codigo_individuo, nombre_destino, nombre_madre, nombre_padre, nombre_ciudad;
        //Atributos tabla urgencia
        private int id_urgencia, id_sensibilidad_quimica, id_facilidad_muerte, dormancia, tolerancia_sequia, tolerancia_calor,
            tolerancia_sal, daño_cosecha, tizon_hoja, putrefaccion_suave, putrefaccion_rosa, silver_scurf, blackleg;
        private double hematomas;

        public string Nombre_ciudad
        {
            get { return nombre_ciudad; }
            set { nombre_ciudad = value; }
        }

        public string Nombre_padre
        {
            get { return nombre_padre; }
            set { nombre_padre = value; }
        }

        public string Nombre_madre
        {
            get { return nombre_madre; }
            set { nombre_madre = value; }
        }        

        public bool Bayas_cosecha
        {
            get { return bayas_cosecha; }
            set { bayas_cosecha = value; }
        }

        public int Numero_tallos
        {
            get { return numero_tallos; }
            set { numero_tallos = value; }
        }

        public int Bajo_calibre
        {
            get { return bajo_calibre; }
            set { bajo_calibre = value; }
        }

        public int Semillita
        {
            get { return semillita; }
            set { semillita = value; }
        }

        public int Semilla
        {
            get { return semilla; }
            set { semilla = value; }
        }

        public int Semillon
        {
            get { return semillon; }
            set { semillon = value; }
        }

        public int Consumo
        {
            get { return consumo; }
            set { consumo = value; }
        }

        public int Porcentaje_relacion_standard
        {
            get { return porcentaje_relacion_standard; }
            set { porcentaje_relacion_standard = value; }
        }

        public double Toneladas_hectarea
        {
            get { return toneladas_hectarea; }
            set { toneladas_hectarea = value; }
        }

        public double Tuberculos_planta
        {
            get { return tuberculos_planta; }
            set { tuberculos_planta = value; }
        }

        public double Total_kg
        {
            get { return total_kg; }
            set { total_kg = value; }
        }

        public int Cantidad_papas
        {
            get { return cantidad_papas; }
            set { cantidad_papas = value; }
        }

        public int Año_cosecha
        {
            get { return año_cosecha; }
            set { año_cosecha = value; }
        }

        public int Id_calidad_piel
        {
            get { return id_calidad_piel; }
            set { id_calidad_piel = value; }
        }

        public int Id_emergencia
        {
            get { return id_emergencia; }
            set { id_emergencia = value; }
        }

        public int Id_tizon_tardio_follaje
        {
            get { return id_tizon_tardio_follaje; }
            set { id_tizon_tardio_follaje = value; }
        }

        public int Id_tizon_tardio_tuberculo
        {
            get { return id_tizon_tardio_tuberculo; }
            set { id_tizon_tardio_tuberculo = value; }
        }

        public int Id_tamaño
        {
            get { return id_tamaño; }
            set { id_tamaño = value; }
        }

        public int Id_fertilidad
        {
            get { return id_fertilidad; }
            set { id_fertilidad = value; }
        }

        public int Id_numero_tuberculos
        {
            get { return id_numero_tuberculos; }
            set { id_numero_tuberculos = value; }
        }

        public int Id_termporada
        {
            get { return id_termporada; }
            set { id_termporada = value; }
        }

        public int Id_tuberculos_verdes
        {
            get { return id_tuberculos_verdes; }
            set { id_tuberculos_verdes = value; }
        }

        public int Id_tipo_hoja
        {
            get { return id_tipo_hoja; }
            set { id_tipo_hoja = value; }
        }

        public int Id_ciudad
        {
            get { return id_ciudad; }
            set { id_ciudad = value; }
        }

        public int Id_codificacion
        {
            get { return id_codificacion; }
            set { id_codificacion = value; }
        }

        public int Id_brotacion
        {
            get { return id_brotacion; }
            set { id_brotacion = value; }
        }

        public int Id_emergencia_40_dias
        {
            get { return id_emergencia_40_dias; }
            set { id_emergencia_40_dias = value; }
        }

        public int Id_forma
        {
            get { return id_forma; }
            set { id_forma = value; }
        }

        public int Id_desarrollo_follaje
        {
            get { return id_desarrollo_follaje; }
            set { id_desarrollo_follaje = value; }
        }

        public int Id_madurez
        {
            get { return id_madurez; }
            set { id_madurez = value; }
        }

        public int Id_metribuzina
        {
            get { return id_metribuzina; }
            set { id_metribuzina = value; }
        }

        public int Id_profundidad
        {
            get { return id_profundidad; }
            set { id_profundidad = value; }
        }

        public int Id_regularidad
        {
            get { return id_regularidad; }
            set { id_regularidad = value; }
        }

        public int Id_distribucion_calibre
        {
            get { return id_distribucion_calibre; }
            set { id_distribucion_calibre = value; }
        }        

        public int Blackleg
        {
            get { return blackleg; }
            set { blackleg = value; }
        }

        public int Silver_scurf
        {
            get { return silver_scurf; }
            set { silver_scurf = value; }
        }

        public int Putrefaccion_rosa
        {
            get { return putrefaccion_rosa; }
            set { putrefaccion_rosa = value; }
        }

        public int Putrefaccion_suave
        {
            get { return putrefaccion_suave; }
            set { putrefaccion_suave = value; }
        }

        public int Tizon_hoja
        {
            get { return tizon_hoja; }
            set { tizon_hoja = value; }
        }

        public double Hematomas
        {
            get { return hematomas; }
            set { hematomas = value; }
        }

        public int Daño_cosecha
        {
            get { return daño_cosecha; }
            set { daño_cosecha = value; }
        }

        public int Tolerancia_sal
        {
            get { return tolerancia_sal; }
            set { tolerancia_sal = value; }
        }

        public int Tolerancia_calor
        {
            get { return tolerancia_calor; }
            set { tolerancia_calor = value; }
        }

        public int Tolerancia_sequia
        {
            get { return tolerancia_sequia; }
            set { tolerancia_sequia = value; }
        }

        public int Dormancia
        {
            get { return dormancia; }
            set { dormancia = value; }
        }

        public int Id_facilidad_muerte
        {
            get { return id_facilidad_muerte; }
            set { id_facilidad_muerte = value; }
        }

        public int Id_sensibilidad_quimica
        {
            get { return id_sensibilidad_quimica; }
            set { id_sensibilidad_quimica = value; }
        }

        public int Id_urgencia
        {
            get { return id_urgencia; }
            set { id_urgencia = value; }
        }


        public bool Flor_cosecha
        {
            get { return flor_cosecha; }
            set { flor_cosecha = value; }
        }        

        public int Id_destino
        {
            get { return id_destino; }
            set { id_destino = value; }
        }

        public int Id_cosecha
        {
            get { return id_cosecha; }
            set { id_cosecha = value; }
        }        

        public double Posicion_cosecha
        {
            get { return posicion_cosecha; }
            set { posicion_cosecha = value; }
        }
        

        public string Nombre_destino
        {
            get { return nombre_destino; }
            set { nombre_destino = value; }
        }

        public string Codigo_individuo
        {
            get { return codigo_individuo; }
            set { codigo_individuo = value; }
        }

        public string Pad_codigo_variedad
        {
            get { return pad_codigo_variedad; }
            set { pad_codigo_variedad = value; }
        }

        public string Codigo_variedad
        {
            get { return codigo_variedad; }
            set { codigo_variedad = value; }
        }

        /*
         * TEMPORADA = 6,12,24,48 PAPAS
         * Constructor para mostrar la tabla de cosecha
         */
        public Cosecha(int id_cosecha, string codigo_variedad, string nombre_madre, string pad_codigo_variedad, string nombre_padre,
            double posicion_cosecha, string codigo_individuo, string nombre_destino)
        {
            this.id_cosecha = id_cosecha;
            this.codigo_variedad = codigo_variedad;
            this.nombre_madre = nombre_madre;
            this.pad_codigo_variedad = pad_codigo_variedad;
            this.nombre_padre = nombre_padre;
            this.posicion_cosecha = posicion_cosecha;
            this.codigo_individuo = codigo_individuo;
            this.nombre_destino = nombre_destino;
        }

        /*
         * TEMPORADA = 6,12,24 PAPAS
         * Constructor para actualizar la variedad en cosecha
         */
        public Cosecha(int id_cosecha, int cantidad_papas, double posicion_cosecha, bool flor_cosecha, bool bayas_cosecha, 
            int id_fertilidad, int id_emergencia40, int id_metribuzina, int id_emergencia, int id_madurez, int id_desarrollo, 
            int id_tipo_hoja, int id_brotacion, int id_tamaño, int id_distribucion, int id_forma, int id_regularidad, 
            int id_profundidad, int id_calidad, int id_tuberculos_verdes, int id_tizon_tardio_follaje, 
            int id_tizon_tardio_tuberculo, int id_numero, int id_ciudad, double total_kg, double tuberculos_planta, 
            double toneladas_hectarea, int porcentaje_relacion_standard, int consumo, int semillon, int semilla, int semillita, 
            int bajo_calibre, int numero_tallos, int id_sensibilidad_quimica, int id_facilidad_muerte, int dormancia, 
            int tolerancia_sequia, int tolerancia_calor, int tolerancia_sal, int daño_cosecha, int tizon_hoja, 
            int putrefaccion_suave, int putrefaccion_rosa, int silver_scurf, int blackleg)
        {            
            this.id_cosecha = id_cosecha;
            this.cantidad_papas = cantidad_papas;
            this.posicion_cosecha = posicion_cosecha;
            this.flor_cosecha = flor_cosecha;
            this.bayas_cosecha = bayas_cosecha;
            this.id_fertilidad = id_fertilidad;
            this.id_emergencia_40_dias = id_emergencia40;
            this.id_metribuzina = id_metribuzina;
            this.id_emergencia = id_emergencia;
            this.id_madurez = id_madurez;
            this.id_desarrollo_follaje = id_desarrollo;
            this.id_tipo_hoja = id_tipo_hoja;
            this.id_brotacion = id_brotacion;
            this.id_tamaño = id_tamaño;
            this.id_distribucion_calibre = id_distribucion;
            this.id_forma = id_forma;
            this.id_regularidad = id_regularidad;
            this.id_profundidad = id_profundidad;
            this.id_calidad_piel = id_calidad;
            this.id_tuberculos_verdes = id_tuberculos_verdes;
            this.id_tizon_tardio_follaje = id_tizon_tardio_follaje;
            this.id_tizon_tardio_tuberculo = id_tizon_tardio_tuberculo;
            this.id_numero_tuberculos = id_numero;
            this.id_ciudad = id_ciudad;
            this.total_kg = total_kg;
            this.tuberculos_planta = tuberculos_planta;
            this.toneladas_hectarea = toneladas_hectarea;
            this.porcentaje_relacion_standard = porcentaje_relacion_standard;
            this.consumo = consumo;
            this.semillon = semillon;
            this.semilla = semilla;
            this.semillita = semillita;
            this.bajo_calibre = bajo_calibre;
            this.numero_tallos = numero_tallos;
            this.id_sensibilidad_quimica = id_sensibilidad_quimica;
            this.id_facilidad_muerte = id_facilidad_muerte;
            this.dormancia = dormancia;
            this.tolerancia_sequia = tolerancia_sequia;
            this.tolerancia_calor = tolerancia_calor;
            this.tolerancia_sal = tolerancia_sal;
            this.daño_cosecha = daño_cosecha;
            this.tizon_hoja = tizon_hoja;
            this.putrefaccion_suave = putrefaccion_suave;
            this.putrefaccion_rosa = putrefaccion_rosa;
            this.silver_scurf = silver_scurf;
            this.blackleg = blackleg;
        }

        /*
         * TEMPORADA = 48 PAPAS
         * Constructor para actualizar la variedad en cosecha
         */
        public Cosecha(int id_cosecha, int cantidad_papas, double posicion_cosecha, bool flor_cosecha, bool bayas_cosecha,
            int id_fertilidad, int id_emergencia40, int id_metribuzina, int id_emergencia, int id_madurez, int id_desarrollo,
            int id_tipo_hoja, int id_brotacion, int id_tamaño, int id_distribucion, int id_forma, int id_regularidad,
            int id_profundidad, int id_calidad, int id_tuberculos_verdes, int id_tizon_tardio_follaje,
            int id_tizon_tardio_tuberculo, int id_numero, int id_ciudad, double total_kg, double tuberculos_planta,
            int consumo, int semillon, int semilla, int semillita,
            int bajo_calibre, int numero_tallos, int id_sensibilidad_quimica, int id_facilidad_muerte, int dormancia,
            int tolerancia_sequia, int tolerancia_calor, int tolerancia_sal, int daño_cosecha, int tizon_hoja,
            int putrefaccion_suave, int putrefaccion_rosa, int silver_scurf, int blackleg)
        {
            this.id_cosecha = id_cosecha;
            this.cantidad_papas = cantidad_papas;
            this.posicion_cosecha = posicion_cosecha;
            this.flor_cosecha = flor_cosecha;
            this.bayas_cosecha = bayas_cosecha;
            this.id_fertilidad = id_fertilidad;
            this.id_emergencia_40_dias = id_emergencia40;
            this.id_metribuzina = id_metribuzina;
            this.id_emergencia = id_emergencia;
            this.id_madurez = id_madurez;
            this.id_desarrollo_follaje = id_desarrollo;
            this.id_tipo_hoja = id_tipo_hoja;
            this.id_brotacion = id_brotacion;
            this.id_tamaño = id_tamaño;
            this.id_distribucion_calibre = id_distribucion;
            this.id_forma = id_forma;
            this.id_regularidad = id_regularidad;
            this.id_profundidad = id_profundidad;
            this.id_calidad_piel = id_calidad;
            this.id_tuberculos_verdes = id_tuberculos_verdes;
            this.id_tizon_tardio_follaje = id_tizon_tardio_follaje;
            this.id_tizon_tardio_tuberculo = id_tizon_tardio_tuberculo;
            this.id_numero_tuberculos = id_numero;
            this.id_ciudad = id_ciudad;
            this.total_kg = total_kg;
            this.tuberculos_planta = tuberculos_planta;
            this.consumo = consumo;
            this.semillon = semillon;
            this.semilla = semilla;
            this.semillita = semillita;
            this.bajo_calibre = bajo_calibre;
            this.numero_tallos = numero_tallos;
            this.id_sensibilidad_quimica = id_sensibilidad_quimica;
            this.id_facilidad_muerte = id_facilidad_muerte;
            this.dormancia = dormancia;
            this.tolerancia_sequia = tolerancia_sequia;
            this.tolerancia_calor = tolerancia_calor;
            this.tolerancia_sal = tolerancia_sal;
            this.daño_cosecha = daño_cosecha;
            this.tizon_hoja = tizon_hoja;
            this.putrefaccion_suave = putrefaccion_suave;
            this.putrefaccion_rosa = putrefaccion_rosa;
            this.silver_scurf = silver_scurf;
            this.blackleg = blackleg;
        }

        /*
         * TEMPORADA=48PAPAS
         * Constructor para mostrar la tabla de de rendimiento de 48 papas
         */
        public Cosecha(string codigo_individuo, string nombre_ciudad, int porcentaje_relacion_standard, double toneladas_hectarea)
        {
            this.codigo_individuo = codigo_individuo;
            this.nombre_ciudad = nombre_ciudad;
            this.porcentaje_relacion_standard = porcentaje_relacion_standard;
            this.toneladas_hectarea = toneladas_hectarea;
        }
    }
}