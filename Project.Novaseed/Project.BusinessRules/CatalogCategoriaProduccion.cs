using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogCategoriaProduccion
    {
        public List<CategoriaProduccion> GetCategoriaProduccion()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<CategoriaProduccion> lcp = new List<CategoriaProduccion>();
            string sql = "categoriaProduccionObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                CategoriaProduccion catProd = new CategoriaProduccion(resultado.GetInt32(0), resultado.GetString(1));
                lcp.Add(catProd);
            }
            resultado.Close();
            bd.Close();

            return lcp;
        }
    }
}