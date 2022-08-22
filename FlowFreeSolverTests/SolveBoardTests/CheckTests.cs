using FlowFreeSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FlowFreeSolverTests.SolveBoardTests
{
    [TestClass]
    public class CheckTests
    {
        SolveBoard _solver = new SolveBoard();

        List<List<int>> _startBoard = new List<List<int>>()
            {
                    new List<int>() { 1, 0, 2, 0, 3 },
                    new List<int>() { 0, 0, 4, 0, 5 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 2, 0, 3, 0 },
                    new List<int>() { 0, 1, 4, 5, 0 },
            };

        List<List<int>> _testBoard = new List<List<int>>()
            {
                    new List<int>() { 1, 2, 2, 3, 3 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 1, 4, 5, 5 },
            };

        List<List<int>> _testBoard1 = new List<List<int>>()
            {
                    new List<int>() { 1, 2, 2, 3, 3 },
                    new List<int>() { 1, 1, 4, 3, 5 }, // This errors as the first 1 has 3 cells adjacent to it as the same color
                    new List<int>() { 1, 2, 4, 3, 5 }, // Fails as of this one being submitted
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 1, 4, 5, 5 },
            };

        List<List<int>> _testBoard2 = new List<List<int>>()
            {
                    new List<int>() { 1, 2, 2, 3, 3 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 2, 3, 3, 5 },
                    new List<int>() { 1, 1, 4, 5, 5 }, // This errors as 4 is a starting point and doesn't have anything connected to it
            };

        List<List<int>> _testBoard3 = new List<List<int>>()
            {
                    new List<int>() { 1, 2, 2, 3, 3 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 2, 2, 3, 5 }, // This errors as the first 2 is a starting point and has two connections
                    new List<int>() { 1, 1, 4, 5, 5 },
            };

        List<List<int>> _testBoard4 = new List<List<int>>()
            {
                    new List<int>() { 1, 2, 2, 3, 3 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 2, 3, 3, 5 },
                    new List<int>() { 1, 1, 4, 5, 5 }, // This errors as 4 is a starting point and doesn't have anything connected to it
            };

        List<List<int>> _testBoard5 = new List<List<int>>()
            {
                    new List<int>() { 1, 4, 2, 2, 3 }, // This should error midway check due to 4 not being a starter and having 1 adjacent value OR 3 being a starter and not having an adjacent value
                    new List<int>() { 1, 4, 4, 2, 5 },
                    new List<int>() { 1, 2, 2, 3, 3 },
                    new List<int>() { 2, 2, 2, 3, 0 },
                    new List<int>() { 0, 1, 4, 5, 0 },
            };

        [TestMethod]
        public void MidWayCheckReturnsTrueIfNoErrorsFound()
        {
            bool actual = _solver.MidWayCheck(_testBoard, 2, 2, _startBoard);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void MidWayCheckReturnsFalseIfErrorFound()
        {
            bool actual1 = _solver.MidWayCheck(_testBoard1, 2, 0, _startBoard);
            bool actual2 = _solver.MidWayCheck(_testBoard2, 4, 3, _startBoard);

            Assert.IsFalse(actual1);
            Assert.IsFalse(actual2);
        }

        [TestMethod]
        public void FinalCheckReturnsTrueIfNoErrorsFound()
        {
            bool actual = _solver.FinalCheck(_testBoard, _startBoard);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void FinalCheckReturnsFalseIfErrorFound()
        {
            bool actual1 = _solver.FinalCheck(_testBoard1, _startBoard);
            bool actual2 = _solver.FinalCheck(_testBoard2, _startBoard);

            Assert.IsFalse(actual1);
            Assert.IsFalse(actual2);
        }

        [TestMethod]
        public void DoubleCheckBoardReturnsTrueIfNoErrorsFound()
        {
            bool midWay1 = _solver.DoubleCheckBoard(_testBoard, 2, 4, _startBoard);
            bool midWay2 = _solver.DoubleCheckBoard(_testBoard, 4, 4, _startBoard);

            Assert.IsTrue(midWay1);
            Assert.IsTrue(midWay2);
        }

        [TestMethod]
        public void DoubleCheckBoardReturnsFalseIfErrorFound()
        {
            bool midWay1 = _solver.DoubleCheckBoard(_testBoard1, 2, 2, _startBoard);
            bool final1 = _solver.DoubleCheckBoard(_testBoard1, 4, 4, _startBoard);

            Assert.IsFalse(midWay1);
            Assert.IsFalse(final1);
        }
    }
}