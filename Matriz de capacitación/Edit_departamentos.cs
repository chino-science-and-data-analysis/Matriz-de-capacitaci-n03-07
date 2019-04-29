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
    public partial class Edit_departamentos : MetroFramework.Forms.MetroForm
    {
        public Edit_departamentos()
        {
            InitializeComponent();
        }

        public void Edit_departamento_Load(object sender, EventArgs e)
        {
            
            this.txtclavedep.ReadOnly = true;
            this.AcceptButton = button1;
            this.txt_altadepartamento.Focus();
            this.txt_altadepartamento.Select();
        }
        datos obDatos = new datos();
        private void button1_Click(object sender, EventArgs e)
        {
            string campos = "Nombre='" + this.txt_altadepartamento.Text + "'";
            if (obDatos.actualizar("tbl_departamentos", campos, "Id_Departamento='" + this.txtclavedep.Text + "'"))
            {
                MessageBox.Show("Se actualizó correctamente");
                OBFiltro.txt_buscar.Select();
                this.Close();
            }
            else
            {
                MessageBox.Show("Campos invalidos");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OBFiltro.txt_buscar.Select();
            this.Close();
        }
        frm_departamentos OBFiltro = new frm_departamentos();
    }
}
