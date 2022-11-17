using FlowFreeSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FlowFreeSolverTests.SolveBoardTests
{
    [TestClass]
    public class CheckTests
    {
        SolveBoard _solver = new SolveBoard(_startBoard);

        static List<List<int>> _startBoard = new List<List<int>>()
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

        List<List<int>> _testBoard1 = new List<List<int>>() // Fails final check due to (2,0)
            {
                    new List<int>() { 1, 2, 2, 3, 3 },
                    new List<int>() { 1, 1, 4, 3, 5 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 1, 4, 5, 5 },
            };

        List<List<int>> _testBoard2 = new List<List<int>>() // Passes midway check
            {
                    new List<int>() { 1, 2, 2, 3, 3 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 2, 0, 0, 0 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 0, 0, 0, 0 },
            };

        List<List<int>> _testBoard3 = new List<List<int>>() // Fails midway check due to (2,0)
            {
                    new List<int>() { 1, 2, 2, 3, 3 },
                    new List<int>() { 1, 1, 4, 3, 5 },
                    new List<int>() { 1, 2, 0, 0, 0 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 0, 0, 0, 0 },
            };

        List<List<int>> _testBoard4 = new List<List<int>>() // Fails final check due to (4,0)
            {
                    new List<int>() { 1, 2, 2, 3, 3 },
                    new List<int>() { 1, 2, 4, 3, 5 },
                    new List<int>() { 1, 4, 4, 5, 5 },
                    new List<int>() { 1, 2, 2, 3, 3 },
                    new List<int>() { 0, 1, 4, 5, 0 },
            };
    }
}