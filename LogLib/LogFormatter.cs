using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogLib
{
    public static class LogFormatter
    {
        public static string Format(this LogFileType logFileType, string logMessage, LogLevel logLevel)
        {
            switch (logFileType)
            {
                //TODO: 여기 양식 작성 
                case LogFileType.HTML: return $"<div style=\"color:{logLevel.GetColor()}\"><span style=\"font-weight:bold\">[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {logLevel}</span>: {logMessage}</div>".Replace("\n", "</br>");
                case LogFileType.LOG:
                case LogFileType.TXT:
                case LogFileType.NONE:
                default: return $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {logLevel}: {logMessage}";
            }
        }
    }
}
