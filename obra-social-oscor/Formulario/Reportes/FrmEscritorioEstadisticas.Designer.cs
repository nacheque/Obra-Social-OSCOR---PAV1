namespace obra_social_oscor.Formulario.Reportes
{
    partial class FrmEscritorioEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEscritorioEstadisticas));
            this.btn_Salir_estadisticas = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atencionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeAtencionesPorTipoDeAfiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porcentajeDeAtencionesPorTipoDeAfiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeEspecialidadesPorCentroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porcentajeDePracticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeProfesionaPorCentroMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Salir_estadisticas
            // 
            this.btn_Salir_estadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir_estadisticas.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btn_Salir_estadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir_estadisticas.Location = new System.Drawing.Point(584, 182);
            this.btn_Salir_estadisticas.Name = "btn_Salir_estadisticas";
            this.btn_Salir_estadisticas.Size = new System.Drawing.Size(69, 65);
            this.btn_Salir_estadisticas.TabIndex = 6;
            this.btn_Salir_estadisticas.UseVisualStyleBackColor = true;
            this.btn_Salir_estadisticas.Click += new System.EventHandler(this.btn_Salir_estadisticas_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atencionesToolStripMenuItem,
            this.especialidadesToolStripMenuItem,
            this.practicasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atencionesToolStripMenuItem
            // 
            this.atencionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadDeAtencionesPorTipoDeAfiliadoToolStripMenuItem,
            this.porcentajeDeAtencionesPorTipoDeAfiliadoToolStripMenuItem,
            this.cantidadDeProfesionaPorCentroMedicoToolStripMenuItem});
            this.atencionesToolStripMenuItem.Name = "atencionesToolStripMenuItem";
            this.atencionesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.atencionesToolStripMenuItem.Text = "Atenciones";
            // 
            // cantidadDeAtencionesPorTipoDeAfiliadoToolStripMenuItem
            // 
            this.cantidadDeAtencionesPorTipoDeAfiliadoToolStripMenuItem.Name = "cantidadDeAtencionesPorTipoDeAfiliadoToolStripMenuItem";
            this.cantidadDeAtencionesPorTipoDeAfiliadoToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.cantidadDeAtencionesPorTipoDeAfiliadoToolStripMenuItem.Text = "Cantidad de atenciones por tipo de afiliado";
            this.cantidadDeAtencionesPorTipoDeAfiliadoToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeAtencionesPorTipoDeAfiliadoToolStripMenuItem_Click);
            // 
            // porcentajeDeAtencionesPorTipoDeAfiliadoToolStripMenuItem
            // 
            this.porcentajeDeAtencionesPorTipoDeAfiliadoToolStripMenuItem.Name = "porcentajeDeAtencionesPorTipoDeAfiliadoToolStripMenuItem";
            this.porcentajeDeAtencionesPorTipoDeAfiliadoToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.porcentajeDeAtencionesPorTipoDeAfiliadoToolStripMenuItem.Text = "Porcentaje de atenciones por tipo de afiliado";
            this.porcentajeDeAtencionesPorTipoDeAfiliadoToolStripMenuItem.Click += new System.EventHandler(this.porcentajeDeAtencionesPorTipoDeAfiliadoToolStripMenuItem_Click);
            // 
            // especialidadesToolStripMenuItem
            // 
            this.especialidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadDeEspecialidadesPorCentroToolStripMenuItem});
            this.especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            this.especialidadesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.especialidadesToolStripMenuItem.Text = "Especialidades";
            // 
            // cantidadDeEspecialidadesPorCentroToolStripMenuItem
            // 
            this.cantidadDeEspecialidadesPorCentroToolStripMenuItem.Name = "cantidadDeEspecialidadesPorCentroToolStripMenuItem";
            this.cantidadDeEspecialidadesPorCentroToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.cantidadDeEspecialidadesPorCentroToolStripMenuItem.Text = "Cantidad de Especialidades por Centro";
            this.cantidadDeEspecialidadesPorCentroToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeEspecialidadesPorCentroToolStripMenuItem_Click);
            // 
            // practicasToolStripMenuItem
            // 
            this.practicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porcentajeDePracticasToolStripMenuItem});
            this.practicasToolStripMenuItem.Name = "practicasToolStripMenuItem";
            this.practicasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.practicasToolStripMenuItem.Text = "Practicas";
            // 
            // porcentajeDePracticasToolStripMenuItem
            // 
            this.porcentajeDePracticasToolStripMenuItem.Name = "porcentajeDePracticasToolStripMenuItem";
            this.porcentajeDePracticasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.porcentajeDePracticasToolStripMenuItem.Text = "Porcentaje de Practicas";
            this.porcentajeDePracticasToolStripMenuItem.Click += new System.EventHandler(this.porcentajeDePracticasToolStripMenuItem_Click);
            // 
            // cantidadDeProfesionaPorCentroMedicoToolStripMenuItem
            // 
            this.cantidadDeProfesionaPorCentroMedicoToolStripMenuItem.Name = "cantidadDeProfesionaPorCentroMedicoToolStripMenuItem";
            this.cantidadDeProfesionaPorCentroMedicoToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.cantidadDeProfesionaPorCentroMedicoToolStripMenuItem.Text = "Cantidad de Profesional por Centro Medico";
            this.cantidadDeProfesionaPorCentroMedicoToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeProfesionaPorCentroMedicoToolStripMenuItem_Click);
            // 
            // FrmEscritorioEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::obra_social_oscor.Properties.Resources.fondo_escritorio_estadisticas;
            this.ClientSize = new System.Drawing.Size(665, 259);
            this.Controls.Add(this.btn_Salir_estadisticas);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmEscritorioEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir_estadisticas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atencionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeAtencionesPorTipoDeAfiliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porcentajeDeAtencionesPorTipoDeAfiliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeEspecialidadesPorCentroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porcentajeDePracticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeProfesionaPorCentroMedicoToolStripMenuItem;
    }
}