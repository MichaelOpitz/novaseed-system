using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogCiudad
    {
        public List<Ciudad> GetCiudad()
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
    }
}