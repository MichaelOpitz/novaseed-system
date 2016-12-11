using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.DataAccess;
using System.Data.Common;
using System.Data;

namespace Project.BusinessRules
{
    public class CatalogUsuario
    {
        /*
         * Agregar un usuario
         */
        public void AddUsuario(Usuario u)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            string sql = "usuarioAgregar";
            bd.CreateCommandSP(sql);
            bd.CreateParameter("@rol", DbType.Int32, u.Rol);
            bd.CreateParameter("@dv", DbType.String, u.Dv);
            bd.CreateParameter("@id_cargo", DbType.Int32, u.Id_cargo);
            bd.CreateParameter("@id_sexo", DbType.Int32, u.Id_sexo);
            bd.CreateParameter("@nombre", DbType.String, u.Nombre);
            bd.CreateParameter("@apellido", DbType.String, u.Apellido);
            bd.CreateParameter("@fecha_nacimiento", DbType.DateTime2, u.Fecha_nacimiento);
            bd.CreateParameter("@direccion", DbType.String, u.Direccion);
            bd.CreateParameter("@email", DbType.String, u.Email);
            bd.CreateParameter("@telefono", DbType.Int32, u.Telefono);
            bd.CreateParameter("@usuario", DbType.String, u.Usuario_persona);
            bd.CreateParameter("@password", DbType.String, u.Password);
            bd.CreateParameter("@administrador", DbType.Boolean, u.Administrador);
            bd.Execute();
            bd.Close();
        }

        /*
         * Agregar nacionalidad a un usuario
         */
        public void AddNacionalidad(int id_pais, int rol)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            string sql = "usuarioNacionalidadAgregar";
            bd.CreateCommandSP(sql);
            bd.CreateParameter("@id_pais", DbType.Int32, id_pais);
            bd.CreateParameter("@rol", DbType.Int32, rol);
            bd.Execute();
            bd.Close();
        }

        /*
         * Elimina un usuario a través del rol
         * Devuelve 1 si eliminó, 0 en caso contrario
         */
        public int DeleteUsuario(int rol)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            string sql = "usuarioEliminar";
            bd.CreateCommandSP(sql);
            bd.CreateParameter("@rol", DbType.Int32, rol);

            int elimino;
            DbDataReader resultado = bd.Query();//disponible resultado
            resultado.Read();
            elimino = resultado.GetInt32(0);
            resultado.Close();

            bd.Close();
            return elimino;
        }

        /*
         * Devuelve la lista con todos los usuarios del sistema
         */
        public List<Usuario> GetUsuario()
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            List<Usuario> lu = new List<Usuario>();
            string sql = "usuarioObtener";
            bd.CreateCommandSP(sql);

            DbDataReader resultado = bd.Query();

            while (resultado.Read())
            {
                Usuario usuario = new Usuario(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2),
                    resultado.GetString(3), resultado.GetString(4), resultado.GetString(5));
                lu.Add(usuario);
            }
            resultado.Close();
            bd.Close();

            return lu;
        }
    }
}