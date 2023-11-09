using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TP_DyBD
{
    public static class SQL
    {
        // Obtiene la cadena de conexión desde el archivo app.config
        private static string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        // Método para ejecutar consultas SELECT
        public static DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        // Método para ejecutar consultas INSERT, UPDATE o DELETE
        public static int ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
