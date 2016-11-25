using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVBotonFloralPigmentacion
    {
        private int id_boton_floral_pigmentacion;
        private string nombre_boton_floral_pigmentacion;

        public int Id_boton_floral_pigmentacion
        {
            get { return id_boton_floral_pigmentacion; }
            set { id_boton_floral_pigmentacion = value; }
        }        

        public string Nombre_boton_floral_pigmentacion
        {
            get { return nombre_boton_floral_pigmentacion; }
            set { nombre_boton_floral_pigmentacion = value; }
        }

        public UPOVBotonFloralPigmentacion(int id_boton_floral_pigmentacion, string nombre_boton_floral_pigmentacion)
        {
            this.id_boton_floral_pigmentacion = id_boton_floral_pigmentacion;
            this.nombre_boton_floral_pigmentacion = nombre_boton_floral_pigmentacion;
        }
    }
}