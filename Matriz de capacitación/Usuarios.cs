using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Matriz_de_capacitación
{
    class Usuarios:datos
    {
        private string usuario;
        private string contraseña;

        public Usuarios()
        {
            usuario = string.Empty;
            contraseña = string.Empty;
            this.sql = string.Empty;
        }

        public string Usuario
        {
            get
            {
                return this.usuario;
                
            }
            set
            {
                this.usuario = value;
            }
        }
        public string Contraseña
        {
            get
            {
                return this.contraseña;
            }
            set
            {
                this.contraseña = value;
            }        
        }

        public bool Buscar()
        {
            bool Resultado = false;
            this.sql = string.Format(@"SELECT Id_Usuario FROM tbl_usuarios WHERE Usuario='{0}' AND Contraseña='{1}'", this.usuario, this.contraseña);
            this.comando = new SqlCommand(this.sql, this.cn);
            this.cn.Open();
            SqlDataReader Reg = null;
            Reg = this.comando.ExecuteReader();
            if (Reg.Read())
            {
                Resultado = true;
                frm_main MainOb = new frm_main();
                MainOb.Show();
            }
            else
            {
                this.mensaje = "No";
            }
            this.cn.Close();
            return Resultado;
        }
        
    }
}
