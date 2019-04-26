namespace Matriz_de_capacitación
{
    partial class Alta_departamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_altadepartamento = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btnsavedep = new System.Windows.Forms.Button();
            this.txtclavedep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_int = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOMBRE";
            // 
            // txt_altadepartamento
            // 
            this.txt_altadepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_altadepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_altadepartamento.Location = new System.Drawing.Point(97, 131);
            this.txt_altadepartamento.Name = "txt_altadepartamento";
            this.txt_altadepartamento.Size = new System.Drawing.Size(150, 20);
            this.txt_altadepartamento.TabIndex = 2;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(172, 203);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(80, 20);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnsavedep
            // 
            this.btnsavedep.Location = new System.Drawing.Point(30, 203);
            this.btnsavedep.Name = "btnsavedep";
            this.btnsavedep.Size = new System.Drawing.Size(80, 20);
            this.btnsavedep.TabIndex = 3;
            this.btnsavedep.Text = "Guardar";
            this.btnsavedep.UseVisualStyleBackColor = true;
            this.btnsavedep.Click += new System.EventHandler(this.btnsavedep_Click);
            // 
            // txtclavedep
            // 
            this.txtclavedep.Location = new System.Drawing.Point(97, 86);
            this.txtclavedep.MaxLength = 6;
            this.txtclavedep.Name = "txtclavedep";
            this.txtclavedep.Size = new System.Drawing.Size(150, 20);
            this.txtclavedep.TabIndex = 1;
            this.txtclavedep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclavedep_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CLAVE";
            // 
            // lbl_int
            // 
            this.lbl_int.AutoSize = true;
            this.lbl_int.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_int.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_int.ForeColor = System.Drawing.Color.Red;
            this.lbl_int.Location = new System.Drawing.Point(98, 71);
            this.lbl_int.Name = "lbl_int";
            this.lbl_int.Size = new System.Drawing.Size(148, 12);
            this.lbl_int.TabIndex = 0;
            this.lbl_int.Text = "Sólo se admiten valores númericos";
            this.lbl_int.Visible = false;
            // 
            // Alta_departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(280, 250);
            this.Controls.Add(this.lbl_int);
            this.Controls.Add(this.txtclavedep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btnsavedep);
            this.Controls.Add(this.txt_altadepartamento);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Alta_departamento";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Resizable = false;
            this.Text = "Nuevo Departamento";
            this.Load += new System.EventHandler(this.Altadepartamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btnsavedep;
        public System.Windows.Forms.TextBox txt_altadepartamento;
        public System.Windows.Forms.TextBox txtclavedep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_int;
    }
}