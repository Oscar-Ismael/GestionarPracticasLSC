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
            InitializeComponent();
            LoadMaterias();
            LoadPracticas();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreMateria.Text;
            string codigo = txtCodigoMateria.Text;
            string descripcion = txtDescripcionMateria.Text;

            cnMaterias.AgregarMateria(nombre, codigo, descripcion);
            MessageBox.Show("Materia agregada con éxito.");
            LoadMaterias();
        }

        private void btnAgregarPractica_Click(object sender, EventArgs e)
        {
            string nombre = txtNombrePractica.Text;
            DateTime fecha = DateTime.Parse(txtFechaPractica.Text);
            string objetivo = txtObjetivoPractica.Text;
            string procedimientos = txtProcedimientosPractica.Text;
            string materiales = txtMaterialesPractica.Text;
            int idMateria = (int)cmbMateriaPractica.SelectedValue;

            cnPracticas.AgregarPractica(nombre, fecha, objetivo, procedimientos, materiales, idMateria);
            MessageBox.Show("Práctica agregada con éxito.");
            LoadPracticas();
        }

        private void LoadMaterias()
        {
            DataTable materias = cnMaterias.MostrarMaterias();
            cmbMateriaPractica.DataSource = materias;
            cmbMateriaPractica.DisplayMember = "Nombremat";
            cmbMateriaPractica.ValueMember = "ID_Materia";

            dgvMaterias.DataSource = materias;
        }

        private void LoadPracticas()
        {
            DataTable practicas = cnPracticas.MostrarPracticas();
            dgvPracticas.DataSource = practicas;
        }
    }
}
