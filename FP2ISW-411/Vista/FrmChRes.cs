using FP2ISW_411.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP2ISW_411.Vista
{
    public partial class FrmChRes : Form
    {
        procesos P = new procesos();
        long id;
        public FrmChRes(long id)
        {
            InitializeComponent();
            
            this.id = id;

            dataGridView1.DataSource = P.informacion_reservaciones(id);
        }
    }
}
