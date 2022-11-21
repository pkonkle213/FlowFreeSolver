using System;
using System.Collections.Generic;
using System.Text;

namespace FlowFreeSolver.Models
{
    public class Answer
    {
        public List<List<int>> Board { get; set; }
        public bool IsSolvable { get; set; }
        public int Attempts { get; set; }
    }
}
