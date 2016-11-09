using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class ColorCarne
    {
        private int id_color_carne, valor_color_carne;
        private string nombre_color_carne;       

        public int Valor_color_carne
        {
            get { return valor_color_carne; }
            set { valor_color_carne = value; }
        }

        public int Id_color_carne
        {
            get { return id_color_carne; }
            set { id_color_carne = value; }
        }        

        public string Nombre_color_carne
        {
            get { return nombre_color_carne; }
            set { nombre_color_carne = value; }
        }

        public ColorCarne(int id_color_carne, string nombre_color_carne)
        {
            this.id_color_carne = id_color_carne;
            this.nombre_color_carne = nombre_color_carne;
        }
    }
}