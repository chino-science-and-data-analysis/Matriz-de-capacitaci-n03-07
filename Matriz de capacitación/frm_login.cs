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
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if(txtuser.Text=="")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text=="")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
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
            this.AcceptButton = btnlogin;
            // this.textBox1.CharacterCasing = CharacterCasing.Upper;
            // this.textBox2.CharacterCasing = CharacterCasing.Upper;
            txtuser.Focus();
            txtuser.Select();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if
                (
                string.IsNullOrEmpty(txtuser.Text)
                )
            {
                MessageBox.Show("Usuario invalido");
                return;

            }
            else
            {
                Usuarios UsuarioOb = new Usuarios();
                UsuarioOb.Usuario = this.txtuser.Text;
                UsuarioOb.Contraseña = this.txtpass.Text;

                if (UsuarioOb.Buscar() == true)
                {
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña invalidos", "Error");
                    txtpass.SelectAll();
                }

            }
        }
    }
}
