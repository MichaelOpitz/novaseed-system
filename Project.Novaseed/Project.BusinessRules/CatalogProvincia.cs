using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class CatalogProvincia
    {
        /*
         * Agregar una provincia
         */
        public void AddProvincia(string nombre_provincia, int id_region)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "provinciaAgregar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@nombre_provincia", DbType.String, nombre_provincia);
                bd.CreateParameter("@id_region", DbType.Int32, id_region);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Actualizar provincia
         */
        public void UpdateProvincia(int id_provincia, string nombre_provincia)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "provinciaActualizar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_provincia", DbType.Int32, id_provincia);
                bd.CreateParameter("@nombre_provincia", DbType.String, nombre_provincia);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Elimina una provincia a través del id_provincia
         * Devuelve 1 si eliminó, 0 en caso contrario
         */
        public int DeleteProvincia(int id_provincia)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "provinciaEliminar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_provincia", DbType.Int32, id_provincia);

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
         * Obtiene la lista de las provincia por region seleccionada
         */
        public List<Provincia> GetProvincia(int id_region)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Provincia> lp = new List<Provincia>();
                string sql = "provinciaObtener";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_region", DbType.Int32, id_region);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    Provincia provincia = new Provincia(resultado.GetInt32(0), resultado.GetString(1));
                    lp.Add(provincia);
                }
                resultado.Close();
                bd.Close();

                return lp;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}