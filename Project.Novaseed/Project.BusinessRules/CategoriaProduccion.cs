using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class CategoriaProduccion
    {
        private int id_categoria_produccion;
        private string nombre_categoria_produccion;

        public int Id_categoria_produccion
        {
            get { return id_categoria_produccion; }
            set { id_categoria_produccion = value; }
        }        

        public string Nombre_categoria_produccion
        {
            get { return nombre_categoria_produccion; }
            set { nombre_categoria_produccion = value; }
        }

        public CategoriaProduccion(int id_categoria_produccion, string nombre_categoria_produccion)
        {
            this.id_categoria_produccion = id_categoria_produccion;
            this.nombre_categoria_produccion = nombre_categoria_produccion;
        }
    }
}