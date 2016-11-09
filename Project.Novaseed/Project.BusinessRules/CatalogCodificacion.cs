using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;
using System.Data;

namespace Project.BusinessRules
{
    public class CatalogCodificacion
    {
        /*
         * Agregar codificacion de todos los clones que no esten con sus códigos respectivos en el año indicado
         */
        public int AddCodificacion(int año_codificacion)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            string sql = "codificacionAgregar";
            bd.CreateCommandSP(sql);
            bd.CreateParameter("@ano_codificacion", DbType.Int32, año_codificacion);

            int existe_codificacion;
            DbDataReader resultado = bd.Query();//disponible resultado
            resultado.Read();
            existe_codificacion = resultado.GetInt32(0);
            resultado.Close();

            bd.Close();
            return existe_codificacion;
        }

        /*
         * Actualizar codificacion, devuelve 1 si actualizó, 0 en caso contrario
         */
        public int UpdateCodificacion(Codificacion c)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            string sql = "codificacionActualizar";
            bd.CreateCommandSP(sql);
            bd.CreateParameter("@id_codificacion", DbType.Int32, c.Id_codificacion);
            bd.CreateParameter("@codigo_individuo", DbType.String, c.Codigo_individuo);

            int existe_codificacion;
            DbDataReader resultado = bd.Query();//disponible resultado
            resultado.Read();
            existe_codificacion = resultado.GetInt32(0);
            resultado.Close();

            bd.Close();
            return existe_codificacion;
        }

        /*
         * Elimina la codificacion a través del id_codificacion
         * Devuelve 1 si eliminó, 0 en caso contrario
         */
        public int DeleteCodificacion(int id_codificacion)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            string sql = "codificacionEliminar";
            bd.CreateCommandSP(sql);
            bd.CreateParameter("@id_codificacion", DbType.Int32, id_codificacion);

            int elimino;
            DbDataReader resultado = bd.Query();//disponible resultado
            resultado.Read();
            elimino = resultado.GetInt32(0);
            resultado.Close();

            bd.Close();
            return elimino;
        }

        /*
         * Devuelve los padres codificados para seleccionarlos y ver la codificación de sus hijos
         */
        public List<Codificacion> GetCodificacionPadres(int año)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Codificacion> codificaciones = new List<Codificacion>();
            string salida = "codificacionPadresObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@ano_codificacion", DbType.Int32, año);

            DbDataReader resultado = bd.Query();//disponible resultado

            while (resultado.Read())
            {
                Codificacion cod = new Codificacion(resultado.GetString(0), resultado.GetString(1), 
                    resultado.GetString(2), resultado.GetString(3));
                codificaciones.Add(cod);
            }
            resultado.Close();
            bd.Close();

            return codificaciones;
        }

        /*
         * Devuelve los hijos codificados
         */
        public List<Codificacion> GetCodificacion(string codigo_variedad, string pad_codigo_variedad, int año)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Codificacion> codificaciones = new List<Codificacion>();
            string salida = "codificacionObtener";//comando sql
            bd.CreateCommandSP(salida);            
            bd.CreateParameter("@codigo_variedad", DbType.String, codigo_variedad);
            bd.CreateParameter("@pad_codigo_variedad", DbType.String, pad_codigo_variedad);
            bd.CreateParameter("@ano_codificacion", DbType.Int32, año);

            DbDataReader resultado = bd.Query();//disponible resultado

            while (resultado.Read())
            {
                Codificacion cod = new Codificacion(resultado.GetInt32(0), resultado.GetString(1));
                codificaciones.Add(cod);
            }
            resultado.Close();
            bd.Close();

            return codificaciones;
        }
    }
}