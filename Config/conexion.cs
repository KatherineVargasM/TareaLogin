using System;
using System.Data.SqlClient;

namespace Login.config
{
    public static class Conexion
    {
        private static readonly string connectionString;

        static Conexion()
        {
            connectionString = "Server=.;database=Login;uid=sa;pwd=corpad17k";
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
                throw;
            }
        }

    }
}