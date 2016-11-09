using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Drawing;

namespace Project.BusinessRules
{
    public class Clones
    {
        private int id_clones, id_fertilidad, id_vasos, ano_clon, azul_clon, roja_clon, amarilla_clon, bicolor_clon, tiene_imagen;
        private double posicion_clon;
        private string codigo_variedad, pad_codigo_variedad, nombre_fertilidad, nombre_madre, nombre_padre;

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

        public int Tiene_imagen
        {
            get { return tiene_imagen; }
            set { tiene_imagen = value; }
        }        

        public double Posicion_clon
        {
            get { return posicion_clon; }
            set { posicion_clon = value; }
        }

        public int Bicolor_clon
        {
            get { return bicolor_clon; }
            set { bicolor_clon = value; }
        }

        public int Amarilla_clon
        {
            get { return amarilla_clon; }
            set { amarilla_clon = value; }
        }

        public int Roja_clon
        {
            get { return roja_clon; }
            set { roja_clon = value; }
        }

        public int Azul_clon
        {
            get { return azul_clon; }
            set { azul_clon = value; }
        }

        public int Ano_clon
        {
            get { return ano_clon; }
            set { ano_clon = value; }
        }

        public int Id_vasos
        {
            get { return id_vasos; }
            set { id_vasos = value; }
        }

        public int Id_fertilidad
        {
            get { return id_fertilidad; }
            set { id_fertilidad = value; }
        }

        public int Id_clones
        {
            get { return id_clones; }
            set { id_clones = value; }
        }        

        public string Nombre_fertilidad
        {
            get { return nombre_fertilidad; }
            set { nombre_fertilidad = value; }
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
         * Constructor para obtener el clon
         */
        public Clones(int id_clones, string codigo_variedad, string nombre_madre, string pad_codigo_variedad, string nombre_padre,
            double posicion_clon, string nombre_fertilidad, int azul_clon, int roja_clon, int amarilla_clon, int bicolor_clon)
        {
            this.id_clones = id_clones;
            this.codigo_variedad = codigo_variedad;
            this.nombre_madre = nombre_madre;
            this.pad_codigo_variedad = pad_codigo_variedad;
            this.nombre_padre = nombre_padre;
            this.posicion_clon = posicion_clon;
            this.nombre_fertilidad = nombre_fertilidad;
            this.azul_clon = azul_clon;
            this.roja_clon = roja_clon;
            this.amarilla_clon = amarilla_clon;
            this.bicolor_clon = bicolor_clon;
        }

        /*
        * Constructor para actualizar el clon
        */
        public Clones(int id_clones, double posicion_clon, int id_fertilidad, int azul_clon, int roja_clon, int amarilla_clon, 
            int bicolor_clon)
        {
            this.id_clones = id_clones;
            this.posicion_clon = posicion_clon;
            this.id_fertilidad = id_fertilidad;
            this.azul_clon = azul_clon;
            this.roja_clon = roja_clon;
            this.amarilla_clon = amarilla_clon;
            this.bicolor_clon = bicolor_clon;
        }
    }
}