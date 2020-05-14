using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LongestIncreasingSubsequence
    {
        public int LIS(int[] A, int i, int n, int previous)
        {
            if (i == n)
               return 0;

            int exc1 = LIS(A, i + 1, n, previous);

            int incl = 0;

            if (A[i] > previous)
                incl = 1 + LIS(A, i + 1, n, previous);

            return Math.Max(exc1, incl); 
        }
    }
}
