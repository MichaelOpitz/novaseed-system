using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVBroteTamaño
    {
        private int id_brote_tamaño;
        private string nombre_brote_tamaño;

        public int Id_brote_tamaño
        {
            get { return id_brote_tamaño; }
            set { id_brote_tamaño = value; }
        }        

        public string Nombre_brote_tamaño
        {
            get { return nombre_brote_tamaño; }
            set { nombre_brote_tamaño = value; }
        }

        public UPOVBroteTamaño(int id_brote_tamaño, string nombre_brote_tamaño)
        {
            this.id_brote_tamaño = id_brote_tamaño;
            this.nombre_brote_tamaño = nombre_brote_tamaño;
        }
    }
}