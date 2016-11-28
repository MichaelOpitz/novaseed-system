using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogProductor
    {
        public List<Productor> GetProductor()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Productor> lp = new List<Productor>();
            string sql = "productorObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                Productor prod = new Productor(resultado.GetInt32(0), resultado.GetString(1));
                lp.Add(prod);
            }
            resultado.Close();
            bd.Close();

            return lp;
        }
    }
}