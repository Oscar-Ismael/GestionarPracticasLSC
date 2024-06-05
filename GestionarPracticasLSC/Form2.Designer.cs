using System.Windows.Forms;

namespace GestionarPracticasLSC
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        // Controles para el formulario
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.Button btnAgregarPractica;
        private System.Windows.Forms.Button btnEliminarPractica;
        private System.Windows.Forms.ComboBox cmbMateriaPractica;
        private System.Windows.Forms.ComboBox cmbMateriaPracticaModificar;
        private System.Windows.Forms.ComboBox cmbMateriaPracticaEliminar;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.DataGridView dgvPracticas;
        private System.Windows.Forms.DataGridView dgvPracticasModificar;
        private System.Windows.Forms.DataGridView dgvPracticasEliminar;
        private PlaceholderTextBox txtNombreMateria;
        private PlaceholderTextBox txtCodigoMateria;
        private PlaceholderTextBox txtDescripcionMateria;
        private PlaceholderTextBox txtNombrePractica;
        private PlaceholderTextBox txtFechaPractica;
        private PlaceholderTextBox txtObjetivoPractica;
        private PlaceholderTextBox txtProcedimientosPractica;
        private PlaceholderTextBox txtMaterialesPractica;
        private PlaceholderTextBox txtIDPractica;
        private PlaceholderTextBox txtNombrePracticaModificar;
        private PlaceholderTextBox txtFechaPracticaModificar;
        private PlaceholderTextBox txtObjetivoPracticaModificar;
        private PlaceholderTextBox txtProcedimientosPracticaModificar;
        private PlaceholderTextBox txtMaterialesPracticaModificar;
        private PlaceholderTextBox txtIDPracticaModificar;
        private TabControl tabControl;
        private TabPage tabMaterias;
        private TabPage tabPracticas;
        private TabPage tabModificarPractica;
        private TabPage tabEliminarPractica;
        private Label lblNombreMateria;
        private Label lblCodigoMateria;
        private Label lblDescripcionMateria;
        private Label lblNombrePractica;
        private Label lblFechaPractica;
        private Label lblObjetivoPractica;
        private Label lblProcedimientosPractica;
        private Label lblMaterialesPractica;
        private Label lblMateriaPractica;
        private Label lblIDPracticaModificar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMaterias = new System.Windows.Forms.TabPage();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.lblCodigoMateria = new System.Windows.Forms.Label();
            this.lblDescripcionMateria = new System.Windows.Forms.Label();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.txtNombreMateria = new PlaceholderTextBox();
            this.txtCodigoMateria = new PlaceholderTextBox();
            this.txtDescripcionMateria = new PlaceholderTextBox();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.tabPracticas = new System.Windows.Forms.TabPage();
            this.lblNombrePractica = new System.Windows.Forms.Label();
            this.lblFechaPractica = new System.Windows.Forms.Label();
            this.lblObjetivoPractica = new System.Windows.Forms.Label();
            this.lblProcedimientosPractica = new System.Windows.Forms.Label();
            this.lblMaterialesPractica = new System.Windows.Forms.Label();
            this.lblMateriaPractica = new System.Windows.Forms.Label();
            this.dgvPracticas = new System.Windows.Forms.DataGridView();
            this.cmbMateriaPractica = new System.Windows.Forms.ComboBox();
            this.btnAgregarPractica = new System.Windows.Forms.Button();
            this.txtNombrePractica = new PlaceholderTextBox();
            this.txtFechaPractica = new PlaceholderTextBox();
            this.txtObjetivoPractica = new PlaceholderTextBox();
            this.txtProcedimientosPractica = new PlaceholderTextBox();
            this.txtMaterialesPractica = new PlaceholderTextBox();
            this.tabModificarPractica = new System.Windows.Forms.TabPage();
            this.lbnombrepracticasModificar = new System.Windows.Forms.Label();
            this.lblfechadelaPracticaModificar = new System.Windows.Forms.Label();
            this.lblobjetivodelapracticaModificar = new System.Windows.Forms.Label();
            this.lblprocedimientosModificar = new System.Windows.Forms.Label();
            this.lblmaterialesnecesariosModificar = new System.Windows.Forms.Label();
            this.cmbMateriaPracticaModificar = new System.Windows.Forms.ComboBox();
            this.dgvPracticasModificar = new System.Windows.Forms.DataGridView();
            this.txtNombrePracticaModificar = new PlaceholderTextBox();
            this.txtFechaPracticaModificar = new PlaceholderTextBox();
            this.txtObjetivoPracticaModificar = new PlaceholderTextBox();
            this.txtProcedimientosPracticaModificar = new PlaceholderTextBox();
            this.txtMaterialesPracticaModificar = new PlaceholderTextBox();
            this.txtIDPracticaModificar = new PlaceholderTextBox();
            this.lblIDPracticaModificar = new System.Windows.Forms.Label();
            this.tabEliminarPractica = new System.Windows.Forms.TabPage();
            this.lblmateriasEliminar = new System.Windows.Forms.Label();
            this.lblIDdelapracticaEliminar = new System.Windows.Forms.Label();
            this.cmbMateriaPracticaEliminar = new System.Windows.Forms.ComboBox();
            this.dgvPracticasEliminar = new System.Windows.Forms.DataGridView();
            this.txtIDPractica = new PlaceholderTextBox();
            this.btnEliminarPractica = new System.Windows.Forms.Button();
            this.btnModificarPractica = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.tabPracticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticas)).BeginInit();
            this.tabModificarPractica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticasModificar)).BeginInit();
            this.tabEliminarPractica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticasEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMaterias);
            this.tabControl.Controls.Add(this.tabPracticas);
            this.tabControl.Controls.Add(this.tabModificarPractica);
            this.tabControl.Controls.Add(this.tabEliminarPractica);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 426);
            this.tabControl.TabIndex = 0;
            // 
            // tabMaterias
            // 
            this.tabMaterias.Controls.Add(this.lblNombreMateria);
            this.tabMaterias.Controls.Add(this.lblCodigoMateria);
            this.tabMaterias.Controls.Add(this.lblDescripcionMateria);
            this.tabMaterias.Controls.Add(this.dgvMaterias);
            this.tabMaterias.Controls.Add(this.txtNombreMateria);
            this.tabMaterias.Controls.Add(this.txtCodigoMateria);
            this.tabMaterias.Controls.Add(this.txtDescripcionMateria);
            this.tabMaterias.Controls.Add(this.btnAgregarMateria);
            this.tabMaterias.Location = new System.Drawing.Point(4, 22);
            this.tabMaterias.Name = "tabMaterias";
            this.tabMaterias.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterias.Size = new System.Drawing.Size(768, 400);
            this.tabMaterias.TabIndex = 0;
            this.tabMaterias.Text = "Materias";
            this.tabMaterias.UseVisualStyleBackColor = true;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Location = new System.Drawing.Point(26, 11);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(97, 13);
            this.lblNombreMateria.TabIndex = 11;
            this.lblNombreMateria.Text = "Nombre de Materia";
            // 
            // lblCodigoMateria
            // 
            this.lblCodigoMateria.AutoSize = true;
            this.lblCodigoMateria.Location = new System.Drawing.Point(26, 41);
            this.lblCodigoMateria.Name = "lblCodigoMateria";
            this.lblCodigoMateria.Size = new System.Drawing.Size(93, 13);
            this.lblCodigoMateria.TabIndex = 12;
            this.lblCodigoMateria.Text = "Código de Materia";
            // 
            // lblDescripcionMateria
            // 
            this.lblDescripcionMateria.AutoSize = true;
            this.lblDescripcionMateria.Location = new System.Drawing.Point(26, 71);
            this.lblDescripcionMateria.Name = "lblDescripcionMateria";
            this.lblDescripcionMateria.Size = new System.Drawing.Size(116, 13);
            this.lblDescripcionMateria.TabIndex = 13;
            this.lblDescripcionMateria.Text = "Descripción de Materia";
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(245, 6);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.Size = new System.Drawing.Size(500, 300);
            this.dgvMaterias.TabIndex = 0;
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.ForeColor = System.Drawing.Color.Gray;
            this.txtNombreMateria.Location = new System.Drawing.Point(20, 20);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.PlaceholderText = "Nombre de la Materia";
            this.txtNombreMateria.Size = new System.Drawing.Size(200, 20);
            this.txtNombreMateria.TabIndex = 0;
            this.txtNombreMateria.Text = "Nombre de la Materia";
            // 
            // txtCodigoMateria
            // 
            this.txtCodigoMateria.ForeColor = System.Drawing.Color.Gray;
            this.txtCodigoMateria.Location = new System.Drawing.Point(20, 50);
            this.txtCodigoMateria.Name = "txtCodigoMateria";
            this.txtCodigoMateria.PlaceholderText = "Código de la Materia";
            this.txtCodigoMateria.Size = new System.Drawing.Size(200, 20);
            this.txtCodigoMateria.TabIndex = 1;
            this.txtCodigoMateria.Text = "Código de la Materia";
            // 
            // txtDescripcionMateria
            // 
            this.txtDescripcionMateria.ForeColor = System.Drawing.Color.Gray;
            this.txtDescripcionMateria.Location = new System.Drawing.Point(20, 80);
            this.txtDescripcionMateria.Name = "txtDescripcionMateria";
            this.txtDescripcionMateria.PlaceholderText = "Descripción de la Materia";
            this.txtDescripcionMateria.Size = new System.Drawing.Size(200, 20);
            this.txtDescripcionMateria.TabIndex = 2;
            this.txtDescripcionMateria.Text = "Descripción de la Materia";
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(20, 110);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(200, 23);
            this.btnAgregarMateria.TabIndex = 3;
            this.btnAgregarMateria.Text = "Agregar Materia";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // tabPracticas
            // 
            this.tabPracticas.Controls.Add(this.lblNombrePractica);
            this.tabPracticas.Controls.Add(this.lblFechaPractica);
            this.tabPracticas.Controls.Add(this.lblObjetivoPractica);
            this.tabPracticas.Controls.Add(this.lblProcedimientosPractica);
            this.tabPracticas.Controls.Add(this.lblMaterialesPractica);
            this.tabPracticas.Controls.Add(this.lblMateriaPractica);
            this.tabPracticas.Controls.Add(this.dgvPracticas);
            this.tabPracticas.Controls.Add(this.cmbMateriaPractica);
            this.tabPracticas.Controls.Add(this.btnAgregarPractica);
            this.tabPracticas.Controls.Add(this.txtNombrePractica);
            this.tabPracticas.Controls.Add(this.txtFechaPractica);
            this.tabPracticas.Controls.Add(this.txtObjetivoPractica);
            this.tabPracticas.Controls.Add(this.txtProcedimientosPractica);
            this.tabPracticas.Controls.Add(this.txtMaterialesPractica);
            this.tabPracticas.Location = new System.Drawing.Point(4, 22);
            this.tabPracticas.Name = "tabPracticas";
            this.tabPracticas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPracticas.Size = new System.Drawing.Size(768, 400);
            this.tabPracticas.TabIndex = 1;
            this.tabPracticas.Text = "Prácticas";
            this.tabPracticas.UseVisualStyleBackColor = true;
            // 
            // lblNombrePractica
            // 
            this.lblNombrePractica.AutoSize = true;
            this.lblNombrePractica.Location = new System.Drawing.Point(26, 11);
            this.lblNombrePractica.Name = "lblNombrePractica";
            this.lblNombrePractica.Size = new System.Drawing.Size(101, 13);
            this.lblNombrePractica.TabIndex = 14;
            this.lblNombrePractica.Text = "Nombre de Práctica";
            // 
            // lblFechaPractica
            // 
            this.lblFechaPractica.AutoSize = true;
            this.lblFechaPractica.Location = new System.Drawing.Point(26, 41);
            this.lblFechaPractica.Name = "lblFechaPractica";
            this.lblFechaPractica.Size = new System.Drawing.Size(94, 13);
            this.lblFechaPractica.TabIndex = 15;
            this.lblFechaPractica.Text = "Fecha de Práctica";
            // 
            // lblObjetivoPractica
            // 
            this.lblObjetivoPractica.AutoSize = true;
            this.lblObjetivoPractica.Location = new System.Drawing.Point(26, 71);
            this.lblObjetivoPractica.Name = "lblObjetivoPractica";
            this.lblObjetivoPractica.Size = new System.Drawing.Size(103, 13);
            this.lblObjetivoPractica.TabIndex = 16;
            this.lblObjetivoPractica.Text = "Objetivo de Práctica";
            // 
            // lblProcedimientosPractica
            // 
            this.lblProcedimientosPractica.AutoSize = true;
            this.lblProcedimientosPractica.Location = new System.Drawing.Point(26, 101);
            this.lblProcedimientosPractica.Name = "lblProcedimientosPractica";
            this.lblProcedimientosPractica.Size = new System.Drawing.Size(79, 13);
            this.lblProcedimientosPractica.TabIndex = 17;
            this.lblProcedimientosPractica.Text = "Procedimientos";
            // 
            // lblMaterialesPractica
            // 
            this.lblMaterialesPractica.AutoSize = true;
            this.lblMaterialesPractica.Location = new System.Drawing.Point(26, 131);
            this.lblMaterialesPractica.Name = "lblMaterialesPractica";
            this.lblMaterialesPractica.Size = new System.Drawing.Size(111, 13);
            this.lblMaterialesPractica.TabIndex = 18;
            this.lblMaterialesPractica.Text = "Materiales Necesarios";
            // 
            // lblMateriaPractica
            // 
            this.lblMateriaPractica.AutoSize = true;
            this.lblMateriaPractica.Location = new System.Drawing.Point(26, 161);
            this.lblMateriaPractica.Name = "lblMateriaPractica";
            this.lblMateriaPractica.Size = new System.Drawing.Size(42, 13);
            this.lblMateriaPractica.TabIndex = 19;
            this.lblMateriaPractica.Text = "Materia";
            // 
            // dgvPracticas
            // 
            this.dgvPracticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracticas.Location = new System.Drawing.Point(245, 6);
            this.dgvPracticas.Name = "dgvPracticas";
            this.dgvPracticas.Size = new System.Drawing.Size(500, 300);
            this.dgvPracticas.TabIndex = 0;
            // 
            // cmbMateriaPractica
            // 
            this.cmbMateriaPractica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateriaPractica.FormattingEnabled = true;
            this.cmbMateriaPractica.Location = new System.Drawing.Point(20, 170);
            this.cmbMateriaPractica.Name = "cmbMateriaPractica";
            this.cmbMateriaPractica.Size = new System.Drawing.Size(200, 21);
            this.cmbMateriaPractica.TabIndex = 9;
            // 
            // btnAgregarPractica
            // 
            this.btnAgregarPractica.Location = new System.Drawing.Point(20, 200);
            this.btnAgregarPractica.Name = "btnAgregarPractica";
            this.btnAgregarPractica.Size = new System.Drawing.Size(200, 23);
            this.btnAgregarPractica.TabIndex = 10;
            this.btnAgregarPractica.Text = "Agregar Práctica";
            this.btnAgregarPractica.UseVisualStyleBackColor = true;
            this.btnAgregarPractica.Click += new System.EventHandler(this.btnAgregarPractica_Click);
            // 
            // txtNombrePractica
            // 
            this.txtNombrePractica.ForeColor = System.Drawing.Color.Gray;
            this.txtNombrePractica.Location = new System.Drawing.Point(20, 20);
            this.txtNombrePractica.Name = "txtNombrePractica";
            this.txtNombrePractica.PlaceholderText = "Nombre de la Práctica";
            this.txtNombrePractica.Size = new System.Drawing.Size(200, 20);
            this.txtNombrePractica.TabIndex = 4;
            this.txtNombrePractica.Text = "Nombre de la Práctica";
            // 
            // txtFechaPractica
            // 
            this.txtFechaPractica.ForeColor = System.Drawing.Color.Gray;
            this.txtFechaPractica.Location = new System.Drawing.Point(20, 50);
            this.txtFechaPractica.Name = "txtFechaPractica";
            this.txtFechaPractica.PlaceholderText = "Fecha de la Práctica";
            this.txtFechaPractica.Size = new System.Drawing.Size(200, 20);
            this.txtFechaPractica.TabIndex = 5;
            this.txtFechaPractica.Text = "Fecha de la Práctica";
            // 
            // txtObjetivoPractica
            // 
            this.txtObjetivoPractica.ForeColor = System.Drawing.Color.Gray;
            this.txtObjetivoPractica.Location = new System.Drawing.Point(20, 80);
            this.txtObjetivoPractica.Name = "txtObjetivoPractica";
            this.txtObjetivoPractica.PlaceholderText = "Objetivo de la Práctica";
            this.txtObjetivoPractica.Size = new System.Drawing.Size(200, 20);
            this.txtObjetivoPractica.TabIndex = 6;
            this.txtObjetivoPractica.Text = "Objetivo de la Práctica";
            // 
            // txtProcedimientosPractica
            // 
            this.txtProcedimientosPractica.ForeColor = System.Drawing.Color.Gray;
            this.txtProcedimientosPractica.Location = new System.Drawing.Point(20, 110);
            this.txtProcedimientosPractica.Name = "txtProcedimientosPractica";
            this.txtProcedimientosPractica.PlaceholderText = "Procedimientos";
            this.txtProcedimientosPractica.Size = new System.Drawing.Size(200, 20);
            this.txtProcedimientosPractica.TabIndex = 7;
            this.txtProcedimientosPractica.Text = "Procedimientos";
            // 
            // txtMaterialesPractica
            // 
            this.txtMaterialesPractica.ForeColor = System.Drawing.Color.Gray;
            this.txtMaterialesPractica.Location = new System.Drawing.Point(20, 140);
            this.txtMaterialesPractica.Name = "txtMaterialesPractica";
            this.txtMaterialesPractica.PlaceholderText = "Materiales Necesarios";
            this.txtMaterialesPractica.Size = new System.Drawing.Size(200, 20);
            this.txtMaterialesPractica.TabIndex = 8;
            this.txtMaterialesPractica.Text = "Materiales Necesarios";
            // 
            // tabModificarPractica
            // 
            this.tabModificarPractica.Controls.Add(this.btnModificarPractica);
            this.tabModificarPractica.Controls.Add(this.lbnombrepracticasModificar);
            this.tabModificarPractica.Controls.Add(this.lblfechadelaPracticaModificar);
            this.tabModificarPractica.Controls.Add(this.lblobjetivodelapracticaModificar);
            this.tabModificarPractica.Controls.Add(this.lblprocedimientosModificar);
            this.tabModificarPractica.Controls.Add(this.lblmaterialesnecesariosModificar);
            this.tabModificarPractica.Controls.Add(this.cmbMateriaPracticaModificar);
            this.tabModificarPractica.Controls.Add(this.dgvPracticasModificar);
            this.tabModificarPractica.Controls.Add(this.txtNombrePracticaModificar);
            this.tabModificarPractica.Controls.Add(this.txtFechaPracticaModificar);
            this.tabModificarPractica.Controls.Add(this.txtObjetivoPracticaModificar);
            this.tabModificarPractica.Controls.Add(this.txtProcedimientosPracticaModificar);
            this.tabModificarPractica.Controls.Add(this.txtMaterialesPracticaModificar);
            this.tabModificarPractica.Controls.Add(this.txtIDPracticaModificar);
            this.tabModificarPractica.Controls.Add(this.lblIDPracticaModificar);
            this.tabModificarPractica.Location = new System.Drawing.Point(4, 22);
            this.tabModificarPractica.Name = "tabModificarPractica";
            this.tabModificarPractica.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificarPractica.Size = new System.Drawing.Size(768, 400);
            this.tabModificarPractica.TabIndex = 2;
            this.tabModificarPractica.Text = "Modificar Práctica";
            this.tabModificarPractica.UseVisualStyleBackColor = true;
            // 
            // lbnombrepracticasModificar
            // 
            this.lbnombrepracticasModificar.AutoSize = true;
            this.lbnombrepracticasModificar.Location = new System.Drawing.Point(17, 19);
            this.lbnombrepracticasModificar.Name = "lbnombrepracticasModificar";
            this.lbnombrepracticasModificar.Size = new System.Drawing.Size(112, 13);
            this.lbnombrepracticasModificar.TabIndex = 19;
            this.lbnombrepracticasModificar.Text = "Nombre de la Práctica";
            // 
            // lblfechadelaPracticaModificar
            // 
            this.lblfechadelaPracticaModificar.AutoSize = true;
            this.lblfechadelaPracticaModificar.Location = new System.Drawing.Point(17, 58);
            this.lblfechadelaPracticaModificar.Name = "lblfechadelaPracticaModificar";
            this.lblfechadelaPracticaModificar.Size = new System.Drawing.Size(105, 13);
            this.lblfechadelaPracticaModificar.TabIndex = 18;
            this.lblfechadelaPracticaModificar.Text = "Fecha de la Práctica";
            // 
            // lblobjetivodelapracticaModificar
            // 
            this.lblobjetivodelapracticaModificar.AutoSize = true;
            this.lblobjetivodelapracticaModificar.Location = new System.Drawing.Point(17, 97);
            this.lblobjetivodelapracticaModificar.Name = "lblobjetivodelapracticaModificar";
            this.lblobjetivodelapracticaModificar.Size = new System.Drawing.Size(114, 13);
            this.lblobjetivodelapracticaModificar.TabIndex = 17;
            this.lblobjetivodelapracticaModificar.Text = "Objetivo de la Práctica";
            // 
            // lblprocedimientosModificar
            // 
            this.lblprocedimientosModificar.AutoSize = true;
            this.lblprocedimientosModificar.Location = new System.Drawing.Point(17, 136);
            this.lblprocedimientosModificar.Name = "lblprocedimientosModificar";
            this.lblprocedimientosModificar.Size = new System.Drawing.Size(79, 13);
            this.lblprocedimientosModificar.TabIndex = 16;
            this.lblprocedimientosModificar.Text = "Procedimientos";
            // 
            // lblmaterialesnecesariosModificar
            // 
            this.lblmaterialesnecesariosModificar.AutoSize = true;
            this.lblmaterialesnecesariosModificar.Location = new System.Drawing.Point(17, 175);
            this.lblmaterialesnecesariosModificar.Name = "lblmaterialesnecesariosModificar";
            this.lblmaterialesnecesariosModificar.Size = new System.Drawing.Size(111, 13);
            this.lblmaterialesnecesariosModificar.TabIndex = 15;
            this.lblmaterialesnecesariosModificar.Text = "Materiales Necesarios";
            // 
            // cmbMateriaPracticaModificar
            // 
            this.cmbMateriaPracticaModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateriaPracticaModificar.FormattingEnabled = true;
            this.cmbMateriaPracticaModificar.Location = new System.Drawing.Point(20, 256);
            this.cmbMateriaPracticaModificar.Name = "cmbMateriaPracticaModificar";
            this.cmbMateriaPracticaModificar.Size = new System.Drawing.Size(200, 21);
            this.cmbMateriaPracticaModificar.TabIndex = 9;
            this.cmbMateriaPracticaModificar.SelectedIndexChanged += new System.EventHandler(this.cmbMateriaPracticaModificar_SelectedIndexChanged);
            // 
            // dgvPracticasModificar
            // 
            this.dgvPracticasModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracticasModificar.Location = new System.Drawing.Point(245, 6);
            this.dgvPracticasModificar.Name = "dgvPracticasModificar";
            this.dgvPracticasModificar.Size = new System.Drawing.Size(500, 300);
            this.dgvPracticasModificar.TabIndex = 0;
            // 
            // txtNombrePracticaModificar
            // 
            this.txtNombrePracticaModificar.ForeColor = System.Drawing.Color.Gray;
            this.txtNombrePracticaModificar.Location = new System.Drawing.Point(20, 35);
            this.txtNombrePracticaModificar.Name = "txtNombrePracticaModificar";
            this.txtNombrePracticaModificar.PlaceholderText = "Nombre de la Práctica";
            this.txtNombrePracticaModificar.Size = new System.Drawing.Size(200, 20);
            this.txtNombrePracticaModificar.TabIndex = 4;
            this.txtNombrePracticaModificar.Text = "Nombre de la Práctica";
            // 
            // txtFechaPracticaModificar
            // 
            this.txtFechaPracticaModificar.ForeColor = System.Drawing.Color.Gray;
            this.txtFechaPracticaModificar.Location = new System.Drawing.Point(20, 74);
            this.txtFechaPracticaModificar.Name = "txtFechaPracticaModificar";
            this.txtFechaPracticaModificar.PlaceholderText = "Fecha de la Práctica";
            this.txtFechaPracticaModificar.Size = new System.Drawing.Size(200, 20);
            this.txtFechaPracticaModificar.TabIndex = 5;
            this.txtFechaPracticaModificar.Text = "Fecha de la Práctica";
            // 
            // txtObjetivoPracticaModificar
            // 
            this.txtObjetivoPracticaModificar.ForeColor = System.Drawing.Color.Gray;
            this.txtObjetivoPracticaModificar.Location = new System.Drawing.Point(20, 113);
            this.txtObjetivoPracticaModificar.Name = "txtObjetivoPracticaModificar";
            this.txtObjetivoPracticaModificar.PlaceholderText = "Objetivo de la Práctica";
            this.txtObjetivoPracticaModificar.Size = new System.Drawing.Size(200, 20);
            this.txtObjetivoPracticaModificar.TabIndex = 6;
            this.txtObjetivoPracticaModificar.Text = "Objetivo de la Práctica";
            // 
            // txtProcedimientosPracticaModificar
            // 
            this.txtProcedimientosPracticaModificar.ForeColor = System.Drawing.Color.Gray;
            this.txtProcedimientosPracticaModificar.Location = new System.Drawing.Point(20, 152);
            this.txtProcedimientosPracticaModificar.Name = "txtProcedimientosPracticaModificar";
            this.txtProcedimientosPracticaModificar.PlaceholderText = "Procedimientos";
            this.txtProcedimientosPracticaModificar.Size = new System.Drawing.Size(200, 20);
            this.txtProcedimientosPracticaModificar.TabIndex = 7;
            this.txtProcedimientosPracticaModificar.Text = "Procedimientos";
            // 
            // txtMaterialesPracticaModificar
            // 
            this.txtMaterialesPracticaModificar.ForeColor = System.Drawing.Color.Gray;
            this.txtMaterialesPracticaModificar.Location = new System.Drawing.Point(20, 191);
            this.txtMaterialesPracticaModificar.Name = "txtMaterialesPracticaModificar";
            this.txtMaterialesPracticaModificar.PlaceholderText = "Materiales Necesarios";
            this.txtMaterialesPracticaModificar.Size = new System.Drawing.Size(200, 20);
            this.txtMaterialesPracticaModificar.TabIndex = 8;
            this.txtMaterialesPracticaModificar.Text = "Materiales Necesarios";
            // 
            // txtIDPracticaModificar
            // 
            this.txtIDPracticaModificar.ForeColor = System.Drawing.Color.Gray;
            this.txtIDPracticaModificar.Location = new System.Drawing.Point(20, 230);
            this.txtIDPracticaModificar.Name = "txtIDPracticaModificar";
            this.txtIDPracticaModificar.PlaceholderText = "ID de la Práctica";
            this.txtIDPracticaModificar.Size = new System.Drawing.Size(200, 20);
            this.txtIDPracticaModificar.TabIndex = 13;
            this.txtIDPracticaModificar.Text = "ID de la Práctica";
            // 
            // lblIDPracticaModificar
            // 
            this.lblIDPracticaModificar.AutoSize = true;
            this.lblIDPracticaModificar.Location = new System.Drawing.Point(17, 214);
            this.lblIDPracticaModificar.Name = "lblIDPracticaModificar";
            this.lblIDPracticaModificar.Size = new System.Drawing.Size(75, 13);
            this.lblIDPracticaModificar.TabIndex = 14;
            this.lblIDPracticaModificar.Text = "ID de Práctica";
            // 
            // tabEliminarPractica
            // 
            this.tabEliminarPractica.Controls.Add(this.lblmateriasEliminar);
            this.tabEliminarPractica.Controls.Add(this.lblIDdelapracticaEliminar);
            this.tabEliminarPractica.Controls.Add(this.cmbMateriaPracticaEliminar);
            this.tabEliminarPractica.Controls.Add(this.dgvPracticasEliminar);
            this.tabEliminarPractica.Controls.Add(this.txtIDPractica);
            this.tabEliminarPractica.Controls.Add(this.btnEliminarPractica);
            this.tabEliminarPractica.Location = new System.Drawing.Point(4, 22);
            this.tabEliminarPractica.Name = "tabEliminarPractica";
            this.tabEliminarPractica.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminarPractica.Size = new System.Drawing.Size(768, 400);
            this.tabEliminarPractica.TabIndex = 3;
            this.tabEliminarPractica.Text = "Eliminar Práctica";
            this.tabEliminarPractica.UseVisualStyleBackColor = true;
            // 
            // lblmateriasEliminar
            // 
            this.lblmateriasEliminar.AutoSize = true;
            this.lblmateriasEliminar.Location = new System.Drawing.Point(17, 12);
            this.lblmateriasEliminar.Name = "lblmateriasEliminar";
            this.lblmateriasEliminar.Size = new System.Drawing.Size(47, 13);
            this.lblmateriasEliminar.TabIndex = 15;
            this.lblmateriasEliminar.Text = "Materias";
            // 
            // lblIDdelapracticaEliminar
            // 
            this.lblIDdelapracticaEliminar.AutoSize = true;
            this.lblIDdelapracticaEliminar.Location = new System.Drawing.Point(17, 52);
            this.lblIDdelapracticaEliminar.Name = "lblIDdelapracticaEliminar";
            this.lblIDdelapracticaEliminar.Size = new System.Drawing.Size(86, 13);
            this.lblIDdelapracticaEliminar.TabIndex = 14;
            this.lblIDdelapracticaEliminar.Text = "ID de la Prácrica";
            // 
            // cmbMateriaPracticaEliminar
            // 
            this.cmbMateriaPracticaEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateriaPracticaEliminar.FormattingEnabled = true;
            this.cmbMateriaPracticaEliminar.Location = new System.Drawing.Point(20, 28);
            this.cmbMateriaPracticaEliminar.Name = "cmbMateriaPracticaEliminar";
            this.cmbMateriaPracticaEliminar.Size = new System.Drawing.Size(200, 21);
            this.cmbMateriaPracticaEliminar.TabIndex = 9;
            // 
            // dgvPracticasEliminar
            // 
            this.dgvPracticasEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracticasEliminar.Location = new System.Drawing.Point(245, 6);
            this.dgvPracticasEliminar.Name = "dgvPracticasEliminar";
            this.dgvPracticasEliminar.Size = new System.Drawing.Size(500, 300);
            this.dgvPracticasEliminar.TabIndex = 0;
            // 
            // txtIDPractica
            // 
            this.txtIDPractica.ForeColor = System.Drawing.Color.Gray;
            this.txtIDPractica.Location = new System.Drawing.Point(20, 68);
            this.txtIDPractica.Name = "txtIDPractica";
            this.txtIDPractica.PlaceholderText = "ID de la Práctica";
            this.txtIDPractica.Size = new System.Drawing.Size(200, 20);
            this.txtIDPractica.TabIndex = 13;
            this.txtIDPractica.Text = "ID de la Práctica";
            // 
            // btnEliminarPractica
            // 
            this.btnEliminarPractica.Location = new System.Drawing.Point(20, 94);
            this.btnEliminarPractica.Name = "btnEliminarPractica";
            this.btnEliminarPractica.Size = new System.Drawing.Size(200, 23);
            this.btnEliminarPractica.TabIndex = 10;
            this.btnEliminarPractica.Text = "Eliminar Práctica";
            this.btnEliminarPractica.UseVisualStyleBackColor = true;
            this.btnEliminarPractica.Click += new System.EventHandler(this.btnEliminarPractica_Click);
            // 
            // btnModificarPractica
            // 
            this.btnModificarPractica.Location = new System.Drawing.Point(20, 283);
            this.btnModificarPractica.Name = "btnModificarPractica";
            this.btnModificarPractica.Size = new System.Drawing.Size(200, 23);
            this.btnModificarPractica.TabIndex = 20;
            this.btnModificarPractica.Text = "Modificar Práctica";
            this.btnModificarPractica.UseVisualStyleBackColor = true;
            this.btnModificarPractica.Click += new System.EventHandler(this.btnModificarPractica_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form2";
            this.Text = "Gestión de Prácticas";
            this.tabControl.ResumeLayout(false);
            this.tabMaterias.ResumeLayout(false);
            this.tabMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.tabPracticas.ResumeLayout(false);
            this.tabPracticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticas)).EndInit();
            this.tabModificarPractica.ResumeLayout(false);
            this.tabModificarPractica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticasModificar)).EndInit();
            this.tabEliminarPractica.ResumeLayout(false);
            this.tabEliminarPractica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticasEliminar)).EndInit();
            this.ResumeLayout(false);

        }

        private Label lbnombrepracticasModificar;
        private Label lblfechadelaPracticaModificar;
        private Label lblobjetivodelapracticaModificar;
        private Label lblprocedimientosModificar;
        private Label lblmaterialesnecesariosModificar;
        private Label lblmateriasEliminar;
        private Label lblIDdelapracticaEliminar;
        private Button btnModificarPractica;
    }
}
