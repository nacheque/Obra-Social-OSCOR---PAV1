namespace obra_social_oscor.Formulario.ABM_Comunes
{
    partial class frm_Tipo_Afiliado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Tipo_Afiliado));
            this.btn_Limpiar_Tipo_Afiliado = new System.Windows.Forms.Button();
            this.grd_Tipo_Afiliado = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Tipo_Afiliado_Descripcion = new System.Windows.Forms.Label();
            this.txt_Nombre_Tipo_Afiliado = new System.Windows.Forms.TextBox();
            this.btn_Salir_Tipo_Afiliado = new System.Windows.Forms.Button();
            this.btn_Eliminar_Tipo_Afiliado = new System.Windows.Forms.Button();
            this.btn_Editar_Tipo_Afiliado = new System.Windows.Forms.Button();
            this.btn_Agregar_Tipo_Afiliado = new System.Windows.Forms.Button();
            this.tt_tipo_afiliado = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Tipo_Afiliado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Limpiar_Tipo_Afiliado
            // 
            this.btn_Limpiar_Tipo_Afiliado.Location = new System.Drawing.Point(12, 338);
            this.btn_Limpiar_Tipo_Afiliado.Name = "btn_Limpiar_Tipo_Afiliado";
            this.btn_Limpiar_Tipo_Afiliado.Size = new System.Drawing.Size(112, 23);
            this.btn_Limpiar_Tipo_Afiliado.TabIndex = 13;
            this.btn_Limpiar_Tipo_Afiliado.Text = "Reiniciar Formulario";
            this.btn_Limpiar_Tipo_Afiliado.UseVisualStyleBackColor = true;
            this.btn_Limpiar_Tipo_Afiliado.Click += new System.EventHandler(this.btn_Limpiar_Tipo_Afiliado_Click);
            // 
            // grd_Tipo_Afiliado
            // 
            this.grd_Tipo_Afiliado.AllowUserToAddRows = false;
            this.grd_Tipo_Afiliado.AllowUserToDeleteRows = false;
            this.grd_Tipo_Afiliado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Tipo_Afiliado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion});
            this.grd_Tipo_Afiliado.Location = new System.Drawing.Point(12, 105);
            this.grd_Tipo_Afiliado.Name = "grd_Tipo_Afiliado";
            this.grd_Tipo_Afiliado.ReadOnly = true;
            this.grd_Tipo_Afiliado.Size = new System.Drawing.Size(332, 183);
            this.grd_Tipo_Afiliado.TabIndex = 10;
            this.grd_Tipo_Afiliado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Tipo_Afiliado_CellClick);
            this.grd_Tipo_Afiliado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Tipo_Afiliado_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Tipo_Afiliado_Descripcion);
            this.groupBox1.Controls.Add(this.txt_Nombre_Tipo_Afiliado);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 74);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // lbl_Tipo_Afiliado_Descripcion
            // 
            this.lbl_Tipo_Afiliado_Descripcion.AutoSize = true;
            this.lbl_Tipo_Afiliado_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo_Afiliado_Descripcion.Location = new System.Drawing.Point(13, 26);
            this.lbl_Tipo_Afiliado_Descripcion.Name = "lbl_Tipo_Afiliado_Descripcion";
            this.lbl_Tipo_Afiliado_Descripcion.Size = new System.Drawing.Size(69, 20);
            this.lbl_Tipo_Afiliado_Descripcion.TabIndex = 0;
            this.lbl_Tipo_Afiliado_Descripcion.Text = "Nombre:";
            // 
            // txt_Nombre_Tipo_Afiliado
            // 
            this.txt_Nombre_Tipo_Afiliado.Location = new System.Drawing.Point(88, 28);
            this.txt_Nombre_Tipo_Afiliado.Name = "txt_Nombre_Tipo_Afiliado";
            this.txt_Nombre_Tipo_Afiliado.Size = new System.Drawing.Size(225, 20);
            this.txt_Nombre_Tipo_Afiliado.TabIndex = 1;
            this.txt_Nombre_Tipo_Afiliado.TextChanged += new System.EventHandler(this.txt_Nombre_Tipo_Afiliado_TextChanged);
            this.txt_Nombre_Tipo_Afiliado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_Tipo_Afiliado_KeyPress);
            // 
            // btn_Salir_Tipo_Afiliado
            // 
            this.btn_Salir_Tipo_Afiliado.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btn_Salir_Tipo_Afiliado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir_Tipo_Afiliado.Location = new System.Drawing.Point(305, 323);
            this.btn_Salir_Tipo_Afiliado.Name = "btn_Salir_Tipo_Afiliado";
            this.btn_Salir_Tipo_Afiliado.Size = new System.Drawing.Size(44, 38);
            this.btn_Salir_Tipo_Afiliado.TabIndex = 12;
            this.tt_tipo_afiliado.SetToolTip(this.btn_Salir_Tipo_Afiliado, "Salir");
            this.btn_Salir_Tipo_Afiliado.UseVisualStyleBackColor = true;
            this.btn_Salir_Tipo_Afiliado.Click += new System.EventHandler(this.btn_Salir_Tipo_Afiliado_Click);
            // 
            // btn_Eliminar_Tipo_Afiliado
            // 
            this.btn_Eliminar_Tipo_Afiliado.BackgroundImage = global::obra_social_oscor.Properties.Resources.eliminar;
            this.btn_Eliminar_Tipo_Afiliado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar_Tipo_Afiliado.Location = new System.Drawing.Point(112, 294);
            this.btn_Eliminar_Tipo_Afiliado.Name = "btn_Eliminar_Tipo_Afiliado";
            this.btn_Eliminar_Tipo_Afiliado.Size = new System.Drawing.Size(44, 38);
            this.btn_Eliminar_Tipo_Afiliado.TabIndex = 11;
            this.tt_tipo_afiliado.SetToolTip(this.btn_Eliminar_Tipo_Afiliado, "Eliminar tipo de afiliado");
            this.btn_Eliminar_Tipo_Afiliado.UseVisualStyleBackColor = true;
            this.btn_Eliminar_Tipo_Afiliado.Click += new System.EventHandler(this.btn_Eliminar_Tipo_Afiliado_Click);
            // 
            // btn_Editar_Tipo_Afiliado
            // 
            this.btn_Editar_Tipo_Afiliado.BackgroundImage = global::obra_social_oscor.Properties.Resources.Editar;
            this.btn_Editar_Tipo_Afiliado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Editar_Tipo_Afiliado.Location = new System.Drawing.Point(62, 294);
            this.btn_Editar_Tipo_Afiliado.Name = "btn_Editar_Tipo_Afiliado";
            this.btn_Editar_Tipo_Afiliado.Size = new System.Drawing.Size(44, 38);
            this.btn_Editar_Tipo_Afiliado.TabIndex = 9;
            this.tt_tipo_afiliado.SetToolTip(this.btn_Editar_Tipo_Afiliado, "Editar tipo de afiliado");
            this.btn_Editar_Tipo_Afiliado.UseVisualStyleBackColor = true;
            this.btn_Editar_Tipo_Afiliado.Click += new System.EventHandler(this.btn_Editar_Tipo_Afiliado_Click);
            // 
            // btn_Agregar_Tipo_Afiliado
            // 
            this.btn_Agregar_Tipo_Afiliado.BackgroundImage = global::obra_social_oscor.Properties.Resources.agregar;
            this.btn_Agregar_Tipo_Afiliado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar_Tipo_Afiliado.Location = new System.Drawing.Point(12, 294);
            this.btn_Agregar_Tipo_Afiliado.Name = "btn_Agregar_Tipo_Afiliado";
            this.btn_Agregar_Tipo_Afiliado.Size = new System.Drawing.Size(44, 38);
            this.btn_Agregar_Tipo_Afiliado.TabIndex = 7;
            this.tt_tipo_afiliado.SetToolTip(this.btn_Agregar_Tipo_Afiliado, "Agregar tipo de afiliado");
            this.btn_Agregar_Tipo_Afiliado.UseVisualStyleBackColor = true;
            this.btn_Agregar_Tipo_Afiliado.Click += new System.EventHandler(this.btn_Agregar_Tipo_Afiliado_Click);
            // 
            // frm_Tipo_Afiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 372);
            this.Controls.Add(this.btn_Limpiar_Tipo_Afiliado);
            this.Controls.Add(this.btn_Salir_Tipo_Afiliado);
            this.Controls.Add(this.btn_Eliminar_Tipo_Afiliado);
            this.Controls.Add(this.btn_Editar_Tipo_Afiliado);
            this.Controls.Add(this.btn_Agregar_Tipo_Afiliado);
            this.Controls.Add(this.grd_Tipo_Afiliado);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Tipo_Afiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Afiliado";
            this.Load += new System.EventHandler(this.frm_Tipo_Afiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Tipo_Afiliado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Limpiar_Tipo_Afiliado;
        private System.Windows.Forms.Button btn_Salir_Tipo_Afiliado;
        private System.Windows.Forms.Button btn_Eliminar_Tipo_Afiliado;
        private System.Windows.Forms.Button btn_Editar_Tipo_Afiliado;
        private System.Windows.Forms.Button btn_Agregar_Tipo_Afiliado;
        private System.Windows.Forms.DataGridView grd_Tipo_Afiliado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Tipo_Afiliado_Descripcion;
        private System.Windows.Forms.TextBox txt_Nombre_Tipo_Afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.ToolTip tt_tipo_afiliado;
    }
}