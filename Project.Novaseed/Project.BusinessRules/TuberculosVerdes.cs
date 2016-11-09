using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class TuberculosVerdes
    {
        private int id_tuberculos_verdes, valor_tuberculos_verdes;
        private string nombre_tuberculos_verdes;

        public int Valor_tuberculos_verdes
        {
            get { return valor_tuberculos_verdes; }
            set { valor_tuberculos_verdes = value; }
        }

        public int Id_tuberculos_verdes
        {
            get { return id_tuberculos_verdes; }
            set { id_tuberculos_verdes = value; }
        }        

        public string Nombre_tuberculos_verdes
        {
            get { return nombre_tuberculos_verdes; }
            set { nombre_tuberculos_verdes = value; }
        }

        public TuberculosVerdes(int id_tuberculos_verdes, string nombre_tuberculos_verdes)
        {
            this.id_tuberculos_verdes = id_tuberculos_verdes;
            this.nombre_tuberculos_verdes = nombre_tuberculos_verdes;            
        }
    }
}