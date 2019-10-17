using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_Final_Grupo_06.Models
{
    public class Local
    {
        int _id_local;
        string _nombre_local;
        int _piso;
        int _lugar;

        public Local(int id_local, string nombre_local, int piso, int lugar)
        {
            _id_local = id_local;
            _nombre_local = nombre_local;
            _piso = piso;
            _lugar = lugar;
        }

        public int id_local
        {
            get
            {
                return _id_local;
            }
            set
            {
                _id_local = value;
            }
        }

        public string nombre_local
        {
            get
            {
                return _nombre_local;
            }
            set
            {
                _nombre_local = value;
            }
        }

        public int piso
        {
            get
            {
                return _piso;
            }
            set
            {
                _piso = value;
            }
        }

        public int lugar
        {
            get
            {
                return _lugar;
            }
            set
            {
                _lugar = value;
            }
        }
    }
}