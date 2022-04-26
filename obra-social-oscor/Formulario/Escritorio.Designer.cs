namespace obra_social_oscor
{
    partial class frm_Escritorio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Escritorio));
            this.btn_afiliado = new System.Windows.Forms.Button();
            this.btn_Profesional = new System.Windows.Forms.Button();
            this.btn_Centro = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCorazon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_afiliado
            // 
            this.btn_afiliado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_afiliado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_afiliado.BackgroundImage")));
            this.btn_afiliado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_afiliado.Location = new System.Drawing.Point(642, 80);
            this.btn_afiliado.Name = "btn_afiliado";
            this.btn_afiliado.Size = new System.Drawing.Size(250, 250);
            this.btn_afiliado.TabIndex = 1;
            this.btn_afiliado.UseVisualStyleBackColor = true;
            this.btn_afiliado.Click += new System.EventHandler(this.btn_afiliado_Click);
            // 
            // btn_Profesional
            // 
            this.btn_Profesional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Profesional.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Profesional.BackgroundImage")));
            this.btn_Profesional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Profesional.Location = new System.Drawing.Point(987, 80);
            this.btn_Profesional.Name = "btn_Profesional";
            this.btn_Profesional.Size = new System.Drawing.Size(250, 250);
            this.btn_Profesional.TabIndex = 2;
            this.btn_Profesional.UseVisualStyleBackColor = true;
            this.btn_Profesional.Click += new System.EventHandler(this.btn_Profesional_Click);
            // 
            // btn_Centro
            // 
            this.btn_Centro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Centro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Centro.BackgroundImage")));
            this.btn_Centro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Centro.Location = new System.Drawing.Point(642, 377);
            this.btn_Centro.Name = "btn_Centro";
            this.btn_Centro.Size = new System.Drawing.Size(250, 250);
            this.btn_Centro.TabIndex = 3;
            this.btn_Centro.UseVisualStyleBackColor = true;
            this.btn_Centro.Click += new System.EventHandler(this.btn_Centro_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Location = new System.Drawing.Point(987, 377);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(250, 250);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "OSCOR";
            // 
            // btnCorazon
            // 
            this.btnCorazon.BackColor = System.Drawing.Color.Silver;
            this.btnCorazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorazon.ForeColor = System.Drawing.Color.Red;
            this.btnCorazon.Location = new System.Drawing.Point(330, 307);
            this.btnCorazon.Name = "btnCorazon";
            this.btnCorazon.Size = new System.Drawing.Size(70, 47);
            this.btnCorazon.TabIndex = 6;
            this.btnCorazon.Text = "???";
            this.btnCorazon.UseVisualStyleBackColor = false;
            this.btnCorazon.Click += new System.EventHandler(this.btnCorazon_Click);
            // 
            // frm_Escritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 702);
            this.Controls.Add(this.btnCorazon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Centro);
            this.Controls.Add(this.btn_Profesional);
            this.Controls.Add(this.btn_afiliado);
            this.DoubleBuffered = true;
            this.Name = "frm_Escritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escritorio del Sistema";
            this.Load += new System.EventHandler(this.frm_Escritorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_afiliado;
        private System.Windows.Forms.Button btn_Profesional;
        private System.Windows.Forms.Button btn_Centro;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCorazon;
    }
}

