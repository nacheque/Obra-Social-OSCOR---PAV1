namespace obra_social_oscor.Formulario.Reportes.Formularios
{
    partial class FrmListadoAfiliados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoAfiliados));
            this.reportViewerListadoAfiliados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewerListadoAfiliados
            // 
            this.reportViewerListadoAfiliados.LocalReport.ReportEmbeddedResource = "obra_social_oscor.Formulario.Reportes.Informes.ReporteListadoAfiliados.rdlc";
            this.reportViewerListadoAfiliados.Location = new System.Drawing.Point(5, 1);
            this.reportViewerListadoAfiliados.Name = "reportViewerListadoAfiliados";
            this.reportViewerListadoAfiliados.ServerReport.BearerToken = null;
            this.reportViewerListadoAfiliados.Size = new System.Drawing.Size(746, 379);
            this.reportViewerListadoAfiliados.TabIndex = 0;
            this.reportViewerListadoAfiliados.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(574, 386);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(57, 52);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmListadoAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.reportViewerListadoAfiliados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadoAfiliados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Afiliados";
            this.Load += new System.EventHandler(this.FrmListadoAfiliados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerListadoAfiliados;
        private System.Windows.Forms.Button btnSalir;
    }
}