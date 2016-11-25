using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVBrotePubescenciaExtremo
    {
        private int id_brote_pubescencia_extremo;
        private string nombre_brote_pubescencia_extremo;

        public int Id_brote_pubescencia_extremo
        {
            get { return id_brote_pubescencia_extremo; }
            set { id_brote_pubescencia_extremo = value; }
        }        

        public string Nombre_brote_pubescencia_extremo
        {
            get { return nombre_brote_pubescencia_extremo; }
            set { nombre_brote_pubescencia_extremo = value; }
        }

        public UPOVBrotePubescenciaExtremo(int id_brote_pubescencia_extremo, string nombre_brote_pubescencia_extremo)
        {
            this.id_brote_pubescencia_extremo = id_brote_pubescencia_extremo;
            this.nombre_brote_pubescencia_extremo = nombre_brote_pubescencia_extremo;
        }
    }
}