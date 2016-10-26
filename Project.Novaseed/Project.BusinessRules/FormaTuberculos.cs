using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class FormaTuberculos
    {
        private int id_forma, valor_forma;
        private string nombre_forma;

        public int Valor_forma
        {
            get { return valor_forma; }
            set { valor_forma = value; }
        }

        public int Id_forma
        {
            get { return id_forma; }
            set { id_forma = value; }
        }        

        public string Nombre_forma
        {
            get { return nombre_forma; }
            set { nombre_forma = value; }
        }

        public FormaTuberculos(int id_forma, string nombre_forma, int valor_forma)
        {
            this.id_forma = id_forma;
            this.nombre_forma = nombre_forma;
            this.valor_forma = valor_forma;
        }

        public FormaTuberculos(int id_forma, string nombre_forma)
        {
            this.id_forma = id_forma;
            this.nombre_forma = nombre_forma;            
        }
    }
}