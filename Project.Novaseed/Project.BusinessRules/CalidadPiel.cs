using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class CalidadPiel
    {
        private int id_calidad_piel, valor_calidad_piel;
        private string nombre_calidad_piel;

        public int Valor_calidad_piel
        {
            get { return valor_calidad_piel; }
            set { valor_calidad_piel = value; }
        }

        public int Id_calidad_piel
        {
            get { return id_calidad_piel; }
            set { id_calidad_piel = value; }
        }        

        public string Nombre_calidad_piel
        {
            get { return nombre_calidad_piel; }
            set { nombre_calidad_piel = value; }
        }

        public CalidadPiel(int id_calidad_piel, string nombre_calidad_piel)
        {
            this.id_calidad_piel = id_calidad_piel;
            this.nombre_calidad_piel = nombre_calidad_piel;            
        }
    }
}