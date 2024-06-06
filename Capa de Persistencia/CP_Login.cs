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
                try
                {
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conn;

                    if (tipoUsuario == "Profesor")
                    {
                        comando.CommandText = @"SELECT COUNT(1) FROM Profesores 
                                                WHERE CorreoElectronico = @CorreoElectronico AND Contrasena = @Contrasena";
                    }
                    else if (tipoUsuario == "Alumno")
                    {
                        comando.CommandText = @"SELECT COUNT(1) FROM Alumnos 
                                                WHERE CorreoElectronico = @CorreoElectronico AND NumeroMatricula = @Contrasena";
                    }
                    comando.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                    comando.Parameters.AddWithValue("@Contrasena", contrasena);

                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar la consulta de inicio de sesión: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
        }

        public int ObtenerIdAlumno(string correoElectronico)
        {
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conn;
                    comando.CommandText = @"SELECT ID_Alumno FROM Alumnos 
                                    WHERE CorreoElectronico = @CorreoElectronico";
                    comando.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                    Console.WriteLine($"Ejecutando consulta para obtener ID del alumno con correo: {correoElectronico}");

                    int idAlumno = Convert.ToInt32(comando.ExecuteScalar());
                    Console.WriteLine($"ID del alumno obtenido: {idAlumno}");
                    return idAlumno;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener ID del alumno: " + ex.Message);
                    throw new Exception("Error al obtener ID del alumno: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
        }




    }
}
