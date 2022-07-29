using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace FP2ISW_411.Datos
{
    internal class Conexion
    {
        SqlConnection conn;
        public Conexion()
        {
            conn = new SqlConnection("Data Source=LAPTOP-DRHB9J1B;Initial Catalog=Hotel;Integrated Security=True");
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
                Console.WriteLine(ex.Message);
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
                return false;
            }
        }
    }
}
