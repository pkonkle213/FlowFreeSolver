using System.Collections.Generic;
using FlowFreeSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlowFreeSolverTests
{
    [TestClass]
    public class MatchingTests
    {
        private static List<List<int>> _testBoard = new List<List<int>>()
            {
                new List<int>() { 1, 1, 1, 1 },
                new List<int>() { 1, 2, 2, 1 },
                new List<int>() { 1, 2, 2, 1 },
                new List<int>() { 1, 1, 1, 1 },
            };

        SolveBoard _solver = new SolveBoard(_testBoard);

        [TestMethod]
        [DataRow(1, 1, 0, true)]
        [DataRow(1, 1, 3, true)]
        [DataRow(1, 3, 3, true)]
        [DataRow(1, 0, 0, false)]
        [DataRow(2, 1, 1, false)]
        public void IsColorInBoxAbove_Returns_Right_Result(int colorTry, int row, int column, bool expected)
        {
            bool actual = _solver.IsColorInBoxAbove(_testBoard, colorTry, row, column);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(1, 0, 0, true)]
        [DataRow(1, 2, 3, true)]
        [DataRow(1, 3, 3, false)]
        [DataRow(2, 2, 1, false)]
        public void IsColorInBoxBelow_Returns_Right_Result(int colorTry, int row, int column, bool expected)
        {
            bool actual = _solver.IsColorInBoxBelow(_testBoard, colorTry, row, column);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(1, 0, 0, true)]
        [DataRow(2, 1, 1, true)]
        [DataRow(1, 1, 3, false)]
        [DataRow(1, 2, 0, false)]
        public void IsColorInBoxRight_Returns_Right_Result(int colorTry, int row, int column, bool expected)
        {
            bool actual = _solver.IsColorInBoxRight(_testBoard, colorTry, row, column);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(1, 0, 2, true)]
        [DataRow(2, 1, 2, true)]
        [DataRow(1, 1, 0, false)]
        [DataRow(1, 2, 2, false)]
        public void IsColorInBoxLeft_Returns_Right_Result(int colorTry, int row, int column, bool expected)
        {
            bool actual = _solver.IsColorInBoxLeft(_testBoard, colorTry, row, column);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(1, 1, 1, true)]
        [DataRow(2, 1, 1, false)]
        public void IsColorNW(int colorTry, int row, int column, bool expected)
        {
            bool actual = _solver.IsColorInBoxNW(_testBoard, colorTry, row, column);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(1, 2, 2, true)]
        [DataRow(2, 2, 2, false)]
        public void IsColorSE(int colorTry, int row, int column, bool expected)
        {
            bool actual = _solver.IsColorInBoxSE(_testBoard, colorTry, row, column);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(1, 2, 1, true)]
        [DataRow(2, 2, 1, false)]
        public void IsColorSW(int colorTry, int row, int column, bool expected)
        {
            bool actual = _solver.IsColorInBoxSW(_testBoard, colorTry, row, column);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(1, 1, 2, true)]
        [DataRow(2, 1, 2, false)]
        public void IsColorNE(int colorTry, int row, int column, bool expected)
        {
            bool actual = _solver.IsColorInBoxNE(_testBoard, colorTry, row, column);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(1, 0, 0, 2)]
        [DataRow(2, 1, 1, 3)]
        [DataRow(1, 0, 1, 2)]
        [DataRow(2, 2, 2, 3)]
        [DataRow(3, 2, 2, 0)]
        public void TotalMatchingIsAccurate(int colorTry, int row, int column, int expected)
        {
            int actual = _solver.MatchingAdjacentTiles(_testBoard, colorTry, row, column);

            Assert.AreEqual(expected, actual);
        }
    }
}