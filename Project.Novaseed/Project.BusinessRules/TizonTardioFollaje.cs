using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class TizonTardioFollaje
    {
        private int id_tizon_tardio_follaje, valor_tizon_tardio_follaje;
        private string nombre_tizon_tardio_follaje;

        public int Valor_tizon_tardio_follaje
        {
            get { return valor_tizon_tardio_follaje; }
            set { valor_tizon_tardio_follaje = value; }
        }

        public int Id_tizon_tardio_follaje
        {
            get { return id_tizon_tardio_follaje; }
            set { id_tizon_tardio_follaje = value; }
        }        

        public string Nombre_tizon_tardio_follaje
        {
            get { return nombre_tizon_tardio_follaje; }
            set { nombre_tizon_tardio_follaje = value; }
        }

        public TizonTardioFollaje(int id_tizon_tardio_follaje, string nombre_tizon_tardio_follaje)
        {
            this.id_tizon_tardio_follaje = id_tizon_tardio_follaje;
            this.nombre_tizon_tardio_follaje = nombre_tizon_tardio_follaje;            
        }
    }
}