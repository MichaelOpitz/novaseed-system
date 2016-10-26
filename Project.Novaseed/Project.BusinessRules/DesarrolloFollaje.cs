using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class DesarrolloFollaje
    {
        private int id_desarrollo_follaje, valor_desarrollo_follaje;
        private string nombre_desarrollo_follaje;

        public int Valor_desarrollo_follaje
        {
            get { return valor_desarrollo_follaje; }
            set { valor_desarrollo_follaje = value; }
        }

        public int Id_desarrollo_follaje
        {
            get { return id_desarrollo_follaje; }
            set { id_desarrollo_follaje = value; }
        }        

        public string Nombre_desarrollo_follaje
        {
            get { return nombre_desarrollo_follaje; }
            set { nombre_desarrollo_follaje = value; }
        }

        public DesarrolloFollaje(int id_desarrollo_follaje, string nombre_desarrollo_follaje, int valor_desarrollo_follaje)
        {
            this.id_desarrollo_follaje = id_desarrollo_follaje;
            this.nombre_desarrollo_follaje = nombre_desarrollo_follaje;
            this.valor_desarrollo_follaje = valor_desarrollo_follaje;
        }

        public DesarrolloFollaje(int id_desarrollo_follaje, string nombre_desarrollo_follaje)
        {
            this.id_desarrollo_follaje = id_desarrollo_follaje;
            this.nombre_desarrollo_follaje = nombre_desarrollo_follaje;            
        }
    }
}