using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVCorolaFlorTamaño
    {
        private int id_corola_flor_tamaño;
        private string nombre_corola_flor_tamaño;

        public int Id_corola_flor_tamaño
        {
            get { return id_corola_flor_tamaño; }
            set { id_corola_flor_tamaño = value; }
        }        

        public string Nombre_corola_flor_tamaño
        {
            get { return nombre_corola_flor_tamaño; }
            set { nombre_corola_flor_tamaño = value; }
        }

        public UPOVCorolaFlorTamaño(int id_corola_flor_tamaño, string nombre_corola_flor_tamaño)
        {
            this.id_corola_flor_tamaño = id_corola_flor_tamaño;
            this.nombre_corola_flor_tamaño = nombre_corola_flor_tamaño;            
        }
    }
}