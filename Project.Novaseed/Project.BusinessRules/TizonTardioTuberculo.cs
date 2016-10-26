using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class TizonTardioTuberculo
    {
        private int id_tizon_tardio_tuberculo, valor_tizon_tardio_tuberculo;
        private string nombre_tizon_tardio_tuberculo;

        public int Valor_tizon_tardio_tuberculo
        {
            get { return valor_tizon_tardio_tuberculo; }
            set { valor_tizon_tardio_tuberculo = value; }
        }

        public int Id_tizon_tardio_tuberculo
        {
            get { return id_tizon_tardio_tuberculo; }
            set { id_tizon_tardio_tuberculo = value; }
        }        

        public string Nombre_tizon_tardio_tuberculo
        {
            get { return nombre_tizon_tardio_tuberculo; }
            set { nombre_tizon_tardio_tuberculo = value; }
        }

        public TizonTardioTuberculo(int id_tizon_tardio_tuberculo, string nombre_tizon_tardio_tuberculo, int valor_tizon_tardio_tuberculo)
        {
            this.id_tizon_tardio_tuberculo = id_tizon_tardio_tuberculo;
            this.nombre_tizon_tardio_tuberculo = nombre_tizon_tardio_tuberculo;
            this.valor_tizon_tardio_tuberculo = valor_tizon_tardio_tuberculo;
        }

        public TizonTardioTuberculo(int id_tizon_tardio_tuberculo, string nombre_tizon_tardio_tuberculo)
        {
            this.id_tizon_tardio_tuberculo = id_tizon_tardio_tuberculo;
            this.nombre_tizon_tardio_tuberculo = nombre_tizon_tardio_tuberculo;            
        }
    }
}