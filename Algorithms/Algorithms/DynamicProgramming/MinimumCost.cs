using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class MinimumCost
    {      
        public int Lookup(int[,] input)
        {
            // use Array.GetLength(dimension);
            var d = new int[input.GetLength(0) + 1, input.GetLength(1) + 1];
            
            for (int i = 1; i <= input.GetLength(1); i++)
            {
                for (int j = 1; j <= input.GetLength(0); j++)
                {
                    if (d[i - 1, j] < d[i, j-1])
                        d[i, j] = d[i-1,j] + input[i,j];
                    else if (d[i - 1, j] >= d[i, j - 1])
                        d[i, j] = d[i, j - 1] + input[i, j];                    
                }
            }

            return d[input.GetLength(0), input.GetLength(1)];
        }
    }
}
