namespace obra_social_oscor.Formulario.ABM_Comunes
{
    partial class FrmValorCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValorCuota));
            this.lblVCEdadDesde = new System.Windows.Forms.Label();
            this.lblVCEdadHasta = new System.Windows.Forms.Label();
            this.lblVCTipoAfiliado = new System.Windows.Forms.Label();
            this.lblVCMonto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmbTipoAfiliado = new System.Windows.Forms.ComboBox();
            this.gdrValoresC = new System.Windows.Forms.DataGridView();
            this.TipoAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdadDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdadHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarVC = new System.Windows.Forms.Button();
            this.btnEditarVC = new System.Windows.Forms.Button();
            this.btnEliminarVC = new System.Windows.Forms.Button();
            this.btnSalirVC = new System.Windows.Forms.Button();
            this.btnReiniciarFormVC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdrValoresC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVCEdadDesde
            // 
            this.lblVCEdadDesde.AutoSize = true;
            this.lblVCEdadDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVCEdadDesde.Location = new System.Drawing.Point(13, 13);
            this.lblVCEdadDesde.Name = "lblVCEdadDesde";
            this.lblVCEdadDesde.Size = new System.Drawing.Size(102, 20);
            this.lblVCEdadDesde.TabIndex = 0;
            this.lblVCEdadDesde.Text = "Edad Desde:";
            // 
            // lblVCEdadHasta
            // 
            this.lblVCEdadHasta.AutoSize = true;
            this.lblVCEdadHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVCEdadHasta.Location = new System.Drawing.Point(12, 63);
            this.lblVCEdadHasta.Name = "lblVCEdadHasta";
            this.lblVCEdadHasta.Size = new System.Drawing.Size(98, 20);
            this.lblVCEdadHasta.TabIndex = 1;
            this.lblVCEdadHasta.Text = "Edad Hasta:";
            // 
            // lblVCTipoAfiliado
            // 
            this.lblVCTipoAfiliado.AutoSize = true;
            this.lblVCTipoAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVCTipoAfiliado.Location = new System.Drawing.Point(311, 13);
            this.lblVCTipoAfiliado.Name = "lblVCTipoAfiliado";
            this.lblVCTipoAfiliado.Size = new System.Drawing.Size(117, 20);
            this.lblVCTipoAfiliado.TabIndex = 2;
            this.lblVCTipoAfiliado.Text = "Tipo de Afiliado";
            // 
            // lblVCMonto
            // 
            this.lblVCMonto.AutoSize = true;
            this.lblVCMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVCMonto.Location = new System.Drawing.Point(311, 63);
            this.lblVCMonto.Name = "lblVCMonto";
            this.lblVCMonto.Size = new System.Drawing.Size(123, 20);
            this.lblVCMonto.TabIndex = 3;
            this.lblVCMonto.Text = "Monto a Cobrar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(440, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 6;
            // 
            // cmbTipoAfiliado
            // 
            this.cmbTipoAfiliado.FormattingEnabled = true;
            this.cmbTipoAfiliado.Location = new System.Drawing.Point(440, 13);
            this.cmbTipoAfiliado.Name = "cmbTipoAfiliado";
            this.cmbTipoAfiliado.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoAfiliado.TabIndex = 7;
            // 
            // gdrValoresC
            // 
            this.gdrValoresC.AllowUserToAddRows = false;
            this.gdrValoresC.AllowUserToDeleteRows = false;
            this.gdrValoresC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrValoresC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoAfiliado,
            this.EdadDesde,
            this.EdadHasta,
            this.Monto});
            this.gdrValoresC.Location = new System.Drawing.Point(16, 104);
            this.gdrValoresC.Name = "gdrValoresC";
            this.gdrValoresC.ReadOnly = true;
            this.gdrValoresC.Size = new System.Drawing.Size(544, 232);
            this.gdrValoresC.TabIndex = 8;
            // 
            // TipoAfiliado
            // 
            this.TipoAfiliado.HeaderText = "Tipo de Afiliado";
            this.TipoAfiliado.Name = "TipoAfiliado";
            this.TipoAfiliado.ReadOnly = true;
            this.TipoAfiliado.Width = 200;
            // 
            // EdadDesde
            // 
            this.EdadDesde.HeaderText = "Edad Desde";
            this.EdadDesde.Name = "EdadDesde";
            this.EdadDesde.ReadOnly = true;
            // 
            // EdadHasta
            // 
            this.EdadHasta.HeaderText = "Edad Hasta";
            this.EdadHasta.Name = "EdadHasta";
            this.EdadHasta.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // btnAgregarVC
            // 
            this.btnAgregarVC.BackgroundImage = global::obra_social_oscor.Properties.Resources.agregar;
            this.btnAgregarVC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarVC.Location = new System.Drawing.Point(17, 342);
            this.btnAgregarVC.Name = "btnAgregarVC";
            this.btnAgregarVC.Size = new System.Drawing.Size(59, 53);
            this.btnAgregarVC.TabIndex = 9;
            this.btnAgregarVC.UseVisualStyleBackColor = true;
            // 
            // btnEditarVC
            // 
            this.btnEditarVC.BackgroundImage = global::obra_social_oscor.Properties.Resources.Editar;
            this.btnEditarVC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarVC.Location = new System.Drawing.Point(82, 342);
            this.btnEditarVC.Name = "btnEditarVC";
            this.btnEditarVC.Size = new System.Drawing.Size(59, 53);
            this.btnEditarVC.TabIndex = 10;
            this.btnEditarVC.UseVisualStyleBackColor = true;
            // 
            // btnEliminarVC
            // 
            this.btnEliminarVC.BackgroundImage = global::obra_social_oscor.Properties.Resources.eliminar;
            this.btnEliminarVC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarVC.Location = new System.Drawing.Point(147, 342);
            this.btnEliminarVC.Name = "btnEliminarVC";
            this.btnEliminarVC.Size = new System.Drawing.Size(59, 53);
            this.btnEliminarVC.TabIndex = 11;
            this.btnEliminarVC.UseVisualStyleBackColor = true;
            // 
            // btnSalirVC
            // 
            this.btnSalirVC.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btnSalirVC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalirVC.Location = new System.Drawing.Point(501, 385);
            this.btnSalirVC.Name = "btnSalirVC";
            this.btnSalirVC.Size = new System.Drawing.Size(59, 53);
            this.btnSalirVC.TabIndex = 12;
            this.btnSalirVC.UseVisualStyleBackColor = true;
            this.btnSalirVC.Click += new System.EventHandler(this.btnSalirVC_Click);
            // 
            // btnReiniciarFormVC
            // 
            this.btnReiniciarFormVC.Location = new System.Drawing.Point(12, 401);
            this.btnReiniciarFormVC.Name = "btnReiniciarFormVC";
            this.btnReiniciarFormVC.Size = new System.Drawing.Size(129, 37);
            this.btnReiniciarFormVC.TabIndex = 13;
            this.btnReiniciarFormVC.Text = "Reiniciar Formulario";
            this.btnReiniciarFormVC.UseVisualStyleBackColor = true;
            // 
            // FrmValorCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.btnReiniciarFormVC);
            this.Controls.Add(this.btnSalirVC);
            this.Controls.Add(this.btnEliminarVC);
            this.Controls.Add(this.btnEditarVC);
            this.Controls.Add(this.btnAgregarVC);
            this.Controls.Add(this.gdrValoresC);
            this.Controls.Add(this.cmbTipoAfiliado);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblVCMonto);
            this.Controls.Add(this.lblVCTipoAfiliado);
            this.Controls.Add(this.lblVCEdadHasta);
            this.Controls.Add(this.lblVCEdadDesde);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmValorCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valor de Cuota Mensual";
            this.Load += new System.EventHandler(this.FrmValorCuota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrValoresC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVCEdadDesde;
        private System.Windows.Forms.Label lblVCEdadHasta;
        private System.Windows.Forms.Label lblVCTipoAfiliado;
        private System.Windows.Forms.Label lblVCMonto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cmbTipoAfiliado;
        private System.Windows.Forms.DataGridView gdrValoresC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdadDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdadHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Button btnAgregarVC;
        private System.Windows.Forms.Button btnEditarVC;
        private System.Windows.Forms.Button btnEliminarVC;
        private System.Windows.Forms.Button btnSalirVC;
        private System.Windows.Forms.Button btnReiniciarFormVC;
    }
}