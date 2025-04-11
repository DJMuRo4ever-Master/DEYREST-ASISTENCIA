using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace ATTEDEYV.Services
{
    public class DatabaseService
    {
        private readonly string connectionString;

        public DatabaseService()
        {
            // Lee la conexión desde App.config
            connectionString = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        }

        public string ObtenerNombrePorDNI(string dni)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT APELLIDOS + ', ' + NOMBRES AS NombreCompleto FROM Colaboradores WHERE DNI = @DNI";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DNI", dni);
                    object resultado = cmd.ExecuteScalar();
                    return resultado?.ToString();
                }
            }
        }


    }
}
