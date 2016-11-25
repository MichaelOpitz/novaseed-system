using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVFolioloProfundidadNervios
    {
        private int id_foliolo_profundidad_nervios;
        private string nombre_foliolo_profundidad_nervios;

        public int Id_foliolo_profundidad_nervios
        {
            get { return id_foliolo_profundidad_nervios; }
            set { id_foliolo_profundidad_nervios = value; }
        }        

        public string Nombre_foliolo_profundidad_nervios
        {
            get { return nombre_foliolo_profundidad_nervios; }
            set { nombre_foliolo_profundidad_nervios = value; }
        }

        public UPOVFolioloProfundidadNervios(int id_foliolo_profundidad_nervios, string nombre_foliolo_profundidad_nervios)
        {
            this.id_foliolo_profundidad_nervios = id_foliolo_profundidad_nervios;
            this.nombre_foliolo_profundidad_nervios = nombre_foliolo_profundidad_nervios;            
        }
    }
}