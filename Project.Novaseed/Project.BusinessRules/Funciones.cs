﻿using Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Project.BusinessRules
{
    public class Funciones
    {
        /*
         * Agrega a la tabla paises
         */ 
        public void AddPaises(List<string> paises)
        {
            DataAccess.DataBase bd = new DataBase();
            bd.Connect(); //método conectar
            string sql = "paisesAgregar";
            int cont = 0;
            while (cont < paises.Count)
            {
                bd.CreateCommandSP(sql);
                bd.CreateParameter("@pais", DbType.String, paises[cont].ToString());
                cont = cont + 1;
                bd.Execute();
            }
            bd.Close();
        }

        /*
         * Valida un RUN
         */ 
        public bool ValidarRUN(string run, char dv)
        {
            bool validacion = false;
            try
            {
                run = run.ToUpper();
                run = run.Replace(".", "");
                run = run.Replace("-", "");
                int runAux = int.Parse(run);
                //dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; runAux != 0; runAux /= 10)
                    s = (s + runAux % 10 * (9 - m++ % 6)) % 11;
                
                if (dv == (char)(s != 0 ? s + 47 : 75))
                    validacion = true;
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        public bool ValidarExtension(string extension)
        {
            Boolean verif = false;
            switch (extension)
            {
                case ".jpg":
                case ".jpeg":
                case ".png":
                case ".gif":
                case ".bmp":
                    verif = true;
                    break;
                default:
                    verif = false;
                    break;
            }
            return verif;
        }

        /*
         * Encripta con el metodo SHA1
         */ 
        private string EncriptarSHA1(string cadena)
        {
            SHA1CryptoServiceProvider elProveedor = new SHA1CryptoServiceProvider();
            byte[] vectoBytes = System.Text.Encoding.UTF8.GetBytes(cadena);
            byte[] inArray = elProveedor.ComputeHash(vectoBytes);
            elProveedor.Clear();
            return Convert.ToBase64String(inArray);
        }

        /*
         * Encripta con el metodo MD5
         */ 
        private string EncriptarMD5(string cadena)
        {
            //arreglo de bytes donde guardaremos la llave
            byte[] keyArray;
            //arreglo de bytes donde guardaremos el texto
            //que vamos a encriptar
            byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(cadena);
            //se utilizan las clases de encriptación
            //provistas por el Framework
            //Algoritmo MD5
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            //se guarda la llave para que se le realice
            //hashing
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(cadena));
            hashmd5.Clear();
            //Algoritmo 3DAS
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            //se empieza con la transformación de la cadena
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            //arreglo de bytes donde se guarda la
            //cadena cifrada
            byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);
            tdes.Clear();
            //se regresa el resultado en forma de una cadena
            return Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
        }

        /*
         * Doble encriptación, primero en SHA1 y luego en MD5
         */ 
        public string Encriptar(string cadena)
        {            
            return EncriptarMD5(EncriptarSHA1(cadena));
        }

        public void GenerarNuevaContrasena(string email)
        {
            try
            {
                Random rd = new Random(DateTime.Now.Millisecond);
                int nuevaContrasena = rd.Next(100000, 999999);
                EnviarCorreoContrasena(nuevaContrasena, email);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        private void EnviarCorreoContrasena(int contrasenaNueva, string correo)
        {
            string contraseña = "root2017";
            string mensaje = string.Empty;
            //Creando el correo electronico
            string destinatario = correo;
            string remitente = "equipo.novaseed@gmail.com";
            string asunto = "Recuperación de contraseña usuario Novaseed";
            string cuerpoDelMesaje = "Su nueva contraseña es " + Convert.ToString(contrasenaNueva);
            MailMessage ms = new MailMessage(remitente, destinatario, asunto, cuerpoDelMesaje);
            ms.Priority = System.Net.Mail.MailPriority.High;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("equipo.novaseed@gmail.com", contraseña);

            try
            {
                Task.Run(() =>
                {
                    smtp.Send(ms);
                    ms.Dispose();
                }
                );

                CatalogUsuario cu = new CatalogUsuario();
                Funciones f = new Funciones();
                string password = f.Encriptar(Convert.ToString(contrasenaNueva));
                cu.RecuperarContraseña(correo, password);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}