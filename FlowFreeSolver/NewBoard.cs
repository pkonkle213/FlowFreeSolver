using System;
using System.Collections.Generic;

namespace FlowSolver
{
    public class NewBoard
    {
        // This is all thought, no testing, and not implemented yet

        List<List<int>> board = new List<List<int>>();

        public List<List<int>> MakeNewBoard()
        {
            Console.Clear();
            int width = Size("Width");
            int height = Size("Height");
            board = MakeBoard(width, height);
            GetSpots(board);

            List<List<int>> newBoard = new List<List<int>>();
            return newBoard;
        }

        public List<List<int>> MakeBoard(int width, int height)
        {
            List<List<int>> newBoard = new List<List<int>>();
            for (int row = 0; row < height; row++)
            {
                List<int> newRow = new List<int>();
                for (int column = 0; column < board[0].Count; column++)
                {
                    newRow.Add(0);
                }

                newBoard.Add(newRow);
            }
            return newBoard;
        }

        public void GetSpots(List<List<int>> newBoard)
        {
        }

        public int Size(string side)
        {
            int length = 0;

            while (length == 0)
            {
                Console.Write($"{side}: ");
                string widthString = Console.ReadLine();
                try
                {
                    length = int.Parse(widthString);
                    if (length < 1)
                    {
                        length = 0;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid integer greater than 1.");
                }
            }

            return length;
        }
    }
}
