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

        public static Local Buscar_Local_Por_Id(int Id)
        {
            Local UnLocal = new Local();
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "dbo.TraerLocal";
            consulta.CommandType = System.Data.CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@Id", Id);
            SqlDataReader dr = consulta.ExecuteReader();
            if (dr.Read())
            {
                string Nombre = dr["nombre_local"].ToString();
                string descripcion = dr["descripcion"].ToString();
                int id_Local = Id;
                UnLocal.id_local = id_Local;
                UnLocal.nombre_local = Nombre;
                UnLocal.descripcion = descripcion;
            }
            Desconectar(conn);
            return UnLocal;
        }

        public static string Buscar_local_por_nombre(Local a)
        {
            SqlConnection conn = Conectar();
            string res = "";
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "SP_BuscarLocal";
            consulta.CommandType = System.Data.CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@nombre_local", nombre_local);
            SqlDataReader dr = consulta.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    res = dr.ToString();
                }
            }
            else
            {
                res = "error";
            }
            return res;
            Desconectar(conn);
        }

        public static List<Local> Obtener_Todos_Locales()
        {
            List<Local> lista_local = new List<Local>();
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "SELECT id_local, nombre_local, piso, id_rubro FROM Local";
            consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader data_reader = consulta.ExecuteReader();
            while (data_reader.Read())
            {
                int id_local = Convert.ToInt32(data_reader["id_local"]);
                string nombre_local = (data_reader["nombre_local"]).ToString();
                int piso = Convert.ToInt32(data_reader["piso"]);
                int id_rubro = Convert.ToInt32(data_reader["id_rubro"]);
                Local unLocal = new Local(id_local, nombre_local, piso, id_rubro);
                lista_local.Add(unLocal);
            }
            Desconectar(conn);
            return lista_local;
        }

        public static Local Traer_Local_por_nombre()
        {
            List<Local> lista_local = new List<Local>();
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "SP_BuscarLocal";
            consulta.CommandType = System.Data.CommandType.Text;
            Local unLocal = new Local();
            SqlDataReader data_reader = consulta.ExecuteReader();
            while (data_reader.Read())
            {
                int id_local = Convert.ToInt32(data_reader["id_local"]);
                string nombre_local = (data_reader["nombre_local"]).ToString();
                int piso = Convert.ToInt32(data_reader["piso"]);
                int id_rubro = Convert.ToInt32(data_reader["id_rubro"]);
                string descripcion = dr["descripcion"].ToString();
                Local local_buscado(int id_local, string nombre_local, int piso, int id_rubro, string descripcion);

            }
            return local_buscado;
            Desconectar(conn);
        }

        public static string LogIn(Usuario unUsuario)
        {
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "SP_IniciarSEsion";
            consulta.CommandType = System.Data.CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@pUsuario", unUsuario.usuario);
            consulta.Parameters.AddWithValue("@pContra", unUsuario.contraseña);
            SqlDataReader data_reader = consulta.ExecuteReader();
            string res = "";
            if (data_reader.HasRows)
            {
                if (data_reader.Read())
                {
                    res = data_reader.ToString();
                }
            }
            else
            {
                res = "error";
            }
            Desconectar(conn);
            return res;
        }

        public static int CrearUsuario(Usuario nuevoUsuario2)
        {
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "SP_Registrarse";
            consulta.CommandType = System.Data.CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@pUsuario", nuevoUsuario2.usuario);
            consulta.Parameters.AddWithValue("@pContra", nuevoUsuario2.contraseña);
            int regsAfectados;
            try
            {
                regsAfectados = consulta.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                regsAfectados = 0;
            }
            Desconectar(conn);
            return regsAfectados;
        }


    }

}
