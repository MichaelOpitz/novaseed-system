using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVBroteTamañoExtremo
    {
        private int id_brote_tamaño_extremo;
        private string nombre_brote_tamaño_extremo;

        public int Id_brote_tamaño_extremo
        {
            get { return id_brote_tamaño_extremo; }
            set { id_brote_tamaño_extremo = value; }
        }        

        public string Nombre_brote_tamaño_extremo
        {
            get { return nombre_brote_tamaño_extremo; }
            set { nombre_brote_tamaño_extremo = value; }
        }

        public UPOVBroteTamañoExtremo(int id_brote_tamaño_extremo, string nombre_brote_tamaño_extremo)
        {
            this.id_brote_tamaño_extremo = id_brote_tamaño_extremo;
            this.nombre_brote_tamaño_extremo = nombre_brote_tamaño_extremo;
        }
    }
}