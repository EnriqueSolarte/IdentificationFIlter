namespace ServoTool
{
    partial class FormProgram
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_UploadCode = new System.Windows.Forms.Button();
            this.Btn_DownloadCode = new System.Windows.Forms.Button();
            this.TB_PrgNum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_Travers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox_Gtype = new System.Windows.Forms.CheckedListBox();
            this.CB_VertAxis = new System.Windows.Forms.ComboBox();
            this.CB_HorizAxis = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_PrgMode = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TB_Radius = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Repeat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_FeedRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBox_CWCCW = new System.Windows.Forms.CheckedListBox();
            this.checkBox_HRV = new System.Windows.Forms.CheckBox();
            this.TB_NTrigger = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_FileName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Btn_Apply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Btn_DownloadCode);
            this.groupBox1.Controls.Add(this.TB_PrgNum);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Program U/D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Program No. O";
            // 
            // Btn_UploadCode
            // 
            this.Btn_UploadCode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_UploadCode.Location = new System.Drawing.Point(22, 308);
            this.Btn_UploadCode.Name = "Btn_UploadCode";
            this.Btn_UploadCode.Size = new System.Drawing.Size(222, 35);
            this.Btn_UploadCode.TabIndex = 5;
            this.Btn_UploadCode.Text = "Upload Code to NC";
            this.Btn_UploadCode.UseVisualStyleBackColor = true;
            this.Btn_UploadCode.Click += new System.EventHandler(this.Btn_UploadCode_Click);
            // 
            // Btn_DownloadCode
            // 
            this.Btn_DownloadCode.Location = new System.Drawing.Point(10, 57);
            this.Btn_DownloadCode.Name = "Btn_DownloadCode";
            this.Btn_DownloadCode.Size = new System.Drawing.Size(222, 35);
            this.Btn_DownloadCode.TabIndex = 6;
            this.Btn_DownloadCode.Text = "Download Code to PC";
            this.Btn_DownloadCode.UseVisualStyleBackColor = true;
            this.Btn_DownloadCode.Click += new System.EventHandler(this.Btn_DownloadCode_Click);
            // 
            // TB_PrgNum
            // 
            this.TB_PrgNum.Location = new System.Drawing.Point(136, 22);
            this.TB_PrgNum.Name = "TB_PrgNum";
            this.TB_PrgNum.Size = new System.Drawing.Size(96, 29);
            this.TB_PrgNum.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Apply);
            this.groupBox2.Controls.Add(this.TB_FileName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TB_NTrigger);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.checkBox_HRV);
            this.groupBox2.Controls.Add(this.checkedListBox_CWCCW);
            this.groupBox2.Controls.Add(this.TB_Repeat);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TB_FeedRate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TB_Radius);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TB_Travers);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.checkedListBox_Gtype);
            this.groupBox2.Controls.Add(this.CB_VertAxis);
            this.groupBox2.Controls.Add(this.CB_HorizAxis);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CB_PrgMode);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(265, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 332);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // TB_Travers
            // 
            this.TB_Travers.Location = new System.Drawing.Point(66, 126);
            this.TB_Travers.Name = "TB_Travers";
            this.TB_Travers.Size = new System.Drawing.Size(73, 29);
            this.TB_Travers.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(14, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "Traverse Length";
            // 
            // checkedListBox_Gtype
            // 
            this.checkedListBox_Gtype.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.checkedListBox_Gtype.CheckOnClick = true;
            this.checkedListBox_Gtype.ColumnWidth = 135;
            this.checkedListBox_Gtype.FormattingEnabled = true;
            this.checkedListBox_Gtype.Items.AddRange(new object[] {
            "Cutting feed",
            "Rapid-traverse"});
            this.checkedListBox_Gtype.Location = new System.Drawing.Point(6, 92);
            this.checkedListBox_Gtype.MultiColumn = true;
            this.checkedListBox_Gtype.Name = "checkedListBox_Gtype";
            this.checkedListBox_Gtype.Size = new System.Drawing.Size(284, 28);
            this.checkedListBox_Gtype.TabIndex = 7;
            this.checkedListBox_Gtype.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_Gtype_ItemCheck);
            // 
            // CB_VertAxis
            // 
            this.CB_VertAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_VertAxis.FormattingEnabled = true;
            this.CB_VertAxis.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.CB_VertAxis.Location = new System.Drawing.Point(240, 57);
            this.CB_VertAxis.Name = "CB_VertAxis";
            this.CB_VertAxis.Size = new System.Drawing.Size(50, 29);
            this.CB_VertAxis.TabIndex = 5;
            // 
            // CB_HorizAxis
            // 
            this.CB_HorizAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_HorizAxis.FormattingEnabled = true;
            this.CB_HorizAxis.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.CB_HorizAxis.Location = new System.Drawing.Point(98, 57);
            this.CB_HorizAxis.Name = "CB_HorizAxis";
            this.CB_HorizAxis.Size = new System.Drawing.Size(50, 29);
            this.CB_HorizAxis.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vert. -axis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horiz. -axis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Program Mode";
            // 
            // CB_PrgMode
            // 
            this.CB_PrgMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_PrgMode.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.CB_PrgMode.FormattingEnabled = true;
            this.CB_PrgMode.Items.AddRange(new object[] {
            "Free program",
            "Straight movement",
            "Square",
            "Circle",
            "Diamond",
            "Square with 1/4Arc"});
            this.CB_PrgMode.Location = new System.Drawing.Point(137, 22);
            this.CB_PrgMode.Name = "CB_PrgMode";
            this.CB_PrgMode.Size = new System.Drawing.Size(153, 27);
            this.CB_PrgMode.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(12, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 187);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Program";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(225, 160);
            this.textBox1.TabIndex = 0;
            // 
            // TB_Radius
            // 
            this.TB_Radius.Location = new System.Drawing.Point(213, 126);
            this.TB_Radius.Name = "TB_Radius";
            this.TB_Radius.Size = new System.Drawing.Size(73, 29);
            this.TB_Radius.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Radius";
            // 
            // TB_Repeat
            // 
            this.TB_Repeat.Location = new System.Drawing.Point(213, 161);
            this.TB_Repeat.Name = "TB_Repeat";
            this.TB_Repeat.Size = new System.Drawing.Size(73, 29);
            this.TB_Repeat.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Repeat";
            // 
            // TB_FeedRate
            // 
            this.TB_FeedRate.Location = new System.Drawing.Point(66, 161);
            this.TB_FeedRate.Name = "TB_FeedRate";
            this.TB_FeedRate.Size = new System.Drawing.Size(73, 29);
            this.TB_FeedRate.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(9, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "FeedRate";
            // 
            // checkedListBox_CWCCW
            // 
            this.checkedListBox_CWCCW.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.checkedListBox_CWCCW.CheckOnClick = true;
            this.checkedListBox_CWCCW.FormattingEnabled = true;
            this.checkedListBox_CWCCW.Items.AddRange(new object[] {
            "CW",
            "CCW"});
            this.checkedListBox_CWCCW.Location = new System.Drawing.Point(27, 196);
            this.checkedListBox_CWCCW.MultiColumn = true;
            this.checkedListBox_CWCCW.Name = "checkedListBox_CWCCW";
            this.checkedListBox_CWCCW.Size = new System.Drawing.Size(245, 28);
            this.checkedListBox_CWCCW.TabIndex = 16;
            // 
            // checkBox_HRV
            // 
            this.checkBox_HRV.AutoSize = true;
            this.checkBox_HRV.Location = new System.Drawing.Point(27, 230);
            this.checkBox_HRV.Name = "checkBox_HRV";
            this.checkBox_HRV.Size = new System.Drawing.Size(249, 25);
            this.checkBox_HRV.TabIndex = 17;
            this.checkBox_HRV.Text = "High Precision Control Mode";
            this.checkBox_HRV.UseVisualStyleBackColor = true;
            // 
            // TB_NTrigger
            // 
            this.TB_NTrigger.Location = new System.Drawing.Point(120, 261);
            this.TB_NTrigger.Name = "TB_NTrigger";
            this.TB_NTrigger.Size = new System.Drawing.Size(73, 29);
            this.TB_NTrigger.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "N for Trigger";
            // 
            // TB_FileName
            // 
            this.TB_FileName.Location = new System.Drawing.Point(99, 296);
            this.TB_FileName.Name = "TB_FileName";
            this.TB_FileName.Size = new System.Drawing.Size(104, 29);
            this.TB_FileName.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "File Name";
            // 
            // Btn_Apply
            // 
            this.Btn_Apply.Location = new System.Drawing.Point(209, 296);
            this.Btn_Apply.Name = "Btn_Apply";
            this.Btn_Apply.Size = new System.Drawing.Size(77, 29);
            this.Btn_Apply.TabIndex = 22;
            this.Btn_Apply.Text = "Apply";
            this.Btn_Apply.UseVisualStyleBackColor = true;
            // 
            // FormProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 356);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_UploadCode);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProgram";
            this.Text = "FormProgram";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_UploadCode;
        private System.Windows.Forms.Button Btn_DownloadCode;
        private System.Windows.Forms.TextBox TB_PrgNum;
        private System.Windows.Forms.ComboBox CB_PrgMode;
        private System.Windows.Forms.ComboBox CB_VertAxis;
        private System.Windows.Forms.ComboBox CB_HorizAxis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Travers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox_Gtype;
        private System.Windows.Forms.Button Btn_Apply;
        private System.Windows.Forms.TextBox TB_FileName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_NTrigger;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_HRV;
        private System.Windows.Forms.CheckedListBox checkedListBox_CWCCW;
        private System.Windows.Forms.TextBox TB_Repeat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_FeedRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Radius;
        private System.Windows.Forms.Label label5;
    }
}