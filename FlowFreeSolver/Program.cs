using FlowFreeSolver;
using FlowFreeSolver.FileWriter;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowFreeSolver
{
    public class Program
    {
        private static PreMadeBoards _preMadeBoards = new PreMadeBoards();
        private static List<List<int>> _startBoard = _preMadeBoards.board10;
        private static FileAccess fileWriter = new FileAccess();

        static void Main()
        {
            NewBoard _makeBoard = new NewBoard();
            fileWriter.ClearLog();

            //List<List<int>> startBoard = _makeBoard.MakeNewBoard();
            List<List<int>> newBoard = CopyBoard(_startBoard);

            SolveBoard solver = new SolveBoard(_startBoard);

            if (solver.IsBoardSolved(newBoard))
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
            int maxNumber = board.Max(row => row.Max());
            double logThing = Math.Log(maxNumber);
            int padding = Convert.ToInt32(Math.Floor(logThing)) + 1;

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
