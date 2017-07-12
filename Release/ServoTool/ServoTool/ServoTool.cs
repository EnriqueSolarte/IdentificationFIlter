using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CollectSmplData;
using MTS;

namespace ServoTool
{
    public partial class ServoTool : Form
    {
        itri2fanucWrapper Itri2Fanuc = new itri2fanucWrapper();
        MTS_func mts;
        //public List<List<float>> DataList = new List<List<float>>();
        public Label[] LblAxisArry;
        public Label[] LblTypeArry;
        public Label[] LblUnitArry;
        public Button[] Btns;
        public short NumOfChanl = 0;
        public string[] SmplType = new string[8], SmplUnit = new string[8], SmplAxis = new string[8];
        public sbyte[] SmplAxisArray = new sbyte[8];
        public short[] SmplTypeArray = new short[8];
        short AxisCount = 0;
        List<string> StrAxisList = new List<string>();
        string[] ServoType = new string[7] { "POSF", "ERR", "VCMD", "TCMD", "SPEED", "FREQ", "FRTCM" };
        string[] SpindleType = new string[5] { "SPEED", "TCMD", "VCMD", "LTR", "EPMTR" };
        string[] ServoUnit = new string[7] { "mm", "mm", "mm/min", "%", "mm/min", "hz", "%" };
        string[] SpindleUnit = new string[5] { "mm/min", "%", "mm/min", "%", "kw" };
        // List<int> MarkTime = new List<int>(), SeqTime = new List<int>();
        // List<long> MarkSeq = new List<long>();
        // long LastSeq = 0;

        private StreamWriter Smplsw;
        private int DataIndex;
        private decimal SmplPeriod = 1;
        private short SmplShift = 0;
        public ServoTool()
        {
            InitializeComponent();
            mts = new MTS_func();
            LblAxisArry = new Label[8] { label_Axis1, label_Axis2, label_Axis3, label_Axis4, label_Axis5, label_Axis6, label_Axis7, label_Axis8 };
            LblTypeArry = new Label[8] { label_Type1, label_Type2, label_Type3, label_Type4, label_Type5, label_Type6, label_Type7, label_Type8 };
            LblUnitArry = new Label[8] { label_Unit1, label_Unit2, label_Unit3, label_Unit4, label_Unit5, label_Unit6, label_Unit7, label_Unit8 };
            Btns = new Button[10] { Btn_Set, Btn_Delete, Btn_Start, Btn_End, Btn_RdPrm, Btn_WrPrm, Btn_DownloadCode, Btn_UploadCode, Btn_FrqResStart, Btn_FrqResEnd };
            Inertial();
            //TB_IP.Text = "140.96.24.133";
            //TB_IP.Text = "192.168.220.1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CB_Axis.SelectedIndex = 0;
            CB_Type.SelectedIndex = 0;
            CB_Unit.SelectedIndex = 0;
            CB_FrqAxis.SelectedIndex = 0;
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (Btn_Connect.Text == "Connect")
            {
                string ip = TB_IP.Text;
                ushort port = ushort.Parse(TB_Port.Text);
                int timeout = 2;
                string ret = Itri2Fanuc.Connect(ip, port, timeout);
                if (ret == "EW_OK")
                {
                    TB_ConStatus.Text = "Connect";
                    Btn_Connect.Text = "DisConnect";
                    TB_ConStatus.BackColor = Color.Green;
                    Btn_Set.Enabled = true;
                    Btn_Delete.Enabled = true;
                    Btn_Start.Enabled = true;
                    Btn_RdPrm.Enabled = true;
                    Btn_WrPrm.Enabled = true;
                    Btn_UploadCode.Enabled = true;
                    Btn_DownloadCode.Enabled = true;
                    Btn_FrqResStart.Enabled = true;
                    TB_IP.Enabled = false;
                    TB_Port.Enabled = false;
                    mts.GetHndl(Itri2Fanuc);
                }
                else
                {
                    MessageBox.Show("Connect failed:" + ret, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (Btn_Connect.Text == "DisConnect")
            {
                Itri2Fanuc.SamplingCancel();
                Itri2Fanuc.SamplingEnd();
                string ret = Itri2Fanuc.DisConnect();
                if (ret == "EW_OK")
                {
                    Inertial();
                }
            }
        }

        private void Btn_Set_Click(object sender, EventArgs e)
        {
            sbyte Axis = (sbyte)(CB_Axis.SelectedIndex + 1);
            short Type = 0;
            if (CB_Axis.SelectedIndex == 3)
            {
                switch (CB_Type.SelectedIndex)
                {
                    case 0:
                        Type = 1;
                        break;
                    case 1:
                        Type = 2;
                        break;
                    case 2:
                        Type = 3;
                        break;
                    case 3:
                        Type = 6;
                        break;
                    case 4:
                        Type = 9;
                        break;
                }
            }
            else
            {
                switch (CB_Type.SelectedIndex)
                {
                    case 0:
                        Type = 0;
                        break;
                    case 1:
                        Type = 1;
                        break;
                    case 2:
                        Type = 2;
                        break;
                    case 3:
                        Type = 3;
                        break;
                    case 4:
                        Type = 4;
                        break;
                    case 5:
                        Type = 31;
                        break;
                    case 6:
                        Type = 32;
                        break;
                }
            }
            if ((Axis == 1 || Axis == 2) && AxisCount >= 4)
            {
                MessageBox.Show("Max(X+Y)=4", "超出上限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //string SetBool = Itri2Fanuc.SetChannelData(Axis, Type);
                //if (SetBool.Equals("EW_OK"))
                //{
                if ((Axis == 1 || Axis == 2)) AxisCount++;
                if (CB_Axis.SelectedIndex == 3)
                    Axis = -1;
                SmplAxisArray[NumOfChanl] = Axis;
                SmplTypeArray[NumOfChanl] = Type;
                SmplAxis[NumOfChanl] = CB_Axis.SelectedItem.ToString();
                SmplType[NumOfChanl] = CB_Type.SelectedItem.ToString();
                SmplUnit[NumOfChanl] = CB_Unit.SelectedItem.ToString();

                StrAxisList.Add("CH" + (NumOfChanl + 1) + " [" + SmplAxis[NumOfChanl] + "-" + SmplType[NumOfChanl] + "(" + SmplUnit[NumOfChanl] + ")" + "]");
                LblAxisArry[NumOfChanl].Text = CB_Axis.SelectedItem.ToString();
                LblTypeArry[NumOfChanl].Text = CB_Type.SelectedItem.ToString();
                LblUnitArry[NumOfChanl].Text = CB_Unit.SelectedItem.ToString();
                LblAxisArry[NumOfChanl].Visible = true;
                LblTypeArry[NumOfChanl].Visible = true;
                LblUnitArry[NumOfChanl].Visible = true;
                NumOfChanl++;
                //}
                //else
                //  MessageBox.Show(SetBool, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            //string DelBool = Itri2Fanuc.DelChannelData();
            //if (DelBool.Equals("EW_OK"))
            //{
            NumOfChanl--;
            if ((SmplAxis[NumOfChanl] == "X" || SmplAxis[NumOfChanl] == "Y")) AxisCount--;
            SmplType[NumOfChanl] = null;
            SmplAxis[NumOfChanl] = null;
            SmplAxisArray[NumOfChanl] = 0;
            SmplTypeArray[NumOfChanl] = 0;
            StrAxisList.RemoveAt(NumOfChanl);
            LblAxisArry[NumOfChanl].Visible = false;
            LblTypeArry[NumOfChanl].Visible = false;
            LblUnitArry[NumOfChanl].Visible = false;
            //}
            //else
            //    MessageBox.Show(DelBool, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CB_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Unit.SelectedIndex = CB_Type.SelectedIndex;
        }

        private void checkBox_DataNum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_DataNum.Checked)
            {
                NumUpDown_DataNum.Enabled = false;
            }
            else
            {
                NumUpDown_DataNum.Enabled = true;
            }
        }

        private void checkBox_Trigger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Trigger.Checked)
            {
                TB_Trigger.Enabled = false;
            }
            else
            {
                TB_Trigger.Enabled = true;
            }
        }

        private void checkBox_SmplRate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SmplRate.Checked)
            {
                NumUpDown_Sampling.Enabled = false;
            }
            else
            {
                NumUpDown_Sampling.Enabled = true;
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            SaveFileDialog path = new SaveFileDialog();
            path.FileName = "SmplData" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            path.Filter = "取樣資料|*.smpl";
            if (path.ShowDialog() == System.Windows.Forms.DialogResult.OK && path.FileName != "")
            {
                int DataNum, TriggerNum;
                if (checkBox_DataNum.Checked)
                {
                    DataNum = -1;
                }
                else
                {
                    DataNum = (int)NumUpDown_DataNum.Value;
                }
                if (checkBox_Trigger.Checked)
                {
                    TriggerNum = 0;
                }
                else
                {
                    TriggerNum = int.Parse(TB_Trigger.Text);
                }
                if (checkBox_SmplRate.Checked)
                {
                    SmplShift = 512;
                    SmplPeriod = 0.25M;
                }
                else
                {
                    SmplShift = 0;
                    SmplPeriod = NumUpDown_Sampling.Value;

                }
                sbyte[] AxisTemp = new sbyte[NumOfChanl];
                short[] TypeTemp = new short[NumOfChanl];
                for (int i = 0; i < NumOfChanl; i++)
                {
                    AxisTemp[i] = SmplAxisArray[i];
                    TypeTemp[i] = SmplTypeArray[i];
                }
                string ret = Itri2Fanuc.SamplingStart(NumOfChanl, AxisTemp, TypeTemp, SmplShift, DataNum, TriggerNum);
                if (ret.Equals("EW_OK"))
                {
                    Smplsw = new StreamWriter(path.FileName);
                    /*DataList.RemoveAll(it => true);
                    for (int i = 0; i < NumOfChanl; i++)
                    {
                        DataList.Add(new List<float>());
                    }*/
                    DataIndex = 0;
                    Btn_End.Enabled = true;
                    Btn_Start.Enabled = false;
                    timer1.Enabled = true;
                    //timer2.Enabled = true;
                }
                else
                {
                    MessageBox.Show(ret, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string SmplStat = "3";
            try
            {
                SmplStat = Itri2Fanuc.SamplingRead();
            }
            catch
            {
                Itri2Fanuc.SamplingCancel();
                Itri2Fanuc.SamplingEnd();
                MessageBox.Show("Memory Error(Please reboot CNC)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Enabled = false;
            }

            if (SmplStat.Equals("1") || SmplStat.Equals("0"))
            {
                //DateTime CurTime = new DateTime();
                //CurTime = DateTime.Now;
                //MarkTime.Add((CurTime.Hour * 10000000) + (CurTime.Minute * 100000) + (CurTime.Second * 1000) + (CurTime.Millisecond));

                TB_ConStatus.Text = "Sampling...";
                if (DataIndex == 0)
                {
                    Smplsw.Write("SamplingRate:" + SmplPeriod + "ms\r\n\r\n");
                    for (int i = 0; i < NumOfChanl; i++)
                    {
                        if (i == 0)
                            Smplsw.Write(SmplAxis[i] + "-" + SmplType[i]);
                        else
                            Smplsw.Write("," + SmplAxis[i] + "-" + SmplType[i]);
                    }
                    Smplsw.Write("\r\n");
                    for (int i = 0; i < NumOfChanl; i++)
                    {
                        if (i == 0)
                            Smplsw.Write(SmplUnit[i]);
                        else
                            Smplsw.Write("," + SmplUnit[i]);
                    }
                    Smplsw.Write("\r\n");
                }

                for (int i = 0; i < Itri2Fanuc.DataLength; i++)
                {
                    if (DataIndex % Math.Ceiling(SmplPeriod) == 0)
                    {
                        for (int j = 0; j < NumOfChanl; j++)
                        {
                            if (j == 0)
                                Smplsw.Write(Itri2Fanuc.CollectData[j, i]);
                            else
                                Smplsw.Write("," + Itri2Fanuc.CollectData[j, i]);
                        }
                        Smplsw.Write("\r\n");
                    }
                    DataIndex++;
                }
                if (SmplStat.Equals("0"))
                {
                    string ret = Itri2Fanuc.SamplingEnd();
                    if (ret.Equals("EW_OK"))
                    {
                        TB_ConStatus.Text = "Sampling end";
                        Smplsw.Close();
                        Smplsw.Dispose();
                        Btn_Start.Enabled = true;
                        Btn_End.Enabled = false;
                        timer1.Enabled = false;
                        //timer2.Enabled = false;
                    }
                }
            }
            else if (SmplStat.Equals("-1"))
            {
                TB_ConStatus.Text = "Waiting for trigger...";
            }
        }

        private void Btn_End_Click(object sender, EventArgs e)
        {
            string ret = Itri2Fanuc.SamplingCancel();
            ret = Itri2Fanuc.SamplingEnd();
            if (ret.Equals("EW_OK"))
            {
                Smplsw.Close();
                Smplsw.Dispose();
                timer1.Enabled = false;
                //timer2.Enabled = false;
                TB_ConStatus.Text = "Sampling end";
                Btn_Start.Enabled = true;
                Btn_End.Enabled = false;
            }
        }

        private void Btn_RdPrm_Click(object sender, EventArgs e)
        {
            int PrmNo = int.Parse(TB_PrmNumR.Text);
            double[] PrmVals = new double[3];
            String ret = Itri2Fanuc.ReadParameterVal(PrmNo);
            TB_RdPrmVal.Text = ret;
        }
        private void Btn_WrPrm_Click(object sender, EventArgs e)
        {
            short PrmAxis = short.Parse(TB_PrmAxisW.Text);
            int PrmNo = int.Parse(TB_PrmNumW.Text);
            int PrmVal = int.Parse(TB_PrmValW.Text);
            String WPrmStatus = Itri2Fanuc.WriteParameterVal(PrmAxis, PrmNo, PrmVal);
            if (WPrmStatus.Equals("EW_OK"))
            {
                double[] PrmVals = new double[3];
                String ret = Itri2Fanuc.ReadParameterVal(PrmNo);
                TB_WrPrmVal.Text = ret;
            }
            else
                MessageBox.Show(WPrmStatus, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Btn_UploadCode_Click(object sender, EventArgs e)
        {
            OpenFileDialog path = new OpenFileDialog();
            path.Filter = "G程式碼|*.Gcode";
            if (path.ShowDialog() == System.Windows.Forms.DialogResult.OK && path.FileName != "")
            {
                string UploadStatus = Itri2Fanuc.UploadNCCode(path.FileName);
                if (UploadStatus.Equals("EW_OK"))
                    TB_ConStatus.Text = "Upload completed";
                else
                    MessageBox.Show(UploadStatus, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TB_ConStatus.Text = "Upload Failed(Path Error)";
            }
        }

        private void Btn_DownloadCode_Click(object sender, EventArgs e)
        {
            if (TB_PrgNum.Text.Length > 0)
            {
                FolderBrowserDialog path = new FolderBrowserDialog();
                if (path.ShowDialog() == System.Windows.Forms.DialogResult.OK && path.SelectedPath != "")
                {
                    string FilePath = path.SelectedPath + "\\O" + TB_PrgNum.Text + "_Download.Gcode";
                    string DownloadStatus = Itri2Fanuc.DownloadNCCode(FilePath, int.Parse(TB_PrgNum.Text));
                    if (DownloadStatus.Equals("EW_OK"))
                        TB_ConStatus.Text = "Download completed";
                    else
                        MessageBox.Show(DownloadStatus, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Download Failed (Path Error)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Download Failed (Please Enter Program Number)", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void TB_PrgNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Btn_FrqResStart_Click(object sender, EventArgs e)
        {
            if (NumUpDown_FrqStart.Value > NumUpDown_FrqEnd.Value)
            {
                MessageBox.Show("FrqStart > FrqEnd", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog path = new SaveFileDialog();
            path.FileName = "FrqRes" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            path.Filter = "CSV(逗號分隔)|*.csv";
            if (path.ShowDialog() == System.Windows.Forms.DialogResult.OK && path.FileName != "")
            {
                Smplsw = new StreamWriter(path.FileName);
                string ret = mts.FrqResponseStart((short)(CB_FrqAxis.SelectedIndex + 1), (int)(NumUpDown_FrqStart.Value),
                       (int)(NumUpDown_FrqEnd.Value), (int)NumUpDown_InputAmp.Value, (int)(NumUpDown_WaveNum.Value), int.Parse(TB_PosGain.Text));
                if (ret.Equals("Start input disturbance"))
                {                    
                    Btn_FrqResEnd.Enabled = true;
                    Btn_FrqResStart.Enabled = false;
                    DataIndex = 0;
                    Btn_FrqResEnd.Enabled = true;
                    Btn_FrqResStart.Enabled = false;
                    timer2.Enabled = true;
                }
                TB_ConStatus.Text = ret;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            /*long CurSeq = Itri2Fanuc.GetSeq(CncHndl);
            if (CurSeq != LastSeq)
            {
                DateTime CurTime = new DateTime();
                CurTime = DateTime.Now;
                SeqTime.Add((CurTime.Hour * 10000000) + (CurTime.Minute * 100000) + (CurTime.Second * 1000) + (CurTime.Millisecond));
                MarkSeq.Add(CurSeq);
                LastSeq = CurSeq;
            }*/
            string SmplStat = "3";
            try
            {
                //SmplStat = Itri2Fanuc.FrqRpnsRead(CncHndl, 1);
                SmplStat = Itri2Fanuc.SamplingRead();
            }
            catch
            {
                Itri2Fanuc.SamplingCancel();
                Itri2Fanuc.SamplingEnd();
                MessageBox.Show("Memory Error(Please reboot CNC)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer2.Enabled = false;
            }
            if (SmplStat.Equals("1") || SmplStat.Equals("0"))
            {
                if (DataIndex == 0)
                {
                    string FrqAxis = CB_FrqAxis.SelectedItem.ToString();
                    Smplsw.Write("SamplingRate:" + 0.25 + "ms\r\n\r\n" + FrqAxis + "-TCMD," + FrqAxis + "-FRTCM," + FrqAxis + "-FREQ\r\n%,%,Hz\r\n");
                }

                for (int i = 0; i < Itri2Fanuc.DataLength; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (j == 0)
                            Smplsw.Write(Itri2Fanuc.CollectData[j, i]);
                        else
                            Smplsw.Write("," + Itri2Fanuc.CollectData[j, i]);
                    }
                    Smplsw.Write("\r\n");
                    DataIndex++;
                }
                if (SmplStat.Equals("0"))
                {
                    Itri2Fanuc.SamplingEnd();
                    string ret = mts.FrqResponseEnd((short)(CB_FrqAxis.SelectedIndex + 1));
                    if (ret.Equals("Stop input disturbance"))
                    {
                        Btn_FrqResStart.Enabled = true;
                        Btn_FrqResEnd.Enabled = false;
                    }
                    TB_ConStatus.Text = ret;
                    Smplsw.Close();
                    Smplsw.Dispose();
                    timer2.Enabled = false;
                }
            }
            else
                TB_ConStatus.Text = SmplStat;
        }

        private void Btn_FrqResEnd_Click(object sender, EventArgs e)
        {
            Itri2Fanuc.SamplingCancel();
            Itri2Fanuc.SamplingEnd();
            string ret = mts.FrqResponseEnd((short)(CB_FrqAxis.SelectedIndex + 1));
            if (ret.Equals("Stop input disturbance"))
            {
                Btn_FrqResStart.Enabled = true;
                Btn_FrqResEnd.Enabled = false;
            }
            TB_ConStatus.Text = ret;
            Smplsw.Close();
            Smplsw.Dispose();
            timer2.Enabled = false;
        }

        private void Btn_PlotBode_Click(object sender, EventArgs e)
        {
            FormPlotBode form = new FormPlotBode();
            form.Show();
            if (!TB_ConStatus.Text.Equals("Disconnect"))
                TB_ConStatus.Text = "Connect";
        }

        private void Btn_PlotXY_Click(object sender, EventArgs e)
        {
            FormPlotXY form = new FormPlotXY();
            form.Show();
            if (!TB_ConStatus.Text.Equals("Disconnect"))
                TB_ConStatus.Text = "Connect";
        }

        private void Btn_Program_Click(object sender, EventArgs e)
        {
            FormProgram form = new FormProgram(Itri2Fanuc);
            form.Show();
        }

        private void Btn_MTS_Click(object sender, EventArgs e)
        {

        }

        private void CB_Axis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Axis.SelectedIndex == 3)
            {
                CB_Type.Items.Clear();
                CB_Type.Items.AddRange(SpindleType);
                CB_Type.SelectedIndex = 0;
                CB_Unit.Items.Clear();
                CB_Unit.Items.AddRange(SpindleUnit);
                CB_Unit.SelectedIndex = 0;
            }
            else
            {
                CB_Type.Items.Clear();
                CB_Type.Items.AddRange(ServoType);
                CB_Type.SelectedIndex = 0;
                CB_Unit.Items.Clear();
                CB_Unit.Items.AddRange(ServoUnit);
                CB_Unit.SelectedIndex = 0;
            }
        }

        private void Btn_PlotYT_Click(object sender, EventArgs e)
        {
            FormPlotYT form = new FormPlotYT();
            form.Show();
            if (!TB_ConStatus.Text.Equals("Disconnect"))
                TB_ConStatus.Text = "Connect";
        }
        private void Inertial()
        {
            for (int i = 0; i < NumOfChanl; i++)
            {
                SmplType[i] = null;
                SmplAxis[i] = null;
                LblAxisArry[i].Visible = false;
                LblTypeArry[i].Visible = false;
                LblUnitArry[i].Visible = false;
            }
            StrAxisList.Clear();
            AxisCount = 0;
            NumOfChanl = 0;

            TB_ConStatus.Text = "Disconnect";
            Btn_Connect.Text = "Connect";
            TB_ConStatus.BackColor = Color.Red;
            for (int i = 0; i < Btns.Length; i++)
            {
                Btns[i].Enabled = false;
            }
            TB_IP.Enabled = true;
            TB_Port.Enabled = true;
            CB_Type.Items.Clear();
            CB_Type.Items.AddRange(ServoType);
        }
    }
}
