using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FP2ISW_411.Modelos;
using System.Data;

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

        public int consultar_codigoH(long id)
        {
            int codigo = 0;
            
            try
            {
                string sql = "SELECT codigo_hotel FROM tb_asignaciones WHERE id_user = '"+ id +"'";
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
                conex.Desconectar();
            }
            return codigo;
        }

        public int consultar_codigoHN(string name)
        {
            int codigo = 0;

            try
            {
                string sql = "SELECT identificador FROM tb_hoteles WHERE nombre= '" + name + "'";
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
                conex.Desconectar();
            }
            return codigo;
        }


        public List<usuario> Consultar_Usuarios()
        {
            List<usuario> Lusers = new List<usuario>();
            try
            {
                string sql = "SELECT identificador, nombre, apellido1, apellido2, user_type, activo FROM dbo.tb_usuarios WHERE user_type != 9 ORDER BY nombre";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Lusers.Add(new usuario(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetInt32(4), Convert.ToInt32(dr.GetValue(5))));
                }
                conex.Desconectar();
            }
            catch
            {
                Lusers = null;
                conex.Desconectar();
            }


            return Lusers;
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
                string sql = "SELECT nombre,apellido1,apellido2,edad,fecha_nacimiento,fecha_contratacion,user_type,pais,provincia,canton,direccion, cliente, activo FROM dbo.tb_usuarios,dbo.tb_direcciones WHERE dbo.tb_usuarios.identificador = " + id + " AND dbo.tb_direcciones.id_user = " + id + "";

                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    U = new usuario(id, dr.GetString(0), dr.GetString(1), dr.GetString(2), "", dr.GetInt32(3), Convert.ToDateTime(dr.GetValue(4)), dr.GetString(7), dr.GetString(8), dr.GetString(9), dr.GetString(10), Convert.ToDateTime(dr.GetValue(5)), dr.GetInt32(6),Convert.ToInt32(dr.GetValue(11)),Convert.ToInt32(dr.GetValue(12)));
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
        public usuario user(long id)
        {
            usuario U = null;
            try
            {
                string sql = "SELECT nombre, apellido1, passwor, user_type FROM dbo.tb_usuarios WHERE identificador = " + id + "AND activo = 1";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    U = new usuario(id, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetInt32(3));

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
                string sql = "SELECT nombre, localidad, cantidad, activo from dbo.tb_hoteles WHERE identificador = " + id;
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    H = new Hoteles(id, dr.GetString(0), dr.GetString(1), dr.GetInt32(2), Convert.ToInt32(dr.GetValue(3)));
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

        public string nombre_hotel(int t_h)
        {
            string n = "";
            try
            {
                string sql = "SELECT nombre FROM dbo.tb_hoteles WHERE identificador='" + t_h + "';";
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
                n = "";
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

        public List<int> habitaciones_disponibles(List<int> tipos,DateTime entrada,int hotel,int t_habi)
        {
            try
            {
                string sql = "SELECT h.hab_id FROM dbo.tb_Habitaciones AS h,dbo.tb_reservaciones AS r WHERE (h.hab_type=" + t_habi + " AND h.id_hotel=" + hotel + " AND h.hab_id=r.hab_id AND  (NOT h.hab_id IN (SELECT hab_id FROM  dbo.tb_reservaciones AS r WHERE R.checkout>= CAST('" + entrada.Year+"-"+entrada.Month+"-"+entrada.Day+"' AS date)))) GROUP BY h.hab_id;";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    tipos.Add(dr.GetInt32(0));
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

        public List<int> habitaciones_disponibles_sin_reserva(List<int> tipos,int hotel, int t_habi)
        { 
            try
            {
                string sql = "SELECT h.hab_id FROM dbo.tb_Habitaciones AS h WHERE ((NOT h.hab_id  IN (SELECT hab_id FROM dbo.tb_reservaciones)) AND h.hab_type=" + t_habi + " AND h.id_hotel=" + hotel + ")";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    tipos.Add(dr.GetInt32(0));
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

        public bool checkASIG(long ID)
        {
            bool s = false;
            try
            {
                string sql = "SELECT* FROM tb_asignaciones WHERE id_user = '"+ ID +"';";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    s = true;
                }
                conex.Desconectar();
            }
            catch
            {
                s = false;
                conex.Desconectar();
            }
            return s;
        }


        public List<int> habitaciones(List<int> tipos, int hotel)
        {
            try
            {
                string sql = "SELECT h.hab_id FROM dbo.tb_Habitaciones AS h WHERE h.id_hotel=" + hotel + ";";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    tipos.Add(dr.GetInt32(0));
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

        public DataTable informacion_reservacion(long id)
        {
            try
            {
                string sql = "SELECT id_reservacion,id_cliente,checkin,checkout,cantidad_personas,hab_id,total FROM dbo.tb_reservaciones WHERE id_cliente="+id+ " AND status!=3;";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(dr);
                conex.Desconectar();
                return tabla;
            }
            catch
            {
                conex.Desconectar();
                return null;
            }
        }

        public DataTable informacion_reservaciones(long id)
        {
            try
            {
                string sql = "SELECT id_reservacion as Reservacion,id_cliente as ID_Cliente,checkin as Fecha_Entrada_Reservada,checkout as Fecha_Salida_Reservada,cantidad_personas as Personas,hab_id as Habitacion,total as Monto FROM dbo.tb_reservaciones WHERE id_cliente=" + id + ";";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(dr);
                conex.Desconectar();
                return tabla;
            }
            catch
            {
                conex.Desconectar();
                return null;
            }
        }

        public int id_reservaciones(long id)
        {
            try
            {

                string sql = "SELECT id_reservacion FROM dbo.tb_reservaciones WHERE hab_id = (SELECT id_hab FROM tb_asignaciones WHERE id_user = '" + id +"');";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                int x = 0;
                while (dr.Read())
                {
                    x = dr.GetInt32(0);
                }
                conex.Desconectar();
                return x;
            }
            catch
            {
                conex.Desconectar();
                return 0;
            }
        }

        

        public List<int> id_reservas(long id)
        {
            List<int> ids=new List<int>();
            try
            {
                string sql = "SELECT id_reservacion FROM dbo.tb_reservaciones WHERE id_cliente=" + id + " AND status!=3;";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    ids.Add(dr.GetInt32(0));
                }
                conex.Desconectar();
                return ids;
            }
            catch
            {
                conex.Desconectar();
                return null;
            }
        }
        public int status(int id)
        {
            try
            {
                string sql = "SELECT status FROM dbo.tb_reservaciones WHERE id_reservacion=" + id + ";";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                int x=0;
                while (dr.Read())
                {
                    x = dr.GetInt32(0);
                }
                conex.Desconectar();
                return x;
            }
            catch
            {
                conex.Desconectar();
                return 0;
            }
        }

        public int total_reserva(int id)
        {
            try
            {
                string sql = "SELECT total FROM dbo.tb_reservaciones WHERE id_reservacion=" + id + ";";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                int total = 0;
                while (dr.Read())
                {
                    total=dr.GetInt32(0);
                }    
                conex.Desconectar();
                return total;
            }
            catch
            {
                conex.Desconectar();
                return 0;
            }
        }

        public DataTable informacion_reservacion_Check_in(long id)
        {
            try
            {
                string sql = "SELECT id_reservacion AS ID_Reservacion,id_cliente AS ID_Cliente,checkin AS Fecha_Entrada,checkout AS Fecha_Salida,cantidad_personas AS Cant_Personas,hab_id AS Numero_Habitacion,total AS Total FROM dbo.tb_reservaciones WHERE id_cliente="+id+ " AND confirm_checkIn is null AND status =3;";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(dr);
                conex.Desconectar();
                return tabla;
            }
            catch
            {
                conex.Desconectar();
                return null;
            }
        }

        public List<int> id_reservas_check_in(long id)
        {
            List<int> ids = new List<int>();
            try
            {
                string sql = "SELECT id_reservacion FROM dbo.tb_reservaciones WHERE id_cliente=" + id + " AND status !=1 AND  confirm_checkIn is null GROUP BY id_reservacion;";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    ids.Add(dr.GetInt32(0));
                }
                conex.Desconectar();
                return ids;
            }
            catch
            {
                conex.Desconectar();
                return null;
            }
        }
        public DataTable informacion_reservacion_Check_out(long id)
        {
            try
            {
                string sql = "SELECT id_reservacion,id_cliente,checkin,checkout,cantidad_personas,hab_id,total FROM dbo.tb_reservaciones WHERE id_cliente=" + id + " AND not(confirm_checkIn is null) AND confirm_checkOut is null AND status =3;";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(dr);
                conex.Desconectar();
                return tabla;
            }
            catch
            {
                conex.Desconectar();
                return null;
            }
        }

        public List<int> id_reservas_check_out(long id)
        {
            List<int> ids = new List<int>();
            try
            {
                string sql = "SELECT id_reservacion FROM dbo.tb_reservaciones WHERE id_cliente=" + id + " AND status =3 AND  not(confirm_checkIn is null)  AND confirm_checkOut is null GROUP BY id_reservacion;";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    ids.Add(dr.GetInt32(0));
                }
                conex.Desconectar();
                return ids;
            }
            catch
            {
                conex.Desconectar();
                return null;
            }
        }

        public DataTable report_hoteles_temporada(DateTime fecha1, DateTime fecha2)
        {
            try
            {
                string sql = "SELECT th.nombre , COUNT(*) as cantidad FROM tb_hoteles th, tb_Habitaciones thb, tb_reservaciones tr WHERE th.identificador = thb.id_hotel AND thb.hab_id = tr.hab_id  AND tr.checkin BETWEEN '" + fecha1.Year + "-" + fecha1.Month + "-" + fecha1.Day + "' AND '" + fecha2.Year + "-" + fecha2.Month + "-" + fecha2.Day + "' GROUP BY th.nombre ORDER BY cantidad DESC";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(dr);
                conex.Desconectar();
                return tabla;
            }
            catch
            {
                conex.Desconectar();
                return null;
            }
        }

        public DataTable report_cantidad_personas_hotel( int anno)
        {
            try
            {
                string sql = "SELECT SUM(tr.cantidad_personas) as cantidad FROM tb_hoteles th, tb_Habitaciones thb, tb_reservaciones tr WHERE th.identificador = thb.id_hotel AND thb.hab_id = tr.hab_id  AND tr.checkin BETWEEN '" + anno+"-01-01' AND '"+anno+"-04-01'";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(dr);
                conex.Desconectar();
                return tabla;
            }
            catch
            {
                conex.Desconectar();
                return null;
            }
        }

        public DataTable report_porcentaje_personas_hotel()
        {
            try
            {
                string sql = "SELECT th.nombre as hotel, ((SUM(tr.cantidad_personas)*100)/(SELECT SUM(r.cantidad_personas) FROM tb_reservaciones r)) as porcentaje FROM tb_hoteles th, tb_Habitaciones thb, tb_reservaciones tr WHERE thb.id_hotel = th.identificador AND thb.hab_id = tr.hab_id GROUP BY th.nombre ";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(dr);
                conex.Desconectar();
                return tabla;
            }
            catch
            {
                conex.Desconectar();
                return null;
            }
        }

        public List<int> report_data(long id,DateTime fecha1)
        {
            
            List<int> ids = new List<int>();
            try
            {
                string sql = "SELECT* FROM tb_Habitaciones hb, tb_hoteles h WHERE NOT EXISTS(SELECT tr.hab_id FROM tb_reservaciones tr WHERE hb.hab_id = tr.hab_id AND tr.checkin = '" + fecha1.Year + "-" + fecha1.Month + "-" + fecha1.Day + "' ) AND hb.id_hotel = h.identificador AND h.identificador = '" + id+"';";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    ids.Add(dr.GetInt32(0));
                }
                conex.Desconectar();
                return ids;
            }
            catch
            {
                conex.Desconectar();
                return null;
            }
        }

        public DataTable report_data_users()
        {

            try
            {
                string sql = "SELECT tus.nombre as Clientes_Frecuentes FROM tb_reservaciones r, tb_usuarios tus WHERE r.id_cliente = tus.identificador GROUP BY r.id_cliente, tus.nombre ORDER BY r.id_cliente DESC";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(dr);
                conex.Desconectar();
                return tabla;
            }
            catch
            {
                conex.Desconectar();
                return null;
            }
        }

        public List<string> report_data_clients()
        {

            List<string> ids = new List<string>();
            try
            {
                //string sql = "SELECT h.nombre FROM tb_hoteles h WHERE h.localidad ='"+idHotel+"' GROUP BY h.localidad, h.nombre";
                string sql = "SELECT h.nombre, h.localidad FROM tb_hoteles h  GROUP BY h.localidad, h.nombre";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    ids.Add(dr.GetString(0));
                }
                conex.Desconectar();
                return ids;
            }
            catch
            {
                conex.Desconectar();
                return null;
            }
        }

    }


}
