using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_Final_Grupo_06.Models
{
    public class Usuario
    {
        private int _id_usuario;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _mail;
        private int _id_locales_favoritos;

        public Usuario(int id_usuario, string nombre, string apellido, string telefono, string mail, int id_locales_favoritos)
        {
            _id_usuario = id_usuario;
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
            _mail = mail;
            _id_locales_favoritos = id_locales_favoritos;
        }

        public int id_usuario
        {
            get
            {
                return _id_usuario;
            }
            set
            {
                _id_usuario = value;
            }
        }

        public string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public string apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido= value;
            }
        }

        public string telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                _telefono = value;
            }
        }

        public string mail
        {
            get
            {
                return _mail;
            }
            set
            {
                _mail= value;
            }
        }

        public int id_locales_favoritos
        {
            get
            {
                return _id_locales_favoritos;
            }
            set
            {
                _id_locales_favoritos = value;
            }
        }
    }
}