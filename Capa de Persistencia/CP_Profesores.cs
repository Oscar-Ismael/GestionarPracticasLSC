using System;
using System.Data.SqlClient;
using System.Data;


namespace Capa_de_Persistencia
{
    public class CP_Profesores
    {
        private CP_Conexion conexion = new CP_Conexion();

        public DataTable GetAllProfesores()
        {
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("SELECT * FROM Profesores", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public void AddProfesor(string nombre, string apellidoPaterno, string apellidoMaterno, string correo, string contrasena)
        {
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                string query = "INSERT INTO Profesores (NombreProf, ApellidoPaternoProf, ApellidoMaternoProf, CorreoElectronico, Contrasena) VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Correo, @Contrasena)";
                using (SqlCommand comando = new SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno);
                    comando.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno);
                    comando.Parameters.AddWithValue("@Correo", correo);
                    comando.Parameters.AddWithValue("@Contrasena", contrasena);
                    comando.ExecuteNonQuery();
                }
            }
        }



    }
}
