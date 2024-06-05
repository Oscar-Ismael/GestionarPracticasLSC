using System;
using System.Windows.Forms;

namespace GestionarPracticasLSC
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Console.WriteLine("Iniciando la aplicación...");
            Application.Run(new Login());  // Reemplaza "Login" con el nombre de tu formulario principal si es diferente
        }
    }
}
