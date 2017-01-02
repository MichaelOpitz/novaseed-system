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
            try
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
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Agregar nacionalidad a un usuario
         */
        public void AddNacionalidad(int id_pais, int rol)
        {
            try
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
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Actualizar usuario(perfil)
         */
        public void UpdateUsuario(Usuario u)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "usuarioActualizar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@rol", DbType.Int32, u.Rol);
                bd.CreateParameter("@id_cargo", DbType.Int32, u.Id_cargo);
                bd.CreateParameter("@id_sexo", DbType.Int32, u.Id_sexo);
                bd.CreateParameter("@nombre", DbType.String, u.Nombre);
                bd.CreateParameter("@apellido", DbType.String, u.Apellido);
                bd.CreateParameter("@fecha_nac", DbType.DateTime2, u.Fecha_nacimiento);
                bd.CreateParameter("@direccion", DbType.String, u.Direccion);
                bd.CreateParameter("@email", DbType.String, u.Email);
                bd.CreateParameter("@telefono", DbType.Int32, u.Telefono);                
                bd.CreateParameter("@administrador", DbType.Boolean, u.Administrador);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Elimina un usuario a través del rol
         * Devuelve 1 si eliminó, 0 en caso contrario
         */
        public int DeleteUsuario(int rol)
        {
            try
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
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Elimina una nacionalidad de usuario a través del rol         
         */
        public void DeleteNacionalidad(int rol)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                string sql = "paisEliminar";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@rol", DbType.Int32, rol);
                bd.Execute();
                bd.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve la lista con todos los usuarios del sistema
         */
        public List<Usuario> GetUsuario()
        {
            try
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
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve la lista con las conexiones de los usuarios en el sistema
         */
        public List<Usuario> GetUsuarioRegistro()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Usuario> lu = new List<Usuario>();
                string sql = "usuarioRegistroObtener";
                bd.CreateCommandSP(sql);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    Usuario usuario = new Usuario(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2),
                        resultado.GetString(3), resultado.GetString(4), resultado.GetDateTime(5));
                    lu.Add(usuario);
                }
                resultado.Close();
                bd.Close();

                return lu;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve 1 si el usuario se conecto hoy, 0 en caso contrario
         */
        public int GetUsuarioEstaConectado(int posicion)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                int esta_conectado;

                string salida = "usuarioObtener";//comando sql
                bd.CreateCommandSP(salida);
                DbDataReader resultado = bd.Query();//disponible resultado
                List<int> rol = new List<int>();
                while (resultado.Read())
                {
                    rol.Add(resultado.GetInt32(0));
                }
                resultado.Close();

                string salida2 = "usuarioEstaConectado";//comando sql
                bd.CreateCommandSP(salida2);
                bd.CreateParameter("@rol", DbType.Int32, rol[posicion]);
                DbDataReader resultado2 = bd.Query();//disponible resultado
                resultado2.Read();
                esta_conectado = resultado2.GetInt32(0);
                resultado2.Close();

                bd.Close();
                return esta_conectado;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve la estadistica de usuarios conectados y no conectados por día
         * Estadistica
         */
        public List<Usuario> GetUsuariosConectados()
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Usuario> usuarios = new List<Usuario>();
                string salida = "estadisticaUsuarioRegistro";//comando sql
                bd.CreateCommandSP(salida);

                DbDataReader resultado = bd.Query();//disponible resultado

                while (resultado.Read())
                {
                    Usuario u = new Usuario(resultado.GetInt32(0), resultado.GetInt32(1));
                    usuarios.Add(u);
                }
                resultado.Close();
                bd.Close();

                return usuarios;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve 1 si el usuario pudo ingresar en el login, 0 en caso contrario
         */
        public int GetLogin(string usuario, string password)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                int ingreso;

                string salida = "loginIngresar";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@usuario", DbType.String, usuario);
                bd.CreateParameter("@password", DbType.String, password);
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                ingreso = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return ingreso;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve el nombre y cargo del usuario
         */
        public List<Usuario> GetNombreCargoUsuario(string usuario)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Usuario> usuarios = new List<Usuario>();
                string salida = "personaNombreCargoObtener";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@usuario", DbType.String, usuario);

                DbDataReader resultado = bd.Query();//disponible resultado

                while (resultado.Read())
                {
                    Usuario u = new Usuario(resultado.GetString(0), resultado.GetString(1));
                    usuarios.Add(u);
                }
                resultado.Close();
                bd.Close();

                return usuarios;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve los parámetros del perfil de usuario
         */
        public List<Usuario> GetUsuarioPerfil(string usuario)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Usuario> lu = new List<Usuario>();
                string sql = "usuarioPerfilObtener";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@usuario", DbType.String, usuario);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    Usuario u = new Usuario(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2),
                        resultado.GetString(3), resultado.GetDateTime(4), resultado.GetString(5), resultado.GetInt32(6),
                        resultado.GetString(7), resultado.GetBoolean(8), resultado.GetInt32(9), resultado.GetInt32(10));
                    lu.Add(u);
                }
                resultado.Close();
                bd.Close();

                return lu;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve los parámetros del perfil de usuario
         */
        public List<Usuario> GetUsuarioPerfilNacionalidad(int rol)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                List<Usuario> lu = new List<Usuario>();
                string sql = "usuarioPerfilNacionalidadObtener";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@rol", DbType.Int32, rol);

                DbDataReader resultado = bd.Query();

                while (resultado.Read())
                {
                    Usuario u = new Usuario(resultado.GetInt32(0));
                    lu.Add(u);
                }
                resultado.Close();
                bd.Close();

                return lu;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Cambiar la contraseña del usuario en el perfil
         */
        public int CambiarContraseña(string usuario, string passwordVieja, string passwordNueva)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                int cambio;

                string sql = "usuarioCambiarContraseña";
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@usuario", DbType.String, usuario);
                bd.CreateParameter("@passwordVieja", DbType.String, passwordVieja);
                bd.CreateParameter("@passwordNueva", DbType.String, passwordNueva);
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                cambio = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return cambio;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        /*
         * Devuelve 1 si el correo existe, 0 en caso contrario
         */
        public int ExistCorreo(string email)
        {
            try
            {
                DataAccess.DataBase bd = new DataBase();
                bd.Connect(); //método conectar
                int existe;

                string salida = "loginExisteCorreo";//comando sql
                bd.CreateCommandSP(salida);
                bd.CreateParameter("@email", DbType.String, email);                
                DbDataReader resultado = bd.Query();//disponible resultado
                resultado.Read();
                existe = resultado.GetInt32(0);
                resultado.Close();

                bd.Close();
                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}