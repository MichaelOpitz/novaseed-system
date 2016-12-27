using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogFertilidad
    {
        public List<Fertilidad> getFertilidad()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Fertilidad> lf = new List<Fertilidad>();
                string sql = "fertilidadObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    Fertilidad fertilidad = new Fertilidad(resultado.GetInt32(0), resultado.GetString(1));
                    lf.Add(fertilidad);
                }
                resultado.Close();
                bd.Close();

                return lf;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}