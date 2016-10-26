using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogTamaño
    {
        public List<Tamaño> getTamaño()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Tamaño> lt = new List<Tamaño>();
            string sql = "tamañoObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                Tamaño tamaño = new Tamaño(resultado.GetInt32(0), resultado.GetString(1));
                lt.Add(tamaño);
            }
            resultado.Close();
            bd.Close();

            return lt;
        }
    }
}