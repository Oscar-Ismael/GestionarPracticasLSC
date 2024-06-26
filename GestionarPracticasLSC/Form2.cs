﻿using System;
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
            LoadPracticasEliminar();
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
            LoadMaterias();
        }

        private void btnAgregarPractica_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Botón Agregar Práctica clicado");
            string nombre = txtNombrePractica.Text;
            string fecha;
            try
            {
                fecha = DateTime.ParseExact(txtFechaPractica.Text, "dd/MM/yyyy", null).ToString("yyyy-MM-dd"); // Convertimos a yyyy-MM-dd
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de fecha incorrecto. Utiliza dd/MM/yyyy.");
                return;
            }

            string objetivo = txtObjetivoPractica.Text;
            string procedimientos = txtProcedimientosPractica.Text;
            string materiales = txtMaterialesPractica.Text;
            int idMateria = int.Parse(cmbMateriaPractica.SelectedValue.ToString());

            Console.WriteLine($"Datos de práctica: Nombre={nombre}, Fecha={fecha}, Objetivo={objetivo}, Procedimientos={procedimientos}, Materiales={materiales}, IdMateria={idMateria}");
            CN_Practicas cnPracticas = new CN_Practicas();
            try
            {
                cnPracticas.AgregarPractica(nombre, fecha, objetivo, procedimientos, materiales, idMateria);
                MessageBox.Show("Práctica agregada exitosamente");
                LoadPracticas();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificarPractica_Click(object sender, EventArgs e)
        {
            int idPractica = int.Parse(txtIDPracticaModificar.Text);
            string nombre = txtNombrePracticaModificar.Text;
            string fecha;
            try
            {
                fecha = DateTime.ParseExact(txtFechaPracticaModificar.Text, "dd/MM/yyyy", null).ToString("yyyy-MM-dd");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato de fecha incorrecto. Utiliza dd/MM/yyyy.");
                return;
            }

            string objetivo = txtObjetivoPracticaModificar.Text;
            string procedimientos = txtProcedimientosPracticaModificar.Text;
            string materiales = txtMaterialesPracticaModificar.Text;
            int idMateria = int.Parse(cmbMateriaPracticaModificar.SelectedValue.ToString());
            CN_Practicas cnPracticas = new CN_Practicas();
            try
            {
                cnPracticas.ModificarPractica(idPractica, nombre, fecha, objetivo, procedimientos, materiales, idMateria);
                MessageBox.Show("Práctica modificada con éxito.");
                LoadPracticas();
                LoadPracticasModificar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminarPractica_Click(object sender, EventArgs e)
        {
            int idPractica = int.Parse(txtIDPractica.Text);
            CN_Practicas cnPracticas = new CN_Practicas();
            try
            {
                cnPracticas.EliminarPractica(idPractica);
                MessageBox.Show("Práctica eliminada con éxito.");
                LoadPracticas();
                LoadPracticasEliminar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbMateriaPracticaEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPracticasEliminar();
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

            cmbMateriaPracticaModificar.DataSource = materias;
            cmbMateriaPracticaModificar.DisplayMember = "Nombremat";
            cmbMateriaPracticaModificar.ValueMember = "ID_Materia";

            dgvMaterias.DataSource = materias;
        }

        private void LoadPracticas()
        {
            Console.WriteLine("Cargando prácticas...");
            CN_Practicas cnPracticas = new CN_Practicas();
            DataTable practicas = cnPracticas.MostrarPracticas();
            dgvPracticas.DataSource = practicas;
        }

        private void LoadPracticasModificar()
        {
            CN_Practicas cnPracticas = new CN_Practicas();
            if (cmbMateriaPracticaModificar.SelectedValue != null)
            {
                int idMateria;
                if (int.TryParse(cmbMateriaPracticaModificar.SelectedValue.ToString(), out idMateria))
                {
                    DataTable practicas = cnPracticas.MostrarPracticasPorMateria(idMateria);
                    dgvPracticasModificar.DataSource = practicas;
                }
                else
                {
                    Console.WriteLine("No se pudo convertir el valor seleccionado a entero.");
                }
            }
        }

        private void LoadPracticasEliminar()
        {
            CN_Practicas cnPracticas = new CN_Practicas();
            if (cmbMateriaPracticaEliminar.SelectedValue != null)
            {
                int idMateria;
                if (int.TryParse(cmbMateriaPracticaEliminar.SelectedValue.ToString(), out idMateria))
                {
                    DataTable practicas = cnPracticas.MostrarPracticasPorMateria(idMateria);
                    dgvPracticasEliminar.DataSource = practicas;
                }
                else
                {
                    Console.WriteLine("No se pudo convertir el valor seleccionado a entero.");
                }
            }
        }

        private void cmbMateriaPracticaModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPracticasModificar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
