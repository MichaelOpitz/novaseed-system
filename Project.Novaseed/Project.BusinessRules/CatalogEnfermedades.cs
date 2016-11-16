using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogEnfermedades
    {
        public List<Enfermedades> GetEnfermedades()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Enfermedades> le = new List<Enfermedades>();
            string sql = "enfermedadesObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                Enfermedades enfermedad = new Enfermedades(resultado.GetInt32(0), resultado.GetString(1));
                le.Add(enfermedad);
            }
            resultado.Close();
            bd.Close();

            return le;
        }
    }
}