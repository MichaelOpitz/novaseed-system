using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVBrotePorteExtremo
    {
        private int id_brote_porte_extremo;
        private string nombre_brote_porte_extremo;

        public int Id_brote_porte_extremo
        {
            get { return id_brote_porte_extremo; }
            set { id_brote_porte_extremo = value; }
        }        

        public string Nombre_brote_porte_extremo
        {
            get { return nombre_brote_porte_extremo; }
            set { nombre_brote_porte_extremo = value; }
        }

        public UPOVBrotePorteExtremo(int id_brote_porte_extremo, string nombre_brote_porte_extremo)
        {
            this.id_brote_porte_extremo = id_brote_porte_extremo;
            this.nombre_brote_porte_extremo = nombre_brote_porte_extremo;
        }
    }
}