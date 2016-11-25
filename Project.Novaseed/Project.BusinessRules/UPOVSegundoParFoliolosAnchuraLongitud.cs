using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVSegundoParFoliolosAnchuraLongitud
    {
        private int id_segundo_par_foliolos_anchura_longitud;
        private string nombre_segundo_par_foliolos_anchura_longitud;

        public int Id_segundo_par_foliolos_anchura_longitud
        {
            get { return id_segundo_par_foliolos_anchura_longitud; }
            set { id_segundo_par_foliolos_anchura_longitud = value; }
        }        

        public string Nombre_segundo_par_foliolos_anchura_longitud
        {
            get { return nombre_segundo_par_foliolos_anchura_longitud; }
            set { nombre_segundo_par_foliolos_anchura_longitud = value; }
        }

        public UPOVSegundoParFoliolosAnchuraLongitud(int id_segundo_par_foliolos_anchura_longitud,
            string nombre_segundo_par_foliolos_anchura_longitud)
        {
            this.id_segundo_par_foliolos_anchura_longitud = id_segundo_par_foliolos_anchura_longitud;
            this.nombre_segundo_par_foliolos_anchura_longitud = nombre_segundo_par_foliolos_anchura_longitud;            
        }
    }
}