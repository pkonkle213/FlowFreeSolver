using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowFreeSolver
{
    public class SolveBoard
    {
        private int _maxColor;
        private List<List<int>> _startBoard;
        private static int _attempts = 0;

        public SolveBoard(int maxColor, List<List<int>> startBoard)
        {
            _maxColor = maxColor;
            _startBoard = startBoard;
        }

        public bool isBoardSolved(List<List<int>> board)
        {
            for (int row = 0; row < board.Count; row++)
            {
                for (int column = 0; column < board[0].Count; column++)
                {
                    if (board[row][column] == 0)
                    {
                        for (int colorTry = 1; colorTry <= _maxColor; colorTry++)
                        {
                            if (isValidPlacement(board, colorTry, row, column))
                            {
                                board[row][column] = colorTry;
                                _attempts++;
                                PrintBoard(board);

                                if (!DoubleCheckBoardIsValid(board))
                                {
                                    board[row][column] = 0;
                                    return false;
                                }

                                if (isBoardSolved(board))
                                {
                                    return true;
                                }
                                else
                                {
                                    board[row][column] = 0;
                                }
                            }
                        }
                    }
                }
            }

            return true;
        }

        public bool isValidPlacement(List<List<int>> board, int colorTry, int row, int column) // See later comment, may need to be in this validation
        {
            return (MatchingAdjacentTiles(board, colorTry, row, column) > 0 && MatchingAdjacentTiles(board, colorTry, row, column) < 3);
        }

        public int MatchingAdjacentTiles(List<List<int>> board, int color, int row, int column) // Needs to also be used to find adjacent 0s. R0:12233, R1:11435 should error
        {
            int correct = 0;

            if (isColorInBoxAbove(board, color, row, column))
            {
                correct++;
            }

            if (isColorInBoxBelow(board, color, row, column))
            {
                correct++;
            }

            if (isColorInBoxLeft(board, color, row, column))
            {
                correct++;
            }

            if (isColorInBoxRight(board, color, row, column))
            {
                correct++;
            }

            return correct;
        }

        public bool isColorInBoxAbove(List<List<int>> board, int color, int row, int column)
        {
            if (row == 0)
            {
                return false;
            }

            if (color == board[row - 1][column])
            {
                return true;
            }

            return false;
        }

        public bool isColorInBoxLeft(List<List<int>> board, int color, int row, int column)
        {
            if (column == 0)
            {
                return false;
            }

            if (color == board[row][column - 1])
            {
                return true;
            }

            return false;
        }

        public bool isColorInBoxBelow(List<List<int>> board, int color, int row, int column)
        {
            if (row + 1 == board.Count)
            {
                return false;
            }

            if (color == board[row + 1][column])
            {
                return true;
            }

            return false;
        }

        public bool isColorInBoxRight(List<List<int>> board, int color, int row, int column)
        {
            if (column + 1 == board[0].Count)
            {
                return false;
            }

            if (color == board[row][column + 1])
            {
                return true;
            }

            return false;
        }

        public bool DoubleCheckBoardIsValid(List<List<int>> board)
        {
            for (int row = 0; row < board.Count; row++)
            {
                for (int column = 0; column < board[row].Count; column++)
                {
                    if (board[row][column] > 0)
                    {
                        if (board.Min(row => row.Min()) > 0)
                        {
                            if (board[row][column] == _startBoard[row][column] && MatchingAdjacentTiles(board, board[row][column], row, column) != 1)
                            {
                                return false;
                            }

                            if (board[row][column] != _startBoard[row][column] && MatchingAdjacentTiles(board, board[row][column], row, column) != 2)
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (board[row][column] == _startBoard[row][column] && MatchingAdjacentTiles(board, board[row][column], row, column) > 1)
                            {
                                return false;
                            }

                            if (MatchingAdjacentTiles(board, board[row][column], row, column) > 2)
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
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

            Console.WriteLine(_attempts);

            //Console.WriteLine();
        }
    }
}
