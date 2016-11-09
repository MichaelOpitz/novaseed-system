using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class ProfundidadOjo
    {
        private int id_profundidad, valor_profundidad_ojo;
        private string profundidad_ojo;

        public int Valor_profundidad_ojo
        {
            get { return valor_profundidad_ojo; }
            set { valor_profundidad_ojo = value; }
        }

        public int Id_profundidad
        {
            get { return id_profundidad; }
            set { id_profundidad = value; }
        }        

        public string Profundidad_ojo
        {
            get { return profundidad_ojo; }
            set { profundidad_ojo = value; }
        }

        public ProfundidadOjo(int id_profundidad, string profundidad_ojo)
        {
            this.id_profundidad = id_profundidad;
            this.profundidad_ojo = profundidad_ojo;            
        }
    }
}