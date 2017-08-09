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
using System.Text.RegularExpressions;


namespace ServoTool
{
    public partial class FormPlotBode : Form
    {
        List<List<float>> DataList3 = new List<List<float>>();
        CheckBox[] CheckBoxArry;
        public FormPlotBode()
        {
            InitializeComponent();
        }

        private void FormPlotBode_Load(object sender, EventArgs e)
        {
            CheckBoxArry = new CheckBox[8] { checkBox3_CH1, checkBox3_CH2, checkBox3_CH3, checkBox3_CH4, checkBox3_CH5, checkBox3_CH6, checkBox3_CH7, checkBox3_CH8 };

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


            this.chart2.Series.Clear();
            chart2.Visible = true;
            chart2.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart2.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart2.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chart2.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart2.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart2.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart2.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
        }

        private void checkBox3_CH1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox CkBox = (CheckBox)sender;
            if (CkBox.Checked)
            {
                chart1.Series[(CkBox.TabIndex) - 1].Enabled = true;
                chart2.Series[(CkBox.TabIndex) - 1].Enabled = true;
            }
            else
            {
                chart1.Series[(CkBox.TabIndex) - 1].Enabled = false;
                chart2.Series[(CkBox.TabIndex) - 1].Enabled = false;
            }
            chart1.ChartAreas[0].RecalculateAxesScale();
            chart2.ChartAreas[0].RecalculateAxesScale();
        }
        

        private void FormPlotBode_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataList3.Clear();
            chart1.Dispose();
            this.Dispose();
            this.Close();
            GC.Collect();
        }

        private void Btn_BodePlot_Click(object sender, EventArgs e)
        {
            int NumOfChanl = 0;
            this.chart1.ChartAreas[0].AxisX.IsLogarithmic = false;
            this.chart2.ChartAreas[0].AxisX.IsLogarithmic = false;
            try
            {
                DataList3.Clear();
                this.chart1.Series.Clear();
                this.chart2.Series.Clear();
                OpenFileDialog ReadPath = new OpenFileDialog();                
                ReadPath.Filter = "CSV|*.csv";
                if (ReadPath.ShowDialog() == System.Windows.Forms.DialogResult.OK && ReadPath.FileName != "")
                {
                    string[] ValArry,TypArry;
                    string RdLine;
                    StreamReader sr = new StreamReader(ReadPath.FileName);
                    sr.ReadLine();
                    sr.ReadLine();
                    RdLine = sr.ReadLine();
                    TypArry = RdLine.Split(',');
                    sr.ReadLine();                    
                    chart1.ChartAreas[0].AxisX.Title = "Frequency (Hz)";
                    chart1.ChartAreas[0].AxisY.Title = "Gain";
                    chart2.ChartAreas[0].AxisX.Title = "Frequency (Hz)";
                    chart2.ChartAreas[0].AxisY.Title = "Phase";
                    while (!sr.EndOfStream)
                    {
                        RdLine = sr.ReadLine();
                        ValArry = RdLine.Split(',');
                        NumOfChanl = ValArry.Length;
                        for (int i = 0; i < NumOfChanl; i++)
                        {
                            DataList3.Add(new List<float>());
                            DataList3[i].Add(float.Parse(ValArry[i]));
                        }
                    }
                    sr.Close();
                    MTS.MTS_func mts = new MTS.MTS_func();
                    mts.BodePlot(ref DataList3);
                    if (NumOfChanl != 0)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            CheckBoxArry[i].Enabled = false;
                        }
                        Series seriesGain = new Series("Gain");
                        seriesGain.ChartType = SeriesChartType.FastLine;
                        this.chart1.ChartAreas[0].AxisX.IsLogarithmic = true;
                        seriesGain.BorderWidth = 2;
                        seriesGain.BorderColor = Color.Blue;
                        Series seriesPhase = new Series("Phase");
                        seriesPhase.ChartType = SeriesChartType.FastLine;
                        this.chart2.ChartAreas[0].AxisX.IsLogarithmic = true;
                        seriesPhase.BorderWidth = 2;
                        seriesPhase.BorderColor = Color.Blue;
                        for (int i = 0; i < DataList3[0].Count; i++)
                        {
                            seriesGain.Points.AddXY(DataList3[0][i], DataList3[1][i]);
                            seriesPhase.Points.AddXY(DataList3[0][i], DataList3[2][i]);
                        }
                        this.chart1.Series.Add(seriesGain);
                        this.chart2.Series.Add(seriesPhase);
                        CheckBoxArry[0].Enabled = true;
                        CheckBoxArry[0].Checked = true;
                    }
                    else
                        MessageBox.Show("Load Error(format is incorrect)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Load Error(path is wrong)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        

        private void chart1_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                DataPoint myPoint = (DataPoint)(e.HitTestResult.Object);
                e.Text = "X value: " + myPoint.XValue + Environment.NewLine;
                e.Text += "Y value: " + myPoint.YValues[0] + Environment.NewLine;
            }
        }

        private void FormPlotBode_Resize(object sender, EventArgs e)
        {
            chart1.Height = panel2.Height / 2;
            chart2.Top = panel2.Top + chart1.Height;
            chart2.Height = panel2.Height / 2 ;
        }
    }
}
