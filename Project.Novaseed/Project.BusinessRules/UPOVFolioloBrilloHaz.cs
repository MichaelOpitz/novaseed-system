using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVFolioloBrilloHaz
    {
        private int id_foliolo_brillo_haz;
        private string nombre_foliolo_brillo_haz;

        public int Id_foliolo_brillo_haz
        {
            get { return id_foliolo_brillo_haz; }
            set { id_foliolo_brillo_haz = value; }
        }        

        public string Nombre_foliolo_brillo_haz
        {
            get { return nombre_foliolo_brillo_haz; }
            set { nombre_foliolo_brillo_haz = value; }
        }

        public UPOVFolioloBrilloHaz(int id_foliolo_brillo_haz, string nombre_foliolo_brillo_haz)
        {
            this.id_foliolo_brillo_haz = id_foliolo_brillo_haz;
            this.nombre_foliolo_brillo_haz = nombre_foliolo_brillo_haz;            
        }
    }
}