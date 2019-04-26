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
    public partial class Alta_area : MetroFramework.Forms.MetroForm
    {
        public Alta_area()
        {
            InitializeComponent();
        }
        datos obDatos = new datos();
        frm_areas ObArea = new frm_areas();
        private void Alta_area_Load(object sender, EventArgs e)
        {
            this.CancelButton = btncancelararea;
            this.AcceptButton = btnaceptararea;
            //cmbdepartamento.Focus();
            //cmbdepartamento.Select();
            this.cmbdepartamento.ValueMember = "Id_Departamento";
            obDatos.consultar("SELECT Id_Departamento, cast(Id_Departamento AS varchar) +'  '+ Nombre AS Combo_Dep FROM tbl_departamentos", "combo_dep");
            obDatos.da.Fill(obDatos.ds, "tbl_departamentos");
            this.cmbdepartamento.DataSource = obDatos.ds.Tables[0].DefaultView;
            this.cmbdepartamento.DisplayMember = "Combo_Dep";
            
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (
              (cmbdepartamento.SelectedItem == null) ||
              //string.IsNullOrEmpty(comboColaborador.SelectedValue.ToString())||
              string.IsNullOrEmpty(txtnarea.Text)


              //string.IsNullOrEmpty(comboTipo.SelectedValue.ToString())
              )


            {
                MessageBox.Show("No se admiten campos vacíos");
                return;
            }

            else
            {
                string sql = "insert into tbl_areas (Id_Area,Id_Departamento,Nombre) values ('" + this.txtcarea.Text + "','" + this.cmbdepartamento.SelectedValue.ToString() + "','" + this.txtnarea.Text + "')";
                //  if (textBox6.Text != null) Clipboard.SetText(textBox6.Text);


                if (obDatos.insertar(sql))
                {
                    MessageBox.Show("Registro exitoso");
                    ObArea.txt_filtroareas.Select();
                    this.Close();
                }
                else
                {

                }
                //Application.Restart();
            }
        }

        private void txtcarea_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
