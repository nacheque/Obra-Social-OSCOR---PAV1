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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Escritorio));
            this.btn_Atenciones = new System.Windows.Forms.Button();
            this.btn_Asignar_Profesional = new System.Windows.Forms.Button();
            this.btn_Centro = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.tt_Form_Principal = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Pagos = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_estadisticas = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.afiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeAfliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeTipoDeAfiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeBarriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeLocalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorDeCuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Atenciones
            // 
            this.btn_Atenciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Atenciones.BackgroundImage = global::obra_social_oscor.Properties.Resources.Imagen_Atenciones;
            this.btn_Atenciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Atenciones.Location = new System.Drawing.Point(218, 106);
            this.btn_Atenciones.Name = "btn_Atenciones";
            this.btn_Atenciones.Size = new System.Drawing.Size(206, 195);
            this.btn_Atenciones.TabIndex = 1;
            this.tt_Form_Principal.SetToolTip(this.btn_Atenciones, "Gestionar Atenciones");
            this.btn_Atenciones.UseVisualStyleBackColor = true;
            this.btn_Atenciones.Click += new System.EventHandler(this.btn_afiliado_Click);
            // 
            // btn_Asignar_Profesional
            // 
            this.btn_Asignar_Profesional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Asignar_Profesional.BackgroundImage = global::obra_social_oscor.Properties.Resources.Imagen_Profesionales;
            this.btn_Asignar_Profesional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Asignar_Profesional.Location = new System.Drawing.Point(592, 106);
            this.btn_Asignar_Profesional.Name = "btn_Asignar_Profesional";
            this.btn_Asignar_Profesional.Size = new System.Drawing.Size(206, 195);
            this.btn_Asignar_Profesional.TabIndex = 2;
            this.tt_Form_Principal.SetToolTip(this.btn_Asignar_Profesional, "Asignar Profesionales a un Centro\r\n\r\n");
            this.btn_Asignar_Profesional.UseVisualStyleBackColor = true;
            this.btn_Asignar_Profesional.Click += new System.EventHandler(this.btn_Profesional_Click);
            // 
            // btn_Centro
            // 
            this.btn_Centro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Centro.BackgroundImage = global::obra_social_oscor.Properties.Resources.Imagen_Centros;
            this.btn_Centro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Centro.Location = new System.Drawing.Point(218, 407);
            this.btn_Centro.Name = "btn_Centro";
            this.btn_Centro.Size = new System.Drawing.Size(206, 195);
            this.btn_Centro.TabIndex = 3;
            this.tt_Form_Principal.SetToolTip(this.btn_Centro, "Gestionar Centros");
            this.btn_Centro.UseVisualStyleBackColor = true;
            this.btn_Centro.Click += new System.EventHandler(this.btn_Centro_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.BackgroundImage = global::obra_social_oscor.Properties.Resources.salir;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Location = new System.Drawing.Point(1236, 577);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(119, 113);
            this.btn_Salir.TabIndex = 4;
            this.tt_Form_Principal.SetToolTip(this.btn_Salir, "Salir de la Aplicación");
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Pagos
            // 
            this.btn_Pagos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pagos.BackColor = System.Drawing.Color.Transparent;
            this.btn_Pagos.BackgroundImage = global::obra_social_oscor.Properties.Resources.Imagen_Pagos;
            this.btn_Pagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pagos.Location = new System.Drawing.Point(942, 106);
            this.btn_Pagos.Name = "btn_Pagos";
            this.btn_Pagos.Size = new System.Drawing.Size(206, 195);
            this.btn_Pagos.TabIndex = 6;
            this.tt_Form_Principal.SetToolTip(this.btn_Pagos, "Cargar un Pago");
            this.btn_Pagos.UseVisualStyleBackColor = false;
            this.btn_Pagos.Click += new System.EventHandler(this.btn_Pagos_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reportes.BackgroundImage = global::obra_social_oscor.Properties.Resources.imagen_reportes;
            this.btn_reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reportes.Location = new System.Drawing.Point(592, 407);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(206, 195);
            this.btn_reportes.TabIndex = 8;
            this.tt_Form_Principal.SetToolTip(this.btn_reportes, "Ver Reportes");
            this.btn_reportes.UseVisualStyleBackColor = true;
            // 
            // btn_estadisticas
            // 
            this.btn_estadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_estadisticas.BackgroundImage = global::obra_social_oscor.Properties.Resources.Imagen_estadisticas;
            this.btn_estadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_estadisticas.Location = new System.Drawing.Point(942, 407);
            this.btn_estadisticas.Name = "btn_estadisticas";
            this.btn_estadisticas.Size = new System.Drawing.Size(206, 195);
            this.btn_estadisticas.TabIndex = 9;
            this.tt_Form_Principal.SetToolTip(this.btn_estadisticas, "Ver Estadisticas");
            this.btn_estadisticas.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.afiliadoToolStripMenuItem,
            this.especialidadesToolStripMenuItem,
            this.barriosToolStripMenuItem,
            this.localidadesToolStripMenuItem,
            this.cuotasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1367, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // afiliadoToolStripMenuItem
            // 
            this.afiliadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeAfliadoToolStripMenuItem,
            this.gestionDeTipoDeAfiliadoToolStripMenuItem});
            this.afiliadoToolStripMenuItem.Name = "afiliadoToolStripMenuItem";
            this.afiliadoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.afiliadoToolStripMenuItem.Text = "Afiliado";
            // 
            // gestionDeAfliadoToolStripMenuItem
            // 
            this.gestionDeAfliadoToolStripMenuItem.Image = global::obra_social_oscor.Properties.Resources.Icono_Afiliados;
            this.gestionDeAfliadoToolStripMenuItem.Name = "gestionDeAfliadoToolStripMenuItem";
            this.gestionDeAfliadoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.gestionDeAfliadoToolStripMenuItem.Text = "Gestion de Afliado";
            this.gestionDeAfliadoToolStripMenuItem.Click += new System.EventHandler(this.gestionDeAfliadoToolStripMenuItem_Click);
            // 
            // gestionDeTipoDeAfiliadoToolStripMenuItem
            // 
            this.gestionDeTipoDeAfiliadoToolStripMenuItem.Image = global::obra_social_oscor.Properties.Resources.Icono_Afiliados;
            this.gestionDeTipoDeAfiliadoToolStripMenuItem.Name = "gestionDeTipoDeAfiliadoToolStripMenuItem";
            this.gestionDeTipoDeAfiliadoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.gestionDeTipoDeAfiliadoToolStripMenuItem.Text = "Gestion de Tipo de Afiliado";
            this.gestionDeTipoDeAfiliadoToolStripMenuItem.Click += new System.EventHandler(this.gestionDeTipoDeAfiliadoToolStripMenuItem_Click);
            // 
            // especialidadesToolStripMenuItem
            // 
            this.especialidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeEspecialidadesToolStripMenuItem});
            this.especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            this.especialidadesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.especialidadesToolStripMenuItem.Text = "Especialidades";
            // 
            // gestionDeEspecialidadesToolStripMenuItem
            // 
            this.gestionDeEspecialidadesToolStripMenuItem.Image = global::obra_social_oscor.Properties.Resources.Imagen_Especialidades;
            this.gestionDeEspecialidadesToolStripMenuItem.Name = "gestionDeEspecialidadesToolStripMenuItem";
            this.gestionDeEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.gestionDeEspecialidadesToolStripMenuItem.Text = "Gestion de Especialidades";
            this.gestionDeEspecialidadesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeEspecialidadesToolStripMenuItem_Click);
            // 
            // barriosToolStripMenuItem
            // 
            this.barriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeBarriosToolStripMenuItem});
            this.barriosToolStripMenuItem.Name = "barriosToolStripMenuItem";
            this.barriosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.barriosToolStripMenuItem.Text = "Barrios";
            // 
            // gestionDeBarriosToolStripMenuItem
            // 
            this.gestionDeBarriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionDeBarriosToolStripMenuItem.Image")));
            this.gestionDeBarriosToolStripMenuItem.Name = "gestionDeBarriosToolStripMenuItem";
            this.gestionDeBarriosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.gestionDeBarriosToolStripMenuItem.Text = "Gestion de Barrios";
            this.gestionDeBarriosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeBarriosToolStripMenuItem_Click);
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeLocalidadesToolStripMenuItem});
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            // 
            // gestionDeLocalidadesToolStripMenuItem
            // 
            this.gestionDeLocalidadesToolStripMenuItem.Image = global::obra_social_oscor.Properties.Resources._287695_location_icon;
            this.gestionDeLocalidadesToolStripMenuItem.Name = "gestionDeLocalidadesToolStripMenuItem";
            this.gestionDeLocalidadesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gestionDeLocalidadesToolStripMenuItem.Text = "Gestion de Localidades";
            this.gestionDeLocalidadesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeLocalidadesToolStripMenuItem_Click);
            // 
            // cuotasToolStripMenuItem
            // 
            this.cuotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valorDeCuotaToolStripMenuItem});
            this.cuotasToolStripMenuItem.Name = "cuotasToolStripMenuItem";
            this.cuotasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.cuotasToolStripMenuItem.Text = "Cuotas";
            // 
            // valorDeCuotaToolStripMenuItem
            // 
            this.valorDeCuotaToolStripMenuItem.Image = global::obra_social_oscor.Properties.Resources._2203534_cash_coin_money_value_icon;
            this.valorDeCuotaToolStripMenuItem.Name = "valorDeCuotaToolStripMenuItem";
            this.valorDeCuotaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.valorDeCuotaToolStripMenuItem.Text = "Valor de Cuota";
            this.valorDeCuotaToolStripMenuItem.Click += new System.EventHandler(this.valorDeCuotaToolStripMenuItem_Click);
            // 
            // frm_Escritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::obra_social_oscor.Properties.Resources.fondo_escritorio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1367, 702);
            this.Controls.Add(this.btn_estadisticas);
            this.Controls.Add(this.btn_reportes);
            this.Controls.Add(this.btn_Pagos);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Centro);
            this.Controls.Add(this.btn_Asignar_Profesional);
            this.Controls.Add(this.btn_Atenciones);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Escritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a OSCOR";
            this.Load += new System.EventHandler(this.frm_Escritorio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Atenciones;
        private System.Windows.Forms.Button btn_Asignar_Profesional;
        private System.Windows.Forms.Button btn_Centro;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.ToolTip tt_Form_Principal;
        private System.Windows.Forms.Button btn_Pagos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem especialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeEspecialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem afiliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeAfliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeTipoDeAfiliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeBarriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeLocalidadesToolStripMenuItem;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Button btn_estadisticas;
        private System.Windows.Forms.ToolStripMenuItem cuotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valorDeCuotaToolStripMenuItem;
    }
}

