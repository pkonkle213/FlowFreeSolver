﻿using FlowSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FlowSolverTests
{
    [TestClass]
    public class MatchingTests
    {
        SolveBoard _solver = new SolveBoard();
        List<List<int>> _testBoard = new List<List<int>>()
            {
                new List<int>() { 1, 1, 1, 1, 1 },
                new List<int>() { 0, 0, 1, 1, 1 },
                new List<int>() { 0, 0, 1, 1, 1 },
            };

        [TestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(1, 1, 1)]
        public void IsColorInBoxAboveReturnsTrueWhenMatching(int colorTry, int row, int column)
        {
            bool actual = _solver.isColorInBoxAbove(_testBoard, colorTry, row, column);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        [DataRow(1, 0, 0)]
        [DataRow(0, 1, 1)]
        public void IsColorInBoxAboveReturnsFalseWhenNotMatching(int colorTry, int row, int column)
        {
            bool actual = _solver.isColorInBoxAbove(_testBoard, colorTry, row, column);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        [DataRow(1, 0, 2)]
        [DataRow(1, 1, 3)]
        public void IsColorInBoxBelowReturnsTrueWhenMatching(int colorTry, int row, int column)
        {
            bool actual = _solver.isColorInBoxBelow(_testBoard, colorTry, row, column);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(1, 2, 1)]
        public void IsColorInBoxBelowReturnsFalseWhenNotMatching(int colorTry, int row, int column)
        {
            bool actual = _solver.isColorInBoxBelow(_testBoard, colorTry, row, column);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        [DataRow(1, 0, 0)]
        [DataRow(1, 1, 2)]
        public void IsColorInBoxRightReturnsTrueWhenMatching(int colorTry, int row, int column)
        {
            bool actual = _solver.isColorInBoxRight(_testBoard, colorTry, row, column);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        [DataRow(1, 1, 4)]
        [DataRow(1, 2, 0)]
        public void IsColorInBoxRightReturnsFalseWhenNotMatching(int colorTry, int row, int column)
        {
            bool actual = _solver.isColorInBoxRight(_testBoard, colorTry, row, column);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        [DataRow(1, 0, 2)]
        [DataRow(1, 1, 3)]
        public void IsColorInBoxLeftReturnsTrueWhenMatching(int colorTry, int row, int column)
        {
            bool actual = _solver.isColorInBoxLeft(_testBoard, colorTry, row, column);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(1, 2, 1)]
        public void IsColorInBoxLeftReturnsFalseWhenNotMatching(int colorTry, int row, int column)
        {
            bool actual = _solver.isColorInBoxLeft(_testBoard, colorTry, row, column);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        [DataRow(1, 2, 0, 0)]
        [DataRow(1, 0, 0, 1)]
        [DataRow(1, 0, 1, 2)]
        [DataRow(1, 1, 4, 3)]
        [DataRow(1, 1, 3, 4)]
        public void TotalMatchingIsAccurate(int colorTry, int row, int column, int expected)
        {
            int actual = _solver.MatchingAdjacentTiles(_testBoard, colorTry, row, column);

            Assert.AreEqual(expected, actual);
        }
    }
}