using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LargestSquareSubmatrix1
    {
        public int Lookup(int[,] input)
        {
            // use Array.GetLength(dimension);
            var d = new int[input.GetLength(0) + 1, input.GetLength(1) + 1];
            var max = 0;
            for (int i = 1; i <= input.GetLength(1); i++)
            {
                for (int j = 1; j <= input.GetLength(0); j++)
                {
                    if (input[i - 1, j - 1] == 0)
                        d[i, j] = 0;
                    else if (d[i - 1, j - 1] > 0 && d[i - 1, j] > 0 && d[i, j - 1] > 0)
                        d[i, j] = d[i - 1, j - 1] + 1;
                    else
                        d[i, j] = 1;

                    max = d[i, j] > max ? d[i, j] : max;
                }
            }

            return max;
        }
    }
}
