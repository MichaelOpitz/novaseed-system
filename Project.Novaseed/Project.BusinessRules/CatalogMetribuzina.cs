using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogMetribuzina
    {
        public List<Metribuzina> getMetribuzina()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Metribuzina> lm = new List<Metribuzina>();
            string sql = "metribuzinaObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                Metribuzina metribuzina = new Metribuzina(resultado.GetInt32(0), resultado.GetString(1));
                lm.Add(metribuzina);
            }
            resultado.Close();
            bd.Close();

            return lm;
        }
    }
}