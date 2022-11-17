using FlowFreeSolver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowFreeSolver
{
    public class Program
    {
        private static PreMadeBoards _preMadeBoards = new PreMadeBoards();
        private static List<List<int>> _startBoard = _preMadeBoards.boardLOL;
        private static WriteBoard _writeBoard = new WriteBoard();

        static void Main()
        {
            List<List<int>> newBoard = CopyBoard(_startBoard);

            SolveBoard solver = new SolveBoard(_startBoard);

            if (solver.IsBoardSolved(newBoard))
            {
                _writeBoard.Peek(newBoard);
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
    }
}
