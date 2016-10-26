using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class DistribucionCalibre
    {
        private int id_distribucion_calibre, valor_distribucion_calibre;
        private string nombre_distribucion_calibre;

        public int Valor_distribucion_calibre
        {
            get { return valor_distribucion_calibre; }
            set { valor_distribucion_calibre = value; }
        }

        public int Id_distribucion_calibre
        {
            get { return id_distribucion_calibre; }
            set { id_distribucion_calibre = value; }
        }        

        public string Nombre_distribucion_calibre
        {
            get { return nombre_distribucion_calibre; }
            set { nombre_distribucion_calibre = value; }
        }

        public DistribucionCalibre(int id_distribucion_calibre, string nombre_distribucion_calibre, int valor_distribucion_calibre)
        {
            this.id_distribucion_calibre = id_distribucion_calibre;
            this.nombre_distribucion_calibre = nombre_distribucion_calibre;
            this.valor_distribucion_calibre = valor_distribucion_calibre;
        }

        public DistribucionCalibre(int id_distribucion_calibre, string nombre_distribucion_calibre)
        {
            this.id_distribucion_calibre = id_distribucion_calibre;
            this.nombre_distribucion_calibre = nombre_distribucion_calibre;            
        }
    }
}