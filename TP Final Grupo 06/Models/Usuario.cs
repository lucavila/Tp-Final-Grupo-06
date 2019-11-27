using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_Final_Grupo_06.Models
{

    public class Usuario
    {
        private int _id;
        private string _usuario;
        private string _contraseña;

        public Usuario()
        {

        }
        public Usuario(int id, string usuario, string contraseña)
        {
            _id = id;
            _usuario = usuario;
            _contraseña = contraseña;
        }

        public int id { get => _id; set => _id = value; }
        public string usuario { get => _usuario; set => _usuario = value; }
        public string contraseña { get => _contraseña; set => _contraseña = value; }
    }
}

