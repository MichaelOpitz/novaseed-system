using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Vasos
    {
        private int id_vasos, id_fertilidad, id_cruzamiento, ano_vasos, cantidad_vasos,
            azul_vasos, roja_vasos, amarilla_vasos, bicolor_vasos;
        private string codigo_variedad, pad_codigo_variedad, ubicacion_vasos, nombre_fertilidad, nombre_madre, nombre_padre;

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

        public string Nombre_fertilidad
        {
            get { return nombre_fertilidad; }
            set { nombre_fertilidad = value; }
        }

        public string Ubicacion_vasos
        {
            get { return ubicacion_vasos; }
            set { ubicacion_vasos = value; }
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

        public int Bicolor_vasos
        {
            get { return bicolor_vasos; }
            set { bicolor_vasos = value; }
        }

        public int Amarilla_vasos
        {
            get { return amarilla_vasos; }
            set { amarilla_vasos = value; }
        }

        public int Roja_vasos
        {
            get { return roja_vasos; }
            set { roja_vasos = value; }
        }

        public int Azul_vasos
        {
            get { return azul_vasos; }
            set { azul_vasos = value; }
        }

        public int Cantidad_vasos
        {
            get { return cantidad_vasos; }
            set { cantidad_vasos = value; }
        }

        public int Ano_vasos
        {
            get { return ano_vasos; }
            set { ano_vasos = value; }
        }

        public int Id_cruzamiento
        {
            get { return id_cruzamiento; }
            set { id_cruzamiento = value; }
        }

        public int Id_fertilidad
        {
            get { return id_fertilidad; }
            set { id_fertilidad = value; }
        }

        public int Id_vasos
        {
            get { return id_vasos; }
            set { id_vasos = value; }
        }

        /*
         * Constructor para obtener el vaso
         */ 
        public Vasos(int id_vasos, string codigo_variedad, string nombre_madre, string pad_codigo_variedad, string nombre_padre, 
            string ubicacion_vasos, int cantidad_vasos, string nombre_fertilidad)
        {
            this.id_vasos = id_vasos;
            this.codigo_variedad = codigo_variedad;
            this.nombre_madre = nombre_madre;
            this.pad_codigo_variedad = pad_codigo_variedad;
            this.nombre_padre = nombre_padre;
            this.ubicacion_vasos = ubicacion_vasos;
            this.cantidad_vasos = cantidad_vasos;
            this.nombre_fertilidad = nombre_fertilidad;
        }

        /*
         * Constructor que obtiene los colores del vaso
         */
        public Vasos(int azul_vasos, int roja_vasos, int amarilla_vasos, int bicolor_vasos)
        {
            this.azul_vasos = azul_vasos;
            this.roja_vasos = roja_vasos;
            this.amarilla_vasos = amarilla_vasos;
            this.bicolor_vasos = bicolor_vasos;
        }

        /*
         * Constructor que actualiza los vasos
         */
        public Vasos(int id_vasos, string ubicacion_vasos, int cantidad_vasos, int id_fertilidad, 
            int azul_vasos, int roja_vasos, int amarilla_vasos, int bicolor_vasos)
        {
            this.id_vasos = id_vasos;
            this.ubicacion_vasos = ubicacion_vasos;
            this.cantidad_vasos = cantidad_vasos;
            this.id_fertilidad = id_fertilidad;
            this.azul_vasos = azul_vasos;
            this.roja_vasos = roja_vasos;
            this.amarilla_vasos = amarilla_vasos;
            this.bicolor_vasos = bicolor_vasos;

        }
    }
}