namespace obra_social_oscor.Formulario.Reportes.Formularios
{
    partial class FrmAtencionDiariaAfiliado
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lblAfiliado = new System.Windows.Forms.Label();
            this.btn_generarReportAfiliado = new System.Windows.Forms.Button();
            this.cmb_afiliado = new System.Windows.Forms.ComboBox();
            this.reportAtencionDiariaAfiliado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Location = new System.Drawing.Point(633, 407);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 42);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(314, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 100;
            this.lblFecha.Text = "Fecha";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(357, 13);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha.TabIndex = 99;
            // 
            // lblAfiliado
            // 
            this.lblAfiliado.AutoSize = true;
            this.lblAfiliado.Location = new System.Drawing.Point(9, 15);
            this.lblAfiliado.Name = "lblAfiliado";
            this.lblAfiliado.Size = new System.Drawing.Size(41, 13);
            this.lblAfiliado.TabIndex = 98;
            this.lblAfiliado.Text = "Afiliado";
            // 
            // btn_generarReportAfiliado
            // 
            this.btn_generarReportAfiliado.Location = new System.Drawing.Point(583, 10);
            this.btn_generarReportAfiliado.Name = "btn_generarReportAfiliado";
            this.btn_generarReportAfiliado.Size = new System.Drawing.Size(98, 23);
            this.btn_generarReportAfiliado.TabIndex = 97;
            this.btn_generarReportAfiliado.Text = "Generar Reporte";
            this.btn_generarReportAfiliado.UseVisualStyleBackColor = true;
            this.btn_generarReportAfiliado.Click += new System.EventHandler(this.btn_generarReportAfiliado_Click);
            // 
            // cmb_afiliado
            // 
            this.cmb_afiliado.FormattingEnabled = true;
            this.cmb_afiliado.Location = new System.Drawing.Point(56, 12);
            this.cmb_afiliado.Name = "cmb_afiliado";
            this.cmb_afiliado.Size = new System.Drawing.Size(213, 21);
            this.cmb_afiliado.TabIndex = 96;
            // 
            // reportAtencionDiariaAfiliado
            // 
            this.reportAtencionDiariaAfiliado.Location = new System.Drawing.Point(3, 63);
            this.reportAtencionDiariaAfiliado.Name = "reportAtencionDiariaAfiliado";
            this.reportAtencionDiariaAfiliado.ServerReport.BearerToken = null;
            this.reportAtencionDiariaAfiliado.Size = new System.Drawing.Size(687, 329);
            this.reportAtencionDiariaAfiliado.TabIndex = 101;
            // 
            // FrmAtencionDiariaAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 461);
            this.Controls.Add(this.reportAtencionDiariaAfiliado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.lblAfiliado);
            this.Controls.Add(this.btn_generarReportAfiliado);
            this.Controls.Add(this.cmb_afiliado);
            this.Controls.Add(this.btn_Salir);
            this.Name = "FrmAtencionDiariaAfiliado";
            this.Text = "FrmAtencionDiariaAfiliado";
            this.Load += new System.EventHandler(this.FrmAtencionDiariaAfiliado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label lblAfiliado;
        private System.Windows.Forms.Button btn_generarReportAfiliado;
        private System.Windows.Forms.ComboBox cmb_afiliado;
        private Microsoft.Reporting.WinForms.ReportViewer reportAtencionDiariaAfiliado;
    }
}