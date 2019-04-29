namespace Matriz_de_capacitación
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.pnl_menulateral = new System.Windows.Forms.Panel();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.pnl_central = new System.Windows.Forms.Panel();
            this.pnl_inferior = new System.Windows.Forms.Panel();
            this.lblpPuestousuario = new System.Windows.Forms.Label();
            this.lbl_apellidousuario = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.tmr_ocultar = new System.Windows.Forms.Timer(this.components);
            this.tmr_mostrar = new System.Windows.Forms.Timer(this.components);
            this.tmr_fecha = new System.Windows.Forms.Timer(this.components);
            this.btn_menu = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.btn_maximizar = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.picbx_usuario = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_inicio2 = new System.Windows.Forms.PictureBox();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_capacitaciones = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.PictureBox();
            this.btn_colaboradores = new System.Windows.Forms.Button();
            this.btn_departamentos = new System.Windows.Forms.Button();
            this.btn_areas = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_puestos = new System.Windows.Forms.Button();
            this.pnl_menulateral.SuspendLayout();
            this.pnl_titulo.SuspendLayout();
            this.pnl_inferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_inicio2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_inicio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menulateral
            // 
            this.pnl_menulateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(33)))));
            this.pnl_menulateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_menulateral.Controls.Add(this.btn_logout);
            this.pnl_menulateral.Controls.Add(this.btn_inicio2);
            this.pnl_menulateral.Controls.Add(this.btn_reportes);
            this.pnl_menulateral.Controls.Add(this.btn_capacitaciones);
            this.pnl_menulateral.Controls.Add(this.btn_inicio);
            this.pnl_menulateral.Controls.Add(this.btn_colaboradores);
            this.pnl_menulateral.Controls.Add(this.btn_departamentos);
            this.pnl_menulateral.Controls.Add(this.btn_areas);
            this.pnl_menulateral.Controls.Add(this.btn_usuarios);
            this.pnl_menulateral.Controls.Add(this.btn_puestos);
            this.pnl_menulateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menulateral.Location = new System.Drawing.Point(0, 0);
            this.pnl_menulateral.Name = "pnl_menulateral";
            this.pnl_menulateral.Size = new System.Drawing.Size(250, 600);
            this.pnl_menulateral.TabIndex = 0;
            this.pnl_menulateral.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(193)))), ((int)(((byte)(198)))));
            this.lbl_fecha.Location = new System.Drawing.Point(548, 39);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_fecha.Size = new System.Drawing.Size(399, 33);
            this.lbl_fecha.TabIndex = 6;
            this.lbl_fecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // lbl_hora
            // 
            this.lbl_hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(198)))));
            this.lbl_hora.Location = new System.Drawing.Point(659, -10);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_hora.Size = new System.Drawing.Size(176, 49);
            this.lbl_hora.TabIndex = 5;
            this.lbl_hora.Text = "21:49:45";
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(198)))));
            this.pnl_titulo.Controls.Add(this.btn_menu);
            this.pnl_titulo.Controls.Add(this.btn_minimizar);
            this.pnl_titulo.Controls.Add(this.btn_restaurar);
            this.pnl_titulo.Controls.Add(this.btn_maximizar);
            this.pnl_titulo.Controls.Add(this.btn_cerrar);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(250, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(950, 40);
            this.pnl_titulo.TabIndex = 0;
            this.pnl_titulo.DoubleClick += new System.EventHandler(this.iconmaximizar_Click);
            this.pnl_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            // 
            // pnl_central
            // 
            this.pnl_central.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_central.Location = new System.Drawing.Point(250, 40);
            this.pnl_central.Name = "pnl_central";
            this.pnl_central.Size = new System.Drawing.Size(950, 490);
            this.pnl_central.TabIndex = 1;
            this.pnl_central.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // pnl_inferior
            // 
            this.pnl_inferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(101)))));
            this.pnl_inferior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_inferior.Controls.Add(this.lbl_hora);
            this.pnl_inferior.Controls.Add(this.lblpPuestousuario);
            this.pnl_inferior.Controls.Add(this.lbl_fecha);
            this.pnl_inferior.Controls.Add(this.lbl_apellidousuario);
            this.pnl_inferior.Controls.Add(this.lbl_usuario);
            this.pnl_inferior.Controls.Add(this.picbx_usuario);
            this.pnl_inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_inferior.Location = new System.Drawing.Point(250, 530);
            this.pnl_inferior.Name = "pnl_inferior";
            this.pnl_inferior.Size = new System.Drawing.Size(950, 70);
            this.pnl_inferior.TabIndex = 2;
            // 
            // lblpPuestousuario
            // 
            this.lblpPuestousuario.AutoSize = true;
            this.lblpPuestousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpPuestousuario.ForeColor = System.Drawing.Color.Black;
            this.lblpPuestousuario.Location = new System.Drawing.Point(64, 45);
            this.lblpPuestousuario.Name = "lblpPuestousuario";
            this.lblpPuestousuario.Size = new System.Drawing.Size(141, 18);
            this.lblpPuestousuario.TabIndex = 7;
            this.lblpPuestousuario.Text = "DESARROLLADOR";
            // 
            // lbl_apellidousuario
            // 
            this.lbl_apellidousuario.AutoSize = true;
            this.lbl_apellidousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidousuario.ForeColor = System.Drawing.Color.Black;
            this.lbl_apellidousuario.Location = new System.Drawing.Point(64, 27);
            this.lbl_apellidousuario.Name = "lbl_apellidousuario";
            this.lbl_apellidousuario.Size = new System.Drawing.Size(62, 18);
            this.lbl_apellidousuario.TabIndex = 6;
            this.lbl_apellidousuario.Text = "ID_2210";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.Black;
            this.lbl_usuario.Location = new System.Drawing.Point(64, 9);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(97, 18);
            this.lbl_usuario.TabIndex = 5;
            this.lbl_usuario.Text = "ALEJANDRO";
            // 
            // tmr_ocultar
            // 
            this.tmr_ocultar.Interval = 40;
            this.tmr_ocultar.Tick += new System.EventHandler(this.tmr_ocultar_Tick);
            // 
            // tmr_mostrar
            // 
            this.tmr_mostrar.Interval = 40;
            this.tmr_mostrar.Tick += new System.EventHandler(this.tmr_mostrar_Tick);
            // 
            // tmr_fecha
            // 
            this.tmr_fecha.Tick += new System.EventHandler(this.tmr_fecha_Tick);
            // 
            // btn_menu
            // 
            this.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.Location = new System.Drawing.Point(6, 3);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(35, 35);
            this.btn_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_menu.TabIndex = 4;
            this.btn_menu.TabStop = false;
            this.btn_menu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = global::Matriz_de_capacitación.Properties.Resources.Minimize;
            this.btn_minimizar.Location = new System.Drawing.Point(894, 10);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(20, 20);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 3;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restaurar.Image = global::Matriz_de_capacitación.Properties.Resources.Normal;
            this.btn_restaurar.Location = new System.Drawing.Point(922, 10);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(20, 20);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restaurar.TabIndex = 2;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Visible = false;
            this.btn_restaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_maximizar.Image = global::Matriz_de_capacitación.Properties.Resources.maximize3;
            this.btn_maximizar.Location = new System.Drawing.Point(922, 10);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(20, 20);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximizar.TabIndex = 1;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Click += new System.EventHandler(this.iconmaximizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(69, 0);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(35, 40);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Visible = false;
            this.btn_cerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // picbx_usuario
            // 
            this.picbx_usuario.BackColor = System.Drawing.Color.Transparent;
            this.picbx_usuario.BackgroundImage = global::Matriz_de_capacitación.Properties.Resources.boss_man_128;
            this.picbx_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbx_usuario.Location = new System.Drawing.Point(6, 10);
            this.picbx_usuario.Name = "picbx_usuario";
            this.picbx_usuario.Size = new System.Drawing.Size(50, 50);
            this.picbx_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_usuario.TabIndex = 3;
            this.picbx_usuario.TabStop = false;
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BackgroundImage = global::Matriz_de_capacitación.Properties.Resources.salir__;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(101)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(0, 545);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(55, 55);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btm_Logout_Click);
            // 
            // btn_inicio2
            // 
            this.btn_inicio2.BackgroundImage = global::Matriz_de_capacitación.Properties.Resources.logo_simplificado_Ti_01;
            this.btn_inicio2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_inicio2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inicio2.Location = new System.Drawing.Point(1, 12);
            this.btn_inicio2.Name = "btn_inicio2";
            this.btn_inicio2.Size = new System.Drawing.Size(60, 60);
            this.btn_inicio2.TabIndex = 10;
            this.btn_inicio2.TabStop = false;
            this.btn_inicio2.Visible = false;
            this.btn_inicio2.Click += new System.EventHandler(this.btninicio2_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.BackColor = System.Drawing.Color.Transparent;
            this.btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(101)))));
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.ForeColor = System.Drawing.Color.White;
            this.btn_reportes.Image = global::Matriz_de_capacitación.Properties.Resources.bar_graph11;
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Location = new System.Drawing.Point(8, 452);
            this.btn_reportes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(240, 50);
            this.btn_reportes.TabIndex = 6;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reportes.UseVisualStyleBackColor = false;
            this.btn_reportes.Click += new System.EventHandler(this.btnREPORTES_Click);
            // 
            // btn_capacitaciones
            // 
            this.btn_capacitaciones.BackColor = System.Drawing.Color.Transparent;
            this.btn_capacitaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_capacitaciones.FlatAppearance.BorderSize = 0;
            this.btn_capacitaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_capacitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(101)))));
            this.btn_capacitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capacitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capacitaciones.ForeColor = System.Drawing.Color.White;
            this.btn_capacitaciones.Image = global::Matriz_de_capacitación.Properties.Resources.seo1;
            this.btn_capacitaciones.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_capacitaciones.Location = new System.Drawing.Point(8, 393);
            this.btn_capacitaciones.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_capacitaciones.Name = "btn_capacitaciones";
            this.btn_capacitaciones.Size = new System.Drawing.Size(240, 50);
            this.btn_capacitaciones.TabIndex = 5;
            this.btn_capacitaciones.Text = "Capacitaciones";
            this.btn_capacitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capacitaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_capacitaciones.UseVisualStyleBackColor = false;
            this.btn_capacitaciones.Click += new System.EventHandler(this.btncapacitaciones_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.Transparent;
            this.btn_inicio.BackgroundImage = global::Matriz_de_capacitación.Properties.Resources.LogotipoGi;
            this.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inicio.Location = new System.Drawing.Point(5, 12);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(240, 80);
            this.btn_inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_inicio.TabIndex = 0;
            this.btn_inicio.TabStop = false;
            this.btn_inicio.Click += new System.EventHandler(this.btnINICIO_Click);
            // 
            // btn_colaboradores
            // 
            this.btn_colaboradores.BackColor = System.Drawing.Color.Transparent;
            this.btn_colaboradores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_colaboradores.FlatAppearance.BorderSize = 0;
            this.btn_colaboradores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_colaboradores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(101)))));
            this.btn_colaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_colaboradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_colaboradores.ForeColor = System.Drawing.Color.White;
            this.btn_colaboradores.Image = global::Matriz_de_capacitación.Properties.Resources.patient__1_11;
            this.btn_colaboradores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_colaboradores.Location = new System.Drawing.Point(8, 275);
            this.btn_colaboradores.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_colaboradores.Name = "btn_colaboradores";
            this.btn_colaboradores.Size = new System.Drawing.Size(240, 50);
            this.btn_colaboradores.TabIndex = 3;
            this.btn_colaboradores.TabStop = false;
            this.btn_colaboradores.Text = "Colaboradores";
            this.btn_colaboradores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_colaboradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_colaboradores.UseVisualStyleBackColor = false;
            this.btn_colaboradores.Click += new System.EventHandler(this.btncolaboradores_Click);
            // 
            // btn_departamentos
            // 
            this.btn_departamentos.BackColor = System.Drawing.Color.Transparent;
            this.btn_departamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_departamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_departamentos.FlatAppearance.BorderSize = 0;
            this.btn_departamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_departamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(101)))));
            this.btn_departamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_departamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_departamentos.ForeColor = System.Drawing.Color.White;
            this.btn_departamentos.Image = global::Matriz_de_capacitación.Properties.Resources.phone_book__1_1;
            this.btn_departamentos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_departamentos.Location = new System.Drawing.Point(8, 98);
            this.btn_departamentos.Name = "btn_departamentos";
            this.btn_departamentos.Size = new System.Drawing.Size(240, 50);
            this.btn_departamentos.TabIndex = 0;
            this.btn_departamentos.Text = "Departamentos";
            this.btn_departamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_departamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_departamentos.UseVisualStyleBackColor = false;
            this.btn_departamentos.Click += new System.EventHandler(this.btndepartamentos_Click);
            // 
            // btn_areas
            // 
            this.btn_areas.BackColor = System.Drawing.Color.Transparent;
            this.btn_areas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_areas.FlatAppearance.BorderSize = 0;
            this.btn_areas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_areas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(101)))));
            this.btn_areas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_areas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_areas.ForeColor = System.Drawing.Color.White;
            this.btn_areas.Image = global::Matriz_de_capacitación.Properties.Resources.user;
            this.btn_areas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_areas.Location = new System.Drawing.Point(8, 157);
            this.btn_areas.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_areas.Name = "btn_areas";
            this.btn_areas.Size = new System.Drawing.Size(240, 50);
            this.btn_areas.TabIndex = 1;
            this.btn_areas.Text = "   Áreas";
            this.btn_areas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_areas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_areas.UseVisualStyleBackColor = false;
            this.btn_areas.Click += new System.EventHandler(this.btnareas_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.BackColor = System.Drawing.Color.Transparent;
            this.btn_usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usuarios.FlatAppearance.BorderSize = 0;
            this.btn_usuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(101)))));
            this.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.ForeColor = System.Drawing.Color.White;
            this.btn_usuarios.Image = global::Matriz_de_capacitación.Properties.Resources.payment1;
            this.btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuarios.Location = new System.Drawing.Point(8, 334);
            this.btn_usuarios.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(240, 50);
            this.btn_usuarios.TabIndex = 4;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_usuarios.UseVisualStyleBackColor = false;
            this.btn_usuarios.Click += new System.EventHandler(this.btnusuarios_Click);
            // 
            // btn_puestos
            // 
            this.btn_puestos.BackColor = System.Drawing.Color.Transparent;
            this.btn_puestos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_puestos.FlatAppearance.BorderSize = 0;
            this.btn_puestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_puestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(101)))));
            this.btn_puestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_puestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_puestos.ForeColor = System.Drawing.Color.White;
            this.btn_puestos.Image = global::Matriz_de_capacitación.Properties.Resources.person_settings1;
            this.btn_puestos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_puestos.Location = new System.Drawing.Point(8, 216);
            this.btn_puestos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_puestos.Name = "btn_puestos";
            this.btn_puestos.Size = new System.Drawing.Size(240, 50);
            this.btn_puestos.TabIndex = 2;
            this.btn_puestos.Text = "Puestos";
            this.btn_puestos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_puestos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_puestos.UseVisualStyleBackColor = false;
            this.btn_puestos.Click += new System.EventHandler(this.btnpuestos_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.pnl_central);
            this.Controls.Add(this.pnl_titulo);
            this.Controls.Add(this.pnl_inferior);
            this.Controls.Add(this.pnl_menulateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matriz de capacitacíon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_menulateral.ResumeLayout(false);
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_inferior.ResumeLayout(false);
            this.pnl_inferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_inicio2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_inicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_inferior;
        private System.Windows.Forms.Panel pnl_menulateral;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.PictureBox btn_menu;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_restaurar;
        private System.Windows.Forms.PictureBox btn_maximizar;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button btn_puestos;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Button btn_capacitaciones;
        private System.Windows.Forms.Button btn_departamentos;
        private System.Windows.Forms.Button btn_areas;
        private System.Windows.Forms.Button btn_colaboradores;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Timer tmr_ocultar;
        private System.Windows.Forms.Timer tmr_mostrar;
        private System.Windows.Forms.Timer tmr_fecha;
        private System.Windows.Forms.PictureBox btn_inicio;
        private System.Windows.Forms.Label lblpPuestousuario;
        private System.Windows.Forms.Label lbl_apellidousuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.PictureBox picbx_usuario;
        private System.Windows.Forms.PictureBox btn_inicio2;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel pnl_central;

    }
}