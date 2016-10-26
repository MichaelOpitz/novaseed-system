using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogProfundidadOjo
    {
        public List<ProfundidadOjo> getProfundidadOjo()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<ProfundidadOjo> lpo = new List<ProfundidadOjo>();
            string sql = "profundidadOjoObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                ProfundidadOjo profundidad = new ProfundidadOjo(resultado.GetInt32(0), resultado.GetString(1));
                lpo.Add(profundidad);
            }
            resultado.Close();
            bd.Close();

            return lpo;
        }
    }
}