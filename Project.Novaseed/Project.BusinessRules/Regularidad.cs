using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Regularidad
    {
        private int id_regularidad, valor_regularidad;
        private string nombre_regularidad;

        public int Valor_regularidad
        {
            get { return valor_regularidad; }
            set { valor_regularidad = value; }
        }

        public int Id_regularidad
        {
            get { return id_regularidad; }
            set { id_regularidad = value; }
        }        

        public string Nombre_regularidad
        {
            get { return nombre_regularidad; }
            set { nombre_regularidad = value; }
        }

        public Regularidad(int id_regularidad, string nombre_regularidad, int valor_regularidad)
        {
            this.id_regularidad = id_regularidad;
            this.nombre_regularidad = nombre_regularidad;
            this.valor_regularidad = valor_regularidad;
        }

        public Regularidad(int id_regularidad, string nombre_regularidad)
        {
            this.id_regularidad = id_regularidad;
            this.nombre_regularidad = nombre_regularidad;            
        }
    }
}