using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Brotacion
    {
        private int id_brotacion;
        private string nombre_brotacion;

        public int Id_brotacion
        {
            get { return id_brotacion; }
            set { id_brotacion = value; }
        }        

        public string Nombre_brotacion
        {
            get { return nombre_brotacion; }
            set { nombre_brotacion = value; }
        }

        public Brotacion(int id_brotacion, string nombre_brotacion)
        {
            this.id_brotacion = id_brotacion;
            this.nombre_brotacion = nombre_brotacion;
        }
    }
}