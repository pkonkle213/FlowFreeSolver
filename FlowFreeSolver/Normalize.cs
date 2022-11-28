using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

//This has yet to be implemented

namespace FlowFreeSolver
{
    public class Normalize
    {
        private List<int> _colors = new List<int>() { 0 };

        public List<List<int>> NormalizeBoard(List<List<int>> startBoard)
        {
            int maxColorStart = startBoard.Max(row => row.Max());

            for (int i = 1; i <= maxColorStart; i++)
            {
                bool present = false;

                foreach (List<int> row in startBoard)
                {
                    foreach (int number in row)
                    {
                        if (number == i)
                        {
                            present = true;
                        }
                    }
                }

                if (present)
                {
                    _colors.Add(i);
                }
            }

            List<List<int>> newBoard = new List<List<int>>();

            for (int r = 0; r < startBoard.Count; r++)
            {
                List<int> row = new List<int>();
                for (int c = 0; c < startBoard[0].Count; c++)
                {
                    for (int i = 0; i < _colors.Count; i++)
                    {
                        if (_colors[i] == startBoard[r][c])
                        {
                            row.Add(i);
                        }
                    }
                }

                newBoard.Add(row);
            }

            return newBoard;
        }

        public List<List<int>> DenomalizeBoard(List<List<int>> endBoard)
        {
            List<List<int>> board = new List<List<int>>();

            for (int r = 0; r < endBoard.Count; r++)
            {
                List<int> row = new List<int>();

                for (int c = 0; c < endBoard[0].Count; c++)
                {
                    row.Add(_colors[endBoard[r][c]]);
                }

                board.Add(row);
            }

            return board;
        }
    }
}
