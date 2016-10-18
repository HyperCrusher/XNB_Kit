using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace XNB_Unpacker
{
    public partial class Window : Form
    {
        private delegate void updateText(string str);
        private delegate void ToggleButton(Button Butt, Boolean value);
        private delegate void ToggleTabs(TabPage Tab, Boolean value);
        public Window()
        {
            InitializeComponent();
        }

        private void Unpack_Click(object sender, EventArgs e)
        {
            Unpack.RunWorkerAsync();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            HomeTitle.Location = new Point((Tab.TabPages[0].Width / 2) - (HomeTitle.Size.Width / 2));
        }

 
        private void doUnpack(DataReceivedEventArgs e)
        {
            if(e.Data != null)
                UnpackStatus.Invoke(new updateText(update_unpackStatus), new object[] { e.Data.ToString() });

        }

        private void doPack(DataReceivedEventArgs e)
        {
            if (e.Data != null)
                PackStatus.Invoke(new updateText(update_packStatus), new object[] { e.Data.ToString() });

        }

        private void ToggleUnpack(Boolean value)
        {
            BrowseXNBBtn.Invoke(new ToggleButton(Toggle_Button), new object[] { BrowseXNBBtn, value });
            ExtractFoldrBrowseBtn.Invoke(new ToggleButton(Toggle_Button), new object[] { ExtractFoldrBrowseBtn, value });
            UnpackBtn.Invoke(new ToggleButton(Toggle_Button), new object[] { UnpackBtn, value });
            Tab.Invoke(new ToggleTabs(Toggle_Tabcontrol), new object[] { Tab.TabPages[0], value });
            Tab.Invoke(new ToggleTabs(Toggle_Tabcontrol), new object[] { Tab.TabPages[2], value });
        }

        private void TogglePack(Boolean value)
        {
            PackBtn.Invoke(new ToggleButton(Toggle_Button), new object[] { PackBtn, value });
            BrowseCompressToBtn.Invoke(new ToggleButton(Toggle_Button), new object[] { BrowseCompressToBtn, value });
            BrowseUnpackedBtn.Invoke(new ToggleButton(Toggle_Button), new object[] { BrowseUnpackedBtn, value });
            Tab.Invoke(new ToggleTabs(Toggle_Tabcontrol), new object[] { Tab.TabPages[0], value });
            Tab.Invoke(new ToggleTabs(Toggle_Tabcontrol), new object[] { Tab.TabPages[1], value });
        }
        private void Toggle_Button(Button Button, Boolean value)
        {
            Button.Enabled = value;
        }
        private void update_unpackStatus(string value)
        {
            if(value != "")
                UnpackStatus.AppendText("> " + value + "\n");
            if (value == "Done")
            {
                UnpackStatus.Text = ("> " + value + "\n");
            }
        }

        private void update_packStatus(string value)
        {
            if (value != "")
                PackStatus.AppendText("> " + value + "\n");
            if (value == "Done")
            {
                PackStatus.Text = ("> " + value + "\n");
            }
        }


        private void Toggle_Tabcontrol(TabPage tab, Boolean value)
        {
            tab.Enabled = value;
        }

        private void Unpack_DoWork(object sender, DoWorkEventArgs de)
        {
            System.Diagnostics.Process UnpackProcess;
            UnpackProcess = new System.Diagnostics.Process();
            UnpackProcess.StartInfo.UseShellExecute = false;
            UnpackProcess.StartInfo.RedirectStandardOutput = true;
            UnpackProcess.StartInfo.RedirectStandardInput = true;
            UnpackProcess.StartInfo.FileName = "cmd";
            UnpackProcess.StartInfo.CreateNoWindow = true;
            UnpackProcess.OutputDataReceived += (s, e) => doUnpack(e);
            ToggleUnpack(false);
            UnpackProcess.Start();
            UnpackProcess.BeginOutputReadLine();
            UnpackProcess.StandardInput.WriteLine("@.\\app\\node .\\app\\main.js extract \"" + FolderXNBTbx.Text + "\" \"" + ExtractFolderTxb.Text + "\"");
            UnpackProcess.StandardInput.WriteLine("@exit");
            UnpackProcess.StandardInput.Flush();
            UnpackProcess.WaitForExit();
            UnpackStatus.Invoke(new updateText(update_unpackStatus), new object[] { "Done" });
            ToggleUnpack(true);
            UnpackProcess.Close();
        }

        private void XNB_Click(object sender, EventArgs e)
        {
            FolderDialog.Reset();
            FolderDialog.Description = "Select Folder Containing XNB Files";
            FolderDialog.ShowDialog();
            FolderXNBTbx.Text = FolderDialog.SelectedPath;
            if (FolderXNBTbx.Text != "" && ExtractFolderTxb.Text != "")
                UnpackBtn.Enabled = true;
            else
                UnpackBtn.Enabled = false;
        }

        private void Extract_Click(object sender, EventArgs e)
        {
            FolderDialog.Reset();
            FolderDialog.Description = "Select Folder to Unpack XNB Files Into";
            FolderDialog.ShowDialog();
            ExtractFolderTxb.Text = FolderDialog.SelectedPath;
            if (FolderXNBTbx.Text != "" && ExtractFolderTxb.Text != "")
                UnpackBtn.Enabled = true;
            else
                UnpackBtn.Enabled = false;
        }

        private void Pack_Click(object sender, EventArgs ed)
        {
            Pack.RunWorkerAsync();
        }

        private void Compress_Click(object sender, EventArgs e)
        {
            FolderDialog.Reset();
            FolderDialog.Description = "Select Folder to Unpack XNB Files Into";
            FolderDialog.ShowDialog();
            CompressToTxtbx.Text = FolderDialog.SelectedPath;
            if (CompressToTxtbx.Text != "" && UnPackedtxbx.Text != "")
                PackBtn.Enabled = true;
            else
                PackBtn.Enabled = false;
        }

        private void Unpacked_Click(object sender, EventArgs e)
        {
            FolderDialog.Reset();
            FolderDialog.Description = "Select Folder to Unpack XNB Files Into";
            FolderDialog.ShowDialog();
            UnPackedtxbx.Text = FolderDialog.SelectedPath;
            if (CompressToTxtbx.Text != "" && UnPackedtxbx.Text != "")
                PackBtn.Enabled = true;
            else
                PackBtn.Enabled = false;
        }

        private void Pack_DoWork(object sender, DoWorkEventArgs ed)
        {
            System.Diagnostics.Process PackProccess;
            PackProccess = new System.Diagnostics.Process();
            PackProccess.StartInfo.UseShellExecute = false;
            PackProccess.StartInfo.RedirectStandardOutput = true;
            PackProccess.StartInfo.RedirectStandardInput = true;
            PackProccess.StartInfo.FileName = "cmd";
            PackProccess.StartInfo.CreateNoWindow = true;
            PackProccess.OutputDataReceived += (s, e) => doPack(e);
            TogglePack(false);
            PackProccess.Start();
            PackProccess.BeginOutputReadLine();
            PackProccess.StandardInput.WriteLine("@.\\app\\node .\\app\\main.js pack \"" + UnPackedtxbx.Text + "\" \"" + CompressToTxtbx.Text + "\"");
            PackProccess.StandardInput.WriteLine("@exit");
            PackProccess.StandardInput.Flush();
            PackProccess.WaitForExit();
            PackStatus.Invoke(new updateText(update_packStatus), new object[] { "Done" });
            TogglePack(true);
            PackProccess.Close();
        }


    }
}
