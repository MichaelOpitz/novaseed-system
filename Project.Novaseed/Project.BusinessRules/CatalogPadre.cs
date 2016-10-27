using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;
using System.Data;

namespace Project.BusinessRules
{
    public class CatalogPadre
    {
        public List<Padre> getPadre(Padre p)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Padre> padre = new List<Padre>();
            string sql = "padreObtener";
            bd.CreateCommandSP(sql);
            bd.CreateParameter("@id_tamaño", DbType.Int32, p.Id_tamaño);
            bd.CreateParameter("@id_madurez", DbType.Int32, p.Id_madurez);
            bd.CreateParameter("@id_tipo_hoja", DbType.Int32, p.Id_tipo_hoja);
            bd.CreateParameter("@id_calidad_piel", DbType.Int32, p.Id_calidad_piel);
            bd.CreateParameter("@id_forma", DbType.Int32, p.Id_forma);
            bd.CreateParameter("@id_distribucion", DbType.Int32, p.Id_distribucion_calibre);
            bd.CreateParameter("@id_profundidad", DbType.Int32, p.Id_profundidad);
            bd.CreateParameter("@id_regularidad", DbType.Int32, p.Id_regularidad);
            bd.CreateParameter("@id_desarrollo", DbType.Int32, p.Id_desarrollo_follaje);
            bd.CreateParameter("@id_brotacion", DbType.Int32, p.Id_brotacion);
            bd.CreateParameter("@id_emergencia", DbType.Int32, p.Id_emergencia);
            bd.CreateParameter("@id_emergencia_40", DbType.Int32, p.Id_emergencia_40_dias);
            bd.CreateParameter("@id_metribuzina", DbType.Int32, p.Id_metribuzina);
            bd.CreateParameter("@id_verdes", DbType.Int32, p.Id_tuberculos_verdes);
            bd.CreateParameter("@id_tizon_follaje", DbType.Int32, p.Id_tizon_tardio_follaje);
            bd.CreateParameter("@id_tizon_tuberculo", DbType.Int32, p.Id_tizon_tardio_tuberculo);
            bd.CreateParameter("@id_numero", DbType.Int32, p.Id_numero_tuberculos);
            bd.CreateParameter("@id_fertilidad", DbType.Int32, p.Id_fertilidad);
            bd.CreateParameter("@id_destino", DbType.Int32, p.Id_destino);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                try
                {
                    Padre papa = new Padre(resultado.GetString(0), resultado.GetString(1), resultado.GetString(2), resultado.GetString(3),
                        resultado.GetString(4), resultado.GetString(5), resultado.GetString(6), resultado.GetString(7), resultado.GetString(8),
                        resultado.GetString(9), resultado.GetString(10), resultado.GetString(11), resultado.GetString(12), resultado.GetString(13),
                        resultado.GetString(14), resultado.GetString(15), resultado.GetString(16), resultado.GetString(17),
                        resultado.GetString(18), resultado.GetString(19), resultado.GetString(20), resultado.GetString(21));
                    padre.Add(papa);
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} Exception caught.", e);
                }
            }
            resultado.Close();
            bd.Close();

            return padre;
        }

        public List<Padre> GetPadreNombre(string nombre)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Padre> padre = new List<Padre>();
            string sql = "padreNombreObtener";
            bd.CreateCommandSP(sql);
            bd.CreateParameter("@nombre_padre_variedad", DbType.String, nombre);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                try
                {
                    Padre papa = new Padre(resultado.GetString(0), resultado.GetString(1), resultado.GetString(2), resultado.GetString(3),
                        resultado.GetString(4), resultado.GetString(5), resultado.GetString(6), resultado.GetString(7), resultado.GetString(8),
                        resultado.GetString(9), resultado.GetString(10), resultado.GetString(11), resultado.GetString(12), resultado.GetString(13),
                        resultado.GetString(14), resultado.GetString(15), resultado.GetString(16), resultado.GetString(17),
                        resultado.GetString(18), resultado.GetString(19), resultado.GetString(20), resultado.GetString(21));
                    padre.Add(papa);
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} Exception caught.", e);
                }
            }
            resultado.Close();
            bd.Close();

            return padre;
        }
    }
}