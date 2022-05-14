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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Afiliado));
            this.txt_monto_afiliado = new System.Windows.Forms.TextBox();
            this.lbl_monto_inscripcion = new System.Windows.Forms.Label();
            this.lbl_fecha_inscripcion = new System.Windows.Forms.Label();
            this.grd_Afi = new System.Windows.Forms.DataGridView();
            this.nro_afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_inscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_inscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_salir_afiliado = new System.Windows.Forms.Button();
            this.btn_limpiar_afiliado = new System.Windows.Forms.Button();
            this.btn_agregar_afiliado = new System.Windows.Forms.Button();
            this.btn_editar_afiliado = new System.Windows.Forms.Button();
            this.btn_borrar_afiliado = new System.Windows.Forms.Button();
            this.cmb_tipo_afiliado = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_afiliado = new System.Windows.Forms.Label();
            this.lbl_fecha_nacimiento_afiliado = new System.Windows.Forms.Label();
            this.txt_nombre_afiliado = new System.Windows.Forms.TextBox();
            this.lbl_nombre_afiliado = new System.Windows.Forms.Label();
            this.txt_apellido_afiliado = new System.Windows.Forms.TextBox();
            this.lbl_apellido_afiliado = new System.Windows.Forms.Label();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_inscripcion = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Afi)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_monto_afiliado
            // 
            this.txt_monto_afiliado.Location = new System.Drawing.Point(392, 65);
            this.txt_monto_afiliado.Name = "txt_monto_afiliado";
            this.txt_monto_afiliado.Size = new System.Drawing.Size(43, 20);
            this.txt_monto_afiliado.TabIndex = 89;
            // 
            // lbl_monto_inscripcion
            // 
            this.lbl_monto_inscripcion.AutoSize = true;
            this.lbl_monto_inscripcion.Location = new System.Drawing.Point(293, 68);
            this.lbl_monto_inscripcion.Name = "lbl_monto_inscripcion";
            this.lbl_monto_inscripcion.Size = new System.Drawing.Size(91, 13);
            this.lbl_monto_inscripcion.TabIndex = 88;
            this.lbl_monto_inscripcion.Text = "Monto Inscripcion";
            // 
            // lbl_fecha_inscripcion
            // 
            this.lbl_fecha_inscripcion.AutoSize = true;
            this.lbl_fecha_inscripcion.Location = new System.Drawing.Point(279, 44);
            this.lbl_fecha_inscripcion.Name = "lbl_fecha_inscripcion";
            this.lbl_fecha_inscripcion.Size = new System.Drawing.Size(106, 13);
            this.lbl_fecha_inscripcion.TabIndex = 87;
            this.lbl_fecha_inscripcion.Text = "Fecha de Inscripcion";
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
            this.tipo_afiliado,
            this.fecha_inscripcion,
            this.monto_inscripcion});
            this.grd_Afi.Location = new System.Drawing.Point(19, 91);
            this.grd_Afi.Name = "grd_Afi";
            this.grd_Afi.ReadOnly = true;
            this.grd_Afi.Size = new System.Drawing.Size(765, 290);
            this.grd_Afi.TabIndex = 86;
            this.grd_Afi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Afi_CellClick);
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
            // 
            // tipo_afiliado
            // 
            this.tipo_afiliado.DataPropertyName = "ID_TIPO_AFILIADO";
            this.tipo_afiliado.HeaderText = "Tipo Afiliado";
            this.tipo_afiliado.Name = "tipo_afiliado";
            this.tipo_afiliado.ReadOnly = true;
            // 
            // fecha_inscripcion
            // 
            this.fecha_inscripcion.DataPropertyName = "FECHA_INSCRIPCION";
            this.fecha_inscripcion.HeaderText = "Fecha de Inscripcion";
            this.fecha_inscripcion.Name = "fecha_inscripcion";
            this.fecha_inscripcion.ReadOnly = true;
            // 
            // monto_inscripcion
            // 
            this.monto_inscripcion.DataPropertyName = "MONTO_INSCRIPCION";
            this.monto_inscripcion.HeaderText = "Monto Inscripcion";
            this.monto_inscripcion.Name = "monto_inscripcion";
            this.monto_inscripcion.ReadOnly = true;
            this.monto_inscripcion.Width = 60;
            // 
            // btn_salir_afiliado
            // 
            this.btn_salir_afiliado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir_afiliado.BackgroundImage")));
            this.btn_salir_afiliado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir_afiliado.Location = new System.Drawing.Point(734, 387);
            this.btn_salir_afiliado.Name = "btn_salir_afiliado";
            this.btn_salir_afiliado.Size = new System.Drawing.Size(50, 50);
            this.btn_salir_afiliado.TabIndex = 85;
            this.btn_salir_afiliado.UseVisualStyleBackColor = true;
            this.btn_salir_afiliado.Click += new System.EventHandler(this.btn_salir_afiliado_Click);
            // 
            // btn_limpiar_afiliado
            // 
            this.btn_limpiar_afiliado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_limpiar_afiliado.BackgroundImage")));
            this.btn_limpiar_afiliado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limpiar_afiliado.Location = new System.Drawing.Point(734, 33);
            this.btn_limpiar_afiliado.Name = "btn_limpiar_afiliado";
            this.btn_limpiar_afiliado.Size = new System.Drawing.Size(50, 50);
            this.btn_limpiar_afiliado.TabIndex = 84;
            this.btn_limpiar_afiliado.UseVisualStyleBackColor = true;
            this.btn_limpiar_afiliado.Click += new System.EventHandler(this.btn_limpiar_afiliado_Click);
            // 
            // btn_agregar_afiliado
            // 
            this.btn_agregar_afiliado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregar_afiliado.BackgroundImage")));
            this.btn_agregar_afiliado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar_afiliado.Location = new System.Drawing.Point(19, 387);
            this.btn_agregar_afiliado.Name = "btn_agregar_afiliado";
            this.btn_agregar_afiliado.Size = new System.Drawing.Size(50, 50);
            this.btn_agregar_afiliado.TabIndex = 83;
            this.btn_agregar_afiliado.UseVisualStyleBackColor = true;
            this.btn_agregar_afiliado.Click += new System.EventHandler(this.btn_agregar_afiliado_Click);
            // 
            // btn_editar_afiliado
            // 
            this.btn_editar_afiliado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar_afiliado.BackgroundImage")));
            this.btn_editar_afiliado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar_afiliado.Location = new System.Drawing.Point(75, 387);
            this.btn_editar_afiliado.Name = "btn_editar_afiliado";
            this.btn_editar_afiliado.Size = new System.Drawing.Size(50, 50);
            this.btn_editar_afiliado.TabIndex = 82;
            this.btn_editar_afiliado.UseVisualStyleBackColor = true;
            // 
            // btn_borrar_afiliado
            // 
            this.btn_borrar_afiliado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_borrar_afiliado.BackgroundImage")));
            this.btn_borrar_afiliado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar_afiliado.Location = new System.Drawing.Point(131, 387);
            this.btn_borrar_afiliado.Name = "btn_borrar_afiliado";
            this.btn_borrar_afiliado.Size = new System.Drawing.Size(50, 50);
            this.btn_borrar_afiliado.TabIndex = 81;
            this.btn_borrar_afiliado.UseVisualStyleBackColor = true;
            // 
            // cmb_tipo_afiliado
            // 
            this.cmb_tipo_afiliado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_afiliado.FormattingEnabled = true;
            this.cmb_tipo_afiliado.Location = new System.Drawing.Point(391, 15);
            this.cmb_tipo_afiliado.Name = "cmb_tipo_afiliado";
            this.cmb_tipo_afiliado.Size = new System.Drawing.Size(139, 21);
            this.cmb_tipo_afiliado.TabIndex = 80;
            // 
            // lbl_tipo_afiliado
            // 
            this.lbl_tipo_afiliado.AutoSize = true;
            this.lbl_tipo_afiliado.Location = new System.Drawing.Point(319, 18);
            this.lbl_tipo_afiliado.Name = "lbl_tipo_afiliado";
            this.lbl_tipo_afiliado.Size = new System.Drawing.Size(65, 13);
            this.lbl_tipo_afiliado.TabIndex = 79;
            this.lbl_tipo_afiliado.Text = "Tipo Afiliado";
            // 
            // lbl_fecha_nacimiento_afiliado
            // 
            this.lbl_fecha_nacimiento_afiliado.AutoSize = true;
            this.lbl_fecha_nacimiento_afiliado.Location = new System.Drawing.Point(17, 70);
            this.lbl_fecha_nacimiento_afiliado.Name = "lbl_fecha_nacimiento_afiliado";
            this.lbl_fecha_nacimiento_afiliado.Size = new System.Drawing.Size(108, 13);
            this.lbl_fecha_nacimiento_afiliado.TabIndex = 78;
            this.lbl_fecha_nacimiento_afiliado.Text = "Fecha de Nacimiento";
            // 
            // txt_nombre_afiliado
            // 
            this.txt_nombre_afiliado.Location = new System.Drawing.Point(131, 41);
            this.txt_nombre_afiliado.Name = "txt_nombre_afiliado";
            this.txt_nombre_afiliado.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre_afiliado.TabIndex = 77;
            // 
            // lbl_nombre_afiliado
            // 
            this.lbl_nombre_afiliado.AutoSize = true;
            this.lbl_nombre_afiliado.Location = new System.Drawing.Point(81, 44);
            this.lbl_nombre_afiliado.Name = "lbl_nombre_afiliado";
            this.lbl_nombre_afiliado.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre_afiliado.TabIndex = 76;
            this.lbl_nombre_afiliado.Text = "Nombre";
            // 
            // txt_apellido_afiliado
            // 
            this.txt_apellido_afiliado.Location = new System.Drawing.Point(131, 15);
            this.txt_apellido_afiliado.Name = "txt_apellido_afiliado";
            this.txt_apellido_afiliado.Size = new System.Drawing.Size(121, 20);
            this.txt_apellido_afiliado.TabIndex = 75;
            // 
            // lbl_apellido_afiliado
            // 
            this.lbl_apellido_afiliado.AutoSize = true;
            this.lbl_apellido_afiliado.Location = new System.Drawing.Point(81, 18);
            this.lbl_apellido_afiliado.Name = "lbl_apellido_afiliado";
            this.lbl_apellido_afiliado.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido_afiliado.TabIndex = 74;
            this.lbl_apellido_afiliado.Text = "Apellido";
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtp_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(131, 65);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(121, 20);
            this.dtp_fecha_nacimiento.TabIndex = 90;
            this.dtp_fecha_nacimiento.Value = new System.DateTime(2022, 5, 4, 0, 0, 0, 0);
            // 
            // dtp_fecha_inscripcion
            // 
            this.dtp_fecha_inscripcion.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtp_fecha_inscripcion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_inscripcion.Location = new System.Drawing.Point(392, 41);
            this.dtp_fecha_inscripcion.Name = "dtp_fecha_inscripcion";
            this.dtp_fecha_inscripcion.Size = new System.Drawing.Size(138, 20);
            this.dtp_fecha_inscripcion.TabIndex = 91;
            // 
            // frm_Afiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp_fecha_inscripcion);
            this.Controls.Add(this.dtp_fecha_nacimiento);
            this.Controls.Add(this.txt_monto_afiliado);
            this.Controls.Add(this.lbl_monto_inscripcion);
            this.Controls.Add(this.lbl_fecha_inscripcion);
            this.Controls.Add(this.grd_Afi);
            this.Controls.Add(this.btn_salir_afiliado);
            this.Controls.Add(this.btn_limpiar_afiliado);
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
            this.Text = "Afiliado";
            this.Load += new System.EventHandler(this.frm_Afiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Afi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_monto_afiliado;
        private System.Windows.Forms.Label lbl_monto_inscripcion;
        private System.Windows.Forms.Label lbl_fecha_inscripcion;
        private System.Windows.Forms.DataGridView grd_Afi;
        private System.Windows.Forms.Button btn_salir_afiliado;
        private System.Windows.Forms.Button btn_limpiar_afiliado;
        private System.Windows.Forms.Button btn_agregar_afiliado;
        private System.Windows.Forms.Button btn_editar_afiliado;
        private System.Windows.Forms.Button btn_borrar_afiliado;
        private System.Windows.Forms.ComboBox cmb_tipo_afiliado;
        private System.Windows.Forms.Label lbl_tipo_afiliado;
        private System.Windows.Forms.Label lbl_fecha_nacimiento_afiliado;
        private System.Windows.Forms.TextBox txt_nombre_afiliado;
        private System.Windows.Forms.Label lbl_nombre_afiliado;
        private System.Windows.Forms.TextBox txt_apellido_afiliado;
        private System.Windows.Forms.Label lbl_apellido_afiliado;
        private System.Windows.Forms.DateTimePicker dtp_fecha_nacimiento;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_inscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_inscripcion;
    }
}