using System;
using System.IO;

namespace LogLib
{
    public static class Log
    {
        private static string DirPath { get => @"..\Log"; }

        private static void Write(string logMessage, LogLevel logLevel, params LogFileType[] logFileTypes)
        {
            foreach (LogFileType logFileType in logFileTypes)
            {
                string filePath = $@"{DirPath}\{DateTime.Now.ToString("yyyy-MM-dd")}{logFileType.GetExtention()}";

                if (!Directory.Exists(DirPath)) Directory.CreateDirectory(DirPath);

                using (StreamWriter streamWriter = File.AppendText(filePath))
                {
                    streamWriter.WriteLine(logFileType.Format(logMessage, logLevel));
                }
            }
        }

        public static void Debug(object obj)
        {
            Write(obj.ToString(), LogLevel.DEBUG, LogFileType.HTML, LogFileType.LOG);
        }

        public static void Debug(object obj, params LogFileType[] logFileTypes)
        {
            Write(obj.ToString(), LogLevel.DEBUG, logFileTypes);
        }

        public static void Warn(object obj, params LogFileType[] logFileTypes)
        {
            Write(obj.ToString(), LogLevel.WARN, logFileTypes);
        }

        public static void Warn(object obj)
        {
            Write(obj.ToString(), LogLevel.WARN, LogFileType.HTML, LogFileType.LOG);
        }

        public static void Info(object obj)
        {
            Write(obj.ToString(), LogLevel.INFO, LogFileType.HTML, LogFileType.LOG);
        }

        public static void Info(object obj, params LogFileType[] logFileTypes)
        {
            Write(obj.ToString(), LogLevel.INFO, logFileTypes);
        }

        public static void Error(object obj)
        {
            Write(obj.ToString(), LogLevel.ERROR, LogFileType.HTML, LogFileType.LOG);
        }

        public static void Error(object obj, params LogFileType[] logFileTypes)
        {
            Write(obj.ToString(), LogLevel.ERROR, logFileTypes);
        }

        public static void Error(Exception ex)
        {
            Error(ex.Message + "\n" + ex.StackTrace);
        }
    }
}
