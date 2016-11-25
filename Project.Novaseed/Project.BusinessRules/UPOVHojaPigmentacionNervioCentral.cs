using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVHojaPigmentacionNervioCentral
    {
        private int id_hoja_pigmentacion_nervio_central;
        private string nombre_hoja_pigmentacion_nervio_central;

        public int Id_hoja_pigmentacion_nervio_central
        {
            get { return id_hoja_pigmentacion_nervio_central; }
            set { id_hoja_pigmentacion_nervio_central = value; }
        }        

        public string Nombre_hoja_pigmentacion_nervio_central
        {
            get { return nombre_hoja_pigmentacion_nervio_central; }
            set { nombre_hoja_pigmentacion_nervio_central = value; }
        }

        public UPOVHojaPigmentacionNervioCentral(int id_hoja_pigmentacion_nervio_central, 
            string nombre_hoja_pigmentacion_nervio_central)
        {
            this.id_hoja_pigmentacion_nervio_central = id_hoja_pigmentacion_nervio_central;
            this.nombre_hoja_pigmentacion_nervio_central = nombre_hoja_pigmentacion_nervio_central;            
        }
    }
}