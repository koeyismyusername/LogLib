using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogLib
{
    public enum LogFileType
    {
        NONE,
        LOG,
        TXT,
        HTML
    }

    public static class LogFileTypeExtention
    {
        public static string GetExtention(this LogFileType logFileType)
        {
            switch (logFileType)
            {
                case LogFileType.HTML: return ".html";
                case LogFileType.LOG: return ".log";
                case LogFileType.TXT:
                case LogFileType.NONE:
                default: return ".txt";
            }
        }
    }
}
