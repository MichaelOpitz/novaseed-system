using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogMadurez
    {
        public List<Madurez> getMadurez()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Madurez> lm = new List<Madurez>();
                string sql = "madurezObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    Madurez mad = new Madurez(resultado.GetInt32(0), resultado.GetString(1));
                    lm.Add(mad);
                }
                resultado.Close();
                bd.Close();

                return lm;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}