using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FP2ISW_411.Modelos;
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

        public List<string> puestos()
        {
            List<string> tipos = new List<string>();
            try
            {
                string sql = "SELECT nombre FROM dbo.tb_roles ORDER BY nombre";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
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


        public int codigo_puesto(string t_h)
        {
            int tarifa = 0;
            try
            {
                string sql = "SELECT identificador FROM dbo.tb_roles WHERE nombre='"+t_h+"';";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    tarifa = dr.GetInt32(0);
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
        public usuario info_usu(long id)
        {
            usuario U = null;
            try
            {
                string sql = "SELECT nombre,apellido1,apellido2,edad,fecha_nacimiento,fecha_contratacion,user_type,pais,provincia,canton,direccion, activo FROM dbo.tb_usuarios,dbo.tb_direcciones WHERE dbo.tb_usuarios.identificador = " + id + " AND dbo.tb_direcciones.id_user = " + id + "";

                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    
                    U = new usuario(id, dr.GetString(0), dr.GetString(1), dr.GetString(2), "", dr.GetInt32(3), Convert.ToDateTime(dr.GetValue(4)), dr.GetString(7), dr.GetString(8), dr.GetString(9), dr.GetString(10), Convert.ToDateTime(dr.GetValue(5)), dr.GetInt32(6),Convert.ToInt32(dr.GetValue(11)));

                }
                conex.Desconectar();
            }
            catch
            {
                U = null;
                conex.Desconectar();
            }
            return U;
        }
        public usuario admin(long id)
        {
            usuario U = null;
            try
            {
                string sql = "SELECT nombre, apellido1, passwor, user_type FROM dbo.tb_usuarios WHERE identificador = " + id + "AND activo = 1 AND user_type = 1";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    U = new usuario(id, dr.GetString(0), dr.GetString(1), null, dr.GetString(2),0, DateTime.Now, null, null, null, null, DateTime.Now, dr.GetInt32(3), 1);

                }
                conex.Desconectar();
            }
            catch
            {
                U = null;
                conex.Desconectar();
            }
            return U;
        }

        public Hoteles SelH(long id)
        {
            Hoteles H = null;
            try
            {
                string sql = "SELECT nombre, localidad, cantidad from dbo.tb_hoteles WHERE identificador = " + id;
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    H = new Hoteles(id, dr.GetString(0), dr.GetString(1), dr.GetInt32(2));                   
                }
                conex.Desconectar();
            }
            catch
            {
                H = null;
                conex.Desconectar();
            }
            return H;
        }

        public string nombre_puesto(int t_h)
        {
            string n = "";
            try
            {
                string sql = "SELECT nombre FROM dbo.tb_roles WHERE identificador='" + t_h + "';";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    n = dr.GetString(0);
                }
                conex.Desconectar();
            }
            catch
            {
                n= "";
                conex.Desconectar();
            }
            return n;
        }

        public List<string> nombre_hoteles()
        {
            List<string> tipos = new List<string>();
            try
            {
                string sql = "SELECT nombre FROM dbo.tb_hoteles;";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
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
        public int codigo_Hotel(string t_h)
        {
            int codigo = 0;
            try
            {
                string sql = "SELECT identificador FROM dbo.tb_hoteles WHERE nombre='" + t_h + "';";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    codigo = dr.GetInt32(0);
                }
                conex.Desconectar();
            }
            catch
            {
                codigo = 0;
                conex.Desconectar();
            }
            return codigo;
        }
        public int codigo_Tipo_habi(string t_h)
        {
            int codigo = 0;
            try
            {
                string sql = "SELECT id_type FROM dbo.tb_hab_type WHERE descripcion='" + t_h + "';";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    codigo = dr.GetInt32(0);
                }
                conex.Desconectar();
            }
            catch
            {
                codigo = 0;
                conex.Desconectar();
            }
            return codigo;
        }

        public double precio_tarifa(int hotel,int T_habitacion)
        {
            double codigo = -1;
            try
            {
                string sql = "SELECT precio FROM dbo.tb_tarifas_de_hotel WHERE codigo_hotel="+hotel+" AND hab_type="+T_habitacion+";";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    codigo = dr.GetDouble(0);
                }
                conex.Desconectar();
            }
            catch
            {
                codigo = -1;
                conex.Desconectar();
            }
            return codigo;
        }
    }


}
