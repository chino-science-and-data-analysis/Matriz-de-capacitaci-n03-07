using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Matriz_de_capacitación
{
    class datos
    {

        private string cadena = "Data Source=DESKTOP-RH1CSAG\\SQLEXPRESS; database=MatrizCapFgi; integrated security = true";
        //private string cadena = "Data Source=192.168.9.32, 1433; database=MatrizCapFgi; user id = sa; password= FarmaciasGi2018";
        public SqlConnection cn;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        protected SqlCommand comando;
        protected string sql;
        protected string mensaje;
        protected int resultado;

        private void conectar()
        {
            cn = new SqlConnection(cadena);
        }

        public datos()
        {
            conectar();
        }
        
        //consultar
        public void consultar(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }
        //eliminar
        public bool eliminar(
            string tabla, string condicion)
        {
            cn.Open();
            string sql = "delete from " + tabla + " where " + condicion;
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //actualizar
        public bool actualizar(string tabla, string campos, string condicion)
        {
            cn.Open();
            string sql = "update " + tabla + " set " + campos + " where " + condicion;
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable consultar2(string tabla)
        {
            string sql = "select * from " + tabla;
            da = new SqlDataAdapter(sql, cn);
            DataSet dst = new DataSet();
            da.Fill(dst, tabla);
            DataTable dt = new DataTable();
            dt = dst.Tables[tabla];
            return dt;
        }
        //Insertar
        public bool insertar(string sql)
        {
            cn.Open();
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        public string Mensaje
        {
            get
            {
                return this.mensaje;
            }
        }

    }
}