namespace obra_social_oscor.Formulario.ABM_Comunes
{
    partial class FrmProfesionales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesionales));
            this.grd_Profesionales = new System.Windows.Forms.DataGridView();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_limpiar_profesional = new System.Windows.Forms.Button();
            this.btn_salir_profesional = new System.Windows.Forms.Button();
            this.btn_agregar_profesional = new System.Windows.Forms.Button();
            this.btn_editar_profesional = new System.Windows.Forms.Button();
            this.btn_borrar_profesional = new System.Windows.Forms.Button();
            this.grp_box_profesionales = new System.Windows.Forms.GroupBox();
            this.msk_txt_telefono_prof = new System.Windows.Forms.MaskedTextBox();
            this.lbl_telefono_prof = new System.Windows.Forms.Label();
            this.cmb_localidad_prof = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_barrios_prof = new System.Windows.Forms.ComboBox();
            this.lbl_barrio_prof = new System.Windows.Forms.Label();
            this.txt_nro_calle_prof = new System.Windows.Forms.TextBox();
            this.lbl_nro_calle_prof = new System.Windows.Forms.Label();
            this.txt_calle_profesional = new System.Windows.Forms.TextBox();
            this.lbl_calle_profesional = new System.Windows.Forms.Label();
            this.txt_nombre_profesional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_apellido_profesional = new System.Windows.Forms.TextBox();
            this.lbl_apellido_profesional = new System.Windows.Forms.Label();
            this.tt_profesionales = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Profesionales)).BeginInit();
            this.grp_box_profesionales.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_Profesionales
            // 
            this.grd_Profesionales.AllowUserToAddRows = false;
            this.grd_Profesionales.AllowUserToDeleteRows = false;
            this.grd_Profesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Profesionales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.apellido,
            this.nombre,
            this.calle,
            this.nro_calle,
            this.barrio,
            this.id_barrio,
            this.localidad,
            this.id_localidad,
            this.Telefono});
            this.grd_Profesionales.Location = new System.Drawing.Point(12, 112);
            this.grd_Profesionales.Name = "grd_Profesionales";
            this.grd_Profesionales.ReadOnly = true;
            this.grd_Profesionales.Size = new System.Drawing.Size(931, 320);
            this.grd_Profesionales.TabIndex = 87;
            this.grd_Profesionales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Profesionales_CellClick);
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            this.matricula.Visible = false;
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
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            this.calle.Width = 120;
            // 
            // nro_calle
            // 
            this.nro_calle.HeaderText = "Nro. Calle";
            this.nro_calle.Name = "nro_calle";
            this.nro_calle.ReadOnly = true;
            this.nro_calle.Width = 60;
            // 
            // barrio
            // 
            this.barrio.HeaderText = "Barrio";
            this.barrio.Name = "barrio";
            this.barrio.ReadOnly = true;
            this.barrio.Width = 150;
            // 
            // id_barrio
            // 
            this.id_barrio.HeaderText = "Id Barrio";
            this.id_barrio.Name = "id_barrio";
            this.id_barrio.ReadOnly = true;
            this.id_barrio.Visible = false;
            // 
            // localidad
            // 
            this.localidad.HeaderText = "Localidad";
            this.localidad.Name = "localidad";
            this.localidad.ReadOnly = true;
            this.localidad.Width = 150;
            // 
            // id_localidad
            // 
            this.id_localidad.HeaderText = "Id Localidad";
            this.id_localidad.Name = "id_localidad";
            this.id_localidad.ReadOnly = true;
            this.id_localidad.Visible = false;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 150;
            // 
            // btn_limpiar_profesional
            // 
            this.btn_limpiar_profesional.Location = new System.Drawing.Point(195, 470);
            this.btn_limpiar_profesional.Name = "btn_limpiar_profesional";
            this.btn_limpiar_profesional.Size = new System.Drawing.Size(112, 23);
            this.btn_limpiar_profesional.TabIndex = 97;
            this.btn_limpiar_profesional.Text = "Reiniciar Formulario";
            this.tt_profesionales.SetToolTip(this.btn_limpiar_profesional, "Limpiar los datos");
            this.btn_limpiar_profesional.UseVisualStyleBackColor = true;
            this.btn_limpiar_profesional.Click += new System.EventHandler(this.btn_limpiar_profesional_Click);
            // 
            // btn_salir_profesional
            // 
            this.btn_salir_profesional.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir_profesional.BackgroundImage")));
            this.btn_salir_profesional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir_profesional.Location = new System.Drawing.Point(893, 443);
            this.btn_salir_profesional.Name = "btn_salir_profesional";
            this.btn_salir_profesional.Size = new System.Drawing.Size(50, 50);
            this.btn_salir_profesional.TabIndex = 96;
            this.tt_profesionales.SetToolTip(this.btn_salir_profesional, "Salir");
            this.btn_salir_profesional.UseVisualStyleBackColor = true;
            this.btn_salir_profesional.Click += new System.EventHandler(this.btn_salir_profesional_Click);
            // 
            // btn_agregar_profesional
            // 
            this.btn_agregar_profesional.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregar_profesional.BackgroundImage")));
            this.btn_agregar_profesional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar_profesional.Location = new System.Drawing.Point(15, 443);
            this.btn_agregar_profesional.Name = "btn_agregar_profesional";
            this.btn_agregar_profesional.Size = new System.Drawing.Size(50, 50);
            this.btn_agregar_profesional.TabIndex = 95;
            this.tt_profesionales.SetToolTip(this.btn_agregar_profesional, "Agregar Profesional");
            this.btn_agregar_profesional.UseVisualStyleBackColor = true;
            this.btn_agregar_profesional.Click += new System.EventHandler(this.btn_agregar_profesional_Click);
            // 
            // btn_editar_profesional
            // 
            this.btn_editar_profesional.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar_profesional.BackgroundImage")));
            this.btn_editar_profesional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar_profesional.Location = new System.Drawing.Point(71, 443);
            this.btn_editar_profesional.Name = "btn_editar_profesional";
            this.btn_editar_profesional.Size = new System.Drawing.Size(50, 50);
            this.btn_editar_profesional.TabIndex = 94;
            this.tt_profesionales.SetToolTip(this.btn_editar_profesional, "Editar Profesional");
            this.btn_editar_profesional.UseVisualStyleBackColor = true;
            this.btn_editar_profesional.Click += new System.EventHandler(this.btn_editar_profesional_Click);
            // 
            // btn_borrar_profesional
            // 
            this.btn_borrar_profesional.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_borrar_profesional.BackgroundImage")));
            this.btn_borrar_profesional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar_profesional.Location = new System.Drawing.Point(127, 443);
            this.btn_borrar_profesional.Name = "btn_borrar_profesional";
            this.btn_borrar_profesional.Size = new System.Drawing.Size(50, 50);
            this.btn_borrar_profesional.TabIndex = 93;
            this.tt_profesionales.SetToolTip(this.btn_borrar_profesional, "Eliminar Profesional");
            this.btn_borrar_profesional.UseVisualStyleBackColor = true;
            this.btn_borrar_profesional.Click += new System.EventHandler(this.btn_borrar_profesional_Click);
            // 
            // grp_box_profesionales
            // 
            this.grp_box_profesionales.Controls.Add(this.msk_txt_telefono_prof);
            this.grp_box_profesionales.Controls.Add(this.lbl_telefono_prof);
            this.grp_box_profesionales.Controls.Add(this.cmb_localidad_prof);
            this.grp_box_profesionales.Controls.Add(this.label2);
            this.grp_box_profesionales.Controls.Add(this.cmb_barrios_prof);
            this.grp_box_profesionales.Controls.Add(this.lbl_barrio_prof);
            this.grp_box_profesionales.Controls.Add(this.txt_nro_calle_prof);
            this.grp_box_profesionales.Controls.Add(this.lbl_nro_calle_prof);
            this.grp_box_profesionales.Controls.Add(this.txt_calle_profesional);
            this.grp_box_profesionales.Controls.Add(this.lbl_calle_profesional);
            this.grp_box_profesionales.Controls.Add(this.txt_nombre_profesional);
            this.grp_box_profesionales.Controls.Add(this.label1);
            this.grp_box_profesionales.Controls.Add(this.txt_apellido_profesional);
            this.grp_box_profesionales.Controls.Add(this.lbl_apellido_profesional);
            this.grp_box_profesionales.Location = new System.Drawing.Point(12, 4);
            this.grp_box_profesionales.Name = "grp_box_profesionales";
            this.grp_box_profesionales.Size = new System.Drawing.Size(931, 102);
            this.grp_box_profesionales.TabIndex = 98;
            this.grp_box_profesionales.TabStop = false;
            this.grp_box_profesionales.Text = "Datos";
            this.grp_box_profesionales.Enter += new System.EventHandler(this.grp_box_profesionales_Enter);
            // 
            // msk_txt_telefono_prof
            // 
            this.msk_txt_telefono_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_txt_telefono_prof.Location = new System.Drawing.Point(612, 57);
            this.msk_txt_telefono_prof.Mask = "9999999999999";
            this.msk_txt_telefono_prof.Name = "msk_txt_telefono_prof";
            this.msk_txt_telefono_prof.Size = new System.Drawing.Size(167, 23);
            this.msk_txt_telefono_prof.TabIndex = 88;
            this.msk_txt_telefono_prof.ValidatingType = typeof(int);
            // 
            // lbl_telefono_prof
            // 
            this.lbl_telefono_prof.AutoSize = true;
            this.lbl_telefono_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono_prof.Location = new System.Drawing.Point(538, 60);
            this.lbl_telefono_prof.Name = "lbl_telefono_prof";
            this.lbl_telefono_prof.Size = new System.Drawing.Size(68, 17);
            this.lbl_telefono_prof.TabIndex = 87;
            this.lbl_telefono_prof.Text = "Telefono:";
            // 
            // cmb_localidad_prof
            // 
            this.cmb_localidad_prof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_localidad_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_localidad_prof.FormattingEnabled = true;
            this.cmb_localidad_prof.Location = new System.Drawing.Point(357, 57);
            this.cmb_localidad_prof.Name = "cmb_localidad_prof";
            this.cmb_localidad_prof.Size = new System.Drawing.Size(167, 24);
            this.cmb_localidad_prof.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Localidad:";
            // 
            // cmb_barrios_prof
            // 
            this.cmb_barrios_prof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_barrios_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_barrios_prof.FormattingEnabled = true;
            this.cmb_barrios_prof.Location = new System.Drawing.Point(74, 58);
            this.cmb_barrios_prof.Name = "cmb_barrios_prof";
            this.cmb_barrios_prof.Size = new System.Drawing.Size(167, 24);
            this.cmb_barrios_prof.TabIndex = 84;
            // 
            // lbl_barrio_prof
            // 
            this.lbl_barrio_prof.AutoSize = true;
            this.lbl_barrio_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barrio_prof.Location = new System.Drawing.Point(18, 63);
            this.lbl_barrio_prof.Name = "lbl_barrio_prof";
            this.lbl_barrio_prof.Size = new System.Drawing.Size(50, 17);
            this.lbl_barrio_prof.TabIndex = 83;
            this.lbl_barrio_prof.Text = "Barrio:";
            // 
            // txt_nro_calle_prof
            // 
            this.txt_nro_calle_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nro_calle_prof.Location = new System.Drawing.Point(865, 24);
            this.txt_nro_calle_prof.Name = "txt_nro_calle_prof";
            this.txt_nro_calle_prof.Size = new System.Drawing.Size(58, 23);
            this.txt_nro_calle_prof.TabIndex = 82;
            this.txt_nro_calle_prof.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nro_calle_prof_KeyPress);
            // 
            // lbl_nro_calle_prof
            // 
            this.lbl_nro_calle_prof.AutoSize = true;
            this.lbl_nro_calle_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nro_calle_prof.Location = new System.Drawing.Point(785, 27);
            this.lbl_nro_calle_prof.Name = "lbl_nro_calle_prof";
            this.lbl_nro_calle_prof.Size = new System.Drawing.Size(74, 17);
            this.lbl_nro_calle_prof.TabIndex = 81;
            this.lbl_nro_calle_prof.Text = "Nro. Calle:";
            // 
            // txt_calle_profesional
            // 
            this.txt_calle_profesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_calle_profesional.Location = new System.Drawing.Point(612, 24);
            this.txt_calle_profesional.Name = "txt_calle_profesional";
            this.txt_calle_profesional.Size = new System.Drawing.Size(167, 23);
            this.txt_calle_profesional.TabIndex = 80;
            this.txt_calle_profesional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_calle_profesional_KeyPress);
            // 
            // lbl_calle_profesional
            // 
            this.lbl_calle_profesional.AutoSize = true;
            this.lbl_calle_profesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calle_profesional.Location = new System.Drawing.Point(563, 27);
            this.lbl_calle_profesional.Name = "lbl_calle_profesional";
            this.lbl_calle_profesional.Size = new System.Drawing.Size(43, 17);
            this.lbl_calle_profesional.TabIndex = 79;
            this.lbl_calle_profesional.Text = "Calle:";
            // 
            // txt_nombre_profesional
            // 
            this.txt_nombre_profesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_profesional.Location = new System.Drawing.Point(357, 24);
            this.txt_nombre_profesional.Name = "txt_nombre_profesional";
            this.txt_nombre_profesional.Size = new System.Drawing.Size(167, 23);
            this.txt_nombre_profesional.TabIndex = 78;
            this.txt_nombre_profesional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_profesional_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 77;
            this.label1.Text = "Nombre:";
            // 
            // txt_apellido_profesional
            // 
            this.txt_apellido_profesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_profesional.Location = new System.Drawing.Point(74, 24);
            this.txt_apellido_profesional.Name = "txt_apellido_profesional";
            this.txt_apellido_profesional.Size = new System.Drawing.Size(167, 23);
            this.txt_apellido_profesional.TabIndex = 76;
            this.txt_apellido_profesional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_profesional_KeyPress);
            // 
            // lbl_apellido_profesional
            // 
            this.lbl_apellido_profesional.AutoSize = true;
            this.lbl_apellido_profesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido_profesional.Location = new System.Drawing.Point(6, 27);
            this.lbl_apellido_profesional.Name = "lbl_apellido_profesional";
            this.lbl_apellido_profesional.Size = new System.Drawing.Size(62, 17);
            this.lbl_apellido_profesional.TabIndex = 75;
            this.lbl_apellido_profesional.Text = "Apellido:";
            // 
            // FrmProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 501);
            this.Controls.Add(this.grp_box_profesionales);
            this.Controls.Add(this.btn_limpiar_profesional);
            this.Controls.Add(this.btn_salir_profesional);
            this.Controls.Add(this.btn_agregar_profesional);
            this.Controls.Add(this.btn_editar_profesional);
            this.Controls.Add(this.btn_borrar_profesional);
            this.Controls.Add(this.grd_Profesionales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProfesionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesionales";
            this.Load += new System.EventHandler(this.FrmProfesionales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Profesionales)).EndInit();
            this.grp_box_profesionales.ResumeLayout(false);
            this.grp_box_profesionales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Profesionales;
        private System.Windows.Forms.Button btn_limpiar_profesional;
        private System.Windows.Forms.Button btn_salir_profesional;
        private System.Windows.Forms.Button btn_agregar_profesional;
        private System.Windows.Forms.Button btn_editar_profesional;
        private System.Windows.Forms.Button btn_borrar_profesional;
        private System.Windows.Forms.GroupBox grp_box_profesionales;
        private System.Windows.Forms.Label lbl_apellido_profesional;
        private System.Windows.Forms.TextBox txt_nro_calle_prof;
        private System.Windows.Forms.Label lbl_nro_calle_prof;
        private System.Windows.Forms.TextBox txt_calle_profesional;
        private System.Windows.Forms.Label lbl_calle_profesional;
        private System.Windows.Forms.TextBox txt_nombre_profesional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_apellido_profesional;
        private System.Windows.Forms.Label lbl_telefono_prof;
        private System.Windows.Forms.ComboBox cmb_localidad_prof;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_barrios_prof;
        private System.Windows.Forms.Label lbl_barrio_prof;
        private System.Windows.Forms.ToolTip tt_profesionales;
        private System.Windows.Forms.MaskedTextBox msk_txt_telefono_prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}