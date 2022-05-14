namespace obra_social_oscor.Formulario.ABM_Comunes
{
    partial class frm_Barrios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Barrios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreBarrio = new System.Windows.Forms.TextBox();
            this.lbl_Barrios = new System.Windows.Forms.Label();
            this.gdrBarrios = new System.Windows.Forms.DataGridView();
            this.btnAgregarBarrio = new System.Windows.Forms.Button();
            this.btnEditarBarrio = new System.Windows.Forms.Button();
            this.btnEliminarBarrio = new System.Windows.Forms.Button();
            this.btnSalirBarrios = new System.Windows.Forms.Button();
            this.ttBarrios = new System.Windows.Forms.ToolTip(this.components);
            this.btnLimpiarCamposBarrio = new System.Windows.Forms.Button();
            this.CodigoBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrBarrios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreBarrio);
            this.groupBox1.Controls.Add(this.lbl_Barrios);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.Location = new System.Drawing.Point(83, 33);
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.Size = new System.Drawing.Size(267, 20);
            this.txtNombreBarrio.TabIndex = 1;
            this.txtNombreBarrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreBarrio_KeyPress);
            // 
            // lbl_Barrios
            // 
            this.lbl_Barrios.AutoSize = true;
            this.lbl_Barrios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Barrios.Location = new System.Drawing.Point(7, 33);
            this.lbl_Barrios.Name = "lbl_Barrios";
            this.lbl_Barrios.Size = new System.Drawing.Size(69, 20);
            this.lbl_Barrios.TabIndex = 0;
            this.lbl_Barrios.Text = "Nombre:";
            // 
            // gdrBarrios
            // 
            this.gdrBarrios.AllowUserToAddRows = false;
            this.gdrBarrios.AllowUserToDeleteRows = false;
            this.gdrBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrBarrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoBarrio,
            this.NombreBarrio});
            this.gdrBarrios.Location = new System.Drawing.Point(12, 111);
            this.gdrBarrios.Name = "gdrBarrios";
            this.gdrBarrios.ReadOnly = true;
            this.gdrBarrios.Size = new System.Drawing.Size(371, 197);
            this.gdrBarrios.TabIndex = 1;
            this.gdrBarrios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrBarrios_CellClick);
            // 
            // btnAgregarBarrio
            // 
            this.btnAgregarBarrio.BackgroundImage = global::obra_social_oscor.Properties.Resources.agregar;
            this.btnAgregarBarrio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarBarrio.Location = new System.Drawing.Point(12, 314);
            this.btnAgregarBarrio.Name = "btnAgregarBarrio";
            this.btnAgregarBarrio.Size = new System.Drawing.Size(50, 47);
            this.btnAgregarBarrio.TabIndex = 2;
            this.ttBarrios.SetToolTip(this.btnAgregarBarrio, "Agregar Nuevo Barrio");
            this.btnAgregarBarrio.UseVisualStyleBackColor = true;
            this.btnAgregarBarrio.Click += new System.EventHandler(this.btnAgregarBarrio_Click);
            // 
            // btnEditarBarrio
            // 
            this.btnEditarBarrio.BackgroundImage = global::obra_social_oscor.Properties.Resources.Editar;
            this.btnEditarBarrio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarBarrio.Location = new System.Drawing.Point(68, 314);
            this.btnEditarBarrio.Name = "btnEditarBarrio";
            this.btnEditarBarrio.Size = new System.Drawing.Size(53, 47);
            this.btnEditarBarrio.TabIndex = 3;
            this.ttBarrios.SetToolTip(this.btnEditarBarrio, "Editar Un Barrio");
            this.btnEditarBarrio.UseVisualStyleBackColor = true;
            this.btnEditarBarrio.Click += new System.EventHandler(this.btnEditarBarrio_Click);
            // 
            // btnEliminarBarrio
            // 
            this.btnEliminarBarrio.BackgroundImage = global::obra_social_oscor.Properties.Resources.eliminar;
            this.btnEliminarBarrio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarBarrio.Location = new System.Drawing.Point(127, 314);
            this.btnEliminarBarrio.Name = "btnEliminarBarrio";
            this.btnEliminarBarrio.Size = new System.Drawing.Size(58, 47);
            this.btnEliminarBarrio.TabIndex = 4;
            this.ttBarrios.SetToolTip(this.btnEliminarBarrio, "Eliminar un Barrio");
            this.btnEliminarBarrio.UseVisualStyleBackColor = true;
            this.btnEliminarBarrio.Click += new System.EventHandler(this.btnEliminarBarrio_Click);
            // 
            // btnSalirBarrios
            // 
            this.btnSalirBarrios.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btnSalirBarrios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalirBarrios.Location = new System.Drawing.Point(321, 388);
            this.btnSalirBarrios.Name = "btnSalirBarrios";
            this.btnSalirBarrios.Size = new System.Drawing.Size(61, 50);
            this.btnSalirBarrios.TabIndex = 5;
            this.ttBarrios.SetToolTip(this.btnSalirBarrios, "Salir");
            this.btnSalirBarrios.UseVisualStyleBackColor = true;
            this.btnSalirBarrios.Click += new System.EventHandler(this.btnSalirBarrios_Click);
            // 
            // btnLimpiarCamposBarrio
            // 
            this.btnLimpiarCamposBarrio.Location = new System.Drawing.Point(13, 368);
            this.btnLimpiarCamposBarrio.Name = "btnLimpiarCamposBarrio";
            this.btnLimpiarCamposBarrio.Size = new System.Drawing.Size(108, 23);
            this.btnLimpiarCamposBarrio.TabIndex = 6;
            this.btnLimpiarCamposBarrio.Text = "Reiniciar Formulario";
            this.btnLimpiarCamposBarrio.UseVisualStyleBackColor = true;
            this.btnLimpiarCamposBarrio.Click += new System.EventHandler(this.btnLimpiarCamposBarrio_Click);
            // 
            // CodigoBarrio
            // 
            this.CodigoBarrio.HeaderText = "Codigo";
            this.CodigoBarrio.Name = "CodigoBarrio";
            this.CodigoBarrio.ReadOnly = true;
            this.CodigoBarrio.Visible = false;
            // 
            // NombreBarrio
            // 
            this.NombreBarrio.DataPropertyName = "BARRIO";
            this.NombreBarrio.HeaderText = "Nombre";
            this.NombreBarrio.Name = "NombreBarrio";
            this.NombreBarrio.ReadOnly = true;
            this.NombreBarrio.Width = 200;
            // 
            // frm_Barrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.btnLimpiarCamposBarrio);
            this.Controls.Add(this.btnSalirBarrios);
            this.Controls.Add(this.btnEliminarBarrio);
            this.Controls.Add(this.btnEditarBarrio);
            this.Controls.Add(this.btnAgregarBarrio);
            this.Controls.Add(this.gdrBarrios);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Barrios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barrios";
            this.Load += new System.EventHandler(this.Barrios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrBarrios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Barrios;
        private System.Windows.Forms.TextBox txtNombreBarrio;
        private System.Windows.Forms.DataGridView gdrBarrios;
        private System.Windows.Forms.Button btnAgregarBarrio;
        private System.Windows.Forms.Button btnEditarBarrio;
        private System.Windows.Forms.Button btnEliminarBarrio;
        private System.Windows.Forms.Button btnSalirBarrios;
        private System.Windows.Forms.ToolTip ttBarrios;
        private System.Windows.Forms.Button btnLimpiarCamposBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBarrio;
    }
}