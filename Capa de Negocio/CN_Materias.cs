using Capa_de_Persistencia;
using System.Data;

namespace Capa_de_Negocio
{
    public class CN_Materias
    {
        private readonly CP_Materias objetoCP = new CP_Materias();

        public void AgregarMateria(string nombre, string codigo, string descripcion)
        {
            objetoCP.AgregarMateria(nombre, codigo, descripcion);
        }

        public DataTable MostrarMaterias()
        {
            return objetoCP.MostrarMaterias();
        }
    }
}
