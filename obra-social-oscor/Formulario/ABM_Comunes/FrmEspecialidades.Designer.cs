namespace obra_social_oscor.Formulario.ABM_Comunes
{
    partial class frm_Especialidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Especialidades));
            this.lbl_Especialidades = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Nombre_Esp = new System.Windows.Forms.TextBox();
            this.grd_Esp = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Salir_Esp = new System.Windows.Forms.Button();
            this.btn_Limpiar_Esp = new System.Windows.Forms.Button();
            this.btn_Eliminar_Esp = new System.Windows.Forms.Button();
            this.btn_Editar_Esp = new System.Windows.Forms.Button();
            this.btn_Agregar_Esp = new System.Windows.Forms.Button();
            this.tt_Esp = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Esp)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Especialidades
            // 
            this.lbl_Especialidades.AutoSize = true;
            this.lbl_Especialidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Especialidades.Location = new System.Drawing.Point(13, 26);
            this.lbl_Especialidades.Name = "lbl_Especialidades";
            this.lbl_Especialidades.Size = new System.Drawing.Size(69, 20);
            this.lbl_Especialidades.TabIndex = 0;
            this.lbl_Especialidades.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Especialidades);
            this.groupBox1.Controls.Add(this.txt_Nombre_Esp);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txt_Nombre_Esp
            // 
            this.txt_Nombre_Esp.Location = new System.Drawing.Point(88, 28);
            this.txt_Nombre_Esp.Name = "txt_Nombre_Esp";
            this.txt_Nombre_Esp.Size = new System.Drawing.Size(225, 20);
            this.txt_Nombre_Esp.TabIndex = 1;
            this.txt_Nombre_Esp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_Esp_KeyPress);
            // 
            // grd_Esp
            // 
            this.grd_Esp.AllowUserToAddRows = false;
            this.grd_Esp.AllowUserToDeleteRows = false;
            this.grd_Esp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Esp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre});
            this.grd_Esp.Location = new System.Drawing.Point(12, 106);
            this.grd_Esp.Name = "grd_Esp";
            this.grd_Esp.ReadOnly = true;
            this.grd_Esp.Size = new System.Drawing.Size(332, 183);
            this.grd_Esp.TabIndex = 3;
            this.grd_Esp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Esp_CellClick);
            this.grd_Esp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Esp_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // btn_Salir_Esp
            // 
            this.btn_Salir_Esp.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btn_Salir_Esp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir_Esp.Location = new System.Drawing.Point(305, 324);
            this.btn_Salir_Esp.Name = "btn_Salir_Esp";
            this.btn_Salir_Esp.Size = new System.Drawing.Size(44, 38);
            this.btn_Salir_Esp.TabIndex = 5;
            this.tt_Esp.SetToolTip(this.btn_Salir_Esp, "Salir del Formulario");
            this.btn_Salir_Esp.UseVisualStyleBackColor = true;
            this.btn_Salir_Esp.Click += new System.EventHandler(this.btn_Salir_Esp_Click);
            // 
            // btn_Limpiar_Esp
            // 
            this.btn_Limpiar_Esp.Location = new System.Drawing.Point(12, 339);
            this.btn_Limpiar_Esp.Name = "btn_Limpiar_Esp";
            this.btn_Limpiar_Esp.Size = new System.Drawing.Size(112, 23);
            this.btn_Limpiar_Esp.TabIndex = 6;
            this.btn_Limpiar_Esp.Text = "Reiniciar Formulario";
            this.tt_Esp.SetToolTip(this.btn_Limpiar_Esp, "Limpiar los campos de datos");
            this.btn_Limpiar_Esp.UseVisualStyleBackColor = true;
            this.btn_Limpiar_Esp.Click += new System.EventHandler(this.btn_Limpiar_Esp_Click);
            // 
            // btn_Eliminar_Esp
            // 
            this.btn_Eliminar_Esp.BackgroundImage = global::obra_social_oscor.Properties.Resources.eliminar;
            this.btn_Eliminar_Esp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar_Esp.Location = new System.Drawing.Point(112, 295);
            this.btn_Eliminar_Esp.Name = "btn_Eliminar_Esp";
            this.btn_Eliminar_Esp.Size = new System.Drawing.Size(44, 38);
            this.btn_Eliminar_Esp.TabIndex = 4;
            this.tt_Esp.SetToolTip(this.btn_Eliminar_Esp, "Eliminar Especialidad");
            this.btn_Eliminar_Esp.UseVisualStyleBackColor = true;
            this.btn_Eliminar_Esp.Click += new System.EventHandler(this.btn_Eliminar_Esp_Click);
            // 
            // btn_Editar_Esp
            // 
            this.btn_Editar_Esp.BackgroundImage = global::obra_social_oscor.Properties.Resources.Editar;
            this.btn_Editar_Esp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Editar_Esp.Location = new System.Drawing.Point(62, 295);
            this.btn_Editar_Esp.Name = "btn_Editar_Esp";
            this.btn_Editar_Esp.Size = new System.Drawing.Size(44, 38);
            this.btn_Editar_Esp.TabIndex = 3;
            this.tt_Esp.SetToolTip(this.btn_Editar_Esp, "Editar Especialidad");
            this.btn_Editar_Esp.UseVisualStyleBackColor = true;
            this.btn_Editar_Esp.Click += new System.EventHandler(this.btn_Editar_Esp_Click);
            // 
            // btn_Agregar_Esp
            // 
            this.btn_Agregar_Esp.BackgroundImage = global::obra_social_oscor.Properties.Resources.agregar;
            this.btn_Agregar_Esp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar_Esp.Location = new System.Drawing.Point(12, 295);
            this.btn_Agregar_Esp.Name = "btn_Agregar_Esp";
            this.btn_Agregar_Esp.Size = new System.Drawing.Size(44, 38);
            this.btn_Agregar_Esp.TabIndex = 2;
            this.tt_Esp.SetToolTip(this.btn_Agregar_Esp, "Agregar Especialidad");
            this.btn_Agregar_Esp.UseVisualStyleBackColor = true;
            this.btn_Agregar_Esp.Click += new System.EventHandler(this.btn_Agregar_Esp_Click);
            // 
            // frm_Especialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(361, 372);
            this.Controls.Add(this.btn_Limpiar_Esp);
            this.Controls.Add(this.btn_Salir_Esp);
            this.Controls.Add(this.btn_Eliminar_Esp);
            this.Controls.Add(this.btn_Editar_Esp);
            this.Controls.Add(this.btn_Agregar_Esp);
            this.Controls.Add(this.grd_Esp);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Especialidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialidades";
            this.Load += new System.EventHandler(this.frm_Especialidades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Esp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Especialidades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grd_Esp;
        private System.Windows.Forms.Button btn_Agregar_Esp;
        private System.Windows.Forms.Button btn_Editar_Esp;
        private System.Windows.Forms.Button btn_Eliminar_Esp;
        private System.Windows.Forms.Button btn_Salir_Esp;
        private System.Windows.Forms.Button btn_Limpiar_Esp;
        private System.Windows.Forms.ToolTip tt_Esp;
        private System.Windows.Forms.TextBox txt_Nombre_Esp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}