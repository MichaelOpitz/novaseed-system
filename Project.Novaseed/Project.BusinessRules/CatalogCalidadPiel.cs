using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogCalidadPiel
    {
        public List<CalidadPiel> getCalidadPiel()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<CalidadPiel> lcp = new List<CalidadPiel>();
            string sql = "calidadPielObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                CalidadPiel calidad = new CalidadPiel(resultado.GetInt32(0), resultado.GetString(1));
                lcp.Add(calidad);
            }
            resultado.Close();
            bd.Close();

            return lcp;
        }
    }
}