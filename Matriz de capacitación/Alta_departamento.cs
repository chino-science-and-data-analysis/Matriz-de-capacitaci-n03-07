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
    public partial class Alta_departamento : MetroFramework.Forms.MetroForm
    {
        frm_departamentos Obtxtfiltro = new frm_departamentos();
        public Alta_departamento()
        {
            InitializeComponent();
        }
        private void Altadepartamento_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnsavedep;
            this.CancelButton = btn_cancelar;
            this.txtclavedep.Focus();
            this.txtclavedep.Select();
        }
        private void btnsavedep_Click(object sender, EventArgs e)
        {
            datos_departamentos Ob_Datosdepartamentos = new datos_departamentos();
            Ob_Datosdepartamentos._Id_Departamento = this.txtclavedep.Text;
            if ((string.IsNullOrEmpty(txtclavedep.Text)) || (string.IsNullOrEmpty(txt_altadepartamento.Text)))
            {
                MessageBox.Show("No se admiten campos vacíos");
                return;
            }
            else if (txtclavedep.Text.Length <= 3)
            {
                MessageBox.Show("La clave debe tener al menos 4 digitos");
                return;
            }
            else if (Ob_Datosdepartamentos.data_Departamentos() == true)
            {
                DialogResult result = MessageBox.Show("¿Desea ver el detalle?", "La clave ingresada ya existe", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    About_departamentos ObDetalledepartamentos = new About_departamentos();
                    ObDetalledepartamentos.ShowDialog();
                }
                else
                {

                }
            }
            else
            {
                datos obDatos = new datos();
                string sql = "insert into tbl_departamentos (Id_Departamento,Nombre) values ('" + this.txtclavedep.Text + "','" + this.txt_altadepartamento.Text + "')";

                if (obDatos.insertar(sql))
                {
                    MessageBox.Show("Registro exitoso");
                    this.Close();
                    Obtxtfiltro.txt_filtrodep.Select();
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                    return;
                }
            }
            //Ob_Datosdepartamentos._Id_Departamento = this.txtclavedep.Text;
            //    if (Ob_Datosdepartamentos.data_Departamentos() == false)
            //{
            //    MessageBox.Show("¿Desea ver el detalle?", "La clave ingresada ya existe", MessageBoxButtons.YesNo); // == DialogResult.Yes
            //}
            //                    else
            //{
        }
/*
            }
            
            {
                if (Ob_Datosdepartamentos.data_Departamentos() == true)
                {

                }
                (Ob_Datosdepartamentos.data_Departamentos() == true)
                
                Ob_Datosdepartamentos._Id_Departamento = this.txtclavedep.Text;

                if (Ob_Datosdepartamentos._Id_Departamento = txtclavedep.Text)
                {
                    if (
                    {
                        if (Ob_Datosdepartamentos.data_Departamentos() == false)
                        {
                            MessageBox.Show("No se encontro la cadena");
                        }
                        About_departamentos Obdetalledepartamento = new About_departamentos();

                        Obdetalledepartamento.Text = ("'String.Format(About {0}AssemblyTitle'");
                        Obdetalledepartamento.lbl_clave.Text = Ob_Datosdepartamentos._Id_Departamento;
                        Obdetalledepartamento.lbl_nombre.Text = Ob_Datosdepartamentos._NombreDepartamento;
                        Obdetalledepartamento.lbl_titular.Text = ("N/A");
                        Obdetalledepartamento.lbl_Eliminado.Text = ("N/A");
                        Obdetalledepartamento.txtdescripcion.Text = Ob_Datosdepartamentos._Observacionesdepartamento;

                        Obdetalledepartamento.ShowDialog();
                    }
                    else
                    {

                    }
                }
*/

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            this.Obtxtfiltro.txt_filtrodep.Focus();
            this.Obtxtfiltro.txt_filtrodep.Select();
            this.Obtxtfiltro.txt_filtrodep.Clear();
            this.Close();
        }

        private void txtclavedep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                this.lbl_int.Visible = false;
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                this.lbl_int.Visible = false;
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                this.lbl_int.Visible = false;
                e.Handled = false;
            }
            else
            {
                this.lbl_int.Visible = true;
                e.Handled = true;
            }
        }
    }
}
