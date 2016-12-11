using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Pais
    {
        private int id_pais;
        private string nombre_pais;

        public string Nombre_pais
        {
            get { return nombre_pais; }
            set { nombre_pais = value; }
        }

        public int Id_pais
        {
            get { return id_pais; }
            set { id_pais = value; }
        }

        public Pais(int id_pais, string nombre_pais)
        {
            this.id_pais = id_pais;
            this.nombre_pais = nombre_pais;
        }
    }
}