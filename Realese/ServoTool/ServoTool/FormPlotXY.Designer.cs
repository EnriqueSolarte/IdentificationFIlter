namespace ServoTool
{
    partial class FormPlotXY
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CB2_AxisX = new System.Windows.Forms.ComboBox();
            this.CB2_AxisY = new System.Windows.Forms.ComboBox();
            this.Btn2_Plot = new System.Windows.Forms.Button();
            this.label2_AxisX = new System.Windows.Forms.Label();
            this.label2_AxisY = new System.Windows.Forms.Label();
            this.Btn2_Load = new System.Windows.Forms.Button();
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
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(13, 61);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(661, 661);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // CB2_AxisX
            // 
            this.CB2_AxisX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB2_AxisX.FormattingEnabled = true;
            this.CB2_AxisX.Location = new System.Drawing.Point(249, 6);
            this.CB2_AxisX.Name = "CB2_AxisX";
            this.CB2_AxisX.Size = new System.Drawing.Size(121, 20);
            this.CB2_AxisX.TabIndex = 1;
            // 
            // CB2_AxisY
            // 
            this.CB2_AxisY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB2_AxisY.FormattingEnabled = true;
            this.CB2_AxisY.Location = new System.Drawing.Point(249, 30);
            this.CB2_AxisY.Name = "CB2_AxisY";
            this.CB2_AxisY.Size = new System.Drawing.Size(121, 20);
            this.CB2_AxisY.TabIndex = 2;
            // 
            // Btn2_Plot
            // 
            this.Btn2_Plot.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2_Plot.Location = new System.Drawing.Point(42, 6);
            this.Btn2_Plot.Name = "Btn2_Plot";
            this.Btn2_Plot.Size = new System.Drawing.Size(111, 44);
            this.Btn2_Plot.TabIndex = 3;
            this.Btn2_Plot.Text = "Plot";
            this.Btn2_Plot.UseVisualStyleBackColor = true;
            this.Btn2_Plot.Click += new System.EventHandler(this.Btn2_Plot_Click);
            // 
            // label2_AxisX
            // 
            this.label2_AxisX.AutoSize = true;
            this.label2_AxisX.Font = new System.Drawing.Font("新細明體", 14F);
            this.label2_AxisX.Location = new System.Drawing.Point(173, 7);
            this.label2_AxisX.Name = "label2_AxisX";
            this.label2_AxisX.Size = new System.Drawing.Size(72, 19);
            this.label2_AxisX.TabIndex = 4;
            this.label2_AxisX.Text = "X-Axis :";
            // 
            // label2_AxisY
            // 
            this.label2_AxisY.AutoSize = true;
            this.label2_AxisY.Font = new System.Drawing.Font("新細明體", 14F);
            this.label2_AxisY.Location = new System.Drawing.Point(174, 30);
            this.label2_AxisY.Name = "label2_AxisY";
            this.label2_AxisY.Size = new System.Drawing.Size(72, 19);
            this.label2_AxisY.TabIndex = 5;
            this.label2_AxisY.Tag = " ";
            this.label2_AxisY.Text = "Y-Axis :";
            // 
            // Btn2_Load
            // 
            this.Btn2_Load.Font = new System.Drawing.Font("新細明體", 14F);
            this.Btn2_Load.Location = new System.Drawing.Point(513, 7);
            this.Btn2_Load.Name = "Btn2_Load";
            this.Btn2_Load.Size = new System.Drawing.Size(111, 44);
            this.Btn2_Load.TabIndex = 7;
            this.Btn2_Load.Text = "Load File";
            this.Btn2_Load.UseVisualStyleBackColor = true;
            this.Btn2_Load.Click += new System.EventHandler(this.Btn2_Load_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Btn2_Plot);
            this.panel1.Controls.Add(this.Btn2_Load);
            this.panel1.Controls.Add(this.CB2_AxisX);
            this.panel1.Controls.Add(this.label2_AxisY);
            this.panel1.Controls.Add(this.CB2_AxisY);
            this.panel1.Controls.Add(this.label2_AxisX);
            this.panel1.Location = new System.Drawing.Point(13, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 53);
            this.panel1.TabIndex = 8;
            // 
            // FormPlotXY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 735);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.MinimumSize = new System.Drawing.Size(704, 773);
            this.Name = "FormPlotXY";
            this.Text = "PlotXY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlotXY_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox CB2_AxisX;
        private System.Windows.Forms.ComboBox CB2_AxisY;
        private System.Windows.Forms.Button Btn2_Plot;
        private System.Windows.Forms.Label label2_AxisX;
        private System.Windows.Forms.Label label2_AxisY;
        private System.Windows.Forms.Button Btn2_Load;
        private System.Windows.Forms.Panel panel1;
    }
}