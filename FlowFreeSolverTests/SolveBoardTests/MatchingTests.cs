using FlowFreeSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FlowFreeSolverTests.SolveBoardTests
{
    [TestClass]
    public class MatchingTests
    {
        private int _maxColor;

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
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            bool actual = solver.isColorInBoxAbove(_testBoard, colorTry, row, column);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        [DataRow(1, 0, 0)]
        [DataRow(0, 1, 1)]
        public void IsColorInBoxAboveReturnsFalseWhenNotMatching(int colorTry, int row, int column)
        {
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            bool actual = solver.isColorInBoxAbove(_testBoard, colorTry, row, column);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        [DataRow(1, 0, 2)]
        [DataRow(1, 1, 3)]
        public void IsColorInBoxBelowReturnsTrueWhenMatching(int colorTry, int row, int column)
        {
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            bool actual = solver.isColorInBoxBelow(_testBoard, colorTry, row, column);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(1, 2, 1)]
        public void IsColorInBoxBelowReturnsFalseWhenNotMatching(int colorTry, int row, int column)
        {
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            bool actual = solver.isColorInBoxBelow(_testBoard, colorTry, row, column);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        [DataRow(1, 0, 0)]
        [DataRow(1, 1, 2)]
        public void IsColorInBoxRightReturnsTrueWhenMatching(int colorTry, int row, int column)
        {
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            bool actual = solver.isColorInBoxRight(_testBoard, colorTry, row, column);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        [DataRow(1, 1, 4)]
        [DataRow(1, 2, 0)]
        public void IsColorInBoxRightReturnsFalseWhenNotMatching(int colorTry, int row, int column)
        {
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            bool actual = solver.isColorInBoxRight(_testBoard, colorTry, row, column);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        [DataRow(1, 0, 2)]
        [DataRow(1, 1, 3)]
        public void IsColorInBoxLeftReturnsTrueWhenMatching(int colorTry, int row, int column)
        {
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            bool actual = solver.isColorInBoxLeft(_testBoard, colorTry, row, column);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(1, 2, 1)]
        public void IsColorInBoxLeftReturnsFalseWhenNotMatching(int colorTry, int row, int column)
        {
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            bool actual = solver.isColorInBoxLeft(_testBoard, colorTry, row, column);

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
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            int actual = solver.MatchingAdjacentTiles(_testBoard, colorTry, row, column);

            Assert.AreEqual(expected, actual);
        }
    }
}