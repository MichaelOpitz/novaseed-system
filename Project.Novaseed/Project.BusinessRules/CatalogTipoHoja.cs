using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogTipoHoja
    {
        public List<TipoHoja> getTipoHoja()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<TipoHoja> lth = new List<TipoHoja>();
                string sql = "tipoHojaObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    TipoHoja hoja = new TipoHoja(resultado.GetInt32(0), resultado.GetString(1));
                    lth.Add(hoja);
                }
                resultado.Close();
                bd.Close();

                return lth;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}