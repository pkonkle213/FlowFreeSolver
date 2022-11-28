using System;
using System.Collections.Generic;
using System.Text;
using FlowFreeSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlowFreeSolverTests
{
    [TestClass]
    public class NormalizeTests
    {
        private Normalize _normalize = new Normalize();

        [TestMethod]
        public void DoesNormalizeAdjustTableCorrectly()
        {
            List<List<int>> newBoard = _normalize.NormalizeBoard(_startBoard);

            Assert.AreEqual(newBoard.Count,_normalizedBoard.Count);
            Assert.AreEqual(newBoard[0].Count,_normalizedBoard[0].Count);
            
            for (int row = 0; row < newBoard.Count; row++)
            {
                for (int column = 0; column < newBoard[0].Count;column++)
                {
                    Assert.AreEqual(newBoard[row][column],_normalizedBoard[row][column]);
                }
            }
        }

        [TestMethod]
        public void DoesDenormalizeAdjustTableCorrectly()
        {
            List<List<int>> newBoard = _normalize.NormalizeBoard(_startBoard);
            List<List<int>> denormal = _normalize.DenomalizeBoard(_completedBoard);

            Assert.AreEqual(denormal.Count, _denormalizedBoard.Count);
            Assert.AreEqual(denormal[0].Count, _denormalizedBoard[0].Count);

            for (int row = 0; row < newBoard.Count; row++)
            {
                for (int column = 0; column < newBoard[0].Count; column++)
                {
                    Assert.AreEqual(denormal[row][column], _denormalizedBoard[row][column]);
                }
            }
        }

        public List<List<int>> _startBoard = new List<List<int>>()
        {
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 10, 0, 7, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 7, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 9, 0, 0, 0, 0, 0 },
            new List<int>() { 9, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 10, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0 },
            new List<int>() { 0, 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 5, 1, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0 },
        };

        public List<List<int>> _normalizedBoard = new List<List<int>>()
        {
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 9, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 6, 0, 0, 0, 0, 7, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0 },
            new List<int>() { 8, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 9, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0 },
            new List<int>() { 0, 0, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 5, 1, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0 },
        };

        public List<List<int>> _completedBoard = new List<List<int>>()
        {
            new List<int>() { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
            new List<int>() { 2, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 2 },
            new List<int>() { 2, 9, 6, 6, 3, 3, 3, 3, 3, 3, 9, 2 },
            new List<int>() { 2, 6, 6, 3, 3, 2, 2, 2, 2, 3, 9, 2 },
            new List<int>() { 2, 6, 2, 2, 2, 2, 7, 7, 2, 3, 9, 2 },
            new List<int>() { 2, 2, 2, 8, 8, 8, 8, 7, 2, 3, 9, 2 },
            new List<int>() { 8, 8, 8, 8, 4, 4, 7, 7, 2, 3, 9, 2 },
            new List<int>() { 4, 4, 4, 4, 4, 3, 7, 2, 2, 3, 9, 2 },
            new List<int>() { 4, 3, 3, 3, 3, 3, 7, 2, 3, 3, 9, 2 },
            new List<int>() { 4, 3, 7, 7, 7, 7, 7, 3, 3, 1, 1, 2 },
            new List<int>() { 4, 3, 7, 3, 3, 3, 3, 3, 4, 4, 1, 2 },
            new List<int>() { 4, 3, 7, 3, 4, 4, 4, 4, 4, 5, 1, 2 },
            new List<int>() { 4, 3, 7, 3, 4, 5, 5, 5, 5, 5, 1, 2 },
            new List<int>() { 4, 3, 3, 3, 4, 5, 1, 1, 1, 1, 1, 2 },
            new List<int>() { 4, 4, 4, 4, 4, 2, 2, 2, 2, 2, 2, 2 },
        };

        public List<List<int>> _denormalizedBoard = new List<List<int>>()
        {
            new List<int>() { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
            new List<int>() { 2, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 2 },
            new List<int>() { 2, 10, 7, 7, 3, 3, 3, 3, 3, 3, 10, 2 },
            new List<int>() { 2, 7, 7, 3, 3, 2, 2, 2, 2, 3, 10, 2 },
            new List<int>() { 2, 7, 2, 2, 2, 2, 8, 8, 2, 3, 10, 2 },
            new List<int>() { 2, 2, 2, 9, 9, 9, 9, 8, 2, 3, 10, 2 },
            new List<int>() { 9, 9, 9, 9, 4, 4, 8, 8, 2, 3, 10, 2 },
            new List<int>() { 4, 4, 4, 4, 4, 3, 8, 2, 2, 3, 10, 2 },
            new List<int>() { 4, 3, 3, 3, 3, 3, 8, 2, 3, 3, 10, 2 },
            new List<int>() { 4, 3, 8, 8, 8, 8, 8, 3, 3, 1, 1, 2 },
            new List<int>() { 4, 3, 8, 3, 3, 3, 3, 3, 4, 4, 1, 2 },
            new List<int>() { 4, 3, 8, 3, 4, 4, 4, 4, 4, 5, 1, 2 },
            new List<int>() { 4, 3, 8, 3, 4, 5, 5, 5, 5, 5, 1, 2 },
            new List<int>() { 4, 3, 3, 3, 4, 5, 1, 1, 1, 1, 1, 2 },
            new List<int>() { 4, 4, 4, 4, 4, 2, 2, 2, 2, 2, 2, 2 },
        };
    }
}
