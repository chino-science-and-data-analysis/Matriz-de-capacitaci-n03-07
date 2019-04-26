namespace Matriz_de_capacitación
{
    partial class Edit_areas
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
            this.txt_careaed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_areaed = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nareaed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelararea = new System.Windows.Forms.Button();
            this.btnaceptararea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_careaed
            // 
            this.txt_careaed.Location = new System.Drawing.Point(130, 114);
            this.txt_careaed.Name = "txt_careaed";
            this.txt_careaed.Size = new System.Drawing.Size(150, 20);
            this.txt_careaed.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "CLAVE DE ÁREA";
            // 
            // cmb_areaed
            // 
            this.cmb_areaed.AccessibleDescription = "";
            this.cmb_areaed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_areaed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_areaed.DropDownHeight = 300;
            this.cmb_areaed.DropDownWidth = 200;
            this.cmb_areaed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_areaed.IntegralHeight = false;
            this.cmb_areaed.ItemHeight = 13;
            this.cmb_areaed.Location = new System.Drawing.Point(130, 74);
            this.cmb_areaed.MaxDropDownItems = 50;
            this.cmb_areaed.MaxLength = 50;
            this.cmb_areaed.Name = "cmb_areaed";
            this.cmb_areaed.Size = new System.Drawing.Size(150, 21);
            this.cmb_areaed.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "DEPARTAMENTO";
            // 
            // txt_nareaed
            // 
            this.txt_nareaed.Location = new System.Drawing.Point(130, 154);
            this.txt_nareaed.Name = "txt_nareaed";
            this.txt_nareaed.Size = new System.Drawing.Size(150, 20);
            this.txt_nareaed.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "NOMBRE";
            // 
            // btncancelararea
            // 
            this.btncancelararea.Location = new System.Drawing.Point(170, 205);
            this.btncancelararea.Name = "btncancelararea";
            this.btncancelararea.Size = new System.Drawing.Size(80, 20);
            this.btncancelararea.TabIndex = 19;
            this.btncancelararea.Text = "Cancelar";
            this.btncancelararea.UseVisualStyleBackColor = true;
            this.btncancelararea.Click += new System.EventHandler(this.btncancelararea_Click);
            // 
            // btnaceptararea
            // 
            this.btnaceptararea.Location = new System.Drawing.Point(40, 205);
            this.btnaceptararea.Name = "btnaceptararea";
            this.btnaceptararea.Size = new System.Drawing.Size(80, 20);
            this.btnaceptararea.TabIndex = 18;
            this.btnaceptararea.Text = "Guardar";
            this.btnaceptararea.UseVisualStyleBackColor = true;
            this.btnaceptararea.Click += new System.EventHandler(this.btnaceptararea_Click);
            // 
            // Edit_areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.txt_careaed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_areaed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nareaed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelararea);
            this.Controls.Add(this.btnaceptararea);
            this.Name = "Edit_areas";
            this.Text = "Edita área";
            this.Load += new System.EventHandler(this.Edit_areas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancelararea;
        private System.Windows.Forms.Button btnaceptararea;
        public System.Windows.Forms.TextBox txt_careaed;
        public System.Windows.Forms.ComboBox cmb_areaed;
        public System.Windows.Forms.TextBox txt_nareaed;
    }
}