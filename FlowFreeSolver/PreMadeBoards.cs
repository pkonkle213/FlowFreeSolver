using System;
using System.Collections.Generic;
using System.Text;

namespace FlowFreeSolver
{
    public class PreMadeBoards
    {
        public List<List<int>> boardCustom = new List<List<int>>()
        {
            new List<int>() {2,5,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,7,10,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,1,0,0,0,0},
            new List<int>() {0,0,4,3,9,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,3,9,11,0,0,0,0,5},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,4,0,6,0,8,0,0,0,10,0},
            new List<int>() {0,0,2,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,7,11,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,8,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,1,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0,6},
        };
        
        public List<List<int>> boardHard2 = new List<List<int>>() // Solved in 11,498,000
        {
            new List<int>() {0,0,0,0,0,0,0,0,1,0,0,0},
            new List<int>() {0,2,3,4,0,0,0,0,0,0,5,0},
            new List<int>() {0,0,0,0,0,6,0,0,0,0,7,1},
            new List<int>() {0,0,0,0,0,0,8,0,0,0,9,10},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,11,0,0,0,0,0,0,0,0,0,12},
            new List<int>() {11,0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,13,0,0,0,0,4,0,0,10,0},
            new List<int>() {0,13,0,0,0,0,0,0,0,0,12,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {2,5,0,6,0,3,0,0,0,0,7,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,8,9,0},
        };
        
        public List<List<int>> boardHard1 = new List<List<int>>() // Solves in 27,000
        {
            new List<int>() {0,0,0,0,0,0,0,0,2,0,0,0},
            new List<int>() {0,3,4,13,0,0,0,0,0,0,1,0},
            new List<int>() {0,0,0,0,0,5,0,0,0,0,6,2},
            new List<int>() {0,0,0,0,0,0,7,0,0,0,8,9},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,10,0,0,0,0,0,0,0,0,0,11},
            new List<int>() {10,0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,12,0,0,0,0,13,0,0,9,0},
            new List<int>() {0,12,0,0,0,0,0,0,0,0,11,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {3,1,0,5,0,4,0,0,0,0,6,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,7,8,0},
        };
        
        public List<List<int>> boardTheory3 = new List<List<int>>() //  Putting lower numbers in the top left hand corner - Not solved past 1,000,000
        {
            new List<int>() {0,0,0,0,0,0,0,0,7,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,1,0,0,0,0,5,0,0},
            new List<int>() {0,0,0,0,2,0,0,0,0,0},
            new List<int>() {0,0,1,0,0,0,0,0,0,0},
            new List<int>() {0,0,3,0,0,0,0,6,4,0},
            new List<int>() {0,0,0,0,0,4,0,0,0,0},
            new List<int>() {0,0,2,6,0,0,0,7,5,3},
            new List<int>() {0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0},
        };
        
        public List<List<int>> boardTheory1 = new List<List<int>>() // Putting lower numbers around the outside - Solved at 94,459 - Warning: switching 1 and 2 will result in no solution past 1m
        {
            new List<int>() {0,0,0,0,0,0,0,0,2,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,5,0,0,0,0,3,0,0},
            new List<int>() {0,0,0,0,6,0,0,0,0,0},
            new List<int>() {0,0,5,0,0,0,0,0,0,0},
            new List<int>() {0,0,1,0,0,0,0,7,4,0},
            new List<int>() {0,0,0,0,0,4,0,0,0,0},
            new List<int>() {0,0,6,7,0,0,0,2,3,1},
            new List<int>() {0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0},
        };
        
        public List<List<int>> boardTheory2 = new List<List<int>>() // Wasn't solved after 40 million
        {
            new List<int>() {0,0,0,0,0,0,0,0,6,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,4,0,0,0,0,3,0,0},
            new List<int>() {0,0,0,0,1,0,0,0,0,0},
            new List<int>() {0,0,4,0,0,0,0,0,0,0},
            new List<int>() {0,0,7,0,0,0,0,2,5,0},
            new List<int>() {0,0,0,0,0,5,0,0,0,0},
            new List<int>() {0,0,1,2,0,0,0,6,3,7},
            new List<int>() {0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0},
        };

        public List<List<int>> board1 = new List<List<int>>() // Solves in 16
        {
            new List<int>() { 1, 0, 2, 0, 3 },
            new List<int>() { 0, 0, 4, 0, 5 },
            new List<int>() { 0, 0, 0, 0, 0 },
            new List<int>() { 0, 2, 0, 3, 0 },
            new List<int>() { 0, 1, 4, 5, 0 },
        };

        public List<List<int>> board2 = new List<List<int>>() // Solves in 16
        {
            new List<int>() { 1, 0, 0, 0, 4 },
            new List<int>() { 0, 0, 0, 0, 0 },
            new List<int>() { 0, 3, 2, 0, 0 },
            new List<int>() { 0, 0, 1, 0, 0 },
            new List<int>() { 2, 3, 4, 0, 0 },
        };

        public List<List<int>> board3 = new List<List<int>>() // Solves in 606
        {
            new List<int>() { 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 1, 3, 0 },
            new List<int>() { 2, 0, 0, 2, 0 },
            new List<int>() { 3, 0, 0, 0, 1 },
        };

        public List<List<int>> board4 = new List<List<int>>() // Solves in 53
        {
            new List<int>() { 1, 0, 2, 0, 0, 0 },
            new List<int>() { 3, 0, 0, 0, 5, 0 },
            new List<int>() { 0, 0, 4, 1, 0, 0 },
            new List<int>() { 0, 0, 2, 0, 5, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 3, 0, 0, 0, 4 },
        };

        public List<List<int>> board5 = new List<List<int>>() // Solves in 
        {
            new List<int>() { 1, 0, 2, 0, 0, 0 },
            new List<int>() { 3, 0, 0, 0, 5, 0 },
            new List<int>() { 0, 0, 4, 1, 0, 0 },
            new List<int>() { 0, 0, 2, 0, 5, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 3, 0, 0, 0, 4 },
        };

        public List<List<int>> board6 = new List<List<int>>() // Solves in 33088
        {
            new List<int>() {0,1,0,2,0,0,0,4,0},
            new List<int>() {0,0,0,0,0,3,0,5,0},
            new List<int>() {0,2,1,0,0,0,6,0,0},
            new List<int>() {0,0,0,6,0,0,0,0,0},
            new List<int>() {9,0,9,3,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,7},
            new List<int>() {0,4,0,0,0,0,0,0,8},
            new List<int>() {0,0,0,5,7,0,0,0,0},
            new List<int>() {8,0,0,0,0,0,0,0,0},
        };

        public List<List<int>> board7 = new List<List<int>>() // Solves in 133
        {
            new List<int>() {0,5,0,0,0,0},
            new List<int>() {0,4,1,0,3,1},
            new List<int>() {0,0,0,0,0,4},
            new List<int>() {0,0,0,3,0,2},
            new List<int>() {2,5,0,0,0,0},
            new List<int>() {0,0,0,0,0,0},
        };

        public List<List<int>> board8 = new List<List<int>>() // Solves in 1958975
        {
            new List<int>() {2,0,0,0,0,0,0,0,0,0},
            new List<int>() {10,0,0,10,9,0,0,0,0,0},
            new List<int>() {0,0,0,5,0,0,0,0,0,0},
            new List<int>() {0,3,0,3,8,9,0,0,0,0},
            new List<int>() {0,0,0,0,4,0,0,0,0,0},
            new List<int>() {0,0,1,0,0,4,0,0,0,0},
            new List<int>() {0,0,0,1,0,0,0,8,0,0},
            new List<int>() {0,0,0,6,7,0,0,0,0,0},
            new List<int>() {0,0,0,5,0,0,2,0,0,0},
            new List<int>() {7,0,0,0,0,0,0,0,0,6},
        };

        public List<List<int>> board9 = new List<List<int>>() // Solves in 1958975
        {
            new List<int>() {0,0,0,0,0,0,0,0,0,0,1,0,0,11},
            new List<int>() {0,3,0,0,0,0,0,0,2,0,8,6,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,5,0,0,0,0,0},
            new List<int>() {0,0,11,0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,1,0,6,0,0},
            new List<int>() {0,0,0,0,0,2,5,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,4,0,0,0,0,0,9,0,0},
            new List<int>() {0,0,0,0,0,0,0,3,0,0,0,0,0,0},
            new List<int>() {0,0,0,9,0,0,0,0,7,0,0,8,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {4,0,0,7,0,10,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0,0,0,10},
        };

        public List<List<int>> board10 = new List<List<int>>()
        {
            new List<int>() {0,0,0,0,0,0,0,3,0,0,0},
            new List<int>() {0,0,0,0,7,2,0,0,0,0,0},
            new List<int>() {0,0,1,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,5,0,0,0,0,0},
            new List<int>() {0,0,0,4,0,0,0,7,2,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,6,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,1,8,0,0,8,0,0},
            new List<int>() {0,0,6,0,0,0,0,0,0,0,4},
            new List<int>() {0,0,0,0,0,0,0,0,0,0,0},
            new List<int>() {0,0,0,0,0,0,0,0,0,5,3},
        };

        public List<List<int>> boardHard = new List<List<int>>()
        {
            new List<int>() { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 4, 0, 0, 0, 0, 0, 0, 4, 0, 0 },
            new List<int>() { 0, 2, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 6, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 7, 0, 0, 0, 0, 0, 0, 0, 0,11 },
            new List<int>() { 0, 0, 0, 0, 0, 8, 0, 9,11, 0, 0,12 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0,10, 0, 0, 0, 0 },
            new List<int>() { 0, 3, 0, 0, 0, 8, 0, 0, 0, 5, 0, 0 },
            new List<int>() { 0, 7, 0, 0, 6, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 1, 2, 0, 0, 0, 0, 0, 0, 0,13,14, 0 },
            new List<int>() {10, 9, 0, 0, 0, 0, 0,13, 0,14, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0,12, 0, 0, 0, 0, 0 },
        };

        public List<List<int>> boardLOL = new List<List<int>>() //Doesn't solve right
        {
            new List<int>() { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0 },
            new List<int>() { 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0 },
            new List<int>() { 4, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() {-1,-1,-1,-1,-1,-1, 0,-1,-1,-1,-1,-1,-1 },
            new List<int>() { 3, 6, 0, 9, 8, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0,10, 0, 0, 0, 0, 0, 0, 9, 0, 0 },
            new List<int>() { 0, 0, 6, 0, 0,10, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0,11, 0,11, 7, 0, 0 },
            new List<int>() { 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        };
    }
}
