using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_Final_Grupo_06.Models
{
    public class Usuario
    {
        private int _id_usuario;
        private string _nombreusuario;
        private string _contraseña;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _mail;

        public Usuario(int id_usuario, string nombreusuario, string contraseña, string nombre, string apellido, string telefono, string mail)
        {
            _id_usuario = id_usuario;
            _nombreusuario = nombreusuario;
            _contraseña = contraseña;
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
            _mail = mail;
        }

        public int id_usuario
        {
            get
            {
                return id_usuario;
            }
            set
            {
                id_usuario = value;
            }
        }

        public int nombreusuario
        {
            get
            {
                return nombreusuario;
            }
            set
            {
                nombreusuario = value;
            }
        }
        public int contraseña
        {
            get
            {
                return contraseña;
            }
            set
            {
                contraseña = value;
            }
        }

        public int nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public int telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }
        public int mail
        {
            get
            {
                return mail;
            }
            set
            {
                mail = value;
            }
        }
    }
}

       