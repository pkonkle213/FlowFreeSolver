﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FlowFreeSolver
{
    public class PreMadeBoards
    {
        public List<List<int>> board1 = new List<List<int>>()
        {
                    new List<int>() { 1, 0, 2, 0, 3 },
                    new List<int>() { 0, 0, 4, 0, 5 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 2, 0, 3, 0 },
                    new List<int>() { 0, 1, 4, 5, 0 },
        };

        public List<List<int>> board2 = new List<List<int>>()
        {
                    new List<int>() { 1, 0, 0, 0, 4 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 3, 2, 0, 0 },
                    new List<int>() { 0, 0, 1, 0, 0 },
                    new List<int>() { 2, 3, 4, 0, 0 },
        };

        public List<List<int>> board3 = new List<List<int>>()
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

        List<List<int>> _boardBlank = new List<List<int>>()
            {
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 0, 0, 0, 0 },
                    new List<int>() { 0, 0, 0, 0, 0 },
            };
    }
}