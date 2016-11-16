using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Cruzamiento
    {
        private int id_cruzamiento, id_fertilidad, ano_cruzamiento, bayas;
        private string codigo_variedad, pad_codigo_variedad, nombre_fertilidad, nombre_madre, nombre_padre,
            ubicacion_cruzamiento;
        private bool flor;

        public string Ubicacion_cruzamiento
        {
            get { return ubicacion_cruzamiento; }
            set { ubicacion_cruzamiento = value; }
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

        public string Nombre_fertilidad
        {
            get { return nombre_fertilidad; }
            set { nombre_fertilidad = value; }
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

        /*
         * Constructor para obtener el cruzamiento
         */ 
        public Cruzamiento(int id_cruzamiento,  string codigo_variedad, string nombre_madre, string pad_codigo_variedad,
            string nombre_padre, string ubicacion_cruzamiento, string nombre_fertilidad, 
            bool flor, int bayas)
        {
            this.id_cruzamiento = id_cruzamiento;            
            this.codigo_variedad = codigo_variedad;
            this.nombre_madre = nombre_madre;
            this.pad_codigo_variedad = pad_codigo_variedad;
            this.nombre_padre = nombre_padre;
            this.ubicacion_cruzamiento = ubicacion_cruzamiento;
            this.nombre_fertilidad = nombre_fertilidad;
            this.flor = flor;
            this.bayas = bayas;
        }

        /*
         * Constructor para la funcion que obtiene el menor año del total de cruzamientos
         */ 
        public Cruzamiento(int ano_cruzamiento)
        {
            this.ano_cruzamiento = ano_cruzamiento;
        }

        /*
         * Constructor para actualizar el cruzamiento
         */
        public Cruzamiento(int id_cruzamiento, string codigo_variedad, string pad_codigo_variedad, 
            string ubicacion_cruzamiento, int id_fertilidad, bool flor, int bayas)
        {
            this.id_cruzamiento = id_cruzamiento;
            this.codigo_variedad = codigo_variedad;
            this.pad_codigo_variedad = pad_codigo_variedad;
            this.ubicacion_cruzamiento = ubicacion_cruzamiento;
            this.id_fertilidad = id_fertilidad;
            this.flor = flor;
            this.bayas = bayas;
        }
    }
}