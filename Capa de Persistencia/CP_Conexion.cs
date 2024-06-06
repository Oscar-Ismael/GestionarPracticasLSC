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
            // Verifica que la cadena de conexión esté correcta y accesible.
            Conexion = new SqlConnection("Server=DESKTOP-N1CI2EQ;Database=GestiondepracticasLSC;Integrated Security=true;");
        }

        public SqlConnection AbrirConexion()
        {
            try
            {
                if (Conexion.State == ConnectionState.Closed)
                {
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
