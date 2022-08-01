using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FP2ISW_411.Modelos;
using FP2ISW_411.Datos;
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
        public bool insert_usuario(usuario U)
        {
            return inser.registrar_usu(U);
        }
        public bool insert_direc(usuario U)
        {
            return inser.registrar_direccion(U);
        }

        public usuario info_usu (long i)
        {
            return c.info_usu(i);
        }

        public Hoteles GetH(long i)
        {
            return c.SelH(i);
        }

        public usuario admin(long i)
        {
            return c.admin(i);
        }
        public string nombre_puesto(int i)
        {
            return c.nombre_puesto(i);
        }
        public bool desac_usu(long id)
        {
            return up.desactivar_usu(id);
        }

        public bool modi_info(usuario u)
        {
            return (up.modificar_usu(u) && up.modificar_direct(u));
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
    }
}
