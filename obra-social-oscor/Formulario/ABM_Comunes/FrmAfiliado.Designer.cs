namespace obra_social_oscor.Formulario.ABM_Comunes
{
    partial class frm_Afiliado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Afiliado));
            this.txt_monto_afiliado = new System.Windows.Forms.TextBox();
            this.lbl_monto_inscripcion = new System.Windows.Forms.Label();
            this.grd_Afi = new System.Windows.Forms.DataGridView();
            this.btn_salir_afiliado = new System.Windows.Forms.Button();
            this.btn_agregar_afiliado = new System.Windows.Forms.Button();
            this.btn_editar_afiliado = new System.Windows.Forms.Button();
            this.cmb_tipo_afiliado = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_afiliado = new System.Windows.Forms.Label();
            this.lbl_fecha_nacimiento_afiliado = new System.Windows.Forms.Label();
            this.txt_nombre_afiliado = new System.Windows.Forms.TextBox();
            this.lbl_nombre_afiliado = new System.Windows.Forms.Label();
            this.txt_apellido_afiliado = new System.Windows.Forms.TextBox();
            this.lbl_apellido_afiliado = new System.Windows.Forms.Label();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.btn_limpiar_afiliado = new System.Windows.Forms.Button();
            this.tt_afiliado = new System.Windows.Forms.ToolTip(this.components);
            this.nro_afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_inscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_inscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoTipoAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_borrar_afiliado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Afi)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_monto_afiliado
            // 
            this.txt_monto_afiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto_afiliado.Location = new System.Drawing.Point(220, 83);
            this.txt_monto_afiliado.Name = "txt_monto_afiliado";
            this.txt_monto_afiliado.Size = new System.Drawing.Size(91, 23);
            this.txt_monto_afiliado.TabIndex = 89;
            this.txt_monto_afiliado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_afiliado_KeyPress);
            // 
            // lbl_monto_inscripcion
            // 
            this.lbl_monto_inscripcion.AutoSize = true;
            this.lbl_monto_inscripcion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_monto_inscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto_inscripcion.Location = new System.Drawing.Point(92, 83);
            this.lbl_monto_inscripcion.Name = "lbl_monto_inscripcion";
            this.lbl_monto_inscripcion.Size = new System.Drawing.Size(122, 17);
            this.lbl_monto_inscripcion.TabIndex = 88;
            this.lbl_monto_inscripcion.Text = "Monto Inscripcion:";
            // 
            // grd_Afi
            // 
            this.grd_Afi.AllowUserToAddRows = false;
            this.grd_Afi.AllowUserToDeleteRows = false;
            this.grd_Afi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Afi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro_afiliado,
            this.apellido,
            this.nombre,
            this.fecha_nacimiento,
            this.fecha_inscripcion,
            this.monto_inscripcion,
            this.tipo_afiliado,
            this.CodigoTipoAfiliado});
            this.grd_Afi.Location = new System.Drawing.Point(12, 119);
            this.grd_Afi.Name = "grd_Afi";
            this.grd_Afi.ReadOnly = true;
            this.grd_Afi.Size = new System.Drawing.Size(776, 290);
            this.grd_Afi.TabIndex = 86;
            this.grd_Afi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Afi_CellClick);
            // 
            // btn_salir_afiliado
            // 
            this.btn_salir_afiliado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir_afiliado.BackgroundImage")));
            this.btn_salir_afiliado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir_afiliado.Location = new System.Drawing.Point(738, 421);
            this.btn_salir_afiliado.Name = "btn_salir_afiliado";
            this.btn_salir_afiliado.Size = new System.Drawing.Size(50, 50);
            this.btn_salir_afiliado.TabIndex = 85;
            this.tt_afiliado.SetToolTip(this.btn_salir_afiliado, "Salir del formulario");
            this.btn_salir_afiliado.UseVisualStyleBackColor = true;
            this.btn_salir_afiliado.Click += new System.EventHandler(this.btn_salir_afiliado_Click);
            // 
            // btn_agregar_afiliado
            // 
            this.btn_agregar_afiliado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregar_afiliado.BackgroundImage")));
            this.btn_agregar_afiliado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar_afiliado.Location = new System.Drawing.Point(19, 415);
            this.btn_agregar_afiliado.Name = "btn_agregar_afiliado";
            this.btn_agregar_afiliado.Size = new System.Drawing.Size(50, 50);
            this.btn_agregar_afiliado.TabIndex = 83;
            this.tt_afiliado.SetToolTip(this.btn_agregar_afiliado, "Agregar un afiliado");
            this.btn_agregar_afiliado.UseVisualStyleBackColor = true;
            this.btn_agregar_afiliado.Click += new System.EventHandler(this.btn_agregar_afiliado_Click);
            // 
            // btn_editar_afiliado
            // 
            this.btn_editar_afiliado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar_afiliado.BackgroundImage")));
            this.btn_editar_afiliado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar_afiliado.Location = new System.Drawing.Point(75, 415);
            this.btn_editar_afiliado.Name = "btn_editar_afiliado";
            this.btn_editar_afiliado.Size = new System.Drawing.Size(50, 50);
            this.btn_editar_afiliado.TabIndex = 82;
            this.tt_afiliado.SetToolTip(this.btn_editar_afiliado, "Editar un afiliado");
            this.btn_editar_afiliado.UseVisualStyleBackColor = true;
            this.btn_editar_afiliado.Click += new System.EventHandler(this.btn_editar_afiliado_Click);
            // 
            // cmb_tipo_afiliado
            // 
            this.cmb_tipo_afiliado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_afiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_afiliado.FormattingEnabled = true;
            this.cmb_tipo_afiliado.Location = new System.Drawing.Point(500, 49);
            this.cmb_tipo_afiliado.Name = "cmb_tipo_afiliado";
            this.cmb_tipo_afiliado.Size = new System.Drawing.Size(204, 24);
            this.cmb_tipo_afiliado.TabIndex = 80;
            // 
            // lbl_tipo_afiliado
            // 
            this.lbl_tipo_afiliado.AutoSize = true;
            this.lbl_tipo_afiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_afiliado.Location = new System.Drawing.Point(404, 52);
            this.lbl_tipo_afiliado.Name = "lbl_tipo_afiliado";
            this.lbl_tipo_afiliado.Size = new System.Drawing.Size(90, 17);
            this.lbl_tipo_afiliado.TabIndex = 79;
            this.lbl_tipo_afiliado.Text = "Tipo Afiliado:";
            // 
            // lbl_fecha_nacimiento_afiliado
            // 
            this.lbl_fecha_nacimiento_afiliado.AutoSize = true;
            this.lbl_fecha_nacimiento_afiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_nacimiento_afiliado.Location = new System.Drawing.Point(72, 52);
            this.lbl_fecha_nacimiento_afiliado.Name = "lbl_fecha_nacimiento_afiliado";
            this.lbl_fecha_nacimiento_afiliado.Size = new System.Drawing.Size(145, 17);
            this.lbl_fecha_nacimiento_afiliado.TabIndex = 78;
            this.lbl_fecha_nacimiento_afiliado.Text = "Fecha de Nacimiento:";
            // 
            // txt_nombre_afiliado
            // 
            this.txt_nombre_afiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_afiliado.Location = new System.Drawing.Point(500, 17);
            this.txt_nombre_afiliado.Name = "txt_nombre_afiliado";
            this.txt_nombre_afiliado.Size = new System.Drawing.Size(204, 23);
            this.txt_nombre_afiliado.TabIndex = 77;
            this.txt_nombre_afiliado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_afiliado_KeyPress);
            // 
            // lbl_nombre_afiliado
            // 
            this.lbl_nombre_afiliado.AutoSize = true;
            this.lbl_nombre_afiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_afiliado.Location = new System.Drawing.Point(432, 20);
            this.lbl_nombre_afiliado.Name = "lbl_nombre_afiliado";
            this.lbl_nombre_afiliado.Size = new System.Drawing.Size(62, 17);
            this.lbl_nombre_afiliado.TabIndex = 76;
            this.lbl_nombre_afiliado.Text = "Nombre:";
            // 
            // txt_apellido_afiliado
            // 
            this.txt_apellido_afiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_afiliado.Location = new System.Drawing.Point(220, 17);
            this.txt_apellido_afiliado.Name = "txt_apellido_afiliado";
            this.txt_apellido_afiliado.Size = new System.Drawing.Size(167, 23);
            this.txt_apellido_afiliado.TabIndex = 75;
            this.txt_apellido_afiliado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_afiliado_KeyPress);
            // 
            // lbl_apellido_afiliado
            // 
            this.lbl_apellido_afiliado.AutoSize = true;
            this.lbl_apellido_afiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido_afiliado.Location = new System.Drawing.Point(152, 18);
            this.lbl_apellido_afiliado.Name = "lbl_apellido_afiliado";
            this.lbl_apellido_afiliado.Size = new System.Drawing.Size(62, 17);
            this.lbl_apellido_afiliado.TabIndex = 74;
            this.lbl_apellido_afiliado.Text = "Apellido:";
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtp_fecha_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(220, 49);
            this.dtp_fecha_nacimiento.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtp_fecha_nacimiento.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(167, 23);
            this.dtp_fecha_nacimiento.TabIndex = 90;
            this.dtp_fecha_nacimiento.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // btn_limpiar_afiliado
            // 
            this.btn_limpiar_afiliado.Location = new System.Drawing.Point(199, 442);
            this.btn_limpiar_afiliado.Name = "btn_limpiar_afiliado";
            this.btn_limpiar_afiliado.Size = new System.Drawing.Size(112, 23);
            this.btn_limpiar_afiliado.TabIndex = 92;
            this.btn_limpiar_afiliado.Text = "Reiniciar Formulario";
            this.btn_limpiar_afiliado.UseVisualStyleBackColor = true;
            this.btn_limpiar_afiliado.Click += new System.EventHandler(this.btn_limpiar_afiliado_Click_1);
            // 
            // nro_afiliado
            // 
            this.nro_afiliado.HeaderText = "Nro Afiliado";
            this.nro_afiliado.Name = "nro_afiliado";
            this.nro_afiliado.ReadOnly = true;
            this.nro_afiliado.Visible = false;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "APELLIDO";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "NOMBRE";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.DataPropertyName = "FECHA_NACIMIENTO";
            this.fecha_nacimiento.HeaderText = "Fecha de Nacimiento";
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.ReadOnly = true;
            this.fecha_nacimiento.Width = 120;
            // 
            // fecha_inscripcion
            // 
            this.fecha_inscripcion.DataPropertyName = "FECHA_INSCRIPCION";
            this.fecha_inscripcion.HeaderText = "Fecha de Inscripcion";
            this.fecha_inscripcion.Name = "fecha_inscripcion";
            this.fecha_inscripcion.ReadOnly = true;
            this.fecha_inscripcion.Width = 120;
            // 
            // monto_inscripcion
            // 
            this.monto_inscripcion.DataPropertyName = "MONTO_INSCRIPCION";
            this.monto_inscripcion.HeaderText = "Monto Inscripcion";
            this.monto_inscripcion.Name = "monto_inscripcion";
            this.monto_inscripcion.ReadOnly = true;
            this.monto_inscripcion.Width = 90;
            // 
            // tipo_afiliado
            // 
            this.tipo_afiliado.HeaderText = "Tipo Afiliado";
            this.tipo_afiliado.Name = "tipo_afiliado";
            this.tipo_afiliado.ReadOnly = true;
            this.tipo_afiliado.Width = 150;
            // 
            // CodigoTipoAfiliado
            // 
            this.CodigoTipoAfiliado.HeaderText = "Codigo Tipo Afiliado";
            this.CodigoTipoAfiliado.Name = "CodigoTipoAfiliado";
            this.CodigoTipoAfiliado.ReadOnly = true;
            this.CodigoTipoAfiliado.Visible = false;
            // 
            // btn_borrar_afiliado
            // 
            this.btn_borrar_afiliado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_borrar_afiliado.BackgroundImage")));
            this.btn_borrar_afiliado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar_afiliado.Location = new System.Drawing.Point(131, 415);
            this.btn_borrar_afiliado.Name = "btn_borrar_afiliado";
            this.btn_borrar_afiliado.Size = new System.Drawing.Size(50, 50);
            this.btn_borrar_afiliado.TabIndex = 81;
            this.tt_afiliado.SetToolTip(this.btn_borrar_afiliado, "Eliminar un afiliado");
            this.btn_borrar_afiliado.UseVisualStyleBackColor = true;
            this.btn_borrar_afiliado.Click += new System.EventHandler(this.btn_borrar_afiliado_Click);
            // 
            // frm_Afiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.btn_limpiar_afiliado);
            this.Controls.Add(this.dtp_fecha_nacimiento);
            this.Controls.Add(this.txt_monto_afiliado);
            this.Controls.Add(this.lbl_monto_inscripcion);
            this.Controls.Add(this.grd_Afi);
            this.Controls.Add(this.btn_salir_afiliado);
            this.Controls.Add(this.btn_agregar_afiliado);
            this.Controls.Add(this.btn_editar_afiliado);
            this.Controls.Add(this.btn_borrar_afiliado);
            this.Controls.Add(this.cmb_tipo_afiliado);
            this.Controls.Add(this.lbl_tipo_afiliado);
            this.Controls.Add(this.lbl_fecha_nacimiento_afiliado);
            this.Controls.Add(this.txt_nombre_afiliado);
            this.Controls.Add(this.lbl_nombre_afiliado);
            this.Controls.Add(this.txt_apellido_afiliado);
            this.Controls.Add(this.lbl_apellido_afiliado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Afiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afiliado";
            this.Load += new System.EventHandler(this.frm_Afiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Afi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_monto_afiliado;
        private System.Windows.Forms.Label lbl_monto_inscripcion;
        private System.Windows.Forms.DataGridView grd_Afi;
        private System.Windows.Forms.Button btn_salir_afiliado;
        private System.Windows.Forms.Button btn_agregar_afiliado;
        private System.Windows.Forms.Button btn_editar_afiliado;
        private System.Windows.Forms.ComboBox cmb_tipo_afiliado;
        private System.Windows.Forms.Label lbl_tipo_afiliado;
        private System.Windows.Forms.Label lbl_fecha_nacimiento_afiliado;
        private System.Windows.Forms.TextBox txt_nombre_afiliado;
        private System.Windows.Forms.Label lbl_nombre_afiliado;
        private System.Windows.Forms.TextBox txt_apellido_afiliado;
        private System.Windows.Forms.Label lbl_apellido_afiliado;
        private System.Windows.Forms.DateTimePicker dtp_fecha_nacimiento;
        private System.Windows.Forms.Button btn_limpiar_afiliado;
        private System.Windows.Forms.ToolTip tt_afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_inscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_inscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoTipoAfiliado;
        private System.Windows.Forms.Button btn_borrar_afiliado;
    }
}