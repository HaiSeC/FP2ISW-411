using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace FP2ISW_411.Datos
{
    internal class Counsultas
    {
        Conexion conex = new Conexion();
        public List<string> tipos_habi()
        {
            List<string> tipos = new List<string>();
            try
            {
                string sql = "SELECT descripcion FROM dbo.tb_hab_type;";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr= comando.ExecuteReader();
                while (dr.Read())
                {
                    tipos.Add(dr.GetString(0));
                }
                conex.Desconectar();
            }
            catch
            {
                tipos = null;
                conex.Desconectar();
            }
            return tipos;
        }
        public double tarifa(string t_h)
        {
            double tarifa=0;
            try
            {
                string sql = "SELECT precio FROM dbo.tb_tarifas_de_hotel WHERE hab_type=(SELECT id_type FROM dbo.tb_hab_type WHERE descripcion='"+t_h+"');";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    tarifa= dr.GetDouble(0);
                }
                conex.Desconectar();
            }
            catch
            {
                tarifa = 0;
                conex.Desconectar();
            }
            return tarifa;
        }
    }
    
}
