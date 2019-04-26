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
    public partial class Alta_usuarios : MetroFramework.Forms.MetroForm
    {

        public Alta_usuarios()
        {
            InitializeComponent();
        }

        private void Altausuarios_Load(object sender, EventArgs e)
        {
            this.comboColaborador.DataSource = obDatos.consultar2("tbl_colaboradores");
            this.comboTipo.DataSource = obDatos.consultar2("cat_tipousuario");
            this.comboDep.DataSource = obDatos.consultar2("tbl_departamentos");
            this.comboDep.ValueMember = "Id_Departamento";
            this.comboDep.DisplayMember = "Nombre";
            this.comboTipo.ValueMember = "Id_TipoUsuario";
            this.comboTipo.DisplayMember = "Nombre";
            this.comboColaborador.ValueMember = "Numero_Empleado";
            this.comboColaborador.DisplayMember = "Select Nombre,Apellido_Paterno FROM tbl_colaboradores";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        datos obDatos = new datos();
        private void button1_Click(object sender, EventArgs e)
        {

            if (
                (comboColaborador.SelectedItem == null) ||
                //string.IsNullOrEmpty(comboColaborador.SelectedValue.ToString())||
                string.IsNullOrEmpty(textUsuario.Text) ||
                string.IsNullOrEmpty(textContraseña.Text)||
                (comboTipo.SelectedItem == null) ||
                (comboDep.SelectedItem == null)
                
                //string.IsNullOrEmpty(comboTipo.SelectedValue.ToString())
                )
                

            {
                 MessageBox.Show("No se admiten campos vacíos");
                   return;
               }
        
           else
          {
                string sql = "insert into tbl_usuarios (Numero_Empleado,Usuario,Contraseña,Id_TipoUsuario,Id_Area) values ('" + this.comboColaborador.SelectedValue.ToString() + "','" + this.textUsuario.Text + "','" + this.textContraseña.Text + "','" + this.comboTipo.SelectedValue.ToString() + "','" + this.comboDep.SelectedValue.ToString() + "')";
                //  if (textBox6.Text != null) Clipboard.SetText(textBox6.Text);


                if (obDatos.insertar(sql))
                {
                    MessageBox.Show("Registro exitoso");
                    this.Close();
                }
                else
                {

                }
                //Application.Restart();
           }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
