using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogProduccion
    {
        /*
         * Actualizar la produccion, devuelve 1 si actualizó, 0 en caso contrario
         * Modificar
         */
        public int UpdateProduccion(Produccion p)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            string sql = "produccionActualizar";
            bd.CreateCommandSP(sql);
            bd.CreateParameter("@id_productor", DbType.Int32, p.Id_productor);
            bd.CreateParameter("@id_ciudad", DbType.Int32, p.Id_ciudad);
            bd.CreateParameter("@codigo_variedad", DbType.String, p.Codigo_variedad);
            bd.CreateParameter("@id_categoria_produccion", DbType.Int32, p.Id_categoria_produccion);
            bd.CreateParameter("@prod_cantidad_total", DbType.Double, p.Prod_cantidad_total);            
            bd.CreateParameter("@cantidad_productor", DbType.Double, p.Cantidad_productor);
            bd.CreateParameter("@superficie_produccion", DbType.Double, p.Superficie_produccion);
            bd.CreateParameter("@cosecha_produccion", DbType.Double, p.Cosecha_produccion);
            bd.CreateParameter("@licencia_produccion", DbType.Boolean, p.Licencia_produccion);                        

            int actualizo;
            DbDataReader resultado = bd.Query();//disponible resultado
            resultado.Read();
            actualizo = resultado.GetInt32(0);
            resultado.Close();

            bd.Close();
            return actualizo;
        }

        /*
         * Devuelve las variedades que tienen o pueden estar en producción
         * Modificar
         */
        public List<Produccion> GetProduccion(int año)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Produccion> producciones = new List<Produccion>();
            string salida = "produccionSeleccionIngresarObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@ano_produccion", DbType.Int32, año);

            DbDataReader resultado = bd.Query();//disponible resultado

            while (resultado.Read())
            {
                Produccion prod = new Produccion(resultado.GetString(0), resultado.GetString(1));
                producciones.Add(prod);
            }
            resultado.Close();
            bd.Close();

            return producciones;
        }

        /*
         * Devuelve 1 si ya está en producción la variedad
         * Modificar
         */
        public int GetProduccionVariedad(int año, int posicion)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            int estaEnProduccion;

            string salida = "produccionSeleccionIngresarObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@ano_produccion", DbType.Int32, año);
            DbDataReader resultado = bd.Query();//disponible resultado
            List<string> codigo_variedad = new List<string>();
            while (resultado.Read())
            {
                codigo_variedad.Add(resultado.GetString(1));
            }
            resultado.Close();

            string salida2 = "produccionEstaEnVariedad";//comando sql
            bd.CreateCommandSP(salida2);
            bd.CreateParameter("@codigo_variedad", DbType.String, codigo_variedad[posicion]);
            DbDataReader resultado2 = bd.Query();//disponible resultado
            resultado2.Read();
            estaEnProduccion = resultado2.GetInt32(0);
            resultado2.Close();

            bd.Close();
            return estaEnProduccion;
        }

        /*
         * Devuelve la produccion de una variedad
         * Modificar
         */
        public List<Produccion> GetProduccionPorVariedad(string codigo_variedad)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Produccion> producciones = new List<Produccion>();
            string salida = "produccionSeleccionObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@codigo_variedad", DbType.String, codigo_variedad);

            DbDataReader resultado = bd.Query();//disponible resultado

            while (resultado.Read())
            {
                Produccion prod = new Produccion(resultado.GetInt32(0), resultado.GetInt32(1), resultado.GetString(2),
                    resultado.GetInt32(3), resultado.GetDouble(4), resultado.GetInt32(5), resultado.GetDouble(6),
                    resultado.GetDouble(7), resultado.GetDouble(8), resultado.GetBoolean(9));
                producciones.Add(prod);
            }
            resultado.Close();
            bd.Close();

            return producciones;
        }

        /*
         * Devuelve las variedades que tienen o pueden estar en producción
         * Filtrar
         */
        public List<Produccion> GetFiltrarProduccionPorVariedad(int año)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Produccion> producciones = new List<Produccion>();
            string salida = "produccionFiltrarVariedadObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@ano_produccion", DbType.Int32, año);

            DbDataReader resultado = bd.Query();//disponible resultado

            while (resultado.Read())
            {
                Produccion prod = new Produccion(resultado.GetString(0), resultado.GetString(1), resultado.GetString(2),
                    resultado.GetString(3), resultado.GetDouble(4), resultado.GetDouble(5), resultado.GetDouble(6),
                    resultado.GetDouble(7), resultado.GetBoolean(8));
                producciones.Add(prod);
            }
            resultado.Close();
            bd.Close();

            return producciones;
        }

        /*
         * Devuelve la produccion por productor, ciudad y/o categoria
         * Filtrar
         */
        public List<Produccion> GetFiltrarProduccionPorProductorCiudadCategoria(int id_productor, int id_ciudad, int id_categoria)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Produccion> producciones = new List<Produccion>();
            string salida = "produccionFiltrarProductorCiudadCategoriaObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@id_productor", DbType.Int32, id_productor);
            bd.CreateParameter("@id_ciudad", DbType.Int32, id_ciudad);
            bd.CreateParameter("@id_categoria", DbType.Int32, id_categoria);

            DbDataReader resultado = bd.Query();//disponible resultado

            while (resultado.Read())
            {
                Produccion prod = new Produccion(resultado.GetString(0), resultado.GetString(1), resultado.GetString(2),
                    resultado.GetString(3), resultado.GetDouble(4), resultado.GetDouble(5), resultado.GetDouble(6),
                    resultado.GetDouble(7), resultado.GetBoolean(8));
                producciones.Add(prod);
            }
            resultado.Close();
            bd.Close();

            return producciones;
        }

        /*
         * Funcion que devuelve una lista de años comenzando de la primera licencia hasta la ultima
         */
        public List<Produccion> GetAñoLicencia_fn()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Produccion> años = new List<Produccion>();
            string salida = "select * from dbo.fn_añoLicenciaObtener()";//comando sql
            bd.CreateCommand(salida);

            DbDataReader resultado = bd.Query();//disponible resultado

            while (resultado.Read())
            {
                Produccion licencia = new Produccion(resultado.GetInt32(0));
                años.Add(licencia);
            }
            resultado.Close();
            bd.Close();

            return años;
        }

        /*
         * Devuelve las producciones que tengas licencias activas
         * Obtener
         */
        public List<Produccion> GetLicencia(int año)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Produccion> producciones = new List<Produccion>();
            string salida = "licenciaObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@ano_licencia", DbType.Int32, año);

            DbDataReader resultado = bd.Query();//disponible resultado

            while (resultado.Read())
            {
                Produccion prod = new Produccion(resultado.GetString(0), resultado.GetString(1), resultado.GetString(2),
                    resultado.GetString(3), resultado.GetDouble(4), resultado.GetDouble(5), resultado.GetDouble(6),
                    resultado.GetDouble(7));
                producciones.Add(prod);
            }
            resultado.Close();
            bd.Close();

            return producciones;
        }

        /*
         * Devuelve la estadistica de ranking de variedades en el año seleccionado
         * Estadistica
         */
        public List<Produccion> GetRankingVariedad(int año)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Produccion> producciones = new List<Produccion>();
            string salida = "estadisticaPorcentajeRelacionObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@ano_produccion", DbType.Int32, año);

            DbDataReader resultado = bd.Query();//disponible resultado

            while (resultado.Read())
            {
                Produccion prod = new Produccion(resultado.GetString(0), resultado.GetInt32(1));
                producciones.Add(prod);
            }
            resultado.Close();
            bd.Close();

            return producciones;
        }

        /*
         * Devuelve la estadistica de produccion por fertilidades en el año seleccionado
         * Estadistica
         */
        public List<Produccion> GetFertilidad(int año)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Produccion> producciones = new List<Produccion>();
            string salida = "estadisticaFertilidadObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@ano_produccion", DbType.Int32, año);

            DbDataReader resultado = bd.Query();//disponible resultado

            while (resultado.Read())
            {
                Produccion prod = new Produccion(resultado.GetString(0), resultado.GetInt32(1));
                producciones.Add(prod);
            }
            resultado.Close();
            bd.Close();

            return producciones;
        }

        /*
         * Devuelve la estadistica de produccion por destinos en el año seleccionado
         * Estadistica
         */
        public List<Produccion> GetDestino(int año)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Produccion> producciones = new List<Produccion>();
            string salida = "estadisticaDestinoObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@ano_produccion", DbType.Int32, año);

            DbDataReader resultado = bd.Query();//disponible resultado

            while (resultado.Read())
            {
                Produccion prod = new Produccion(resultado.GetString(0), resultado.GetInt32(1));
                producciones.Add(prod);
            }
            resultado.Close();
            bd.Close();

            return producciones;
        }

        /*
         * Devuelve la estadistica de produccion por ciudades en el año seleccionado
         * Estadistica
         */
        public List<Produccion> GetCiudad(int año)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Produccion> producciones = new List<Produccion>();
            string salida = "estadisticaCiudadObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@ano_produccion", DbType.Int32, año);

            DbDataReader resultado = bd.Query();//disponible resultado

            while (resultado.Read())
            {
                Produccion prod = new Produccion(resultado.GetString(0), resultado.GetInt32(1));
                producciones.Add(prod);
            }
            resultado.Close();
            bd.Close();

            return producciones;
        }
    }
}