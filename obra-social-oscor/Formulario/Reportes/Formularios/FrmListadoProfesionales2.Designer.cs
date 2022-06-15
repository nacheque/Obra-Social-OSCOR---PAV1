namespace obra_social_oscor.Formulario.Reportes.Formularios
{
    partial class FrmListadoProfesionales2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoProfesionales2));
            this.reportViewerListProf = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewerListProf
            // 
            this.reportViewerListProf.LocalReport.ReportEmbeddedResource = "obra_social_oscor.Formulario.Reportes.Informes.ReporteListadoProfesionales.rdlc";
            this.reportViewerListProf.Location = new System.Drawing.Point(0, 0);
            this.reportViewerListProf.Name = "reportViewerListProf";
            this.reportViewerListProf.ServerReport.BearerToken = null;
            this.reportViewerListProf.Size = new System.Drawing.Size(725, 384);
            this.reportViewerListProf.TabIndex = 0;
            this.reportViewerListProf.Load += new System.EventHandler(this.reportViewerListProf_Load);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(663, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(62, 48);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmListadoProfesionales2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.reportViewerListProf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadoProfesionales2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Profesionales";
            this.Load += new System.EventHandler(this.FrmListadoReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerListProf;
        private System.Windows.Forms.Button btnSalir;
    }
}