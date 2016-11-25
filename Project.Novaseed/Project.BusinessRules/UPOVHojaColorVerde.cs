using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVHojaColorVerde
    {
        private int id_hoja_color_verde;
        private string nombre_hoja_color_verde;

        public int Id_hoja_color_verde
        {
            get { return id_hoja_color_verde; }
            set { id_hoja_color_verde = value; }
        }        

        public string Nombre_hoja_color_verde
        {
            get { return nombre_hoja_color_verde; }
            set { nombre_hoja_color_verde = value; }
        }

        public UPOVHojaColorVerde(int id_hoja_color_verde, string nombre_hoja_color_verde)
        {
            this.id_hoja_color_verde = id_hoja_color_verde;
            this.nombre_hoja_color_verde = nombre_hoja_color_verde;            
        }
    }
}