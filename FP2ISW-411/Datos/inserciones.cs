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
                string sql = "";
                if (e.Cliente == 1)
                {
                    sql = "INSERT INTO dbo.tb_usuarios VALUES(" + e.Cedula + ",'" + e.nombre + "','" + e.Apellido1 + "','" + e.Apellido2 + "'," + e.Edad + ",CAST('" + e.Fecha_nac.Year + "-" + e.Fecha_nac.Month + "-" + e.Fecha_nac.Day + "' AS date),CAST('" + e.Fecha_contratacion.Year + "-" + e.Fecha_contratacion.Month + "-" + e.Fecha_contratacion.Day + "' AS date), 9,'" + e.Password + "',1,"+ e.Cliente +")";
                }
                else
                {
                    sql = "INSERT INTO dbo.tb_usuarios VALUES(" + e.Cedula + ",'" + e.nombre + "','" + e.Apellido1 + "','" + e.Apellido2 + "'," + e.Edad + ",CAST('" + e.Fecha_nac.Year + "-" + e.Fecha_nac.Month + "-" + e.Fecha_nac.Day + "' AS date),CAST('" + e.Fecha_contratacion.Year + "-" + e.Fecha_contratacion.Month + "-" + e.Fecha_contratacion.Day + "' AS date)," + e.Puesto + ",'" + e.Password + "',1," + e.Cliente + ")";
                }
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
                string sql = "INSERT INTO dbo.tb_direcciones VALUES(" + e.Cedula + ",'" + e.Pais + "','" + e.Provincia + "','" + e.Canton + "','"  +e.Direccion + "');";
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

        public bool registrar_asignacion(long idus, int idhot, int idhab)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "INSERT INTO dbo.tb_asignaciones VALUES(" + idhot + ",'" + idhab + "','" + idus + "');";
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

        public bool registrar_habitaH(Habitaciones h)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "INSERT INTO dbo.tb_Habitaciones VALUES(" + h.Tipo + ",'" + h.Id_hotel +  "');";
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
            catch (Exception e )
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool registrar_situacion(Situaciones st, int idres)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "INSERT INTO dbo.tb_situaciones VALUES("+ idres +","+ st.EmplID + "," + st.UsoBar + "," + st.UsoCF + ",'" + st.Desc +"'); ";
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool registrar_hotel(Hoteles H)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "INSERT INTO dbo.tb_hoteles VALUES(" + H.Identificador + ",'" + H.Nombre + "','" + H.Localidad + "','" + H.CantidadHab + "','" + H.Activo + "')";
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

        public bool registrar_Tarifa(int cod_hotel,int cod_T_Hbitacion,double precio)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "INSERT INTO dbo.tb_tarifas_de_hotel VALUES(" + cod_hotel + "," + precio + "," + cod_T_Hbitacion + ");" ;
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

        public bool reservar(long ced, DateTime entrada, DateTime salida,int personas,int habitacion,int precio)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "INSERT INTO dbo.tb_reservaciones VALUES("+ced+",'"+entrada.Year+"-"+entrada.Month+"-"+entrada.Day+ "','" + salida.Year + "-" + salida.Month + "-" + salida.Day + "',"+personas+","+habitacion+",null,null,1,"+precio+");";
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
