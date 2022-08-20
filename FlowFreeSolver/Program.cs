using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowSolver
{
    public class Program
    {
        private static List<List<int>> startBoard1 = new List<List<int>>()
        {
                    new List<int>() { 1, 0, 2, 0, 3 },
                    new List<int>() { 0, 0, 4, 0, 5 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 2, 0, 3, 0 },
                    new List<int>() { 0, 1, 4, 5, 0 },
        };

        private static List<List<int>> startBoard2 = new List<List<int>>()
        {
                    new List<int>() { 1, 0, 0, 0, 4 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 3, 2, 0, 0 },
                    new List<int>() { 0, 0, 1, 0, 0 },
                    new List<int>() { 2, 3, 4, 0, 0 },
        };

        private static List<List<int>> startBoard = startBoard1;

        private static int maxColor;

        static void Main()
        {
            SolveBoard solver = new SolveBoard();

            List<List<int>> newBoard = CopyBoard(startBoard);

            maxColor = newBoard.Max(row => row.Max());

            if (solver.isBoardSolved(newBoard, startBoard, maxColor))
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
