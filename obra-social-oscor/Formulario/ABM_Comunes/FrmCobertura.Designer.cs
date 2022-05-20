namespace obra_social_oscor.Formulario.ABM_Comunes
{
    partial class FrmCobertura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCobertura));
            this.btn_limpiar_cobertura = new System.Windows.Forms.Button();
            this.grd_cobertura = new System.Windows.Forms.DataGridView();
            this.txtPorcCobertura = new System.Windows.Forms.TextBox();
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            this.lbl_practica = new System.Windows.Forms.Label();
            this.cmb_practica = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_afiliado = new System.Windows.Forms.Label();
            this.cmb_tipo_afiliado = new System.Windows.Forms.ComboBox();
            this.btn_salir_cobertura = new System.Windows.Forms.Button();
            this.btn_agregar_cobertura = new System.Windows.Forms.Button();
            this.btn_editar_cobertura = new System.Windows.Forms.Button();
            this.btn_borrar_cobertura = new System.Windows.Forms.Button();
            this.CodigoTipoAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionTipoAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPractica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionPractica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPractica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd_cobertura)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_limpiar_cobertura
            // 
            this.btn_limpiar_cobertura.Location = new System.Drawing.Point(200, 326);
            this.btn_limpiar_cobertura.Name = "btn_limpiar_cobertura";
            this.btn_limpiar_cobertura.Size = new System.Drawing.Size(112, 23);
            this.btn_limpiar_cobertura.TabIndex = 108;
            this.btn_limpiar_cobertura.Text = "Reiniciar Formulario";
            this.btn_limpiar_cobertura.UseVisualStyleBackColor = true;
            this.btn_limpiar_cobertura.Click += new System.EventHandler(this.btn_limpiar_afiliado_Click);
            // 
            // grd_cobertura
            // 
            this.grd_cobertura.AllowUserToAddRows = false;
            this.grd_cobertura.AllowUserToDeleteRows = false;
            this.grd_cobertura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_cobertura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoTipoAfiliado,
            this.DescripcionTipoAfiliado,
            this.CodigoPractica,
            this.DescripcionPractica,
            this.PrecioPractica,
            this.Porcentaje});
            this.grd_cobertura.Location = new System.Drawing.Point(21, 93);
            this.grd_cobertura.Name = "grd_cobertura";
            this.grd_cobertura.ReadOnly = true;
            this.grd_cobertura.Size = new System.Drawing.Size(500, 200);
            this.grd_cobertura.TabIndex = 104;
            this.grd_cobertura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_cobertura_CellClick);
            // 
            // txtPorcCobertura
            // 
            this.txtPorcCobertura.Location = new System.Drawing.Point(160, 55);
            this.txtPorcCobertura.Name = "txtPorcCobertura";
            this.txtPorcCobertura.Size = new System.Drawing.Size(55, 20);
            this.txtPorcCobertura.TabIndex = 103;
            this.txtPorcCobertura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_afiliado_KeyPress);
            // 
            // lbl_porcentaje
            // 
            this.lbl_porcentaje.AutoSize = true;
            this.lbl_porcentaje.Location = new System.Drawing.Point(32, 58);
            this.lbl_porcentaje.Name = "lbl_porcentaje";
            this.lbl_porcentaje.Size = new System.Drawing.Size(122, 13);
            this.lbl_porcentaje.TabIndex = 102;
            this.lbl_porcentaje.Text = "Porcentaje de Cobertura";
            // 
            // lbl_practica
            // 
            this.lbl_practica.AutoSize = true;
            this.lbl_practica.Location = new System.Drawing.Point(312, 25);
            this.lbl_practica.Name = "lbl_practica";
            this.lbl_practica.Size = new System.Drawing.Size(46, 13);
            this.lbl_practica.TabIndex = 101;
            this.lbl_practica.Text = "Practica";
            // 
            // cmb_practica
            // 
            this.cmb_practica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_practica.FormattingEnabled = true;
            this.cmb_practica.Location = new System.Drawing.Point(364, 22);
            this.cmb_practica.Name = "cmb_practica";
            this.cmb_practica.Size = new System.Drawing.Size(121, 21);
            this.cmb_practica.TabIndex = 100;
            // 
            // lbl_tipo_afiliado
            // 
            this.lbl_tipo_afiliado.AutoSize = true;
            this.lbl_tipo_afiliado.Location = new System.Drawing.Point(89, 25);
            this.lbl_tipo_afiliado.Name = "lbl_tipo_afiliado";
            this.lbl_tipo_afiliado.Size = new System.Drawing.Size(65, 13);
            this.lbl_tipo_afiliado.TabIndex = 99;
            this.lbl_tipo_afiliado.Text = "Tipo Afiliado";
            // 
            // cmb_tipo_afiliado
            // 
            this.cmb_tipo_afiliado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_afiliado.FormattingEnabled = true;
            this.cmb_tipo_afiliado.Location = new System.Drawing.Point(160, 22);
            this.cmb_tipo_afiliado.Name = "cmb_tipo_afiliado";
            this.cmb_tipo_afiliado.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo_afiliado.TabIndex = 98;
            // 
            // btn_salir_cobertura
            // 
            this.btn_salir_cobertura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir_cobertura.BackgroundImage")));
            this.btn_salir_cobertura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir_cobertura.Location = new System.Drawing.Point(471, 299);
            this.btn_salir_cobertura.Name = "btn_salir_cobertura";
            this.btn_salir_cobertura.Size = new System.Drawing.Size(50, 50);
            this.btn_salir_cobertura.TabIndex = 109;
            this.btn_salir_cobertura.UseVisualStyleBackColor = true;
            this.btn_salir_cobertura.Click += new System.EventHandler(this.btn_salir_afiliado_Click);
            // 
            // btn_agregar_cobertura
            // 
            this.btn_agregar_cobertura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregar_cobertura.BackgroundImage")));
            this.btn_agregar_cobertura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar_cobertura.Location = new System.Drawing.Point(20, 299);
            this.btn_agregar_cobertura.Name = "btn_agregar_cobertura";
            this.btn_agregar_cobertura.Size = new System.Drawing.Size(50, 50);
            this.btn_agregar_cobertura.TabIndex = 107;
            this.btn_agregar_cobertura.UseVisualStyleBackColor = true;
            this.btn_agregar_cobertura.Click += new System.EventHandler(this.btn_agregar_afiliado_Click);
            // 
            // btn_editar_cobertura
            // 
            this.btn_editar_cobertura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar_cobertura.BackgroundImage")));
            this.btn_editar_cobertura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar_cobertura.Location = new System.Drawing.Point(76, 299);
            this.btn_editar_cobertura.Name = "btn_editar_cobertura";
            this.btn_editar_cobertura.Size = new System.Drawing.Size(50, 50);
            this.btn_editar_cobertura.TabIndex = 106;
            this.btn_editar_cobertura.UseVisualStyleBackColor = true;
            this.btn_editar_cobertura.Click += new System.EventHandler(this.btn_editar_afiliado_Click);
            // 
            // btn_borrar_cobertura
            // 
            this.btn_borrar_cobertura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_borrar_cobertura.BackgroundImage")));
            this.btn_borrar_cobertura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar_cobertura.Location = new System.Drawing.Point(132, 299);
            this.btn_borrar_cobertura.Name = "btn_borrar_cobertura";
            this.btn_borrar_cobertura.Size = new System.Drawing.Size(50, 50);
            this.btn_borrar_cobertura.TabIndex = 105;
            this.btn_borrar_cobertura.UseVisualStyleBackColor = true;
            this.btn_borrar_cobertura.Click += new System.EventHandler(this.btn_borrar_afiliado_Click);
            // 
            // CodigoTipoAfiliado
            // 
            this.CodigoTipoAfiliado.HeaderText = "cod_tipo_afiliado";
            this.CodigoTipoAfiliado.Name = "CodigoTipoAfiliado";
            this.CodigoTipoAfiliado.ReadOnly = true;
            this.CodigoTipoAfiliado.Visible = false;
            // 
            // DescripcionTipoAfiliado
            // 
            this.DescripcionTipoAfiliado.HeaderText = "Tipo Afiliado";
            this.DescripcionTipoAfiliado.Name = "DescripcionTipoAfiliado";
            this.DescripcionTipoAfiliado.ReadOnly = true;
            this.DescripcionTipoAfiliado.Width = 150;
            // 
            // CodigoPractica
            // 
            this.CodigoPractica.HeaderText = "cod_practica";
            this.CodigoPractica.Name = "CodigoPractica";
            this.CodigoPractica.ReadOnly = true;
            this.CodigoPractica.Visible = false;
            // 
            // DescripcionPractica
            // 
            this.DescripcionPractica.HeaderText = "Practica";
            this.DescripcionPractica.Name = "DescripcionPractica";
            this.DescripcionPractica.ReadOnly = true;
            this.DescripcionPractica.Width = 150;
            // 
            // PrecioPractica
            // 
            this.PrecioPractica.HeaderText = "practica_precio";
            this.PrecioPractica.Name = "PrecioPractica";
            this.PrecioPractica.ReadOnly = true;
            this.PrecioPractica.Visible = false;
            // 
            // Porcentaje
            // 
            this.Porcentaje.DataPropertyName = "PORC_COBERTURA";
            this.Porcentaje.HeaderText = "Porcentaje de Cobertura";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            // 
            // FrmCobertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 369);
            this.Controls.Add(this.btn_salir_cobertura);
            this.Controls.Add(this.btn_limpiar_cobertura);
            this.Controls.Add(this.btn_agregar_cobertura);
            this.Controls.Add(this.btn_editar_cobertura);
            this.Controls.Add(this.btn_borrar_cobertura);
            this.Controls.Add(this.grd_cobertura);
            this.Controls.Add(this.txtPorcCobertura);
            this.Controls.Add(this.lbl_porcentaje);
            this.Controls.Add(this.lbl_practica);
            this.Controls.Add(this.cmb_practica);
            this.Controls.Add(this.lbl_tipo_afiliado);
            this.Controls.Add(this.cmb_tipo_afiliado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCobertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCobertura";
            this.Load += new System.EventHandler(this.FrmCobertura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_cobertura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir_cobertura;
        private System.Windows.Forms.Button btn_limpiar_cobertura;
        private System.Windows.Forms.Button btn_agregar_cobertura;
        private System.Windows.Forms.Button btn_editar_cobertura;
        private System.Windows.Forms.Button btn_borrar_cobertura;
        private System.Windows.Forms.DataGridView grd_cobertura;
        private System.Windows.Forms.TextBox txtPorcCobertura;
        private System.Windows.Forms.Label lbl_porcentaje;
        private System.Windows.Forms.Label lbl_practica;
        private System.Windows.Forms.ComboBox cmb_practica;
        private System.Windows.Forms.Label lbl_tipo_afiliado;
        private System.Windows.Forms.ComboBox cmb_tipo_afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoTipoAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionTipoAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPractica;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPractica;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPractica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
    }
}