
namespace obra_social_oscor.Formulario.Reportes.Formularios
{
    partial class FrmListadoCuotasPagas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoCuotasPagas));
            this.reporteListadoCuotas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reporteListadoCuotas
            // 
            this.reporteListadoCuotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporteListadoCuotas.LocalReport.ReportEmbeddedResource = "obra_social_oscor.Formulario.Reportes.Informes.ReporteCuotasPagas.rdlc";
            this.reporteListadoCuotas.Location = new System.Drawing.Point(0, 0);
            this.reporteListadoCuotas.Name = "reporteListadoCuotas";
            this.reporteListadoCuotas.ServerReport.BearerToken = null;
            this.reporteListadoCuotas.Size = new System.Drawing.Size(800, 450);
            this.reporteListadoCuotas.TabIndex = 0;
            this.reporteListadoCuotas.Load += new System.EventHandler(this.reporteListadoCuotas_Load);
            // 
            // FrmListadoCuotasPagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reporteListadoCuotas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadoCuotasPagas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Reportes Cuotas Pagas";
            this.Load += new System.EventHandler(this.FrmListadoCuotasPagas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporteListadoCuotas;
    }
}