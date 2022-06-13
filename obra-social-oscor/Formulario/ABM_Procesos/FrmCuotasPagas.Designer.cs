namespace obra_social_oscor.Formulario.ABM_Procesos
{
    partial class frm_Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Pagos));
            this.grp_buscar_afi_atencion = new System.Windows.Forms.GroupBox();
            this.btn_limpiar_filtros_cuota = new System.Windows.Forms.Button();
            this.lbl_nombre_afi_atencion = new System.Windows.Forms.Label();
            this.lbl_ape_afi_aten = new System.Windows.Forms.Label();
            this.txt_nombre_afi_cuota = new System.Windows.Forms.TextBox();
            this.txt_apellido_afi_cuota = new System.Windows.Forms.TextBox();
            this.cmb_resultados_cuota = new System.Windows.Forms.ComboBox();
            this.lbl_resultados_ate = new System.Windows.Forms.Label();
            this.btn_buscar_afi_cuota = new System.Windows.Forms.Button();
            this.txt_num_afi_cuota = new System.Windows.Forms.TextBox();
            this.lbl_apellido_afi_atencion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msk_nro_cuota = new System.Windows.Forms.MaskedTextBox();
            this.msk_anio_cuota = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_monto_emerg = new System.Windows.Forms.TextBox();
            this.msk_fecha_pago = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grp_datos = new System.Windows.Forms.GroupBox();
            this.grd_pagos = new System.Windows.Forms.DataGridView();
            this.btn_agregar_pago = new System.Windows.Forms.Button();
            this.btn_limpiar_pago = new System.Windows.Forms.Button();
            this.btn_salir_pagos = new System.Windows.Forms.Button();
            this.nro_afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_completo_afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_emergencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminar_pago = new System.Windows.Forms.Button();
            this.grp_buscar_afi_atencion.SuspendLayout();
            this.grp_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_pagos)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_buscar_afi_atencion
            // 
            this.grp_buscar_afi_atencion.Controls.Add(this.btn_limpiar_filtros_cuota);
            this.grp_buscar_afi_atencion.Controls.Add(this.lbl_nombre_afi_atencion);
            this.grp_buscar_afi_atencion.Controls.Add(this.lbl_ape_afi_aten);
            this.grp_buscar_afi_atencion.Controls.Add(this.txt_nombre_afi_cuota);
            this.grp_buscar_afi_atencion.Controls.Add(this.txt_apellido_afi_cuota);
            this.grp_buscar_afi_atencion.Controls.Add(this.cmb_resultados_cuota);
            this.grp_buscar_afi_atencion.Controls.Add(this.lbl_resultados_ate);
            this.grp_buscar_afi_atencion.Controls.Add(this.btn_buscar_afi_cuota);
            this.grp_buscar_afi_atencion.Controls.Add(this.txt_num_afi_cuota);
            this.grp_buscar_afi_atencion.Controls.Add(this.lbl_apellido_afi_atencion);
            this.grp_buscar_afi_atencion.Location = new System.Drawing.Point(224, 29);
            this.grp_buscar_afi_atencion.Name = "grp_buscar_afi_atencion";
            this.grp_buscar_afi_atencion.Size = new System.Drawing.Size(460, 164);
            this.grp_buscar_afi_atencion.TabIndex = 101;
            this.grp_buscar_afi_atencion.TabStop = false;
            this.grp_buscar_afi_atencion.Text = "Buscar Afiliado";
            // 
            // btn_limpiar_filtros_cuota
            // 
            this.btn_limpiar_filtros_cuota.Location = new System.Drawing.Point(337, 88);
            this.btn_limpiar_filtros_cuota.Name = "btn_limpiar_filtros_cuota";
            this.btn_limpiar_filtros_cuota.Size = new System.Drawing.Size(112, 23);
            this.btn_limpiar_filtros_cuota.TabIndex = 107;
            this.btn_limpiar_filtros_cuota.Text = "Limpiar Filtros";
            this.btn_limpiar_filtros_cuota.UseVisualStyleBackColor = true;
            this.btn_limpiar_filtros_cuota.Click += new System.EventHandler(this.btn_limpiar_filtros_cuota_Click);
            // 
            // lbl_nombre_afi_atencion
            // 
            this.lbl_nombre_afi_atencion.AutoSize = true;
            this.lbl_nombre_afi_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_afi_atencion.Location = new System.Drawing.Point(87, 91);
            this.lbl_nombre_afi_atencion.Name = "lbl_nombre_afi_atencion";
            this.lbl_nombre_afi_atencion.Size = new System.Drawing.Size(62, 17);
            this.lbl_nombre_afi_atencion.TabIndex = 106;
            this.lbl_nombre_afi_atencion.Text = "Nombre:";
            // 
            // lbl_ape_afi_aten
            // 
            this.lbl_ape_afi_aten.AutoSize = true;
            this.lbl_ape_afi_aten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ape_afi_aten.Location = new System.Drawing.Point(87, 55);
            this.lbl_ape_afi_aten.Name = "lbl_ape_afi_aten";
            this.lbl_ape_afi_aten.Size = new System.Drawing.Size(62, 17);
            this.lbl_ape_afi_aten.TabIndex = 105;
            this.lbl_ape_afi_aten.Text = "Apellido:";
            // 
            // txt_nombre_afi_cuota
            // 
            this.txt_nombre_afi_cuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_afi_cuota.Location = new System.Drawing.Point(155, 88);
            this.txt_nombre_afi_cuota.Name = "txt_nombre_afi_cuota";
            this.txt_nombre_afi_cuota.Size = new System.Drawing.Size(161, 23);
            this.txt_nombre_afi_cuota.TabIndex = 104;
            // 
            // txt_apellido_afi_cuota
            // 
            this.txt_apellido_afi_cuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_afi_cuota.Location = new System.Drawing.Point(155, 52);
            this.txt_apellido_afi_cuota.Name = "txt_apellido_afi_cuota";
            this.txt_apellido_afi_cuota.Size = new System.Drawing.Size(161, 23);
            this.txt_apellido_afi_cuota.TabIndex = 103;
            // 
            // cmb_resultados_cuota
            // 
            this.cmb_resultados_cuota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_resultados_cuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_resultados_cuota.FormattingEnabled = true;
            this.cmb_resultados_cuota.Location = new System.Drawing.Point(151, 123);
            this.cmb_resultados_cuota.Name = "cmb_resultados_cuota";
            this.cmb_resultados_cuota.Size = new System.Drawing.Size(220, 24);
            this.cmb_resultados_cuota.TabIndex = 101;
            // 
            // lbl_resultados_ate
            // 
            this.lbl_resultados_ate.AutoSize = true;
            this.lbl_resultados_ate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultados_ate.Location = new System.Drawing.Point(66, 127);
            this.lbl_resultados_ate.Name = "lbl_resultados_ate";
            this.lbl_resultados_ate.Size = new System.Drawing.Size(83, 17);
            this.lbl_resultados_ate.TabIndex = 102;
            this.lbl_resultados_ate.Text = "Resultados:";
            // 
            // btn_buscar_afi_cuota
            // 
            this.btn_buscar_afi_cuota.Location = new System.Drawing.Point(337, 19);
            this.btn_buscar_afi_cuota.Name = "btn_buscar_afi_cuota";
            this.btn_buscar_afi_cuota.Size = new System.Drawing.Size(112, 23);
            this.btn_buscar_afi_cuota.TabIndex = 100;
            this.btn_buscar_afi_cuota.Text = "Buscar";
            this.btn_buscar_afi_cuota.UseVisualStyleBackColor = true;
            this.btn_buscar_afi_cuota.Click += new System.EventHandler(this.btn_buscar_afi_cuota_Click);
            // 
            // txt_num_afi_cuota
            // 
            this.txt_num_afi_cuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_afi_cuota.Location = new System.Drawing.Point(155, 14);
            this.txt_num_afi_cuota.Name = "txt_num_afi_cuota";
            this.txt_num_afi_cuota.Size = new System.Drawing.Size(89, 23);
            this.txt_num_afi_cuota.TabIndex = 101;
            // 
            // lbl_apellido_afi_atencion
            // 
            this.lbl_apellido_afi_atencion.AutoSize = true;
            this.lbl_apellido_afi_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido_afi_atencion.Location = new System.Drawing.Point(17, 17);
            this.lbl_apellido_afi_atencion.Name = "lbl_apellido_afi_atencion";
            this.lbl_apellido_afi_atencion.Size = new System.Drawing.Size(132, 17);
            this.lbl_apellido_afi_atencion.TabIndex = 94;
            this.lbl_apellido_afi_atencion.Text = "Numero de Afiliado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 108;
            this.label1.Text = "Nro. Cuota:";
            // 
            // msk_nro_cuota
            // 
            this.msk_nro_cuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_nro_cuota.Location = new System.Drawing.Point(124, 28);
            this.msk_nro_cuota.Mask = "99";
            this.msk_nro_cuota.Name = "msk_nro_cuota";
            this.msk_nro_cuota.Size = new System.Drawing.Size(29, 23);
            this.msk_nro_cuota.TabIndex = 109;
            this.msk_nro_cuota.ValidatingType = typeof(int);
            // 
            // msk_anio_cuota
            // 
            this.msk_anio_cuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_anio_cuota.Location = new System.Drawing.Point(124, 63);
            this.msk_anio_cuota.Mask = "9999";
            this.msk_anio_cuota.Name = "msk_anio_cuota";
            this.msk_anio_cuota.Size = new System.Drawing.Size(50, 23);
            this.msk_anio_cuota.TabIndex = 111;
            this.msk_anio_cuota.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Año Cuota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 112;
            this.label3.Text = "Mto. Emerg. :";
            // 
            // txt_monto_emerg
            // 
            this.txt_monto_emerg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto_emerg.Location = new System.Drawing.Point(124, 99);
            this.txt_monto_emerg.Name = "txt_monto_emerg";
            this.txt_monto_emerg.Size = new System.Drawing.Size(74, 23);
            this.txt_monto_emerg.TabIndex = 113;
            this.txt_monto_emerg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_emerg_KeyPress);
            // 
            // msk_fecha_pago
            // 
            this.msk_fecha_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_fecha_pago.Location = new System.Drawing.Point(124, 134);
            this.msk_fecha_pago.Mask = "00/00/0000";
            this.msk_fecha_pago.Name = "msk_fecha_pago";
            this.msk_fecha_pago.Size = new System.Drawing.Size(82, 23);
            this.msk_fecha_pago.TabIndex = 115;
            this.msk_fecha_pago.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 114;
            this.label4.Text = "Fecha:";
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(124, 168);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(74, 23);
            this.txt_total.TabIndex = 117;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 116;
            this.label5.Text = "Total: ";
            // 
            // grp_datos
            // 
            this.grp_datos.Controls.Add(this.grp_buscar_afi_atencion);
            this.grp_datos.Controls.Add(this.txt_total);
            this.grp_datos.Controls.Add(this.label1);
            this.grp_datos.Controls.Add(this.label5);
            this.grp_datos.Controls.Add(this.msk_nro_cuota);
            this.grp_datos.Controls.Add(this.msk_fecha_pago);
            this.grp_datos.Controls.Add(this.label2);
            this.grp_datos.Controls.Add(this.label4);
            this.grp_datos.Controls.Add(this.msk_anio_cuota);
            this.grp_datos.Controls.Add(this.txt_monto_emerg);
            this.grp_datos.Controls.Add(this.label3);
            this.grp_datos.Location = new System.Drawing.Point(12, 12);
            this.grp_datos.Name = "grp_datos";
            this.grp_datos.Size = new System.Drawing.Size(706, 231);
            this.grp_datos.TabIndex = 118;
            this.grp_datos.TabStop = false;
            this.grp_datos.Text = "Datos Pago";
            // 
            // grd_pagos
            // 
            this.grd_pagos.AllowUserToAddRows = false;
            this.grd_pagos.AllowUserToDeleteRows = false;
            this.grd_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_pagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro_afiliado,
            this.nombre_completo_afiliado,
            this.nro_cuota,
            this.anio,
            this.fecha_pago,
            this.monto_emergencia,
            this.total});
            this.grd_pagos.Location = new System.Drawing.Point(12, 249);
            this.grd_pagos.Name = "grd_pagos";
            this.grd_pagos.ReadOnly = true;
            this.grd_pagos.Size = new System.Drawing.Size(705, 186);
            this.grd_pagos.TabIndex = 119;
            this.grd_pagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_pagos_CellClick);
            // 
            // btn_agregar_pago
            // 
            this.btn_agregar_pago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregar_pago.BackgroundImage")));
            this.btn_agregar_pago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar_pago.Location = new System.Drawing.Point(12, 447);
            this.btn_agregar_pago.Name = "btn_agregar_pago";
            this.btn_agregar_pago.Size = new System.Drawing.Size(50, 50);
            this.btn_agregar_pago.TabIndex = 120;
            this.btn_agregar_pago.UseVisualStyleBackColor = true;
            this.btn_agregar_pago.Click += new System.EventHandler(this.btn_agregar_pago_Click);
            // 
            // btn_limpiar_pago
            // 
            this.btn_limpiar_pago.Location = new System.Drawing.Point(145, 474);
            this.btn_limpiar_pago.Name = "btn_limpiar_pago";
            this.btn_limpiar_pago.Size = new System.Drawing.Size(112, 23);
            this.btn_limpiar_pago.TabIndex = 121;
            this.btn_limpiar_pago.Text = "Reiniciar Formulario";
            this.btn_limpiar_pago.UseVisualStyleBackColor = true;
            this.btn_limpiar_pago.Click += new System.EventHandler(this.btn_limpiar_pago_Click);
            // 
            // btn_salir_pagos
            // 
            this.btn_salir_pagos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir_pagos.BackgroundImage")));
            this.btn_salir_pagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir_pagos.Location = new System.Drawing.Point(661, 447);
            this.btn_salir_pagos.Name = "btn_salir_pagos";
            this.btn_salir_pagos.Size = new System.Drawing.Size(50, 50);
            this.btn_salir_pagos.TabIndex = 122;
            this.btn_salir_pagos.UseVisualStyleBackColor = true;
            this.btn_salir_pagos.Click += new System.EventHandler(this.btn_salir_pagos_Click);
            // 
            // nro_afiliado
            // 
            this.nro_afiliado.HeaderText = "NumeroAfiliado";
            this.nro_afiliado.Name = "nro_afiliado";
            this.nro_afiliado.ReadOnly = true;
            this.nro_afiliado.Visible = false;
            // 
            // nombre_completo_afiliado
            // 
            this.nombre_completo_afiliado.HeaderText = "Afiliado";
            this.nombre_completo_afiliado.Name = "nombre_completo_afiliado";
            this.nombre_completo_afiliado.ReadOnly = true;
            this.nombre_completo_afiliado.Width = 150;
            // 
            // nro_cuota
            // 
            this.nro_cuota.HeaderText = "Cuota";
            this.nro_cuota.Name = "nro_cuota";
            this.nro_cuota.ReadOnly = true;
            this.nro_cuota.Width = 50;
            // 
            // anio
            // 
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            // 
            // fecha_pago
            // 
            this.fecha_pago.HeaderText = "Fecha Pago";
            this.fecha_pago.Name = "fecha_pago";
            this.fecha_pago.ReadOnly = true;
            this.fecha_pago.Width = 150;
            // 
            // monto_emergencia
            // 
            this.monto_emergencia.HeaderText = "Monto Emergencia";
            this.monto_emergencia.Name = "monto_emergencia";
            this.monto_emergencia.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total Pago";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // btn_eliminar_pago
            // 
            this.btn_eliminar_pago.BackgroundImage = global::obra_social_oscor.Properties.Resources.eliminar;
            this.btn_eliminar_pago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_pago.Location = new System.Drawing.Point(68, 447);
            this.btn_eliminar_pago.Name = "btn_eliminar_pago";
            this.btn_eliminar_pago.Size = new System.Drawing.Size(47, 50);
            this.btn_eliminar_pago.TabIndex = 123;
            this.btn_eliminar_pago.UseVisualStyleBackColor = true;
            this.btn_eliminar_pago.Click += new System.EventHandler(this.btn_eliminar_pago_Click);
            // 
            // frm_Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 509);
            this.Controls.Add(this.btn_eliminar_pago);
            this.Controls.Add(this.btn_salir_pagos);
            this.Controls.Add(this.btn_limpiar_pago);
            this.Controls.Add(this.btn_agregar_pago);
            this.Controls.Add(this.grd_pagos);
            this.Controls.Add(this.grp_datos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Pagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Pagos";
            this.Load += new System.EventHandler(this.frm_Pagos_Load);
            this.grp_buscar_afi_atencion.ResumeLayout(false);
            this.grp_buscar_afi_atencion.PerformLayout();
            this.grp_datos.ResumeLayout(false);
            this.grp_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_pagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_buscar_afi_atencion;
        private System.Windows.Forms.Button btn_limpiar_filtros_cuota;
        private System.Windows.Forms.Label lbl_nombre_afi_atencion;
        private System.Windows.Forms.Label lbl_ape_afi_aten;
        private System.Windows.Forms.TextBox txt_nombre_afi_cuota;
        private System.Windows.Forms.TextBox txt_apellido_afi_cuota;
        private System.Windows.Forms.ComboBox cmb_resultados_cuota;
        private System.Windows.Forms.Label lbl_resultados_ate;
        private System.Windows.Forms.Button btn_buscar_afi_cuota;
        private System.Windows.Forms.TextBox txt_num_afi_cuota;
        private System.Windows.Forms.Label lbl_apellido_afi_atencion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msk_nro_cuota;
        private System.Windows.Forms.MaskedTextBox msk_anio_cuota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_monto_emerg;
        private System.Windows.Forms.MaskedTextBox msk_fecha_pago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grp_datos;
        private System.Windows.Forms.DataGridView grd_pagos;
        private System.Windows.Forms.Button btn_agregar_pago;
        private System.Windows.Forms.Button btn_limpiar_pago;
        private System.Windows.Forms.Button btn_salir_pagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_completo_afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_emergencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button btn_eliminar_pago;
    }
}