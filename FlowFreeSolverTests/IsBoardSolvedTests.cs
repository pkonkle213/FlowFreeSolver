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

        List<List<int>> _board1 = new List<List<int>>()
            {
                    new List<int>() { 1, 0, 2, 0, 3 },
                    new List<int>() { 0, 0, 4, 0, 5 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 2, 0, 3, 0 },
                    new List<int>() { 0, 1, 4, 5, 0 },
            };

        List<List<int>> _board2 = new List<List<int>>()
            {
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 2, 0, 3, 0 },
                    new List<int>() { 0, 0, 3, 0, 0 },
                    new List<int>() { 0, 0, 1, 0, 4 },
                    new List<int>() { 1, 2, 4, 0, 0 },
            };

        List<List<int>> _boardBlank = new List<List<int>>()
            {
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 0, 0, 0, 0 },
            };

        [TestMethod]
        public void isBoardSolvesReturnsTrueForSolvableBoards()
        {
            int maxColor1 = _board1.Max(row => row.Max());
            List<List<int>> cloneBoard1 = Program.CopyBoard(_board1);
            bool actual1 = _solver.isBoardSolved(_board1, cloneBoard1, maxColor1);
            
            int maxColor2 = _board2.Max(row => row.Max());
            List<List<int>> cloneBoard2 = Program.CopyBoard(_board2);
            bool actual2 = _solver.isBoardSolved(_board2, cloneBoard2, maxColor2);

            Assert.IsTrue(actual1);
            Assert.IsTrue(actual2); // WHY DOES THIS FAIL!?
        }
    }
}
