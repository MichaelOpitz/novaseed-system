using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogColorPiel
    {
        public List<ColorPiel> getColorPiel()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<ColorPiel> cp = new List<ColorPiel>();
            string sql = "colorPielObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                ColorPiel piel = new ColorPiel(resultado.GetInt32(0), resultado.GetString(1));
                cp.Add(piel);
            }
            resultado.Close();
            bd.Close();

            return cp;
        }
    }
}