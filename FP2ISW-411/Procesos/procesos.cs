using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FP2ISW_411.Datos;
namespace FP2ISW_411.Procesos
{
    internal class procesos
    {
        Datos.Counsultas c = new Counsultas();
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
        public int codigo_puest(string T)
        {
            int P = c.codigo_puesto(T);
            return P;
        }
    }
}
