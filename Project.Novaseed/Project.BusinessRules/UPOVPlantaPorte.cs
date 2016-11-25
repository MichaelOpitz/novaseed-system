using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVPlantaPorte
    {
        private int id_planta_porte;
        private string nombre_planta_porte;

        public int Id_planta_porte
        {
            get { return id_planta_porte; }
            set { id_planta_porte = value; }
        }        

        public string Nombre_planta_porte
        {
            get { return nombre_planta_porte; }
            set { nombre_planta_porte = value; }
        }

        public UPOVPlantaPorte(int id_planta_porte, string nombre_planta_porte)
        {
            this.id_planta_porte = id_planta_porte;
            this.nombre_planta_porte = nombre_planta_porte;            
        }
    }
}