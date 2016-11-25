using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVPlantaEpocaMadurez
    {
        private int id_planta_epoca_madurez;
        private string nombre_planta_epoca_madurez;

        public int Id_planta_epoca_madurez
        {
            get { return id_planta_epoca_madurez; }
            set { id_planta_epoca_madurez = value; }
        }        

        public string Nombre_planta_epoca_madurez
        {
            get { return nombre_planta_epoca_madurez; }
            set { nombre_planta_epoca_madurez = value; }
        }

        public UPOVPlantaEpocaMadurez(int id_planta_epoca_madurez, string nombre_planta_epoca_madurez)
        {
            this.id_planta_epoca_madurez = id_planta_epoca_madurez;
            this.nombre_planta_epoca_madurez = nombre_planta_epoca_madurez;
        }
    }
}