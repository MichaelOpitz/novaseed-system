using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVFoliolosTerminalesCoalescencia
    {
        private int id_foliolos_terminales_coalescencia;
        private string nombre_foliolos_terminales_coalescencia;

        public int Id_foliolos_terminales_coalescencia
        {
            get { return id_foliolos_terminales_coalescencia; }
            set { id_foliolos_terminales_coalescencia = value; }
        }        

        public string Nombre_foliolos_terminales_coalescencia
        {
            get { return nombre_foliolos_terminales_coalescencia; }
            set { nombre_foliolos_terminales_coalescencia = value; }
        }

        public UPOVFoliolosTerminalesCoalescencia(int id_foliolos_terminales_coalescencia,
            string nombre_foliolos_terminales_coalescencia)
        {
            this.id_foliolos_terminales_coalescencia = id_foliolos_terminales_coalescencia;
            this.nombre_foliolos_terminales_coalescencia = nombre_foliolos_terminales_coalescencia;            
        }
    }
}