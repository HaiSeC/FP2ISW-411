using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP2ISW_411
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }
        public FrmInicio(int r, int g, int b)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
