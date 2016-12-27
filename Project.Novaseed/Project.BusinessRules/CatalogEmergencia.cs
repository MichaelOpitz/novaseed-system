using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogEmergencia
    {
        public List<Emergencia> getEmergencia()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Emergencia> le = new List<Emergencia>();
                string sql = "emergenciaObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    Emergencia emer = new Emergencia(resultado.GetInt32(0), resultado.GetString(1));
                    le.Add(emer);
                }
                resultado.Close();
                bd.Close();

                return le;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}