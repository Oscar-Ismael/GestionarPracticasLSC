using Capa_de_Persistencia;

namespace Capa_de_Negocio
{
    public class CN_Login
    {
        private CP_Login objetoCP = new CP_Login();

        public bool LoginUsuario(string correoElectronico, string contrasena, string tipoUsuario)
        {
            return objetoCP.Login(correoElectronico, contrasena, tipoUsuario);
        }

        public int ObtenerIdAlumno(string correoElectronico)
        {
            return objetoCP.ObtenerIdAlumno(correoElectronico);
        }
    }
}
