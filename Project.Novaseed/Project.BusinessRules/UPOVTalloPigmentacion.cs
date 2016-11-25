using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVTalloPigmentacion
    {
        private int id_tallo_pigmentacion;
        private string nombre_tallo_pigmentacion;

        public int Id_tallo_pigmentacion
        {
            get { return id_tallo_pigmentacion; }
            set { id_tallo_pigmentacion = value; }
        }        

        public string Nombre_tallo_pigmentacion
        {
            get { return nombre_tallo_pigmentacion; }
            set { nombre_tallo_pigmentacion = value; }
        }

        public UPOVTalloPigmentacion(int id_tallo_pigmentacion, string nombre_tallo_pigmentacion)
        {
            this.id_tallo_pigmentacion = id_tallo_pigmentacion;
            this.nombre_tallo_pigmentacion = nombre_tallo_pigmentacion;            
        }
    }
}