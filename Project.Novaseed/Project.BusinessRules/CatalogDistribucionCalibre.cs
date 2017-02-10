using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogDistribucionCalibre
    {
        public List<DistribucionCalibre> GetDistribucionCalibre()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<DistribucionCalibre> ldc = new List<DistribucionCalibre>();
                string sql = "distribucionCalibreObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    DistribucionCalibre distribucion = new DistribucionCalibre(resultado.GetInt32(0), resultado.GetString(1));
                    ldc.Add(distribucion);
                }
                resultado.Close();
                bd.Close();

                return ldc;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}