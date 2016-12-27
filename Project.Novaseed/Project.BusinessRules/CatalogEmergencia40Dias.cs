using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogEmergencia40Dias
    {
        public List<Emergencia40Dias> getEmergencia40Dias()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Emergencia40Dias> le40 = new List<Emergencia40Dias>();
                string sql = "emergencia40DiasObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    Emergencia40Dias emer40 = new Emergencia40Dias(resultado.GetInt32(0), resultado.GetString(1));
                    le40.Add(emer40);
                }
                resultado.Close();
                bd.Close();

                return le40;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}