namespace obra_social_oscor.Formulario.ABM_Comunes
{
    partial class frm_Localidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Localidades));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreLocalidad = new System.Windows.Forms.TextBox();
            this.lblNombreLocalidad = new System.Windows.Forms.Label();
            this.gdrLocalidades = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarLocalidad = new System.Windows.Forms.Button();
            this.btnEditarLocalidad = new System.Windows.Forms.Button();
            this.btnEliminarLocalidad = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReiniciarForm = new System.Windows.Forms.Button();
            this.ttLocalidades = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreLocalidad);
            this.groupBox1.Controls.Add(this.lblNombreLocalidad);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.Location = new System.Drawing.Point(83, 39);
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(274, 20);
            this.txtNombreLocalidad.TabIndex = 1;
            this.txtNombreLocalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreLocalidad_KeyPress);
            // 
            // lblNombreLocalidad
            // 
            this.lblNombreLocalidad.AutoSize = true;
            this.lblNombreLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLocalidad.Location = new System.Drawing.Point(7, 40);
            this.lblNombreLocalidad.Name = "lblNombreLocalidad";
            this.lblNombreLocalidad.Size = new System.Drawing.Size(69, 20);
            this.lblNombreLocalidad.TabIndex = 0;
            this.lblNombreLocalidad.Text = "Nombre:";
            // 
            // gdrLocalidades
            // 
            this.gdrLocalidades.AllowUserToAddRows = false;
            this.gdrLocalidades.AllowUserToDeleteRows = false;
            this.gdrLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrLocalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NombreLocalidad});
            this.gdrLocalidades.Location = new System.Drawing.Point(13, 114);
            this.gdrLocalidades.Name = "gdrLocalidades";
            this.gdrLocalidades.ReadOnly = true;
            this.gdrLocalidades.Size = new System.Drawing.Size(384, 223);
            this.gdrLocalidades.TabIndex = 1;
            this.gdrLocalidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrLocalidades_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // NombreLocalidad
            // 
            this.NombreLocalidad.DataPropertyName = "LOCALIDAD";
            this.NombreLocalidad.HeaderText = "Nombre";
            this.NombreLocalidad.Name = "NombreLocalidad";
            this.NombreLocalidad.ReadOnly = true;
            this.NombreLocalidad.Width = 200;
            // 
            // btnAgregarLocalidad
            // 
            this.btnAgregarLocalidad.BackgroundImage = global::obra_social_oscor.Properties.Resources.agregar;
            this.btnAgregarLocalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarLocalidad.Location = new System.Drawing.Point(13, 344);
            this.btnAgregarLocalidad.Name = "btnAgregarLocalidad";
            this.btnAgregarLocalidad.Size = new System.Drawing.Size(53, 49);
            this.btnAgregarLocalidad.TabIndex = 2;
            this.ttLocalidades.SetToolTip(this.btnAgregarLocalidad, "Agregar Localidad");
            this.btnAgregarLocalidad.UseVisualStyleBackColor = true;
            this.btnAgregarLocalidad.Click += new System.EventHandler(this.btnAgregarLocalidad_Click);
            // 
            // btnEditarLocalidad
            // 
            this.btnEditarLocalidad.BackgroundImage = global::obra_social_oscor.Properties.Resources.Editar;
            this.btnEditarLocalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarLocalidad.Location = new System.Drawing.Point(72, 344);
            this.btnEditarLocalidad.Name = "btnEditarLocalidad";
            this.btnEditarLocalidad.Size = new System.Drawing.Size(53, 49);
            this.btnEditarLocalidad.TabIndex = 3;
            this.ttLocalidades.SetToolTip(this.btnEditarLocalidad, "Editar Localidad");
            this.btnEditarLocalidad.UseVisualStyleBackColor = true;
            this.btnEditarLocalidad.Click += new System.EventHandler(this.btnEditarLocalidad_Click);
            // 
            // btnEliminarLocalidad
            // 
            this.btnEliminarLocalidad.BackgroundImage = global::obra_social_oscor.Properties.Resources.eliminar;
            this.btnEliminarLocalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarLocalidad.Location = new System.Drawing.Point(131, 344);
            this.btnEliminarLocalidad.Name = "btnEliminarLocalidad";
            this.btnEliminarLocalidad.Size = new System.Drawing.Size(53, 49);
            this.btnEliminarLocalidad.TabIndex = 4;
            this.ttLocalidades.SetToolTip(this.btnEliminarLocalidad, "Borrar Localidad");
            this.btnEliminarLocalidad.UseVisualStyleBackColor = true;
            this.btnEliminarLocalidad.Click += new System.EventHandler(this.btnEliminarLocalidad_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(344, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 49);
            this.btnSalir.TabIndex = 5;
            this.ttLocalidades.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReiniciarForm
            // 
            this.btnReiniciarForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReiniciarForm.Location = new System.Drawing.Point(12, 398);
            this.btnReiniciarForm.Name = "btnReiniciarForm";
            this.btnReiniciarForm.Size = new System.Drawing.Size(113, 24);
            this.btnReiniciarForm.TabIndex = 6;
            this.btnReiniciarForm.Text = "Reiniciar Formulario";
            this.btnReiniciarForm.UseVisualStyleBackColor = true;
            this.btnReiniciarForm.Click += new System.EventHandler(this.btnReiniciarForm_Click);
            // 
            // ttLocalidades
            // 
            this.ttLocalidades.Popup += new System.Windows.Forms.PopupEventHandler(this.ttLocalidades_Popup);
            // 
            // frm_Localidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.btnReiniciarForm);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarLocalidad);
            this.Controls.Add(this.btnEditarLocalidad);
            this.Controls.Add(this.btnAgregarLocalidad);
            this.Controls.Add(this.gdrLocalidades);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Localidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localidades";
            this.Load += new System.EventHandler(this.frm_Localidades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrLocalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreLocalidad;
        private System.Windows.Forms.Label lblNombreLocalidad;
        private System.Windows.Forms.DataGridView gdrLocalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreLocalidad;
        private System.Windows.Forms.Button btnAgregarLocalidad;
        private System.Windows.Forms.Button btnEditarLocalidad;
        private System.Windows.Forms.Button btnEliminarLocalidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReiniciarForm;
        private System.Windows.Forms.ToolTip ttLocalidades;
    }
}