using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_de_Persistencia
{
    public class CP_Conexion
    {
        private readonly SqlConnection Conexion;

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
                    Conexion.Open();
                }
                return Conexion;
            }
            catch (SqlException e)
            {
                throw new Exception("No se pudo abrir la conexión con la base de datos.", e);
            }
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
            catch (SqlException e)
            {
                throw new Exception("Error al cerrar la conexión con la base de datos.", e);
            }
        }
    }
}
