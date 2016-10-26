using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Destino
    {
        private int id_destino;
        private string nombre_destino;

        public int Id_destino
        {
            get { return id_destino; }
            set { id_destino = value; }
        }        

        public string Nombre_destino
        {
            get { return nombre_destino; }
            set { nombre_destino = value; }
        }

        public Destino(int id_destino, string nombre_destino)
        {
            this.id_destino = id_destino;
            this.nombre_destino = nombre_destino;
        }
    }
}