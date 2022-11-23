using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

//This has yet to be implemented

namespace FlowFreeSolver
{
    public class Normalize
    {
        public List<List<int>> NormalizeBoard(List<List<int>> startBoard)
        {
            int maxColorStart = startBoard.Max(row => row.Max());
            List<int> colors = new List<int>() { 0 };

            for (int i = 1; i <= maxColorStart; i++)
            {
                bool present = false;

                foreach (List<int> row in startBoard)
                {
                    foreach (int number in row)
                    {
                        if (number == i)
                        {
                            present = true;
                        }
                    }
                }

                if (present)
                {
                    colors.Add(i);
                }
            }

            List<List<int>> newBoard = new List<List<int>>();

            for (int r = 0; r < startBoard.Count; r++)
            {
                List<int> row = new List<int>();
                for (int c = 0; c < startBoard[0].Count; c++)
                {
                    for(int i=0;i<colors.Count;i++)
                    {
                        if (colors[i] == startBoard[r][c])
                        {
                           row.Add(i);
                        }
                    }
                }

                newBoard.Add(row);
            }

            return newBoard;
        }
    }
}
