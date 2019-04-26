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
    public partial class frm_puestos : Form
    {
        public frm_puestos()
        {
            InitializeComponent();
        }

        private void frmAltapuesto_Load(object sender, EventArgs e)
        {
            obDatos.consultar("SELECT tbl_puestos.id_puesto as Clave_Puesto, tbl_puestos.Nombre as Puesto, tbl_departamentos.Nombre AS Departamento, tbl_areas.Nombre AS Área FROM tbl_puestos LEFT JOIN tbl_departamentos ON tbl_puestos.Id_departamento = tbl_departamentos.Id_departamento left join tbl_areas ON tbl_puestos.id_area = tbl_areas.id_area", "tbl_puestos");
            this.dataGridPuestos.DataSource = obDatos.ds.Tables["tbl_puestos"];
            this.dataGridPuestos.Refresh();
        }
        datos obDatos = new datos();
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_puestos obPuestos = new Alta_puestos();
            obPuestos.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
