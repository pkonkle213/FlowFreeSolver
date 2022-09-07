using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FlowFreeSolver.FileWriter
{
    public class FileAccess
    {
        public string filePath = @"C:\Catering\cateringsystem.csv";
        public string fileOutPath = @"C:\Catering\Log.txt";

        public void SavePoint(string actionTaken, decimal delta, decimal after)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileOutPath, true)) // Opens a file to write a log (or begins the file). Notes the date, action taken, the difference, and the new total
                {
                    writer.WriteLine($"{DateTime.Now} {actionTaken} {delta.ToString("C")} {after.ToString("C")}");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("No file or folder found." + ex.Message);
            }
        }

        public void LogBoard(List<List<int>> board)
        {

        }

        public void LogError(List<List<int>> board, int colorTry, int row, int column, string reason)
        {

        }
    }
}
