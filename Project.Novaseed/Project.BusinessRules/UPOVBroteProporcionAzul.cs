using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVBroteProporcionAzul
    {
        private int id_brote_proporcion_azul;
        private string nombre_brote_proporcion_azul;

        public int Id_brote_proporcion_azul
        {
            get { return id_brote_proporcion_azul; }
            set { id_brote_proporcion_azul = value; }
        }        

        public string Nombre_brote_proporcion_azul
        {
            get { return nombre_brote_proporcion_azul; }
            set { nombre_brote_proporcion_azul = value; }
        }

        public UPOVBroteProporcionAzul(int id_brote_proporcion_azul, string nombre_brote_proporcion_azul)
        {
            this.id_brote_proporcion_azul = id_brote_proporcion_azul;
            this.nombre_brote_proporcion_azul = nombre_brote_proporcion_azul;
        }
    }
}