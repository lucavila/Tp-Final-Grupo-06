using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TP_Final_Grupo_06.Models
{
    public class BD
    {
        private static string _connectionString = "Server=10.128.8.16;Database=AlmagroShopping;User Id = ashopping;Password=yatay240;";

        public static string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }


        private static SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        public static void Desconectar(SqlConnection conn)
        {
            conn.Close();

        }

        public static List<Usuario> Obtener_Todos_Usuarios()
        {
            List<Usuario> lista = new List <Usuario>();
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "SELECT id_usuario, nombre, apellido, telefono, mail, id_locales_favoritos FROM Usuario";
            consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader data_reader = consulta.ExecuteReader();
            while (data_reader.Read())
            {
                int id_usuario = Convert.ToInt32(data_reader["id_usuario"]);
                string nombre = (data_reader["nombre"]).ToString();
                string apellido = (data_reader["apellido"]).ToString();
                string telefono = (data_reader["telefono"]).ToString();
                string mail = (data_reader["mail"]).ToString();
                int id_locales_favoritos = Convert.ToInt32(data_reader["id_locales_favoritos"]);
                Usuario unUsuario = new Usuario(id_usuario, nombre, apellido, telefono, mail, id_locales_favoritos);
                lista.Add(unUsuario);
            }
            Desconectar(conn);
            return lista;
        }

        public static List<Local> Obtener_Todos_Locales()
        {
            List<Local> lista_local = new List<Local>();
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "SELECT id_local, nombre_local, piso, zona FROM Local";
            consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader data_reader = consulta.ExecuteReader();
            while (data_reader.Read())
            {
                int id_local = Convert.ToInt32(data_reader["id_local"]);
                string nombre_local = (data_reader["nombre_local"]).ToString();
                int piso = Convert.ToInt32(data_reader["piso"]);
                int zona = Convert.ToInt32(data_reader["zona"]);
                Local unLocal = new Local(id_local, nombre_local, piso, zona);
                lista_local.Add(unLocal);
            }
            Desconectar(conn);
            return lista_local;
        }
    }
}