using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class CatalogSexo
    {
        public List<Sexo> GetSexo()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Sexo> ls = new List<Sexo>();
            string sql = "sexoObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                Sexo sexo = new Sexo(resultado.GetInt32(0), resultado.GetString(1));
                ls.Add(sexo);
            }
            resultado.Close();
            bd.Close();

            return ls;
        }
    }
}