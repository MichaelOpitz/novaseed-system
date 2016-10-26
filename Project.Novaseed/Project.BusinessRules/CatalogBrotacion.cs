using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogBrotacion
    {
        public List<Brotacion> getBrotacion()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Brotacion> lb = new List<Brotacion>();
            string sql = "brotacionObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                Brotacion brot = new Brotacion(resultado.GetInt32(0), resultado.GetString(1));
                lb.Add(brot);
            }
            resultado.Close();
            bd.Close();

            return lb;
        }
    }
}