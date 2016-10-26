using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class TipoHoja
    {
        private int id_tipo_hoja, valor_tipo_hoja;
        private string nombre_tipo_hoja;

        public int Valor_tipo_hoja
        {
            get { return valor_tipo_hoja; }
            set { valor_tipo_hoja = value; }
        }

        public int Id_tipo_hoja
        {
            get { return id_tipo_hoja; }
            set { id_tipo_hoja = value; }
        }        

        public string Nombre_tipo_hoja
        {
            get { return nombre_tipo_hoja; }
            set { nombre_tipo_hoja = value; }
        }

        public TipoHoja(int id_tipo_hoja, string nombre_tipo_hoja, int valor_tipo_hoja)
        {
            this.id_tipo_hoja = id_tipo_hoja;
            this.nombre_tipo_hoja = nombre_tipo_hoja;
            this.valor_tipo_hoja = valor_tipo_hoja;
        }

        public TipoHoja(int id_tipo_hoja, string nombre_tipo_hoja)
        {
            this.id_tipo_hoja = id_tipo_hoja;
            this.nombre_tipo_hoja = nombre_tipo_hoja;            
        }
    }
}