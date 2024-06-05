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
    }
}
