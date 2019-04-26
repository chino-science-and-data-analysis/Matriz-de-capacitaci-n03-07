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
    public partial class Alta_colaboradoresdaño : MetroFramework.Forms.MetroForm
    {
        public Alta_colaboradoresdaño()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /*this.comboarea.Items.Insert(0, "");
            this.comboarea.SelectedIndex = 0;
            this.comboarea.DataSource = obDatos.consultar2("tbl_areas");
            this.combodepartamento.DataSource = obDatos.consultar2("tbl_departamentos");
            this.combopuesto.DataSource = obDatos.consultar2("tbl_puestos");
            this.comboalcaldia.DataSource = obDatos.consultar2("tbl_alcaldias");
            this.combobaja.DataSource = obDatos.consultar2("cat_causa_baja");
            this.combosucursal.DataSource = obDatos.consultar2("tbl_sucursales");
            this.combogenero.DataSource = obDatos.consultar2("cat_generos");
            this.combohorario.DataSource = obDatos.consultar2("cat_horarios");
            this.combostatus.DataSource = obDatos.consultar2("cat_status");
            //this.comboarea.Items.Clear();
            this.comboarea.SelectedIndex = 0;
            //this.combopuesto.SelectedValueChanged == ("Dispensador");
            //this.comboarea.Items.Add("");
            
            //this.combosucursal.DataSource = obDatos.consultar2("tbl_sucursales");

            this.comboarea.ValueMember = "Id_Area";
            this.comboarea.DisplayMember = "Nombre";
            this.combodepartamento.ValueMember = "Id_Departamento";
            this.combodepartamento.DisplayMember = "Nombre";
            this.combopuesto.ValueMember = "Id_Puesto";
            this.combopuesto.DisplayMember = "Nombre";
            this.comboalcaldia.ValueMember = "Id_Alcaldia";
            this.comboalcaldia.DisplayMember = "Nombre";
            this.combobaja.ValueMember = "Id_Causa_Baja";
            this.combobaja.DisplayMember = "Nombre";
            this.combosucursal.ValueMember = "Id_Sucursal";
            this.combosucursal.DisplayMember = "Nombre";
            this.combohorario.ValueMember = "Id_Horario";
            this.combohorario.DisplayMember = "Nombre";
            this.combogenero.ValueMember = "Id_Genero";
            this.combogenero.DisplayMember = "Nombre";
            this.combostatus.ValueMember = "Id_Status";
            this.combostatus.DisplayMember = "Nombre";
            
            /*
            if (this.combostatus.SelectedValue.ToString() == "2")
            {
                this.fechabaja.Visible = true;
            }
            */
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        /*    this.Close(); */
        }

        //datos obDatos = new datos();
        
        private void button1_Click_1(object sender, EventArgs e)

        {
        /*    
            int numemp = 0;
            if (int.TryParse(txtnumemp.Text, out numemp))
            {
                MessageBox.Show("si");
            }
            else
            {
                MessageBox.Show("Error en número de empleado");

            }
            if (
                // (combogenero.SelectedItem == null) ||
                //string.IsNullOrEmpty(comboColaborador.SelectedValue.ToString())||
                //  string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtapaterno.Text)
                // string.IsNullOrEmpty(txtnumemp.Text)
                // (comboTipo.SelectedItem == null) ||
                // (comboDep.SelectedItem == null)

                //string.IsNullOrEmpty(comboTipo.SelectedValue.ToString())
                )


            {
                MessageBox.Show("No se admiten campos vacíos");
                return;
            }

            else
            {

                  string sql = "insert into tbl_colaboradores (Numero_Empleado,Nombre,Apellido_Paterno,Apellido_Materno,Genero,Id_Area,Id_Departamento,Id_Puesto,Id_Alcaldia,Id_Sucursal,Horario,Fecha_Nacimiento,RFC,Curp,Num_SS,Fecha_Ingreso,Fecha_Ingreso_Plubek,Status_Tab,Fecha_Baja,Id_Causa_Baja,Comentarios) values ('" + numemp + "','" + this.txtNombre.Text + "','" + this.txtapaterno.Text + "','" + this.txtamaterno.Text + "','" + this.combogenero.SelectedValue.ToString() + "','" + this.comboarea.SelectedValue.ToString() + "','" + this.combodepartamento.SelectedValue.ToString() + "','" + this.combopuesto.SelectedValue.ToString() + "','" + this.comboalcaldia.SelectedValue.ToString() + "','" + this.combosucursal.SelectedValue.ToString() + "','" + this.combohorario.SelectedValue.ToString() + "','" + this.fechanacimiento.Value.Date.ToString("dd/MM/yyyy") + "','" + this.txtrfc.Text + "','" + this.txtcurp.Text + "','" + this.txtnss.Text + "','" + this.fechaingresogi.'" + this.txtamaterno.Text + "', + "','" + this.fechaingreso1.Value.Date.ToString("dd/MM/yyyy") + "','" + this.combostatus.SelectedValue.ToString() + "','" + this.fechabaja.Value.Date.ToString("dd/MM/yyyy") + "','" + this.combobaja.SelectedValue.ToString() + "','" + this.txtcomentarios.Text + "')";
                  //if (textBox6.Text != null) Clipboard.SetText(textBox6.Text);
              

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
            */
        }
        
    

        private void combogenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void fechaingresogi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void combobaja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fechaingreso1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void combodepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void combopuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       /* private void combopuesto_SelectedIndexChanged_1(object sender, EventArgs e)
            
        {
            if (combopuesto.SelectedItem.ToString() != "DISPENSADOR DE FARMACIAS")
            {
                this.comboalcaldia.Enabled = false;
                this.comboalcaldia.Visible = false;
                this.label19.Visible = false;
            }
            else
            {
                this.comboalcaldia.Enabled = true;
                this.comboalcaldia.Visible = true;
                this.label19.Visible = true;
            }
        }
        */
        private void combohorario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboalcaldia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combosucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Alta_colaboradores
            // 
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Name = "Alta_colaboradores";
            this.Load += new System.EventHandler(this.Alta_colaboradores_Load);
            this.ResumeLayout(false);

        }
        */
        private void Alta_colaboradores_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
