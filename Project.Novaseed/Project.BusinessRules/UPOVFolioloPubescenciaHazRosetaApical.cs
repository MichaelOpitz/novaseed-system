using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVFolioloPubescenciaHazRosetaApical
    {
        private int id_foliolo_pubescencia_haz_roseta_apical;
        private string nombre_foliolo_pubescencia_haz_roseta_apical;

        public int Id_foliolo_pubescencia_haz_roseta_apical
        {
            get { return id_foliolo_pubescencia_haz_roseta_apical; }
            set { id_foliolo_pubescencia_haz_roseta_apical = value; }
        }        

        public string Nombre_foliolo_pubescencia_haz_roseta_apical
        {
            get { return nombre_foliolo_pubescencia_haz_roseta_apical; }
            set { nombre_foliolo_pubescencia_haz_roseta_apical = value; }
        }

        public UPOVFolioloPubescenciaHazRosetaApical(int id_foliolo_pubescencia_haz_roseta_apical,
            string nombre_foliolo_pubescencia_haz_roseta_apical)
        {
            this.id_foliolo_pubescencia_haz_roseta_apical = id_foliolo_pubescencia_haz_roseta_apical;
            this.nombre_foliolo_pubescencia_haz_roseta_apical = nombre_foliolo_pubescencia_haz_roseta_apical;            
        }
    }
}