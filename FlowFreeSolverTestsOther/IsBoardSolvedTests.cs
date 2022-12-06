using System.Collections.Generic;
using FlowFreeSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace FlowFreeSolverTests
{
    [TestClass]
    public class IsBoardSolvedTests
    {
        private PreMadeBoards _boards = new PreMadeBoards();

        [TestCaseSource(nameof(SuccessfulBoards))]
        [TestMethod]
        public void IsBoardSolvesReturnsTrueForSolveableBoards(List<List<int>> board)
        {

        }

        private IEnumerable<TestCaseData> SuccessfulBoards
        {
            get
            {
                yield return new TestCaseData(_boards.boardExtreme2_30_12x12_7);
            }
        }
    }
}
