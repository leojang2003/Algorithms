using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LargestSquareSubmatrix1
    {
        public int[,] Lookup(int[,] input)
        {
            // use Array.GetLength(dimension);
            var d = new int[input.GetLength(0) + 1, input.GetLength(1) + 1];

            for (int i = 0; i < d.Length; i++)
            {
                d[0, i] = 0;
                d[i, 0] = 0;
            }

            for (int i = 1; i <= input.GetLength(0); i++)
            {
                for (int j = 1; j <= input.GetLength(1); j++)
                {
                    if(input[i-1,j-1] == 1 && )
                }
            }

            return null;
        }
    }
}
