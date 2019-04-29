using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Matriz_de_capacitación
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "Usuario")
            {
                txt_user.Text = "";
                txt_user.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if(txt_user.Text=="")
            {
                txt_user.Text = "Usuario";
                txt_user.ForeColor = Color.DarkGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Contraseña")
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.Black;
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text=="")
            {
                txt_pass.Text = "Contraseña";
                txt_pass.ForeColor = Color.DarkGray;
                txt_pass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Resizable = false;
            this.AcceptButton = btn_login;
            // this.textBox1.CharacterCasing = CharacterCasing.Upper;
            // this.textBox2.CharacterCasing = CharacterCasing.Upper;
            txt_user.Focus();
            txt_user.Select();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if
                (
                string.IsNullOrEmpty(txt_user.Text)
                )
            {
                MessageBox.Show("Usuario invalido");
                return;

            }
            else
            {
                Usuarios UsuarioOb = new Usuarios();
                UsuarioOb.Usuario = this.txt_user.Text;
                UsuarioOb.Contraseña = this.txt_pass.Text;

                if (UsuarioOb.Buscar() == true)
                {
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña invalidos", "Error");
                    txt_pass.SelectAll();
                }

            }
        }
    }
}
