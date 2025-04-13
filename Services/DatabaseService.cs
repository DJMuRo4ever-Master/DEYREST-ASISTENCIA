using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ATTEDEYV.Models;


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

        public Persona ObtenerNombrePorDNI(string dni)
        {            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT APELLIDOS as APELLIDOS , NOMBRES AS NOMBRES FROM Colaboradores WHERE DNI = @DNI";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DNI", dni);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Persona
                            {
                                Apellidos = reader["APELLIDOS"].ToString(),
                                Nombres = reader["NOMBRES"].ToString()
                            };
                        }
                        else
                        {
                            return null; // No se encontró
                        }
                    }
                }
            }
        }


    }
}
