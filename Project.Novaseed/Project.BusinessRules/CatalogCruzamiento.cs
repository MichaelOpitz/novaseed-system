using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;
using System.Data;

namespace Project.BusinessRules
{
    public class CatalogCruzamiento
    {
        /*
         * Actualizar cruzamiento, involucra tablas cruzamienta, madre y padre.
         */ 
        public void UpdateCruzamiento(Cruzamiento c)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            string sql = "cruzamientoActualizar";
            bd.CreateCommandSP(sql);
            bd.CreateParameter("@id_cruzamiento", DbType.Int32, c.Id_cruzamiento);
            bd.CreateParameter("@codigo_variedad", DbType.String, c.Codigo_variedad);
            bd.CreateParameter("@pad_codigo_variedad", DbType.String, c.Pad_codigo_variedad);
            bd.CreateParameter("@ubicacion_madre", DbType.String, c.Ubicacion_madre);
            bd.CreateParameter("@ubicacion_padre", DbType.String, c.Ubicacion_padre);
            bd.CreateParameter("@id_fertilidad", DbType.Int32, c.Id_fertilidad);
            bd.CreateParameter("@flor", DbType.Boolean, c.Flor);
            bd.CreateParameter("@bayas", DbType.Int32, c.Bayas);            
            bd.Execute();
            bd.Close();
        }

        /*
         * Funcion que devuelve una lista de años comenzando del primer cruzamiento hasta el actual
         */ 
        public List<Cruzamiento> GetAñoCruzamiento_fn()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Cruzamiento> años = new List<Cruzamiento>();
            string salida = "select * from dbo.fn_añoCruzamientoObtener()";//comando sql
            bd.CreateCommand(salida);

            DbDataReader resultado = bd.Query();//disponible resultado

            while (resultado.Read())
            {
                Cruzamiento año = new Cruzamiento(resultado.GetInt32(0));
                años.Add(año);
            }
            resultado.Close();
            bd.Close();

            return años;
        }

        /*
         * Devuelve el cruzamiento completo, con el nombre de fertilidad en vez de la id
         */ 
        public List<Cruzamiento> GetCruzamiento(int año)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Cruzamiento> cruzamientos = new List<Cruzamiento>();
            string salida = "cruzamientoObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@ano_cruzamiento", DbType.Int32, año);

            DbDataReader resultado = bd.Query();//disponible resultado

            while (resultado.Read())
            {
                Cruzamiento cruz = new Cruzamiento(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2),
                    resultado.GetString(3), resultado.GetString(4), resultado.GetString(5), resultado.GetBoolean(6), 
                    resultado.GetInt32(7));
                cruzamientos.Add(cruz);
            }
            resultado.Close();
            bd.Close();

            return cruzamientos;
        }

        /*
         * Devuelve el tipo de fertilidad que tiene cada cruzamiento
         */ 
        public int GetFertilidadCruzamiento(int año, int posicion)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            int id_fertilidad;

            string salida = "cruzamientoObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@ano_cruzamiento", DbType.Int32, año);
            DbDataReader resultado = bd.Query();//disponible resultado
            List<int> id_cruzamiento = new List<int>();
            while (resultado.Read())
            {
                id_cruzamiento.Add(resultado.GetInt32(0));  
            }
            resultado.Close();

            string salida2 = "cruzamientoIndexFertilidadObtener";//comando sql
            bd.CreateCommandSP(salida2);
            bd.CreateParameter("@id_cruzamiento", DbType.Int32, id_cruzamiento[posicion]);
            DbDataReader resultado2 = bd.Query();//disponible resultado
            resultado2.Read();
            id_fertilidad = resultado2.GetInt32(0);
            resultado2.Close();

            bd.Close();
            return id_fertilidad;
        }

        /*
         * Devuelve true si el id_cruzamiento tiene flor, false en caso contrario
         */ 
        public bool GetFlorCruzamiento(int año, int posicion)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            bool id_flor;

            string salida = "cruzamientoObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@ano_cruzamiento", DbType.Int32, año);
            DbDataReader resultado = bd.Query();//disponible resultado
            List<int> id_cruzamiento = new List<int>();
            while (resultado.Read())
            {
                id_cruzamiento.Add(resultado.GetInt32(0));
            }
            resultado.Close();

            string salida2 = "cruzamientoIndexFlorObtener";//comando sql
            bd.CreateCommandSP(salida2);
            bd.CreateParameter("@id_cruzamiento", DbType.Int32, id_cruzamiento[posicion]);
            DbDataReader resultado2 = bd.Query();//disponible resultado
            resultado2.Read();
            id_flor = resultado2.GetBoolean(0);
            resultado2.Close();

            bd.Close();
            return id_flor;
        }
    }
}