using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVBrotePigmentacionExtremo
    {
        private int id_brote_pigmentacion_extremo;
        private string nombre_brote_pigmentacion_extremo;

        public int Id_brote_pigmentacion_extremo
        {
            get { return id_brote_pigmentacion_extremo; }
            set { id_brote_pigmentacion_extremo = value; }
        }        

        public string Nombre_brote_pigmentacion_extremo
        {
            get { return nombre_brote_pigmentacion_extremo; }
            set { nombre_brote_pigmentacion_extremo = value; }
        }

        public UPOVBrotePigmentacionExtremo(int id_brote_pigmentacion_extremo, string nombre_brote_pigmentacion_extremo)
        {
            this.id_brote_pigmentacion_extremo = id_brote_pigmentacion_extremo;
            this.nombre_brote_pigmentacion_extremo = nombre_brote_pigmentacion_extremo;
        }
    }
}