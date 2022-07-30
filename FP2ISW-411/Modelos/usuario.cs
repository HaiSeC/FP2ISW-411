using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP2ISW_411.Modelos
{
    internal class usuario
    {
        long cedula;
        string Noombre;
        string apellidos;
        string contraseña;
        int edad;
        DateTime fecha_nac;
        string direccion;
        DateTime fecha_contratacion;
        int puesto;
        public usuario(long cedula, string noombre, string apellidos, string contraseña, int edad, DateTime fecha_nac, string direccion, DateTime fecha_contratacion, int puesto)
        {
            this.cedula = cedula;
            Noombre = noombre;
            this.apellidos = apellidos;
            this.contraseña = contraseña;
            this.edad = edad;
            this.fecha_nac = fecha_nac;
            this.direccion = direccion;
            this.fecha_contratacion = fecha_contratacion;
            this.puesto = puesto;
        }
    }
}
