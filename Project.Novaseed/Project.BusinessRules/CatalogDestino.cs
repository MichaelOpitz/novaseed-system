using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogDestino
    {
        public List<Destino> getDestino()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Destino> ld = new List<Destino>();
                string sql = "destinoObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    Destino destino = new Destino(resultado.GetInt32(0), resultado.GetString(1));
                    ld.Add(destino);
                }
                resultado.Close();
                bd.Close();

                return ld;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}