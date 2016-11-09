using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Emergencia
    {
        private int id_emergencia, valor_emergencia;
        private string nombre_emergencia;

        public int Valor_emergencia
        {
            get { return valor_emergencia; }
            set { valor_emergencia = value; }
        }

        public int Id_emergencia
        {
            get { return id_emergencia; }
            set { id_emergencia = value; }
        }        

        public string Nombre_emergencia
        {
            get { return nombre_emergencia; }
            set { nombre_emergencia = value; }
        }

        public Emergencia(int id_emergencia, string nombre_emergencia)
        {
            this.id_emergencia = id_emergencia;
            this.nombre_emergencia = nombre_emergencia;            
        }
    }
}