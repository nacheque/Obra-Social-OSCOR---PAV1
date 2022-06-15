namespace obra_social_oscor.Formulario.Reportes.Formularios
{
    partial class FrmListadoProfesionales
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
            this.reportViewerListProf = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewerListProf
            // 
            this.reportViewerListProf.LocalReport.ReportEmbeddedResource = "obra_social_oscor.Formulario.Reportes.Informes.ReporteListadoProfesionales.rdlc";
            this.reportViewerListProf.Location = new System.Drawing.Point(44, 0);
            this.reportViewerListProf.Name = "reportViewerListProf";
            this.reportViewerListProf.ServerReport.BearerToken = null;
            this.reportViewerListProf.Size = new System.Drawing.Size(483, 442);
            this.reportViewerListProf.TabIndex = 0;
            this.reportViewerListProf.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(465, 448);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(62, 49);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmListadoProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 509);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.reportViewerListProf);
            this.Name = "FrmListadoProfesionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Profesionales";
            this.Load += new System.EventHandler(this.FrmListadoProfesionales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerListProf;
        private System.Windows.Forms.Button btnSalir;
    }
}