﻿using System;
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
using ViliPetek.LinearAlgebra;

namespace ServoTool
{
    public partial class FormPlotYT : Form
    {
        List<List<double>> DataList3 = new List<List<double>>();
        CheckBox[] CheckBoxArry;
        public FormPlotYT()
        {
            InitializeComponent();
        }

        private void FormPlotYT_Load(object sender, EventArgs e)
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
        }

        private void checkBox3_CH1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox CkBox = (CheckBox)sender;
            if (CkBox.Checked)
            {
                chart1.Series[(CkBox.TabIndex) - 1].Enabled = true;
            }
            else
            {
                chart1.Series[(CkBox.TabIndex) - 1].Enabled = false;
            }
            chart1.ChartAreas[0].RecalculateAxesScale();
        }


        private void Btn3_Load_Click(object sender, EventArgs e)
        {
            this.chart1.ChartAreas[0].AxisX.IsLogarithmic = false;
            
            try
            {
                DataList3.Clear();
                this.chart1.Series.Clear();
                OpenFileDialog ReadPath = new OpenFileDialog();     
                ReadPath.Filter = "取樣資料|*.smpl|頻率響應|*.frq|CSV|*.csv";
                if (ReadPath.ShowDialog() == System.Windows.Forms.DialogResult.OK && ReadPath.FileName != "")
                {
                    string[] ValArry, TypeArry, UnitArry;
                    StreamReader sr = new StreamReader(ReadPath.FileName);
                    string RdLine = sr.ReadLine();
                    chart1.ChartAreas[0].AxisX.Title = "Time(1ms) "+ RdLine;
                    Regex rx = new Regex("[0-9][^m]*");
                    Match SmplPeriodMatch = rx.Match(RdLine);
                    float SmplPeriod = float.Parse(SmplPeriodMatch.Value);
                    sr.ReadLine();
                    RdLine = sr.ReadLine();
                    TypeArry = RdLine.Split(',');
                    RdLine = sr.ReadLine();
                    UnitArry = RdLine.Split(',');
                    int NumOfChanl = 3;
                    for (int i = 0; i < NumOfChanl; i++)
                    {
                        DataList3.Add(new List<double>());
                    }

                    while (!sr.EndOfStream)
                    {
                        RdLine = sr.ReadLine();
                        ValArry = RdLine.Split(',');
                        NumOfChanl = ValArry.Length;
                        for (int i = 0; i < NumOfChanl; i++)
                        {
                           // DataList3.Add(new List<double>());
                            DataList3[i].Add(double.Parse(ValArry[i]));
                        }
                    }
                    sr.Close();

                    //while (true)
                    //{
                    //    if (DataList3[1][0] == 0)
                    //    {
                    //        for (int i = 0; i < 3; i++)
                    //        {
                    //            DataList3[i].RemoveAt(0);
                    //        }
                    //    }
                    //    else
                    //    {
                    //        break; ;
                    //    }
                    //}
                    //while (true)
                    //{
                    //    int last = DataList3[1].Count - 1;
                    //    if (DataList3[1][last] == 0)
                    //    {
                    //        for (int i = 0; i < 3; i++)
                    //        {
                    //            DataList3[i].RemoveAt(last);
                    //        }
                    //    }
                    //    else
                    //    {
                    //        break;
                    //    }
                    //}
                    //int DataLength = DataList3[0].Count;

                    //int Index = 0;
                    //DataList3.Add(new List<double>());
                    //DataList3[1].Clear();
                    //for (int i = 0; i < DataLength - 1; i++)
                    //{
                    //    if (DataList3[2][i + 1] != DataList3[2][i] || i == DataLength - 2)
                    //    {
                    //        double[] xx = new double[i - Index + 1];
                    //        double[] yy = new double[i - Index + 1];
                    //        for (int j = 0; j < (i - Index + 1); j++)
                    //        {
                    //            xx[j] = j;
                    //            yy[j] = DataList3[0][j + Index];
                    //        }
                    //        //FrqDataList[2].GetRange(PhaseStart, (int)PeriodTimes).CopyTo(yy);
                    //        var polyfit = new PolyFit(xx, yy, 11);
                    //        var fitted = polyfit.Fit(xx);

                    //        for (int j = 0; j < (i - Index + 1); j++)
                    //        {
                    //            DataList3[1].Add((double)fitted[j]);
                    //        }
                    //        Index = i+1;
                    //    }
                    //}

                    if (NumOfChanl != 0)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            CheckBoxArry[i].Enabled = false;
                        }
                        for (int i = 0; i < NumOfChanl; i++)
                        {
                            Series series1 = new Series("CH" + (i + 1) + "[" + TypeArry[i] + "("+ UnitArry[i] +")"+ "]");
                            series1.ChartType = SeriesChartType.FastLine;
                            if (ReadPath.FilterIndex == 2)
                            {
                                if (i == 2)
                                    series1.YAxisType = AxisType.Secondary;
                                else
                                    series1.YAxisType = AxisType.Primary;
                            }
                            for (int j = 0; j < DataList3[i].Count; j++)
                            {
                               // if (i == 2)
                                //    DataList3[i][j] = DataList3[i][j]+ (float)0.142;
                                series1.Points.AddXY((j + 1) * SmplPeriod, DataList3[i][j]);
                            }
                            this.chart1.Series.Add(series1);
                            CheckBoxArry[i].Enabled = true;
                            CheckBoxArry[i].Checked = true;
                        }
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

        private void FormPlotYT_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataList3.Clear();
            chart1.Dispose();
            this.Dispose();
            this.Close();
            GC.Collect();
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
    }
}
