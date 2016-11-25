using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVInflorescenciaTamaño
    {
        private int id_inflorescencia_tamaño;
        private string nombre_inflorescencia_tamaño;

        public int Id_inflorescencia_tamaño
        {
            get { return id_inflorescencia_tamaño; }
            set { id_inflorescencia_tamaño = value; }
        }        

        public string Nombre_inflorescencia_tamaño
        {
            get { return nombre_inflorescencia_tamaño; }
            set { nombre_inflorescencia_tamaño = value; }
        }

        public UPOVInflorescenciaTamaño(int id_inflorescencia_tamaño, string nombre_inflorescencia_tamaño)
        {
            this.id_inflorescencia_tamaño = id_inflorescencia_tamaño;
            this.nombre_inflorescencia_tamaño = nombre_inflorescencia_tamaño;           
        }
    }
}