namespace GestionarPracticasLSC
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

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
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.dgvPracticas = new System.Windows.Forms.DataGridView();
            this.btnEntregarPractica = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(9, 10);
            this.cmbMaterias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(720, 21);
            this.cmbMaterias.TabIndex = 0;
            this.cmbMaterias.SelectedIndexChanged += new System.EventHandler(this.cmbMaterias_SelectedIndexChanged);
            // 
            // dgvPracticas
            // 
            this.dgvPracticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracticas.Location = new System.Drawing.Point(9, 34);
            this.dgvPracticas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPracticas.Name = "dgvPracticas";
            this.dgvPracticas.RowTemplate.Height = 24;
            this.dgvPracticas.Size = new System.Drawing.Size(720, 322);
            this.dgvPracticas.TabIndex = 1;
            // 
            // btnEntregarPractica
            // 
            this.btnEntregarPractica.Location = new System.Drawing.Point(9, 361);
            this.btnEntregarPractica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntregarPractica.Name = "btnEntregarPractica";
            this.btnEntregarPractica.Size = new System.Drawing.Size(356, 24);
            this.btnEntregarPractica.TabIndex = 2;
            this.btnEntregarPractica.Text = "Entregar Práctica";
            this.btnEntregarPractica.UseVisualStyleBackColor = true;
            this.btnEntregarPractica.Click += new System.EventHandler(this.btnEntregarPractica_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(370, 362);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(353, 23);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 395);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEntregarPractica);
            this.Controls.Add(this.dgvPracticas);
            this.Controls.Add(this.cmbMaterias);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticas)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.DataGridView dgvPracticas;
        private System.Windows.Forms.Button btnEntregarPractica;
        private System.Windows.Forms.Button btnRegresar;
    }
}
