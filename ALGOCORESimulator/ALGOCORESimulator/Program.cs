using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;



namespace ALGOCORESimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string scanFpath = "";
            string scanPath;
            string scanName;
            string logFileFpath;
            string flag1 = "";
            string otherArgs = "";
            int argi = 0;

            Console.WriteLine("ALGOCORE on the move ...\n");

            foreach (string argument in args)
            {
                if (argi == 0)
                    scanFpath = argument;
                else if (argi == 1)
                    flag1 = argument;
                else
                    otherArgs += argument;
                argi++;
            }
            scanPath = Path.GetDirectoryName(scanFpath);
            scanName = Path.GetFileNameWithoutExtension(scanFpath);
            logFileFpath = scanPath + "\\" + scanName + "_Progress.txt";

            Console.WriteLine(" Scan path     : " + scanFpath + "\n");
            Console.WriteLine(" Log name      : " + logFileFpath + "\n");
            Console.WriteLine(" Flag-1        : " + flag1 + "\n");
            Console.WriteLine(" Other Params  : " + otherArgs + "\n");

            if (File.Exists(logFileFpath))
                File.Delete(logFileFpath);

            //File.Open(logFileFpath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            TextWriter tw = new StreamWriter(logFileFpath);
            String progresLine = "Initializing,5,OK";
            tw.WriteLine(progresLine);
            tw.Close();

            Thread.Sleep(2000);
            tw = new StreamWriter(logFileFpath);
            progresLine = "Loading Scan,15,OK";
            tw.WriteLine(progresLine);
            tw.Close();


            Thread.Sleep(2000);
            tw = new StreamWriter(logFileFpath);
            progresLine = "Calculating,25,OK";
            tw.WriteLine(progresLine);
            tw.Close();

            Thread.Sleep(2000);
            tw = new StreamWriter(logFileFpath);
            progresLine = "Stitching,50,OK";
            tw.WriteLine(progresLine);
            tw.Close();

            Thread.Sleep(2000);
            tw = new StreamWriter(logFileFpath);
            progresLine = "Generating PLY,80,OK";
            tw.WriteLine(progresLine);
            tw.Close();

            Thread.Sleep(2000);
            tw = new StreamWriter(logFileFpath);
            progresLine = "Closing,90,OK";
            tw.WriteLine(progresLine);
            tw.Close();

            Thread.Sleep(2000);
            tw = new StreamWriter(logFileFpath);
            progresLine = "Completed,100,OK";
            tw.WriteLine(progresLine);
            tw.Close();

        }
    }
}
