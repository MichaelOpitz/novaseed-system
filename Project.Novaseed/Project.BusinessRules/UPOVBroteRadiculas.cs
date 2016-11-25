using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVBroteRadiculas
    {
        private int id_brote_radiculas;
        private string nombre_brote_radiculas;

        public int Id_brote_radiculas
        {
            get { return id_brote_radiculas; }
            set { id_brote_radiculas = value; }
        }        

        public string Nombre_brote_radiculas
        {
            get { return nombre_brote_radiculas; }
            set { nombre_brote_radiculas = value; }
        }

        public UPOVBroteRadiculas(int id_brote_radiculas, string nombre_brote_radiculas)
        {
            this.id_brote_radiculas = id_brote_radiculas;
            this.nombre_brote_radiculas = nombre_brote_radiculas;
        }
    }
}