using System;
using System.Collections.Generic;
using System.Text;

namespace FlowFreeSolver
{
    public class SolveBoard
    {
        public bool isBoardSolved(List<List<int>> board, List<List<int>> startBoard, int maxColor)
        {
            for (int row = 0; row < board.Count; row++)
            {
                for (int column = 0; column < board[0].Count; column++)
                {
                    if (board[row][column] == 0)
                    {
                        for (int colorTry = 1; colorTry <= maxColor; colorTry++)
                        {
                            if (isValidPlacement(board, colorTry, row, column, startBoard))
                            {
                                board[row][column] = colorTry;

                                if (isBoardSolved(board, startBoard, maxColor))
                                {
                                    return true;
                                }
                                else
                                {
                                    board[row][column] = 0;
                                }
                            }
                        }

                        return false;
                    }
                }
            }

            return true;
        }

        public bool isValidPlacement(List<List<int>> board, int colorTry, int row, int column, List<List<int>> startBoard)
        {
            return (MatchingAdjacentTiles(board, colorTry, row, column) < 3 && DoubleCheckBoard(board, row, column, startBoard));
        }

        public int MatchingAdjacentTiles(List<List<int>> board, int color, int row, int column)
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

        public bool DoubleCheckBoard(List<List<int>> board, int testRow, int testColumn, List<List<int>> startBoard)
        {
            if (testRow == board.Count - 1 && testColumn == board[0].Count - 1)
            {
                return FinalCheck(board, startBoard);
            }
            else
            {
                return MidWayCheck(board, testRow, testColumn, startBoard);
            }
        }

        public bool FinalCheck(List<List<int>> board, List<List<int>> startBoard)
        {
            for (int row = 0; row < board.Count; row++)
            {
                for (int column = 0; column < board[row].Count; column++)
                {
                    if (board[row][column] == startBoard[row][column] && MatchingAdjacentTiles(board, board[row][column], row, column) != 1)
                    {
                        return false;
                    }

                    if (board[row][column] != startBoard[row][column] && MatchingAdjacentTiles(board, board[row][column], row, column) != 2)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool MidWayCheck(List<List<int>> board, int testRow, int testColumn, List<List<int>> startBoard)
        {
            for (int row = 0; row < board.Count; row++)
            {
                for (int column = 0; column < board[row].Count; column++)
                {
                    if (row == testRow && column == testColumn)
                    {
                        return true;
                    }

                    if (board[row][column] == startBoard[row][column] && MatchingAdjacentTiles(board, board[row][column], row, column) > 1)
                    {
                        return false;
                    }

                    if (board[row][column] > 0 && MatchingAdjacentTiles(board, board[row][column], row, column) > 2)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
