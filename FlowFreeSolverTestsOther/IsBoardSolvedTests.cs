﻿using FlowFreeSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FlowFreeSolverTests.SolveBoardTests
{
    [TestClass]
    public class IsBoardSolvedTests
    {
        private PreMadeBoards _boards = new PreMadeBoards();

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
                    new List<int>() { 1, 1, 2, 2, 3 },
                    new List<int>() { 0, 1, 4, 0, 5 },
                    new List<int>() { 1, 0, 1, 0, 0 },
                    new List<int>() { 0, 2, 0, 3, 0 },
                    new List<int>() { 0, 1, 4, 5, 0 },
            };

        List<List<int>> _testBoard2 = new List<List<int>>()
            {
                    new List<int>() { 1, 2, 2, 3, 3 },
                    new List<int>() { 1, 0, 4, 0, 5 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 2, 0, 3, 0 },
                    new List<int>() { 0, 1, 4, 5, 0 },
            };

        [TestMethod]
        public void isValidPlacementReturnsTrueForValidPlacement()
        {
            SolveBoard solver = new SolveBoard(_startBoard);

            bool actual1 = solver.IsValidPlacement(_testBoard2, 2, 1, 1);
            
            Assert.IsTrue(actual1);
        }

        [TestMethod]
        public void isValidPlacementReturnsFalseForInvalidPlacement()
        {
            SolveBoard solver = new SolveBoard(_startBoard);

            bool actual1 = solver.IsValidPlacement(_testBoard1, 1, 2, 1);
            Assert.IsFalse(actual1);
            
            bool actual2 = solver.IsValidPlacement(_testBoard1, 1, 2, 4);
            Assert.IsFalse(actual2);
        }

        [TestMethod]
        public void isBoardSolvesReturnsTrueForSolveableBoards()
        {
            //SolveBoard solver1 = new SolveBoard(_boards.board1);
            //List<List<int>> cloneBoard1 = Program.CopyBoard(_boards.board1);
            //bool actual1 = solver1.IsBoardSolved(cloneBoard1);
            //Assert.IsTrue(actual1);
        }
    }
}