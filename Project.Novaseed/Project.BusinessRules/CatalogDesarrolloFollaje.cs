using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogDesarrolloFollaje
    {
        public List<DesarrolloFollaje> getDesarrolloFollaje()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<DesarrolloFollaje> ldf = new List<DesarrolloFollaje>();
                string sql = "desarrolloFollajeObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    DesarrolloFollaje desarrollo = new DesarrolloFollaje(resultado.GetInt32(0), resultado.GetString(1));
                    ldf.Add(desarrollo);
                }
                resultado.Close();
                bd.Close();

                return ldf;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}