namespace obra_social_oscor.Formulario.ABM
{
    partial class frm_Centro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Centro));
            this.grp_centros = new System.Windows.Forms.GroupBox();
            this.grp_esp_centro = new System.Windows.Forms.GroupBox();
            this.btn_agregar_esp_centro = new System.Windows.Forms.Button();
            this.grd_esp_centro = new System.Windows.Forms.DataGridView();
            this.id_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_esp_centro = new System.Windows.Forms.ComboBox();
            this.cmb_propio = new System.Windows.Forms.ComboBox();
            this.lbl_propio = new System.Windows.Forms.Label();
            this.lbl_mail_centro = new System.Windows.Forms.Label();
            this.txt_mail_centro = new System.Windows.Forms.TextBox();
            this.lbl_tel_centro = new System.Windows.Forms.Label();
            this.cmb_loc_centro = new System.Windows.Forms.ComboBox();
            this.lbl_loc_centro = new System.Windows.Forms.Label();
            this.cmb_barrio_centro = new System.Windows.Forms.ComboBox();
            this.lbl_denom_centro = new System.Windows.Forms.Label();
            this.txt_nro_calle_centro = new System.Windows.Forms.TextBox();
            this.txt_denom_centro = new System.Windows.Forms.TextBox();
            this.lbl_nro_calle_centro = new System.Windows.Forms.Label();
            this.lbl_calle_centro = new System.Windows.Forms.Label();
            this.txt_calle_centro = new System.Windows.Forms.TextBox();
            this.lbl_barrio_centro = new System.Windows.Forms.Label();
            this.grd_centros = new System.Windows.Forms.DataGridView();
            this.btn_agregar_centro = new System.Windows.Forms.Button();
            this.btn_limpiar_centro = new System.Windows.Forms.Button();
            this.btn_salir_centro = new System.Windows.Forms.Button();
            this.cod_centro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msk_txt_telefono_centro = new System.Windows.Forms.MaskedTextBox();
            this.btn_eliminar_esp = new System.Windows.Forms.Button();
            this.grp_centros.SuspendLayout();
            this.grp_esp_centro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_esp_centro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_centros)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_centros
            // 
            this.grp_centros.Controls.Add(this.msk_txt_telefono_centro);
            this.grp_centros.Controls.Add(this.grp_esp_centro);
            this.grp_centros.Controls.Add(this.cmb_propio);
            this.grp_centros.Controls.Add(this.lbl_propio);
            this.grp_centros.Controls.Add(this.lbl_mail_centro);
            this.grp_centros.Controls.Add(this.txt_mail_centro);
            this.grp_centros.Controls.Add(this.lbl_tel_centro);
            this.grp_centros.Controls.Add(this.cmb_loc_centro);
            this.grp_centros.Controls.Add(this.lbl_loc_centro);
            this.grp_centros.Controls.Add(this.cmb_barrio_centro);
            this.grp_centros.Controls.Add(this.lbl_denom_centro);
            this.grp_centros.Controls.Add(this.txt_nro_calle_centro);
            this.grp_centros.Controls.Add(this.txt_denom_centro);
            this.grp_centros.Controls.Add(this.lbl_nro_calle_centro);
            this.grp_centros.Controls.Add(this.lbl_calle_centro);
            this.grp_centros.Controls.Add(this.txt_calle_centro);
            this.grp_centros.Controls.Add(this.lbl_barrio_centro);
            this.grp_centros.Location = new System.Drawing.Point(12, 12);
            this.grp_centros.Name = "grp_centros";
            this.grp_centros.Size = new System.Drawing.Size(1093, 275);
            this.grp_centros.TabIndex = 0;
            this.grp_centros.TabStop = false;
            this.grp_centros.Text = "Datos";
            // 
            // grp_esp_centro
            // 
            this.grp_esp_centro.Controls.Add(this.btn_eliminar_esp);
            this.grp_esp_centro.Controls.Add(this.btn_agregar_esp_centro);
            this.grp_esp_centro.Controls.Add(this.grd_esp_centro);
            this.grp_esp_centro.Controls.Add(this.cmb_esp_centro);
            this.grp_esp_centro.Location = new System.Drawing.Point(797, 19);
            this.grp_esp_centro.Name = "grp_esp_centro";
            this.grp_esp_centro.Size = new System.Drawing.Size(290, 250);
            this.grp_esp_centro.TabIndex = 109;
            this.grp_esp_centro.TabStop = false;
            this.grp_esp_centro.Text = "Especialidades del centro";
            // 
            // btn_agregar_esp_centro
            // 
            this.btn_agregar_esp_centro.Location = new System.Drawing.Point(6, 19);
            this.btn_agregar_esp_centro.Name = "btn_agregar_esp_centro";
            this.btn_agregar_esp_centro.Size = new System.Drawing.Size(73, 23);
            this.btn_agregar_esp_centro.TabIndex = 95;
            this.btn_agregar_esp_centro.Text = "Agregar";
            this.btn_agregar_esp_centro.UseVisualStyleBackColor = true;
            this.btn_agregar_esp_centro.Click += new System.EventHandler(this.btn_agregar_esp_centro_Click);
            // 
            // grd_esp_centro
            // 
            this.grd_esp_centro.AllowUserToAddRows = false;
            this.grd_esp_centro.AllowUserToDeleteRows = false;
            this.grd_esp_centro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_esp_centro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_especialidad,
            this.nombre});
            this.grd_esp_centro.Location = new System.Drawing.Point(6, 82);
            this.grd_esp_centro.Name = "grd_esp_centro";
            this.grd_esp_centro.ReadOnly = true;
            this.grd_esp_centro.Size = new System.Drawing.Size(278, 162);
            this.grd_esp_centro.TabIndex = 111;
            this.grd_esp_centro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_esp_centro_CellClick);
            // 
            // id_especialidad
            // 
            this.id_especialidad.HeaderText = "IdEspecialidad";
            this.id_especialidad.Name = "id_especialidad";
            this.id_especialidad.ReadOnly = true;
            this.id_especialidad.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // cmb_esp_centro
            // 
            this.cmb_esp_centro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_esp_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_esp_centro.FormattingEnabled = true;
            this.cmb_esp_centro.Location = new System.Drawing.Point(85, 19);
            this.cmb_esp_centro.Name = "cmb_esp_centro";
            this.cmb_esp_centro.Size = new System.Drawing.Size(199, 24);
            this.cmb_esp_centro.TabIndex = 110;
            // 
            // cmb_propio
            // 
            this.cmb_propio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_propio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_propio.FormattingEnabled = true;
            this.cmb_propio.Location = new System.Drawing.Point(724, 20);
            this.cmb_propio.Name = "cmb_propio";
            this.cmb_propio.Size = new System.Drawing.Size(43, 24);
            this.cmb_propio.TabIndex = 108;
            // 
            // lbl_propio
            // 
            this.lbl_propio.AutoSize = true;
            this.lbl_propio.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_propio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_propio.Location = new System.Drawing.Point(665, 23);
            this.lbl_propio.Name = "lbl_propio";
            this.lbl_propio.Size = new System.Drawing.Size(53, 17);
            this.lbl_propio.TabIndex = 107;
            this.lbl_propio.Text = "Propio:";
            // 
            // lbl_mail_centro
            // 
            this.lbl_mail_centro.AutoSize = true;
            this.lbl_mail_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mail_centro.Location = new System.Drawing.Point(321, 104);
            this.lbl_mail_centro.Name = "lbl_mail_centro";
            this.lbl_mail_centro.Size = new System.Drawing.Size(37, 17);
            this.lbl_mail_centro.TabIndex = 105;
            this.lbl_mail_centro.Text = "Mail:";
            // 
            // txt_mail_centro
            // 
            this.txt_mail_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mail_centro.Location = new System.Drawing.Point(364, 101);
            this.txt_mail_centro.Name = "txt_mail_centro";
            this.txt_mail_centro.Size = new System.Drawing.Size(295, 23);
            this.txt_mail_centro.TabIndex = 106;
            // 
            // lbl_tel_centro
            // 
            this.lbl_tel_centro.AutoSize = true;
            this.lbl_tel_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel_centro.Location = new System.Drawing.Point(6, 104);
            this.lbl_tel_centro.Name = "lbl_tel_centro";
            this.lbl_tel_centro.Size = new System.Drawing.Size(68, 17);
            this.lbl_tel_centro.TabIndex = 103;
            this.lbl_tel_centro.Text = "Telefono:";
            // 
            // cmb_loc_centro
            // 
            this.cmb_loc_centro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_loc_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_loc_centro.FormattingEnabled = true;
            this.cmb_loc_centro.Location = new System.Drawing.Point(515, 61);
            this.cmb_loc_centro.Name = "cmb_loc_centro";
            this.cmb_loc_centro.Size = new System.Drawing.Size(144, 24);
            this.cmb_loc_centro.TabIndex = 102;
            // 
            // lbl_loc_centro
            // 
            this.lbl_loc_centro.AutoSize = true;
            this.lbl_loc_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loc_centro.Location = new System.Drawing.Point(436, 64);
            this.lbl_loc_centro.Name = "lbl_loc_centro";
            this.lbl_loc_centro.Size = new System.Drawing.Size(73, 17);
            this.lbl_loc_centro.TabIndex = 101;
            this.lbl_loc_centro.Text = "Localidad:";
            // 
            // cmb_barrio_centro
            // 
            this.cmb_barrio_centro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_barrio_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_barrio_centro.FormattingEnabled = true;
            this.cmb_barrio_centro.Location = new System.Drawing.Point(515, 20);
            this.cmb_barrio_centro.Name = "cmb_barrio_centro";
            this.cmb_barrio_centro.Size = new System.Drawing.Size(144, 24);
            this.cmb_barrio_centro.TabIndex = 97;
            // 
            // lbl_denom_centro
            // 
            this.lbl_denom_centro.AutoSize = true;
            this.lbl_denom_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_denom_centro.Location = new System.Drawing.Point(17, 26);
            this.lbl_denom_centro.Name = "lbl_denom_centro";
            this.lbl_denom_centro.Size = new System.Drawing.Size(61, 17);
            this.lbl_denom_centro.TabIndex = 91;
            this.lbl_denom_centro.Text = "Denom.:";
            // 
            // txt_nro_calle_centro
            // 
            this.txt_nro_calle_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nro_calle_centro.Location = new System.Drawing.Point(364, 62);
            this.txt_nro_calle_centro.Name = "txt_nro_calle_centro";
            this.txt_nro_calle_centro.Size = new System.Drawing.Size(66, 23);
            this.txt_nro_calle_centro.TabIndex = 99;
            this.txt_nro_calle_centro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_calle_centro_KeyPress);
            // 
            // txt_denom_centro
            // 
            this.txt_denom_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_denom_centro.Location = new System.Drawing.Point(80, 23);
            this.txt_denom_centro.Name = "txt_denom_centro";
            this.txt_denom_centro.Size = new System.Drawing.Size(344, 23);
            this.txt_denom_centro.TabIndex = 92;
            this.txt_denom_centro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_denom_centro_KeyPress);
            // 
            // lbl_nro_calle_centro
            // 
            this.lbl_nro_calle_centro.AutoSize = true;
            this.lbl_nro_calle_centro.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_nro_calle_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nro_calle_centro.Location = new System.Drawing.Point(296, 65);
            this.lbl_nro_calle_centro.Name = "lbl_nro_calle_centro";
            this.lbl_nro_calle_centro.Size = new System.Drawing.Size(62, 17);
            this.lbl_nro_calle_centro.TabIndex = 98;
            this.lbl_nro_calle_centro.Text = "Numero:";
            // 
            // lbl_calle_centro
            // 
            this.lbl_calle_centro.AutoSize = true;
            this.lbl_calle_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calle_centro.Location = new System.Drawing.Point(31, 65);
            this.lbl_calle_centro.Name = "lbl_calle_centro";
            this.lbl_calle_centro.Size = new System.Drawing.Size(43, 17);
            this.lbl_calle_centro.TabIndex = 93;
            this.lbl_calle_centro.Text = "Calle:";
            // 
            // txt_calle_centro
            // 
            this.txt_calle_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_calle_centro.Location = new System.Drawing.Point(80, 62);
            this.txt_calle_centro.Name = "txt_calle_centro";
            this.txt_calle_centro.Size = new System.Drawing.Size(204, 23);
            this.txt_calle_centro.TabIndex = 94;
            this.txt_calle_centro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_calle_centro_KeyPress);
            // 
            // lbl_barrio_centro
            // 
            this.lbl_barrio_centro.AutoSize = true;
            this.lbl_barrio_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barrio_centro.Location = new System.Drawing.Point(459, 23);
            this.lbl_barrio_centro.Name = "lbl_barrio_centro";
            this.lbl_barrio_centro.Size = new System.Drawing.Size(50, 17);
            this.lbl_barrio_centro.TabIndex = 96;
            this.lbl_barrio_centro.Text = "Barrio:";
            // 
            // grd_centros
            // 
            this.grd_centros.AllowUserToAddRows = false;
            this.grd_centros.AllowUserToDeleteRows = false;
            this.grd_centros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_centros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_centro,
            this.denominacion,
            this.calle,
            this.numero,
            this.id_barrio,
            this.barrio,
            this.id_localidad,
            this.localidad,
            this.telefono,
            this.mail,
            this.propio});
            this.grd_centros.Location = new System.Drawing.Point(12, 293);
            this.grd_centros.Name = "grd_centros";
            this.grd_centros.ReadOnly = true;
            this.grd_centros.Size = new System.Drawing.Size(1093, 215);
            this.grd_centros.TabIndex = 1;
            this.grd_centros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_centros_CellClick);
            // 
            // btn_agregar_centro
            // 
            this.btn_agregar_centro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregar_centro.BackgroundImage")));
            this.btn_agregar_centro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar_centro.Location = new System.Drawing.Point(12, 547);
            this.btn_agregar_centro.Name = "btn_agregar_centro";
            this.btn_agregar_centro.Size = new System.Drawing.Size(50, 50);
            this.btn_agregar_centro.TabIndex = 84;
            this.btn_agregar_centro.UseVisualStyleBackColor = true;
            this.btn_agregar_centro.Click += new System.EventHandler(this.btn_agregar_centro_Click);
            // 
            // btn_limpiar_centro
            // 
            this.btn_limpiar_centro.Location = new System.Drawing.Point(92, 574);
            this.btn_limpiar_centro.Name = "btn_limpiar_centro";
            this.btn_limpiar_centro.Size = new System.Drawing.Size(112, 23);
            this.btn_limpiar_centro.TabIndex = 93;
            this.btn_limpiar_centro.Text = "Reiniciar Formulario";
            this.btn_limpiar_centro.UseVisualStyleBackColor = true;
            this.btn_limpiar_centro.Click += new System.EventHandler(this.btn_limpiar_centro_Click);
            // 
            // btn_salir_centro
            // 
            this.btn_salir_centro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir_centro.BackgroundImage")));
            this.btn_salir_centro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir_centro.Location = new System.Drawing.Point(1043, 547);
            this.btn_salir_centro.Name = "btn_salir_centro";
            this.btn_salir_centro.Size = new System.Drawing.Size(50, 50);
            this.btn_salir_centro.TabIndex = 94;
            this.btn_salir_centro.UseVisualStyleBackColor = true;
            this.btn_salir_centro.Click += new System.EventHandler(this.btn_salir_centro_Click);
            // 
            // cod_centro
            // 
            this.cod_centro.HeaderText = "Codigo";
            this.cod_centro.Name = "cod_centro";
            this.cod_centro.ReadOnly = true;
            this.cod_centro.Visible = false;
            // 
            // denominacion
            // 
            this.denominacion.HeaderText = "Denom.";
            this.denominacion.Name = "denominacion";
            this.denominacion.ReadOnly = true;
            this.denominacion.Width = 225;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            this.calle.Width = 175;
            // 
            // numero
            // 
            this.numero.HeaderText = "Nro.";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 50;
            // 
            // id_barrio
            // 
            this.id_barrio.HeaderText = "IdBarrio";
            this.id_barrio.Name = "id_barrio";
            this.id_barrio.ReadOnly = true;
            this.id_barrio.Visible = false;
            // 
            // barrio
            // 
            this.barrio.HeaderText = "Barrio";
            this.barrio.Name = "barrio";
            this.barrio.ReadOnly = true;
            // 
            // id_localidad
            // 
            this.id_localidad.HeaderText = "IdLocalidad";
            this.id_localidad.Name = "id_localidad";
            this.id_localidad.ReadOnly = true;
            this.id_localidad.Visible = false;
            // 
            // localidad
            // 
            this.localidad.HeaderText = "Localidad";
            this.localidad.Name = "localidad";
            this.localidad.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Tel.";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.HeaderText = "Mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Width = 250;
            // 
            // propio
            // 
            this.propio.HeaderText = "Propio";
            this.propio.Name = "propio";
            this.propio.ReadOnly = true;
            this.propio.Width = 50;
            // 
            // msk_txt_telefono_centro
            // 
            this.msk_txt_telefono_centro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_txt_telefono_centro.Location = new System.Drawing.Point(80, 101);
            this.msk_txt_telefono_centro.Mask = "9999999999999";
            this.msk_txt_telefono_centro.Name = "msk_txt_telefono_centro";
            this.msk_txt_telefono_centro.Size = new System.Drawing.Size(204, 23);
            this.msk_txt_telefono_centro.TabIndex = 112;
            this.msk_txt_telefono_centro.ValidatingType = typeof(int);
            // 
            // btn_eliminar_esp
            // 
            this.btn_eliminar_esp.Location = new System.Drawing.Point(6, 53);
            this.btn_eliminar_esp.Name = "btn_eliminar_esp";
            this.btn_eliminar_esp.Size = new System.Drawing.Size(73, 23);
            this.btn_eliminar_esp.TabIndex = 112;
            this.btn_eliminar_esp.Text = "Eliminar";
            this.btn_eliminar_esp.UseVisualStyleBackColor = true;
            this.btn_eliminar_esp.Click += new System.EventHandler(this.btn_eliminar_esp_Click);
            // 
            // frm_Centro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 609);
            this.Controls.Add(this.btn_salir_centro);
            this.Controls.Add(this.btn_limpiar_centro);
            this.Controls.Add(this.btn_agregar_centro);
            this.Controls.Add(this.grd_centros);
            this.Controls.Add(this.grp_centros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Centro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centros";
            this.Load += new System.EventHandler(this.frm_Centro_Load);
            this.grp_centros.ResumeLayout(false);
            this.grp_centros.PerformLayout();
            this.grp_esp_centro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_esp_centro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_centros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_centros;
        private System.Windows.Forms.ComboBox cmb_propio;
        private System.Windows.Forms.Label lbl_propio;
        private System.Windows.Forms.Label lbl_mail_centro;
        private System.Windows.Forms.TextBox txt_mail_centro;
        private System.Windows.Forms.Label lbl_tel_centro;
        private System.Windows.Forms.ComboBox cmb_loc_centro;
        private System.Windows.Forms.Label lbl_loc_centro;
        private System.Windows.Forms.ComboBox cmb_barrio_centro;
        private System.Windows.Forms.Label lbl_denom_centro;
        private System.Windows.Forms.TextBox txt_nro_calle_centro;
        private System.Windows.Forms.TextBox txt_denom_centro;
        private System.Windows.Forms.Label lbl_nro_calle_centro;
        private System.Windows.Forms.Label lbl_calle_centro;
        private System.Windows.Forms.TextBox txt_calle_centro;
        private System.Windows.Forms.Label lbl_barrio_centro;
        private System.Windows.Forms.DataGridView grd_centros;
        private System.Windows.Forms.Button btn_agregar_centro;
        private System.Windows.Forms.Button btn_limpiar_centro;
        private System.Windows.Forms.Button btn_salir_centro;
        private System.Windows.Forms.GroupBox grp_esp_centro;
        private System.Windows.Forms.Button btn_agregar_esp_centro;
        private System.Windows.Forms.DataGridView grd_esp_centro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.ComboBox cmb_esp_centro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_centro;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn propio;
        private System.Windows.Forms.MaskedTextBox msk_txt_telefono_centro;
        private System.Windows.Forms.Button btn_eliminar_esp;
    }
}