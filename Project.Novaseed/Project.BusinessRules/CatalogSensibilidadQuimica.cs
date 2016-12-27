using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogSensibilidadQuimica
    {
        public List<SensibilidadQuimica> GetSensibilidadQuimica()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<SensibilidadQuimica> lsq = new List<SensibilidadQuimica>();
                string sql = "sensibilidadQuimicaObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    SensibilidadQuimica sensibilidad = new SensibilidadQuimica(resultado.GetInt32(0), resultado.GetString(1));
                    lsq.Add(sensibilidad);
                }
                resultado.Close();
                bd.Close();

                return lsq;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}