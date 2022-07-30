using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FP2ISW_411.Modelos;
namespace FP2ISW_411.Datos
{
    internal class inserciones
    {
        Conexion conex = new Conexion();

        public bool registrar_usu(usuario e)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "INSERT INTO dbo.tb_usuarios VALUES("+e.Cedula+",'"+e.nombre+"','"+e.Apellido1+"','"+e.Apellido2+"',"+e.Edad+ ",CAST('"+e.Fecha_nac.Year+"-"+e.Fecha_nac.Month+"-"+e.Fecha_nac.Day+"' AS date),CAST('"+ e.Fecha_contratacion.Year+"-"+e.Fecha_contratacion.Month+"-"+e.Fecha_contratacion.Day+"' AS date)," + e.Puesto+",'"+e.Contraseña+"',1)";
                SqlCommand comando = new
                SqlCommand(sql, conex.Conectar());
                int cantidad = comando.ExecuteNonQuery();
            if (cantidad == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                conex.Desconectar();

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool registrar_direccion(usuario e)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "INSERT INTO dbo.tb_direcciones VALUES("+e.Cedula+",'"+e.Pais+"','"+e.Provincia+"','"+e.Canton+"','"+e.Direccion+"');";
                SqlCommand comando = new
                SqlCommand(sql, conex.Conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                conex.Desconectar();

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
