using FlowFreeSolver.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowFreeSolver
{
    public class SolveBoard
    {
        private static WriteBoard _writeBoard = new WriteBoard();
        private int _maxColor;
        private List<List<int>> _startBoard;
        private int _attempts;


        public SolveBoard(List<List<int>> startBoard)
        {
            _startBoard = startBoard;
            _maxColor = _startBoard.Max(row => row.Max());
        }

        public Answer SolveThisBoard(List<List<int>> board)
        {
            Answer answer = new Answer();
            if (IsBoardSolved(board))
            {
                answer.Board = board;
                answer.Attempts = _attempts;
                answer.IsSolvable = true;
            }
            else
            {
                answer.IsSolvable = false;
            }

            return answer;
        }

        public bool IsBoardSolved(List<List<int>> board)
        {
            for (var row = 0; row < board.Count; row++)
            {
                for (var column = 0; column < board[0].Count; column++)
                {
                    if (board[row][column] == 0)
                    {
                        for (var colorTry = 1; colorTry <= _maxColor; colorTry++)
                        {
                            if (IsValidPlacement(board, colorTry, row, column))
                            {
                                Peek(board);

                                if (IsBoardSolved(board))
                                {
                                    return true;
                                }

                                board[row][column] = 0;
                            }
                        }

                        return false;
                    }
                }
            }

            Peek(board);
            return true;
        }

        private void Peek(List<List<int>> board)
        {
            _attempts++;
            if (_attempts % 1000 == 0)
            {
                Console.WriteLine(_attempts);
                _writeBoard.Peek(board);
            }
        }

        public bool IsValidPlacement(List<List<int>> board, int colorTry, int row, int column)
        {
            board[row][column] = colorTry;

            if (DoubleCheckBoardIsValid(board))
            {
                return true;
            }

            board[row][column] = 0;
            return false;
        }

        public int MatchingAdjacentTiles(List<List<int>> board, int color, int row, int column)
        {
            var correct = 0;
            var left = IsColorInBoxLeft(board, color, row, column);
            var right = IsColorInBoxRight(board, color, row, column);
            var above = IsColorInBoxAbove(board, color, row, column);
            var below = IsColorInBoxBelow(board, color, row, column);

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
            for (var row = 0; row < board.Count; row++)
            {
                for (var column = 0; column < board[row].Count; column++)
                {
                    if (board[row][column] > 0)
                    {
                        if (NumberNeighboringZeros(board, row, column) == 0)
                        {
                            if (board[row][column] == _startBoard[row][column] &&
                                MatchingAdjacentTiles(board, board[row][column], row, column) != 1)
                            {
                                return false;
                            }

                            if (board[row][column] != _startBoard[row][column] &&
                                MatchingAdjacentTiles(board, board[row][column], row, column) != 2)
                            {
                                return false;
                            }
                        }

                        if (board[row][column] != _startBoard[row][column] &&
                            NumberNeighboringZeros(board, row, column) == 1 &&
                            MatchingAdjacentTiles(board, board[row][column], row, column) == 0)
                        {
                            return false;
                        }

                        if (board[row][column] == _startBoard[row][column] &&
                            MatchingAdjacentTiles(board, board[row][column], row, column) > 1)
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

        public int NumberNeighboringZeros(List<List<int>> board, int row, int column)
        {
            return MatchingAdjacentTiles(board, 0, row, column);
        }
    }
}