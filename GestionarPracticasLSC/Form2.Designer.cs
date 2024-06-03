using System.Windows.Forms;

namespace GestionarPracticasLSC
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private PlaceholderTextBox txtNombreMateria;
        private PlaceholderTextBox txtCodigoMateria;
        private PlaceholderTextBox txtDescripcionMateria;
        private Button btnAgregarMateria;
        private PlaceholderTextBox txtNombrePractica;
        private PlaceholderTextBox txtFechaPractica;
        private PlaceholderTextBox txtObjetivoPractica;
        private PlaceholderTextBox txtProcedimientosPractica;
        private PlaceholderTextBox txtMaterialesPractica;
        private ComboBox cmbMateriaPractica;
        private Button btnAgregarPractica;
        private TabControl tabControl;
        private TabPage tabMaterias;
        private TabPage tabPracticas;
        private DataGridView dgvPracticas;
        private Label lblNombreMateria;
        private Label lblCodigoMateria;
        private Label lblDescripcionMateria;
        private Label lblNombrePractica;
        private Label lblFechaPractica;
        private Label lblObjetivoPractica;
        private Label lblProcedimientosPractica;
        private Label lblMaterialesPractica;
        private Label lblMateriaPractica;

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
            this.txtNombreMateria = new PlaceholderTextBox();
            this.txtCodigoMateria = new PlaceholderTextBox();
            this.txtDescripcionMateria = new PlaceholderTextBox();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.txtNombrePractica = new PlaceholderTextBox();
            this.txtFechaPractica = new PlaceholderTextBox();
            this.txtObjetivoPractica = new PlaceholderTextBox();
            this.txtProcedimientosPractica = new PlaceholderTextBox();
            this.txtMaterialesPractica = new PlaceholderTextBox();
            this.cmbMateriaPractica = new System.Windows.Forms.ComboBox();
            this.btnAgregarPractica = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMaterias = new System.Windows.Forms.TabPage();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.tabPracticas = new System.Windows.Forms.TabPage();
            this.dgvPracticas = new System.Windows.Forms.DataGridView();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.lblCodigoMateria = new System.Windows.Forms.Label();
            this.lblDescripcionMateria = new System.Windows.Forms.Label();
            this.lblNombrePractica = new System.Windows.Forms.Label();
            this.lblFechaPractica = new System.Windows.Forms.Label();
            this.lblObjetivoPractica = new System.Windows.Forms.Label();
            this.lblProcedimientosPractica = new System.Windows.Forms.Label();
            this.lblMaterialesPractica = new System.Windows.Forms.Label();
            this.lblMateriaPractica = new System.Windows.Forms.Label();
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Location = new System.Drawing.Point(20, 5);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(94, 13);
            this.lblNombreMateria.TabIndex = 11;
            this.lblNombreMateria.Text = "Nombre de Materia";
            // 
            // lblCodigoMateria
            // 
            this.lblCodigoMateria.AutoSize = true;
            this.lblCodigoMateria.Location = new System.Drawing.Point(20, 35);
            this.lblCodigoMateria.Name = "lblCodigoMateria";
            this.lblCodigoMateria.Size = new System.Drawing.Size(88, 13);
            this.lblCodigoMateria.TabIndex = 12;
            this.lblCodigoMateria.Text = "Código de Materia";
            // 
            // lblDescripcionMateria
            // 
            this.lblDescripcionMateria.AutoSize = true;
            this.lblDescripcionMateria.Location = new System.Drawing.Point(20, 65);
            this.lblDescripcionMateria.Name = "lblDescripcionMateria";
            this.lblDescripcionMateria.Size = new System.Drawing.Size(110, 13);
            this.lblDescripcionMateria.TabIndex = 13;
            this.lblDescripcionMateria.Text = "Descripción de Materia";
            // 
            // lblNombrePractica
            // 
            this.lblNombrePractica.AutoSize = true;
            this.lblNombrePractica.Location = new System.Drawing.Point(20, 5);
            this.lblNombrePractica.Name = "lblNombrePractica";
            this.lblNombrePractica.Size = new System.Drawing.Size(94, 13);
            this.lblNombrePractica.TabIndex = 14;
            this.lblNombrePractica.Text = "Nombre de Práctica";
            // 
            // lblFechaPractica
            // 
            this.lblFechaPractica.AutoSize = true;
            this.lblFechaPractica.Location = new System.Drawing.Point(20, 35);
            this.lblFechaPractica.Name = "lblFechaPractica";
            this.lblFechaPractica.Size = new System.Drawing.Size(81, 13);
            this.lblFechaPractica.TabIndex = 15;
            this.lblFechaPractica.Text = "Fecha de Práctica";
            // 
            // lblObjetivoPractica
            // 
            this.lblObjetivoPractica.AutoSize = true;
            this.lblObjetivoPractica.Location = new System.Drawing.Point(20, 65);
            this.lblObjetivoPractica.Name = "lblObjetivoPractica";
            this.lblObjetivoPractica.Size = new System.Drawing.Size(97, 13);
            this.lblObjetivoPractica.TabIndex = 16;
            this.lblObjetivoPractica.Text = "Objetivo de Práctica";
            // 
            // lblProcedimientosPractica
            // 
            this.lblProcedimientosPractica.AutoSize = true;
            this.lblProcedimientosPractica.Location = new System.Drawing.Point(20, 95);
            this.lblProcedimientosPractica.Name = "lblProcedimientosPractica";
            this.lblProcedimientosPractica.Size = new System.Drawing.Size(79, 13);
            this.lblProcedimientosPractica.TabIndex = 17;
            this.lblProcedimientosPractica.Text = "Procedimientos";
            // 
            // lblMaterialesPractica
            // 
            this.lblMaterialesPractica.AutoSize = true;
            this.lblMaterialesPractica.Location = new System.Drawing.Point(20, 125);
            this.lblMaterialesPractica.Name = "lblMaterialesPractica";
            this.lblMaterialesPractica.Size = new System.Drawing.Size(96, 13);
            this.lblMaterialesPractica.TabIndex = 18;
            this.lblMaterialesPractica.Text = "Materiales Necesarios";
            // 
            // lblMateriaPractica
            // 
            this.lblMateriaPractica.AutoSize = true;
            this.lblMateriaPractica.Location = new System.Drawing.Point(20, 155);
            this.lblMateriaPractica.Name = "lblMateriaPractica";
            this.lblMateriaPractica.Size = new System.Drawing.Size(41, 13);
            this.lblMateriaPractica.TabIndex = 19;
            this.lblMateriaPractica.Text = "Materia";
            // 
            // Other Controls Initialization
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(20, 20);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.PlaceholderText = "Nombre de la Materia";
            this.txtNombreMateria.Size = new System.Drawing.Size(200, 20);
            this.txtNombreMateria.TabIndex = 0;
            // 
            // txtCodigoMateria
            // 
            this.txtCodigoMateria.Location = new System.Drawing.Point(20, 50);
            this.txtCodigoMateria.Name = "txtCodigoMateria";
            this.txtCodigoMateria.PlaceholderText = "Código de la Materia";
            this.txtCodigoMateria.Size = new System.Drawing.Size(200, 20);
            this.txtCodigoMateria.TabIndex = 1;
            // 
            // txtDescripcionMateria
            // 
            this.txtDescripcionMateria.Location = new System.Drawing.Point(20, 80);
            this.txtDescripcionMateria.Name = "txtDescripcionMateria";
            this.txtDescripcionMateria.PlaceholderText = "Descripción de la Materia";
            this.txtDescripcionMateria.Size = new System.Drawing.Size(200, 20);
            this.txtDescripcionMateria.TabIndex = 2;
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
            // txtNombrePractica
            // 
            this.txtNombrePractica.Location = new System.Drawing.Point(20, 20);
            this.txtNombrePractica.Name = "txtNombrePractica";
            this.txtNombrePractica.PlaceholderText = "Nombre de la Práctica";
            this.txtNombrePractica.Size = new System.Drawing.Size(200, 20);
            this.txtNombrePractica.TabIndex = 4;
            // 
            // txtFechaPractica
            // 
            this.txtFechaPractica.Location = new System.Drawing.Point(20, 50);
            this.txtFechaPractica.Name = "txtFechaPractica";
            this.txtFechaPractica.PlaceholderText = "Fecha de la Práctica";
            this.txtFechaPractica.Size = new System.Drawing.Size(200, 20);
            this.txtFechaPractica.TabIndex = 5;
            // 
            // txtObjetivoPractica
            // 
            this.txtObjetivoPractica.Location = new System.Drawing.Point(20, 80);
            this.txtObjetivoPractica.Name = "txtObjetivoPractica";
            this.txtObjetivoPractica.PlaceholderText = "Objetivo de la Práctica";
            this.txtObjetivoPractica.Size = new System.Drawing.Size(200, 20);
            this.txtObjetivoPractica.TabIndex = 6;
            // 
            // txtProcedimientosPractica
            // 
            this.txtProcedimientosPractica.Location = new System.Drawing.Point(20, 110);
            this.txtProcedimientosPractica.Name = "txtProcedimientosPractica";
            this.txtProcedimientosPractica.PlaceholderText = "Procedimientos";
            this.txtProcedimientosPractica.Size = new System.Drawing.Size(200, 20);
            this.txtProcedimientosPractica.TabIndex = 7;
            // 
            // txtMaterialesPractica
            // 
            this.txtMaterialesPractica.Location = new System.Drawing.Point(20, 140);
            this.txtMaterialesPractica.Name = "txtMaterialesPractica";
            this.txtMaterialesPractica.PlaceholderText = "Materiales Necesarios";
            this.txtMaterialesPractica.Size = new System.Drawing.Size(200, 20);
            this.txtMaterialesPractica.TabIndex = 8;
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMaterias);
            this.tabControl.Controls.Add(this.tabPracticas);
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
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(245, 6);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.Size = new System.Drawing.Size(500, 300);
            this.dgvMaterias.TabIndex = 0;
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
            this.tabPracticas.Controls.Add(this.txtNombrePractica);
            this.tabPracticas.Controls.Add(this.txtFechaPractica);
            this.tabPracticas.Controls.Add(this.txtObjetivoPractica);
            this.tabPracticas.Controls.Add(this.txtProcedimientosPractica);
            this.tabPracticas.Controls.Add(this.txtMaterialesPractica);
            this.tabPracticas.Controls.Add(this.cmbMateriaPractica);
            this.tabPracticas.Controls.Add(this.btnAgregarPractica);
            this.tabPracticas.Location = new System.Drawing.Point(4, 22);
            this.tabPracticas.Name = "tabPracticas";
            this.tabPracticas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPracticas.Size = new System.Drawing.Size(768, 400);
            this.tabPracticas.TabIndex = 1;
            this.tabPracticas.Text = "Prácticas";
            this.tabPracticas.UseVisualStyleBackColor = true;
            // 
            // dgvPracticas
            // 
            this.dgvPracticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracticas.Location = new System.Drawing.Point(245, 6);
            this.dgvPracticas.Name = "dgvPracticas";
            this.dgvPracticas.Size = new System.Drawing.Size(500, 300);
            this.dgvPracticas.TabIndex = 0;
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
            this.ResumeLayout(false);
        }


        private DataGridView dgvMaterias;
    }
}
