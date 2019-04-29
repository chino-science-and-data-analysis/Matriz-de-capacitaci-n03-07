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
    public partial class frm_departamentos : Form
    {
        public frm_departamentos()
        {
            InitializeComponent();
        }
        datos obDatos = new datos();
        public void frm_departamentos_Load(object sender, EventArgs e)
        {

            this.txt_buscar.Focus();
            this.txt_buscar.Clear();
            this.txt_buscar.Select();
            this.AcceptButton = btn_agrega;
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_departamento OB_Altadep = new Alta_departamento();
            this.txt_buscar.Clear();
            OB_Altadep.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {

            Edit_departamentos Obaltedepedit = new Edit_departamentos();

            if (datagrid_departamentos.SelectedRows.Count > 0)
            {
                Obaltedepedit.txtclavedep.Text = datagrid_departamentos.CurrentRow.Cells[0].Value.ToString();
                Obaltedepedit.txt_altadepartamento.Text = datagrid_departamentos.CurrentRow.Cells[1].Value.ToString();
                Obaltedepedit.ShowDialog();   
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (datagrid_departamentos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro de eliminar el registro?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string campos = "Id_Eliminado='" + 1 + "'";
                    obDatos.actualizar("tbl_departamentos", campos, "Id_departamento='" + datagrid_departamentos.CurrentRow.Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Registro eliminado");
                    txt_buscar.Focus();
                    txt_buscar.Select();
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
        private void FiltroDep_KeyUp(object sender, KeyEventArgs e)
        {
            obDatos.consultar("select Id_Departamento as Clave, Nombre FROM tbl_departamentos WHERE tbl_departamentos.ID_Eliminado=0 and tbl_departamentos.Id_Departamento!=1 AND tbl_departamentos.Nombre LIKE '%" + this.txt_buscar.Text + "%' ", "tbl_departamentos");
            this.datagrid_departamentos.DataSource = obDatos.ds.Tables["tbl_departamentos"];
            return;
        }
        public void FiltroDep_Enter(object sender, EventArgs e)
        {   
            obDatos.consultar("select Id_Departamento as Clave, Nombre FROM tbl_departamentos WHERE tbl_departamentos.ID_Eliminado=0 and tbl_departamentos.Id_Departamento != 1 AND tbl_departamentos.Nombre LIKE '%" + this.txt_buscar.Text + "%' ", "tbl_departamentos");
            this.datagrid_departamentos.DataSource = obDatos.ds.Tables["tbl_departamentos"];
            return;
        }
        private void FiltroDep_Leave(object sender, EventArgs e)
        {
            this.txt_buscar.Clear();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}
