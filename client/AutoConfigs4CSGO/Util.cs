using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Collections.Generic;

namespace EzConfig4CSGO
{
    class Util
    {
        public static DateTime CheckCloudFile(ulong steamid)
        {
            if(!int.TryParse(DownloadString("https://api.kxnrl.com/configs/v1/?check&steamid=" + steamid), out int time))
            {
                return TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            }
            return TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)).AddSeconds(time);
        }

        private static string DownloadString(string url)
        {
            string result = string.Empty;

            using (WebClient web = new WebClient())
            {
                try
                {
                    result = web.DownloadString(url);
                }
                catch (Exception ex)
                {
                    Logging.Exception(ex);
                }
            }

            return result;
        }

        public static string GetSteamFolder()
        {
            return FindProcessPathByName("Steam");
        }

        private static string FindProcessPathByName(string name)
        {
            try
            {
                Process[] steamEXE = Process.GetProcessesByName(name);
                return (steamEXE.Length > 0) ? Path.GetDirectoryName(steamEXE[0].MainModule.FileName) : string.Empty;
            }
            catch
            {
                MessageBox.Show("您的Steam正在以管理员模式运行\n无法获取Steam数据", "EzConfig4CSGO");
                return string.Empty;
            }
        }

        public static bool UploadToServer(string steamFolder, ulong steamid)
        {
            try
            {
                UploadFile(steamFolder + @"\config.cfg", steamid);
                UploadFile(steamFolder + @"\video.txt", steamid);
                UploadFile(steamFolder + @"\autoexec.cfg", steamid, false);
                return true;
            }
            catch (Exception ex)
            {
                Logging.Exception(ex, true);
                return false;
            }
        }

        private static void UploadFile(string file, ulong steamid, bool force = true)
        {
            if(!File.Exists(file))
            {
                if(!force)
                {
                    // Stop
                    return;
                }

                // Exception
                throw new Exception("文件[" + file + "] 不存在");
            }

            using (HttpClient http = new HttpClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                http.BaseAddress = new Uri("https://api.kxnrl.com/");
                http.DefaultRequestHeaders.Add("User-Agent", "CSharp HttpClient from EzConfig4CSGO by Kyle");

                string cfg = "Echo NULL";
                using (StreamReader sr = new StreamReader(file, Encoding.UTF8))
                {
                    cfg = sr.ReadToEnd();
                }

                Dictionary<string, string> dict = new Dictionary<string, string>()
                {
                    {"upload",  "EzConfig4CSGO" },
                    {"steamid", steamid.ToString() },
                    {"streams", cfg },
                    {"filecfg", Path.GetFileName(file) }
                };

                FormUrlEncodedContent data = new FormUrlEncodedContent(dict);

                var result = http.PostAsync("/configs/v1/", data).Result;
                Console.WriteLine("Result: " + result.Content.ReadAsStringAsync().Result);
            }
        }

        internal static void backupCode(string steamid, string file)
        {
            using (WebClient web = new WebClient())
            {
                string cfg = "Echo NULL";
                using (StreamReader sr = new StreamReader(file, Encoding.UTF8))
                {
                    cfg = sr.ReadToEnd();
                }

                NameValueCollection data = new NameValueCollection()
                {
                    {"upload",  "EzConfig4CSGO" },
                    {"steamid", steamid.ToString() },
                    {"streams", cfg },
                    {"filecfg", file }
                };

                web.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                byte[] result = web.UploadValues("https://api.kxnrl.com/configs/v1", data);

                if (!Encoding.UTF8.GetString(result).StartsWith("success"))
                {
                    throw new Exception("Error: " + Encoding.UTF8.GetString(result));
                }
                Console.WriteLine(Encoding.UTF8.GetString(result));
            }
        }

        public static bool DownloadConfig(string steamFolder, ulong steamid, ProgressBar bar, Label label)
        {
            try
            {
                DownloadFile(steamFolder + @"\autoexec.cfg", steamid, bar, label, false);
            }
            catch
            {
                label.Text = "您尚未上传autoexec.cfg";
            }

            try
            {
                DownloadFile(steamFolder + @"\config.cfg", steamid, bar, label);
                DownloadFile(steamFolder + @"\video.txt", steamid, bar, label);
                return true;
            }
            catch (Exception ex)
            {
                Logging.Exception(ex, true);
                return false;
            }
        }

        private static void DownloadFile(string file, ulong steam, ProgressBar bar, Label label, bool force = true)
        {
            if(File.Exists(file))
            {
                File.Delete(file);
                Console.WriteLine("Deleted " + file + " ...");
            }

            HttpWebRequest web = (HttpWebRequest)WebRequest.Create("https://api.kxnrl.com/configs/v1/data/" + steam + "/" + Path.GetFileName(file));
            HttpWebResponse response = (HttpWebResponse)web.GetResponse();

            label.Text = "正在下载'" + Path.GetFileName(file) + "'...";

            using (Stream stream = response.GetResponseStream())
            {
                using (FileStream fs = new FileStream(file, FileMode.Create))
                {
                    long totalDownloadedByte = 0;
                    byte[] bytes = new byte[2048];
                    int osize = stream.Read(bytes, 0, bytes.Length);

                    bar.Maximum = (int)response.ContentLength;
                    bar.Minimum = 0;
                    bar.Value   = 0;

                    while (osize > 0)
                    {
                        totalDownloadedByte = osize + totalDownloadedByte;
                        fs.Write(bytes, 0, osize);
                        osize = stream.Read(bytes, 0, bytes.Length);

                        bar.Value = (int)totalDownloadedByte;
                        Application.DoEvents();
                    }

                    label.Text = "下载'" + Path.GetFileName(file) + "'完成!";
                }
            }
        }
    }
}
