using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVBrotePubescenciaBase
    {
        private int id_brote_pubescencia_base;
        private string nombre_brote_pubescencia_base;

        public int Id_brote_pubescencia_base
        {
            get { return id_brote_pubescencia_base; }
            set { id_brote_pubescencia_base = value; }
        }        

        public string Nombre_brote_pubescencia_base
        {
            get { return nombre_brote_pubescencia_base; }
            set { nombre_brote_pubescencia_base = value; }
        }

        public UPOVBrotePubescenciaBase(int id_brote_pubescencia_base, string nombre_brote_pubescencia_base)
        {
            this.id_brote_pubescencia_base = id_brote_pubescencia_base;
            this.nombre_brote_pubescencia_base = nombre_brote_pubescencia_base;
        }
    }
}