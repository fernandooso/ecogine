using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace interda.controlador
{
    public class conector
    {
        static string servidor = "172.22.65.57";
        static string db = "interda";
        static string user = "ecogine";
        static string pass = "Ec0_61n3";
        static string cadenaConexion = $"Server={servidor};Database={db};User ID={user};Password={pass};";

        public MySqlConnection crear_conexion()
        {
            MySqlConnection conexion = null;

            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                //MessageBox.Show("Se conectó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar. Error: " + ex.Message);
            }

            return conexion;
        }
        public DataTable leer(string query)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection conexion = crear_conexion())
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos: " + ex.Message);
                }
            }

            return dataTable;
        }
        public bool insertar(string query)
        {
            try
            {
                using (MySqlConnection conexion = crear_conexion())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.ExecuteNonQuery();
                        // MessageBox.Show("Consulta ejecutada correctamente");
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                return false;
            }
        }
    }
}
