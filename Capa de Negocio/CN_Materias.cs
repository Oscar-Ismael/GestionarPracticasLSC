using Capa_de_Persistencia;
using System.Data;

namespace Capa_de_Negocio
{
    public class CN_Materias
    {
        private CP_Materias cpMaterias = new CP_Materias();

        public void AgregarMateria(string nombre, string codigo, string descripcion)
        {
            cpMaterias.AgregarMateria(nombre, codigo, descripcion);
        }

        public DataTable MostrarMaterias()
        {
            return cpMaterias.MostrarMaterias();
        }
    }
}