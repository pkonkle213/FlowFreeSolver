using FlowFreeSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FlowFreeSolverTests.SolveBoardTests
{
    [TestClass]
    public class IsBoardSolvedTests
    {
        SolveBoard _solver = new SolveBoard();
        PreMadeBoards _boards = new PreMadeBoards();

        List<List<int>> _startBoard = new List<List<int>>()
            {
                    new List<int>() { 1, 0, 2, 0, 3 },
                    new List<int>() { 0, 0, 4, 0, 5 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 2, 0, 3, 0 },
                    new List<int>() { 0, 1, 4, 5, 0 },
            };

        List<List<int>> _testBoard1 = new List<List<int>>()
            {
                    new List<int>() { 1, 1, 2, 2, 3 }, // This should error midway check due to 4 not being a starter and having 1 adjacent value OR 3 being a starter and not having an adjacent value
                    new List<int>() { 0, 0, 4, 0, 5 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 2, 0, 3, 0 },
                    new List<int>() { 0, 1, 4, 5, 0 },
            };

        List<List<int>> _testBoard2 = new List<List<int>>()
            {
                    new List<int>() { 1, 2, 2, 3, 3 }, // This should error midway check due to 4 not being a starter and having 1 adjacent value OR 3 being a starter and not having an adjacent value
                    new List<int>() { 1, 0, 4, 0, 5 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 2, 0, 3, 0 },
                    new List<int>() { 0, 1, 4, 5, 0 },
            };

        [TestMethod]
        public void isValidPlacementReturnsTrueForValidPlacement()
        {
            bool actual1 = _solver.isValidPlacement(_testBoard2, 2, 1, 1, _startBoard);
            Assert.IsTrue(actual1);
        }

        [TestMethod]
        public void isValidPlacementReturnsFalseForInvalidPlacement()
        {
            bool actual1 = _solver.isValidPlacement(_testBoard1, 1, 1, 0, _startBoard);
            Assert.IsFalse(actual1);
        }

        [TestMethod]
        public void isBoardSolvesReturnsTrueForSolvableBoards()
        {
            int maxColor1 = _boards.board1.Max(row => row.Max());
            List<List<int>> cloneBoard1 = Program.CopyBoard(_boards.board1);
            bool actual1 = _solver.isBoardSolved(_boards.board1, cloneBoard1, maxColor1);
            Assert.IsTrue(actual1);

            int maxColor2 = _boards.board2.Max(row => row.Max());
            List<List<int>> cloneBoard2 = Program.CopyBoard(_boards.board2);
            bool actual2 = _solver.isBoardSolved(_boards.board2, cloneBoard2, maxColor2);
            Assert.IsTrue(actual2);

            int maxColor3 = _boards.board3.Max(row => row.Max());
            List<List<int>> cloneBoard3 = Program.CopyBoard(_boards.board3);
            bool actual3 = _solver.isBoardSolved(_boards.board3, cloneBoard3, maxColor3);
            Assert.IsTrue(actual3);
        }
    }
}
