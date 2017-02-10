using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogColorCarne
    {
        public List<ColorCarne> GetColorCarne()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<ColorCarne> cc = new List<ColorCarne>();
                string sql = "colorCarneObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    ColorCarne carne = new ColorCarne(resultado.GetInt32(0), resultado.GetString(1));
                    cc.Add(carne);
                }
                resultado.Close();
                bd.Close();

                return cc;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}