using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogTizonTardioTuberculo
    {
        public List<TizonTardioTuberculo> GetTizonTardioTuberculo()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<TizonTardioTuberculo> lttt = new List<TizonTardioTuberculo>();
                string sql = "tizonTardioTuberculoObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    TizonTardioTuberculo tuberculo = new TizonTardioTuberculo(resultado.GetInt32(0), resultado.GetString(1));
                    lttt.Add(tuberculo);
                }
                resultado.Close();
                bd.Close();

                return lttt;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}