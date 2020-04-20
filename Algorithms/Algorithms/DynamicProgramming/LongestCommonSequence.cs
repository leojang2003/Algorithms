using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LongestCommonSequence
    {
        public string LCS(string[] input1, string[] input2)
        {
            var m = input1.Length;
            var n = input1.Length;

            if(input1[m-1] == input1[n-1])
            {
                return LCS(input1.Take(m - 1).ToArray(), input2.Take(n - 1).ToArray()) + input1[m - 1];
            }
            else
            {
                var sub1 = LCS(input1.Take(m - 1).ToArray(), input2);
                var sub2 = LCS(input1.Take(m).ToArray(), input2.Take(n-1).ToArray());
                return sub1.Length > sub2.Length ? sub1 : sub2;
            }
        }
    }
}
