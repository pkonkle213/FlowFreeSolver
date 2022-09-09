using FlowFreeSolver.FileWriter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace FlowFreeSolver
{
    public class SolveBoard
    {
        private FileAccess fileWriter = new FileAccess();
        private int _maxColor;
        private List<List<int>> _startBoard;
        private int _attempts;

        public SolveBoard(int maxColor, List<List<int>> startBoard)
        {
            _maxColor = maxColor;
            _startBoard = startBoard;
        }

        public bool IsBoardSolved(List<List<int>> board)
        {
            for (int row = 0; row < board.Count; row++)
            {
                for (int column = 0; column < board[0].Count; column++)
                {
                    if (board[row][column] == 0)
                    {
                        for (int colorTry = 1; colorTry <= _maxColor; colorTry++)
                        {
                            if (IsValidPlacement(board, colorTry, row, column))
                            {
                                LogBoard(board);

                                if (IsBoardSolved(board))
                                {
                                    return true;
                                }

                                board[row][column] = 0;

                                LogBoard(board);
                            }
                        }

                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsValidPlacement(List<List<int>> board, int colorTry, int row, int column)
        {
            board[row][column] = colorTry;

            if (DoubleCheckBoardIsValid(board))
            {
                return true;
            }

            board[row][column] = 0;
            return (false);
        }


        public int MatchingAdjacentTiles(List<List<int>> board, int color, int row, int column)
        {
            int correct = 0;
            bool left = IsColorInBoxLeft(board, color, row, column);
            bool right = IsColorInBoxRight(board, color, row, column);
            bool above = IsColorInBoxAbove(board, color, row, column);
            bool below = IsColorInBoxBelow(board, color, row, column);

            if (above)
            {
                correct++;
            }

            if (right)
            {
                correct++;
            }

            if (below)
            {
                correct++;
            }

            if (left)
            {
                correct++;
            }

            if (above && right && IsColorInBoxNE(board, color, row, column))
            {
                correct++;
            }

            if (below && right && IsColorInBoxSE(board, color, row, column))
            {
                correct++;
            }

            if (below && left && IsColorInBoxSW(board, color, row, column))
            {
                correct++;
            }

            if (above && left && IsColorInBoxNW(board, color, row, column))
            {
                correct++;
            }

            return correct;
        }

        public bool IsColorInBoxAbove(List<List<int>> board, int color, int row, int column)
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

        public bool IsColorInBoxNE(List<List<int>> board, int color, int row, int column)
        {
            if (row == 0 || column + 1 == board[row].Count)
            {
                return false;
            }

            if (color == board[row - 1][column + 1])
            {
                return true;
            }

            return false;
        }

        public bool IsColorInBoxRight(List<List<int>> board, int color, int row, int column)
        {
            if (column + 1 == board[row].Count)
            {
                return false;
            }

            if (color == board[row][column + 1])
            {
                return true;
            }

            return false;
        }

        public bool IsColorInBoxSE(List<List<int>> board, int color, int row, int column)
        {
            if (row + 1 == board.Count || column + 1 == board[row].Count)
            {
                return false;
            }

            if (color == board[row + 1][column + 1])
            {
                return true;
            }

            return false;
        }

        public bool IsColorInBoxBelow(List<List<int>> board, int color, int row, int column)
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

        public bool IsColorInBoxSW(List<List<int>> board, int color, int row, int column)
        {
            if (row + 1 == board.Count || column == 0)
            {
                return false;
            }

            if (color == board[row + 1][column - 1])
            {
                return true;
            }

            return false;
        }

        public bool IsColorInBoxLeft(List<List<int>> board, int color, int row, int column)
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

        public bool IsColorInBoxNW(List<List<int>> board, int color, int row, int column)
        {
            if (row == 0 || column == 0)
            {
                return false;
            }

            if (color == board[row - 1][column - 1])
            {
                return true;
            }

            return false;
        }

        public bool DoubleCheckBoardIsValid(List<List<int>> board)
        {
            if (board.Min(row => row.Min()) > 0)
            {
                return FinalCheck(board);
            }

            return MidwayCheck(board);
        }

        public bool FinalCheck(List<List<int>> board)
        {
            for (int row = 0; row < board.Count; row++)
            {
                for (int column = 0; column < board[row].Count; column++)
                {
                    if (board[row][column] == 0)
                    {
                        return false;
                    }

                    if (board[row][column] == _startBoard[row][column] && MatchingAdjacentTiles(board, board[row][column], row, column) != 1)
                    {
                        return false;
                    }

                    if (board[row][column] != _startBoard[row][column] && MatchingAdjacentTiles(board, board[row][column], row, column) != 2)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool MidwayCheck(List<List<int>> board)
        {
            for (int row = 0; row < board.Count; row++)
            {
                for (int column = 0; column < board[row].Count; column++)
                {
                    if (board[row][column] > 0)
                    {
                        if (NumberNeighboringZeros(board, row, column) == 0)
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

                        if (NeighboringColors(board, row, column).Max() != 0 && NeighboringColors(board, row, column).Contains(board[row][column]))
                        {
                            return false;
                        }

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

            return true;
        }

        private List<int> NeighboringColors(List<List<int>> board, int row, int column)
        {
            List<int> result = new List<int>()
            {
                ColorInBoxAbove(board,row,column),
                ColorInBoxRight(board,row,column),
                ColorInBoxBelow(board,row,column),
                ColorInBoxLeft(board,row,column)
            };

            return result;
        }

        private int ColorInBoxAbove(List<List<int>> board, int row, int column)
        {
            if (row == 0)
            {
                return 0;
            }

            return board[row - 1][column];
        }

        private int ColorInBoxRight(List<List<int>> board, int row, int column)
        {
            if (column == board[0].Count)
            {
                return 0;
            }

            return board[row][column + 1];
        }

        private int ColorInBoxBelow(List<List<int>> board, int row, int column)
        {
            if (row == board.Count)
            {
                return 0;
            }

            return board[row + 1][column];
        }

        private int ColorInBoxLeft(List<List<int>> board, int row, int column)
        {
            if (column == 0)
            {
                return 0;
            }

            return board[row][column - 1];
        }

        public int NumberNeighboringZeros(List<List<int>> board, int row, int column)
        {
            return MatchingAdjacentTiles(board, 0, row, column);
        }

        public void LogBoard(List<List<int>> board)
        {
            _attempts++;
            fileWriter.LogBoard(board, _attempts);
        }

        public void PrintBoard(List<List<int>> board)
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

            Console.WriteLine(_attempts++);
        }
    }
}
