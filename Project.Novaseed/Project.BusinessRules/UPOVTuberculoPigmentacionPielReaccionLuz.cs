using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVTuberculoPigmentacionPielReaccionLuz
    {
        private int id_tuberculo_pigmentacion_piel_reaccion_luz;
        private string nombre_tuberculo_pigmentacion_piel_reaccion_luz;

        public string Nombre_tuberculo_pigmentacion_piel_reaccion_luz
        {
            get { return nombre_tuberculo_pigmentacion_piel_reaccion_luz; }
            set { nombre_tuberculo_pigmentacion_piel_reaccion_luz = value; }
        }

        public int Id_tuberculo_pigmentacion_piel_reaccion_luz
        {
            get { return id_tuberculo_pigmentacion_piel_reaccion_luz; }
            set { id_tuberculo_pigmentacion_piel_reaccion_luz = value; }
        }

        public UPOVTuberculoPigmentacionPielReaccionLuz(int id_tuberculo_pigmentacion_piel_reaccion_luz,
            string nombre_tuberculo_pigmentacion_piel_reaccion_luz)
        {
            this.id_tuberculo_pigmentacion_piel_reaccion_luz = id_tuberculo_pigmentacion_piel_reaccion_luz;
            this.nombre_tuberculo_pigmentacion_piel_reaccion_luz = nombre_tuberculo_pigmentacion_piel_reaccion_luz;            
        }
    }
}