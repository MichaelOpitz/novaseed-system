using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVPlantaEstructuraFollaje
    {
        private int id_planta_estructura_follaje;
        private string nombre_planta_estructura_follaje;

        public int Id_planta_estructura_follaje
        {
            get { return id_planta_estructura_follaje; }
            set { id_planta_estructura_follaje = value; }
        }        

        public string Nombre_planta_estructura_follaje
        {
            get { return nombre_planta_estructura_follaje; }
            set { nombre_planta_estructura_follaje = value; }
        }

        public UPOVPlantaEstructuraFollaje(int id_planta_estructura_follaje, string nombre_planta_estructura_follaje)
        {
            this.id_planta_estructura_follaje = id_planta_estructura_follaje;
            this.nombre_planta_estructura_follaje = nombre_planta_estructura_follaje;            
        }
    }
}