using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP2ISW_411.Modelos
{
    internal class Habitaciones
    {
        int tipo;
        int id_hotel;

        public Habitaciones(int type, int hotel)
        {
            Tipo = type;
            id_hotel = hotel;
        }

        public int Tipo { get => tipo; set => tipo = value; }
        public int Id_hotel { get => id_hotel; set => id_hotel = value; }

        

    }
}
