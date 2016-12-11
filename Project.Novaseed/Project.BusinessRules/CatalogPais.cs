using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogPais
    {
        public List<Pais> GetPais()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Pais> lp = new List<Pais>();
            string sql = "paisObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                Pais pais = new Pais(resultado.GetInt32(0), resultado.GetString(1));
                lp.Add(pais);
            }
            resultado.Close();
            bd.Close();

            return lp;
        }
    }
}