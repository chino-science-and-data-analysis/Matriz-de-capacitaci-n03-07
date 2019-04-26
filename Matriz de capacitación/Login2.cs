using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_de_capacitación
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Resizable = false;
            this.AcceptButton = button1;
           // this.textBox1.CharacterCasing = CharacterCasing.Upper;
           // this.textBox2.CharacterCasing = CharacterCasing.Upper;
            textUsuario.Focus();
            textUsuario.Select();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if
                (
                string.IsNullOrEmpty(textUsuario.Text)
                )
            {
                MessageBox.Show("Usuario invalido");
                return;

            }
            else
            {
                Usuarios UserOb = new Usuarios();
                UserOb.Usuario = this.textUsuario.Text;
                UserOb.Contraseña = this.textContraseña.Text;
                if (UserOb.Buscar() == true)
                {
                    this.Hide();
                    Main MainOb = new Main();
                    MainOb.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña invalidos", "Error");
                    textContraseña.SelectAll();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            //if (e.KeyCode == Keys.Enter)
            //{
            //  button1.PerformClick();
            // }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        // private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //  if (e.KeyChar.Equals(Convert.ToChar(13)))
        //{
        //  button1_Click(sender, e);
        //}
        //  }

    }
}
