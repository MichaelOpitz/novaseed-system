using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class NumeroTuberculos
    {
        private int id_numero_tuberculos, valor_numero_tuberculos;
        private string nombre_numero_tuberculos;

        public int Valor_numero_tuberculos
        {
            get { return valor_numero_tuberculos; }
            set { valor_numero_tuberculos = value; }
        }

        public int Id_numero_tuberculos
        {
            get { return id_numero_tuberculos; }
            set { id_numero_tuberculos = value; }
        }        

        public string Nombre_numero_tuberculos
        {
            get { return nombre_numero_tuberculos; }
            set { nombre_numero_tuberculos = value; }
        }

        public NumeroTuberculos(int id_numero_tuberculos, string nombre_numero_tuberculos)
        {
            this.id_numero_tuberculos = id_numero_tuberculos;
            this.nombre_numero_tuberculos = nombre_numero_tuberculos;            
        }
    }
}