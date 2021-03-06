﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Madre : Variedad
    {
        private string ubicacion_madre;        

        public string Ubicacion_madre
        {
            get { return ubicacion_madre; }
            set { ubicacion_madre = value; }
        }                

        /*
         * Constructor que hereda de clase variedad y muestra nombres de las características en vez de las id's
         */ 
        public Madre(string codigo_variedad, string nombre_variedad, string nombre_tamaño, string nombre_madurez,
            string nombre_forma, string nombre_distribucion_calibre, string nombre_profundidad, string nombre_regularidad,
            string nombre_brotacion, string nombre_emergencia, string nombre_emergencia_40_dias, string nombre_metribuzina,
            string nombre_tuberculos_verdes, string nombre_tizon_tardio_follaje, string nombre_tizon_tardio_tuberculo,
            string nombre_numero_tuberculos, string nombre_fertilidad, string nombre_destino, string ubicacion_madre)
            : base(codigo_variedad, nombre_variedad, nombre_tamaño, nombre_madurez,
            nombre_forma, nombre_distribucion_calibre, nombre_profundidad, nombre_regularidad,
            nombre_brotacion, nombre_emergencia, nombre_emergencia_40_dias, nombre_metribuzina,
            nombre_tuberculos_verdes, nombre_tizon_tardio_follaje, nombre_tizon_tardio_tuberculo,
            nombre_numero_tuberculos, nombre_fertilidad, nombre_destino)
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
            this.ubicacion_madre = ubicacion_madre;
        }

        /*
         * Constructor que muestra las id's de las características
         */ 
        public Madre(int id_tamaño, int id_madurez,
            int id_forma, int id_distribucion_calibre, int id_profundidad, int id_regularidad,
            int id_brotacion, int id_emergencia, int id_emergencia_40_dias, int id_metribuzina,
            int id_tuberculos_verdes, int id_tizon_tardio_follaje, int id_tizon_tardio_tuberculo,
            int id_numero_tuberculos, int id_fertilidad, int id_destino)
            : base(id_tamaño, id_madurez, id_forma, id_distribucion_calibre,
            id_profundidad, id_regularidad, id_brotacion, id_emergencia, id_emergencia_40_dias, id_metribuzina,
            id_tuberculos_verdes, id_tizon_tardio_follaje, id_tizon_tardio_tuberculo, id_numero_tuberculos, id_fertilidad, id_destino)
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