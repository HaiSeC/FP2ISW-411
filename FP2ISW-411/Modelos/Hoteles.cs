using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP2ISW_411.Modelos
{
    internal class Hoteles
    {
        long identificador;
        string nombre;
        string localidad;
        int cantidadHab;

        public Hoteles(long identificador, string nombre, string localidad, int cantidadHab)
        {
            this.Identificador = identificador;
            this.Nombre = nombre;
            this.Localidad = localidad;
            this.CantidadHab = cantidadHab;
        }
        public long Identificador { get => identificador; set => identificador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public int CantidadHab { get => cantidadHab; set => cantidadHab = value; }
    }
}
