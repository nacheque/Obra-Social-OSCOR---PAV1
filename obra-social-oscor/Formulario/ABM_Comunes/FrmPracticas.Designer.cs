
namespace obra_social_oscor.Formulario.ABM_Comunes
{
    partial class FrmPracticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPracticas));
            this.grpBox_Pract = new System.Windows.Forms.GroupBox();
            this.txt_Precio_Pract = new System.Windows.Forms.TextBox();
            this.lbl_Precio_Pract = new System.Windows.Forms.Label();
            this.lbl_Descrip_Pract = new System.Windows.Forms.Label();
            this.txt_Nombre_Pract = new System.Windows.Forms.TextBox();
            this.dgv_Pract = new System.Windows.Forms.DataGridView();
            this.IdPractica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Agregar_Pract = new System.Windows.Forms.Button();
            this.btn_Editar_Pract = new System.Windows.Forms.Button();
            this.btn_Eliminar_Pract = new System.Windows.Forms.Button();
            this.btn_Limpiar_Pract = new System.Windows.Forms.Button();
            this.btn_Salir_Pract = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpBox_Pract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pract)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox_Pract
            // 
            this.grpBox_Pract.Controls.Add(this.txt_Precio_Pract);
            this.grpBox_Pract.Controls.Add(this.lbl_Precio_Pract);
            this.grpBox_Pract.Controls.Add(this.lbl_Descrip_Pract);
            this.grpBox_Pract.Controls.Add(this.txt_Nombre_Pract);
            this.grpBox_Pract.Location = new System.Drawing.Point(12, 12);
            this.grpBox_Pract.Name = "grpBox_Pract";
            this.grpBox_Pract.Size = new System.Drawing.Size(332, 109);
            this.grpBox_Pract.TabIndex = 3;
            this.grpBox_Pract.TabStop = false;
            this.grpBox_Pract.Text = "Datos";
            // 
            // txt_Precio_Pract
            // 
            this.txt_Precio_Pract.Location = new System.Drawing.Point(88, 72);
            this.txt_Precio_Pract.Name = "txt_Precio_Pract";
            this.txt_Precio_Pract.Size = new System.Drawing.Size(225, 20);
            this.txt_Precio_Pract.TabIndex = 3;
            // 
            // lbl_Precio_Pract
            // 
            this.lbl_Precio_Pract.AutoSize = true;
            this.lbl_Precio_Pract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio_Pract.Location = new System.Drawing.Point(13, 72);
            this.lbl_Precio_Pract.Name = "lbl_Precio_Pract";
            this.lbl_Precio_Pract.Size = new System.Drawing.Size(57, 20);
            this.lbl_Precio_Pract.TabIndex = 2;
            this.lbl_Precio_Pract.Text = "Precio:";
            // 
            // lbl_Descrip_Pract
            // 
            this.lbl_Descrip_Pract.AutoSize = true;
            this.lbl_Descrip_Pract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descrip_Pract.Location = new System.Drawing.Point(13, 26);
            this.lbl_Descrip_Pract.Name = "lbl_Descrip_Pract";
            this.lbl_Descrip_Pract.Size = new System.Drawing.Size(69, 20);
            this.lbl_Descrip_Pract.TabIndex = 0;
            this.lbl_Descrip_Pract.Text = "Nombre:";
            // 
            // txt_Nombre_Pract
            // 
            this.txt_Nombre_Pract.Location = new System.Drawing.Point(88, 28);
            this.txt_Nombre_Pract.Name = "txt_Nombre_Pract";
            this.txt_Nombre_Pract.Size = new System.Drawing.Size(225, 20);
            this.txt_Nombre_Pract.TabIndex = 1;
            this.txt_Nombre_Pract.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_Pract_Key_Press);
            // 
            // dgv_Pract
            // 
            this.dgv_Pract.AllowUserToAddRows = false;
            this.dgv_Pract.AllowUserToDeleteRows = false;
            this.dgv_Pract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPractica,
            this.Descripcion,
            this.PrecioPract});
            this.dgv_Pract.Location = new System.Drawing.Point(12, 142);
            this.dgv_Pract.Name = "dgv_Pract";
            this.dgv_Pract.ReadOnly = true;
            this.dgv_Pract.Size = new System.Drawing.Size(329, 200);
            this.dgv_Pract.TabIndex = 4;
            this.dgv_Pract.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pract_Cell_Click);
            // 
            // IdPractica
            // 
            this.IdPractica.DataPropertyName = "ID_PRACTICA";
            this.IdPractica.HeaderText = "ID";
            this.IdPractica.Name = "IdPractica";
            this.IdPractica.ReadOnly = true;
            this.IdPractica.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "DESCRIPCION";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // PrecioPract
            // 
            this.PrecioPract.DataPropertyName = "PRECIO";
            this.PrecioPract.HeaderText = "Precio";
            this.PrecioPract.Name = "PrecioPract";
            this.PrecioPract.ReadOnly = true;
            // 
            // btn_Agregar_Pract
            // 
            this.btn_Agregar_Pract.BackgroundImage = global::obra_social_oscor.Properties.Resources.agregar;
            this.btn_Agregar_Pract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar_Pract.Location = new System.Drawing.Point(12, 371);
            this.btn_Agregar_Pract.Name = "btn_Agregar_Pract";
            this.btn_Agregar_Pract.Size = new System.Drawing.Size(44, 38);
            this.btn_Agregar_Pract.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_Agregar_Pract, "Agregar Practica");
            this.btn_Agregar_Pract.UseVisualStyleBackColor = true;
            this.btn_Agregar_Pract.Click += new System.EventHandler(this.btn_Agregar_Pract_Click);
            // 
            // btn_Editar_Pract
            // 
            this.btn_Editar_Pract.BackgroundImage = global::obra_social_oscor.Properties.Resources.Editar;
            this.btn_Editar_Pract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Editar_Pract.Location = new System.Drawing.Point(62, 371);
            this.btn_Editar_Pract.Name = "btn_Editar_Pract";
            this.btn_Editar_Pract.Size = new System.Drawing.Size(44, 38);
            this.btn_Editar_Pract.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_Editar_Pract, "Modificar Practica");
            this.btn_Editar_Pract.UseVisualStyleBackColor = true;
            this.btn_Editar_Pract.Click += new System.EventHandler(this.btn_Editar_Pract_Click);
            // 
            // btn_Eliminar_Pract
            // 
            this.btn_Eliminar_Pract.BackgroundImage = global::obra_social_oscor.Properties.Resources.eliminar;
            this.btn_Eliminar_Pract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar_Pract.Location = new System.Drawing.Point(112, 371);
            this.btn_Eliminar_Pract.Name = "btn_Eliminar_Pract";
            this.btn_Eliminar_Pract.Size = new System.Drawing.Size(44, 38);
            this.btn_Eliminar_Pract.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_Eliminar_Pract, "Eliminar Practica");
            this.btn_Eliminar_Pract.UseVisualStyleBackColor = true;
            this.btn_Eliminar_Pract.Click += new System.EventHandler(this.btn_Eliminar_Pract_Click);
            // 
            // btn_Limpiar_Pract
            // 
            this.btn_Limpiar_Pract.Location = new System.Drawing.Point(12, 431);
            this.btn_Limpiar_Pract.Name = "btn_Limpiar_Pract";
            this.btn_Limpiar_Pract.Size = new System.Drawing.Size(112, 23);
            this.btn_Limpiar_Pract.TabIndex = 8;
            this.btn_Limpiar_Pract.Text = "Reiniciar Formulario";
            this.toolTip1.SetToolTip(this.btn_Limpiar_Pract, "Reiniciar campos");
            this.btn_Limpiar_Pract.UseVisualStyleBackColor = true;
            this.btn_Limpiar_Pract.Click += new System.EventHandler(this.btn_Limpiar_Pract_Click);
            // 
            // btn_Salir_Pract
            // 
            this.btn_Salir_Pract.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btn_Salir_Pract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir_Pract.Location = new System.Drawing.Point(300, 416);
            this.btn_Salir_Pract.Name = "btn_Salir_Pract";
            this.btn_Salir_Pract.Size = new System.Drawing.Size(44, 38);
            this.btn_Salir_Pract.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_Salir_Pract, "Salir");
            this.btn_Salir_Pract.UseVisualStyleBackColor = true;
            this.btn_Salir_Pract.Click += new System.EventHandler(this.btn_Salir_Pract_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // FrmPracticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 460);
            this.Controls.Add(this.btn_Salir_Pract);
            this.Controls.Add(this.btn_Limpiar_Pract);
            this.Controls.Add(this.btn_Eliminar_Pract);
            this.Controls.Add(this.btn_Editar_Pract);
            this.Controls.Add(this.btn_Agregar_Pract);
            this.Controls.Add(this.dgv_Pract);
            this.Controls.Add(this.grpBox_Pract);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPracticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practicas";
            this.Load += new System.EventHandler(this.Practicas_Load);
            this.grpBox_Pract.ResumeLayout(false);
            this.grpBox_Pract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_Pract;
        private System.Windows.Forms.Label lbl_Descrip_Pract;
        private System.Windows.Forms.TextBox txt_Nombre_Pract;
        private System.Windows.Forms.DataGridView dgv_Pract;
        private System.Windows.Forms.Button btn_Agregar_Pract;
        private System.Windows.Forms.Button btn_Editar_Pract;
        private System.Windows.Forms.Button btn_Eliminar_Pract;
        private System.Windows.Forms.Button btn_Limpiar_Pract;
        private System.Windows.Forms.Button btn_Salir_Pract;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPractica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPract;
        private System.Windows.Forms.TextBox txt_Precio_Pract;
        private System.Windows.Forms.Label lbl_Precio_Pract;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}