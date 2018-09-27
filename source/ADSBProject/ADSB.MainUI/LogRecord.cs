using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ADSB.MainUI
{
    class LogRecord
    {
        private string logFile;
        private StreamWriter writer;
        private FileStream fileStream = null;

        public LogRecord()
        {
            InitialLog();
        }

        public void Writelogs(string info)
        {
            try
            {
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(logFile);
                if (!fileInfo.Exists)
                {
                    fileStream = fileInfo.Create();
                    writer = new StreamWriter(fileStream);
                }
                else
                {
                    fileStream = fileInfo.Open(FileMode.Append, FileAccess.Write);
                    writer = new StreamWriter(fileStream);
                }
                writer.WriteLine(DateTime.Now + ": " + info);

            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                    writer.Dispose();
                    fileStream.Close();
                    fileStream.Dispose();
                }
            }
        }

        private void InitialLog()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Log";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            path = path + "\\" + "Log" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss") + ".txt";
            logFile = path;
        }
    }
}
