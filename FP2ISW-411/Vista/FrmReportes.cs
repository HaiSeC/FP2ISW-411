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


            report1load();
            report2load();
            report3load();
            report6load();
        }

        void report1load()
        {
            DataTable data1 = P.report1(dateTimePicker2.Value.Date, dateTimePicker3.Value.Date);
            chart2.DataSource = data1;
            chart2.ChartAreas[0].AxisX.Interval = 1;
            chart2.Series.Clear();
            for (int i = 1; i < data1.Columns.Count; i++)
            {
                Series series = new Series();
                series.YValueMembers = data1.Columns[i].ColumnName;
                series.ChartType = SeriesChartType.Line;
                series.IsVisibleInLegend = true;
                series.IsValueShownAsLabel = true;
                series.BorderWidth = 3;
                series.LegendText = data1.Columns[i].ColumnName;
                chart2.Series.Add(series);
            }
        }

        void report2load()
        {
            DataTable data1 = P.report2(Convert.ToInt32(dateTimePicker1.Text));
            chart1.DataSource = data1;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.Series.Clear();
            for (int i = 0; i < data1.Columns.Count; i++)
            {
                Series series = new Series();
                series.YValueMembers = data1.Columns[i].ColumnName;
                series.ChartType = SeriesChartType.Line;
                series.IsVisibleInLegend = true;
                series.IsValueShownAsLabel = true;
                series.BorderWidth = 3;
                series.LegendText = data1.Columns[i].ColumnName;
                chart1.Series.Add(series);
            }
        }

        void report3load()
        {
            DataTable data1 = P.report3();
            chart4.DataSource = data1;
            chart4.ChartAreas[0].AxisX.Interval = 1;
            chart4.Series.Clear();
            for (int i =1; i < data1.Columns.Count; i++)
            {
                Series series = new Series();
                series.YValueMembers = data1.Columns[i].ColumnName;
                series.ChartType = SeriesChartType.Column;
                series.IsVisibleInLegend = true;
                series.IsValueShownAsLabel = true;
                series.BorderWidth = 3;
                series.LegendText = data1.Columns[i].ColumnName;
                chart4.Series.Add(series);
            }
        }

        void report6load()
        {
            DataTable data1 = P.report6();
            chart3.DataSource = data1;
            chart3.ChartAreas[0].AxisX.Interval = 1;
            chart3.Series.Clear();
            for (int i = 1; i < data1.Columns.Count; i++)
            {
                Series series = new Series();
                series.XValueMember = data1.Columns[0].ColumnName;
                series.YValueMembers = data1.Columns[i].ColumnName;
                series.ChartType = SeriesChartType.Column;
                series.IsVisibleInLegend = true;
                series.IsValueShownAsLabel = true;
                series.BorderWidth = 3;
                series.LegendText = data1.Columns[i].ColumnName;
                chart3.Series.Add(series);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            report1load();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            report2load();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            report1load();
        }
    }
}
