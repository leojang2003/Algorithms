using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LongestCommonSequencePrintAll
    {
        public int[,] Lookup(string a, string b)
        {
            var lookup = new int[a.Length , b.Length];
            
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < b.Length; j++)
                {
                    if (a.Take(i + 1).ToString() != b.Take(j + 1).ToString())
                    {
                        if(i ==0 && j== 0)
                            lookup[i, j] = 0;
                        if (i == 0 && j != 0)
                            lookup[i, j] = lookup[i, j - 1];
                        else if (i != 0 && j == 0)
                            lookup[i, j] = lookup[i - 1, j];
                        else
                            lookup[i, j] = Math.Max(lookup[i, j - 1], lookup[i - 1, j]);
                    }                        
                    else
                    {
                        if (i == 0 && j == 0)
                            lookup[i, j] = 1;
                        if (i == 0 && j != 0)
                            lookup[i, j] = lookup[i, j - 1] + 1;
                        else if (i != 0 && j == 0)
                            lookup[i, j] = lookup[i - 1, j];
                        else
                            lookup[i, j] = Math.Max(lookup[i, j - 1], lookup[i - 1, j]);
                    }
                }
            }

            return lookup;
        }
    }
}
