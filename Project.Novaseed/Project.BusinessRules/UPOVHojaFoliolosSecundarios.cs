using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVHojaFoliolosSecundarios
    {
        private int id_hoja_foliolos_secundarios;
        private string nombre_hoja_foliolos_secundarios;

        public int Id_hoja_foliolos_secundarios
        {
            get { return id_hoja_foliolos_secundarios; }
            set { id_hoja_foliolos_secundarios = value; }
        }        

        public string Nombre_hoja_foliolos_secundarios
        {
            get { return nombre_hoja_foliolos_secundarios; }
            set { nombre_hoja_foliolos_secundarios = value; }
        }

        public UPOVHojaFoliolosSecundarios(int id_hoja_foliolos_secundarios, string nombre_hoja_foliolos_secundarios)
        {
            this.id_hoja_foliolos_secundarios = id_hoja_foliolos_secundarios;
            this.nombre_hoja_foliolos_secundarios = nombre_hoja_foliolos_secundarios;            
        }
    }
}