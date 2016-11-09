using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Madurez
    {
        private int id_madurez, valor_madurez;
        private string nombre_madurez;

        public int Valor_madurez
        {
            get { return valor_madurez; }
            set { valor_madurez = value; }
        }

        public int Id_madurez
        {
            get { return id_madurez; }
            set { id_madurez = value; }
        }        

        public string Nombre_madurez
        {
            get { return nombre_madurez; }
            set { nombre_madurez = value; }
        }

        public Madurez(int id_madurez, string nombre_madurez)
        {
            this.id_madurez = id_madurez;
            this.nombre_madurez = nombre_madurez;           
        }
    }
}