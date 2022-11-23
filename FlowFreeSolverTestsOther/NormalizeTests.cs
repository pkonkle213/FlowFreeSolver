﻿using System;
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

        public List<List<int>> _startBoard = new List<List<int>>()
        {
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 7, 3, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 10, 0, 8, 11, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 5, 0, 0, 0, 0, 0, 8, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 3, 1, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 5, 0, 10, 0, 0 },
            new List<int>() { 0, 0, 11, 0, 0, 0, 0, 7, 0, 0, 0, 0 },
        };

        public List<List<int>> _normalizedBoard = new List<List<int>>()
        {
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 5, 2, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 7, 0, 6, 8, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 4, 0, 0, 0, 0, 0, 6, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 4, 0, 7, 0, 0 },
            new List<int>() { 0, 0, 8, 0, 0, 0, 0, 5, 0, 0, 0, 0 },
        };
    }
}
