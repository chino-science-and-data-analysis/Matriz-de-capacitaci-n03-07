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
    public partial class frm_areas : Form
    {
        public frm_areas()
        {
            InitializeComponent();
        }
        
        datos obDatos = new datos();
        private void frm_areas_Load(object sender, EventArgs e)
        {
            //txt_filtroareas.Focus();
            //txt_filtroareas.Select();
            this.AcceptButton = btnNuevo;
            this.CancelButton = btnCerrar;
            obDatos.consultar("SELECT tbl_areas.Id_Area as Clave_área, tbl_areas.Nombre AS Área, tbl_departamentos.Nombre AS Departamento FROM tbl_areas LEFT JOIN tbl_departamentos ON tbl_areas.Id_Departamento = tbl_Departamentos.Id_Departamento  WHERE Id_Area!=0", "tbl_areas");
            this.dgv_areas.DataSource = obDatos.ds.Tables["tbl_areas"];
            this.dgv_areas.Refresh();

            //obDatos.consultar("SELECT tbl_areas.Id_Area as Clave_área, tbl_areas.Nombre AS Área, tbl_departamentos.Nombre AS Departamento FROM tbl_areas LEFT JOIN tbl_departamentos ON tbl_areas.Id_Departamento = tbl_Departamentos.Id_Departamento  WHERE Id_Area!= 1 AND tbl_areas.Id_Eliminado IS NULL AND  tbl_areas.Nombre LIKE'%chi%'", "tbl_areas");
            //this.dgv_areas.DataSource = obDatos.ds.Tables["tbl_areas"];


        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_area AltaareaOB = new Alta_area();
            AltaareaOB.ShowDialog();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_areas.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro de eliminar el registro?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string campos = "Id_Eliminado='" + 1 + "'";
                    obDatos.actualizar("tbl_areas", campos, "Id_Area='" + dgv_areas.CurrentRow.Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Registro eliminado");
                    txt_filtroareas.Focus();
                    txt_filtroareas.Select();
                }
                else
                {

                }
            }

            else
            {
                MessageBox.Show("Debe seleccionar una fila");

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Edit_areas Ob_Edita = new Edit_areas();
            if (dgv_areas.SelectedRows.Count > 0)

            {

                //obDatos.consultar("SELECT Id_Departamento, cast(Id_Departamento AS varchar) +'  '+ Nombre AS Combo_Dep FROM tbl_departamentos WHERE NOMBRE='" + dgv_areas.CurrentRow.Cells[2].Value.ToString() + "'", "combo_dep");
                //obDatos.da.Fill(obDatos.ds, "tbl_departamentos");
                //Ob_Edita.cmb_areaed.DataSource = obDatos.ds.Tables[2].DefaultView;
                //Ob_Edita.cmb_areaed.DisplayMember = "combo_dep";
                //Ob_Edita.cmb_areaed.ValueMember = "Id_Departamento";
                //Ob_Edita.txt_careaed.Text = dgv_areas.CurrentRow.Cells[0].Value.ToString();
                //Ob_Edita.txt_nareaed.Text = dgv_areas.CurrentRow.Cells[1].Value.ToString();
                //Ob_Edita.ShowDialog();

            }
            else
            {

                MessageBox.Show("Debe seleccionar una fila");
            }

        }


        //private void txt_filtroareas_KeyUp(object sender, KeyEventArgs e)
        //{
        //    //obDatos.consultar("SELECT tbl_areas.Id_Area as Clave_área, tbl_areas.Nombre AS Área, tbl_departamentos.Nombre AS Departamento FROM tbl_areas LEFT JOIN tbl_departamentos ON tbl_areas.Id_Departamento = tbl_Departamentos.Id_Departamento  WHERE Id_Area != 1 AND tbl_areas.Id_Eliminado IS NULL AND tbl_areas.Nombre LIKE '%" + this.txt_filtroareas.Text + "%'", "tbl_areas");
        //    //this.dgv_areas.DataSource = obDatos.ds.Tables["tbl_areas"];
        //    //return;
        //}

    }
}
