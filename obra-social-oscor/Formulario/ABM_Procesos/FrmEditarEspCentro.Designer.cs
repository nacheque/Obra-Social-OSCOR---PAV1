namespace obra_social_oscor.Formulario.ABM_Procesos
{
    partial class FrmEditarEspCentro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarEspCentro));
            this.grp_esp_centro = new System.Windows.Forms.GroupBox();
            this.btn_eliminar_esp_editar = new System.Windows.Forms.Button();
            this.btn_agregar_esp_centro_editar = new System.Windows.Forms.Button();
            this.grd_esp_centro_editar = new System.Windows.Forms.DataGridView();
            this.id_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_esp_centro_editar = new System.Windows.Forms.ComboBox();
            this.btn_salir_centro_esp = new System.Windows.Forms.Button();
            this.grp_esp_centro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_esp_centro_editar)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_esp_centro
            // 
            this.grp_esp_centro.Controls.Add(this.btn_eliminar_esp_editar);
            this.grp_esp_centro.Controls.Add(this.btn_agregar_esp_centro_editar);
            this.grp_esp_centro.Controls.Add(this.grd_esp_centro_editar);
            this.grp_esp_centro.Controls.Add(this.cmb_esp_centro_editar);
            this.grp_esp_centro.Location = new System.Drawing.Point(12, 12);
            this.grp_esp_centro.Name = "grp_esp_centro";
            this.grp_esp_centro.Size = new System.Drawing.Size(324, 250);
            this.grp_esp_centro.TabIndex = 110;
            this.grp_esp_centro.TabStop = false;
            this.grp_esp_centro.Text = "Especialidades del centro";
            // 
            // btn_eliminar_esp_editar
            // 
            this.btn_eliminar_esp_editar.Location = new System.Drawing.Point(6, 53);
            this.btn_eliminar_esp_editar.Name = "btn_eliminar_esp_editar";
            this.btn_eliminar_esp_editar.Size = new System.Drawing.Size(73, 23);
            this.btn_eliminar_esp_editar.TabIndex = 112;
            this.btn_eliminar_esp_editar.Text = "Eliminar";
            this.btn_eliminar_esp_editar.UseVisualStyleBackColor = true;
            this.btn_eliminar_esp_editar.Click += new System.EventHandler(this.btn_eliminar_esp_editar_Click);
            // 
            // btn_agregar_esp_centro_editar
            // 
            this.btn_agregar_esp_centro_editar.Location = new System.Drawing.Point(6, 19);
            this.btn_agregar_esp_centro_editar.Name = "btn_agregar_esp_centro_editar";
            this.btn_agregar_esp_centro_editar.Size = new System.Drawing.Size(73, 23);
            this.btn_agregar_esp_centro_editar.TabIndex = 95;
            this.btn_agregar_esp_centro_editar.Text = "Agregar";
            this.btn_agregar_esp_centro_editar.UseVisualStyleBackColor = true;
            this.btn_agregar_esp_centro_editar.Click += new System.EventHandler(this.btn_agregar_esp_centro_editar_Click);
            // 
            // grd_esp_centro_editar
            // 
            this.grd_esp_centro_editar.AllowUserToAddRows = false;
            this.grd_esp_centro_editar.AllowUserToDeleteRows = false;
            this.grd_esp_centro_editar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_esp_centro_editar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_especialidad,
            this.nombre});
            this.grd_esp_centro_editar.Location = new System.Drawing.Point(6, 82);
            this.grd_esp_centro_editar.Name = "grd_esp_centro_editar";
            this.grd_esp_centro_editar.ReadOnly = true;
            this.grd_esp_centro_editar.Size = new System.Drawing.Size(312, 162);
            this.grd_esp_centro_editar.TabIndex = 111;
            this.grd_esp_centro_editar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_esp_centro_editar_CellClick);
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
            // cmb_esp_centro_editar
            // 
            this.cmb_esp_centro_editar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_esp_centro_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_esp_centro_editar.FormattingEnabled = true;
            this.cmb_esp_centro_editar.Location = new System.Drawing.Point(85, 19);
            this.cmb_esp_centro_editar.Name = "cmb_esp_centro_editar";
            this.cmb_esp_centro_editar.Size = new System.Drawing.Size(233, 24);
            this.cmb_esp_centro_editar.TabIndex = 110;
            // 
            // btn_salir_centro_esp
            // 
            this.btn_salir_centro_esp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir_centro_esp.BackgroundImage")));
            this.btn_salir_centro_esp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir_centro_esp.Location = new System.Drawing.Point(286, 268);
            this.btn_salir_centro_esp.Name = "btn_salir_centro_esp";
            this.btn_salir_centro_esp.Size = new System.Drawing.Size(50, 50);
            this.btn_salir_centro_esp.TabIndex = 111;
            this.btn_salir_centro_esp.UseVisualStyleBackColor = true;
            this.btn_salir_centro_esp.Click += new System.EventHandler(this.btn_salir_centro_esp_Click);
            // 
            // FrmEditarEspCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 320);
            this.Controls.Add(this.btn_salir_centro_esp);
            this.Controls.Add(this.grp_esp_centro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarEspCentro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Especialidades del Centro";
            this.Load += new System.EventHandler(this.FrmEditarEspCentro_Load);
            this.grp_esp_centro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_esp_centro_editar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_esp_centro;
        private System.Windows.Forms.Button btn_eliminar_esp_editar;
        private System.Windows.Forms.Button btn_agregar_esp_centro_editar;
        private System.Windows.Forms.DataGridView grd_esp_centro_editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.ComboBox cmb_esp_centro_editar;
        private System.Windows.Forms.Button btn_salir_centro_esp;
    }
}