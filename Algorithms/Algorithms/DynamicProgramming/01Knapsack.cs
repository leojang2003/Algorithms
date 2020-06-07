using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class _01Knapsack
    {
        //int[] sum = new int[6];

        public int Maximum(int[] value, int[] weight, int a, int threshold)
        {
            if (threshold <= 0 || a >= value.Length) return 0;

            var with = value[a] + Maximum(value, weight, a + 1, threshold - weight[a]);

            var without = Maximum(value, weight, a + 1, threshold);

            return Math.Max(with, without);

        }
    }
}
