using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVPlantaFrecuenciaFlores
    {
        private int id_planta_frecuencia_flores;
        private string nombre_planta_frecuencia_flores;

        public int Id_planta_frecuencia_flores
        {
            get { return id_planta_frecuencia_flores; }
            set { id_planta_frecuencia_flores = value; }
        }        

        public string Nombre_planta_frecuencia_flores
        {
            get { return nombre_planta_frecuencia_flores; }
            set { nombre_planta_frecuencia_flores = value; }
        }

        public UPOVPlantaFrecuenciaFlores(int id_planta_frecuencia_flores, string nombre_planta_frecuencia_flores)
        {
            this.id_planta_frecuencia_flores = id_planta_frecuencia_flores;
            this.nombre_planta_frecuencia_flores = nombre_planta_frecuencia_flores;            
        }
    }
}