using System;
using System.Data;
using System.Windows.Forms;
using Capa_de_Negocio;

namespace GestionarPracticasLSC
{
    public partial class Form2 : Form
    {
        CN_Materias cnMaterias = new CN_Materias();
        CN_Practicas cnPracticas = new CN_Practicas();

        public Form2()
        {
            Console.WriteLine("Inicializando Form2...");
            InitializeComponent();
            LoadMaterias();
            LoadPracticas();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Botón Agregar Materia clicado.");
            string nombre = txtNombreMateria.Text;
            string codigo = txtCodigoMateria.Text;
            string descripcion = txtDescripcionMateria.Text;
            Console.WriteLine($"Datos de materia: Nombre={nombre}, Código={codigo}, Descripción={descripcion}");

            CN_Materias cnMaterias = new CN_Materias();
            cnMaterias.AgregarMateria(nombre, codigo, descripcion);
        }

        private void btnAgregarPractica_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Botón Agregar Práctica clicado"); // Mensaje de depuración
            string nombre = txtNombrePractica.Text;
            DateTime fecha = DateTime.Parse(txtFechaPractica.Text);
            string objetivo = txtObjetivoPractica.Text;
            string procedimientos = txtProcedimientosPractica.Text;
            string materiales = txtMaterialesPractica.Text;
            int idMateria = int.Parse(cmbMateriaPractica.SelectedValue.ToString());

            Console.WriteLine($"Datos de práctica: Nombre={nombre}, Fecha={fecha}, Objetivo={objetivo}, Procedimientos={procedimientos}, Materiales={materiales}, IdMateria={idMateria}"); // Mensaje de depuración

            try
            {
                cnPracticas.AgregarPractica(nombre, fecha, objetivo, procedimientos, materiales, idMateria);
                MessageBox.Show("Práctica agregada exitosamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message); // Mensaje de depuración
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificarPractica_Click(object sender, EventArgs e)
        {
            int idPractica = int.Parse(txtIDPracticaModificar.Text);
            string nombre = txtNombrePracticaModificar.Text;
            DateTime fecha = DateTime.Parse(txtFechaPracticaModificar.Text);
            string objetivo = txtObjetivoPracticaModificar.Text;
            string procedimientos = txtProcedimientosPracticaModificar.Text;
            string materiales = txtMaterialesPracticaModificar.Text;
            int idMateria = (int)cmbMateriaPracticaModificar.SelectedValue;

            cnPracticas.ModificarPractica(idPractica, nombre, fecha, objetivo, procedimientos, materiales, idMateria);
            MessageBox.Show("Práctica modificada con éxito.");
            LoadPracticas();
        }

        private void btnEliminarPractica_Click(object sender, EventArgs e)
        {
            int idPractica = int.Parse(txtIDPractica.Text);
            cnPracticas.EliminarPractica(idPractica);
            MessageBox.Show("Práctica eliminada con éxito.");
            LoadPracticas();
        }

        private void cmbMateriaPracticaEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idMateria = (int)cmbMateriaPracticaEliminar.SelectedValue;
            DataTable practicas = cnPracticas.MostrarPracticasPorMateria(idMateria);
            dgvPracticasEliminar.DataSource = practicas;
        }

        private void LoadMaterias()
        {
            Console.WriteLine("Cargando materias...");
            DataTable materias = cnMaterias.MostrarMaterias();
            cmbMateriaPractica.DataSource = materias;
            cmbMateriaPractica.DisplayMember = "Nombremat";
            cmbMateriaPractica.ValueMember = "ID_Materia";

            cmbMateriaPracticaEliminar.DataSource = materias;
            cmbMateriaPracticaEliminar.DisplayMember = "Nombremat";
            cmbMateriaPracticaEliminar.ValueMember = "ID_Materia";

            dgvMaterias.DataSource = materias;
        }

        private void LoadPracticas()
        {
            Console.WriteLine("Cargando prácticas...");
            DataTable practicas = cnPracticas.MostrarPracticas();
            dgvPracticas.DataSource = practicas;
        }
    }
}
