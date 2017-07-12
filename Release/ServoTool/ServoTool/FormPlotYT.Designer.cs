namespace ServoTool
{
    partial class FormPlotYT
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox3_CH1 = new System.Windows.Forms.CheckBox();
            this.checkBox3_CH2 = new System.Windows.Forms.CheckBox();
            this.checkBox3_CH3 = new System.Windows.Forms.CheckBox();
            this.checkBox3_CH4 = new System.Windows.Forms.CheckBox();
            this.checkBox3_CH5 = new System.Windows.Forms.CheckBox();
            this.checkBox3_CH6 = new System.Windows.Forms.CheckBox();
            this.checkBox3_CH7 = new System.Windows.Forms.CheckBox();
            this.checkBox3_CH8 = new System.Windows.Forms.CheckBox();
            this.Btn3_Load = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.ScaleView.SmallScrollMinSize = 0.05D;
            chartArea1.AxisX.Title = "Time(ms)";
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.ScaleView.SmallScrollMinSize = 0.0001D;
            chartArea1.AxisY.Title = "Data";
            chartArea1.CursorX.Interval = 1E-05D;
            chartArea1.CursorY.Interval = 0.001D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            legend1.Title = "Type";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1104, 599);
            this.chart1.TabIndex = 11;
            this.chart1.TabStop = false;
            this.chart1.Text = "PlotYT";
            this.chart1.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.chart1_GetToolTipText);
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
            // Btn3_Load
            // 
            this.Btn3_Load.Font = new System.Drawing.Font("新細明體", 12F);
            this.Btn3_Load.Location = new System.Drawing.Point(3, 376);
            this.Btn3_Load.Name = "Btn3_Load";
            this.Btn3_Load.Size = new System.Drawing.Size(87, 42);
            this.Btn3_Load.TabIndex = 9;
            this.Btn3_Load.Text = "Load File";
            this.Btn3_Load.UseVisualStyleBackColor = true;
            this.Btn3_Load.Click += new System.EventHandler(this.Btn3_Load_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn3_Load);
            this.panel1.Controls.Add(this.checkBox3_CH1);
            this.panel1.Controls.Add(this.checkBox3_CH2);
            this.panel1.Controls.Add(this.checkBox3_CH3);
            this.panel1.Controls.Add(this.checkBox3_CH8);
            this.panel1.Controls.Add(this.checkBox3_CH4);
            this.panel1.Controls.Add(this.checkBox3_CH7);
            this.panel1.Controls.Add(this.checkBox3_CH5);
            this.panel1.Controls.Add(this.checkBox3_CH6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1129, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 623);
            this.panel1.TabIndex = 14;
            // 
            // FormPlotYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1223, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.MinimumSize = new System.Drawing.Size(1239, 661);
            this.Name = "FormPlotYT";
            this.Text = "PlotYT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlotYT_FormClosing);
            this.Load += new System.EventHandler(this.FormPlotYT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox checkBox3_CH1;
        private System.Windows.Forms.CheckBox checkBox3_CH2;
        private System.Windows.Forms.CheckBox checkBox3_CH3;
        private System.Windows.Forms.CheckBox checkBox3_CH4;
        private System.Windows.Forms.CheckBox checkBox3_CH5;
        private System.Windows.Forms.CheckBox checkBox3_CH6;
        private System.Windows.Forms.CheckBox checkBox3_CH7;
        private System.Windows.Forms.CheckBox checkBox3_CH8;
        private System.Windows.Forms.Button Btn3_Load;
        private System.Windows.Forms.Panel panel1;
    }
}