using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;

namespace Project.BusinessRules
{
    public class Codificacion
    {
        private int id_codificacion, id_clones, ano_codificacion;
        private string codigo_variedad, pad_codigo_variedad, codigo_individuo, nombre_madre, nombre_padre;

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

        public int Ano_codificacion
        {
            get { return ano_codificacion; }
            set { ano_codificacion = value; }
        }

        public int Id_clones
        {
            get { return id_clones; }
            set { id_clones = value; }
        }

        public int Id_codificacion
        {
            get { return id_codificacion; }
            set { id_codificacion = value; }
        }

        /*
         *  Constructor para listar los padres de la codificacion
         */ 
        public Codificacion(string codigo_variedad, string nombre_madre, string pad_codigo_variedad, string nombre_padre)
        {
            this.codigo_variedad = codigo_variedad;
            this.nombre_madre = nombre_madre;
            this.pad_codigo_variedad = pad_codigo_variedad;
            this.nombre_padre = nombre_padre;
        }

        /*
         *  Constructor para listar los hijos en la codificacion de los padres
         */
        public Codificacion(int id_codificacion, string codigo_individuo)
        {
            this.id_codificacion = id_codificacion;
            this.codigo_individuo = codigo_individuo;
        }

    }
}