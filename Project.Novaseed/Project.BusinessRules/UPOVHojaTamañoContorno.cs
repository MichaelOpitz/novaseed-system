using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVHojaTamañoContorno
    {
        private int id_hoja_tamaño_contorno;
        private string nombre_hoja_tamaño_contorno;

        public int Id_hoja_tamaño_contorno
        {
            get { return id_hoja_tamaño_contorno; }
            set { id_hoja_tamaño_contorno = value; }
        }        

        public string Nombre_hoja_tamaño_contorno
        {
            get { return nombre_hoja_tamaño_contorno; }
            set { nombre_hoja_tamaño_contorno = value; }
        }

        public UPOVHojaTamañoContorno(int id_hoja_tamaño_contorno, string nombre_hoja_tamaño_contorno)
        {
            this.id_hoja_tamaño_contorno = id_hoja_tamaño_contorno;
            this.nombre_hoja_tamaño_contorno = nombre_hoja_tamaño_contorno;            
        }
    }
}