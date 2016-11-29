using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClinicaFrba.Properties;
using System.Data;

namespace ClinicaFrba.DB_Connection
{
    class SQL
    {
        public string connectionString()
        {
            string connectionString = Settings.Default.Database +
                   Settings.Default.Data_Source + @"\" +
                   Settings.Default.SQL_Name +
                   Settings.Default.Password +
                   Settings.Default.Security_Info +
                   Settings.Default.Connection_Timeout +
                   Settings.Default.User;
            return connectionString;
        }

        public SqlConnection crearConexion() {
            return new SqlConnection(this.connectionString());
        }

        public SqlConnection abrirConexion() {
            SqlConnection conexion = this.crearConexion();
            try {
                conexion.Open();
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            return conexion;
        }

        public static void cerrarConexion(SqlConnection conexion) {
            try {
                conexion.Close();
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }

        public DataTable ejecutarSP(string procedure, List<Parametro> parametros) {
            SqlCommand command = new SqlCommand();
            SqlDataAdapter adapter;
            DataTable table = new DataTable();
            try {
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = abrirConexion();
                command.CommandText = "[" + Settings.Default.SQL_Schema + "].[" + procedure + "]";
                for (int i = 0; i < parametros.Count; i++) {
                    command.Parameters.AddWithValue("@" + parametros[i].nombre, parametros[i].valor);
                }
                adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                cerrarConexion(command.Connection);
                command.Dispose();
            } catch (Exception e) {
                table.Columns.Add("0", Type.GetType("System.String"));
                DataRow row = table.NewRow();
                row[0] = e.ToString();
                table.Rows.Add(row);
                return table;
            }
            return table;
        }


    }
}
