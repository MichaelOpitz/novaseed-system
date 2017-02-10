using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogNumeroTuberculos
    {
        public List<NumeroTuberculos> GetNumeroTuberculos()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<NumeroTuberculos> lnt = new List<NumeroTuberculos>();
                string sql = "numeroTuberculosObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    NumeroTuberculos numero = new NumeroTuberculos(resultado.GetInt32(0), resultado.GetString(1));
                    lnt.Add(numero);
                }
                resultado.Close();
                bd.Close();

                return lnt;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}