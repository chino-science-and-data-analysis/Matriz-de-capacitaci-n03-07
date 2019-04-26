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
    public partial class Alta_curso_externo : MetroFramework.Forms.MetroForm
    {
        public Alta_curso_externo()
        {
            InitializeComponent();
        }
        datos obDatos = new datos();
        private void Alta_Curso_Externo_Load(object sender, EventArgs e)
        {
            this.combobanco.DataSource = obDatos.consultar2("cat_bancos");
            this.combobanco.ValueMember = "Id_Banco";
            this.combobanco.DisplayMember = "Nombre";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
