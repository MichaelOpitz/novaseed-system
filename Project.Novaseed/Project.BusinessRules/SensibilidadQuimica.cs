using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class SensibilidadQuimica
    {
        private int id_sensibilidad_quimica, valor_sensibilidad_quimica;
        private string nombre_sensibilidad_quimica;

        public int Valor_sensibilidad_quimica
        {
            get { return valor_sensibilidad_quimica; }
            set { valor_sensibilidad_quimica = value; }
        }

        public int Id_sensibilidad_quimica
        {
            get { return id_sensibilidad_quimica; }
            set { id_sensibilidad_quimica = value; }
        }        

        public string Nombre_sensibilidad_quimica
        {
            get { return nombre_sensibilidad_quimica; }
            set { nombre_sensibilidad_quimica = value; }
        }

        public SensibilidadQuimica(int id_sensibilidad_quimica, string nombre_sensibilidad_quimica)
        {
            this.id_sensibilidad_quimica = id_sensibilidad_quimica;
            this.nombre_sensibilidad_quimica = nombre_sensibilidad_quimica;
        }
    }
}