using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogTizonTardioFollaje
    {
        public List<TizonTardioFollaje> getTizonTardioFollaje()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<TizonTardioFollaje> lttf = new List<TizonTardioFollaje>();
                string sql = "tizonTardioFollajeObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    TizonTardioFollaje follaje = new TizonTardioFollaje(resultado.GetInt32(0), resultado.GetString(1));
                    lttf.Add(follaje);
                }
                resultado.Close();
                bd.Close();

                return lttf;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}