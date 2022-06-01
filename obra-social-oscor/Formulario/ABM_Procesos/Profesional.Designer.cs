namespace obra_social_oscor.Formulario.ABM
{
    partial class frm_Profesional
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Profesional));
            this.lblCentros = new System.Windows.Forms.Label();
            this.lblEspecilidad = new System.Windows.Forms.Label();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.cmbCentros = new System.Windows.Forms.ComboBox();
            this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
            this.cmbProfesionales = new System.Windows.Forms.ComboBox();
            this.btnAgregarPCE = new System.Windows.Forms.Button();
            this.btnEditarPCE = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReiniciarFormulario = new System.Windows.Forms.Button();
            this.gdrProfXCentroXEsp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CodCentro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCentro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProfesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdrProfXCentroXEsp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCentros
            // 
            this.lblCentros.AutoSize = true;
            this.lblCentros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentros.Location = new System.Drawing.Point(69, 9);
            this.lblCentros.Name = "lblCentros";
            this.lblCentros.Size = new System.Drawing.Size(61, 20);
            this.lblCentros.TabIndex = 0;
            this.lblCentros.Text = "Centro:";
            // 
            // lblEspecilidad
            // 
            this.lblEspecilidad.AutoSize = true;
            this.lblEspecilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecilidad.Location = new System.Drawing.Point(27, 54);
            this.lblEspecilidad.Name = "lblEspecilidad";
            this.lblEspecilidad.Size = new System.Drawing.Size(103, 20);
            this.lblEspecilidad.TabIndex = 1;
            this.lblEspecilidad.Text = "Especialidad:";
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesional.Location = new System.Drawing.Point(38, 102);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(92, 20);
            this.lblProfesional.TabIndex = 2;
            this.lblProfesional.Text = "Profesional:";
            // 
            // cmbCentros
            // 
            this.cmbCentros.FormattingEnabled = true;
            this.cmbCentros.Location = new System.Drawing.Point(137, 9);
            this.cmbCentros.Name = "cmbCentros";
            this.cmbCentros.Size = new System.Drawing.Size(367, 21);
            this.cmbCentros.TabIndex = 3;
            this.cmbCentros.SelectionChangeCommitted += new System.EventHandler(this.cmbCentros_SelectionChangeCommitted);
            // 
            // cmbEspecialidades
            // 
            this.cmbEspecialidades.FormattingEnabled = true;
            this.cmbEspecialidades.Location = new System.Drawing.Point(136, 53);
            this.cmbEspecialidades.Name = "cmbEspecialidades";
            this.cmbEspecialidades.Size = new System.Drawing.Size(368, 21);
            this.cmbEspecialidades.TabIndex = 4;
            this.cmbEspecialidades.SelectionChangeCommitted += new System.EventHandler(this.cmbEspecialidades_SelectionChangeCommitted);
            // 
            // cmbProfesionales
            // 
            this.cmbProfesionales.FormattingEnabled = true;
            this.cmbProfesionales.Location = new System.Drawing.Point(136, 101);
            this.cmbProfesionales.Name = "cmbProfesionales";
            this.cmbProfesionales.Size = new System.Drawing.Size(368, 21);
            this.cmbProfesionales.TabIndex = 5;
            this.cmbProfesionales.SelectionChangeCommitted += new System.EventHandler(this.cmbProfesionales_SelectionChangeCommitted_1);
            // 
            // btnAgregarPCE
            // 
            this.btnAgregarPCE.BackgroundImage = global::obra_social_oscor.Properties.Resources.agregar;
            this.btnAgregarPCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarPCE.Location = new System.Drawing.Point(12, 422);
            this.btnAgregarPCE.Name = "btnAgregarPCE";
            this.btnAgregarPCE.Size = new System.Drawing.Size(56, 49);
            this.btnAgregarPCE.TabIndex = 6;
            this.btnAgregarPCE.UseVisualStyleBackColor = true;
            this.btnAgregarPCE.Click += new System.EventHandler(this.btnAgregarPCE_Click_1);
            // 
            // btnEditarPCE
            // 
            this.btnEditarPCE.BackgroundImage = global::obra_social_oscor.Properties.Resources.Editar;
            this.btnEditarPCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarPCE.Location = new System.Drawing.Point(74, 422);
            this.btnEditarPCE.Name = "btnEditarPCE";
            this.btnEditarPCE.Size = new System.Drawing.Size(56, 49);
            this.btnEditarPCE.TabIndex = 7;
            this.btnEditarPCE.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(448, 422);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 49);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReiniciarFormulario
            // 
            this.btnReiniciarFormulario.Location = new System.Drawing.Point(136, 443);
            this.btnReiniciarFormulario.Name = "btnReiniciarFormulario";
            this.btnReiniciarFormulario.Size = new System.Drawing.Size(128, 28);
            this.btnReiniciarFormulario.TabIndex = 9;
            this.btnReiniciarFormulario.Text = "Reiniciar Formulario";
            this.btnReiniciarFormulario.UseVisualStyleBackColor = true;
            this.btnReiniciarFormulario.Click += new System.EventHandler(this.btnReiniciarFormulario_Click_1);
            // 
            // gdrProfXCentroXEsp
            // 
            this.gdrProfXCentroXEsp.AllowUserToAddRows = false;
            this.gdrProfXCentroXEsp.AllowUserToDeleteRows = false;
            this.gdrProfXCentroXEsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrProfXCentroXEsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodCentro,
            this.NombreCentro,
            this.CodEsp,
            this.NombreEsp,
            this.Matricula,
            this.NombreProfesional});
            this.gdrProfXCentroXEsp.Location = new System.Drawing.Point(53, 178);
            this.gdrProfXCentroXEsp.Name = "gdrProfXCentroXEsp";
            this.gdrProfXCentroXEsp.ReadOnly = true;
            this.gdrProfXCentroXEsp.Size = new System.Drawing.Size(451, 238);
            this.gdrProfXCentroXEsp.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Profesionales Asignados a la Especialidad del Centro";
            // 
            // CodCentro
            // 
            this.CodCentro.HeaderText = "CodigoCentro";
            this.CodCentro.Name = "CodCentro";
            this.CodCentro.ReadOnly = true;
            this.CodCentro.Visible = false;
            // 
            // NombreCentro
            // 
            this.NombreCentro.HeaderText = "NombreCentro";
            this.NombreCentro.Name = "NombreCentro";
            this.NombreCentro.ReadOnly = true;
            this.NombreCentro.Visible = false;
            // 
            // CodEsp
            // 
            this.CodEsp.HeaderText = "CodigoEspecialidad";
            this.CodEsp.Name = "CodEsp";
            this.CodEsp.ReadOnly = true;
            this.CodEsp.Visible = false;
            // 
            // NombreEsp
            // 
            this.NombreEsp.HeaderText = "NombreEsp";
            this.NombreEsp.Name = "NombreEsp";
            this.NombreEsp.ReadOnly = true;
            this.NombreEsp.Width = 200;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Visible = false;
            // 
            // NombreProfesional
            // 
            this.NombreProfesional.HeaderText = "Nombre del Profesional";
            this.NombreProfesional.Name = "NombreProfesional";
            this.NombreProfesional.ReadOnly = true;
            this.NombreProfesional.Width = 200;
            // 
            // frm_Profesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdrProfXCentroXEsp);
            this.Controls.Add(this.btnReiniciarFormulario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditarPCE);
            this.Controls.Add(this.btnAgregarPCE);
            this.Controls.Add(this.cmbProfesionales);
            this.Controls.Add(this.cmbEspecialidades);
            this.Controls.Add(this.cmbCentros);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.lblEspecilidad);
            this.Controls.Add(this.lblCentros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Profesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesionales";
            this.Load += new System.EventHandler(this.frm_Profesional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrProfXCentroXEsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCentros;
        private System.Windows.Forms.Label lblEspecilidad;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.ComboBox cmbCentros;
        private System.Windows.Forms.ComboBox cmbEspecialidades;
        private System.Windows.Forms.ComboBox cmbProfesionales;
        private System.Windows.Forms.Button btnAgregarPCE;
        private System.Windows.Forms.Button btnEditarPCE;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReiniciarFormulario;
        private System.Windows.Forms.DataGridView gdrProfXCentroXEsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCentro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCentro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProfesional;
    }
}