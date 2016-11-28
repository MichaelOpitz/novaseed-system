using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Produccion
    {
        private int id_produccion, id_productor, id_ciudad, id_categoria_produccion, ano_produccion, ano_licencia, cantidad_estadistica;
        private double prod_cantidad_total, cantidad_productor, superficie_produccion, cosecha_produccion;
        private bool licencia_produccion;
        private string codigo_variedad, nombre_variedad, nombre_productor, nombre_ciudad, nombre_categoria_produccion, 
            nombre_destino, nombre_estadistica;

        public string Nombre_estadistica
        {
            get { return nombre_estadistica; }
            set { nombre_estadistica = value; }
        }

        public string Nombre_destino
        {
            get { return nombre_destino; }
            set { nombre_destino = value; }
        }


        public int Cantidad_estadistica
        {
            get { return cantidad_estadistica; }
            set { cantidad_estadistica = value; }
        }

        public int Ano_licencia
        {
            get { return ano_licencia; }
            set { ano_licencia = value; }
        }         

        public string Nombre_categoria_produccion
        {
            get { return nombre_categoria_produccion; }
            set { nombre_categoria_produccion = value; }
        }

        public string Nombre_ciudad
        {
            get { return nombre_ciudad; }
            set { nombre_ciudad = value; }
        }

        public string Nombre_productor
        {
            get { return nombre_productor; }
            set { nombre_productor = value; }
        }

        public string Nombre_variedad
        {
            get { return nombre_variedad; }
            set { nombre_variedad = value; }
        }

        public int Ano_produccion
        {
            get { return ano_produccion; }
            set { ano_produccion = value; }
        }

        public int Id_categoria_produccion
        {
            get { return id_categoria_produccion; }
            set { id_categoria_produccion = value; }
        }

        public int Id_ciudad
        {
            get { return id_ciudad; }
            set { id_ciudad = value; }
        }

        public int Id_productor
        {
            get { return id_productor; }
            set { id_productor = value; }
        }

        public int Id_produccion
        {
            get { return id_produccion; }
            set { id_produccion = value; }
        }       

        public double Cosecha_produccion
        {
            get { return cosecha_produccion; }
            set { cosecha_produccion = value; }
        }

        public double Superficie_produccion
        {
            get { return superficie_produccion; }
            set { superficie_produccion = value; }
        }

        public double Cantidad_productor
        {
            get { return cantidad_productor; }
            set { cantidad_productor = value; }
        }

        public double Prod_cantidad_total
        {
            get { return prod_cantidad_total; }
            set { prod_cantidad_total = value; }
        }        

        public bool Licencia_produccion
        {
            get { return licencia_produccion; }
            set { licencia_produccion = value; }
        }        

        public string Codigo_variedad
        {
            get { return codigo_variedad; }
            set { codigo_variedad = value; }
        }     

        /*
         * Constructor para obtener la tabla produccion seleccion ingresar         
         */
        public Produccion(string nombre_variedad, string codigo_variedad)
        {
            this.nombre_variedad = nombre_variedad;
            this.codigo_variedad = codigo_variedad;
        }

        /*
         * Constructor que selecciona de la tabla modificar produccion todos los atributos         
         */
        public Produccion(int id_productor, int id_ciudad, string codigo_variedad, int id_categoria_produccion, 
            double prod_cantidad_total, int ano_produccion, double cantidad_productor, double superficie_produccion,
            double cosecha_produccion, bool licencia_produccion)
        {
            this.id_productor = id_productor;
            this.id_ciudad = id_ciudad;
            this.codigo_variedad = codigo_variedad;
            this.id_categoria_produccion = id_categoria_produccion;
            this.prod_cantidad_total = prod_cantidad_total;
            this.ano_produccion = ano_produccion;
            this.cantidad_productor = cantidad_productor;
            this.superficie_produccion = superficie_produccion;
            this.cosecha_produccion = cosecha_produccion;
            this.licencia_produccion = licencia_produccion;
        }

        /*         
         * Constructor que actualiza la produccion
         */
        public Produccion(int id_productor, int id_ciudad, string codigo_variedad, int id_categoria_produccion,
            double prod_cantidad_total, double cantidad_productor, double superficie_produccion,
            double cosecha_produccion, bool licencia_produccion)
        {
            this.id_productor = id_productor;
            this.id_ciudad = id_ciudad;
            this.codigo_variedad = codigo_variedad;
            this.id_categoria_produccion = id_categoria_produccion;
            this.prod_cantidad_total = prod_cantidad_total;            
            this.cantidad_productor = cantidad_productor;
            this.superficie_produccion = superficie_produccion;
            this.cosecha_produccion = cosecha_produccion;
            this.licencia_produccion = licencia_produccion;
        }

        /*         
         * Constructor que filtra por productor, ciudad y/o categoria
         */
        public Produccion(string nombre_productor, string nombre_ciudad, string codigo_variedad, string nombre_categoria_produccion,
            double prod_cantidad_total, double cantidad_productor, double superficie_produccion,
            double cosecha_produccion, bool licencia_produccion)
        {
            this.nombre_productor = nombre_productor;
            this.nombre_ciudad = nombre_ciudad;
            this.codigo_variedad = codigo_variedad;
            this.nombre_categoria_produccion = nombre_categoria_produccion;
            this.prod_cantidad_total = prod_cantidad_total;
            this.cantidad_productor = cantidad_productor;
            this.superficie_produccion = superficie_produccion;
            this.cosecha_produccion = cosecha_produccion;
            this.licencia_produccion = licencia_produccion;
        }

        /*
         * Constructor para la funcion que obtiene el menor año del total de licencias         
         */
        public Produccion(int ano_licencia)
        {
            this.ano_licencia = ano_licencia;
        }

        /*         
         * Constructor obtiene las licencias activas
         */
        public Produccion(string nombre_productor, string nombre_ciudad, string codigo_variedad, string nombre_categoria_produccion,
            double prod_cantidad_total, double cantidad_productor, double superficie_produccion,
            double cosecha_produccion)
        {
            this.nombre_productor = nombre_productor;
            this.nombre_ciudad = nombre_ciudad;
            this.codigo_variedad = codigo_variedad;
            this.nombre_categoria_produccion = nombre_categoria_produccion;
            this.prod_cantidad_total = prod_cantidad_total;
            this.cantidad_productor = cantidad_productor;
            this.superficie_produccion = superficie_produccion;
            this.cosecha_produccion = cosecha_produccion;            
        }

        /*
         * Constructor para obtener las estadisticas de produccion
         */
        public Produccion(string nombre_estadistica, int cantidad_estadistica)
        {
            this.nombre_estadistica = nombre_estadistica;
            this.cantidad_estadistica = cantidad_estadistica;
        }
    }
}