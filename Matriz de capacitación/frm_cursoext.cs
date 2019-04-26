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
    public partial class frm_cursoext : Form
    {
        public frm_cursoext()
        {
            InitializeComponent();
        }
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_curso_externo cursoextOb = new Alta_curso_externo();
            cursoextOb.Show();
        }

        private void frm_cursoext_Load(object sender, EventArgs e)
        {
            /*obDatos.consultar("SELECT * FROM tbl_cursoexterno", "tbl_cursoexterno");
            this.dataGridColaboradores.DataSource = obDatos.ds.Tables["tbl_ccursoexterno"];
            this.dataGridColaboradores.Refresh();*/
        }
        //datos obDatos = new datos();

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
