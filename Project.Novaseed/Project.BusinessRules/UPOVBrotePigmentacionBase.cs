using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVBrotePigmentacionBase
    {
        private int id_brote_pigmentacion_base;
        private string nombre_brote_pigmentacion_base;

        public int Id_brote_pigmentacion_base
        {
            get { return id_brote_pigmentacion_base; }
            set { id_brote_pigmentacion_base = value; }
        }        

        public string Nombre_brote_pigmentacion_base
        {
            get { return nombre_brote_pigmentacion_base; }
            set { nombre_brote_pigmentacion_base = value; }
        }

        public UPOVBrotePigmentacionBase(int id_brote_pigmentacion_base, string nombre_brote_pigmentacion_base)
        {
            this.id_brote_pigmentacion_base = id_brote_pigmentacion_base;
            this.nombre_brote_pigmentacion_base = nombre_brote_pigmentacion_base;
        }
    }
}