using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FP2ISW_411.Modelos;
namespace FP2ISW_411.Datos
{
    internal class updates
    {
        Conexion conex = new Conexion();

        public bool desactivar_usu(long id)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "UPDATE dbo.tb_usuarios SET activo = 0 WHERE identificador= " + id + ";";
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

        public bool desactivar_hotel(long id)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "UPDATE dbo.tb_hoteles SET activo = 0 WHERE identificador = " + id + ";";
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

        public bool modificar_hoteles(Hoteles H)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "UPDATE dbo.tb_hoteles SET nombre = '"+ H.Nombre +"', localidad = '"+ H.Localidad +"', cantidad = "+ H.CantidadHab +", activo = " + H.Activo + " WHERE identificador = " + H.Identificador + "";
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

        public bool modificar_usu(usuario U)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "UPDATE dbo.tb_usuarios SET nombre='"+U.nombre+"',apellido1='"+U.Apellido1+"',apellido2='"+U.Apellido2+"',fecha_nacimiento= CAST('"+U.Fecha_nac.Year+"-"+U.Fecha_nac.Month+"-"+U.Fecha_nac.Day+"' AS date),edad="+U.Edad+",user_type="+U.Puesto+",activo="+U.Activo+" WHERE identificador="+U.Cedula+";";
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
        public bool modificar_direct(usuario U)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "UPDATE dbo.tb_direcciones SET pais='"+U.Pais+"',provincia='"+U.Provincia+"',canton='"+U.Canton+"',direccion='"+U.Direccion+"' WHERE id_user="+U.Cedula+";";
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
        public bool modificar_Tarifa(int cod_hotel, int cod_Thabi,double precio)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "UPDATE dbo.tb_tarifas_de_hotel SET precio="+precio+" WHERE codigo_hotel="+cod_hotel+" AND hab_type="+cod_Thabi+";";
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

        public bool modificar_status(int estado,int id)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "UPDATE dbo.tb_reservaciones SET status="+estado+" WHERE id_reservacion="+id+";";
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
        public bool modificar_checkIn(int id)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "UPDATE dbo.tb_reservaciones SET confirm_checkIn='" + DateTime.Now + "' WHERE id_reservacion=" + id + ";";
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


        public bool modificar_checkOut(int id)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "";
                sql = "UPDATE dbo.tb_reservaciones SET confirm_checkOut='" + DateTime.Now + "' WHERE id_reservacion=" + id + ";";                 
                SqlCommand comando = new
                SqlCommand(sql, conex.Conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 2 || cantidad == 1)
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
