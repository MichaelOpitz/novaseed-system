using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVSegundoParFoliolosTamaño
    {
        private int id_segundo_par_foliolos_tamaño;
        private string nombre_segundo_par_foliolos_tamaño;

        public int Id_segundo_par_foliolos_tamaño
        {
            get { return id_segundo_par_foliolos_tamaño; }
            set { id_segundo_par_foliolos_tamaño = value; }
        }        

        public string Nombre_segundo_par_foliolos_tamaño
        {
            get { return nombre_segundo_par_foliolos_tamaño; }
            set { nombre_segundo_par_foliolos_tamaño = value; }
        }

        public UPOVSegundoParFoliolosTamaño(int id_segundo_par_foliolos_tamaño, string nombre_segundo_par_foliolos_tamaño)
        {
            this.id_segundo_par_foliolos_tamaño = id_segundo_par_foliolos_tamaño;
            this.nombre_segundo_par_foliolos_tamaño = nombre_segundo_par_foliolos_tamaño;            
        }
    }
}