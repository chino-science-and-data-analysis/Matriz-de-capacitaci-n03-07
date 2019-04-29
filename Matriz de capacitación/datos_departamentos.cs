using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Matriz_de_capacitación
{
    class datos_departamentos:datos
    {

        private string Id_Departamento;
        private string Nombre;
        private string Id_Eliminado;
        private string Fecha_Eliminado;
        private string Usuario;
        private string Columna1;
        public datos_departamentos()
        {

            Id_Departamento = string.Empty;
            Nombre = string.Empty;
            Id_Eliminado = string.Empty;
            Fecha_Eliminado = string.Empty;
            Columna1 = string.Empty;
            this.sql = string.Empty;

        }
        public string _Id_Departamento
        {
            get
            {
                return this.Id_Departamento;
            }
            set
            {
                this.Id_Departamento = value;
            }
        }
        public string _NombreDepartamento
        {
            get
            {
                return this.Nombre;
            }
            set
            {
                this.Nombre = value;
            }
        }

        public string _DepartamentoEliminado
        {
            get
            {
                return this.Id_Eliminado;
            }
            set
            {
                this.Id_Eliminado = value;
            }
        }

        public string _Datedepeliminado
        {
            get
            {
                return this.Fecha_Eliminado;
            }
            set
            {
                this.Fecha_Eliminado = value;
            }
        }

        public string _Observacionesdepartamento
        {
            get
            {
                return this.Columna1;
            }
            set
            {
                this.Columna1 = value;
            }
        }

        public bool data_Departamentos()
        {
            bool Resultado = false;
            this.sql = string.Format(@"SELECT * FROM tbl_departamentos WHERE Id_Departamento='{0}'", this.Id_Departamento);
            // this.sql = string.Format(@"SELECT Id_Departamento FROM tbl_departamentos WHERE Id_Departamento='{0}' AND Nombre='{1}' AND Id_Eliminado='{2}' AND Fecha_Eliminado='{3}' AND Columna1='{4}' AND Usuario='{5}'", this.Id_Departamento, this.Nombre, this.Id_Eliminado, this.Fecha_Eliminado);
            this.comando = new SqlCommand(this.sql, this.cn);
            this.cn.Open();
            SqlDataReader Reg = null;
            Reg = this.comando.ExecuteReader();
            if (Reg.Read())
            {
                Resultado = true;
                
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
