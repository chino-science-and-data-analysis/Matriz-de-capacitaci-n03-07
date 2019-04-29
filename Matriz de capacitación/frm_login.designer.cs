namespace Matriz_de_capacitación
{
    partial class frm_login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.picbx_logo = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_link = new System.Windows.Forms.LinkLabel();
            this.lbl_matriz = new System.Windows.Forms.Label();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_logo
            // 
            this.pnl_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(33)))));
            this.pnl_logo.Controls.Add(this.picbx_logo);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(202, 270);
            this.pnl_logo.TabIndex = 0;
            this.pnl_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // picbx_logo
            // 
            this.picbx_logo.BackColor = System.Drawing.Color.Transparent;
            this.picbx_logo.Image = ((System.Drawing.Image)(resources.GetObject("picbx_logo.Image")));
            this.picbx_logo.Location = new System.Drawing.Point(-9, 64);
            this.picbx_logo.Name = "picbx_logo";
            this.picbx_logo.Size = new System.Drawing.Size(220, 133);
            this.picbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_logo.TabIndex = 0;
            this.picbx_logo.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(623, 270);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Black;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 227;
            this.lineShape2.X2 = 576;
            this.lineShape2.Y1 = 145;
            this.lineShape2.Y2 = 145;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Black;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 227;
            this.lineShape1.X2 = 575;
            this.lineShape1.Y1 = 80;
            this.lineShape1.Y2 = 80;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.Gray;
            this.txt_user.Location = new System.Drawing.Point(225, 60);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(352, 20);
            this.txt_user.TabIndex = 1;
            this.txt_user.Text = "Usuario";
            this.txt_user.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txt_user.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.Gray;
            this.txt_pass.Location = new System.Drawing.Point(225, 125);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(352, 20);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.Text = "Contraseña";
            this.txt_pass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txt_pass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // lbl_link
            // 
            this.lbl_link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl_link.AutoSize = true;
            this.lbl_link.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_link.LinkColor = System.Drawing.Color.DimGray;
            this.lbl_link.Location = new System.Drawing.Point(307, 210);
            this.lbl_link.Name = "lbl_link";
            this.lbl_link.Size = new System.Drawing.Size(182, 17);
            this.lbl_link.TabIndex = 0;
            this.lbl_link.TabStop = true;
            this.lbl_link.Text = "¿Ha olvidado contraseña?";
            this.lbl_link.Visible = false;
            // 
            // lbl_matriz
            // 
            this.lbl_matriz.AutoSize = true;
            this.lbl_matriz.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matriz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(101)))));
            this.lbl_matriz.Location = new System.Drawing.Point(222, 21);
            this.lbl_matriz.Name = "lbl_matriz";
            this.lbl_matriz.Size = new System.Drawing.Size(358, 33);
            this.lbl_matriz.TabIndex = 9;
            this.lbl_matriz.Text = "MATRIZ DE CAPACITACIÓN";
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(585, 3);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(15, 15);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 8;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(601, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(15, 15);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 7;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(33)))));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(101)))));
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            this.btn_login.Image = global::Matriz_de_capacitación.Properties.Resources.logout__1_1;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(326, 162);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(150, 45);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "INGRESAR";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(623, 270);
            this.Controls.Add(this.lbl_matriz);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.lbl_link);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.pnl_logo);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_login";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pnl_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_logo;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel lbl_link;
        private System.Windows.Forms.PictureBox picbx_logo;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.Label lbl_matriz;
    }
}

