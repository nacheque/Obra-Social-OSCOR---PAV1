namespace obra_social_oscor.Formulario.Reportes.Formularios
{
    partial class FrmCantidadAtenDeProfPorCentro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantidadAtenDeProfPorCentro));
            this.report_cantidad_profxcentro = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // report_cantidad_profxcentro
            // 
            this.report_cantidad_profxcentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report_cantidad_profxcentro.LocalReport.ReportEmbeddedResource = "obra_social_oscor.Formulario.Reportes.Informes.CantidadProfPorCentro.rdlc";
            this.report_cantidad_profxcentro.Location = new System.Drawing.Point(0, 0);
            this.report_cantidad_profxcentro.Name = "report_cantidad_profxcentro";
            this.report_cantidad_profxcentro.ServerReport.BearerToken = null;
            this.report_cantidad_profxcentro.Size = new System.Drawing.Size(800, 450);
            this.report_cantidad_profxcentro.TabIndex = 0;
            this.report_cantidad_profxcentro.Load += new System.EventHandler(this.report_cantidad_profxcentro_Load);
            // 
            // FrmCantidadAtenDeProfPorCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.report_cantidad_profxcentro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCantidadAtenDeProfPorCentro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantidad De Profesionales por Centro Medico";
            this.Load += new System.EventHandler(this.FrmCantidadAtenDeProfPorCentro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report_cantidad_profxcentro;
    }
}