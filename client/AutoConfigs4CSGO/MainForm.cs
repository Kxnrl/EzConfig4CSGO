using System;
using System.Windows.Forms;
using System.Text;
using System.Threading;
using SteamworksSharp;
using System.Diagnostics;

namespace EzConfig4CSGO
{
    public partial class MainForm : Form
    {
        private static string steamFolder = @"D:\Steam";

        public MainForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var steamid = SteamApi.SteamUser.GetSteamID();
            var mynname = Encoding.UTF8.GetString(Encoding.Default.GetBytes(SteamApi.SteamFriends.GetPersonaName()));
            var mylevel = SteamApi.SteamUser.GetPlayerSteamLevel();

            // Steam User Info
            Label_SteamID_s.Text = steamid.ToString();
            Label_Nick_s.Text    = mynname.ToString();
            Label_Level_s.Text   = mylevel.ToString();

            // Find Config Dir
            steamFolder = Util.GetSteamFolder() + @"\userdata\" + (steamid - 76561197960265728) + @"\730\local\cfg";

            new Thread(() =>
            {
                // UI
                Invoke(new Action(() =>
                {
                    Handle_Progressbar.Value = 100;
                    Label_Logging.Text = "初始化SteamApi成功...";
                }));

                // Sleep
                Thread.Sleep(2000);

                // UI
                Invoke(new Action(() =>
                {
                    Label_Logging.Text = "正在连接到服务器...";
                }));

                // Check cloud
                DateTime cloudTime = Util.CheckCloudFile(SteamApi.SteamUser.GetSteamID());

                // UI
                Invoke(new Action(() =>
                {
                    // Allow button
                    if (cloudTime.Year > 2000)
                    {
                        Button_Download.Enabled = true;
                        Label_Cloud.Text = cloudTime.ToString("yyyy/MM/dd HH:mm:ss");
                    }
                    else
                    {
                        Label_Cloud.Text = "尚未上传文件到服务器";
                    }
                    Button_Upload.Enabled = true;

                    Label_Logging.Text = "SteamApi && KxnrlApi 初始化完成!";
                }));
            }).Start();
        }

        private void Upload_Clicked(object sender, EventArgs e)
        {
            Button_Upload.Enabled = false;
            Button_Download.Enabled = false;
            Label_Logging.Text = "正在上传文件...";

            if (Util.UploadToServer(steamFolder, SteamApi.SteamUser.GetSteamID()))
            {
                Label_Cloud.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                Button_Download.Enabled = true;
                Label_Logging.Text = "文件上传成功!";
            }

            Button_Upload.Enabled = true;
        }

        private void Download_Clicked(object sender, EventArgs e)
        {
            Button_Upload.Enabled = false;
            Button_Download.Enabled = false;
            Label_Logging.Text = "正在下载文件...";

            if (Util.DownloadConfig(steamFolder, SteamApi.SteamUser.GetSteamID(), Handle_Progressbar, Label_Logging))
            {
                Label_Logging.Text = "文件下载完成!";
            }

            Button_Upload.Enabled = true;
            Button_Download.Enabled = true;
        }

        private void Kxnrl_Clicked(object sender, EventArgs e)
        {
            if(MessageBox.Show("This program is free and useful!" + Environment.NewLine + "If you like my work," + Environment.NewLine + "Click like in github page!", "Kyle \"Kxnrl\" Frankiss", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Process.Start("https://kxnrl.com");
            }
        }
    }
}
