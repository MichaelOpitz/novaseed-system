using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Metribuzina
    {
        private int id_metribuzina, valor_metribuzina;
        private string nombre_metribuzina;

        public int Valor_metribuzina
        {
            get { return valor_metribuzina; }
            set { valor_metribuzina = value; }
        }

        public int Id_metribuzina
        {
            get { return id_metribuzina; }
            set { id_metribuzina = value; }
        }        

        public string Nombre_metribuzina
        {
            get { return nombre_metribuzina; }
            set { nombre_metribuzina = value; }
        }

        public Metribuzina(int id_metribuzina, string nombre_metribuzina)
        {
            this.id_metribuzina = id_metribuzina;
            this.nombre_metribuzina = nombre_metribuzina;            
        }
    }
}