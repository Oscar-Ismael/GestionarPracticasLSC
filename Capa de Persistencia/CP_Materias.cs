using System.Data;
using System.Data.SqlClient;

namespace Capa_de_Persistencia
{
    public class CP_Materias
    {
        private readonly CP_Conexion conexion = new CP_Conexion();

        public void AgregarMateria(string nombre, string codigo, string descripcion)
        {
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                string query = "INSERT INTO Materias (Nombremat, Codigo, Descripcion) VALUES (@Nombre, @Codigo, @Descripcion)";
                using (SqlCommand comando = new SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Codigo", codigo);
                    comando.Parameters.AddWithValue("@Descripcion", descripcion);
                    comando.ExecuteNonQuery();
                }
                conexion.CerrarConexion();
            }
        }

        public DataTable MostrarMaterias()
        {
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("SELECT * FROM Materias", conn))
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
