using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FP2ISW_411.Datos
{
    internal class Conexion
    {
        SqlConnection conn;
        public Conexion()
        {
            //conn = new SqlConnection("Data Source=LAPTOP-DRHB9J1B;Initial Catalog=Hotel;Integrated Security=True");
            conn = new SqlConnection("Data Source=GUERREROPC\\GDB;Initial Catalog=Hotel;Integrated Security=True");
            //conn = new SqlConnection("Data Source=Guerrero-Macboo\\GBD;Initial Catalog=Hotel;Integrated Security=True");
            //conn = new SqlConnection("Data Source=DESKTOP-UTLBP94;Initial Catalog=Hotel;Integrated Security=True");
        }
        public SqlConnection Conectar()
        {
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
                
            }
        }
        public bool Desconectar()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
