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

        [TestMethod]
        public void isValidPlacementReturnsTrue()
        {

        }

        [TestMethod]
        public void isBoardSolvesReturnsTrueForSolvableBoards()
        {
            int maxColor1 = _boards.board1.Max(row => row.Max());
            List<List<int>> cloneBoard1 = Program.CopyBoard(_boards.board1);
            bool actual1 = _solver.isBoardSolved(_boards.board1, cloneBoard1, maxColor1);

            int maxColor2 = _boards.board2.Max(row => row.Max());
            List<List<int>> cloneBoard2 = Program.CopyBoard(_boards.board2);
            bool actual2 = _solver.isBoardSolved(_boards.board2, cloneBoard2, maxColor2);

            Assert.IsTrue(actual1);
            Assert.IsTrue(actual2);
        }
    }
}
