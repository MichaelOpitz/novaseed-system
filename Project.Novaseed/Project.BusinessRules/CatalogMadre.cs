using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;
using System.Data;

namespace Project.BusinessRules
{
    public class CatalogMadre
    {
        public List<Madre> getMadre(Madre m)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Madre> madre = new List<Madre>();
                string sql = "madreObtener";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_tamaño", DbType.Int32, m.Id_tamaño);
                bd.CreateParameter("@id_madurez", DbType.Int32, m.Id_madurez);
                bd.CreateParameter("@id_forma", DbType.Int32, m.Id_forma);
                bd.CreateParameter("@id_distribucion", DbType.Int32, m.Id_distribucion_calibre);
                bd.CreateParameter("@id_profundidad", DbType.Int32, m.Id_profundidad);
                bd.CreateParameter("@id_regularidad", DbType.Int32, m.Id_regularidad);
                bd.CreateParameter("@id_brotacion", DbType.Int32, m.Id_brotacion);
                bd.CreateParameter("@id_emergencia", DbType.Int32, m.Id_emergencia);
                bd.CreateParameter("@id_emergencia_40", DbType.Int32, m.Id_emergencia_40_dias);
                bd.CreateParameter("@id_metribuzina", DbType.Int32, m.Id_metribuzina);
                bd.CreateParameter("@id_verdes", DbType.Int32, m.Id_tuberculos_verdes);
                bd.CreateParameter("@id_tizon_follaje", DbType.Int32, m.Id_tizon_tardio_follaje);
                bd.CreateParameter("@id_tizon_tuberculo", DbType.Int32, m.Id_tizon_tardio_tuberculo);
                bd.CreateParameter("@id_numero", DbType.Int32, m.Id_numero_tuberculos);
                bd.CreateParameter("@id_fertilidad", DbType.Int32, m.Id_fertilidad);
                bd.CreateParameter("@id_destino", DbType.Int32, m.Id_destino);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    try
                    {
                        Madre mama = new Madre(resultado.GetString(0), resultado.GetString(1), resultado.GetString(2),
                            resultado.GetString(3), resultado.GetString(4), resultado.GetString(5), resultado.GetString(6),
                            resultado.GetString(7), resultado.GetString(8), resultado.GetString(9), resultado.GetString(10),
                            resultado.GetString(11), resultado.GetString(12), resultado.GetString(13), resultado.GetString(14),
                            resultado.GetString(15), resultado.GetString(16), resultado.GetString(17), resultado.GetString(18));
                        madre.Add(mama);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} Exception caught.", e);
                    }
                }
                resultado.Close();
                bd.Close();

                return madre;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public List<Madre> GetMadreNombre(string nombre)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Madre> madre = new List<Madre>();
                string sql = "madreNombreObtener";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@nombre_madre_variedad", DbType.String, nombre);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    try
                    {
                        Madre mama = new Madre(resultado.GetString(0), resultado.GetString(1), resultado.GetString(2),
                            resultado.GetString(3), resultado.GetString(4), resultado.GetString(5), resultado.GetString(6),
                            resultado.GetString(7), resultado.GetString(8), resultado.GetString(9), resultado.GetString(10),
                            resultado.GetString(11), resultado.GetString(12), resultado.GetString(13), resultado.GetString(14),
                            resultado.GetString(15), resultado.GetString(16), resultado.GetString(17), resultado.GetString(18));
                        madre.Add(mama);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} Exception caught.", e);
                    }
                }
                resultado.Close();
                bd.Close();

                return madre;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}