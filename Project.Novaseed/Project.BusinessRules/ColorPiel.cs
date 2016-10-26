using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class ColorPiel
    {
        private int id_color_piel, valor_color_piel;
        private string nombre_color_piel;

        public int Valor_color_piel
        {
            get { return valor_color_piel; }
            set { valor_color_piel = value; }
        }

        public int Id_color_piel
        {
            get { return id_color_piel; }
            set { id_color_piel = value; }
        }        

        public string Nombre_color_piel
        {
            get { return nombre_color_piel; }
            set { nombre_color_piel = value; }
        }

        public ColorPiel(int id_color_piel, string nombre_color_piel, int valor_color_piel)
        {
            this.id_color_piel = id_color_piel;
            this.nombre_color_piel = nombre_color_piel;
            this.valor_color_piel = valor_color_piel;
        }

        public ColorPiel(int id_color_piel, string nombre_color_piel)
        {
            this.id_color_piel = id_color_piel;
            this.nombre_color_piel = nombre_color_piel;            
        }
    }
}