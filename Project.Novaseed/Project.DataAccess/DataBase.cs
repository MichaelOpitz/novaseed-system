using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.Data;
using System.Configuration;

namespace Project.DataAccess
{
    public class DataBase
    {
        private DbConnection connection;
        private DbCommand command;
        private string connection_string;
        private static DbProviderFactory factory;
        private DbDataAdapter adapter;

        public DataBase()
        {
            string provider = ConfigurationManager.AppSettings.Get("proveedor");
            this.connection_string = ConfigurationManager.AppSettings.Get("cadena");//pass nombre basedatos nombre servidor
            factory = DbProviderFactories.GetFactory(provider);//instanciar la conexion con la base de datos

        }
        /*
         * Conexión a la base de datos
         */ 
        public void Connect()
        {
            this.connection = factory.CreateConnection();//Se crea la conexion
            this.connection.ConnectionString = connection_string;//Se configura el string de conexion
            this.connection.Open();// Se intenta abrir la conexion
        }
        /*
         * Crea código SQL
         */ 
        public void CreateCommand(string sql)
        {
            this.command = factory.CreateCommand();
            this.command.Connection = connection;
            this.command.CommandType = CommandType.Text;//3 opciones de trabajar (consultas)
            this.command.CommandText = sql;
        }
        /*
         * Llama a procedimiento almacenado
         */ 
        public void CreateCommandSP(string sql)
        {
            this.command = factory.CreateCommand();
            this.command.Connection = connection;
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandText = sql;
        }
        /*
         * Crea un parametro
         */ 
        public void CreateParameter(string name, DbType type, object value)
        {
            DbParameter parameter = factory.CreateParameter();
            parameter.DbType = type;
            parameter.ParameterName = name;
            parameter.Value = value;
            this.command.Parameters.Add(parameter);
        }
        /*
         * Crea un DataSet
         */ 
        public DataSet Set(string sql)
        {
            try
            {
                adapter = factory.CreateDataAdapter();
                this.Connect();
                this.CreateCommand(sql);
                adapter.SelectCommand = this.command;
                DbCommandBuilder cb = factory.CreateCommandBuilder();
                cb.DataAdapter = adapter;
                DataSet set = new DataSet();

                //Relleno de datos del dataset
                adapter.Fill(set);
                return set;
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex.Message);
            }
        }
        /*
         * Crea un DataSet con Procedimiento Almacenado
         */
        public DataSet SetSP(string sql, string parametro, DbType tipo, object value)
        {
            try
            {
                adapter = factory.CreateDataAdapter();
                this.Connect();
                this.CreateCommandSP(sql);
                this.CreateParameter(parametro,tipo,value);
                adapter.SelectCommand = this.command;
                DbCommandBuilder cb = factory.CreateCommandBuilder();
                cb.DataAdapter = adapter;
                DataSet set = new DataSet();

                //Relleno de datos del dataset
                adapter.Fill(set);
                return set;
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex.Message);
            }
        }
        public DbDataReader Query()
        {
            return this.command.ExecuteReader();
        }
        /*
         * Cierra la conexión
         */ 
        public void Close()
        {
            this.connection.Close();
        }
        /*
         * Ejecuta las tres operaciones básicas, insertar, modificar y eliminar
         */ 
        public void Execute()
        {
            try
            {
                this.command.ExecuteNonQuery();//inserta, update, delete ...(no duvuelve resultado ni valores)

            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex.Message);
            }
        }
    }
}