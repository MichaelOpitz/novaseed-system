using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Funciones
    {
        /*
         * Agrega a la tabla paises
         */ 
        public void AddPaises(List<string> paises)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            string sql = "paisesAgregar";
            int cont = 0;
            while (cont < paises.Count)
            {
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@pais", DbType.String, paises[cont].ToString());
                cont = cont + 1;
                bd.Execute();
            }
            bd.Close();

        }
    }
}