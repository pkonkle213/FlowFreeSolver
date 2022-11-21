using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FlowFreeSolver
{
    public class Normalize
    {
        public List<List<int>> NormalizeBoard(List<List<int>> startBoard)
        {
            int maxColorStart = startBoard.Max(row => row.Max());
            List<int> colors = new List<int>();
            List<int> colorsFull = new List<int>();

            for (int i = 1; i <= maxColorStart; i++)
            {
                int quantity = 0;
                colorsFull.Add(i);

                foreach (List<int> row in startBoard)
                {
                    foreach (int number in row)
                    {
                        if (number == i)
                        {
                            quantity++;
                        }
                    }
                }

                if (quantity != 0)
                {
                    colors.Add(i);
                }
            }

            List<List<int>> newBoard = new List<List<int>>();

            for (int r = 0; r < startBoard.Count; r++)
            {
                for(int c = 0; c < startBoard[0].Count; c++)
                {

                }
            }

            return newBoard;
        }
    }
}
