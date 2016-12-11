using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Sexo
    {
        private int id_sexo;
        private string nombre_sexo;

        public string Nombre_sexo
        {
            get { return nombre_sexo; }
            set { nombre_sexo = value; }
        }

        public int Id_sexo
        {
            get { return id_sexo; }
            set { id_sexo = value; }
        }

        public Sexo(int id_sexo, string nombre_sexo)
        {
            this.id_sexo = id_sexo;
            this.nombre_sexo = nombre_sexo;  
        }
    }
}