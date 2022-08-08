using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP2ISW_411.Modelos
{
    internal class Situaciones
    {
        int usoBar = 0;
        int usoCF = 0;
        string desc = "";

        public Situaciones()
        {
            //int usoBar = 0;
            //int usoCF = 0;
            //string desc = "";
        }

        public Situaciones(int usoBar, int usoCF, string desc)
        {
            this.UsoBar = usoBar;
            this.UsoCF = usoCF;
            this.Desc = desc;
        }
        
        public int UsoBar { get => usoBar; set => usoBar = value; }
        public int UsoCF { get => usoCF; set => usoCF = value; }
        public string Desc { get => desc; set => desc = value; }
        public string GetAll { get => "Esta Información será a Almacenada\nDescripción de la Situación: " + desc + "\nUso del Bar: " + UsoBar + "\nUso de la Caja Fuerte: " + UsoCF; }
    }
        
}
