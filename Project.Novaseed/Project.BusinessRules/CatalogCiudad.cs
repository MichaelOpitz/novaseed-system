using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;
using System.Data;

namespace Project.BusinessRules
{
    public class CatalogCiudad
    {
        /*
         * Agregar una ciudad
         */
        public void AddCiudad(string nombre_ciudad, int id_provincia)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "ciudadAgregar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@nombre_ciudad", DbType.String, nombre_ciudad);
                bd.CreateParameter("@id_provincia", DbType.Int32, id_provincia);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Actualizar ciudad
         */
        public void UpdateCiudad(int id_ciudad, string nombre_ciudad)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "ciudadActualizar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_ciudad", DbType.Int32, id_ciudad);
                bd.CreateParameter("@nombre_ciudad", DbType.String, nombre_ciudad);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Elimina una ciudad a través del id_ciduad
         * Devuelve 1 si eliminó, 0 en caso contrario
         */
        public int DeleteCiudad(int id_ciudad)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "ciudadEliminar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_ciudad", DbType.Int32, id_ciudad);

                int elimino;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                elimino = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return elimino;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene las ciudades que trabaja novaseed
         */
        public List<Ciudad> GetCiudad()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Ciudad> lc = new List<Ciudad>();
                string sql = "ciudadObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    Ciudad city = new Ciudad(resultado.GetInt32(0), resultado.GetString(1));
                    lc.Add(city);
                }
                resultado.Close();
                bd.Close();

                return lc;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public List<Ciudad> GetCiudadPorProvincia(int id_provincia)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Ciudad> lc = new List<Ciudad>();
                string sql = "ciudadObtenerPorProvincia";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_provincia", DbType.Int32, id_provincia);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    Ciudad ciudad = new Ciudad(resultado.GetInt32(0), resultado.GetString(1));
                    lc.Add(ciudad);
                }
                resultado.Close();
                bd.Close();

                return lc;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}