using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogUPOVInforme
    {
        public List<UPOVInforme> GetInflorescenciaTamaño()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<UPOVInforme> lui = new List<UPOVInforme>();
            string sql = "upovInformeInflorescenciaTamañoObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                UPOVInforme upov = new UPOVInforme(resultado.GetInt32(0), resultado.GetString(1));
                lui.Add(upov);
            }
            resultado.Close();
            bd.Close();

            return lui;
        }
    }
}