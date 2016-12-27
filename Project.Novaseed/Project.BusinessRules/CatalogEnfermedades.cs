using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;
using System.Data;

namespace Project.BusinessRules
{
    public class CatalogEnfermedades
    {
        /*
         * Agregar una enfermedad
         */
        public void AddEnfermedad(string nombre_enfermedad)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "enfermedadesAgregar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@nombre_enfermedades", DbType.String, nombre_enfermedad);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Actualizar enfermedad
         */
        public void UpdateEnfermedad(int id_enfermedad, string nombre_enfermedad)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "enfermedadesActualizar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_enfermedades", DbType.Int32, id_enfermedad);
                bd.CreateParameter("@nombre_enfermedad", DbType.String, nombre_enfermedad);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Elimina una enfermedad a través del id_enfermedad.
         * Devuelve 1 si eliminó, 0 en caso contrario
         */
        public int DeleteEnfermedad(int id_enfermedad)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "enfermedadesEliminar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_enfermedades", DbType.Int32, id_enfermedad);

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
         * Obtiene la lista con todas las enfermedadesd de novaseed
         */
        public List<Enfermedades> GetEnfermedades()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Enfermedades> le = new List<Enfermedades>();
                string sql = "enfermedadesObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    Enfermedades enfermedad = new Enfermedades(resultado.GetInt32(0), resultado.GetString(1));
                    le.Add(enfermedad);
                }
                resultado.Close();
                bd.Close();

                return le;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}