using System;
using System.Data.SqlClient;

namespace Capa_de_Persistencia
{
    public class CP_Login
    {
        private CP_Conexion conexion = new CP_Conexion();

        public bool Login(string correoElectronico, string contrasena, string tipoUsuario)
        {
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conn;

                if (tipoUsuario == "Profesor")
                {
                    comando.CommandText = @"SELECT COUNT(1) FROM Profesores 
                                            WHERE CorreoElectronico = @CorreoElectronico AND Contrasena = @Contrasena";
                    comando.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                    comando.Parameters.AddWithValue("@Contrasena", contrasena);
                }
                else if (tipoUsuario == "Alumno")
                {
                    comando.CommandText = @"SELECT COUNT(1) FROM Alumnos 
                                            WHERE CorreoElectronico = @CorreoElectronico AND NumeroMatricula = @Contrasena";
                    comando.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                    comando.Parameters.AddWithValue("@Contrasena", contrasena); // Aquí 'contrasena' es la matrícula
                }

                int count = Convert.ToInt32(comando.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
