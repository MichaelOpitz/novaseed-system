using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogTuberculosVerdes
    {
        public List<TuberculosVerdes> GetTuberculosVerdes()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<TuberculosVerdes> ltv = new List<TuberculosVerdes>();
                string sql = "tuberculosVerdesObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    TuberculosVerdes tuberculos = new TuberculosVerdes(resultado.GetInt32(0), resultado.GetString(1));
                    ltv.Add(tuberculos);
                }
                resultado.Close();
                bd.Close();

                return ltv;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}