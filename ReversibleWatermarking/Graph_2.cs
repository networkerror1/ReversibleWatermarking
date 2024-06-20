using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ReversibleDataHiding
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas.Add("area");
            chart1.ChartAreas["area"].AxisX.Minimum = 0;
            chart1.ChartAreas["area"].AxisX.Maximum = 2;
            chart1.ChartAreas["area"].AxisX.Interval = 0.2;
            chart1.ChartAreas["area"].AxisY.Minimum = 0;
            chart1.ChartAreas["area"].AxisY.Interval = 5;
            chart1.ChartAreas["area"].AxisY.Maximum = 50;


            chart1.Legends.Add("unitprice1");
            chart1.Series.Add("Proposed_Scheme");
            chart1.Legends.Add("unitprice2");   
            chart1.Series.Add("B");



            chart1.Series["Proposed_Scheme"].Color = Color.MediumSlateBlue;
            chart1.Series["B"].Color = Color.Green;
            chart1.Series["Proposed_Scheme"].ChartType = SeriesChartType.Line;
            chart1.Series["B"].ChartType = SeriesChartType.Line;

            chart1.Series["Proposed_Scheme"].BorderWidth = 3;
            chart1.Series["B"].BorderWidth = 3;

            //chart1.Series["A"].Points.AddXY(0, 0);

            chart1.Series["Proposed_Scheme"].Points.AddXY(0.4, 65);
            chart1.Series["B"].Points.AddXY(0.4,55);

            chart1.Series["Proposed_Scheme"].Points.AddXY(0.5, 44);
            chart1.Series["B"].Points.AddXY(0.45,38);

            chart1.Series["Proposed_Scheme"].Points.AddXY(0.76, 43);
            chart1.Series["B"].Points.AddXY(0.82,33);

            chart1.Series["Proposed_Scheme"].Points.AddXY(0.85, 38);
            //chart1.Series["B"].Points.AddXY(7,4.5);

            chart1.Series["Proposed_Scheme"].Points.AddXY(1.12, 37);
            chart1.Series["B"].Points.AddXY(1.15, 32);

            chart1.Series["Proposed_Scheme"].Points.AddXY(1.18, 31);
            chart1.Series["B"].Points.AddXY(1.18, 20);

            chart1.Series["Proposed_Scheme"].Points.AddXY(1.23, 24);
            //chart1.Series["B"].Points.AddXY(7, 4.5);

            chart1.Series["Proposed_Scheme"].Points.AddXY(1.42, 18);
            chart1.Series["B"].Points.AddXY(1.20, 15);

            chart1.Series["B"].Points.AddXY(1.38, 10);
        }
    }
}
