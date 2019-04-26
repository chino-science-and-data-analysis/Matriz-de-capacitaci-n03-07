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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton4_Click(object sender, EventArgs e)
        {

        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alta_colaboradores ColaboradoresOb = new Alta_colaboradores();
            ColaboradoresOb.Show();
        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frm_login LoginOb = new frm_login();
            LoginOb.Show();
        }

        private void externasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alta_curso_externo ExternoOb = new Alta_curso_externo();
            ExternoOb.Show();
        }

        private void capacitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void áreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alta_area AltaareaOB = new Alta_area();
            AltaareaOB.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alta_usuarios AltaUsuerOb = new Alta_usuarios();
            AltaUsuerOb.Show();
            
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alta_departamento AltadepOb = new Alta_departamento();
            AltadepOb.Show();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
