using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class FacilidadMuerte
    {
        private int id_facilidad_muerte, valor_facilidad_muerte;
        private string nombre_facilidad_muerte;

        public int Valor_facilidad_muerte
        {
            get { return valor_facilidad_muerte; }
            set { valor_facilidad_muerte = value; }
        }

        public int Id_facilidad_muerte
        {
            get { return id_facilidad_muerte; }
            set { id_facilidad_muerte = value; }
        }        

        public string Nombre_facilidad_muerte
        {
            get { return nombre_facilidad_muerte; }
            set { nombre_facilidad_muerte = value; }
        }

        public FacilidadMuerte(int id_facilidad_muerte, string nombre_facilidad_muerte)
        {
            this.id_facilidad_muerte = id_facilidad_muerte;
            this.nombre_facilidad_muerte = nombre_facilidad_muerte;
        }
    }
}