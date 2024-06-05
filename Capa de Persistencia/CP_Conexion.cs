using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_de_Persistencia
{
    public class CP_Conexion
    {
        private SqlConnection Conexion;

        public CP_Conexion()
        {
            Conexion = new SqlConnection("Server=DESKTOP-Q04OS5T;Database=GestiondepracticasLSC;Integrated Security=true;");
        }

        public SqlConnection AbrirConexion()
        {
            try
            {
                if (Conexion.State == ConnectionState.Closed)
                {
                    Console.WriteLine("Cadena de conexión: " + Conexion.ConnectionString);
                    Conexion.Open();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al abrir la conexión: " + ex.Message);
            }

            return Conexion;
        }

        public void CerrarConexion()
        {
            try
            {
                if (Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}
