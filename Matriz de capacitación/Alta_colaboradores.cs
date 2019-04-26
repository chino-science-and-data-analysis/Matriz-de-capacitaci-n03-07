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
    public partial class Alta_colaboradores : MetroFramework.Forms.MetroForm
    {
        public Alta_colaboradores()
        {
            InitializeComponent();
        }
        datos obDatos = new datos();
        private void Alta_colaboradores_Load(object sender, EventArgs e)
        {
            txtnumemp.Focus();
            txtnumemp.Select();
            this.AcceptButton = btnguardar;
        
            this.combogenero.DataSource = obDatos.consultar2("cat_generos");
            this.combogenero.ValueMember = "Id_Genero";
            this.combogenero.DisplayMember = "Nombre";

            //this.combostatus.DataSource = obDatos.consultar2("cat_status");
            //this.combostatus.ValueMember = "Id_Status";
            //this.combostatus.DisplayMember = "Nombre";

            //this.combobaja.DataSource = obDatos.consultar2("cat_causabaja");
            //this.combobaja.ValueMember = "Id_Causa_Baja";
            //this.combobaja.DisplayMember = "Nombre";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (
               //(comboColaborador.SelectedItem == null) ||
               //string.IsNullOrEmpty(comboColaborador.SelectedValue.ToString())||
               string.IsNullOrEmpty(txtnumemp.Text)


               //string.IsNullOrEmpty(comboTipo.SelectedValue.ToString())
               )


            {
                MessageBox.Show("No se admiten campos vacíos");
                return;
            }

            else
            {
               string sql = "insert into tbl_colaboradoresgi (Id_Colaborador,Nombre,Apellido_Paterno,Apellido_Materno,Curp,RFC,Num_SS,Fecha_Nacimiento,Fecha_Registro,Comentarios,Id_Genero) values ('" + this.txtnumemp.Text + "','" + this.txtNombre.Text + "','" + this.txtapaterno.Text + "','" + this.txtamaterno.Text + "','" + this.txtcurp.Text + "','" + this.txtrfc.Text + "','" + this.txtnss.Text + "','" + this.dtpnacimiento.Value.Date.ToString("yyyy/MM/dd") + "','" + this.dtpregistro.Value.Date.ToString("yyyy/MM/dd") + "','" + this.txtcomentarios.Text + "','" + this.combogenero.SelectedValue.ToString() + "')";
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

        private void PB_Colaborador_Click(object sender, EventArgs e)
        {
            if (
               //(comboColaborador.SelectedItem == null) ||
               //string.IsNullOrEmpty(comboColaborador.SelectedValue.ToString())||
               string.IsNullOrEmpty(txtnumemp.Text)


               //string.IsNullOrEmpty(comboTipo.SelectedValue.ToString())
               )


            {
                MessageBox.Show("No se admiten campos vacíos");
                return;
            }

            else
            {
                string sql = "insert into tbl_colaboradoresgi (Id_Colaborador,Nombre,Apellido_Paterno,Apellido_Materno,Curp,RFC,Num_SS,Fecha_Nacimiento,Fecha_Registro,Comentarios,Id_Genero) values ('" + this.txtnumemp.Text + "','" + this.txtNombre.Text + "','" + this.txtapaterno.Text + "','" + this.txtamaterno.Text + "','" + this.txtcurp.Text + "','" + this.txtrfc.Text + "','" + this.txtnss.Text + "','" + this.dtpnacimiento.Value.Date.ToString("yyyy/MM/dd") + "','" + this.dtpregistro.Value.Date.ToString("yyyy/MM/dd") + "','" + this.txtcomentarios.Text + "','" + this.combogenero.SelectedValue.ToString() + "')";
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
    }
}
