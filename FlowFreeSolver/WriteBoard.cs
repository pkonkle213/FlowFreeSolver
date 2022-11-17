using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowFreeSolver
{
    public class WriteBoard
    {
        public void Peek(List<List<int>> board)
        {
            int maxColor = board.Max(row => row.Max());
            int padding = Convert.ToInt32(Math.Floor(Math.Log(maxColor))) + 1;

            for (int row = 0; row < board.Count; row++)
            {
                for (int column = 0; column < board[0].Count; column++)
                {
                    Console.Write(board[row][column].ToString().PadLeft(padding));
                }

                Console.WriteLine();
            }

            for (int column = 0; column < board[0].Count; column++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
        }
    }
}
