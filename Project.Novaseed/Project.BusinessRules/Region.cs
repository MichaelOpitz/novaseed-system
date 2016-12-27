using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Region
    {
        private int id_region;
        private string nombre_region;

        public string Nombre_region
        {
            get { return nombre_region; }
            set { nombre_region = value; }
        }

        public int Id_region
        {
            get { return id_region; }
            set { id_region = value; }
        }

        public Region(int id_region, string nombre_region)
        {
            this.id_region = id_region;
            this.nombre_region = nombre_region;
        }
    }
}