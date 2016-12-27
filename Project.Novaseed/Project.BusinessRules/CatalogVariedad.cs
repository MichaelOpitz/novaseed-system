using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class CatalogVariedad
    {
        /*
         * Devuelve una lista con las variedades standard del sistema
         */
        public List<Variedad> GetTablaVariedadVariedades()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Variedad> variedad = new List<Variedad>();
                string salida = "variedadTablaVariedadesObtener";//comando sql
                bd.CreateCommandSP(salida);

                DbDataReader resultado = bd.Query();//disponible resultado

                while (resultado.Read())
                {
                    Variedad v = new Variedad(resultado.GetString(0), resultado.GetString(1));
                    variedad.Add(v);
                }
                resultado.Close();
                bd.Close();

                return variedad;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene las características por el nombre de la variedad
         */ 
        public DataSet GetVariedadReporte(string codigo_variedad)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                DataSet set = new DataSet();
                string salida = "variedadReporte";//comando sql
                set = bd.SetSP(salida, "@codigo_variedad", DbType.String, codigo_variedad);
                return set;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}