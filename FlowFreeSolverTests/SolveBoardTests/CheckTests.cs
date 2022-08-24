using FlowFreeSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FlowFreeSolverTests.SolveBoardTests
{
    [TestClass]
    public class CheckTests
    {
        private int _maxColor;

        List<List<int>> _startBoard = new List<List<int>>()
            {
                    new List<int>() { 1, 0, 2, 0, 3 },
                    new List<int>() { 0, 0, 4, 0, 5 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 2, 0, 3, 0 },
                    new List<int>() { 0, 1, 4, 5, 0 },
            };

        List<List<int>> _answerBoard = new List<List<int>>()
            {
                    new List<int>() { 1, 2, 2, 3, 3 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 1, 4, 5, 5 },
            };

        List<List<int>> _testBoard = new List<List<int>>()
            {
                    new List<int>() { 1, 2, 2, 3, 3 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 2, 4, 3, 0 },
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

        List<List<int>> _testBoard6 = new List<List<int>>()
            {
                    new List<int>() { 1, 1, 2, 2, 3 }, // This should error midway check due to 4 not being a starter and having 1 adjacent value OR 3 being a starter and not having an adjacent value
                    new List<int>() { 1, 0, 4, 0, 5 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 2, 0, 3, 0 },
                    new List<int>() { 0, 1, 4, 5, 0 },
            };

        List<List<int>> _testBoard7 = new List<List<int>>()
            {
                    new List<int>() { 1, 2, 2, 3, 3 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 4, 4, 5, 5 },
                    new List<int>() { 1, 2, 2, 3, 3 },
                    new List<int>() { 1, 1, 4, 5, 3 },
            };

        [TestMethod]
        public void DoubleCheckReturnsTrueIfNoErrorsFound()
        {
            _maxColor = _startBoard.Max(row => row.Max());
            SolveBoard solver = new SolveBoard(_maxColor, _startBoard);
            bool actual = solver.DoubleCheckBoardIsValid(_answerBoard);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void DoubleCheckReturnsFalseIfErrorFound()
        {
            _maxColor = _startBoard.Max(row => row.Max());

            SolveBoard solver1 = new SolveBoard(_maxColor, _startBoard);
            bool actual1 = solver1.DoubleCheckBoardIsValid(_testBoard1);

            SolveBoard solver2 = new SolveBoard(_maxColor, _startBoard);
            bool actual2 = solver2.DoubleCheckBoardIsValid(_testBoard2);

            SolveBoard solver3 = new SolveBoard(_maxColor, _startBoard);
            bool actual7 = solver3.DoubleCheckBoardIsValid(_testBoard7);

            Assert.IsFalse(actual1);
            Assert.IsFalse(actual2);
            Assert.IsFalse(actual7);
        }
    }
}