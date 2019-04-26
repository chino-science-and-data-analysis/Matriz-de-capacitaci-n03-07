namespace Matriz_de_capacitación
{
    partial class Alta_area
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
            this.txtnarea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelararea = new System.Windows.Forms.Button();
            this.btnaceptararea = new System.Windows.Forms.Button();
            this.cmbdepartamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcarea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnarea
            // 
            this.txtnarea.Location = new System.Drawing.Point(130, 154);
            this.txtnarea.Name = "txtnarea";
            this.txtnarea.Size = new System.Drawing.Size(150, 20);
            this.txtnarea.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "NOMBRE";
            // 
            // btncancelararea
            // 
            this.btncancelararea.Location = new System.Drawing.Point(170, 205);
            this.btncancelararea.Name = "btncancelararea";
            this.btncancelararea.Size = new System.Drawing.Size(80, 20);
            this.btncancelararea.TabIndex = 5;
            this.btncancelararea.Text = "Cancelar";
            this.btncancelararea.UseVisualStyleBackColor = true;
            this.btncancelararea.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnaceptararea
            // 
            this.btnaceptararea.Location = new System.Drawing.Point(40, 205);
            this.btnaceptararea.Name = "btnaceptararea";
            this.btnaceptararea.Size = new System.Drawing.Size(80, 20);
            this.btnaceptararea.TabIndex = 4;
            this.btnaceptararea.Text = "Guardar";
            this.btnaceptararea.UseVisualStyleBackColor = true;
            this.btnaceptararea.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbdepartamento
            // 
            this.cmbdepartamento.AccessibleDescription = "";
            this.cmbdepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbdepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbdepartamento.DropDownHeight = 300;
            this.cmbdepartamento.DropDownWidth = 200;
            this.cmbdepartamento.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbdepartamento.IntegralHeight = false;
            this.cmbdepartamento.ItemHeight = 13;
            this.cmbdepartamento.Location = new System.Drawing.Point(130, 74);
            this.cmbdepartamento.MaxDropDownItems = 50;
            this.cmbdepartamento.MaxLength = 50;
            this.cmbdepartamento.Name = "cmbdepartamento";
            this.cmbdepartamento.Size = new System.Drawing.Size(150, 21);
            this.cmbdepartamento.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "DEPARTAMENTO";
            // 
            // txtcarea
            // 
            this.txtcarea.Location = new System.Drawing.Point(130, 114);
            this.txtcarea.Name = "txtcarea";
            this.txtcarea.Size = new System.Drawing.Size(150, 20);
            this.txtcarea.TabIndex = 2;
            this.txtcarea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcarea_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "CLAVE DE ÁREA";
            // 
            // Alta_area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.txtcarea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbdepartamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelararea);
            this.Controls.Add(this.btnaceptararea);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Alta_area";
            this.Resizable = false;
            this.Text = "Nueva área";
            this.Load += new System.EventHandler(this.Alta_area_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancelararea;
        private System.Windows.Forms.Button btnaceptararea;
        private System.Windows.Forms.ComboBox cmbdepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcarea;
        private System.Windows.Forms.Label label3;
    }
}