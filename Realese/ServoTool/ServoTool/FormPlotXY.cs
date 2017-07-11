using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace ServoTool
{
    public partial class FormPlotXY : Form
    {
        List<List<double>> DataList2 = new List<List<double>>();
        public FormPlotXY()
        {
            InitializeComponent();            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();
            chart1.Visible = true;
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
            Btn2_Plot.Enabled = false;
        }

        private void Btn2_Plot_Click(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();
            Series series1 = new Series("SmplData");
            series1.ChartType = SeriesChartType.Line;

            if (CB2_AxisX.SelectedItem != null && CB2_AxisY.SelectedItem != null && DataList2.Count != 0)
            {
                for (int i = 0; i < DataList2[CB2_AxisX.SelectedIndex].Count; i++)
                {
                    series1.Points.AddXY(DataList2[CB2_AxisX.SelectedIndex][i], DataList2[CB2_AxisY.SelectedIndex][i]);
                }
            }
            else
            {
                MessageBox.Show("Plot Error(data error)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.chart1.Series.Add(series1);
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void Btn2_Load_Click(object sender, EventArgs e)
        {
            try
                {
                DataList2.Clear();
                OpenFileDialog ReadPath = new OpenFileDialog();                
                ReadPath.Filter = "取樣資料|*.smpl|CSV|*.csv";
                if (ReadPath.ShowDialog() == System.Windows.Forms.DialogResult.OK && ReadPath.FileName != "")
                {
                    string[] StrArry;
                    StreamReader sr = new StreamReader(ReadPath.FileName);
                    sr.ReadLine();
                    sr.ReadLine();
                    string ReadLine = sr.ReadLine();
                    StrArry = ReadLine.Split(',');
                    CB2_AxisX.Items.Clear();
                    CB2_AxisY.Items.Clear();
                    CB2_AxisX.Items.AddRange(StrArry);
                    CB2_AxisY.Items.AddRange(StrArry);
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        ReadLine = sr.ReadLine();
                        StrArry = ReadLine.Split(',');                        
                        for (int i=0;i<StrArry.Length;i++)
                        {
                            DataList2.Add(new List<double>());
                            DataList2[i].Add(double.Parse(StrArry[i]));
                        }                        
                    }
                    sr.Close();
                    Btn2_Plot.Enabled = true;
                    CB2_AxisX.Enabled = true;
                    CB2_AxisY.Enabled = true;
                }
                else
                {
                    Btn2_Plot.Enabled = false;
                    CB2_AxisX.Items.Clear();
                    CB2_AxisY.Items.Clear();
                    MessageBox.Show("Load Error(please select a file in right format)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                    
            }
            catch (Exception ex)
            {
                CB2_AxisX.Enabled = false;
                CB2_AxisY.Enabled = false;
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPlotXY_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataList2.Clear();
            chart1.Dispose();
            this.Dispose();
            this.Close();
            GC.Collect();
        }
    }
}
