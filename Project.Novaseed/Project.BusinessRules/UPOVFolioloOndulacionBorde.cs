using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVFolioloOndulacionBorde
    {
        private int id_foliolo_ondulacion_borde;
        private string nombre_foliolo_ondulacion_borde;

        public int Id_foliolo_ondulacion_borde
        {
            get { return id_foliolo_ondulacion_borde; }
            set { id_foliolo_ondulacion_borde = value; }
        }        

        public string Nombre_foliolo_ondulacion_borde
        {
            get { return nombre_foliolo_ondulacion_borde; }
            set { nombre_foliolo_ondulacion_borde = value; }
        }

        public UPOVFolioloOndulacionBorde(int id_foliolo_ondulacion_borde, string nombre_foliolo_ondulacion_borde)
        {
            this.id_foliolo_ondulacion_borde = id_foliolo_ondulacion_borde;
            this.nombre_foliolo_ondulacion_borde = nombre_foliolo_ondulacion_borde;            
        }
    }
}