namespace Matriz_de_capacitación
{
    partial class About_departamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PB_departamento = new System.Windows.Forms.PictureBox();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_titular = new System.Windows.Forms.Label();
            this.lbl_Eliminado = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_departamento)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.PB_departamento, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lbl_clave, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lbl_nombre, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lbl_titular, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lbl_Eliminado, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.txtdescripcion, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 60);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(462, 261);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // PB_departamento
            // 
            this.PB_departamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_departamento.Image = global::Matriz_de_capacitación.Properties.Resources.logo_simplificado_Ti_01;
            this.PB_departamento.Location = new System.Drawing.Point(3, 3);
            this.PB_departamento.Name = "PB_departamento";
            this.tableLayoutPanel.SetRowSpan(this.PB_departamento, 6);
            this.PB_departamento.Size = new System.Drawing.Size(120, 120);
            this.PB_departamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_departamento.TabIndex = 12;
            this.PB_departamento.TabStop = false;
            // 
            // lbl_clave
            // 
            this.lbl_clave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_clave.Location = new System.Drawing.Point(158, 0);
            this.lbl_clave.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lbl_clave.MaximumSize = new System.Drawing.Size(0, 17);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(301, 17);
            this.lbl_clave.TabIndex = 19;
            this.lbl_clave.Text = "Clave";
            this.lbl_clave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_nombre.Location = new System.Drawing.Point(158, 26);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lbl_nombre.MaximumSize = new System.Drawing.Size(0, 17);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(301, 17);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_titular
            // 
            this.lbl_titular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_titular.Location = new System.Drawing.Point(158, 52);
            this.lbl_titular.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lbl_titular.MaximumSize = new System.Drawing.Size(0, 17);
            this.lbl_titular.Name = "lbl_titular";
            this.lbl_titular.Size = new System.Drawing.Size(301, 17);
            this.lbl_titular.TabIndex = 21;
            this.lbl_titular.Text = "Titular";
            this.lbl_titular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Eliminado
            // 
            this.lbl_Eliminado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Eliminado.Location = new System.Drawing.Point(158, 78);
            this.lbl_Eliminado.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lbl_Eliminado.MaximumSize = new System.Drawing.Size(0, 17);
            this.lbl_Eliminado.Name = "lbl_Eliminado";
            this.lbl_Eliminado.Size = new System.Drawing.Size(301, 17);
            this.lbl_Eliminado.TabIndex = 22;
            this.lbl_Eliminado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtdescripcion.Location = new System.Drawing.Point(158, 107);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.ReadOnly = true;
            this.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtdescripcion.Size = new System.Drawing.Size(301, 124);
            this.txtdescripcion.TabIndex = 23;
            this.txtdescripcion.TabStop = false;
            this.txtdescripcion.Text = "Descripción";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(384, 237);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 21);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            // 
            // About_departamentos
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 330);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About_departamentos";
            this.Padding = new System.Windows.Forms.Padding(9, 60, 9, 9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle Departamento";
            this.Load += new System.EventHandler(this.About_departamentos_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_departamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        public System.Windows.Forms.PictureBox PB_departamento;
        public System.Windows.Forms.Label lbl_clave;
        public System.Windows.Forms.Label lbl_nombre;
        public System.Windows.Forms.Label lbl_titular;
        public System.Windows.Forms.Label lbl_Eliminado;
        public System.Windows.Forms.TextBox txtdescripcion;
    }
}
