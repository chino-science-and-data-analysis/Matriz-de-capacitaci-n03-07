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
    public partial class frm_colaboradores : Form
    {
        datos obDatos = new datos();
        public frm_colaboradores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obDatos.consultar("SELECT Id_Colaborador AS Número_de_empleado,Nombre,Apellido_Paterno,Apellido_Materno FROM tbl_colaboradoresgi WHERE Id_Colaborador!=1", "tbl_colaboradoresgi");
            this.datagrid_gi.DataSource = obDatos.ds.Tables["tbl_colaboradoresgi"];
            this.datagrid_gi.Refresh();

            obDatos.consultar("SELECT * FROM tbl_colaboradoresgi", "tbl_colaboradoresgi");
            this.datagrid_plubek.DataSource = obDatos.ds.Tables["tbl_colaboradoresgi"];
            this.datagrid_plubek.Refresh();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_gi_Click(object sender, EventArgs e)
        {

        }

        private void tb_plubek_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alta_colaboradores ColaboradoresOb = new Alta_colaboradores();
            ColaboradoresOb.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
