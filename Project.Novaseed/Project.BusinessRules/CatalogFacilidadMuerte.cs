using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogFacilidadMuerte
    {
        public List<FacilidadMuerte> GetFacilidadMuerte()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<FacilidadMuerte> lfm = new List<FacilidadMuerte>();
            string sql = "facilidadMuerteObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                FacilidadMuerte facilidad = new FacilidadMuerte(resultado.GetInt32(0), resultado.GetString(1));
                lfm.Add(facilidad);
            }
            resultado.Close();
            bd.Close();

            return lfm;
        }
    }
}