using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVHojaApertura
    {
        private int id_hoja_apertura;
        private string nombre_hoja_apertura;

        public int Id_hoja_apertura
        {
            get { return id_hoja_apertura; }
            set { id_hoja_apertura = value; }
        }        

        public string Nombre_hoja_apertura
        {
            get { return nombre_hoja_apertura; }
            set { nombre_hoja_apertura = value; }
        }

        public UPOVHojaApertura(int id_hoja_apertura, string nombre_hoja_apertura)
        {
            this.id_hoja_apertura = id_hoja_apertura;
            this.nombre_hoja_apertura = nombre_hoja_apertura;            
        }
    }
}