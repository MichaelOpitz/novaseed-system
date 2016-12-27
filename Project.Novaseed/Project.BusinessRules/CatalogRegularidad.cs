using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogRegularidad
    {
        public List<Regularidad> getRegularidad()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Regularidad> lr = new List<Regularidad>();
                string sql = "regularidadObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    Regularidad reg = new Regularidad(resultado.GetInt32(0), resultado.GetString(1));
                    lr.Add(reg);
                }
                resultado.Close();
                bd.Close();

                return lr;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}