using System;
using System.Collections.Generic;
using System.Text;

namespace FlowFreeSolver.FileWriter
{
    public class Logger
    {
        FileAccess writer = new FileAccess();

        public void LogBoard(List<List<int>> board)
        {
            writer.LogBoard(board);
        }
    }
}
