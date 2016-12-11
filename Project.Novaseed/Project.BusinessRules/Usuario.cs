using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.BusinessRules
{
    public class Usuario
    {
        private int rol, telefono, id_cargo, id_sexo;
        private string dv, nombre, apellido, nombre_cargo, usuario_persona, password, email, direccion;
        private DateTime fecha_nacimiento, fecha_creacion, fecha_ultima_conexion;
        private bool administrador;

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
        public Usuario(int rol, string dv, string nombre, string apellido, string nombre_cargo, string usuario_persona)
        {
            this.rol = rol;
            this.dv = dv;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombre_cargo = nombre_cargo;
            this.usuario_persona = usuario_persona;
        }

        /*
         * Constructor que agrega un usuario 
         */
        public Usuario(int rol, string dv, int id_cargo, int id_sexo, string nombre, string apellido, DateTime fecha_nacimiento, 
            string direccion, string email, int telefono, string usuario_persona, string password, bool administrador)
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
        }
    }
}