namespace obra_social_oscor.Formulario.Reportes.Atenciones
{
    partial class FrmHistoricoAtencionesAfiliado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistoricoAtencionesAfiliado));
            this.report_aten_historico = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.cmb_prof_reporte_aten = new System.Windows.Forms.ComboBox();
            this.cmb_afiliado_reporte_aten = new System.Windows.Forms.ComboBox();
            this.lbl_profesional_atencion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_filtros = new System.Windows.Forms.GroupBox();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.btn_generar_reporte = new System.Windows.Forms.Button();
            this.grp_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // report_aten_historico
            // 
            this.report_aten_historico.LocalReport.ReportEmbeddedResource = "obra_social_oscor.Formulario.Reportes.Informes.HistoricoAtencionesAfiliado.rdlc";
            this.report_aten_historico.Location = new System.Drawing.Point(3, 149);
            this.report_aten_historico.Name = "report_aten_historico";
            this.report_aten_historico.ServerReport.BearerToken = null;
            this.report_aten_historico.Size = new System.Drawing.Size(676, 344);
            this.report_aten_historico.TabIndex = 0;
            this.report_aten_historico.Load += new System.EventHandler(this.report_aten_historico_Load);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Location = new System.Drawing.Point(632, 512);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 42);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // cmb_prof_reporte_aten
            // 
            this.cmb_prof_reporte_aten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_prof_reporte_aten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_prof_reporte_aten.FormattingEnabled = true;
            this.cmb_prof_reporte_aten.Location = new System.Drawing.Point(103, 19);
            this.cmb_prof_reporte_aten.Name = "cmb_prof_reporte_aten";
            this.cmb_prof_reporte_aten.Size = new System.Drawing.Size(222, 24);
            this.cmb_prof_reporte_aten.TabIndex = 88;
            // 
            // cmb_afiliado_reporte_aten
            // 
            this.cmb_afiliado_reporte_aten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_afiliado_reporte_aten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_afiliado_reporte_aten.FormattingEnabled = true;
            this.cmb_afiliado_reporte_aten.Location = new System.Drawing.Point(103, 62);
            this.cmb_afiliado_reporte_aten.Name = "cmb_afiliado_reporte_aten";
            this.cmb_afiliado_reporte_aten.Size = new System.Drawing.Size(222, 24);
            this.cmb_afiliado_reporte_aten.TabIndex = 89;
            // 
            // lbl_profesional_atencion
            // 
            this.lbl_profesional_atencion.AutoSize = true;
            this.lbl_profesional_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesional_atencion.Location = new System.Drawing.Point(9, 22);
            this.lbl_profesional_atencion.Name = "lbl_profesional_atencion";
            this.lbl_profesional_atencion.Size = new System.Drawing.Size(83, 17);
            this.lbl_profesional_atencion.TabIndex = 91;
            this.lbl_profesional_atencion.Text = "Profesional:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 92;
            this.label1.Text = "Afiliado:";
            // 
            // grp_filtros
            // 
            this.grp_filtros.Controls.Add(this.btn_generar_reporte);
            this.grp_filtros.Controls.Add(this.dtp_hasta);
            this.grp_filtros.Controls.Add(this.label3);
            this.grp_filtros.Controls.Add(this.label2);
            this.grp_filtros.Controls.Add(this.dtp_desde);
            this.grp_filtros.Controls.Add(this.cmb_prof_reporte_aten);
            this.grp_filtros.Controls.Add(this.label1);
            this.grp_filtros.Controls.Add(this.cmb_afiliado_reporte_aten);
            this.grp_filtros.Controls.Add(this.lbl_profesional_atencion);
            this.grp_filtros.Location = new System.Drawing.Point(3, 12);
            this.grp_filtros.Name = "grp_filtros";
            this.grp_filtros.Size = new System.Drawing.Size(676, 131);
            this.grp_filtros.TabIndex = 93;
            this.grp_filtros.TabStop = false;
            this.grp_filtros.Text = "Filtros";
            // 
            // dtp_desde
            // 
            this.dtp_desde.Location = new System.Drawing.Point(455, 23);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(200, 20);
            this.dtp_desde.TabIndex = 93;
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
            // dtp_hasta
            // 
            this.dtp_hasta.Location = new System.Drawing.Point(455, 65);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_hasta.TabIndex = 96;
            // 
            // btn_generar_reporte
            // 
            this.btn_generar_reporte.Location = new System.Drawing.Point(536, 102);
            this.btn_generar_reporte.Name = "btn_generar_reporte";
            this.btn_generar_reporte.Size = new System.Drawing.Size(119, 23);
            this.btn_generar_reporte.TabIndex = 97;
            this.btn_generar_reporte.Text = "Generar Reporte";
            this.btn_generar_reporte.UseVisualStyleBackColor = true;
            this.btn_generar_reporte.Click += new System.EventHandler(this.btn_generar_reporte_Click);
            // 
            // FrmHistoricoAtencionesAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 561);
            this.Controls.Add(this.grp_filtros);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.report_aten_historico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHistoricoAtencionesAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reportes de Atenciones";
            this.Load += new System.EventHandler(this.FrmHistoricoAtencionesAfiliado_Load);
            this.grp_filtros.ResumeLayout(false);
            this.grp_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report_aten_historico;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.ComboBox cmb_prof_reporte_aten;
        private System.Windows.Forms.ComboBox cmb_afiliado_reporte_aten;
        private System.Windows.Forms.Label lbl_profesional_atencion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_filtros;
        private System.Windows.Forms.Button btn_generar_reporte;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_desde;
    }
}