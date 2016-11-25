using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVPlantaAltura
    {
        private int id_planta_altura;
        private string nombre_planta_altura;

        public int Id_planta_altura
        {
            get { return id_planta_altura; }
            set { id_planta_altura = value; }
        }        

        public string Nombre_planta_altura
        {
            get { return nombre_planta_altura; }
            set { nombre_planta_altura = value; }
        }

        public UPOVPlantaAltura(int id_planta_altura, string nombre_planta_altura)
        {
            this.id_planta_altura = id_planta_altura;
            this.nombre_planta_altura = nombre_planta_altura;            
        }
    }
}