namespace EzConfig4CSGO
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_SteamID = new System.Windows.Forms.Label();
            this.Label_SteamID_s = new System.Windows.Forms.Label();
            this.Label_Nick = new System.Windows.Forms.Label();
            this.Label_Nick_s = new System.Windows.Forms.Label();
            this.Label_Level = new System.Windows.Forms.Label();
            this.Label_Level_s = new System.Windows.Forms.Label();
            this.Group_Handle = new System.Windows.Forms.GroupBox();
            this.Button_Download = new System.Windows.Forms.Button();
            this.Button_Upload = new System.Windows.Forms.Button();
            this.Label_Cloud = new System.Windows.Forms.Label();
            this.Label_Handle_Cloud = new System.Windows.Forms.Label();
            this.Handle_Progressbar = new System.Windows.Forms.ProgressBar();
            this.Label_Logging = new System.Windows.Forms.Label();
            this.Label_Kxnrl = new System.Windows.Forms.Label();
            this.Group_Handle.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_SteamID
            // 
            this.Label_SteamID.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SteamID.Location = new System.Drawing.Point(12, 10);
            this.Label_SteamID.Name = "Label_SteamID";
            this.Label_SteamID.Size = new System.Drawing.Size(100, 24);
            this.Label_SteamID.TabIndex = 0;
            this.Label_SteamID.Text = "SteamId";
            this.Label_SteamID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_SteamID_s
            // 
            this.Label_SteamID_s.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_SteamID_s.Location = new System.Drawing.Point(130, 10);
            this.Label_SteamID_s.Name = "Label_SteamID_s";
            this.Label_SteamID_s.Size = new System.Drawing.Size(200, 24);
            this.Label_SteamID_s.TabIndex = 1;
            this.Label_SteamID_s.Text = "76561198048432253";
            this.Label_SteamID_s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Nick
            // 
            this.Label_Nick.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nick.Location = new System.Drawing.Point(12, 39);
            this.Label_Nick.Name = "Label_Nick";
            this.Label_Nick.Size = new System.Drawing.Size(100, 24);
            this.Label_Nick.TabIndex = 2;
            this.Label_Nick.Text = "Nickname";
            this.Label_Nick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Nick_s
            // 
            this.Label_Nick_s.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Nick_s.Location = new System.Drawing.Point(130, 39);
            this.Label_Nick_s.Name = "Label_Nick_s";
            this.Label_Nick_s.Size = new System.Drawing.Size(200, 24);
            this.Label_Nick_s.TabIndex = 3;
            this.Label_Nick_s.Text = "nimasile";
            this.Label_Nick_s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Level
            // 
            this.Label_Level.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Level.Location = new System.Drawing.Point(12, 68);
            this.Label_Level.Name = "Label_Level";
            this.Label_Level.Size = new System.Drawing.Size(100, 24);
            this.Label_Level.TabIndex = 4;
            this.Label_Level.Text = "Level";
            this.Label_Level.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Level_s
            // 
            this.Label_Level_s.Font = new System.Drawing.Font("Vivaldi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Level_s.Location = new System.Drawing.Point(130, 68);
            this.Label_Level_s.Name = "Label_Level_s";
            this.Label_Level_s.Size = new System.Drawing.Size(200, 24);
            this.Label_Level_s.TabIndex = 5;
            this.Label_Level_s.Text = "1010";
            this.Label_Level_s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Group_Handle
            // 
            this.Group_Handle.Controls.Add(this.Button_Download);
            this.Group_Handle.Controls.Add(this.Button_Upload);
            this.Group_Handle.Controls.Add(this.Label_Cloud);
            this.Group_Handle.Controls.Add(this.Label_Handle_Cloud);
            this.Group_Handle.Controls.Add(this.Handle_Progressbar);
            this.Group_Handle.Controls.Add(this.Label_Logging);
            this.Group_Handle.Location = new System.Drawing.Point(12, 105);
            this.Group_Handle.Name = "Group_Handle";
            this.Group_Handle.Size = new System.Drawing.Size(320, 140);
            this.Group_Handle.TabIndex = 7;
            this.Group_Handle.TabStop = false;
            this.Group_Handle.Text = "Handle";
            // 
            // Button_Download
            // 
            this.Button_Download.Enabled = false;
            this.Button_Download.Location = new System.Drawing.Point(190, 110);
            this.Button_Download.Name = "Button_Download";
            this.Button_Download.Size = new System.Drawing.Size(100, 25);
            this.Button_Download.TabIndex = 7;
            this.Button_Download.Text = "下载云端文件";
            this.Button_Download.UseVisualStyleBackColor = true;
            this.Button_Download.Click += new System.EventHandler(this.Download_Clicked);
            // 
            // Button_Upload
            // 
            this.Button_Upload.Enabled = false;
            this.Button_Upload.Location = new System.Drawing.Point(30, 110);
            this.Button_Upload.Name = "Button_Upload";
            this.Button_Upload.Size = new System.Drawing.Size(100, 25);
            this.Button_Upload.TabIndex = 6;
            this.Button_Upload.Text = "上传本地文件";
            this.Button_Upload.UseVisualStyleBackColor = true;
            this.Button_Upload.Click += new System.EventHandler(this.Upload_Clicked);
            // 
            // Label_Cloud
            // 
            this.Label_Cloud.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Cloud.Location = new System.Drawing.Point(150, 80);
            this.Label_Cloud.Name = "Label_Cloud";
            this.Label_Cloud.Size = new System.Drawing.Size(150, 20);
            this.Label_Cloud.TabIndex = 4;
            this.Label_Cloud.Text = "null";
            this.Label_Cloud.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Handle_Cloud
            // 
            this.Label_Handle_Cloud.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Handle_Cloud.Location = new System.Drawing.Point(15, 80);
            this.Label_Handle_Cloud.Name = "Label_Handle_Cloud";
            this.Label_Handle_Cloud.Size = new System.Drawing.Size(80, 20);
            this.Label_Handle_Cloud.TabIndex = 2;
            this.Label_Handle_Cloud.Text = "云端文件";
            this.Label_Handle_Cloud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Handle_Progressbar
            // 
            this.Handle_Progressbar.Location = new System.Drawing.Point(15, 50);
            this.Handle_Progressbar.Name = "Handle_Progressbar";
            this.Handle_Progressbar.Size = new System.Drawing.Size(290, 20);
            this.Handle_Progressbar.Step = 1;
            this.Handle_Progressbar.TabIndex = 1;
            this.Handle_Progressbar.Value = 100;
            // 
            // Label_Logging
            // 
            this.Label_Logging.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Logging.Location = new System.Drawing.Point(15, 20);
            this.Label_Logging.Name = "Label_Logging";
            this.Label_Logging.Size = new System.Drawing.Size(290, 20);
            this.Label_Logging.TabIndex = 0;
            this.Label_Logging.Text = "Loading...";
            this.Label_Logging.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Kxnrl
            // 
            this.Label_Kxnrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Kxnrl.Font = new System.Drawing.Font("微软雅黑 Light", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Kxnrl.Location = new System.Drawing.Point(236, 248);
            this.Label_Kxnrl.Name = "Label_Kxnrl";
            this.Label_Kxnrl.Size = new System.Drawing.Size(109, 15);
            this.Label_Kxnrl.TabIndex = 8;
            this.Label_Kxnrl.Text = "Made with ❤ by Kyle";
            this.Label_Kxnrl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Label_Kxnrl.Click += new System.EventHandler(this.Kxnrl_Clicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.Label_Kxnrl);
            this.Controls.Add(this.Group_Handle);
            this.Controls.Add(this.Label_Level_s);
            this.Controls.Add(this.Label_Level);
            this.Controls.Add(this.Label_Nick_s);
            this.Controls.Add(this.Label_Nick);
            this.Controls.Add(this.Label_SteamID_s);
            this.Controls.Add(this.Label_SteamID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EzConfig4CSGO";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Group_Handle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_SteamID;
        private System.Windows.Forms.Label Label_SteamID_s;
        private System.Windows.Forms.Label Label_Nick;
        private System.Windows.Forms.Label Label_Nick_s;
        private System.Windows.Forms.Label Label_Level;
        private System.Windows.Forms.Label Label_Level_s;
        private System.Windows.Forms.GroupBox Group_Handle;
        private System.Windows.Forms.ProgressBar Handle_Progressbar;
        private System.Windows.Forms.Label Label_Logging;
        private System.Windows.Forms.Label Label_Handle_Cloud;
        private System.Windows.Forms.Button Button_Download;
        private System.Windows.Forms.Button Button_Upload;
        private System.Windows.Forms.Label Label_Cloud;
        private System.Windows.Forms.Label Label_Kxnrl;
    }
}

