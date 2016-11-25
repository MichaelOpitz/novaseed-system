using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVBroteLongitudRamificacionesLaterales
    {
        private int id_brote_longitud_ramificaciones_laterales;
        private string nombre_brote_longitud_ramificaciones_laterales;

        public int Id_brote_longitud_ramificaciones_laterales
        {
            get { return id_brote_longitud_ramificaciones_laterales; }
            set { id_brote_longitud_ramificaciones_laterales = value; }
        }        

        public string Nombre_brote_longitud_ramificaciones_laterales
        {
            get { return nombre_brote_longitud_ramificaciones_laterales; }
            set { nombre_brote_longitud_ramificaciones_laterales = value; }
        }

        public UPOVBroteLongitudRamificacionesLaterales(int id_brote_longitud_ramificaciones_laterales,
            string nombre_brote_longitud_ramificaciones_laterales)
        {
            this.id_brote_longitud_ramificaciones_laterales = id_brote_longitud_ramificaciones_laterales;
            this.nombre_brote_longitud_ramificaciones_laterales = nombre_brote_longitud_ramificaciones_laterales;
        }
    }
}