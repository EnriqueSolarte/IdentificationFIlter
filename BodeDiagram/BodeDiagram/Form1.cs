using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;
using System.Numerics;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;


namespace BodeDiagram
{
    public partial class Form1 : Form
    {
        DataAnalysis data = new DataAnalysis();
        public string filename = @"C:\Users\533597\Documents\GitHub\IdentificationFIlter\BodeDiagram\SoftwareTimeResponse1.csv";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (TextReader file = new StreamReader(filename))
            {
                data.getPlottingData(file);
            }
            PlotFFT(data.MAGNITUDE_BODE, data.PHASE_BODE, data.FREQUENCY_BODE);
            data.clearPlottingData();
        }

        public void PlotFFT(List<double> Magnitude, List<double> Phase, List<double> Frequency)
        {
            chart1.Series["Frequency"].Points.Clear();
            chart2.Series["Frequency"].Points.Clear();

            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Hz";
            chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 10.0f);
            chart1.ChartAreas["ChartArea1"].AxisX.MinorTickMark.Enabled = true;
            chart1.ChartAreas["ChartArea1"].AxisX.MinorTickMark.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.IsLogarithmic = true;
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.Enabled = true;
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.LineColor = Color.FromName("LightGray");
            chart1.Series["Frequency"].LegendText = "Phase";
            chart1.Series["Frequency"].ChartType = SeriesChartType.Line;

            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Hz";
            chart2.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 10.0f);
            chart2.ChartAreas["ChartArea1"].AxisX.MinorTickMark.Enabled = true;
            chart2.ChartAreas["ChartArea1"].AxisX.MinorTickMark.Interval = 1;
            chart2.ChartAreas["ChartArea1"].AxisX.IsLogarithmic = true;
            chart2.ChartAreas["ChartArea1"].AxisX.MinorGrid.Enabled = true;
            chart2.ChartAreas["ChartArea1"].AxisX.MinorGrid.Interval = 1;
            chart2.ChartAreas["ChartArea1"].AxisX.MinorGrid.LineColor = Color.FromName("LightGray");
            chart2.Series["Frequency"].LegendText = "Magnitude";
            chart2.Series["Frequency"].ChartType = SeriesChartType.Line;

            for (int i = 0; i < Magnitude.Count; i++)
            {
                chart1.Series["Frequency"].Points.AddXY(Frequency[i], Phase[i]);
                chart2.Series["Frequency"].Points.AddXY(Frequency[i], Magnitude[i]);                
            }
        }
    }
}
