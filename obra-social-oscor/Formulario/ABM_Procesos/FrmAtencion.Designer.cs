namespace obra_social_oscor.Formulario.ABM
{
    partial class frm_Atenciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Atenciones));
            this.grp_atenciones = new System.Windows.Forms.GroupBox();
            this.grp_buscar_afi_atencion = new System.Windows.Forms.GroupBox();
            this.btn_limpiar_filtros_aten = new System.Windows.Forms.Button();
            this.lbl_nombre_afi_atencion = new System.Windows.Forms.Label();
            this.lbl_ape_afi_aten = new System.Windows.Forms.Label();
            this.txt_nombre_afi_atencion = new System.Windows.Forms.TextBox();
            this.txt_apellido_afi_atencion = new System.Windows.Forms.TextBox();
            this.cmb_resultados = new System.Windows.Forms.ComboBox();
            this.lbl_resultados_ate = new System.Windows.Forms.Label();
            this.btn_buscar_afi_atencion = new System.Windows.Forms.Button();
            this.txt_num_afi_ate = new System.Windows.Forms.TextBox();
            this.lbl_apellido_afi_atencion = new System.Windows.Forms.Label();
            this.msk_fecha_aten = new System.Windows.Forms.MaskedTextBox();
            this.lbl_fecha_atenc = new System.Windows.Forms.Label();
            this.lbl_importe_atencion = new System.Windows.Forms.Label();
            this.lbl_practica_atencion = new System.Windows.Forms.Label();
            this.txt_importe_aten = new System.Windows.Forms.TextBox();
            this.cmb_practica_atencion = new System.Windows.Forms.ComboBox();
            this.lbl_profesional_atencion = new System.Windows.Forms.Label();
            this.lbl_esp_atencion = new System.Windows.Forms.Label();
            this.lbl_centro_atencion = new System.Windows.Forms.Label();
            this.cmb_prof_atencion = new System.Windows.Forms.ComboBox();
            this.cmb_esp_atencion = new System.Windows.Forms.ComboBox();
            this.cmb_centro_atencion = new System.Windows.Forms.ComboBox();
            this.grd_atenciones = new System.Windows.Forms.DataGridView();
            this.btn_agregar_atencion = new System.Windows.Forms.Button();
            this.btn_limpiar_atencion = new System.Windows.Forms.Button();
            this.btn_salir_atencion = new System.Windows.Forms.Button();
            this.btn_editar_atencion = new System.Windows.Forms.Button();
            this.tt_atenciones = new System.Windows.Forms.ToolTip(this.components);
            this.id_atencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_centro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_practica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.practica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_atenciones.SuspendLayout();
            this.grp_buscar_afi_atencion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_atenciones)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_atenciones
            // 
            this.grp_atenciones.Controls.Add(this.grp_buscar_afi_atencion);
            this.grp_atenciones.Controls.Add(this.msk_fecha_aten);
            this.grp_atenciones.Controls.Add(this.lbl_fecha_atenc);
            this.grp_atenciones.Controls.Add(this.lbl_importe_atencion);
            this.grp_atenciones.Controls.Add(this.lbl_practica_atencion);
            this.grp_atenciones.Controls.Add(this.txt_importe_aten);
            this.grp_atenciones.Controls.Add(this.cmb_practica_atencion);
            this.grp_atenciones.Controls.Add(this.lbl_profesional_atencion);
            this.grp_atenciones.Controls.Add(this.lbl_esp_atencion);
            this.grp_atenciones.Controls.Add(this.lbl_centro_atencion);
            this.grp_atenciones.Controls.Add(this.cmb_prof_atencion);
            this.grp_atenciones.Controls.Add(this.cmb_esp_atencion);
            this.grp_atenciones.Controls.Add(this.cmb_centro_atencion);
            this.grp_atenciones.Location = new System.Drawing.Point(12, 12);
            this.grp_atenciones.Name = "grp_atenciones";
            this.grp_atenciones.Size = new System.Drawing.Size(1145, 198);
            this.grp_atenciones.TabIndex = 0;
            this.grp_atenciones.TabStop = false;
            this.grp_atenciones.Text = "Datos";
            // 
            // grp_buscar_afi_atencion
            // 
            this.grp_buscar_afi_atencion.Controls.Add(this.btn_limpiar_filtros_aten);
            this.grp_buscar_afi_atencion.Controls.Add(this.lbl_nombre_afi_atencion);
            this.grp_buscar_afi_atencion.Controls.Add(this.lbl_ape_afi_aten);
            this.grp_buscar_afi_atencion.Controls.Add(this.txt_nombre_afi_atencion);
            this.grp_buscar_afi_atencion.Controls.Add(this.txt_apellido_afi_atencion);
            this.grp_buscar_afi_atencion.Controls.Add(this.cmb_resultados);
            this.grp_buscar_afi_atencion.Controls.Add(this.lbl_resultados_ate);
            this.grp_buscar_afi_atencion.Controls.Add(this.btn_buscar_afi_atencion);
            this.grp_buscar_afi_atencion.Controls.Add(this.txt_num_afi_ate);
            this.grp_buscar_afi_atencion.Controls.Add(this.lbl_apellido_afi_atencion);
            this.grp_buscar_afi_atencion.Location = new System.Drawing.Point(356, 19);
            this.grp_buscar_afi_atencion.Name = "grp_buscar_afi_atencion";
            this.grp_buscar_afi_atencion.Size = new System.Drawing.Size(780, 117);
            this.grp_buscar_afi_atencion.TabIndex = 100;
            this.grp_buscar_afi_atencion.TabStop = false;
            this.grp_buscar_afi_atencion.Text = "Buscar Afiliado";
            // 
            // btn_limpiar_filtros_aten
            // 
            this.btn_limpiar_filtros_aten.Location = new System.Drawing.Point(349, 68);
            this.btn_limpiar_filtros_aten.Name = "btn_limpiar_filtros_aten";
            this.btn_limpiar_filtros_aten.Size = new System.Drawing.Size(112, 23);
            this.btn_limpiar_filtros_aten.TabIndex = 107;
            this.btn_limpiar_filtros_aten.Text = "Limpiar Filtros";
            this.btn_limpiar_filtros_aten.UseVisualStyleBackColor = true;
            this.btn_limpiar_filtros_aten.Click += new System.EventHandler(this.btn_limpiar_filtros_aten_Click);
            // 
            // lbl_nombre_afi_atencion
            // 
            this.lbl_nombre_afi_atencion.AutoSize = true;
            this.lbl_nombre_afi_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_afi_atencion.Location = new System.Drawing.Point(87, 91);
            this.lbl_nombre_afi_atencion.Name = "lbl_nombre_afi_atencion";
            this.lbl_nombre_afi_atencion.Size = new System.Drawing.Size(62, 17);
            this.lbl_nombre_afi_atencion.TabIndex = 106;
            this.lbl_nombre_afi_atencion.Text = "Nombre:";
            // 
            // lbl_ape_afi_aten
            // 
            this.lbl_ape_afi_aten.AutoSize = true;
            this.lbl_ape_afi_aten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ape_afi_aten.Location = new System.Drawing.Point(87, 55);
            this.lbl_ape_afi_aten.Name = "lbl_ape_afi_aten";
            this.lbl_ape_afi_aten.Size = new System.Drawing.Size(62, 17);
            this.lbl_ape_afi_aten.TabIndex = 105;
            this.lbl_ape_afi_aten.Text = "Apellido:";
            // 
            // txt_nombre_afi_atencion
            // 
            this.txt_nombre_afi_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_afi_atencion.Location = new System.Drawing.Point(155, 88);
            this.txt_nombre_afi_atencion.Name = "txt_nombre_afi_atencion";
            this.txt_nombre_afi_atencion.Size = new System.Drawing.Size(161, 23);
            this.txt_nombre_afi_atencion.TabIndex = 104;
            this.txt_nombre_afi_atencion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_afi_atencion_KeyPress);
            // 
            // txt_apellido_afi_atencion
            // 
            this.txt_apellido_afi_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_afi_atencion.Location = new System.Drawing.Point(155, 52);
            this.txt_apellido_afi_atencion.Name = "txt_apellido_afi_atencion";
            this.txt_apellido_afi_atencion.Size = new System.Drawing.Size(161, 23);
            this.txt_apellido_afi_atencion.TabIndex = 103;
            this.txt_apellido_afi_atencion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_afi_atencion_KeyPress);
            // 
            // cmb_resultados
            // 
            this.cmb_resultados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_resultados.FormattingEnabled = true;
            this.cmb_resultados.Location = new System.Drawing.Point(463, 13);
            this.cmb_resultados.Name = "cmb_resultados";
            this.cmb_resultados.Size = new System.Drawing.Size(220, 24);
            this.cmb_resultados.TabIndex = 101;
            // 
            // lbl_resultados_ate
            // 
            this.lbl_resultados_ate.AutoSize = true;
            this.lbl_resultados_ate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultados_ate.Location = new System.Drawing.Point(378, 17);
            this.lbl_resultados_ate.Name = "lbl_resultados_ate";
            this.lbl_resultados_ate.Size = new System.Drawing.Size(83, 17);
            this.lbl_resultados_ate.TabIndex = 102;
            this.lbl_resultados_ate.Text = "Resultados:";
            // 
            // btn_buscar_afi_atencion
            // 
            this.btn_buscar_afi_atencion.Location = new System.Drawing.Point(260, 14);
            this.btn_buscar_afi_atencion.Name = "btn_buscar_afi_atencion";
            this.btn_buscar_afi_atencion.Size = new System.Drawing.Size(112, 23);
            this.btn_buscar_afi_atencion.TabIndex = 100;
            this.btn_buscar_afi_atencion.Text = "Buscar";
            this.btn_buscar_afi_atencion.UseVisualStyleBackColor = true;
            this.btn_buscar_afi_atencion.Click += new System.EventHandler(this.btn_buscar_afi_atencion_Click);
            // 
            // txt_num_afi_ate
            // 
            this.txt_num_afi_ate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_afi_ate.Location = new System.Drawing.Point(155, 14);
            this.txt_num_afi_ate.Name = "txt_num_afi_ate";
            this.txt_num_afi_ate.Size = new System.Drawing.Size(89, 23);
            this.txt_num_afi_ate.TabIndex = 101;
            this.txt_num_afi_ate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_afi_ate_KeyPress);
            // 
            // lbl_apellido_afi_atencion
            // 
            this.lbl_apellido_afi_atencion.AutoSize = true;
            this.lbl_apellido_afi_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido_afi_atencion.Location = new System.Drawing.Point(17, 17);
            this.lbl_apellido_afi_atencion.Name = "lbl_apellido_afi_atencion";
            this.lbl_apellido_afi_atencion.Size = new System.Drawing.Size(132, 17);
            this.lbl_apellido_afi_atencion.TabIndex = 94;
            this.lbl_apellido_afi_atencion.Text = "Numero de Afiliado:";
            // 
            // msk_fecha_aten
            // 
            this.msk_fecha_aten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_fecha_aten.Location = new System.Drawing.Point(916, 142);
            this.msk_fecha_aten.Mask = "00/00/0000 00:00";
            this.msk_fecha_aten.Name = "msk_fecha_aten";
            this.msk_fecha_aten.Size = new System.Drawing.Size(123, 23);
            this.msk_fecha_aten.TabIndex = 99;
            this.msk_fecha_aten.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_fecha_atenc
            // 
            this.lbl_fecha_atenc.AutoSize = true;
            this.lbl_fecha_atenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_atenc.Location = new System.Drawing.Point(840, 145);
            this.lbl_fecha_atenc.Name = "lbl_fecha_atenc";
            this.lbl_fecha_atenc.Size = new System.Drawing.Size(51, 17);
            this.lbl_fecha_atenc.TabIndex = 98;
            this.lbl_fecha_atenc.Text = "Fecha:";
            // 
            // lbl_importe_atencion
            // 
            this.lbl_importe_atencion.AutoSize = true;
            this.lbl_importe_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_importe_atencion.Location = new System.Drawing.Point(353, 146);
            this.lbl_importe_atencion.Name = "lbl_importe_atencion";
            this.lbl_importe_atencion.Size = new System.Drawing.Size(59, 17);
            this.lbl_importe_atencion.TabIndex = 96;
            this.lbl_importe_atencion.Text = "Importe:";
            // 
            // lbl_practica_atencion
            // 
            this.lbl_practica_atencion.AutoSize = true;
            this.lbl_practica_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_practica_atencion.Location = new System.Drawing.Point(511, 146);
            this.lbl_practica_atencion.Name = "lbl_practica_atencion";
            this.lbl_practica_atencion.Size = new System.Drawing.Size(63, 17);
            this.lbl_practica_atencion.TabIndex = 95;
            this.lbl_practica_atencion.Text = "Practica:";
            // 
            // txt_importe_aten
            // 
            this.txt_importe_aten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_importe_aten.Location = new System.Drawing.Point(424, 143);
            this.txt_importe_aten.Name = "txt_importe_aten";
            this.txt_importe_aten.Size = new System.Drawing.Size(58, 23);
            this.txt_importe_aten.TabIndex = 93;
            // 
            // cmb_practica_atencion
            // 
            this.cmb_practica_atencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_practica_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_practica_atencion.FormattingEnabled = true;
            this.cmb_practica_atencion.Location = new System.Drawing.Point(580, 142);
            this.cmb_practica_atencion.Name = "cmb_practica_atencion";
            this.cmb_practica_atencion.Size = new System.Drawing.Size(220, 24);
            this.cmb_practica_atencion.TabIndex = 92;
            // 
            // lbl_profesional_atencion
            // 
            this.lbl_profesional_atencion.AutoSize = true;
            this.lbl_profesional_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesional_atencion.Location = new System.Drawing.Point(15, 146);
            this.lbl_profesional_atencion.Name = "lbl_profesional_atencion";
            this.lbl_profesional_atencion.Size = new System.Drawing.Size(83, 17);
            this.lbl_profesional_atencion.TabIndex = 90;
            this.lbl_profesional_atencion.Text = "Profesional:";
            // 
            // lbl_esp_atencion
            // 
            this.lbl_esp_atencion.AutoSize = true;
            this.lbl_esp_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_esp_atencion.Location = new System.Drawing.Point(6, 87);
            this.lbl_esp_atencion.Name = "lbl_esp_atencion";
            this.lbl_esp_atencion.Size = new System.Drawing.Size(92, 17);
            this.lbl_esp_atencion.TabIndex = 89;
            this.lbl_esp_atencion.Text = "Especialidad:";
            // 
            // lbl_centro_atencion
            // 
            this.lbl_centro_atencion.AutoSize = true;
            this.lbl_centro_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_centro_atencion.Location = new System.Drawing.Point(44, 31);
            this.lbl_centro_atencion.Name = "lbl_centro_atencion";
            this.lbl_centro_atencion.Size = new System.Drawing.Size(54, 17);
            this.lbl_centro_atencion.TabIndex = 88;
            this.lbl_centro_atencion.Text = "Centro:";
            // 
            // cmb_prof_atencion
            // 
            this.cmb_prof_atencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_prof_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_prof_atencion.FormattingEnabled = true;
            this.cmb_prof_atencion.Location = new System.Drawing.Point(104, 143);
            this.cmb_prof_atencion.Name = "cmb_prof_atencion";
            this.cmb_prof_atencion.Size = new System.Drawing.Size(222, 24);
            this.cmb_prof_atencion.TabIndex = 87;
            // 
            // cmb_esp_atencion
            // 
            this.cmb_esp_atencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_esp_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_esp_atencion.FormattingEnabled = true;
            this.cmb_esp_atencion.Location = new System.Drawing.Point(104, 84);
            this.cmb_esp_atencion.Name = "cmb_esp_atencion";
            this.cmb_esp_atencion.Size = new System.Drawing.Size(222, 24);
            this.cmb_esp_atencion.TabIndex = 86;
            this.cmb_esp_atencion.SelectionChangeCommitted += new System.EventHandler(this.cmb_esp_atencion_SelectionChangeCommitted);
            // 
            // cmb_centro_atencion
            // 
            this.cmb_centro_atencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_centro_atencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_centro_atencion.FormattingEnabled = true;
            this.cmb_centro_atencion.Location = new System.Drawing.Point(104, 28);
            this.cmb_centro_atencion.Name = "cmb_centro_atencion";
            this.cmb_centro_atencion.Size = new System.Drawing.Size(222, 24);
            this.cmb_centro_atencion.TabIndex = 85;
            this.cmb_centro_atencion.SelectionChangeCommitted += new System.EventHandler(this.cmb_centro_atencion_SelectionChangeCommitted);
            // 
            // grd_atenciones
            // 
            this.grd_atenciones.AllowUserToAddRows = false;
            this.grd_atenciones.AllowUserToDeleteRows = false;
            this.grd_atenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_atenciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_atencion,
            this.nro_afiliado,
            this.afiliado,
            this.fecha_hora,
            this.cod_centro,
            this.centro,
            this.cod_especialidad,
            this.especialidad,
            this.matricula,
            this.profesional,
            this.importe,
            this.id_practica,
            this.practica});
            this.grd_atenciones.Location = new System.Drawing.Point(12, 226);
            this.grd_atenciones.Name = "grd_atenciones";
            this.grd_atenciones.ReadOnly = true;
            this.grd_atenciones.Size = new System.Drawing.Size(1145, 262);
            this.grd_atenciones.TabIndex = 1;
            this.grd_atenciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_atenciones_CellClick);
            // 
            // btn_agregar_atencion
            // 
            this.btn_agregar_atencion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregar_atencion.BackgroundImage")));
            this.btn_agregar_atencion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar_atencion.Location = new System.Drawing.Point(12, 513);
            this.btn_agregar_atencion.Name = "btn_agregar_atencion";
            this.btn_agregar_atencion.Size = new System.Drawing.Size(50, 50);
            this.btn_agregar_atencion.TabIndex = 96;
            this.tt_atenciones.SetToolTip(this.btn_agregar_atencion, "Agregar atencion");
            this.btn_agregar_atencion.UseVisualStyleBackColor = true;
            this.btn_agregar_atencion.Click += new System.EventHandler(this.btn_agregar_atencion_Click);
            // 
            // btn_limpiar_atencion
            // 
            this.btn_limpiar_atencion.Location = new System.Drawing.Point(152, 540);
            this.btn_limpiar_atencion.Name = "btn_limpiar_atencion";
            this.btn_limpiar_atencion.Size = new System.Drawing.Size(112, 23);
            this.btn_limpiar_atencion.TabIndex = 98;
            this.btn_limpiar_atencion.Text = "Reiniciar Formulario";
            this.btn_limpiar_atencion.UseVisualStyleBackColor = true;
            this.btn_limpiar_atencion.Click += new System.EventHandler(this.btn_limpiar_atencion_Click);
            // 
            // btn_salir_atencion
            // 
            this.btn_salir_atencion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir_atencion.BackgroundImage")));
            this.btn_salir_atencion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir_atencion.Location = new System.Drawing.Point(1098, 513);
            this.btn_salir_atencion.Name = "btn_salir_atencion";
            this.btn_salir_atencion.Size = new System.Drawing.Size(50, 50);
            this.btn_salir_atencion.TabIndex = 99;
            this.tt_atenciones.SetToolTip(this.btn_salir_atencion, "Salir");
            this.btn_salir_atencion.UseVisualStyleBackColor = true;
            this.btn_salir_atencion.Click += new System.EventHandler(this.btn_salir_atencion_Click);
            // 
            // btn_editar_atencion
            // 
            this.btn_editar_atencion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar_atencion.BackgroundImage")));
            this.btn_editar_atencion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar_atencion.Location = new System.Drawing.Point(68, 513);
            this.btn_editar_atencion.Name = "btn_editar_atencion";
            this.btn_editar_atencion.Size = new System.Drawing.Size(50, 50);
            this.btn_editar_atencion.TabIndex = 100;
            this.tt_atenciones.SetToolTip(this.btn_editar_atencion, "Editar una atencion");
            this.btn_editar_atencion.UseVisualStyleBackColor = true;
            this.btn_editar_atencion.Click += new System.EventHandler(this.btn_editar_atencion_Click);
            // 
            // id_atencion
            // 
            this.id_atencion.HeaderText = "IdAtencion";
            this.id_atencion.Name = "id_atencion";
            this.id_atencion.ReadOnly = true;
            this.id_atencion.Visible = false;
            // 
            // nro_afiliado
            // 
            this.nro_afiliado.HeaderText = "NroAfiliado";
            this.nro_afiliado.Name = "nro_afiliado";
            this.nro_afiliado.ReadOnly = true;
            this.nro_afiliado.Visible = false;
            // 
            // afiliado
            // 
            this.afiliado.HeaderText = "Afiliado";
            this.afiliado.Name = "afiliado";
            this.afiliado.ReadOnly = true;
            this.afiliado.Width = 200;
            // 
            // fecha_hora
            // 
            this.fecha_hora.HeaderText = "Fecha Y Hora";
            this.fecha_hora.Name = "fecha_hora";
            this.fecha_hora.ReadOnly = true;
            this.fecha_hora.Width = 150;
            // 
            // cod_centro
            // 
            this.cod_centro.HeaderText = "CodCentro";
            this.cod_centro.Name = "cod_centro";
            this.cod_centro.ReadOnly = true;
            this.cod_centro.Visible = false;
            // 
            // centro
            // 
            this.centro.HeaderText = "Centro";
            this.centro.Name = "centro";
            this.centro.ReadOnly = true;
            this.centro.Width = 200;
            // 
            // cod_especialidad
            // 
            this.cod_especialidad.HeaderText = "CodEspecialidad";
            this.cod_especialidad.Name = "cod_especialidad";
            this.cod_especialidad.ReadOnly = true;
            this.cod_especialidad.Visible = false;
            // 
            // especialidad
            // 
            this.especialidad.HeaderText = "Especialidad";
            this.especialidad.Name = "especialidad";
            this.especialidad.ReadOnly = true;
            this.especialidad.Width = 150;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            this.matricula.Visible = false;
            // 
            // profesional
            // 
            this.profesional.HeaderText = "Profesional";
            this.profesional.Name = "profesional";
            this.profesional.ReadOnly = true;
            this.profesional.Width = 200;
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            this.importe.Width = 50;
            // 
            // id_practica
            // 
            this.id_practica.HeaderText = "IdPractica";
            this.id_practica.Name = "id_practica";
            this.id_practica.ReadOnly = true;
            this.id_practica.Visible = false;
            // 
            // practica
            // 
            this.practica.HeaderText = "Practica";
            this.practica.Name = "practica";
            this.practica.ReadOnly = true;
            this.practica.Width = 150;
            // 
            // frm_Atenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 575);
            this.Controls.Add(this.btn_editar_atencion);
            this.Controls.Add(this.btn_salir_atencion);
            this.Controls.Add(this.btn_limpiar_atencion);
            this.Controls.Add(this.btn_agregar_atencion);
            this.Controls.Add(this.grd_atenciones);
            this.Controls.Add(this.grp_atenciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Atenciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atenciones";
            this.Load += new System.EventHandler(this.frm_Atenciones_Load);
            this.grp_atenciones.ResumeLayout(false);
            this.grp_atenciones.PerformLayout();
            this.grp_buscar_afi_atencion.ResumeLayout(false);
            this.grp_buscar_afi_atencion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_atenciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_atenciones;
        private System.Windows.Forms.ComboBox cmb_prof_atencion;
        private System.Windows.Forms.ComboBox cmb_esp_atencion;
        private System.Windows.Forms.ComboBox cmb_centro_atencion;
        private System.Windows.Forms.Label lbl_profesional_atencion;
        private System.Windows.Forms.Label lbl_esp_atencion;
        private System.Windows.Forms.Label lbl_centro_atencion;
        private System.Windows.Forms.ComboBox cmb_practica_atencion;
        private System.Windows.Forms.Label lbl_apellido_afi_atencion;
        private System.Windows.Forms.TextBox txt_importe_aten;
        private System.Windows.Forms.Label lbl_practica_atencion;
        private System.Windows.Forms.Label lbl_importe_atencion;
        private System.Windows.Forms.MaskedTextBox msk_fecha_aten;
        private System.Windows.Forms.Label lbl_fecha_atenc;
        private System.Windows.Forms.DataGridView grd_atenciones;
        private System.Windows.Forms.Button btn_agregar_atencion;
        private System.Windows.Forms.Button btn_limpiar_atencion;
        private System.Windows.Forms.Button btn_salir_atencion;
        private System.Windows.Forms.GroupBox grp_buscar_afi_atencion;
        private System.Windows.Forms.Button btn_buscar_afi_atencion;
        private System.Windows.Forms.TextBox txt_num_afi_ate;
        private System.Windows.Forms.Label lbl_resultados_ate;
        private System.Windows.Forms.Label lbl_nombre_afi_atencion;
        private System.Windows.Forms.Label lbl_ape_afi_aten;
        private System.Windows.Forms.TextBox txt_nombre_afi_atencion;
        private System.Windows.Forms.TextBox txt_apellido_afi_atencion;
        private System.Windows.Forms.ComboBox cmb_resultados;
        private System.Windows.Forms.Button btn_limpiar_filtros_aten;
        private System.Windows.Forms.Button btn_editar_atencion;
        private System.Windows.Forms.ToolTip tt_atenciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_atencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_centro;
        private System.Windows.Forms.DataGridViewTextBoxColumn centro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_practica;
        private System.Windows.Forms.DataGridViewTextBoxColumn practica;
    }
}