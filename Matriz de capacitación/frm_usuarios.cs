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
    public partial class frm_usuarios : Form
    {
        public frm_usuarios()
        {
            InitializeComponent();
        }
        
        private void frm_usuarios_Load(object sender, EventArgs e)
        {
            
            obDatos.consultar("SELECT tbl_usuarios.Usuario, tbl_colaboradores.Nombre, tbl_colaboradores.Apellido_Paterno, tbl_colaboradores.Apellido_Materno FROM tbl_usuarios LEFT JOIN tbl_colaboradores ON tbl_usuarios.Numero_Empleado = tbl_colaboradores.Numero_Empleado ","tbl_usuarios");
            this.dataGridUsuarios.DataSource = obDatos.ds.Tables["tbl_usuarios"];
            this.dataGridUsuarios.Refresh();
            
        }
        
        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        datos obDatos = new datos();

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_usuarios obAltausuarios = new Alta_usuarios();
            obAltausuarios.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Alta_usuarios obAltausuarios = new Alta_usuarios(); ;
            if (dataGridUsuarios.SelectedRows.Count > 0)
            {

            }
        }
    }
}
