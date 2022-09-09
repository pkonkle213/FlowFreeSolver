using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FlowFreeSolver.FileWriter
{
    public class FileAccess
    {
        //public string filePath = @"C:\FlowFreeSolver\FlowFreeSolver.csv";
        public string fileOutPath = @"C:\FlowFreeSolver\Log.txt";

        public void ClearLog()
        {
            using (var fs = File.Create(fileOutPath))
            {

            }
        }

        public void LogBoard(List<List<int>> board, int attempts)
        {
            int maxNumber = board.Max(row => row.Max());
            double logThing = Math.Log(maxNumber);
            int padding = Convert.ToInt32(Math.Floor(logThing)) + 1;

            try
            {
                using (StreamWriter writer = new StreamWriter(fileOutPath, true))
                {
                    writer.WriteLine($"Attempt #{attempts}");

                    foreach (List<int> row in board)
                    {
                        string rowWriter = BuildRowWriter(row, padding);
                        writer.WriteLine(rowWriter);
                    }

                    for(int i = 0; i < board[0].Count * padding; i++)
                    {
                        writer.Write("-");
                    }

                    writer.WriteLine();
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("No file or folder found. " + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Could not find the folder. " + ex.Message);
            }
        }

        private string BuildRowWriter(List<int> row, int padding)
        {
            string rowString = "";

            for (int i = 0; i < row.Count - 1; i++)
            {
                rowString += row[i].ToString().PadLeft(padding);
            }

            rowString += row[row.Count - 1].ToString().PadLeft(padding);

            return rowString;
        }

        public void LogError(List<List<int>> board, int colorTry, int row, int column, string reason)
        {

        }
    }
}
