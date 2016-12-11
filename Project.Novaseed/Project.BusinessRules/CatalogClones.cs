using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class CatalogClones
    {
        /*
         * Agregar clones por defecto y por primera vez para luego ser modificado en la tabla clones
         */
        public int AddClones(int id_vasos, string codigo_variedad, string pad_codigo_variedad)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            string sql = "clonesAgregar";
            bd.CreateCommandSP(sql);
            bd.CreateParameter("@id_vasos", DbType.Int32, id_vasos);
            bd.CreateParameter("@codigo_variedad", DbType.String, codigo_variedad);
            bd.CreateParameter("@pad_codigo_variedad", DbType.String, pad_codigo_variedad);

            int existe_clon;
            DbDataReader resultado = bd.Query();//disponible resultado
            resultado.Read();
            existe_clon = resultado.GetInt32(0);
            resultado.Close();

            bd.Close();
            return existe_clon;
        }

        /*
         * Actualizar clon
         */
        public void UpdateClones(Clones c)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            string sql = "clonesActualizar";
            bd.CreateCommandSP(sql);
            bd.CreateParameter("@id_clones", DbType.Int32, c.Id_clones);            
            bd.CreateParameter("@id_fertilidad", DbType.Int32, c.Id_fertilidad);
            bd.CreateParameter("@azul_clon", DbType.Int32, c.Azul_clon);
            bd.CreateParameter("@roja_clon", DbType.Int32, c.Roja_clon);
            bd.CreateParameter("@amarilla_clon", DbType.Int32, c.Amarilla_clon);
            bd.CreateParameter("@bicolor_clon", DbType.Int32, c.Bicolor_clon);
            bd.Execute();
            bd.Close();
        }

        /*
         * Elimina un clon a través del id_clones
         * Devuelve 1 si eliminó, 0 en caso contrario
         */
        public int DeleteClones(int id_clones)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            string sql = "clonesEliminar";
            bd.CreateCommandSP(sql);
            bd.CreateParameter("@id_clones", DbType.Int32, id_clones);

            int elimino;
            DbDataReader resultado = bd.Query();//disponible resultado
            resultado.Read();
            elimino = resultado.GetInt32(0);
            resultado.Close();

            bd.Close();
            return elimino;
        }

        /*
         * Devuelve el clon completo, con el nombre de fertilidad en vez de la id
         */
        public List<Clones> GetClones(int año)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Clones> clones = new List<Clones>();
            string salida = "clonesObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@ano_clones", DbType.Int32, año);

            DbDataReader resultado = bd.Query();//disponible resultado

            while (resultado.Read())
            {
                Clones clon = new Clones(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2), resultado.GetString(3),
                    resultado.GetString(4), resultado.GetString(5), resultado.GetInt32(6), 
                    resultado.GetInt32(7), resultado.GetInt32(8), resultado.GetInt32(9));
                clones.Add(clon);
            }
            resultado.Close();
            bd.Close();

            return clones;
        }

        /*
         * Devuelve el tipo de fertilidad que tiene cada clon
         */
        public int GetFertilidadClones(int año, int posicion)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            int id_fertilidad;

            string salida = "clonesObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@ano_clones", DbType.Int32, año);
            DbDataReader resultado = bd.Query();//disponible resultado
            List<int> id_clones = new List<int>();
            while (resultado.Read())
            {
                id_clones.Add(resultado.GetInt32(0));
            }
            resultado.Close();

            string salida2 = "clonesIndexFertilidadObtener";//comando sql
            bd.CreateCommandSP(salida2);
            bd.CreateParameter("@id_clones", DbType.Int32, id_clones[posicion]);
            DbDataReader resultado2 = bd.Query();//disponible resultado
            resultado2.Read();
            id_fertilidad = resultado2.GetInt32(0);
            resultado2.Close();

            bd.Close();
            return id_fertilidad;
        }

        /*
         * Devuelve 1 si clon ya está codificado, 0 en caso contrario
         */
        public int GetClonesEstaCodificado(int año, int posicion)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            int esta_codificado;

            string salida = "clonesObtener";//comando sql
            bd.CreateCommandSP(salida);
            bd.CreateParameter("@ano_clones", DbType.Int32, año);
            DbDataReader resultado = bd.Query();//disponible resultado
            List<int> id_clones = new List<int>();
            while (resultado.Read())
            {
                id_clones.Add(resultado.GetInt32(0));
            }
            resultado.Close();

            string salida2 = "clonesEstaEnCodificacion";//comando sql
            bd.CreateCommandSP(salida2);
            bd.CreateParameter("@id_clones", DbType.Int32, id_clones[posicion]);
            DbDataReader resultado2 = bd.Query();//disponible resultado
            resultado2.Read();
            esta_codificado = resultado2.GetInt32(0);
            resultado2.Close();

            bd.Close();
            return esta_codificado;
        }
    }
}