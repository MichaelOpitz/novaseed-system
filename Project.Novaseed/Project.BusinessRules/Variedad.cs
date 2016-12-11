using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Variedad
    {
        
        protected int id_tamaño, id_madurez, id_tuberculos_verdes, id_tizon_tardio_tuberculo, id_emergencia_40_dias,
            id_distribucion_calibre, id_profundidad, id_tizon_tardio_follaje, id_numero_tuberculos, id_metribuzina,
            id_fertilidad, id_destino, id_regularidad, id_forma, id_emergencia, id_brotacion;
        protected string codigo_variedad, nombre_variedad, nombre_tamaño, nombre_madurez, 
            nombre_forma, nombre_distribucion_calibre, nombre_profundidad, nombre_regularidad,
            nombre_brotacion, nombre_emergencia, nombre_emergencia_40_dias, nombre_metribuzina,
            nombre_tuberculos_verdes, nombre_tizon_tardio_follaje, nombre_tizon_tardio_tuberculo,
            nombre_numero_tuberculos, nombre_fertilidad, nombre_destino;

        public string Nombre_destino
        {
            get { return nombre_destino; }
            set { nombre_destino = value; }
        }

        public string Nombre_fertilidad
        {
            get { return nombre_fertilidad; }
            set { nombre_fertilidad = value; }
        }

        public string Nombre_numero_tuberculos
        {
            get { return nombre_numero_tuberculos; }
            set { nombre_numero_tuberculos = value; }
        }

        public string Nombre_tizon_tardio_tuberculo
        {
            get { return nombre_tizon_tardio_tuberculo; }
            set { nombre_tizon_tardio_tuberculo = value; }
        }

        public string Nombre_tizon_tardio_follaje
        {
            get { return nombre_tizon_tardio_follaje; }
            set { nombre_tizon_tardio_follaje = value; }
        }

        public string Nombre_tuberculos_verdes
        {
            get { return nombre_tuberculos_verdes; }
            set { nombre_tuberculos_verdes = value; }
        }

        public string Nombre_metribuzina
        {
            get { return nombre_metribuzina; }
            set { nombre_metribuzina = value; }
        }

        public string Nombre_emergencia_40_dias
        {
            get { return nombre_emergencia_40_dias; }
            set { nombre_emergencia_40_dias = value; }
        }

        public string Nombre_emergencia
        {
            get { return nombre_emergencia; }
            set { nombre_emergencia = value; }
        }

        public string Nombre_brotacion
        {
            get { return nombre_brotacion; }
            set { nombre_brotacion = value; }
        }
        
        public string Nombre_regularidad
        {
            get { return nombre_regularidad; }
            set { nombre_regularidad = value; }
        }

        public string Nombre_profundidad
        {
            get { return nombre_profundidad; }
            set { nombre_profundidad = value; }
        }

        public string Nombre_distribucion_calibre
        {
            get { return nombre_distribucion_calibre; }
            set { nombre_distribucion_calibre = value; }
        }

        public string Nombre_forma
        {
            get { return nombre_forma; }
            set { nombre_forma = value; }
        }
        
        public string Nombre_madurez
        {
            get { return nombre_madurez; }
            set { nombre_madurez = value; }
        }

        public string Nombre_tamaño
        {
            get { return nombre_tamaño; }
            set { nombre_tamaño = value; }
        }

        public int Id_brotacion
        {
            get { return id_brotacion; }
            set { id_brotacion = value; }
        }
        
        public int Id_emergencia
        {
            get { return id_emergencia; }
            set { id_emergencia = value; }
        }

        public int Id_forma
        {
            get { return id_forma; }
            set { id_forma = value; }
        }

        public int Id_regularidad
        {
            get { return id_regularidad; }
            set { id_regularidad = value; }
        }

        public int Id_destino
        {
            get { return id_destino; }
            set { id_destino = value; }
        }

        public int Id_fertilidad
        {
            get { return id_fertilidad; }
            set { id_fertilidad = value; }
        }

        public int Id_metribuzina
        {
            get { return id_metribuzina; }
            set { id_metribuzina = value; }
        }

        public int Id_numero_tuberculos
        {
            get { return id_numero_tuberculos; }
            set { id_numero_tuberculos = value; }
        }

        public int Id_tizon_tardio_follaje
        {
            get { return id_tizon_tardio_follaje; }
            set { id_tizon_tardio_follaje = value; }
        }
        
        public int Id_profundidad
        {
            get { return id_profundidad; }
            set { id_profundidad = value; }
        }

        public int Id_distribucion_calibre
        {
            get { return id_distribucion_calibre; }
            set { id_distribucion_calibre = value; }
        }
        
        public int Id_emergencia_40_dias
        {
            get { return id_emergencia_40_dias; }
            set { id_emergencia_40_dias = value; }
        }

        public int Id_tizon_tardio_tuberculo
        {
            get { return id_tizon_tardio_tuberculo; }
            set { id_tizon_tardio_tuberculo = value; }
        }

        public int Id_tuberculos_verdes
        {
            get { return id_tuberculos_verdes; }
            set { id_tuberculos_verdes = value; }
        }

        public int Id_madurez
        {
            get { return id_madurez; }
            set { id_madurez = value; }
        }

        public int Id_tamaño
        {
            get { return id_tamaño; }
            set { id_tamaño = value; }
        }

        public string Nombre_variedad
        {
            get { return nombre_variedad; }
            set { nombre_variedad = value; }
        }

        public string Codigo_variedad
        {
            get { return codigo_variedad; }
            set { codigo_variedad = value; }
        }

        public Variedad(string codigo_variedad, string nombre_variedad, string nombre_tamaño, string nombre_madurez,
            string nombre_forma, string nombre_distribucion_calibre, string nombre_profundidad, string nombre_regularidad,
            string nombre_brotacion, string nombre_emergencia, string nombre_emergencia_40_dias, string nombre_metribuzina,
            string nombre_tuberculos_verdes, string nombre_tizon_tardio_follaje, string nombre_tizon_tardio_tuberculo,
            string nombre_numero_tuberculos, string nombre_fertilidad, string nombre_destino)
        {
            this.codigo_variedad = codigo_variedad;
            this.nombre_variedad = nombre_variedad;
            this.nombre_tamaño = nombre_tamaño;
            this.nombre_madurez = nombre_madurez;
            this.nombre_forma = nombre_forma;
            this.nombre_distribucion_calibre = nombre_distribucion_calibre;
            this.nombre_profundidad = nombre_profundidad;
            this.nombre_regularidad = nombre_regularidad;            
            this.nombre_brotacion = nombre_brotacion;
            this.nombre_emergencia = nombre_emergencia;
            this.nombre_emergencia_40_dias = nombre_emergencia_40_dias;
            this.nombre_metribuzina = nombre_metribuzina;
            this.nombre_tuberculos_verdes = nombre_tuberculos_verdes;
            this.nombre_tizon_tardio_follaje = nombre_tizon_tardio_follaje;
            this.nombre_tizon_tardio_tuberculo = nombre_tizon_tardio_tuberculo;
            this.nombre_numero_tuberculos = nombre_numero_tuberculos;
            this.nombre_fertilidad = nombre_fertilidad;
            this.nombre_destino = nombre_destino;
        }

        public Variedad(int id_tamaño, int id_madurez,
            int id_forma, int id_distribucion_calibre, int id_profundidad, int id_regularidad,
            int id_brotacion, int id_emergencia, int id_emergencia_40_dias, int id_metribuzina,
            int id_tuberculos_verdes, int id_tizon_tardio_follaje, int id_tizon_tardio_tuberculo,
            int id_numero_tuberculos, int id_fertilidad, int id_destino)
        {
            this.id_tamaño = id_tamaño;
            this.id_madurez = id_madurez;
            this.id_tuberculos_verdes = id_tuberculos_verdes;
            this.id_tizon_tardio_tuberculo = id_tizon_tardio_tuberculo;
            this.id_emergencia_40_dias = id_emergencia_40_dias;            
            this.id_distribucion_calibre = id_distribucion_calibre;
            this.id_profundidad = id_profundidad;            
            this.id_tizon_tardio_follaje = id_tizon_tardio_follaje;
            this.id_numero_tuberculos = id_numero_tuberculos;
            this.id_metribuzina = id_metribuzina;
            this.id_fertilidad = id_fertilidad;
            this.id_destino = id_destino;
            this.id_regularidad = id_regularidad;
            this.id_forma = id_forma;
            this.id_emergencia = id_emergencia;            
            this.id_brotacion = id_brotacion;
        }
    }
}