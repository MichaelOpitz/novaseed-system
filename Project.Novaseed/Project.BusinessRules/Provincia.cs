using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Provincia
    {
        private int id_provincia;
        private string nombre_provincia;

        public string Nombre_provincia
        {
            get { return nombre_provincia; }
            set { nombre_provincia = value; }
        }

        public int Id_provincia
        {
            get { return id_provincia; }
            set { id_provincia = value; }
        }

        public Provincia(int id_provincia, string nombre_provincia)
        {
            this.id_provincia = id_provincia;
            this.nombre_provincia = nombre_provincia;
        }
    }
}