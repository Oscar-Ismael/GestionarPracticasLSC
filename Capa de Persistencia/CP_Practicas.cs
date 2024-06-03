using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_de_Persistencia
{
    public class CP_Practicas
    {
        private readonly CP_Conexion conexion = new CP_Conexion();

        public void AgregarPractica(string nombre, DateTime fecha, string objetivo, string procedimientos, string materiales, int idMateria)
        {
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                string query = "INSERT INTO PracticasLaboratorio (ID_Materia, Fecha, Objetivo, Procedimientos, MaterialesNecesarios, Entregado) VALUES (@ID_Materia, @Fecha, @Objetivo, @Procedimientos, @Materiales, 0)";
                using (SqlCommand comando = new SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@ID_Materia", idMateria);
                    comando.Parameters.AddWithValue("@Fecha", fecha);
                    comando.Parameters.AddWithValue("@Objetivo", objetivo);
                    comando.Parameters.AddWithValue("@Procedimientos", procedimientos);
                    comando.Parameters.AddWithValue("@Materiales", materiales);
                    comando.ExecuteNonQuery();
                }
                conexion.CerrarConexion();
            }
        }

        public DataTable MostrarPracticas()
        {
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("SELECT * FROM PracticasLaboratorio", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conexion.CerrarConexion();
                    return dt;
                }
            }
        }
    }
}
