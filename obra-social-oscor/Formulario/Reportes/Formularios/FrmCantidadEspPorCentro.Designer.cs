namespace obra_social_oscor.Formulario.Reportes.Formularios
{
    partial class FrmCantidadEspPorCentro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantidadEspPorCentro));
            this.report_cant_esp_por_centro = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // report_cant_esp_por_centro
            // 
            this.report_cant_esp_por_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report_cant_esp_por_centro.LocalReport.ReportEmbeddedResource = "obra_social_oscor.Formulario.Reportes.Informes.CantidadEspPorCentro.rdlc";
            this.report_cant_esp_por_centro.Location = new System.Drawing.Point(0, 0);
            this.report_cant_esp_por_centro.Name = "report_cant_esp_por_centro";
            this.report_cant_esp_por_centro.ServerReport.BearerToken = null;
            this.report_cant_esp_por_centro.Size = new System.Drawing.Size(800, 450);
            this.report_cant_esp_por_centro.TabIndex = 96;
            this.report_cant_esp_por_centro.Load += new System.EventHandler(this.report_cant_esp_por_centro_Load);
            // 
            // FrmCantidadEspPorCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.report_cant_esp_por_centro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCantidadEspPorCentro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantidad de Especialidades por Centro";
            this.Load += new System.EventHandler(this.FrmCantidadEspPorCentro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report_cant_esp_por_centro;
    }
}