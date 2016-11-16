using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogResistenciaVariedad
    {
        public List<ResistenciaVariedad> GetResistenciaVariedad()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<ResistenciaVariedad> lrv = new List<ResistenciaVariedad>();
            string sql = "resistenciaVariedadObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                ResistenciaVariedad resistencia = new ResistenciaVariedad(resultado.GetInt32(0), resultado.GetString(1));
                lrv.Add(resistencia);
            }
            resultado.Close();
            bd.Close();

            return lrv;
        }
    }
}