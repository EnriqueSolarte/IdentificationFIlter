namespace ServoTool
{
    partial class FormPlotBode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox3_CH1 = new System.Windows.Forms.CheckBox();
            this.Btn_BodePlot = new System.Windows.Forms.Button();
            this.checkBox3_CH2 = new System.Windows.Forms.CheckBox();
            this.checkBox3_CH3 = new System.Windows.Forms.CheckBox();
            this.checkBox3_CH8 = new System.Windows.Forms.CheckBox();
            this.checkBox3_CH4 = new System.Windows.Forms.CheckBox();
            this.checkBox3_CH7 = new System.Windows.Forms.CheckBox();
            this.checkBox3_CH5 = new System.Windows.Forms.CheckBox();
            this.checkBox3_CH6 = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.checkBox3_CH1);
            this.panel1.Controls.Add(this.Btn_BodePlot);
            this.panel1.Controls.Add(this.checkBox3_CH2);
            this.panel1.Controls.Add(this.checkBox3_CH3);
            this.panel1.Controls.Add(this.checkBox3_CH8);
            this.panel1.Controls.Add(this.checkBox3_CH4);
            this.panel1.Controls.Add(this.checkBox3_CH7);
            this.panel1.Controls.Add(this.checkBox3_CH5);
            this.panel1.Controls.Add(this.checkBox3_CH6);
            this.panel1.Location = new System.Drawing.Point(1129, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 623);
            this.panel1.TabIndex = 16;
            // 
            // checkBox3_CH1
            // 
            this.checkBox3_CH1.AutoSize = true;
            this.checkBox3_CH1.Enabled = false;
            this.checkBox3_CH1.Font = new System.Drawing.Font("新細明體", 16F);
            this.checkBox3_CH1.Location = new System.Drawing.Point(17, 26);
            this.checkBox3_CH1.Name = "checkBox3_CH1";
            this.checkBox3_CH1.Size = new System.Drawing.Size(68, 26);
            this.checkBox3_CH1.TabIndex = 1;
            this.checkBox3_CH1.Text = "CH1";
            this.checkBox3_CH1.UseVisualStyleBackColor = true;
            this.checkBox3_CH1.CheckedChanged += new System.EventHandler(this.checkBox3_CH1_CheckedChanged);
            // 
            // Btn_BodePlot
            // 
            this.Btn_BodePlot.Font = new System.Drawing.Font("新細明體", 12F);
            this.Btn_BodePlot.Location = new System.Drawing.Point(3, 443);
            this.Btn_BodePlot.Name = "Btn_BodePlot";
            this.Btn_BodePlot.Size = new System.Drawing.Size(87, 42);
            this.Btn_BodePlot.TabIndex = 12;
            this.Btn_BodePlot.Text = "BodePlot";
            this.Btn_BodePlot.UseVisualStyleBackColor = true;
            this.Btn_BodePlot.Click += new System.EventHandler(this.Btn_BodePlot_Click);
            // 
            // checkBox3_CH2
            // 
            this.checkBox3_CH2.AutoSize = true;
            this.checkBox3_CH2.Enabled = false;
            this.checkBox3_CH2.Font = new System.Drawing.Font("新細明體", 16F);
            this.checkBox3_CH2.Location = new System.Drawing.Point(17, 58);
            this.checkBox3_CH2.Name = "checkBox3_CH2";
            this.checkBox3_CH2.Size = new System.Drawing.Size(68, 26);
            this.checkBox3_CH2.TabIndex = 2;
            this.checkBox3_CH2.Text = "CH2";
            this.checkBox3_CH2.UseVisualStyleBackColor = true;
            this.checkBox3_CH2.CheckedChanged += new System.EventHandler(this.checkBox3_CH1_CheckedChanged);
            // 
            // checkBox3_CH3
            // 
            this.checkBox3_CH3.AutoSize = true;
            this.checkBox3_CH3.Enabled = false;
            this.checkBox3_CH3.Font = new System.Drawing.Font("新細明體", 16F);
            this.checkBox3_CH3.Location = new System.Drawing.Point(17, 90);
            this.checkBox3_CH3.Name = "checkBox3_CH3";
            this.checkBox3_CH3.Size = new System.Drawing.Size(68, 26);
            this.checkBox3_CH3.TabIndex = 3;
            this.checkBox3_CH3.Text = "CH3";
            this.checkBox3_CH3.UseVisualStyleBackColor = true;
            this.checkBox3_CH3.CheckedChanged += new System.EventHandler(this.checkBox3_CH1_CheckedChanged);
            // 
            // checkBox3_CH8
            // 
            this.checkBox3_CH8.AutoSize = true;
            this.checkBox3_CH8.Enabled = false;
            this.checkBox3_CH8.Font = new System.Drawing.Font("新細明體", 16F);
            this.checkBox3_CH8.Location = new System.Drawing.Point(17, 250);
            this.checkBox3_CH8.Name = "checkBox3_CH8";
            this.checkBox3_CH8.Size = new System.Drawing.Size(68, 26);
            this.checkBox3_CH8.TabIndex = 8;
            this.checkBox3_CH8.Text = "CH8";
            this.checkBox3_CH8.UseVisualStyleBackColor = true;
            this.checkBox3_CH8.CheckedChanged += new System.EventHandler(this.checkBox3_CH1_CheckedChanged);
            // 
            // checkBox3_CH4
            // 
            this.checkBox3_CH4.AutoSize = true;
            this.checkBox3_CH4.Enabled = false;
            this.checkBox3_CH4.Font = new System.Drawing.Font("新細明體", 16F);
            this.checkBox3_CH4.Location = new System.Drawing.Point(17, 122);
            this.checkBox3_CH4.Name = "checkBox3_CH4";
            this.checkBox3_CH4.Size = new System.Drawing.Size(68, 26);
            this.checkBox3_CH4.TabIndex = 4;
            this.checkBox3_CH4.Text = "CH4";
            this.checkBox3_CH4.UseVisualStyleBackColor = true;
            this.checkBox3_CH4.CheckedChanged += new System.EventHandler(this.checkBox3_CH1_CheckedChanged);
            // 
            // checkBox3_CH7
            // 
            this.checkBox3_CH7.AutoSize = true;
            this.checkBox3_CH7.Enabled = false;
            this.checkBox3_CH7.Font = new System.Drawing.Font("新細明體", 16F);
            this.checkBox3_CH7.Location = new System.Drawing.Point(17, 218);
            this.checkBox3_CH7.Name = "checkBox3_CH7";
            this.checkBox3_CH7.Size = new System.Drawing.Size(68, 26);
            this.checkBox3_CH7.TabIndex = 7;
            this.checkBox3_CH7.Text = "CH7";
            this.checkBox3_CH7.UseVisualStyleBackColor = true;
            this.checkBox3_CH7.CheckedChanged += new System.EventHandler(this.checkBox3_CH1_CheckedChanged);
            // 
            // checkBox3_CH5
            // 
            this.checkBox3_CH5.AutoSize = true;
            this.checkBox3_CH5.Enabled = false;
            this.checkBox3_CH5.Font = new System.Drawing.Font("新細明體", 16F);
            this.checkBox3_CH5.Location = new System.Drawing.Point(17, 154);
            this.checkBox3_CH5.Name = "checkBox3_CH5";
            this.checkBox3_CH5.Size = new System.Drawing.Size(68, 26);
            this.checkBox3_CH5.TabIndex = 5;
            this.checkBox3_CH5.Text = "CH5";
            this.checkBox3_CH5.UseVisualStyleBackColor = true;
            this.checkBox3_CH5.CheckedChanged += new System.EventHandler(this.checkBox3_CH1_CheckedChanged);
            // 
            // checkBox3_CH6
            // 
            this.checkBox3_CH6.AutoSize = true;
            this.checkBox3_CH6.Enabled = false;
            this.checkBox3_CH6.Font = new System.Drawing.Font("新細明體", 16F);
            this.checkBox3_CH6.Location = new System.Drawing.Point(17, 186);
            this.checkBox3_CH6.Name = "checkBox3_CH6";
            this.checkBox3_CH6.Size = new System.Drawing.Size(68, 26);
            this.checkBox3_CH6.TabIndex = 6;
            this.checkBox3_CH6.Text = "CH6";
            this.checkBox3_CH6.UseVisualStyleBackColor = true;
            this.checkBox3_CH6.CheckedChanged += new System.EventHandler(this.checkBox3_CH1_CheckedChanged);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisX.MajorGrid.LineWidth = 2;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Interval = 0.1D;
            chartArea1.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.Interval = 1D;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.ScaleView.MinSize = 1D;
            chartArea1.AxisX.ScaleView.SmallScrollMinSize = 0.1D;
            chartArea1.AxisX.ScaleView.SmallScrollSize = 0.1D;
            chartArea1.AxisX.Title = "Frequency(Hz)";
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.Title = "Gain";
            chartArea1.CursorX.Interval = 0.01D;
            chartArea1.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            legend1.Title = "Type";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1104, 300);
            this.chart1.TabIndex = 15;
            this.chart1.TabStop = false;
            this.chart1.Text = "GainPlot";
            this.chart1.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.chart1_GetToolTipText);
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.MajorGrid.Interval = 1D;
            chartArea2.AxisX.MajorGrid.LineWidth = 2;
            chartArea2.AxisX.MinorGrid.Enabled = true;
            chartArea2.AxisX.MinorGrid.Interval = 1D;
            chartArea2.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.Title = "Hz";
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.Title = "Phase";
            chartArea2.CursorX.Interval = 0.01D;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Cursor = System.Windows.Forms.Cursors.Default;
            legend2.Name = "Legend1";
            legend2.Title = "Type";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(0, 299);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1104, 300);
            this.chart2.TabIndex = 17;
            this.chart2.TabStop = false;
            this.chart2.Text = "PhasePlot";
            this.chart2.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.chart1_GetToolTipText);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.chart2);
            this.panel2.Location = new System.Drawing.Point(12, 11);
            this.panel2.MinimumSize = new System.Drawing.Size(1104, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 600);
            this.panel2.TabIndex = 18;
            // 
            // FormPlotBode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1239, 661);
            this.Name = "FormPlotBode";
            this.Text = "FormPlotBode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlotBode_FormClosing);
            this.Load += new System.EventHandler(this.FormPlotBode_Load);
            this.Resize += new System.EventHandler(this.FormPlotBode_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox3_CH1;
        private System.Windows.Forms.Button Btn_BodePlot;
        private System.Windows.Forms.CheckBox checkBox3_CH2;
        private System.Windows.Forms.CheckBox checkBox3_CH3;
        private System.Windows.Forms.CheckBox checkBox3_CH8;
        private System.Windows.Forms.CheckBox checkBox3_CH4;
        private System.Windows.Forms.CheckBox checkBox3_CH7;
        private System.Windows.Forms.CheckBox checkBox3_CH5;
        private System.Windows.Forms.CheckBox checkBox3_CH6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel2;
    }
}