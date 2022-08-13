using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP2ISW_411.Modelos
{
    public class usuario
    {
        long cedula;
        string Nombre;
        string apellido1;
        string apellido2;
        string password;
        int edad;
        DateTime fecha_nac;
        string direccion;
        string canton;
        string pais;
        string provincia;
        DateTime fecha_contratacion;
        int puesto;
        int cliente;
        int activo;
        public usuario(long cedula, string noombre, string apellido1,string apellido2, string password, int edad, DateTime fecha_nac, string pais, string provincia, string canton, string direccion, DateTime fecha_contratacion, int puesto, int cliente, int activo)
        {
            this.Cedula = cedula;
            this.Nombre = noombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Fecha_nac = fecha_nac;
            this.Direccion = direccion;
            this.Fecha_contratacion = fecha_contratacion;
            this.Puesto = puesto;
            this.password = password;
            this.Canton = canton;
            this.Pais = pais;
            this.Provincia = provincia;
            this.edad = edad;
            this.cliente = cliente;
            this.Activo = activo;           
        }

        public usuario(long cedula, string noombre, string apellido1, string password, int puesto)
        {
            this.Cedula = cedula;
            this.Nombre = noombre;
            this.Apellido1 = apellido1;
            this.password = password;
            this.Puesto = puesto;
        }

        public usuario(long cedula, string noombre, string apellido1, string apellido2, int puesto, int activo)
        {
            this.Cedula = cedula;
            this.Nombre = noombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Activo = activo;
            this.Puesto = puesto;
        }

        public long Cedula { get => cedula; set => cedula = value; }
        public string nombre { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Password { get => password; set => password = value; }
        public int Edad { get => edad; set => edad = value; }
        public DateTime Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime Fecha_contratacion { get => fecha_contratacion; set => fecha_contratacion = value; }
        public int Puesto { get => puesto; set => puesto = value; }
        public string Canton { get => canton; set => canton = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public int Cliente { get => cliente; set => cliente = value; }
        public int Activo { get => activo; set => activo = value; }
    }
}
