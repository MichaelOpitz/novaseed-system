using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class ResistenciaVariedad
    {
        private int id_resistencia_variedad, nivel_resistencia_variedad;
        private string nombre_resistencia_variedad;

        public int Nivel_resistencia_variedad
        {
            get { return nivel_resistencia_variedad; }
            set { nivel_resistencia_variedad = value; }
        }

        public int Id_resistencia_variedad
        {
            get { return id_resistencia_variedad; }
            set { id_resistencia_variedad = value; }
        }        

        public string Nombre_resistencia_variedad
        {
            get { return nombre_resistencia_variedad; }
            set { nombre_resistencia_variedad = value; }
        }

        public ResistenciaVariedad(int id_resistencia_variedad, string nombre_resistencia_variedad)
        {
            this.id_resistencia_variedad = id_resistencia_variedad;
            this.nombre_resistencia_variedad = nombre_resistencia_variedad;
        }
    }
}