using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Emergencia40Dias
    {
        private int id_emergencia_40_dias, valor_emergencia_40_dias;
        private string nombre_emergencia_40_dias;

        public int Valor_emergencia_40_dias
        {
            get { return valor_emergencia_40_dias; }
            set { valor_emergencia_40_dias = value; }
        }

        public int Id_emergencia_40_dias
        {
            get { return id_emergencia_40_dias; }
            set { id_emergencia_40_dias = value; }
        }        

        public string Nombre_emergencia_40_dias
        {
            get { return nombre_emergencia_40_dias; }
            set { nombre_emergencia_40_dias = value; }
        }

        public Emergencia40Dias(int id_emergencia_40_dias, string nombre_emergencia_40_dias, int valor_emergencia_40_dias)
        {
            this.id_emergencia_40_dias = id_emergencia_40_dias;
            this.nombre_emergencia_40_dias = nombre_emergencia_40_dias;
            this.valor_emergencia_40_dias = valor_emergencia_40_dias;
        }

        public Emergencia40Dias(int id_emergencia_40_dias, string nombre_emergencia_40_dias)
        {
            this.id_emergencia_40_dias = id_emergencia_40_dias;
            this.nombre_emergencia_40_dias = nombre_emergencia_40_dias;            
        }
    }
}