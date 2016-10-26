using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Cruzamiento
    {
        private int id_cruzamiento, id_fertilidad, ano_cruzamiento, bayas;
        private string codigo_variedad, pad_codigo_variedad, ubicacion_madre, ubicacion_padre, nombre_fertilidad;
        private bool flor;

        public string Nombre_fertilidad
        {
            get { return nombre_fertilidad; }
            set { nombre_fertilidad = value; }
        }        

        public string Ubicacion_padre
        {
            get { return ubicacion_padre; }
            set { ubicacion_padre = value; }
        }

        public string Ubicacion_madre
        {
            get { return ubicacion_madre; }
            set { ubicacion_madre = value; }
        }
        
        public bool Flor
        {
            get { return flor; }
            set { flor = value; }
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

        public int Bayas
        {
            get { return bayas; }
            set { bayas = value; }
        }

        public int Ano_cruzamiento
        {
            get { return ano_cruzamiento; }
            set { ano_cruzamiento = value; }
        }

        public int Id_fertilidad
        {
            get { return id_fertilidad; }
            set { id_fertilidad = value; }
        }

        public int Id_cruzamiento
        {
            get { return id_cruzamiento; }
            set { id_cruzamiento = value; }
        }

        public Cruzamiento(int id_cruzamiento,  string codigo_variedad, string pad_codigo_variedad, string ubicacion_madre,
            string ubicacion_padre, string nombre_fertilidad, bool flor, int bayas)
        {
            this.id_cruzamiento = id_cruzamiento;            
            this.codigo_variedad = codigo_variedad;
            this.pad_codigo_variedad = pad_codigo_variedad;
            this.ubicacion_madre = ubicacion_madre;
            this.ubicacion_padre = ubicacion_padre;
            this.nombre_fertilidad = nombre_fertilidad;
            this.flor = flor;
            this.bayas = bayas;
        }

        public Cruzamiento(int ano_cruzamiento)
        {
            this.ano_cruzamiento = ano_cruzamiento;
        }

        /*
         * Constructor para actualizar el cruzamiento
         */ 
        public Cruzamiento(int id_cruzamiento, string codigo_variedad, string pad_codigo_variedad, string ubicacion_madre,
            string ubicacion_padre, int id_fertilidad, bool flor, int bayas)
        {
            this.id_cruzamiento = id_cruzamiento;
            this.codigo_variedad = codigo_variedad;
            this.pad_codigo_variedad = pad_codigo_variedad;
            this.ubicacion_madre = ubicacion_madre;
            this.ubicacion_padre = ubicacion_padre;
            this.id_fertilidad = id_fertilidad;
            this.flor = flor;
            this.bayas = bayas;
        }
    }
}