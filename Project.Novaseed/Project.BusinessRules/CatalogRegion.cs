using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class CatalogRegion
    {
        /*
         * Agregar una region
         */
        public void AddRegion(string nombre_region, int id_pais)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "regionAgregar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@nombre_region", DbType.String, nombre_region);
                bd.CreateParameter("@id_pais", DbType.Int32, id_pais);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Actualizar región
         */
        public void UpdateRegion(int id_region, string nombre_region)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "regionActualizar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_region", DbType.Int32, id_region);
                bd.CreateParameter("@nombre_region", DbType.String, nombre_region);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Elimina una región a través del id_region
         * Devuelve 1 si eliminó, 0 en caso contrario
         */
        public int DeleteRegion(int id_region)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "regionEliminar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_region", DbType.Int32, id_region);

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
         * Obtiene la lista de las regiones por país seleccionado
         */
        public List<Region> GetRegion(int id_pais)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Region> lr = new List<Region>();
                string sql = "regionObtener";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_pais", DbType.Int32, id_pais);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    Region region = new Region(resultado.GetInt32(0), resultado.GetString(1));
                    lr.Add(region);
                }
                resultado.Close();
                bd.Close();

                return lr;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}