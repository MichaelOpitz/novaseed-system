using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVBroteForma
    {
        private int id_brote_forma;
        private string nombre_brote_forma;

        public int Id_brote_forma
        {
            get { return id_brote_forma; }
            set { id_brote_forma = value; }
        }        

        public string Nombre_brote_forma
        {
            get { return nombre_brote_forma; }
            set { nombre_brote_forma = value; }
        }

        public UPOVBroteForma(int id_brote_forma, string nombre_brote_forma)
        {
            this.id_brote_forma = id_brote_forma;
            this.nombre_brote_forma = nombre_brote_forma;
        }
    }
}