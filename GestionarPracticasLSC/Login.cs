using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_de_Negocio;

namespace GestionarPracticasLSC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Login loginNegocio = new CN_Login();
                string tipoUsuario = cmbTipoUsuario.SelectedItem.ToString();
                bool esValido = loginNegocio.LoginUsuario(txtCorreo.Text, txtContrasena.Text, tipoUsuario);

                if (esValido)
                {
                    MessageBox.Show("Inicio de sesión exitoso.");
                    // Abre el formulario correspondiente según el tipo de usuario
                    if (tipoUsuario == "Profesor")
                    {
                        Form2 formularioPrincipal = new Form2();
                        formularioPrincipal.Show();
                    }
                    else if (tipoUsuario == "Alumno")
                    {
                        Form3 formularioAlumno = new Form3();
                        formularioAlumno.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message);
            }
        }



        private void cbMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarContrasena.Checked)
            {
                // Mostrar la contraseña
                txtContrasena.UseSystemPasswordChar = false;
            }
            else
            {
                // Ocultar la contraseña
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

    }
}
