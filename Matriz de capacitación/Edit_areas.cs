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
    public partial class Edit_areas : MetroFramework.Forms.MetroForm
    {
        public Edit_areas()
        {
            InitializeComponent();
        }

        public void Edit_areas_Load(object sender, EventArgs e)
        {

        }

        private void btncancelararea_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        datos ObDatos = new datos();
        frm_areas ObEditaar = new frm_areas();

        private void btnaceptararea_Click(object sender, EventArgs e)
        {
            string campos = "Nombre='" + this.txt_nareaed.Text + "'";
            if (ObDatos.actualizar("tbl_areas", campos, "Id_Area='" + this.txt_careaed.Text + "'"))
            {
                MessageBox.Show("Se actualizó correctamente");
                ObEditaar.txt_filtroareas.Select();
                this.Close();
            }
            else
            {
                MessageBox.Show("Campos invalidos");
                return;
            }
        }
    }
}
