using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class CatalogCargo
    {
        public List<Cargo> GetCargo()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Cargo> lc = new List<Cargo>();
            string sql = "cargoObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                Cargo cargo = new Cargo(resultado.GetInt32(0), resultado.GetString(1));
                lc.Add(cargo);
            }
            resultado.Close();
            bd.Close();

            return lc;
        }
    }
}