using Capa_de_Persistencia;
using System;
using System.Data;

namespace Capa_de_Negocio
{
    public class CN_Practicas
    {
        private CP_Practicas cpPracticas = new CP_Practicas();

        public DataTable MostrarPracticas()
        {
            return cpPracticas.MostrarPracticas();
        }

        public void AgregarPractica(string nombre, DateTime fecha, string objetivo, string procedimientos, string materiales, int idMateria)
        {
            cpPracticas.AgregarPractica(nombre, fecha, objetivo, procedimientos, materiales, idMateria);
        }

        public void ModificarPractica(int id, string nombre, DateTime fecha, string objetivo, string procedimientos, string materiales, int idMateria)
        {
            cpPracticas.ModificarPractica(id, nombre, fecha, objetivo, procedimientos, materiales, idMateria);
        }

        public void EliminarPractica(int id)
        {
            cpPracticas.EliminarPractica(id);
        }

        public DataTable MostrarPracticasPorMateria(int idMateria)
        {
            return cpPracticas.MostrarPracticasPorMateria(idMateria);
        }
    }
}
