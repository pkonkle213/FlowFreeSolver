using FlowSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FlowSolverTests
{
    [TestClass]
    public class IsBoardSolvedTests
    {
        SolveBoard _solver = new SolveBoard();

        List<List<int>> _startBoard1 = new List<List<int>>()
            {
                    new List<int>() { 1, 0, 2, 0, 3 },
                    new List<int>() { 0, 0, 4, 0, 5 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 2, 0, 3, 0 },
                    new List<int>() { 0, 1, 4, 5, 0 },
            };

        [TestMethod]
        public void isBoardSolvesReturnsTrueForSolvableBoards()
        {
            int maxColor = _startBoard1.Max(row => row.Max());
            bool actual = _solver.isBoardSolved(_startBoard1, _startBoard1, maxColor);

            Assert.IsTrue(actual);
        }
    }
}
