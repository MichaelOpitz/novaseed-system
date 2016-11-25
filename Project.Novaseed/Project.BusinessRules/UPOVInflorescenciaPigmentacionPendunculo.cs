using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVInflorescenciaPigmentacionPendunculo
    {
        private int id_inflorescencia_pigmentacion_pendunculo;
        private string nombre_inflorescencia_pigmentacion_pendunculo;

        public int Id_inflorescencia_pigmentacion_pendunculo
        {
            get { return id_inflorescencia_pigmentacion_pendunculo; }
            set { id_inflorescencia_pigmentacion_pendunculo = value; }
        }        

        public string Nombre_inflorescencia_pigmentacion_pendunculo
        {
            get { return nombre_inflorescencia_pigmentacion_pendunculo; }
            set { nombre_inflorescencia_pigmentacion_pendunculo = value; }
        }

        public UPOVInflorescenciaPigmentacionPendunculo(int id_inflorescencia_pigmentacion_pendunculo,
            string nombre_inflorescencia_pigmentacion_pendunculo)
        {
            this.id_inflorescencia_pigmentacion_pendunculo = id_inflorescencia_pigmentacion_pendunculo;
            this.nombre_inflorescencia_pigmentacion_pendunculo = nombre_inflorescencia_pigmentacion_pendunculo;            
        }
    }
}