using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollectSmplData;

namespace ServoTool
{
    public partial class FormProgram : Form
    {
        itri2fanucWrapper Itri2Fanuc;
        ushort CncHndl;
        public FormProgram(itri2fanucWrapper I2F)
        {
            InitializeComponent();
            FormInertial();
            Itri2Fanuc = I2F;
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
                        MessageBox.Show("Download completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Btn_UploadCode_Click(object sender, EventArgs e)
        {
            OpenFileDialog path = new OpenFileDialog();
            path.Filter = "G程式碼|*.Gcode";
            if (path.ShowDialog() == System.Windows.Forms.DialogResult.OK && path.FileName != "")
            {
                string UploadStatus = Itri2Fanuc.UploadNCCode(path.FileName);
                if (UploadStatus.Equals("EW_OK"))
                    MessageBox.Show("Upload completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(UploadStatus, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Upload Failed(Path Error)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormInertial()
        {
            CB_PrgMode.SelectedIndex = 0;
            CB_HorizAxis.SelectedIndex = 0;
            CB_VertAxis.SelectedIndex = 1;
            TB_Travers.Text = "10";
            TB_Radius.Text = "10";
            TB_FeedRate.Text = "1000";
            TB_Repeat.Text = "1";
            TB_NTrigger.Text = "1";
            checkedListBox_Gtype.SetItemChecked(0,true);
            checkedListBox_CWCCW.SetItemChecked(0, true);
        }

        private void checkedListBox_Gtype_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                foreach (int i in checkedListBox_Gtype.CheckedIndices)
                    checkedListBox_Gtype.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
