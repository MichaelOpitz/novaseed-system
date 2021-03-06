﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;
using System.Data;

namespace Project.BusinessRules
{
    public class CatalogVasos
    {
        /*
         * Agregar vasos por defecto y por primera vez para luego ser modificado en la tabla vasos
         */
        public int AddVasos(int id_cruzamiento, string codigo_variedad, string pad_codigo_variedad)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "vasosAgregar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_cruzamiento", DbType.Int32, id_cruzamiento);
                bd.CreateParameter("@codigo_variedad", DbType.String, codigo_variedad);
                bd.CreateParameter("@pad_codigo_variedad", DbType.String, pad_codigo_variedad);

                int existe_vaso;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                existe_vaso = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return existe_vaso;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Actualizar vasos.
         */
        public int UpdateVasos(Vasos v)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "vasosActualizar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_vasos", DbType.Int32, v.Id_vasos);
                bd.CreateParameter("@ubicacion_vasos", DbType.String, v.Ubicacion_vasos);
                bd.CreateParameter("@cantidad_vasos", DbType.Int32, v.Cantidad_vasos);
                bd.CreateParameter("@id_fertilidad", DbType.Int32, v.Id_fertilidad);
                bd.CreateParameter("@azul_vasos", DbType.Int32, v.Azul_vasos);
                bd.CreateParameter("@roja_vasos", DbType.Int32, v.Roja_vasos);
                bd.CreateParameter("@amarilla_vasos", DbType.Int32, v.Amarilla_vasos);
                bd.CreateParameter("@bicolor_vasos", DbType.Int32, v.Bicolor_vasos);
                bd.CreateParameter("@ano_vasos", DbType.Int32, v.Ano_vasos);
                
                int existe_ubicacion;
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                existe_ubicacion = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return existe_ubicacion;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Elimina un vaso a través del id_vasos
         * Devuelve 1 si eliminó, 0 en caso contrario
         */
        public int DeleteVasos(int id_vasos)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "vasosEliminar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@id_vasos", DbType.Int32, id_vasos);

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

        /*
         * Metodo que trae la cantidad total de todos los vasos en un año determinado
         */
        public int GetCantidadTotalVasos_fn(int año_vasos)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                int cantidad;
                string salida = "select dbo.fn_vasosCantidadTotalObtener(" + año_vasos + ")";//comando sql
                bd.CreateCommand(salida);

                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                cantidad = resultado.GetInt32(0);

                resultado.Close();
                bd.Close();

                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve el vaso, con el nombre de fertilidad en vez de la id, sin colores
         */
        public List<Vasos> GetVasos(int año)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Vasos> vasos = new List<Vasos>();
                string salida = "vasosObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@ano_vasos", DbType.Int32, año);

                DbDataReader resultado = bd.Query();//disponible resultado

                while (resultado.Read())
                {
                    Vasos vaso = new Vasos(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2),
                        resultado.GetString(3), resultado.GetString(4), resultado.GetString(5), resultado.GetInt32(6),
                        resultado.GetString(7));
                    vasos.Add(vaso);
                }
                resultado.Close();
                bd.Close();

                return vasos;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        
        /*
         * Devuelve el vaso completo, con el nombre de fertilidad en vez de la id
         */
        public List<Vasos> GetVasosColores(int año)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Vasos> vasos = new List<Vasos>();
                string salida = "vasosObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@ano_vasos", DbType.Int32, año);

                DbDataReader resultado = bd.Query();//disponible resultado

                while (resultado.Read())
                {
                    Vasos vaso = new Vasos(resultado.GetInt32(8), resultado.GetInt32(9), resultado.GetInt32(10), resultado.GetInt32(11));
                    vasos.Add(vaso);
                }
                resultado.Close();
                bd.Close();

                return vasos;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve el tipo de fertilidad que tiene cada vaso
         */
        public int GetFertilidadVasos(int año, int posicion)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                int id_fertilidad;

                string salida = "vasosObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@ano_vasos", DbType.Int32, año);
                DbDataReader resultado = bd.Query();//disponible resultado
                List<int> id_vasos = new List<int>();
                while (resultado.Read())
                {
                    id_vasos.Add(resultado.GetInt32(0));
                }
                resultado.Close();

                string salida2 = "vasosIndexFertilidadObtener";//comando sql
                bd.CreateCommandSP(salida2);
                bd.CreateParameter("@id_vasos", DbType.Int32, id_vasos[posicion]);
                DbDataReader resultado2 = bd.Query();//disponible resultado
                resultado2.Read();
                id_fertilidad = resultado2.GetInt32(0);
                resultado2.Close();

                bd.Close();
                return id_fertilidad;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve 1 si el vaso ya está en etapa de clones
         */
        public int GetVasosEstaEnClones(int id_vasos)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                int estaEnClones;

                string salida2 = "vasosEstaEnClones";//comando sql
                bd.CreateCommandSP(salida2);
                bd.CreateParameter("@id_vasos", DbType.Int32, id_vasos);
                DbDataReader resultado2 = bd.Query();//disponible resultado
                resultado2.Read();
                estaEnClones = resultado2.GetInt32(0);
                resultado2.Close();

                bd.Close();
                return estaEnClones;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}