using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_de_Persistencia
{
    public class CP_Practicas
    {
        private CP_Conexion conexion = new CP_Conexion();

        public DataTable MostrarPracticas()
        {
            DataTable dtPracticas = new DataTable();
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM PracticasLaboratorio", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(dtPracticas);
            }
            conexion.CerrarConexion();
            return dtPracticas;
        }

        public void AgregarPractica(string nombre, string fecha, string objetivo, string procedimientos, string materiales, int idMateria)
        {
            Console.WriteLine("Iniciando método AgregarPractica");
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO PracticasLaboratorio (NombrePract, Fecha, Objetivo, Procedimientos, MaterialesNecesarios, ID_Materia) VALUES (@nombre, @fecha, @objetivo, @procedimientos, @materiales, @idMateria)", conn);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@objetivo", objetivo);
                comando.Parameters.AddWithValue("@procedimientos", procedimientos);
                comando.Parameters.AddWithValue("@materiales", materiales);
                comando.Parameters.AddWithValue("@idMateria", idMateria);

                try
                {
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Práctica agregada exitosamente");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al agregar la práctica: " + ex.Message);
                    throw new Exception("Error al agregar la práctica: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
        }

        public void ModificarPractica(int id, string nombre, string fecha, string objetivo, string procedimientos, string materiales, int idMateria)
        {
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                SqlCommand comando = new SqlCommand(@"UPDATE PracticasLaboratorio SET 
                                        NombrePract = @NombrePract, 
                                        Fecha = @Fecha, 
                                        Objetivo = @Objetivo, 
                                        Procedimientos = @Procedimientos, 
                                        MaterialesNecesarios = @MaterialesNecesarios, 
                                        ID_Materia = @ID_Materia 
                                        WHERE ID_Practica = @ID_Practica", conn);
                comando.Parameters.AddWithValue("@NombrePract", nombre);
                comando.Parameters.AddWithValue("@Fecha", fecha);
                comando.Parameters.AddWithValue("@Objetivo", objetivo);
                comando.Parameters.AddWithValue("@Procedimientos", procedimientos);
                comando.Parameters.AddWithValue("@MaterialesNecesarios", materiales);
                comando.Parameters.AddWithValue("@ID_Materia", idMateria);
                comando.Parameters.AddWithValue("@ID_Practica", id);
                comando.ExecuteNonQuery();
            }
            conexion.CerrarConexion();
        }

        public void EliminarPractica(int id)
        {
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                SqlCommand comando = new SqlCommand("DELETE FROM PracticasLaboratorio WHERE ID_Practica = @ID_Practica", conn);
                comando.Parameters.AddWithValue("@ID_Practica", id);
                comando.ExecuteNonQuery();
            }
            conexion.CerrarConexion();
        }

        public DataTable MostrarPracticasPorMateria(int idMateria)
        {
            DataTable dtPracticas = new DataTable();
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM PracticasLaboratorio WHERE ID_Materia = @ID_Materia", conn);
                comando.Parameters.AddWithValue("@ID_Materia", idMateria);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(dtPracticas);
            }
            conexion.CerrarConexion();
            return dtPracticas;
        }
        public DataTable ObtenerPracticasPorCorreo(string correo)
        {
            DataTable dtPracticas = new DataTable();
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conn;
                    comando.CommandText = @"SELECT p.*, ep.Entregado 
                                        FROM Practicas p 
                                        INNER JOIN EntregaPracticas ep ON p.ID_Practica = ep.ID_Practica 
                                        INNER JOIN Alumnos a ON ep.ID_Alumno = a.ID_Alumno 
                                        WHERE a.CorreoElectronico = @Correo";
                    comando.Parameters.AddWithValue("@Correo", correo);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    adapter.Fill(dtPracticas);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener prácticas por correo: " + ex.Message);
                }
            }
            return dtPracticas;
        }

        public void EntregarPractica(int practicaId, string correoAlumno)
        {
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conn;
                    comando.CommandText = @"UPDATE EntregaPracticas 
                                        SET Entregado = 1 
                                        WHERE ID_Practica = @PracticaId 
                                        AND ID_Alumno = (SELECT ID_Alumno FROM Alumnos WHERE CorreoElectronico = @Correo)";
                    comando.Parameters.AddWithValue("@PracticaId", practicaId);
                    comando.Parameters.AddWithValue("@Correo", correoAlumno);
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al marcar la práctica como entregada: " + ex.Message);
                }
            }
        }

        public DataTable ObtenerPracticasPorMateria(int materiaId)
        {
            DataTable dtPracticas = new DataTable();
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conn;
                    comando.CommandText = "SELECT * FROM PracticasLaboratorio WHERE ID_Materia = @MateriaId";
                    comando.Parameters.AddWithValue("@MateriaId", materiaId);
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    adapter.Fill(dtPracticas);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener prácticas por materia: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
            return dtPracticas;
        }

    }
}
