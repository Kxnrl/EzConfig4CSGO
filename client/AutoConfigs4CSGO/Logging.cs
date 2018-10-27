using System;
using System.IO;
using System.Windows.Forms;

namespace EzConfig4CSGO
{
    class Logging
    {
        private static StreamWriter stream = null;

        public static void Initialize()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Kxnrl\\EzConfig";
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            stream = new StreamWriter(path + "\\exception.log");
        }

        public static void Exception(Exception ex, bool box = false)
        {
            if(box)
            {
                MessageBox.Show("Message: "
                            + Environment.NewLine
                            + ex.Message
                            + Environment.NewLine
                            + "Stacktrace: "
                            + Environment.NewLine
                            + ex.StackTrace,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
            }

            stream.WriteLine("=====================[" + DateTime.Now.ToString() + "]=====================" + Environment.NewLine
                            + "Message: " 
                            + Environment.NewLine
                            + ex.Message 
                            + Environment.NewLine
                            + "Stacktrace: " 
                            + Environment.NewLine
                            + ex.StackTrace
                            + Environment.NewLine
                            );
        }
    }
}
