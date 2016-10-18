namespace XNB_Unpacker
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.HomeTitle = new System.Windows.Forms.Label();
            this.Tab = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.UnpackTab = new System.Windows.Forms.TabPage();
            this.UnpackStatus = new System.Windows.Forms.TextBox();
            this.UnpackBtn = new System.Windows.Forms.Button();
            this.ExtractFoldrBrowseBtn = new System.Windows.Forms.Button();
            this.ExtractFolderTxb = new System.Windows.Forms.TextBox();
            this.ExtractFolderLbl = new System.Windows.Forms.Label();
            this.BrowseXNBBtn = new System.Windows.Forms.Button();
            this.FolderXNBTbx = new System.Windows.Forms.TextBox();
            this.FolderXNBLbl = new System.Windows.Forms.Label();
            this.UnPackTitle = new System.Windows.Forms.Label();
            this.PackTab = new System.Windows.Forms.TabPage();
            this.PackStatus = new System.Windows.Forms.TextBox();
            this.PackBtn = new System.Windows.Forms.Button();
            this.BrowseCompressToBtn = new System.Windows.Forms.Button();
            this.CompressToTxtbx = new System.Windows.Forms.TextBox();
            this.CompressToLbl = new System.Windows.Forms.Label();
            this.BrowseUnpackedBtn = new System.Windows.Forms.Button();
            this.UnPackedtxbx = new System.Windows.Forms.TextBox();
            this.UnpackedLbl = new System.Windows.Forms.Label();
            this.PackTitle = new System.Windows.Forms.Label();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Unpack = new System.ComponentModel.BackgroundWorker();
            this.Pack = new System.ComponentModel.BackgroundWorker();
            this.Tab.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.UnpackTab.SuspendLayout();
            this.PackTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeTitle
            // 
            this.HomeTitle.AutoSize = true;
            this.HomeTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitle.Location = new System.Drawing.Point(11, 13);
            this.HomeTitle.Name = "HomeTitle";
            this.HomeTitle.Size = new System.Drawing.Size(165, 23);
            this.HomeTitle.TabIndex = 0;
            this.HomeTitle.Text = "XNB Modkit GUI";
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.HomeTab);
            this.Tab.Controls.Add(this.UnpackTab);
            this.Tab.Controls.Add(this.PackTab);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(403, 482);
            this.Tab.TabIndex = 1;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.WelcomeMessage);
            this.HomeTab.Controls.Add(this.HomeTitle);
            this.HomeTab.Location = new System.Drawing.Point(4, 25);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(395, 453);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMessage.Location = new System.Drawing.Point(3, 63);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(285, 288);
            this.WelcomeMessage.TabIndex = 1;
            this.WelcomeMessage.Text = resources.GetString("WelcomeMessage.Text");
            // 
            // UnpackTab
            // 
            this.UnpackTab.Controls.Add(this.UnpackStatus);
            this.UnpackTab.Controls.Add(this.UnpackBtn);
            this.UnpackTab.Controls.Add(this.ExtractFoldrBrowseBtn);
            this.UnpackTab.Controls.Add(this.ExtractFolderTxb);
            this.UnpackTab.Controls.Add(this.ExtractFolderLbl);
            this.UnpackTab.Controls.Add(this.BrowseXNBBtn);
            this.UnpackTab.Controls.Add(this.FolderXNBTbx);
            this.UnpackTab.Controls.Add(this.FolderXNBLbl);
            this.UnpackTab.Controls.Add(this.UnPackTitle);
            this.UnpackTab.Location = new System.Drawing.Point(4, 25);
            this.UnpackTab.Name = "UnpackTab";
            this.UnpackTab.Padding = new System.Windows.Forms.Padding(3);
            this.UnpackTab.Size = new System.Drawing.Size(395, 453);
            this.UnpackTab.TabIndex = 1;
            this.UnpackTab.Text = "Unpack";
            this.UnpackTab.UseVisualStyleBackColor = true;
            // 
            // UnpackStatus
            // 
            this.UnpackStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnpackStatus.Location = new System.Drawing.Point(11, 323);
            this.UnpackStatus.Multiline = true;
            this.UnpackStatus.Name = "UnpackStatus";
            this.UnpackStatus.ReadOnly = true;
            this.UnpackStatus.Size = new System.Drawing.Size(376, 127);
            this.UnpackStatus.TabIndex = 9;
            this.UnpackStatus.Text = "> Waiting";
            // 
            // UnpackBtn
            // 
            this.UnpackBtn.Enabled = false;
            this.UnpackBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnpackBtn.Location = new System.Drawing.Point(143, 270);
            this.UnpackBtn.Name = "UnpackBtn";
            this.UnpackBtn.Size = new System.Drawing.Size(126, 31);
            this.UnpackBtn.TabIndex = 8;
            this.UnpackBtn.Text = "Unpack";
            this.UnpackBtn.UseVisualStyleBackColor = true;
            this.UnpackBtn.Click += new System.EventHandler(this.Unpack_Click);
            // 
            // ExtractFoldrBrowseBtn
            // 
            this.ExtractFoldrBrowseBtn.Location = new System.Drawing.Point(244, 212);
            this.ExtractFoldrBrowseBtn.Name = "ExtractFoldrBrowseBtn";
            this.ExtractFoldrBrowseBtn.Size = new System.Drawing.Size(96, 30);
            this.ExtractFoldrBrowseBtn.TabIndex = 7;
            this.ExtractFoldrBrowseBtn.Text = "Browse";
            this.ExtractFoldrBrowseBtn.UseVisualStyleBackColor = true;
            this.ExtractFoldrBrowseBtn.Click += new System.EventHandler(this.Extract_Click);
            // 
            // ExtractFolderTxb
            // 
            this.ExtractFolderTxb.Location = new System.Drawing.Point(62, 183);
            this.ExtractFolderTxb.Name = "ExtractFolderTxb";
            this.ExtractFolderTxb.ReadOnly = true;
            this.ExtractFolderTxb.Size = new System.Drawing.Size(278, 23);
            this.ExtractFolderTxb.TabIndex = 6;
            // 
            // ExtractFolderLbl
            // 
            this.ExtractFolderLbl.AutoSize = true;
            this.ExtractFolderLbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtractFolderLbl.Location = new System.Drawing.Point(59, 158);
            this.ExtractFolderLbl.Name = "ExtractFolderLbl";
            this.ExtractFolderLbl.Size = new System.Drawing.Size(167, 18);
            this.ExtractFolderLbl.TabIndex = 5;
            this.ExtractFolderLbl.Text = "Folder to extract to";
            // 
            // BrowseXNBBtn
            // 
            this.BrowseXNBBtn.Location = new System.Drawing.Point(246, 108);
            this.BrowseXNBBtn.Name = "BrowseXNBBtn";
            this.BrowseXNBBtn.Size = new System.Drawing.Size(96, 30);
            this.BrowseXNBBtn.TabIndex = 4;
            this.BrowseXNBBtn.Text = "Browse";
            this.BrowseXNBBtn.UseVisualStyleBackColor = true;
            this.BrowseXNBBtn.Click += new System.EventHandler(this.XNB_Click);
            // 
            // FolderXNBTbx
            // 
            this.FolderXNBTbx.Location = new System.Drawing.Point(64, 79);
            this.FolderXNBTbx.Name = "FolderXNBTbx";
            this.FolderXNBTbx.ReadOnly = true;
            this.FolderXNBTbx.Size = new System.Drawing.Size(278, 23);
            this.FolderXNBTbx.TabIndex = 3;
            // 
            // FolderXNBLbl
            // 
            this.FolderXNBLbl.AutoSize = true;
            this.FolderXNBLbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderXNBLbl.Location = new System.Drawing.Point(61, 54);
            this.FolderXNBLbl.Name = "FolderXNBLbl";
            this.FolderXNBLbl.Size = new System.Drawing.Size(183, 18);
            this.FolderXNBLbl.TabIndex = 2;
            this.FolderXNBLbl.Text = "Folder with XNB Files";
            // 
            // UnPackTitle
            // 
            this.UnPackTitle.AutoSize = true;
            this.UnPackTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnPackTitle.Location = new System.Drawing.Point(161, 14);
            this.UnPackTitle.Name = "UnPackTitle";
            this.UnPackTitle.Size = new System.Drawing.Size(79, 23);
            this.UnPackTitle.TabIndex = 1;
            this.UnPackTitle.Text = "UnPack";
            // 
            // PackTab
            // 
            this.PackTab.Controls.Add(this.PackStatus);
            this.PackTab.Controls.Add(this.PackBtn);
            this.PackTab.Controls.Add(this.BrowseCompressToBtn);
            this.PackTab.Controls.Add(this.CompressToTxtbx);
            this.PackTab.Controls.Add(this.CompressToLbl);
            this.PackTab.Controls.Add(this.BrowseUnpackedBtn);
            this.PackTab.Controls.Add(this.UnPackedtxbx);
            this.PackTab.Controls.Add(this.UnpackedLbl);
            this.PackTab.Controls.Add(this.PackTitle);
            this.PackTab.Location = new System.Drawing.Point(4, 25);
            this.PackTab.Name = "PackTab";
            this.PackTab.Size = new System.Drawing.Size(395, 453);
            this.PackTab.TabIndex = 2;
            this.PackTab.Text = "Pack";
            this.PackTab.UseVisualStyleBackColor = true;
            // 
            // PackStatus
            // 
            this.PackStatus.Location = new System.Drawing.Point(11, 323);
            this.PackStatus.Multiline = true;
            this.PackStatus.Name = "PackStatus";
            this.PackStatus.ReadOnly = true;
            this.PackStatus.Size = new System.Drawing.Size(376, 127);
            this.PackStatus.TabIndex = 18;
            this.PackStatus.Text = "> Waiting";
            // 
            // PackBtn
            // 
            this.PackBtn.Enabled = false;
            this.PackBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackBtn.Location = new System.Drawing.Point(143, 270);
            this.PackBtn.Name = "PackBtn";
            this.PackBtn.Size = new System.Drawing.Size(126, 31);
            this.PackBtn.TabIndex = 17;
            this.PackBtn.Text = "Pack";
            this.PackBtn.UseVisualStyleBackColor = true;
            this.PackBtn.Click += new System.EventHandler(this.Pack_Click);
            // 
            // BrowseCompressToBtn
            // 
            this.BrowseCompressToBtn.Location = new System.Drawing.Point(244, 212);
            this.BrowseCompressToBtn.Name = "BrowseCompressToBtn";
            this.BrowseCompressToBtn.Size = new System.Drawing.Size(96, 30);
            this.BrowseCompressToBtn.TabIndex = 16;
            this.BrowseCompressToBtn.Text = "Browse";
            this.BrowseCompressToBtn.UseVisualStyleBackColor = true;
            this.BrowseCompressToBtn.Click += new System.EventHandler(this.Compress_Click);
            // 
            // CompressToTxtbx
            // 
            this.CompressToTxtbx.Location = new System.Drawing.Point(62, 183);
            this.CompressToTxtbx.Name = "CompressToTxtbx";
            this.CompressToTxtbx.ReadOnly = true;
            this.CompressToTxtbx.Size = new System.Drawing.Size(278, 23);
            this.CompressToTxtbx.TabIndex = 15;
            // 
            // CompressToLbl
            // 
            this.CompressToLbl.AutoSize = true;
            this.CompressToLbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompressToLbl.Location = new System.Drawing.Point(59, 158);
            this.CompressToLbl.Name = "CompressToLbl";
            this.CompressToLbl.Size = new System.Drawing.Size(187, 18);
            this.CompressToLbl.TabIndex = 14;
            this.CompressToLbl.Text = "Folder to compress to";
            // 
            // BrowseUnpackedBtn
            // 
            this.BrowseUnpackedBtn.Location = new System.Drawing.Point(246, 108);
            this.BrowseUnpackedBtn.Name = "BrowseUnpackedBtn";
            this.BrowseUnpackedBtn.Size = new System.Drawing.Size(96, 30);
            this.BrowseUnpackedBtn.TabIndex = 13;
            this.BrowseUnpackedBtn.Text = "Browse";
            this.BrowseUnpackedBtn.UseVisualStyleBackColor = true;
            this.BrowseUnpackedBtn.Click += new System.EventHandler(this.Unpacked_Click);
            // 
            // UnPackedtxbx
            // 
            this.UnPackedtxbx.Location = new System.Drawing.Point(64, 79);
            this.UnPackedtxbx.Name = "UnPackedtxbx";
            this.UnPackedtxbx.ReadOnly = true;
            this.UnPackedtxbx.Size = new System.Drawing.Size(278, 23);
            this.UnPackedtxbx.TabIndex = 12;
            // 
            // UnpackedLbl
            // 
            this.UnpackedLbl.AutoSize = true;
            this.UnpackedLbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnpackedLbl.Location = new System.Drawing.Point(61, 54);
            this.UnpackedLbl.Name = "UnpackedLbl";
            this.UnpackedLbl.Size = new System.Drawing.Size(242, 18);
            this.UnpackedLbl.TabIndex = 11;
            this.UnpackedLbl.Text = "Folder with unpacked assets";
            // 
            // PackTitle
            // 
            this.PackTitle.AutoSize = true;
            this.PackTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackTitle.Location = new System.Drawing.Point(162, 11);
            this.PackTitle.Name = "PackTitle";
            this.PackTitle.Size = new System.Drawing.Size(53, 23);
            this.PackTitle.TabIndex = 10;
            this.PackTitle.Text = "Pack";
            // 
            // FolderDialog
            // 
            this.FolderDialog.Description = "Select Folder Containing XNB Files";
            this.FolderDialog.RootFolder = System.Environment.SpecialFolder.DesktopDirectory;
            // 
            // Unpack
            // 
            this.Unpack.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Unpack_DoWork);
            // 
            // Pack
            // 
            this.Pack.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Pack_DoWork);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 482);
            this.Controls.Add(this.Tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Window";
            this.Text = "XNB Modkit GUI";
            this.Load += new System.EventHandler(this.Window_Load);
            this.Tab.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            this.UnpackTab.ResumeLayout(false);
            this.UnpackTab.PerformLayout();
            this.PackTab.ResumeLayout(false);
            this.PackTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HomeTitle;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabPage UnpackTab;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.TabPage PackTab;
        private System.Windows.Forms.Label FolderXNBLbl;
        private System.Windows.Forms.Label UnPackTitle;
        private System.Windows.Forms.TextBox FolderXNBTbx;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.TextBox UnpackStatus;
        private System.Windows.Forms.Button UnpackBtn;
        private System.Windows.Forms.Button ExtractFoldrBrowseBtn;
        private System.Windows.Forms.TextBox ExtractFolderTxb;
        private System.Windows.Forms.Label ExtractFolderLbl;
        private System.Windows.Forms.Button BrowseXNBBtn;
        private System.Windows.Forms.TextBox PackStatus;
        private System.Windows.Forms.Button PackBtn;
        private System.Windows.Forms.Button BrowseCompressToBtn;
        private System.Windows.Forms.TextBox CompressToTxtbx;
        private System.Windows.Forms.Label CompressToLbl;
        private System.Windows.Forms.Button BrowseUnpackedBtn;
        private System.Windows.Forms.TextBox UnPackedtxbx;
        private System.Windows.Forms.Label UnpackedLbl;
        private System.Windows.Forms.Label PackTitle;
        private System.ComponentModel.BackgroundWorker Unpack;
        private System.ComponentModel.BackgroundWorker Pack;
    }
}

