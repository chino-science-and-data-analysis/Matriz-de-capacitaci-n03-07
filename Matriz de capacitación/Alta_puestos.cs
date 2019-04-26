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
    public partial class Alta_puestos : MetroFramework.Forms.MetroForm
    {
        public Alta_puestos()
        {
            InitializeComponent();
        }

        private void altapuestos_Load(object sender, EventArgs e)
        {
            this.comboDep.DataSource = obDatos.consultar2("tbl_departamentos");
            this.comboArea.DataSource = obDatos.consultar2("tbl_areas");
            this.comboDep.ValueMember = "Id_Departamento";
            this.comboDep.DisplayMember = "Nombre";
            this.comboArea.ValueMember = "Id_Area";
            this.comboArea.DisplayMember = "Nombre";
        }
        datos obDatos = new datos();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (
               //(comboColaborador.SelectedItem == null) ||
               //string.IsNullOrEmpty(comboColaborador.SelectedValue.ToString())||
               string.IsNullOrEmpty(txtNombre.Text)


               //string.IsNullOrEmpty(comboTipo.SelectedValue.ToString())
               )


            {
                MessageBox.Show("No se admiten campos vacíos");
                return;
            }

            else
            {
                string sql = "insert into tbl_puestos (Id_Puesto,Id_Departamento,Id_Area,Nombre) values ('" + this.txtclave.Text + "','" + this.comboDep.SelectedValue.ToString() + "','" + this.comboArea.SelectedValue.ToString() +"','" + this.txtNombre.Text + "')";
                //  if (textBox6.Text != null) Clipboard.SetText(textBox6.Text);


                if (obDatos.insertar(sql))
                {
                    MessageBox.Show("Registro exitoso");
                    this.Close();
                }
                else
                {

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
