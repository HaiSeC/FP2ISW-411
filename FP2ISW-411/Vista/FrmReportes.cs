using FP2ISW_411.Datos;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace FP2ISW_411.Vista
{
    public partial class FrmReportes : Form
    {
        procesos P = new procesos();
        public FrmReportes()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            DataTable data = P.report5();
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listView1.Items.Add(item);
            }

            List<string> hoteles = P.nombre_hoteles();
            if ( hoteles == null)
            {
                MessageBox.Show("Error al Conectar con la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (string hotel in hoteles)
                {
                    comboBox1.Items.Add(hotel);
                }
                comboBox1.SelectedIndex = 0;
            }
            DataTable data1 = P.report3();
            chart2.DataSource = data1;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.Series.Clear();
            for (int i = 1; i < data1.Columns.Count; i++)
            {
                Series series = new Series();
                series.XValueMember = data1.Columns[0].ColumnName;
                series.YValueMembers = data1.Columns[i].ColumnName;
                series.ChartType = SeriesChartType.Line;
                series.IsVisibleInLegend = true;
                series.IsValueShownAsLabel = true;
                series.BorderWidth = 3;
                series.LegendText = data1.Columns[i].ColumnName;
                chart1.Series.Add(series);
            }
            DataTable data2 = P.report2(Convert.ToInt32(dateTimePicker1.Text));
            var enumerableTable2 = (data2 as System.ComponentModel.IListSource).GetList();
            try
            {
                chart4.DataBindTable(enumerableTable2, "s");

            }
            catch (Exception)
            {

            }
            chart1.DataSource = P.report6();


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
