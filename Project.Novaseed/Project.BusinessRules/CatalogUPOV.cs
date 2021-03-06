﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data;
using System.Data.Common;

namespace Project.BusinessRules
{
    public class CatalogUPOV
    {
        /*
         * Agrega informe UPOV, devuelve 0 si agrego correctamente, 1 en caso contrario
         */
        public int AddUPOV(int id_cosecha)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "upovAgregar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_cosecha", DbType.Int32, id_cosecha);

                int existe_upov;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                existe_upov = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return existe_upov;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Actualizar el informe upov, devuelve 1 si actualizó, 0 en caso contrario
         */
        public int UpdateUPOV(UPOV u)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "upovActualizarAgregarVariedadMadrePadreProduccion";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_upov", DbType.Int32, u.Id_upov);
                bd.CreateParameter("@id_inflorescencia_tamano", DbType.Int32, u.Id_inflorescencia_tamano);
                bd.CreateParameter("@id_brote_tamano_extremo", DbType.Int32, u.Id_brote_tamano_extremo);
                bd.CreateParameter("@id_brote_forma", DbType.Int32, u.Id_brote_forma);
                bd.CreateParameter("@id_brote_proporcion_azul", DbType.Int32, u.Id_brote_proporcion_azul);
                bd.CreateParameter("@id_foliolo_brillo_haz", DbType.Int32, u.Id_foliolo_brillo_haz);
                bd.CreateParameter("@id_boton_floral_pigmentacion", DbType.Int32, u.Id_boton_floral_pigmentacion);
                bd.CreateParameter("@id_brote_pigmentacion_base", DbType.Int32, u.Id_brote_pigmentacion_base);
                bd.CreateParameter("@id_hoja_tamano_contorno", DbType.Int32, u.Id_hoja_tamano_contorno);
                bd.CreateParameter("@id_foliolo_pubescencia_haz_roseta_apical", DbType.Int32, u.Id_foliolo_pubescencia_haz_roseta_apical);
                bd.CreateParameter("@id_foliolo_ondulacion_borde", DbType.Int32, u.Id_foliolo_ondulacion_borde);
                bd.CreateParameter("@id_brote_radiculas", DbType.Int32, u.Id_brote_radiculas);
                bd.CreateParameter("@id_segundo_par_foliolos_anchura_longitud", DbType.Int32, u.Id_segundo_par_foliolos_anchura_longitud);
                bd.CreateParameter("@id_brote_porte_extremo", DbType.Int32, u.Id_brote_porte_extremo);
                bd.CreateParameter("@id_profundidad", DbType.Int32, u.Id_profundidad);
                bd.CreateParameter("@id_planta_porte", DbType.Int32, u.Id_planta_porte);
                bd.CreateParameter("@id_segundo_par_foliolos_tamano", DbType.Int32, u.Id_segundo_par_foliolos_tamano);
                bd.CreateParameter("@id_planta_altura", DbType.Int32, u.Id_planta_altura);
                bd.CreateParameter("@id_brote_pigmentacion_extremo", DbType.Int32, u.Id_brote_pigmentacion_extremo);
                bd.CreateParameter("@id_hoja_foliolos_secundarios", DbType.Int32, u.Id_hoja_foliolos_secundarios);
                bd.CreateParameter("@id_foliolos_terminales_coalescencia", DbType.Int32, u.Id_foliolos_terminales_coalescencia);
                bd.CreateParameter("@id_hoja_pigmentacion_nervio_central", DbType.Int32, u.Id_hoja_pigmentacion_nervio_central);
                bd.CreateParameter("@id_tuberculo_color_base_ojo", DbType.Int32, u.Id_tuberculo_color_base_ojo);
                bd.CreateParameter("@id_brote_longitud_ramificaciones_laterales", DbType.Int32, u.Id_brote_longitud_ramificaciones_laterales);
                bd.CreateParameter("@id_foliolo_profundidad_nervios", DbType.Int32, u.Id_foliolo_profundidad_nervios);
                bd.CreateParameter("@id_forma", DbType.Int32, u.Id_forma);
                bd.CreateParameter("@id_tallo_pigmentacion", DbType.Int32, u.Id_tallo_pigmentacion);
                bd.CreateParameter("@id_brote_pubescencia_base", DbType.Int32, u.Id_brote_pubescencia_base);
                bd.CreateParameter("@id_corola_flor_intensidad_pigmentacion_cara_interna", DbType.Int32, u.Id_corola_flor_intensidad_pigmentacion_cara_interna);
                bd.CreateParameter("@id_tuberculo_pigmentacion_piel_reaccion_luz", DbType.Int32, u.Id_tuberculo_pigmentacion_piel_reaccion_luz);
                bd.CreateParameter("@id_corola_flor_proporcion_azul_pigmentacion_cara_interna", DbType.Int32, u.Id_corola_flor_proporcion_azul_pigmentacion_cara_interna);
                bd.CreateParameter("@id_corola_flor_tamano", DbType.Int32, u.Id_corola_flor_tamano);
                bd.CreateParameter("@id_hoja_apertura", DbType.Int32, u.Id_hoja_apertura);
                bd.CreateParameter("@id_planta_estructura_follaje", DbType.Int32, u.Id_planta_estructura_follaje);
                bd.CreateParameter("@id_hoja_color_verde", DbType.Int32, u.Id_hoja_color_verde);
                bd.CreateParameter("@id_planta_frecuencia_flores", DbType.Int32, u.Id_planta_frecuencia_flores);
                bd.CreateParameter("@id_planta_epoca_madurez", DbType.Int32, u.Id_planta_epoca_madurez);
                bd.CreateParameter("@id_inflorescencia_pigmentacion_pendunculo", DbType.Int32, u.Id_inflorescencia_pigmentacion_pendunculo);
                bd.CreateParameter("@id_brote_pubescencia_extremo", DbType.Int32, u.Id_brote_pubescencia_extremo);
                bd.CreateParameter("@id_corola_flor_extension_pigmentacion_cara_interna", DbType.Int32, u.Id_corola_flor_extension_pigmentacion_cara_interna);
                bd.CreateParameter("@id_brote_tamano", DbType.Int32, u.Id_brote_tamano);
                bd.CreateParameter("@nombre_variedad_upov", DbType.String, u.Nombre_variedad_upov);

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
         * Devuelve las cosechas que tienen o pueden generar el informe upov
         */
        public List<UPOV> GetTablaUPOV(int año_upov)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOV> upov = new List<UPOV>();
                string salida = "upovTablaObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@ano_upov", DbType.Int32, año_upov);

                DbDataReader resultado = bd.Query();//disponible resultado

                while (resultado.Read())
                {
                    UPOV up = new UPOV(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2),
                        resultado.GetString(3), resultado.GetString(4), resultado.GetString(5), resultado.GetString(6),
                        resultado.GetString(7));
                    upov.Add(up);
                }
                resultado.Close();
                bd.Close();

                return upov;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve una lista con las variedades que tienen informe upov
         */
        public List<UPOV> GetTablaUPOVVariedades(string nombre_variedad)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOV> upov = new List<UPOV>();
                string salida = "upovTablaVariedadesObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@nombre_variedad", DbType.String, nombre_variedad);

                DbDataReader resultado = bd.Query();//disponible resultado

                while (resultado.Read())
                {
                    UPOV up = new UPOV(resultado.GetInt32(0), resultado.GetString(1), resultado.GetInt32(2));
                    upov.Add(up);
                }
                resultado.Close();
                bd.Close();

                return upov;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve una lista con las variedades que tienen informe upov
         * Metodo para generar el reporte
         */
        public DataSet GetUPOVReporte(int id_upov)
        {
            try
            {
                DataAccess.DataBase bd = new DataAccess.DataBase();
                DataSet set = new DataSet();
                string salida = "upovNombresReporte";//comando sql
                set = bd.SetSP(salida, "@id_upov", DbType.Int32, id_upov);
                return set;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }        

        /*
         * Devuelve el informe upov con todas sus caracteristicas
         * Metodo de año de generacion, categoria UPOV
         */
        public List<UPOV> GetUPOV(int id_upov)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOV> upov = new List<UPOV>();
                string salida = "upovObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@id_upov", DbType.Int32, id_upov);

                DbDataReader resultado = bd.Query();//disponible resultado

                while (resultado.Read())
                {
                    UPOV up = new UPOV(resultado.GetInt32(0), resultado.GetInt32(1), resultado.GetInt32(2), resultado.GetInt32(3),
                        resultado.GetInt32(4), resultado.GetInt32(5), resultado.GetInt32(6), resultado.GetInt32(7), resultado.GetInt32(8),
                        resultado.GetInt32(9), resultado.GetInt32(10), resultado.GetInt32(11), resultado.GetInt32(12),
                        resultado.GetInt32(13), resultado.GetInt32(14), resultado.GetInt32(15), resultado.GetInt32(16),
                        resultado.GetInt32(17), resultado.GetInt32(18), resultado.GetInt32(19), resultado.GetInt32(20),
                        resultado.GetInt32(21), resultado.GetInt32(22), resultado.GetInt32(23), resultado.GetInt32(24),
                        resultado.GetInt32(25), resultado.GetInt32(26), resultado.GetInt32(27), resultado.GetInt32(28),
                        resultado.GetInt32(29), resultado.GetInt32(30), resultado.GetInt32(31), resultado.GetInt32(32),
                        resultado.GetInt32(33), resultado.GetInt32(34), resultado.GetInt32(35), resultado.GetInt32(36),
                        resultado.GetInt32(37), resultado.GetInt32(38), resultado.GetInt32(39), resultado.GetInt32(40),
                        resultado.GetString(42), resultado.GetString(44), resultado.GetString(45));
                    upov.Add(up);
                }
                resultado.Close();
                bd.Close();

                return upov;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve 1 si el informe UPOV ya está en generado
         */
        public int GetUPOVEstaGenerado(int id_upov)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                int estaGenerado;
                
                string salida2 = "upovEstaGenerado";//comando sql
                bd.CreateCommandSP(salida2);
                bd.CreateParameter("@id_upov", DbType.Int32, id_upov);
                DbDataReader resultado2 = bd.Query();//disponible resultado
                resultado2.Read();
                estaGenerado = resultado2.GetInt32(0);
                resultado2.Close();

                bd.Close();
                return estaGenerado;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Funcion que devuelve una lista de años comenzando del primer informe upov hasta el ultimo
         */
        public List<UPOV> GetAñoUPOVProduccion_fn()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOV> años = new List<UPOV>();
                string salida = "select * from dbo.fn_añoUPOVProduccionObtener()";//comando sql
                bd.CreateCommand(salida);

                DbDataReader resultado = bd.Query();//disponible resultado

                while (resultado.Read())
                {
                    UPOV upov = new UPOV(resultado.GetInt32(0));
                    años.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return años;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
        * Actualizar el color de la carne de la variedad en el informe upov
        */
        public void UpdateUPOVColorCarne(int id_color_carne, int id_upov)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "upovColorCarneActualizar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_color_carne", DbType.Int32, id_color_carne);
                bd.CreateParameter("@id_upov", DbType.Int32, id_upov);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
        * Elimina el color de la carne de la variedad en el informe upov
        */
        public void DeleteUPOVColorCarne(int id_upov)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "upovColorCarneEliminar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_upov", DbType.Int32, id_upov);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve el id_color_carne del informe upov seleccionada
         */
        public List<UPOV> GetUPOVColorCarne(int id_upov)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOV> colores = new List<UPOV>();
                string salida = "upovColorCarneObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@id_upov", DbType.Int32, id_upov);

                DbDataReader resultado = bd.Query();//disponible resultado

                while (resultado.Read())
                {
                    UPOV color = new UPOV(resultado.GetInt32(0));
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
        * Actualizar el color de la piel de la variedad en el informe upov
        */
        public void UpdateUPOVColorPiel(int id_color_piel, int id_upov)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "upovColorPielActualizar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_color_piel", DbType.Int32, id_color_piel);
                bd.CreateParameter("@id_upov", DbType.Int32, id_upov);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
        * Elimina el color de la piel de la variedad en el informe upov
        */
        public void DeleteUPOVColorPiel(int id_upov)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "upovColorPielEliminar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_upov", DbType.Int32, id_upov);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve el id_color_piel del informe upov seleccionada
         */
        public List<UPOV> GetUPOVColorPiel(int id_upov)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOV> colores = new List<UPOV>();
                string salida = "upovColorPielObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@id_upov", DbType.Int32, id_upov);

                DbDataReader resultado = bd.Query();//disponible resultado

                while (resultado.Read())
                {
                    UPOV color = new UPOV(resultado.GetInt32(0));
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

        //----------------------------------------------CARACTERISTICAS UPOV--------------------------------------------      
        /*
         * Obtiene Boton Floral Pigmentacion para el informe upov
         */
        public List<UPOVBotonFloralPigmentacion> GetUPOVBotonFloralPigmentacion()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVBotonFloralPigmentacion> listUPOV = new List<UPOVBotonFloralPigmentacion>();
                string sql = "upovBotonFloralPigmentacionObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVBotonFloralPigmentacion upov = new UPOVBotonFloralPigmentacion(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Brote Forma para el informe upov
         */
        public List<UPOVBroteForma> GetUPOVBroteForma()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVBroteForma> listUPOV = new List<UPOVBroteForma>();
                string sql = "upovBroteFormaObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVBroteForma upov = new UPOVBroteForma(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Brote Longitud Ramificaciones Laterales para el informe upov
         */
        public List<UPOVBroteLongitudRamificacionesLaterales> GetUPOVBroteLongitudRamificacionesLaterales()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVBroteLongitudRamificacionesLaterales> listUPOV = new List<UPOVBroteLongitudRamificacionesLaterales>();
                string sql = "upovBroteLongitudRamificacionesLateralesObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVBroteLongitudRamificacionesLaterales upov = new UPOVBroteLongitudRamificacionesLaterales(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Brote Pigmentacion Base para el informe upov
         */
        public List<UPOVBrotePigmentacionBase> GetUPOVBrotePigmentacionBase()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVBrotePigmentacionBase> listUPOV = new List<UPOVBrotePigmentacionBase>();
                string sql = "upovBrotePigmentacionBaseObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVBrotePigmentacionBase upov = new UPOVBrotePigmentacionBase(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Brote Pigmentacion Extremo para el informe upov
         */
        public List<UPOVBrotePigmentacionExtremo> GetUPOVBrotePigmentacionExtremo()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVBrotePigmentacionExtremo> listUPOV = new List<UPOVBrotePigmentacionExtremo>();
                string sql = "upovBrotePigmentacionExtremoObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVBrotePigmentacionExtremo upov = new UPOVBrotePigmentacionExtremo(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Brote Porte Extremo para el informe upov
         */
        public List<UPOVBrotePorteExtremo> GetUPOVBrotePorteExtremo()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVBrotePorteExtremo> listUPOV = new List<UPOVBrotePorteExtremo>();
                string sql = "upovBrotePorteExtremoObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVBrotePorteExtremo upov = new UPOVBrotePorteExtremo(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Brote Proporcion Azul para el informe upov
         */
        public List<UPOVBroteProporcionAzul> GetUPOVBroteProporcionAzul()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVBroteProporcionAzul> listUPOV = new List<UPOVBroteProporcionAzul>();
                string sql = "upovBroteProporcionAzulObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVBroteProporcionAzul upov = new UPOVBroteProporcionAzul(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Brote Pubescencia Base para el informe upov
         */
        public List<UPOVBrotePubescenciaBase> GetUPOVBrotePubescenciaBase()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVBrotePubescenciaBase> listUPOV = new List<UPOVBrotePubescenciaBase>();
                string sql = "upovBrotePubescenciaBaseObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVBrotePubescenciaBase upov = new UPOVBrotePubescenciaBase(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Brote Pubescencia Extremo para el informe upov
         */
        public List<UPOVBrotePubescenciaExtremo> GetUPOVBrotePubescenciaExtremo()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVBrotePubescenciaExtremo> listUPOV = new List<UPOVBrotePubescenciaExtremo>();
                string sql = "upovBrotePubescenciaExtremoObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVBrotePubescenciaExtremo upov = new UPOVBrotePubescenciaExtremo(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Brote Radiculas para el informe upov
         */
        public List<UPOVBroteRadiculas> GetUPOVBroteRadiculas()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVBroteRadiculas> listUPOV = new List<UPOVBroteRadiculas>();
                string sql = "upovBroteRadiculasObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVBroteRadiculas upov = new UPOVBroteRadiculas(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Brote Tamaño para el informe upov
         */
        public List<UPOVBroteTamaño> GetUPOVBroteTamaño()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVBroteTamaño> listUPOV = new List<UPOVBroteTamaño>();
                string sql = "upovBroteTamañoObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVBroteTamaño upov = new UPOVBroteTamaño(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Brote Tamaño Extremo para el informe upov
         */
        public List<UPOVBroteTamañoExtremo> GetUPOVBroteTamañoExtremo()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVBroteTamañoExtremo> listUPOV = new List<UPOVBroteTamañoExtremo>();
                string sql = "upovBroteTamañoExtremoObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVBroteTamañoExtremo upov = new UPOVBroteTamañoExtremo(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Corola Flor Extension Pigmentacion Cara Interna para el informe upov
         */
        public List<UPOVCorolaFlorExtensionPigmentacionCaraInterna> GetUPOVCorolaFlorExtensionPigmentacionCaraInterna()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVCorolaFlorExtensionPigmentacionCaraInterna> listUPOV = new List<UPOVCorolaFlorExtensionPigmentacionCaraInterna>();
                string sql = "upovCorolaFlorExtensionPigmentacionCaraInternaObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVCorolaFlorExtensionPigmentacionCaraInterna upov = new UPOVCorolaFlorExtensionPigmentacionCaraInterna(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Corola Flor Intensidad Pigmentacion Cara Interna para el informe upov
         */
        public List<UPOVCorolaFlorIntensidadPigmentacionCaraInterna> GetUPOVCorolaFlorIntensidadPigmentacionCaraInterna()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVCorolaFlorIntensidadPigmentacionCaraInterna> listUPOV = new List<UPOVCorolaFlorIntensidadPigmentacionCaraInterna>();
                string sql = "upovCorolaFlorIntensidadPigmentacionCaraInternaObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVCorolaFlorIntensidadPigmentacionCaraInterna upov = new UPOVCorolaFlorIntensidadPigmentacionCaraInterna(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Corola Flor Proporcion Azul Pigmentacion Cara Interna para el informe upov
         */
        public List<UPOVCorolaFlorProporcionAzulPigmentacionCaraInterna> GetUPOVCorolaFlorProporcionAzulPigmentacionCaraInterna()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVCorolaFlorProporcionAzulPigmentacionCaraInterna> listUPOV = new List<UPOVCorolaFlorProporcionAzulPigmentacionCaraInterna>();
                string sql = "upovCorolaFlorProporcionAzulPigmentacionCaraInternaObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVCorolaFlorProporcionAzulPigmentacionCaraInterna upov = new UPOVCorolaFlorProporcionAzulPigmentacionCaraInterna(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Corola Flor Tamaño para el informe upov
         */
        public List<UPOVCorolaFlorTamaño> GetUPOVCorolaFlorTamaño()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVCorolaFlorTamaño> listUPOV = new List<UPOVCorolaFlorTamaño>();
                string sql = "upovCorolaFlorTamañoObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVCorolaFlorTamaño upov = new UPOVCorolaFlorTamaño(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Foliolo Brillo Haz para el informe upov
         */
        public List<UPOVFolioloBrilloHaz> GetUPOVFolioloBrilloHaz()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVFolioloBrilloHaz> listUPOV = new List<UPOVFolioloBrilloHaz>();
                string sql = "upovFolioloBrilloHazObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVFolioloBrilloHaz upov = new UPOVFolioloBrilloHaz(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Foliolo Ondulacion Borde para el informe upov
         */
        public List<UPOVFolioloOndulacionBorde> GetUPOVFolioloOndulacionBorde()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVFolioloOndulacionBorde> listUPOV = new List<UPOVFolioloOndulacionBorde>();
                string sql = "upovFolioloOndulacionBordeObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVFolioloOndulacionBorde upov = new UPOVFolioloOndulacionBorde(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Foliolo Profundidad Nervios para el informe upov
         */
        public List<UPOVFolioloProfundidadNervios> GetUPOVFolioloProfundidadNervios()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVFolioloProfundidadNervios> listUPOV = new List<UPOVFolioloProfundidadNervios>();
                string sql = "upovFolioloProfundidadNerviosObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVFolioloProfundidadNervios upov = new UPOVFolioloProfundidadNervios(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Foliolo Pubescencia Haz Roseta Apical para el informe upov
         */
        public List<UPOVFolioloPubescenciaHazRosetaApical> GetUPOVFolioloPubescenciaHazRosetaApical()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVFolioloPubescenciaHazRosetaApical> listUPOV = new List<UPOVFolioloPubescenciaHazRosetaApical>();
                string sql = "upovFolioloPubescenciaHazRosetaApicalObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVFolioloPubescenciaHazRosetaApical upov = new UPOVFolioloPubescenciaHazRosetaApical(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Foliolos Terminales Coalescencia para el informe upov
         */
        public List<UPOVFoliolosTerminalesCoalescencia> GetUPOVFoliolosTerminalesCoalescencia()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVFoliolosTerminalesCoalescencia> listUPOV = new List<UPOVFoliolosTerminalesCoalescencia>();
                string sql = "upovFoliolosTerminalesCoalescenciaObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVFoliolosTerminalesCoalescencia upov = new UPOVFoliolosTerminalesCoalescencia(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Hoja Apertura para el informe upov
         */
        public List<UPOVHojaApertura> GetUPOVHojaApertura()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVHojaApertura> listUPOV = new List<UPOVHojaApertura>();
                string sql = "upovHojaAperturaObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVHojaApertura upov = new UPOVHojaApertura(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Hoja Color Verde para el informe upov
         */
        public List<UPOVHojaColorVerde> GetUPOVHojaColorVerde()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVHojaColorVerde> listUPOV = new List<UPOVHojaColorVerde>();
                string sql = "upovHojaColorVerdeObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVHojaColorVerde upov = new UPOVHojaColorVerde(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Hoja Foliolos Secundarios para el informe upov
         */
        public List<UPOVHojaFoliolosSecundarios> GetUPOVHojaFoliolosSecundarios()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVHojaFoliolosSecundarios> listUPOV = new List<UPOVHojaFoliolosSecundarios>();
                string sql = "upovHojaFoliolosSecundariosObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVHojaFoliolosSecundarios upov = new UPOVHojaFoliolosSecundarios(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Hoja Pigmentacion Nervio Central para el informe upov
         */
        public List<UPOVHojaPigmentacionNervioCentral> GetUPOVHojaPigmentacionNervioCentral()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVHojaPigmentacionNervioCentral> listUPOV = new List<UPOVHojaPigmentacionNervioCentral>();
                string sql = "upovHojaPigmentacionNervioCentralObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVHojaPigmentacionNervioCentral upov = new UPOVHojaPigmentacionNervioCentral(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Hoja Tamaño Contorno para el informe upov
         */
        public List<UPOVHojaTamañoContorno> GetUPOVHojaTamañoContorno()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVHojaTamañoContorno> listUPOV = new List<UPOVHojaTamañoContorno>();
                string sql = "upovHojaTamañoContornoObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVHojaTamañoContorno upov = new UPOVHojaTamañoContorno(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Inflorescencia Pigmentacion Pendunculo para el informe upov
         */
        public List<UPOVInflorescenciaPigmentacionPendunculo> GetUPOVInflorescenciaPigmentacionPendunculo()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVInflorescenciaPigmentacionPendunculo> listUPOV = new List<UPOVInflorescenciaPigmentacionPendunculo>();
                string sql = "upovInflorescenciaPigmentacionPendunculoObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVInflorescenciaPigmentacionPendunculo upov = new UPOVInflorescenciaPigmentacionPendunculo(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Inflorescencia Tamaño para el informe upov
         */
        public List<UPOVInflorescenciaTamaño> GetUPOVInflorescenciaTamaño()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVInflorescenciaTamaño> listUPOV = new List<UPOVInflorescenciaTamaño>();
                string sql = "upovInflorescenciaTamañoObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVInflorescenciaTamaño upov = new UPOVInflorescenciaTamaño(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Planta Altura para el informe upov
         */
        public List<UPOVPlantaAltura> GetUPOVPlantaAltura()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVPlantaAltura> listUPOV = new List<UPOVPlantaAltura>();
                string sql = "upovPlantaAlturaObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVPlantaAltura upov = new UPOVPlantaAltura(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Planta Epoca Madurez para el informe upov
         */
        public List<UPOVPlantaEpocaMadurez> GetUPOVPlantaEpocaMadurez()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVPlantaEpocaMadurez> listUPOV = new List<UPOVPlantaEpocaMadurez>();
                string sql = "upovPlantaEpocaMadurezObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVPlantaEpocaMadurez upov = new UPOVPlantaEpocaMadurez(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Planta Estructura Follaje para el informe upov
         */
        public List<UPOVPlantaEstructuraFollaje> GetUPOVPlantaEstructuraFollaje()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVPlantaEstructuraFollaje> listUPOV = new List<UPOVPlantaEstructuraFollaje>();
                string sql = "upovPlantaEstructuraFollajeObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVPlantaEstructuraFollaje upov = new UPOVPlantaEstructuraFollaje(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Planta Frecuencia Flores para el informe upov
         */
        public List<UPOVPlantaFrecuenciaFlores> GetUPOVPlantaFrecuenciaFlores()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVPlantaFrecuenciaFlores> listUPOV = new List<UPOVPlantaFrecuenciaFlores>();
                string sql = "upovPlantaFrecuenciaFloresObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVPlantaFrecuenciaFlores upov = new UPOVPlantaFrecuenciaFlores(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Planta Porte para el informe upov
         */
        public List<UPOVPlantaPorte> GetUPOVPlantaPorte()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVPlantaPorte> listUPOV = new List<UPOVPlantaPorte>();
                string sql = "upovPlantaPorteObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVPlantaPorte upov = new UPOVPlantaPorte(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Segundo Par Foliolos Anchura Longitud para el informe upov
         */
        public List<UPOVSegundoParFoliolosAnchuraLongitud> GetUPOVSegundoParFoliolosAnchuraLongitud()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVSegundoParFoliolosAnchuraLongitud> listUPOV = new List<UPOVSegundoParFoliolosAnchuraLongitud>();
                string sql = "upovSegundoParFoliolosAnchuraLongitudObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVSegundoParFoliolosAnchuraLongitud upov = new UPOVSegundoParFoliolosAnchuraLongitud(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Segundo Par Foliolos Tamaño para el informe upov
         */
        public List<UPOVSegundoParFoliolosTamaño> GetUPOVSegundoParFoliolosTamaño()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVSegundoParFoliolosTamaño> listUPOV = new List<UPOVSegundoParFoliolosTamaño>();
                string sql = "upovSegundoParFoliolosTamañoObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVSegundoParFoliolosTamaño upov = new UPOVSegundoParFoliolosTamaño(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Tallo Pigmentacion para el informe upov
         */
        public List<UPOVTalloPigmentacion> GetUPOVTalloPigmentacion()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVTalloPigmentacion> listUPOV = new List<UPOVTalloPigmentacion>();
                string sql = "upovTalloPigmentacionObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVTalloPigmentacion upov = new UPOVTalloPigmentacion(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Tuberculo Color Base Ojo para el informe upov
         */
        public List<UPOVTuberculoColorBaseOjo> GetUPOVTuberculoColorBaseOjo()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVTuberculoColorBaseOjo> listUPOV = new List<UPOVTuberculoColorBaseOjo>();
                string sql = "upovTuberculoColorBaseOjoObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVTuberculoColorBaseOjo upov = new UPOVTuberculoColorBaseOjo(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Obtiene Tuberculo Pigmentacion Piel Reaccion Luz para el informe upov
         */
        public List<UPOVTuberculoPigmentacionPielReaccionLuz> GetUPOVTuberculoPigmentacionPielReaccionLuz()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<UPOVTuberculoPigmentacionPielReaccionLuz> listUPOV = new List<UPOVTuberculoPigmentacionPielReaccionLuz>();
                string sql = "upovTuberculoPigmentacionPielReaccionLuzObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    UPOVTuberculoPigmentacionPielReaccionLuz upov = new UPOVTuberculoPigmentacionPielReaccionLuz(resultado.GetInt32(0), resultado.GetString(1));
                    listUPOV.Add(upov);
                }
                resultado.Close();
                bd.Close();

                return listUPOV;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}