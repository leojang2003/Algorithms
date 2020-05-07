using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LongestCommonSubsequenceLength
    {
        public int LCS(string[] input1, string[] input2)
        {
            var m = input1.Length;
            var n = input2.Length;

            if (m == 0 || n == 0)
                return 0;

            if(input1[m-1] == input1[n-1])
            {
                return LCS(input1.Take(m - 1).ToArray(), input2.Take(n - 1).ToArray()) + 1;
            }
            else
            {
                return Math.Max(LCS(input1.Take(m - 1).ToArray(), input2), LCS(input1.Take(m).ToArray(), input2.Take(n - 1).ToArray()));
            }
        }
    }
}
