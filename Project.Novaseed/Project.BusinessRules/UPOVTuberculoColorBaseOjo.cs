using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class UPOVTuberculoColorBaseOjo
    {
        private int id_tuberculo_color_base_ojo;
        private string nombre_tuberculo_color_base_ojo;

        public string Nombre_tuberculo_color_base_ojo
        {
            get { return nombre_tuberculo_color_base_ojo; }
            set { nombre_tuberculo_color_base_ojo = value; }
        }

        public int Id_tuberculo_color_base_ojo
        {
            get { return id_tuberculo_color_base_ojo; }
            set { id_tuberculo_color_base_ojo = value; }
        }

        public UPOVTuberculoColorBaseOjo(int id_tuberculo_color_base_ojo, string nombre_tuberculo_color_base_ojo)
        {
            this.id_tuberculo_color_base_ojo = id_tuberculo_color_base_ojo;
            this.nombre_tuberculo_color_base_ojo = nombre_tuberculo_color_base_ojo;            
        }
    }
}