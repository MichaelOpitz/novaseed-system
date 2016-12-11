using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Cargo
    {
        private int id_cargo;
        private string nombre_cargo;

        public string Nombre_cargo
        {
            get { return nombre_cargo; }
            set { nombre_cargo = value; }
        }

        public int Id_cargo
        {
            get { return id_cargo; }
            set { id_cargo = value; }
        }

        public Cargo(int id_cargo, string nombre_cargo)
        {
            this.id_cargo = id_cargo;
            this.nombre_cargo = nombre_cargo;
        }
    }
}