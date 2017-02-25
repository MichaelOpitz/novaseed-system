using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;
using System.Data;

namespace Project.BusinessRules
{
    public class CatalogCosecha
    {
        //--------------------------------------------INICIO 6PAPAS-----------------------------------------------------------
        /*
         * Agrega temporada 6papas a una codificacion, devuelve 0 si agrego correctamente, 1 en caso contrario
         */
        public int AddCosecha6papas(int id_codificacion)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosecha6papasAgregar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_codificacion", DbType.Int32, id_codificacion);

                int existe_6papas;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                existe_6papas = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return existe_6papas;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }    

        /*
         * Actualizar la variedad en 6 papas, devuelve 1 si actualizó, 0 en caso contrario
         */
        public int UpdateCosecha6papas(Cosecha c)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosecha6papasActualizar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_cosecha", DbType.Int32, c.Id_cosecha);
                bd.CreateParameter("@cantidad_papas", DbType.Int32, c.Cantidad_papas);
                bd.CreateParameter("@posicion_cosecha", DbType.Double, c.Posicion_cosecha);
                bd.CreateParameter("@flor_cosecha", DbType.Boolean, c.Flor_cosecha);
                bd.CreateParameter("@bayas_cosecha", DbType.Boolean, c.Bayas_cosecha);
                bd.CreateParameter("@id_fertilidad", DbType.Int32, c.Id_fertilidad);
                bd.CreateParameter("@id_emergencia40", DbType.Int32, c.Id_emergencia_40_dias);
                bd.CreateParameter("@id_metribuzina", DbType.Int32, c.Id_metribuzina);
                bd.CreateParameter("@id_emergencia", DbType.Int32, c.Id_emergencia);
                bd.CreateParameter("@id_madurez", DbType.Int32, c.Id_madurez);
                bd.CreateParameter("@id_desarrollo_follaje", DbType.Int32, c.Id_desarrollo_follaje);
                bd.CreateParameter("@id_tipo_hoja", DbType.Int32, c.Id_tipo_hoja);
                bd.CreateParameter("@id_brotacion", DbType.Int32, c.Id_brotacion);
                bd.CreateParameter("@id_tamano", DbType.Int32, c.Id_tamaño);
                bd.CreateParameter("@id_distribucion", DbType.Int32, c.Id_distribucion_calibre);
                bd.CreateParameter("@id_forma", DbType.Int32, c.Id_forma);
                bd.CreateParameter("@id_regularidad", DbType.Int32, c.Id_regularidad);
                bd.CreateParameter("@id_profundidad", DbType.Int32, c.Id_profundidad);
                bd.CreateParameter("@id_calidad", DbType.Int32, c.Id_calidad_piel);
                bd.CreateParameter("@id_verdes", DbType.Int32, c.Id_tuberculos_verdes);
                bd.CreateParameter("@tizon_follaje", DbType.Int32, c.Id_tizon_tardio_follaje);
                bd.CreateParameter("@tizon_tuberculo", DbType.Int32, c.Id_tizon_tardio_tuberculo);
                bd.CreateParameter("@id_numero", DbType.Int32, c.Id_numero_tuberculos);
                bd.CreateParameter("@id_ciudad", DbType.Int32, c.Id_ciudad);
                bd.CreateParameter("@total_kg", DbType.Double, c.Total_kg);
                bd.CreateParameter("@tuberculos_planta", DbType.Double, c.Tuberculos_planta);
                bd.CreateParameter("@toneladas_hectarea", DbType.Double, c.Toneladas_hectarea);
                bd.CreateParameter("@porcentaje_relacion", DbType.Int32, c.Porcentaje_relacion_standard);
                bd.CreateParameter("@consumo", DbType.Int32, c.Consumo);
                bd.CreateParameter("@semillon", DbType.Int32, c.Semillon);
                bd.CreateParameter("@semilla", DbType.Int32, c.Semilla);
                bd.CreateParameter("@semillita", DbType.Int32, c.Semillita);
                bd.CreateParameter("@bajo_calibre", DbType.Int32, c.Bajo_calibre);
                bd.CreateParameter("@numero_tallos", DbType.Int32, c.Numero_tallos);
                bd.CreateParameter("@id_sensibilidad_quimica", DbType.Int32, c.Id_sensibilidad_quimica);
                bd.CreateParameter("@id_facilidad_muerte", DbType.Int32, c.Id_facilidad_muerte);
                bd.CreateParameter("@dormancia", DbType.Int32, c.Dormancia);
                bd.CreateParameter("@tolerancia_sequia", DbType.Int32, c.Tolerancia_sequia);
                bd.CreateParameter("@tolerancia_calor", DbType.Int32, c.Tolerancia_calor);
                bd.CreateParameter("@tolerancia_sal", DbType.Int32, c.Tolerancia_sal);
                bd.CreateParameter("@dano_cosecha", DbType.Int32, c.Daño_cosecha);
                bd.CreateParameter("@tizon_hoja", DbType.Int32, c.Tizon_hoja);
                bd.CreateParameter("@putrefaccion_suave", DbType.Int32, c.Putrefaccion_suave);
                bd.CreateParameter("@putrefaccion_rosa", DbType.Int32, c.Putrefaccion_rosa);
                bd.CreateParameter("@silver_scurf", DbType.Int32, c.Silver_scurf);
                bd.CreateParameter("@blackleg", DbType.Int32, c.Blackleg);

                int actualizo;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                actualizo = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return actualizo;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Elimina una variedad en temporada 6papas a través del id_cosecha
         * Devuelve 1 si eliminó, 0 en caso contrario
         */
        public int DeleteCosecha6papas(int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosecha6papasEliminar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);

                int elimino;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                elimino = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return elimino;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }            
        //--------------------------------------------FIN 6PAPAS-----------------------------------------------------------
        //--------------------------------------------INICIO 12PAPAS-------------------------------------------------------

        /*
         * Agrega temporada 12papas a una temporada 6papas, devuelve 0 si agrego correctamente, 1 en caso contrario
         */
        public int AddCosecha12papas(int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosecha12papasAgregar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);

                int existe_12papas;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                existe_12papas = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return existe_12papas;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
        * Actualizar la variedad en 12 papas, devuelve 1 si actualizó, 0 en caso contrario
        */
        public int UpdateCosecha12papas(Cosecha c)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosecha12papasActualizar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_cosecha", DbType.Int32, c.Id_cosecha);
                bd.CreateParameter("@cantidad_papas", DbType.Int32, c.Cantidad_papas);
                bd.CreateParameter("@posicion_cosecha", DbType.Double, c.Posicion_cosecha);
                bd.CreateParameter("@flor_cosecha", DbType.Boolean, c.Flor_cosecha);
                bd.CreateParameter("@bayas_cosecha", DbType.Boolean, c.Bayas_cosecha);
                bd.CreateParameter("@id_fertilidad", DbType.Int32, c.Id_fertilidad);
                bd.CreateParameter("@id_emergencia40", DbType.Int32, c.Id_emergencia_40_dias);
                bd.CreateParameter("@id_metribuzina", DbType.Int32, c.Id_metribuzina);
                bd.CreateParameter("@id_emergencia", DbType.Int32, c.Id_emergencia);
                bd.CreateParameter("@id_madurez", DbType.Int32, c.Id_madurez);
                bd.CreateParameter("@id_desarrollo_follaje", DbType.Int32, c.Id_desarrollo_follaje);
                bd.CreateParameter("@id_tipo_hoja", DbType.Int32, c.Id_tipo_hoja);
                bd.CreateParameter("@id_brotacion", DbType.Int32, c.Id_brotacion);
                bd.CreateParameter("@id_tamano", DbType.Int32, c.Id_tamaño);
                bd.CreateParameter("@id_distribucion", DbType.Int32, c.Id_distribucion_calibre);
                bd.CreateParameter("@id_forma", DbType.Int32, c.Id_forma);
                bd.CreateParameter("@id_regularidad", DbType.Int32, c.Id_regularidad);
                bd.CreateParameter("@id_profundidad", DbType.Int32, c.Id_profundidad);
                bd.CreateParameter("@id_calidad", DbType.Int32, c.Id_calidad_piel);
                bd.CreateParameter("@id_verdes", DbType.Int32, c.Id_tuberculos_verdes);
                bd.CreateParameter("@tizon_follaje", DbType.Int32, c.Id_tizon_tardio_follaje);
                bd.CreateParameter("@tizon_tuberculo", DbType.Int32, c.Id_tizon_tardio_tuberculo);
                bd.CreateParameter("@id_numero", DbType.Int32, c.Id_numero_tuberculos);
                bd.CreateParameter("@id_ciudad", DbType.Int32, c.Id_ciudad);
                bd.CreateParameter("@total_kg", DbType.Double, c.Total_kg);
                bd.CreateParameter("@tuberculos_planta", DbType.Double, c.Tuberculos_planta);
                bd.CreateParameter("@toneladas_hectarea", DbType.Double, c.Toneladas_hectarea);
                bd.CreateParameter("@porcentaje_relacion", DbType.Int32, c.Porcentaje_relacion_standard);
                bd.CreateParameter("@consumo", DbType.Int32, c.Consumo);
                bd.CreateParameter("@semillon", DbType.Int32, c.Semillon);
                bd.CreateParameter("@semilla", DbType.Int32, c.Semilla);
                bd.CreateParameter("@semillita", DbType.Int32, c.Semillita);
                bd.CreateParameter("@bajo_calibre", DbType.Int32, c.Bajo_calibre);
                bd.CreateParameter("@numero_tallos", DbType.Int32, c.Numero_tallos);
                bd.CreateParameter("@id_sensibilidad_quimica", DbType.Int32, c.Id_sensibilidad_quimica);
                bd.CreateParameter("@id_facilidad_muerte", DbType.Int32, c.Id_facilidad_muerte);
                bd.CreateParameter("@dormancia", DbType.Int32, c.Dormancia);
                bd.CreateParameter("@tolerancia_sequia", DbType.Int32, c.Tolerancia_sequia);
                bd.CreateParameter("@tolerancia_calor", DbType.Int32, c.Tolerancia_calor);
                bd.CreateParameter("@tolerancia_sal", DbType.Int32, c.Tolerancia_sal);
                bd.CreateParameter("@dano_cosecha", DbType.Int32, c.Daño_cosecha);
                bd.CreateParameter("@tizon_hoja", DbType.Int32, c.Tizon_hoja);
                bd.CreateParameter("@putrefaccion_suave", DbType.Int32, c.Putrefaccion_suave);
                bd.CreateParameter("@putrefaccion_rosa", DbType.Int32, c.Putrefaccion_rosa);
                bd.CreateParameter("@silver_scurf", DbType.Int32, c.Silver_scurf);
                bd.CreateParameter("@blackleg", DbType.Int32, c.Blackleg);

                int actualizo;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                actualizo = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return actualizo;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Elimina una variedad en temporada 12papas a través del id_cosecha
         * Devuelve 1 si eliminó, 0 en caso contrario
         */
        public int DeleteCosecha12papas(int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosecha12papasEliminar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);

                int elimino;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                elimino = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return elimino;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        //--------------------------------------------FIN 12PAPAS-----------------------------------------------------------
        //--------------------------------------------INICIO 24PAPAS--------------------------------------------------------

        /*
         * Agrega temporada 24papas a una temporada 12papas, devuelve 0 si agrego correctamente, 1 en caso contrario
         */
        public int AddCosecha24papas(int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosecha24papasAgregar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);

                int existe_24papas;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                existe_24papas = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return existe_24papas;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
        * Actualizar la variedad en 24 papas, devuelve 1 si actualizó, 0 en caso contrario
        */
        public int UpdateCosecha24papas(Cosecha c)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosecha24papasActualizar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_cosecha", DbType.Int32, c.Id_cosecha);
                bd.CreateParameter("@cantidad_papas", DbType.Int32, c.Cantidad_papas);
                bd.CreateParameter("@posicion_cosecha", DbType.Double, c.Posicion_cosecha);
                bd.CreateParameter("@flor_cosecha", DbType.Boolean, c.Flor_cosecha);
                bd.CreateParameter("@bayas_cosecha", DbType.Boolean, c.Bayas_cosecha);
                bd.CreateParameter("@id_fertilidad", DbType.Int32, c.Id_fertilidad);
                bd.CreateParameter("@id_emergencia40", DbType.Int32, c.Id_emergencia_40_dias);
                bd.CreateParameter("@id_metribuzina", DbType.Int32, c.Id_metribuzina);
                bd.CreateParameter("@id_emergencia", DbType.Int32, c.Id_emergencia);
                bd.CreateParameter("@id_madurez", DbType.Int32, c.Id_madurez);
                bd.CreateParameter("@id_desarrollo_follaje", DbType.Int32, c.Id_desarrollo_follaje);
                bd.CreateParameter("@id_tipo_hoja", DbType.Int32, c.Id_tipo_hoja);
                bd.CreateParameter("@id_brotacion", DbType.Int32, c.Id_brotacion);
                bd.CreateParameter("@id_tamano", DbType.Int32, c.Id_tamaño);
                bd.CreateParameter("@id_distribucion", DbType.Int32, c.Id_distribucion_calibre);
                bd.CreateParameter("@id_forma", DbType.Int32, c.Id_forma);
                bd.CreateParameter("@id_regularidad", DbType.Int32, c.Id_regularidad);
                bd.CreateParameter("@id_profundidad", DbType.Int32, c.Id_profundidad);
                bd.CreateParameter("@id_calidad", DbType.Int32, c.Id_calidad_piel);
                bd.CreateParameter("@id_verdes", DbType.Int32, c.Id_tuberculos_verdes);
                bd.CreateParameter("@tizon_follaje", DbType.Int32, c.Id_tizon_tardio_follaje);
                bd.CreateParameter("@tizon_tuberculo", DbType.Int32, c.Id_tizon_tardio_tuberculo);
                bd.CreateParameter("@id_numero", DbType.Int32, c.Id_numero_tuberculos);
                bd.CreateParameter("@id_ciudad", DbType.Int32, c.Id_ciudad);
                bd.CreateParameter("@total_kg", DbType.Double, c.Total_kg);
                bd.CreateParameter("@tuberculos_planta", DbType.Double, c.Tuberculos_planta);
                bd.CreateParameter("@toneladas_hectarea", DbType.Double, c.Toneladas_hectarea);
                bd.CreateParameter("@porcentaje_relacion", DbType.Int32, c.Porcentaje_relacion_standard);
                bd.CreateParameter("@consumo", DbType.Int32, c.Consumo);
                bd.CreateParameter("@semillon", DbType.Int32, c.Semillon);
                bd.CreateParameter("@semilla", DbType.Int32, c.Semilla);
                bd.CreateParameter("@semillita", DbType.Int32, c.Semillita);
                bd.CreateParameter("@bajo_calibre", DbType.Int32, c.Bajo_calibre);
                bd.CreateParameter("@numero_tallos", DbType.Int32, c.Numero_tallos);
                bd.CreateParameter("@id_sensibilidad_quimica", DbType.Int32, c.Id_sensibilidad_quimica);
                bd.CreateParameter("@id_facilidad_muerte", DbType.Int32, c.Id_facilidad_muerte);
                bd.CreateParameter("@dormancia", DbType.Int32, c.Dormancia);
                bd.CreateParameter("@tolerancia_sequia", DbType.Int32, c.Tolerancia_sequia);
                bd.CreateParameter("@tolerancia_calor", DbType.Int32, c.Tolerancia_calor);
                bd.CreateParameter("@tolerancia_sal", DbType.Int32, c.Tolerancia_sal);
                bd.CreateParameter("@dano_cosecha", DbType.Int32, c.Daño_cosecha);
                bd.CreateParameter("@tizon_hoja", DbType.Int32, c.Tizon_hoja);
                bd.CreateParameter("@putrefaccion_suave", DbType.Int32, c.Putrefaccion_suave);
                bd.CreateParameter("@putrefaccion_rosa", DbType.Int32, c.Putrefaccion_rosa);
                bd.CreateParameter("@silver_scurf", DbType.Int32, c.Silver_scurf);
                bd.CreateParameter("@blackleg", DbType.Int32, c.Blackleg);

                int actualizo;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                actualizo = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return actualizo;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Elimina una variedad en temporada 24papas a través del id_cosecha
         * Devuelve 1 si eliminó, 0 en caso contrario
         */
        public int DeleteCosecha24papas(int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosecha24papasEliminar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);

                int elimino;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                elimino = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return elimino;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        //--------------------------------------------FIN 24PAPAS-----------------------------------------------------------
        //--------------------------------------------INICIO 48PAPAS--------------------------------------------------------

        /*
         * Agrega temporada 48papas a una temporada 24papas, devuelve 0 si agrego correctamente, 1 en caso contrario
         */
        public int AddCosecha48papas(int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosecha48papasAgregar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);

                int existe_48papas;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                existe_48papas = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return existe_48papas;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
        * Actualizar la variedad en 48 papas, devuelve 1 si actualizó, 0 en caso contrario
        */
        public int UpdateCosecha48papas(Cosecha c)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosecha48papasActualizar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_cosecha", DbType.Int32, c.Id_cosecha);
                bd.CreateParameter("@cantidad_papas", DbType.Int32, c.Cantidad_papas);
                bd.CreateParameter("@posicion_cosecha", DbType.Double, c.Posicion_cosecha);
                bd.CreateParameter("@flor_cosecha", DbType.Boolean, c.Flor_cosecha);
                bd.CreateParameter("@bayas_cosecha", DbType.Boolean, c.Bayas_cosecha);
                bd.CreateParameter("@id_fertilidad", DbType.Int32, c.Id_fertilidad);
                bd.CreateParameter("@id_emergencia40", DbType.Int32, c.Id_emergencia_40_dias);
                bd.CreateParameter("@id_metribuzina", DbType.Int32, c.Id_metribuzina);
                bd.CreateParameter("@id_emergencia", DbType.Int32, c.Id_emergencia);
                bd.CreateParameter("@id_madurez", DbType.Int32, c.Id_madurez);
                bd.CreateParameter("@id_desarrollo_follaje", DbType.Int32, c.Id_desarrollo_follaje);
                bd.CreateParameter("@id_tipo_hoja", DbType.Int32, c.Id_tipo_hoja);
                bd.CreateParameter("@id_brotacion", DbType.Int32, c.Id_brotacion);
                bd.CreateParameter("@id_tamano", DbType.Int32, c.Id_tamaño);
                bd.CreateParameter("@id_distribucion", DbType.Int32, c.Id_distribucion_calibre);
                bd.CreateParameter("@id_forma", DbType.Int32, c.Id_forma);
                bd.CreateParameter("@id_regularidad", DbType.Int32, c.Id_regularidad);
                bd.CreateParameter("@id_profundidad", DbType.Int32, c.Id_profundidad);
                bd.CreateParameter("@id_calidad", DbType.Int32, c.Id_calidad_piel);
                bd.CreateParameter("@id_verdes", DbType.Int32, c.Id_tuberculos_verdes);
                bd.CreateParameter("@tizon_follaje", DbType.Int32, c.Id_tizon_tardio_follaje);
                bd.CreateParameter("@tizon_tuberculo", DbType.Int32, c.Id_tizon_tardio_tuberculo);
                bd.CreateParameter("@id_numero", DbType.Int32, c.Id_numero_tuberculos);
                bd.CreateParameter("@id_ciudad", DbType.Int32, c.Id_ciudad);
                bd.CreateParameter("@total_kg", DbType.Double, c.Total_kg);
                bd.CreateParameter("@tuberculos_planta", DbType.Double, c.Tuberculos_planta);
                bd.CreateParameter("@toneladas_hectarea", DbType.Double, c.Toneladas_hectarea);
                bd.CreateParameter("@porcentaje_relacion", DbType.Int32, c.Porcentaje_relacion_standard);
                bd.CreateParameter("@consumo", DbType.Int32, c.Consumo);
                bd.CreateParameter("@semillon", DbType.Int32, c.Semillon);
                bd.CreateParameter("@semilla", DbType.Int32, c.Semilla);
                bd.CreateParameter("@semillita", DbType.Int32, c.Semillita);
                bd.CreateParameter("@bajo_calibre", DbType.Int32, c.Bajo_calibre);
                bd.CreateParameter("@numero_tallos", DbType.Int32, c.Numero_tallos);
                bd.CreateParameter("@id_sensibilidad_quimica", DbType.Int32, c.Id_sensibilidad_quimica);
                bd.CreateParameter("@id_facilidad_muerte", DbType.Int32, c.Id_facilidad_muerte);
                bd.CreateParameter("@dormancia", DbType.Int32, c.Dormancia);
                bd.CreateParameter("@tolerancia_sequia", DbType.Int32, c.Tolerancia_sequia);
                bd.CreateParameter("@tolerancia_calor", DbType.Int32, c.Tolerancia_calor);
                bd.CreateParameter("@tolerancia_sal", DbType.Int32, c.Tolerancia_sal);
                bd.CreateParameter("@dano_cosecha", DbType.Int32, c.Daño_cosecha);
                bd.CreateParameter("@tizon_hoja", DbType.Int32, c.Tizon_hoja);
                bd.CreateParameter("@putrefaccion_suave", DbType.Int32, c.Putrefaccion_suave);
                bd.CreateParameter("@putrefaccion_rosa", DbType.Int32, c.Putrefaccion_rosa);
                bd.CreateParameter("@silver_scurf", DbType.Int32, c.Silver_scurf);
                bd.CreateParameter("@blackleg", DbType.Int32, c.Blackleg);

                int actualizo;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                actualizo = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return actualizo;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve 1 si la cosecha ya está en UPOV
         */
        public int GetCosechaEstaEnUPOV(int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                int estaEnUPOV;

                string salida2 = "cosechaEstaEnUPOV";//comando sql
                bd.CreateCommandSP(salida2);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);
                DbDataReader resultado2 = bd.Query();//disponible resultado
                resultado2.Read();
                estaEnUPOV = resultado2.GetInt32(0);
                resultado2.Close();

                bd.Close();
                return estaEnUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve codigo del individuo, ciudad, porcentaje de relacion standard y las toneladas por hectárea de una cosecha
         */
        public List<Cosecha> GetTablaRendimiento48papas(int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Cosecha> cosecha48papas = new List<Cosecha>();
                string salida = "cosecha48papasTablaRendimientoObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);

                DbDataReader resultado = bd.Query();//disponible resultado

                while (resultado.Read())
                {
                    Cosecha cos = new Cosecha(resultado.GetString(0), resultado.GetString(1), resultado.GetInt32(2),
                        resultado.GetDouble(3));
                    cosecha48papas.Add(cos);
                }
                resultado.Close();
                bd.Close();

                return cosecha48papas;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Elimina una variedad en temporada 48papas a través del id_cosecha
         * Devuelve 1 si eliminó, 0 en caso contrario
         */
        public int DeleteCosecha48papas(int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosecha48papasEliminar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);

                int elimino;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                elimino = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return elimino;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        //--------------------------------------------FIN 48PAPAS-----------------------------------------------------------
        //--------------------------------------------INICIO METODOS COMUNES------------------------------------------------
        /*
         * Devuelve id_cosecha, madre, padre, posicion, individuo y destino para las distintas temporadas
         */
        public List<Cosecha> GetTablaCosecha(int año, int id_temporada)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Cosecha> cosecha6papas = new List<Cosecha>();
                string salida = "cosechaTablaObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@ano_cosecha", DbType.Int32, año);
                bd.CreateParameter("@id_temporada", DbType.Int32, id_temporada);

                DbDataReader resultado = bd.Query();//disponible resultado

                while (resultado.Read())
                {
                    Cosecha cos = new Cosecha(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2),
                        resultado.GetString(3), resultado.GetString(4), resultado.GetDouble(5), resultado.GetString(6),
                        resultado.GetString(7));
                    cosecha6papas.Add(cos);
                }
                resultado.Close();
                bd.Close();

                return cosecha6papas;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve 1 si la variedad ya esta en etapas avanzadas
         * el id_temporada recibe la temporada para el color verde o rojo
         * Se le resta 1 para obtener la tabla de la cosecha en la temporada anterior
         */
        public int GetCosechaTemporadasAvanzadas(int id_cosecha, int id_temporada)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                int estaEnCosecha;

                string salida2 = "cosechaEstaEnTemporadasAvanzadasObtener";//comando sql
                bd.CreateCommandSP(salida2);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);
                bd.CreateParameter("@id_temporada", DbType.Int32, id_temporada);
                DbDataReader resultado2 = bd.Query();//disponible resultado
                resultado2.Read();
                estaEnCosecha = resultado2.GetInt32(0);
                resultado2.Close();

                bd.Close();
                return estaEnCosecha;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        } 

        /*
         * Devuelve todos los atributos boolean segun la posicion del atributo en el procedimiento almacenado
         */
        public bool GetCosechaValoresBooleanos(int id_cosecha, int posicion_atributo)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar            
                string salida = "cosechaSeleccionObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);
                DbDataReader resultado = bd.Query();//disponible resultado            
                resultado.Read();
                bool atributo = resultado.GetBoolean(posicion_atributo);
                resultado.Close();
                bd.Close();
                return atributo;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve todos los atributos enteros segun la posicion del atributo en el procedimiento almacenado
         */
        public int GetCosechaValoresEnteros(int id_cosecha, int posicion_atributo)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar            
                string salida = "cosechaSeleccionObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);
                DbDataReader resultado = bd.Query();//disponible resultado            
                resultado.Read();
                int atributo = resultado.GetInt32(posicion_atributo);
                resultado.Close();
                bd.Close();
                return atributo;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve todos los atributos double segun la posicion del atributo en el procedimiento almacenado
         */
        public double GetCosechaValoresDouble(int id_cosecha, int posicion_atributo)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar            
                string salida = "cosechaSeleccionObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);
                DbDataReader resultado = bd.Query();//disponible resultado            
                resultado.Read();
                double atributo = resultado.GetDouble(posicion_atributo);
                resultado.Close();
                bd.Close();
                return atributo;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
        * Actualizar el color de la carne de la variedad en cualquier temporada
        */
        public void UpdateCosechaColorCarne(int id_color_carne, int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosechaColorCarneActualizar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_color_carne", DbType.Int32, id_color_carne);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
        * Elimina el color de la carne de la variedad en cualquier temporada
        */
        public void DeleteCosechaColorCarne(int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosechaColorCarneEliminar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve el id_color_carne de la cosecha seleccionada
         */
        public List<Cosecha> GetCosechaColorCarne(int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Cosecha> colores = new List<Cosecha>();
                string salida = "cosechaColorCarneObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);

                DbDataReader resultado = bd.Query();//disponible resultado

                while (resultado.Read())
                {
                    Cosecha color = new Cosecha(resultado.GetInt32(0));
                    colores.Add(color);
                }
                resultado.Close();
                bd.Close();

                return colores;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
        * Actualizar el color de la carne de la variedad en cualquier temporada
        */
        public void UpdateCosechaColorPiel(int id_color_piel, int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosechaColorPielActualizar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_color_piel", DbType.Int32, id_color_piel);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
        * Elimina el color de la piel de la variedad en cualquier temporada
        */
        public void DeleteCosechaColorPiel(int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosechaColorPielEliminar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve el id_color_piel de la cosecha seleccionada
         */
        public List<Cosecha> GetCosechaColorPiel(int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Cosecha> colores = new List<Cosecha>();
                string salida = "cosechaColorPielObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);

                DbDataReader resultado = bd.Query();//disponible resultado

                while (resultado.Read())
                {
                    Cosecha color = new Cosecha(resultado.GetInt32(0));
                    colores.Add(color);
                }
                resultado.Close();
                bd.Close();

                return colores;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Agrega enfermedades a la variedad, devuelve 0 si agrego correctamente, 1 en caso contrario
         */
        public int AddCosechaEnfermedades(string nombre_enfermedad, int id_cosecha, string nombre_resistencia_variedad)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosechaEnfermedadesAgregar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@nombre_enfermedad", DbType.String, nombre_enfermedad);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);
                bd.CreateParameter("@nombre_resistencia_variedad", DbType.String, nombre_resistencia_variedad);

                int existe_enfermedad;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                existe_enfermedad = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return existe_enfermedad;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
        * Elimina la enfermedad de la variedad en cualquier temporada
        */
        public void DeleteCosechaEnfermedades(int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "cosechaEnfermedadesEliminar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve el nombre de la enfermedad y resistencia de la variedad en la cosecha seleccionada
         */
        public List<Cosecha> GetCosechaEnfermedades(int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Cosecha> enfermedades = new List<Cosecha>();
                string salida = "cosechaEnfermedadesObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);

                DbDataReader resultado = bd.Query();//disponible resultado

                while (resultado.Read())
                {
                    Cosecha color = new Cosecha(resultado.GetString(0), resultado.GetString(1));
                    enfermedades.Add(color);
                }
                resultado.Close();
                bd.Close();

                return enfermedades;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        //--------------------------------------------FIN METODOS COMUNES-------------------------------------------------------
    }
}