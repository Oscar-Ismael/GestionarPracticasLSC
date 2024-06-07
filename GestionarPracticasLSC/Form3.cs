using Capa_de_Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestionarPracticasLSC
{
    public partial class Form3 : Form
    {
        private string correoAlumno;
        private CN_Materias cnMaterias = new CN_Materias();
        private CN_Practicas cnPracticas = new CN_Practicas();

        public Form3(string correo)
        {
            InitializeComponent();
            correoAlumno = correo;
            Console.WriteLine($"Correo del Alumno en Form3: {correoAlumno}");
            LoadMaterias();
        }

        private void LoadMaterias()
        {
            try
            {
                DataTable materiasTable = cnMaterias.ObtenerMateriasPorCorreo(correoAlumno);
                if (materiasTable.Rows.Count > 0)
                {
                    cmbMaterias.DataSource = materiasTable;
                    cmbMaterias.DisplayMember = "Nombremat";
                    cmbMaterias.ValueMember = "ID_Materia";
                    Console.WriteLine("Materias cargadas.");
                }
                else
                {
                    Console.WriteLine("No se encontraron materias para el alumno.");
                    MessageBox.Show("No se encontraron materias para el alumno.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar materias: " + ex.Message);
                MessageBox.Show("Error al cargar materias: " + ex.Message);
            }
        }

        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaterias.SelectedValue != null)
            {
                var selectedRowView = cmbMaterias.SelectedValue as DataRowView;
                if (selectedRowView != null)
                {
                    int materiaId = Convert.ToInt32(selectedRowView["ID_Materia"]);
                    Console.WriteLine($"Materia seleccionada ID: {materiaId}");
                    LoadPracticas(materiaId);
                }
            }
        }

        private void LoadPracticas(int materiaId)
        {
            try
            {
                Console.WriteLine($"Cargando prácticas para la materia ID: {materiaId}");
                DataTable practicasTable = cnPracticas.ObtenerPracticasPorMateria(materiaId);
                Console.WriteLine($"Número de prácticas obtenidas: {practicasTable.Rows.Count}");
                if (practicasTable.Rows.Count > 0)
                {
                    dgvPracticas.DataSource = practicasTable;
                    Console.WriteLine("Prácticas cargadas en el DataGridView.");
                }
                else
                {
                    Console.WriteLine("No se encontraron prácticas para la materia seleccionada.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar prácticas: {ex.Message}");
            }
        }

        private void btnEntregarPractica_Click(object sender, EventArgs e)
        {
            if (dgvPracticas.SelectedRows.Count > 0)
            {
                int practicaId = Convert.ToInt32(dgvPracticas.SelectedRows[0].Cells["ID_Practica"].Value);
                try
                {
                    cnPracticas.EntregarPractica(practicaId, correoAlumno);
                    MessageBox.Show("Práctica entregada exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al entregar práctica: " + ex.Message);
                    MessageBox.Show("Error al entregar práctica: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una práctica para entregar.");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
    }
}
