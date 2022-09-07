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
                new List<int>() { 1, 1, 1, 1 },
                new List<int>() { 1, 2, 2, 1 },
                new List<int>() { 1, 2, 2, 1 },
                new List<int>() { 1, 1, 1, 1 },
            };

        [TestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(1, 1, 3)]
        [DataRow(1, 3, 3)]
        public void IsColorInBoxAboveReturnsTrueWhenMatching(int colorTry, int row, int column)
        {
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            bool actual = solver.IsColorInBoxAbove(_testBoard, colorTry, row, column);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        [DataRow(1, 0, 0)]
        [DataRow(2, 1, 1)]
        public void IsColorInBoxAboveReturnsFalseWhenNotMatching(int colorTry, int row, int column)
        {
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            bool actual = solver.IsColorInBoxAbove(_testBoard, colorTry, row, column);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        [DataRow(1, 0, 0)]
        [DataRow(1, 2, 3)]
        public void IsColorInBoxBelowReturnsTrueWhenMatching(int colorTry, int row, int column)
        {
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            bool actual = solver.IsColorInBoxBelow(_testBoard, colorTry, row, column);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        [DataRow(1, 3, 3)]
        [DataRow(2, 2, 1)]
        public void IsColorInBoxBelowReturnsFalseWhenNotMatching(int colorTry, int row, int column)
        {
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            bool actual = solver.IsColorInBoxBelow(_testBoard, colorTry, row, column);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        [DataRow(1, 0, 0)]
        [DataRow(2, 1, 1)]
        public void IsColorInBoxRightReturnsTrueWhenMatching(int colorTry, int row, int column)
        {
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            bool actual = solver.IsColorInBoxRight(_testBoard, colorTry, row, column);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        [DataRow(1, 1, 3)]
        [DataRow(1, 2, 0)]
        public void IsColorInBoxRightReturnsFalseWhenNotMatching(int colorTry, int row, int column)
        {
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            bool actual = solver.IsColorInBoxRight(_testBoard, colorTry, row, column);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        [DataRow(1, 0, 2)]
        [DataRow(2, 1, 2)]
        public void IsColorInBoxLeftReturnsTrueWhenMatching(int colorTry, int row, int column)
        {
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            bool actual = solver.IsColorInBoxLeft(_testBoard, colorTry, row, column);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(1, 2, 2)]
        public void IsColorInBoxLeftReturnsFalseWhenNotMatching(int colorTry, int row, int column)
        {
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            bool actual = solver.IsColorInBoxLeft(_testBoard, colorTry, row, column);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        [DataRow(1, 0, 0, 2)]
        [DataRow(2, 1, 1, 3)]
        [DataRow(1, 0, 1, 2)]
        [DataRow(2, 2, 2, 3)]
        [DataRow(3, 2, 2, 0)]
        public void TotalMatchingIsAccurate(int colorTry, int row, int column, int expected)
        {
            _maxColor = _testBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _testBoard);

            int actual = solver.MatchingAdjacentTiles(_testBoard, colorTry, row, column);

            Assert.AreEqual(expected, actual);
        }
    }
}