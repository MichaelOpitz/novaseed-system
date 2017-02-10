using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Usuario
    {
        private int rol, telefono, id_cargo, id_sexo, conectado, no_conectado, id_pais;
        private string dv, nombre, apellido, nombre_cargo, usuario_persona, password, email, direccion, imagen;
        private DateTime fecha_nacimiento, fecha_creacion, fecha_ultima_conexion;
        private bool administrador;

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public int Id_pais
        {
            get { return id_pais; }
            set { id_pais = value; }
        }

        public int No_conectado
        {
            get { return no_conectado; }
            set { no_conectado = value; }
        }

        public int Conectado
        {
            get { return conectado; }
            set { conectado = value; }
        }

        public bool Administrador
        {
            get { return administrador; }
            set { administrador = value; }
        }

        public int Id_sexo
        {
            get { return id_sexo; }
            set { id_sexo = value; }
        }

        public int Id_cargo
        {
            get { return id_cargo; }
            set { id_cargo = value; }
        }        

        public string Usuario_persona
        {
            get { return usuario_persona; }
            set { usuario_persona = value; }
        }        

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public int Rol
        {
            get { return rol; }
            set { rol = value; }
        }        

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Nombre_cargo
        {
            get { return nombre_cargo; }
            set { nombre_cargo = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Dv
        {
            get { return dv; }
            set { dv = value; }
        }        

        public DateTime Fecha_ultima_conexion
        {
            get { return fecha_ultima_conexion; }
            set { fecha_ultima_conexion = value; }
        }

        public DateTime Fecha_creacion
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }
        }

        public DateTime Fecha_nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }

        /*
         * Constructor que obtiene los usuarios
         */ 
        public Usuario(int rol, string dv, string nombre, string apellido, string nombre_cargo, string usuario_persona, string email)
        {
            this.rol = rol;
            this.dv = dv;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombre_cargo = nombre_cargo;
            this.usuario_persona = usuario_persona;
            this.email = email;
        }

        /*
         * Constructor que agrega un usuario 
         */
        public Usuario(int rol, string dv, int id_cargo, int id_sexo, string nombre, string apellido, DateTime fecha_nacimiento, 
            string direccion, string email, int telefono, string usuario_persona, string password, bool administrador, string imagen)
        {
            this.rol = rol;
            this.dv = dv;
            this.id_cargo = id_cargo;
            this.id_sexo = id_sexo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha_nacimiento = fecha_nacimiento;
            this.direccion = direccion;
            this.email = email;
            this.telefono = telefono;
            this.usuario_persona = usuario_persona;
            this.password = password;
            this.administrador = administrador;
            this.imagen = imagen;
        }

        /*
         * Constructor para obtener el registro de usuarios
         */
        public Usuario(int rol, string nombre, string apellido, string nombre_cargo, string usuario_persona, DateTime fecha_ultima_conexion)
        {
            this.rol = rol;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombre_cargo = nombre_cargo;
            this.usuario_persona = usuario_persona;
            this.fecha_ultima_conexion = fecha_ultima_conexion;
        }

        /*
         * Constructor para obtener la estadística de los usuarios conectados y no conectados
         */
        public Usuario(int conectado, int no_conectado)
        {
            this.conectado = conectado;
            this.no_conectado = no_conectado;
        }

        /*
         * Constructor para actualizar un usuario(perfil)
         */
        public Usuario(int rol, int id_cargo, int id_sexo, string nombre, string apellido, DateTime fecha_nac, string direccion,
            string email, int telefono, bool administrador, string imagen)
        {
            this.rol = rol;
            this.id_cargo = id_cargo;
            this.id_sexo = id_sexo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha_nacimiento = fecha_nac;
            this.direccion = direccion;
            this.email = email;
            this.telefono = telefono;            
            this.administrador = administrador;
            this.imagen = imagen;
        }

        /*
         * Constructor para obtener el nombre, cargo y foto de perfil del usuario
         */
        public Usuario(string nombre, string nombre_cargo, string imagen)
        {
            this.nombre = nombre;
            this.nombre_cargo = nombre_cargo;
            this.imagen = imagen;
        }

        /*
         * Constructor que obtiene el perfil de usuario
         */
        public Usuario(int rol, string dv, string nombre, string apellido, DateTime fecha_nacimiento, string email, 
            int telefono, string direccion, bool administrador, int id_sexo, int id_cargo)
        {
            this.rol = rol;
            this.dv = dv;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha_nacimiento = fecha_nacimiento;
            this.email = email;
            this.telefono = telefono;
            this.direccion = direccion;
            this.administrador = administrador;
            this.id_sexo = id_sexo;
            this.id_cargo = id_cargo;
        }

        /*
         * Constructor que obtiene la nacionalidad del usuario para el perfil
         */
        public Usuario(int id_pais)
        {
            this.id_pais = id_pais;
        }
    }
}