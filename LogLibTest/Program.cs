using System;
using System.IO;

using LogLib;

namespace LogLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamWriter sw = File.AppendText("../Log/LogLog/logFile.txt"))
                {
                    sw.WriteLine("hello, world");
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
        }
    }
}
