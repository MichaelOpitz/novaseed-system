using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVCorolaFlorIntensidadPigmentacionCaraInterna
    {
        private int id_corola_flor_intensidad_pigmentacion_cara_interna;
        private string nombre_corola_flor_intensidad_pigmentacion_cara_interna;

        public int Id_corola_flor_intensidad_pigmentacion_cara_interna
        {
            get { return id_corola_flor_intensidad_pigmentacion_cara_interna; }
            set { id_corola_flor_intensidad_pigmentacion_cara_interna = value; }
        }        

        public string Nombre_corola_flor_intensidad_pigmentacion_cara_interna
        {
            get { return nombre_corola_flor_intensidad_pigmentacion_cara_interna; }
            set { nombre_corola_flor_intensidad_pigmentacion_cara_interna = value; }
        }

        public UPOVCorolaFlorIntensidadPigmentacionCaraInterna(int id_corola_flor_intensidad_pigmentacion_cara_interna,
            string nombre_corola_flor_intensidad_pigmentacion_cara_interna)
        {
            this.id_corola_flor_intensidad_pigmentacion_cara_interna = id_corola_flor_intensidad_pigmentacion_cara_interna;
            this.nombre_corola_flor_intensidad_pigmentacion_cara_interna = nombre_corola_flor_intensidad_pigmentacion_cara_interna;            
        }
    }
}