using Capa_de_Persistencia;
using System;
using System.Data;

namespace Capa_de_Negocio
{
    public class CN_Practicas
    {
        private readonly CP_Practicas objetoCP = new CP_Practicas();

        public void AgregarPractica(string nombre, DateTime fecha, string objetivo, string procedimientos, string materiales, int idMateria)
        {
            objetoCP.AgregarPractica(nombre, fecha, objetivo, procedimientos, materiales, idMateria);
        }

        public DataTable MostrarPracticas()
        {
            return objetoCP.MostrarPracticas();
        }
    }
}
