using FlowFreeSolver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowFreeSolver
{
    public class Program
    {
        private static PreMadeBoards _preMadeBoards = new PreMadeBoards();
        private static List<List<int>> _startBoard = _preMadeBoards.board1;

        private static int maxColor;

        static void Main()
        {
            SolveBoard solver = new SolveBoard();
            NewBoard _makeBoard = new NewBoard();

            //List<List<int>> startBoard = _makeBoard.MakeNewBoard();
            List<List<int>> newBoard = CopyBoard(_startBoard);

            maxColor = newBoard.Max(row => row.Max());

            if (solver.isBoardSolved(newBoard, _startBoard, maxColor))
            {
                PrintBoard(newBoard);
                Console.WriteLine("Solved!");
            }
            else
            {
                Console.WriteLine("Can't solve. Many apologies");
            }
        }

        public static List<List<int>> CopyBoard(List<List<int>> board)
        {
            List<List<int>> newBoard = new List<List<int>>();
            for (int row = 0; row < board.Count; row++)
            {
                List<int> newRow = new List<int>();
                for (int column = 0; column < board[0].Count; column++)
                {
                    newRow.Add(board[row][column]);
                }

                newBoard.Add(newRow);
            }

            return newBoard;
        }

        public static void PrintBoard(List<List<int>> board)
        {
            for (int row = 0; row < board.Count; row++)
            {
                for (int column = 0; column < board[0].Count; column++)
                {
                    Console.Write(board[row][column]);
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
