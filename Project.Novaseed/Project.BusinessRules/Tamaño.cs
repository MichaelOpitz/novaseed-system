using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Tamaño
    {
        private int id_tamaño, valor_tamaño;
        private string nombre_tamaño;

        public int Valor_tamaño
        {
            get { return valor_tamaño; }
            set { valor_tamaño = value; }
        }

        public int Id_tamaño
        {
            get { return id_tamaño; }
            set { id_tamaño = value; }
        }        

        public string Nombre_tamaño
        {
            get { return nombre_tamaño; }
            set { nombre_tamaño = value; }
        }

        public Tamaño(int id_tamaño, string nombre_tamaño)
        {
            this.id_tamaño = id_tamaño;
            this.nombre_tamaño = nombre_tamaño;            
        }
    }
}