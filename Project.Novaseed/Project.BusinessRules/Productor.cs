using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Productor
    {
        private int id_productor;
        private string nombre_productor;

        public int Id_productor
        {
            get { return id_productor; }
            set { id_productor = value; }
        }        

        public string Nombre_productor
        {
            get { return nombre_productor; }
            set { nombre_productor = value; }
        }

        public Productor(int id_productor, string nombre_productor)
        {
            this.id_productor = id_productor;
            this.nombre_productor = nombre_productor;
        }
    }
}