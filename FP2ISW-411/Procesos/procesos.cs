using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FP2ISW_411.Modelos;
using FP2ISW_411.Datos;
using System.Data;

namespace FP2ISW_411.Procesos
{
    internal class procesos
    {
        Counsultas c = new Counsultas();
        inserciones inser = new inserciones();
        updates up= new updates();
        public List<string> tipos_habi()
        {
            List<string> tipos = c.tipos_habi();
            return tipos;
        }
        public double tarifa_hab(string tipo_hab)
        {
            double tarifa=c.tarifa(tipo_hab);
            return tarifa;
        }
        public List<string> tipo_puestos()
        {
            List<string> tipos = c.puestos();
            return tipos;
        }
        public List<string> nombre_hoteles()
        {
            return c.nombre_hoteles();
        }
        public int codigo_puest(string T)
        {
            int P = c.codigo_puesto(T);
            return P;
        }

        public List<usuario> getEmpleados()
        {
            return c.Consultar_Usuarios();
        }

        public int getCode_H(long id)
        {
            return c.consultar_codigoH(id);
        }
        public int getCode_HN(string name)
        {
            return c.consultar_codigoHN(name);
        }
        public bool insert_usuario(usuario U)
        {
            return inser.registrar_usu(U);
        }
        public bool insert_direc(usuario U)
        {
            return inser.registrar_direccion(U);
        }
        public bool insert_hotel(Hoteles h)
        {
            return inser.registrar_hotel(h);
        }

        public usuario info_usu (long i)
        {
            return c.info_usu(i);
        }

        public bool insert_situacion(Situaciones st, int id)
        {
            return inser.registrar_situacion(st, id);
        }
        public Hoteles GetH(long i)
        {
            return c.SelH(i);
        }

        public int getResidHab(int id)
        {
            return c.id_reservaciones(id);
        }

        public usuario user(long i)
        {
            return c.user(i);
        }
        public string nombre_puesto(int i)
        {
            return c.nombre_puesto(i);
        }

        public string nombre_hotel(int i)
        {
            return c.nombre_hotel(i);
        }

        public bool desac_usu(long id)
        {
            return up.desactivar_usu(id);
        }
        public bool desac_hot(long id)
        {
            return up.desactivar_hotel(id);
        }

        public bool modi_info(usuario u)
        {
            return (up.modificar_usu(u) && up.modificar_direct(u));
        }

        public bool modi_hot(Hoteles h)
        {
            return (up.modificar_hoteles(h));
        }

        public int cod_Hotel(string T)
        {
            return c.codigo_Hotel(T);
        }
        public int cod_T_habi(string T)
        {
            return c.codigo_Tipo_habi(T);
        }

        public void insert_tarifa(string T_habi,string hotel,double precio)
        {
            inser.registrar_Tarifa(cod_Hotel(hotel),cod_T_habi(T_habi),precio);
        }
        public double prec_tarifa(string Hot, string t_habi)
        {
            return c.precio_tarifa(cod_Hotel(Hot), cod_T_habi(t_habi));
        }
        public bool modi_tarifa(string T_habi, string hotel, double precio)
        {
            return up.modificar_Tarifa(cod_Hotel(hotel),cod_T_habi(T_habi),precio);
        }

        public List<int> habi_disponibles(DateTime entrada,int hotel,int T_habi)
        {
            List<int> t = new List<int>();
            return c.habitaciones_disponibles_sin_reserva(c.habitaciones_disponibles(t,entrada,hotel,T_habi),hotel,T_habi);
        }

        public List<int> habs(int hotel)
        {
            List<int> t = new List<int>();
            return c.habitaciones(t, hotel);
        }

        public bool agregar_asignacion(long idus, int idhot, int idhab)
        {
            return inser.registrar_asignacion(idus, idhot, idhab);
        }

        public bool cambiar_asignacion(long idus, int idhot, int idhab)
        {
            return up.modificar_asignaciont(idus, idhot, idhab);
        }

        public bool cambiar_puesto(int puesto, long user)
        {
            return up.modificar_puesto(puesto, user);
        }

        public bool CASS(long ID)
        {
            return c.checkASIG(ID);
        }
        public bool reservar(long ced, DateTime entrada, DateTime salida, int personas, int habitacion, int precio)
        {
            return inser.reservar(ced, entrada, salida, personas, habitacion,precio);
        }

        public DataTable informacion_reservaciones(long id)
        {
            return c.informacion_reservaciones(id);
        }

        public DataTable informacion_reservacion(long id)
        {
            return c.informacion_reservacion(id);
        }
        public List<int> ids_reservas(long id)
        {
            return c.id_reservas(id);
        }
        public int status(int id)
        {
            return c.status(id);
        }
        public int total_reserva(int id)
        {
            return c.total_reserva(id);
        }

        public bool modificar_status(int estado, int id)
        {
            return up.modificar_status(estado, id);
        }

        public DataTable SituacionesOut(int hab)
        {
            return c.SituacionesOut(hab);
        }
        
        public DataTable informacion_reservacion_Check(string T_check, long id)
        {
            if (T_check == "in")
            {
                return c.informacion_reservacion_Check_in(id);
            }
            else
            {
                return c.informacion_reservacion_Check_out(id);
            }
        }
        public List<int> ids_reservas_check(long id, string T_check)
        {
            if (T_check == "in")
            {
                return c.id_reservas_check_in(id);
            }
            else
            {
                return c.id_reservas_check_out(id);
            }
        }
        public bool Modificar_checks(int id, string T_check)
        {
            if (T_check == "in")
            {
                return up.modificar_checkIn(id);
            }
            else
            {
                return up.modificar_checkOut(id);
            }
        }

        public DataTable report1(DateTime fecha1, DateTime fecha2)
        {
            return c.report_hoteles_temporada(fecha1, fecha2);
        }

        public DataTable report2( int anno)
        {
            return c.report_cantidad_personas_hotel( anno);
        }

        public DataTable report3()
        {
            return c.report_porcentaje_personas_hotel();
        }

        public List<int> report4(long id, DateTime fecha1, DateTime fecha2)
        {
            return c.report_data(id, fecha1);
        }

        public DataTable report5()
        {
            return c.report_data_users();
        }

        public DataTable report6()
        {
            return c.report_data_clients();
        }

    }
}
