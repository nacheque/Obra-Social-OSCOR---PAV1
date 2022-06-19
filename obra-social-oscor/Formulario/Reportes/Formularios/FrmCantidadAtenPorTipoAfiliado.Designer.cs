namespace obra_social_oscor.Formulario.Reportes.Formularios
{
    partial class FrmCantidadAtenPorTipoAfiliado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantidadAtenPorTipoAfiliado));
            this.grp_filtros = new System.Windows.Forms.GroupBox();
            this.btn_generar_estadistica = new System.Windows.Forms.Button();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.report_cant_aten_tipo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.grp_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_filtros
            // 
            this.grp_filtros.Controls.Add(this.btn_generar_estadistica);
            this.grp_filtros.Controls.Add(this.dtp_hasta);
            this.grp_filtros.Controls.Add(this.label3);
            this.grp_filtros.Controls.Add(this.label2);
            this.grp_filtros.Controls.Add(this.dtp_desde);
            this.grp_filtros.Location = new System.Drawing.Point(12, 12);
            this.grp_filtros.Name = "grp_filtros";
            this.grp_filtros.Size = new System.Drawing.Size(676, 86);
            this.grp_filtros.TabIndex = 94;
            this.grp_filtros.TabStop = false;
            this.grp_filtros.Text = "Filtros";
            // 
            // btn_generar_estadistica
            // 
            this.btn_generar_estadistica.Location = new System.Drawing.Point(478, 57);
            this.btn_generar_estadistica.Name = "btn_generar_estadistica";
            this.btn_generar_estadistica.Size = new System.Drawing.Size(119, 23);
            this.btn_generar_estadistica.TabIndex = 97;
            this.btn_generar_estadistica.Text = "Generar Estadistica";
            this.btn_generar_estadistica.UseVisualStyleBackColor = true;
            this.btn_generar_estadistica.Click += new System.EventHandler(this.btn_generar_estadistica_Click);
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Location = new System.Drawing.Point(398, 16);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_hasta.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 95;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "Desde:";
            // 
            // dtp_desde
            // 
            this.dtp_desde.Location = new System.Drawing.Point(86, 17);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(200, 20);
            this.dtp_desde.TabIndex = 93;
            // 
            // report_cant_aten_tipo
            // 
            this.report_cant_aten_tipo.LocalReport.ReportEmbeddedResource = "obra_social_oscor.Formulario.Reportes.Informes.EstadisticaCantidadAtenPorTipoAfi." +
    "rdlc";
            this.report_cant_aten_tipo.Location = new System.Drawing.Point(12, 104);
            this.report_cant_aten_tipo.Name = "report_cant_aten_tipo";
            this.report_cant_aten_tipo.ServerReport.BearerToken = null;
            this.report_cant_aten_tipo.Size = new System.Drawing.Size(676, 344);
            this.report_cant_aten_tipo.TabIndex = 95;
            this.report_cant_aten_tipo.Load += new System.EventHandler(this.report_cant_aten_tipo_Load);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Location = new System.Drawing.Point(640, 455);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 42);
            this.btn_Salir.TabIndex = 96;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // FrmCantidadAtenPorTipoAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 509);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.report_cant_aten_tipo);
            this.Controls.Add(this.grp_filtros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCantidadAtenPorTipoAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica de Atenciones por Tipo de Afiliado";
            this.Load += new System.EventHandler(this.FrmCantidadAtenPorTipoAfiliado_Load);
            this.grp_filtros.ResumeLayout(false);
            this.grp_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_filtros;
        private System.Windows.Forms.Button btn_generar_estadistica;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private Microsoft.Reporting.WinForms.ReportViewer report_cant_aten_tipo;
        private System.Windows.Forms.Button btn_Salir;
    }
}