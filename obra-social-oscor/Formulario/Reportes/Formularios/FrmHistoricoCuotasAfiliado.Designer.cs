namespace obra_social_oscor.Formulario.Reportes.Formularios
{
    partial class FrmHistoricoCuotasAfiliado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistoricoCuotasAfiliado));
            this.grp_filtros = new System.Windows.Forms.GroupBox();
            this.btn_generar_reporte_cuota_afi = new System.Windows.Forms.Button();
            this.dtp_hasta_report = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_desde_report = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_afi_hist_cuota = new System.Windows.Forms.ComboBox();
            this.report_cuota_historico = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Salir_reporte = new System.Windows.Forms.Button();
            this.grp_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_filtros
            // 
            this.grp_filtros.Controls.Add(this.btn_generar_reporte_cuota_afi);
            this.grp_filtros.Controls.Add(this.dtp_hasta_report);
            this.grp_filtros.Controls.Add(this.label3);
            this.grp_filtros.Controls.Add(this.label2);
            this.grp_filtros.Controls.Add(this.dtp_desde_report);
            this.grp_filtros.Controls.Add(this.label1);
            this.grp_filtros.Controls.Add(this.cmb_afi_hist_cuota);
            this.grp_filtros.Location = new System.Drawing.Point(12, 12);
            this.grp_filtros.Name = "grp_filtros";
            this.grp_filtros.Size = new System.Drawing.Size(676, 131);
            this.grp_filtros.TabIndex = 94;
            this.grp_filtros.TabStop = false;
            this.grp_filtros.Text = "Filtros";
            // 
            // btn_generar_reporte_cuota_afi
            // 
            this.btn_generar_reporte_cuota_afi.Location = new System.Drawing.Point(536, 102);
            this.btn_generar_reporte_cuota_afi.Name = "btn_generar_reporte_cuota_afi";
            this.btn_generar_reporte_cuota_afi.Size = new System.Drawing.Size(119, 23);
            this.btn_generar_reporte_cuota_afi.TabIndex = 97;
            this.btn_generar_reporte_cuota_afi.Text = "Generar Reporte";
            this.btn_generar_reporte_cuota_afi.UseVisualStyleBackColor = true;
            this.btn_generar_reporte_cuota_afi.Click += new System.EventHandler(this.btn_generar_reporte_cuota_afi_Click);
            // 
            // dtp_hasta_report
            // 
            this.dtp_hasta_report.Location = new System.Drawing.Point(455, 65);
            this.dtp_hasta_report.Name = "dtp_hasta_report";
            this.dtp_hasta_report.Size = new System.Drawing.Size(200, 20);
            this.dtp_hasta_report.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 95;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "Desde:";
            // 
            // dtp_desde_report
            // 
            this.dtp_desde_report.Location = new System.Drawing.Point(455, 23);
            this.dtp_desde_report.Name = "dtp_desde_report";
            this.dtp_desde_report.Size = new System.Drawing.Size(200, 20);
            this.dtp_desde_report.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 92;
            this.label1.Text = "Afiliado:";
            // 
            // cmb_afi_hist_cuota
            // 
            this.cmb_afi_hist_cuota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_afi_hist_cuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_afi_hist_cuota.FormattingEnabled = true;
            this.cmb_afi_hist_cuota.Location = new System.Drawing.Point(109, 23);
            this.cmb_afi_hist_cuota.Name = "cmb_afi_hist_cuota";
            this.cmb_afi_hist_cuota.Size = new System.Drawing.Size(222, 24);
            this.cmb_afi_hist_cuota.TabIndex = 89;
            // 
            // report_cuota_historico
            // 
            this.report_cuota_historico.LocalReport.ReportEmbeddedResource = "obra_social_oscor.Formulario.Reportes.Informes.HistoricoCuotasAfiliado.rdlc";
            this.report_cuota_historico.Location = new System.Drawing.Point(11, 149);
            this.report_cuota_historico.Name = "report_cuota_historico";
            this.report_cuota_historico.ServerReport.BearerToken = null;
            this.report_cuota_historico.Size = new System.Drawing.Size(676, 344);
            this.report_cuota_historico.TabIndex = 95;
            // 
            // btn_Salir_reporte
            // 
            this.btn_Salir_reporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir_reporte.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btn_Salir_reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir_reporte.Location = new System.Drawing.Point(640, 499);
            this.btn_Salir_reporte.Name = "btn_Salir_reporte";
            this.btn_Salir_reporte.Size = new System.Drawing.Size(47, 42);
            this.btn_Salir_reporte.TabIndex = 96;
            this.btn_Salir_reporte.UseVisualStyleBackColor = true;
            this.btn_Salir_reporte.Click += new System.EventHandler(this.btn_Salir_reporte_Click);
            // 
            // FrmHistoricoCuotasAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 548);
            this.Controls.Add(this.btn_Salir_reporte);
            this.Controls.Add(this.report_cuota_historico);
            this.Controls.Add(this.grp_filtros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHistoricoCuotasAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Cuotas Pagas";
            this.Load += new System.EventHandler(this.FrmHistoricoCuotasAfiliado_Load);
            this.grp_filtros.ResumeLayout(false);
            this.grp_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_filtros;
        private System.Windows.Forms.Button btn_generar_reporte_cuota_afi;
        private System.Windows.Forms.DateTimePicker dtp_hasta_report;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_desde_report;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_afi_hist_cuota;
        private Microsoft.Reporting.WinForms.ReportViewer report_cuota_historico;
        private System.Windows.Forms.Button btn_Salir_reporte;
    }
}