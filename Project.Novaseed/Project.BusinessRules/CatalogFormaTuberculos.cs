using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogFormaTuberculos
    {
        public List<FormaTuberculos> getFormaTuberculos()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<FormaTuberculos> lft = new List<FormaTuberculos>();
            string sql = "formaTuberculosObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                FormaTuberculos forma = new FormaTuberculos(resultado.GetInt32(0), resultado.GetString(1));
                lft.Add(forma);
            }
            resultado.Close();
            bd.Close();

            return lft;
        }
    }
}