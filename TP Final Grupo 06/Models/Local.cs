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
        int _id_rubro;
        string _descripcion;
        string _urlimagen;

        public Local()
        {

        }

        public Local(int id_local, string nombre_local, int piso, int id_rubro, string descripcion, string urlimagen)
        {
            _id_local = id_local;
            _nombre_local = nombre_local;
            _piso = piso;
            _id_rubro = id_rubro;
            _descripcion = descripcion;
            _urlimagen = urlimagen;
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

        public string urlimagen
        {
            get
            {
                return _urlimagen;
            }
            set
            {
                _urlimagen = value;
            }
        }

        public string descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
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

        public int id_rubro
        {
            get
            {
                return _id_rubro;
            }
            set
            {
                _id_rubro = value;
            }
        }
    }
}