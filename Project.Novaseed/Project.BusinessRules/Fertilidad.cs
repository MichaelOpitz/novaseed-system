using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Fertilidad
    {
        private int id_fertilidad;
        private string nombre_fertilidad;

        public int Id_fertilidad
        {
            get { return id_fertilidad; }
            set { id_fertilidad = value; }
        }        

        public string Nombre_fertilidad
        {
            get { return nombre_fertilidad; }
            set { nombre_fertilidad = value; }
        }

        public Fertilidad(int id_fertilidad, string nombre_fertilidad)
        {
            this.id_fertilidad = id_fertilidad;
            this.nombre_fertilidad = nombre_fertilidad;
        }
    }
}