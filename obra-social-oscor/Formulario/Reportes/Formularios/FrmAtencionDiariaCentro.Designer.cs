namespace obra_social_oscor.Formulario.Reportes.Formularios
{
    partial class FrmAtencionDiariaCentro
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_centro = new System.Windows.Forms.ComboBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btn_generar_reporte = new System.Windows.Forms.Button();
            this.reportAtencionDiariaCentro = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Location = new System.Drawing.Point(650, 407);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 42);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Centro Medico";
            // 
            // cmb_centro
            // 
            this.cmb_centro.FormattingEnabled = true;
            this.cmb_centro.Location = new System.Drawing.Point(88, 12);
            this.cmb_centro.Name = "cmb_centro";
            this.cmb_centro.Size = new System.Drawing.Size(190, 21);
            this.cmb_centro.TabIndex = 7;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(362, 13);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha.TabIndex = 95;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(319, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 96;
            this.lblFecha.Text = "Fecha";
            // 
            // btn_generar_reporte
            // 
            this.btn_generar_reporte.Location = new System.Drawing.Point(578, 10);
            this.btn_generar_reporte.Name = "btn_generar_reporte";
            this.btn_generar_reporte.Size = new System.Drawing.Size(119, 23);
            this.btn_generar_reporte.TabIndex = 98;
            this.btn_generar_reporte.Text = "Generar Reporte";
            this.btn_generar_reporte.UseVisualStyleBackColor = true;
            this.btn_generar_reporte.Click += new System.EventHandler(this.btn_generar_reporte_Click);
            // 
            // reportAtencionDiariaCentro
            // 
            this.reportAtencionDiariaCentro.LocalReport.ReportEmbeddedResource = "obra_social_oscor.Formulario.Reportes.Informes.ReporteAtencionDiariaCentro.rdlc";
            this.reportAtencionDiariaCentro.Location = new System.Drawing.Point(2, 52);
            this.reportAtencionDiariaCentro.Name = "reportAtencionDiariaCentro";
            this.reportAtencionDiariaCentro.ServerReport.BearerToken = null;
            this.reportAtencionDiariaCentro.Size = new System.Drawing.Size(705, 334);
            this.reportAtencionDiariaCentro.TabIndex = 99;
            // 
            // FrmAtencionDiariaCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 461);
            this.Controls.Add(this.reportAtencionDiariaCentro);
            this.Controls.Add(this.btn_generar_reporte);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_centro);
            this.Controls.Add(this.btn_Salir);
            this.Name = "FrmAtencionDiariaCentro";
            this.Text = "FrmAtencionDiariaCentro";
            this.Load += new System.EventHandler(this.FrmAtencionDiariaCentro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_centro;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btn_generar_reporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportAtencionDiariaCentro;
    }
}