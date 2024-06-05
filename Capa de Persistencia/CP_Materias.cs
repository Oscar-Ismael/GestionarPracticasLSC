using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_de_Persistencia
{
    public class CP_Materias
    {
        private CP_Conexion conexion = new CP_Conexion();

        public void AgregarMateria(string nombre, string codigo, string descripcion)
        {
            Console.WriteLine("Método AgregarMateria iniciado.");
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conn;
                    comando.CommandText = @"INSERT INTO Materias (Nombremat, Codigo, Descripcion) 
                                            VALUES (@Nombre, @Codigo, @Descripcion)";
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Codigo", codigo);
                    comando.Parameters.AddWithValue("@Descripcion", descripcion);
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Materia agregada exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al agregar la materia: " + ex.Message);
                    throw;
                }
            }
        }

        public DataTable MostrarMaterias()
        {
            Console.WriteLine("Método MostrarMaterias iniciado.");
            DataTable dtMaterias = new DataTable();
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conn;
                    comando.CommandText = "SELECT * FROM Materias";
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    adapter.Fill(dtMaterias);
                    Console.WriteLine("Materias mostradas exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al mostrar las materias: " + ex.Message);
                    throw;
                }
            }
            return dtMaterias;
        }
    }
}