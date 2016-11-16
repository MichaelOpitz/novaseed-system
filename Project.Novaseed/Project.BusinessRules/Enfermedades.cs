using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Enfermedades
    {
        private int id_enfermedad;
        private string nombre_enfermedad;

        public string Nombre_enfermedad
        {
            get { return nombre_enfermedad; }
            set { nombre_enfermedad = value; }
        }

        public int Id_enfermedad
        {
            get { return id_enfermedad; }
            set { id_enfermedad = value; }
        }

        public Enfermedades(int id_enfermedad, string nombre_enfermedad)
        {
            this.id_enfermedad = id_enfermedad;
            this.nombre_enfermedad = nombre_enfermedad;
        }
    }
}