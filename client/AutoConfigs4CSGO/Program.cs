using System;
using System.Threading;
using System.Windows.Forms;
using SteamworksSharp;
using SteamworksSharp.Native;

namespace EzConfig4CSGO
{
    static class Program
    {
        private const int AppId = 250820;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Mutex
            Mutex self = new Mutex(true, Application.StartupPath.GetHashCode().ToString(), out bool allow);
            if (!allow)
            {
                MessageBox.Show("已有一个CSI在运行中了 ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }

            // Load local native
            Logging.Initialize();

            // Load native steam binaries.
            SteamNative.Initialize();

            // Check steam is running
            if (!SteamApi.IsSteamRunning())
            {
                MessageBox.Show("请先运行Steam客户端.", "EZConfig4CSGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Provide appId so it automatically creates a "steam_appid.txt" file.
            if (!SteamApi.Initialize(AppId))
            {
                MessageBox.Show("初始化SteamApi失败.", "EZConfig4CSGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
