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

        /*
         * Valida un RUN
         */ 
        public bool ValidarRUN(string run, char dv)
        {
            bool validacion = false;
            try
            {
                run = run.ToUpper();
                run = run.Replace(".", "");
                run = run.Replace("-", "");
                int runAux = int.Parse(run);
                //dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; runAux != 0; runAux /= 10)
                    s = (s + runAux % 10 * (9 - m++ % 6)) % 11;
                
                if (dv == (char)(s != 0 ? s + 47 : 75))
                    validacion = true;
            }
            catch (Exception)
            {
            }
            return validacion;
        }
    }
}