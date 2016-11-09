using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Ciudad
    {
        private int id_ciudad, id_provincia;
        private string nombre_ciudad;

        public int Id_provincia
        {
            get { return id_provincia; }
            set { id_provincia = value; }
        }

        public int Id_ciudad
        {
            get { return id_ciudad; }
            set { id_ciudad = value; }
        }        

        public string Nombre_ciudad
        {
            get { return nombre_ciudad; }
            set { nombre_ciudad = value; }
        }

        public Ciudad(int id_ciudad, string nombre_ciudad)
        {
            this.id_ciudad = id_ciudad;
            this.nombre_ciudad = nombre_ciudad;
        }
    }
}